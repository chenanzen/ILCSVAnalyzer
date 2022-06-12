using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace ILCSVAnalyzer
{
    internal class CSVFIleAnalyzer
    {
        public List<CSVColumn> CSVColumns { get; set; }

        public DataTable ImportedDataTable { get; }

        public int NumOfWords { get; }
        public int NumOfLetters { get; }
        public int NumOfDates { get; }
        public int NumOfNumeric { get; }

        public List<string> Errors { get; set; }
        public bool ShowStopper { get; set; }

        public CSVFIleAnalyzer(string csvfullfilepath)
        {
            // Init
            CSVColumns = new List<CSVColumn>();

            Errors = new List<string>();
            ShowStopper = false;
            ImportedDataTable = new DataTable();
            NumOfWords = 0;
            NumOfLetters = 0;
            NumOfDates = 0;
            NumOfNumeric = 0;

            // read csv file
            var rowindex = 0;
            var temprows = new List<string[]>();
            char[] delimiters = new char[] { ' ', '\r', '\n' };
            try
            {
                using (var csvFileReader = new CSVFileReader(csvfullfilepath))
                {
                    // get header
                    var headers = csvFileReader.GetHeaders();
                    foreach (var header in headers)
                    {
                        CSVColumns.Add(new CSVColumn(header));  
                    }
                    rowindex += 1;

                    // read row by row
                    double tempDouble;
                    DateTime tempDateTime;

                    while (!csvFileReader.EndOfData())
                    {
                        var rowdata = csvFileReader.ReadLine();

                        if (rowdata.Length != CSVColumns.Count)
                        {
                            Errors.Add($"Row #{rowindex}: number of column does not match header.");
                            continue;
                        }
                        else
                        {
                            // find type if necessary
                            if (CSVColumns.Any(c => !c.TypeFound))
                            {
                                for (int i = 0; i < rowdata.Length; i++)
                                {
                                    var temp = rowdata[i];
                                    if (!CSVColumns[i].TypeFound)
                                    {
                                        if (double.TryParse(temp, out tempDouble))
                                        {
                                            CSVColumns[i].TypeFound = true;
                                            CSVColumns[i].ColumnType = typeof(double);
                                        }
                                        else if (DateTime.TryParse(temp, out tempDateTime))
                                        {
                                            CSVColumns[i].TypeFound = true;
                                            CSVColumns[i].ColumnType = typeof(DateTime);
                                        }
                                        else if (!string.IsNullOrWhiteSpace(temp))
                                        {
                                            CSVColumns[i].TypeFound = true;
                                            CSVColumns[i].ColumnType = typeof(string);
                                        }
                                    }
                                }
                            }

                            temprows.Add(rowdata);
                        }
                    }

                    // when all rows has been read, and all double and datetime field identified
                    // whats left are string
                    for (int i = 0; i < CSVColumns.Count; i++)
                    {
                        if (CSVColumns[i].TypeFound)
                        {
                            var col = new DataColumn($"col_{i}", CSVColumns[i].ColumnType);
                            ImportedDataTable.Columns.Add(col);
                        }
                        else
                        {
                            CSVColumns[i].TypeFound = true;
                            CSVColumns[i].ColumnType = typeof(string);
                            var col = new DataColumn($"col_{i}", typeof(string));
                            ImportedDataTable.Columns.Add(col);
                        }
                    }

                    // move cache rows into datatable
                    var rowIndex = 1;
                    foreach (var row in temprows)
                    {
                        var newrow = ImportedDataTable.NewRow();
                        for (int i = 0; i < CSVColumns.Count; i++)
                        {
                            if (CSVColumns[i].ColumnType == typeof(double))
                            {
                                if (double.TryParse(row[i], out tempDouble))
                                {
                                    NumOfNumeric++;
                                    newrow[i] = tempDouble;
                                }
                                else
                                {
                                    if (!string.IsNullOrWhiteSpace(row[i]))
                                    {
                                        Errors.Add($"Row #{rowIndex}: Invalid Double type data found at column {CSVColumns[i].HeaderName}.");
                                    }
                                }
                            }
                            else if (CSVColumns[i].ColumnType == typeof(DateTime))
                            {
                                if (DateTime.TryParse(row[i], out tempDateTime))
                                {
                                    NumOfDates++;
                                    newrow[i] = tempDateTime;
                                }
                                else
                                {
                                    if (!string.IsNullOrWhiteSpace(row[i]))
                                    {
                                        Errors.Add($"Row #{rowIndex}: Invalid DateTime type data found at column {CSVColumns[i].HeaderName}.");
                                    }
                                }
                            }
                            else
                            {
                                // treat as if string
                                var words = row[i].Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                                NumOfWords += words.Length;
                                NumOfLetters += words.Sum(w => w.Length);
                                newrow[i] = row[i];
                            }
                        }
                        ImportedDataTable.Rows.Add(newrow);

                        rowIndex++;
                    }
                }


            }
            catch (Exception ex)
            {
                ShowStopper = true;
                Errors.Add($"Exception while reading, row position #{rowindex}. Exception: {ex}");
            }
        }
    }
}

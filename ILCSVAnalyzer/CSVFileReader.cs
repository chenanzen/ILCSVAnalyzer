using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILCSVAnalyzer
{
    internal class CSVFileReader
    {
        private readonly TextFieldParser _csvReader;
        private readonly string[] _headers;

        public CSVFileReader(string filepath)
        {
            _csvReader = new TextFieldParser(filepath);
            _csvReader.SetDelimiters(new string[] { "," });
            _csvReader.HasFieldsEnclosedInQuotes = true;
        }

        private void Dispose()
        {
            _csvReader.Close();
            _csvReader.Dispose();
        }

        public string[] GetHeaders()
        {
            return _headers;
        }

        public Dictionary<string, string> ReadLine()
        {
            var result = new Dictionary<string, string>();
            var rowdata = _csvReader.ReadFields();
            for (int i = 0; i < _headers.Length; i++)
            {
                if (rowdata.Length >= i)
                    result.Add(_headers[i], rowdata[i]);
                else
                    result.Add(_headers[i], string.Empty);
            }

            return result;
        }

        public bool EndOfData()
        {
            return _csvReader.EndOfData;
        }
    }
}

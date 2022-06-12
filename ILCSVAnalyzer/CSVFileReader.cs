using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILCSVAnalyzer
{
    internal class CSVFileReader: IDisposable
    {
        private readonly TextFieldParser _csvReader;
        private readonly string[] _headers;

        public CSVFileReader(string filepath)
        {
            _csvReader = new TextFieldParser(filepath);
            _csvReader.SetDelimiters(new string[] { "," });
            _csvReader.HasFieldsEnclosedInQuotes = true;

            // first row is column name
            _headers = _csvReader.ReadFields();
        }

        public string[] GetHeaders()
        {
            return _headers;
        }

        public string[] ReadLine()
        {
            return _csvReader.ReadFields();
        }

        public bool EndOfData()
        {
            return _csvReader.EndOfData;
        }

        void IDisposable.Dispose()
        {
            _csvReader.Close();
            _csvReader.Dispose();
        }
    }
}

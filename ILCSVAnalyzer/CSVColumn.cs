using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILCSVAnalyzer
{
    internal class CSVColumn
    {
        public string HeaderName { get; set; }
        public bool TypeFound { get; set; }
        public Type ColumnType { get; set; }
        public List<string> RawContent { get; set; }

        public CSVColumn(string headerName)
        {
            HeaderName = headerName;
            TypeFound = false;
            ColumnType = null;
            RawContent = new List<string>();
        }
    }
}

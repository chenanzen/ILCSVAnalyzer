using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ILCSVAnalyzer
{
    public partial class MainForm : Form
    {
        private CSVFIleAnalyzer CsvFileAnalyzer { get; set; }
        private FormMessagePrompt MessagePrompt { get; set; }
        public MainForm()
        {
            InitializeComponent();
            MessagePrompt = new FormMessagePrompt();
        }

        private void LoadCSVButton_Click(object sender, EventArgs e)
        {
            var openCSVFileDialog = new OpenFileDialog()
            {
                InitialDirectory = @".",
                Title = "Select CSV File to Analyze",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "csv",
                Filter = "csv files (*.csv)|*.csv",
                FilterIndex = 2,
                RestoreDirectory = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true,
                Multiselect = false
            };

            if (openCSVFileDialog.ShowDialog() == DialogResult.OK)
            {
                CSVFileName.Text = openCSVFileDialog.FileName;

                CsvFileAnalyzer = new CSVFIleAnalyzer(openCSVFileDialog.FileName);
                if (CsvFileAnalyzer.ShowStopper)
                {
                    // stop process and show error
                    MessagePrompt.ShowDialog("Show Stopper Error", CsvFileAnalyzer.Errors);
                }
                else
                {
                    if (CsvFileAnalyzer.Errors.Any())
                    {
                        // show warning
                        MessagePrompt.ShowDialog("Warnings", CsvFileAnalyzer.Errors);
                    }

                    // clear datagrid
                    dataGridView1.DataSource = CsvFileAnalyzer.ImportedDataTable;
                    for(int i=0; i<CsvFileAnalyzer.CSVColumns.Count; i++)
                    {
                        dataGridView1.Columns[i].HeaderText = CsvFileAnalyzer.CSVColumns[i].HeaderName;
                    }
                    LabelNumOfWord.Text = $"{CsvFileAnalyzer.NumOfWords}";
                    LabelNumOfLetters.Text = $"{CsvFileAnalyzer.NumOfLetters}";
                    LabelNumOfNumeric.Text = $"{CsvFileAnalyzer.NumOfNumeric}";
                    LabelNumOfDateTime.Text = $"{CsvFileAnalyzer.NumOfDates}";

                }
            }
        }
    }
}

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
        public MainForm()
        {
            InitializeComponent();
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
            }
        }
    }
}

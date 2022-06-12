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
    public partial class FormMessagePrompt : Form
    {
        public FormMessagePrompt()
        {
            InitializeComponent();
        }

        public void ShowDialog(string title, IEnumerable<string> messages)
        {
            this.Text = title;
            var messageToDisplay = string.Empty;
            foreach(var message in messages)
            {
                messageToDisplay += message + Environment.NewLine;
            }

            textboxMessages.Text = messageToDisplay;
            this.ShowDialog();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

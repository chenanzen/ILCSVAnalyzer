namespace ILCSVAnalyzer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.CSVFileName = new System.Windows.Forms.TextBox();
            this.LoadCSVButton = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LabelNumOfWord = new System.Windows.Forms.Label();
            this.LabelNumOfLetters = new System.Windows.Forms.Label();
            this.LabelNumOfNumeric = new System.Windows.Forms.Label();
            this.LabelNumOfDateTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CSVFileName
            // 
            this.CSVFileName.Location = new System.Drawing.Point(278, 12);
            this.CSVFileName.Name = "CSVFileName";
            this.CSVFileName.Size = new System.Drawing.Size(600, 31);
            this.CSVFileName.TabIndex = 0;
            // 
            // LoadCSVButton
            // 
            this.LoadCSVButton.Location = new System.Drawing.Point(12, 12);
            this.LoadCSVButton.Name = "LoadCSVButton";
            this.LoadCSVButton.Size = new System.Drawing.Size(251, 40);
            this.LoadCSVButton.TabIndex = 1;
            this.LoadCSVButton.Text = "Choose a csv file";
            this.LoadCSVButton.UseVisualStyleBackColor = true;
            this.LoadCSVButton.Click += new System.EventHandler(this.LoadCSVButton_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 836);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 273);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1225, 551);
            this.dataGridView1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LabelNumOfDateTime);
            this.groupBox1.Controls.Add(this.LabelNumOfNumeric);
            this.groupBox1.Controls.Add(this.LabelNumOfLetters);
            this.groupBox1.Controls.Add(this.LabelNumOfWord);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1222, 150);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statistic";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Words";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of Letters";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(531, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of Numeric";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(531, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number of Date Time";
            // 
            // LabelNumOfWord
            // 
            this.LabelNumOfWord.AutoSize = true;
            this.LabelNumOfWord.Location = new System.Drawing.Point(230, 31);
            this.LabelNumOfWord.Name = "LabelNumOfWord";
            this.LabelNumOfWord.Size = new System.Drawing.Size(36, 25);
            this.LabelNumOfWord.TabIndex = 4;
            this.LabelNumOfWord.Text = "##";
            // 
            // LabelNumOfLetters
            // 
            this.LabelNumOfLetters.AutoSize = true;
            this.LabelNumOfLetters.Location = new System.Drawing.Point(230, 71);
            this.LabelNumOfLetters.Name = "LabelNumOfLetters";
            this.LabelNumOfLetters.Size = new System.Drawing.Size(36, 25);
            this.LabelNumOfLetters.TabIndex = 5;
            this.LabelNumOfLetters.Text = "##";
            // 
            // LabelNumOfNumeric
            // 
            this.LabelNumOfNumeric.AutoSize = true;
            this.LabelNumOfNumeric.Location = new System.Drawing.Point(772, 31);
            this.LabelNumOfNumeric.Name = "LabelNumOfNumeric";
            this.LabelNumOfNumeric.Size = new System.Drawing.Size(36, 25);
            this.LabelNumOfNumeric.TabIndex = 6;
            this.LabelNumOfNumeric.Text = "##";
            // 
            // LabelNumOfDateTime
            // 
            this.LabelNumOfDateTime.AutoSize = true;
            this.LabelNumOfDateTime.Location = new System.Drawing.Point(772, 71);
            this.LabelNumOfDateTime.Name = "LabelNumOfDateTime";
            this.LabelNumOfDateTime.Size = new System.Drawing.Size(36, 25);
            this.LabelNumOfDateTime.TabIndex = 7;
            this.LabelNumOfDateTime.Text = "##";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 836);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.LoadCSVButton);
            this.Controls.Add(this.CSVFileName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Illumina CSV Analyzer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CSVFileName;
        private System.Windows.Forms.Button LoadCSVButton;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LabelNumOfDateTime;
        private System.Windows.Forms.Label LabelNumOfNumeric;
        private System.Windows.Forms.Label LabelNumOfLetters;
        private System.Windows.Forms.Label LabelNumOfWord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}


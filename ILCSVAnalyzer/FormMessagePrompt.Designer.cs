namespace ILCSVAnalyzer
{
    partial class FormMessagePrompt
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
            this.textboxMessages = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textboxMessages
            // 
            this.textboxMessages.Location = new System.Drawing.Point(13, 13);
            this.textboxMessages.Multiline = true;
            this.textboxMessages.Name = "textboxMessages";
            this.textboxMessages.ReadOnly = true;
            this.textboxMessages.Size = new System.Drawing.Size(1014, 529);
            this.textboxMessages.TabIndex = 0;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(383, 600);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(169, 38);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // FormMessagePrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 650);
            this.ControlBox = false;
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.textboxMessages);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMessagePrompt";
            this.Text = "FormMessagePrompt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxMessages;
        private System.Windows.Forms.Button buttonClose;
    }
}
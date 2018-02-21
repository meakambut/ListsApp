namespace ListsApp
{
    partial class fBooksSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbBooksPerYear = new System.Windows.Forms.TextBox();
            this.btnCloseBooksSettings = new System.Windows.Forms.Button();
            this.btnSaveNewAmountOfBooksPerYear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Books per year: ";
            // 
            // tbBooksPerYear
            // 
            this.tbBooksPerYear.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbBooksPerYear.Location = new System.Drawing.Point(141, 20);
            this.tbBooksPerYear.Name = "tbBooksPerYear";
            this.tbBooksPerYear.Size = new System.Drawing.Size(69, 26);
            this.tbBooksPerYear.TabIndex = 1;
            // 
            // btnCloseBooksSettings
            // 
            this.btnCloseBooksSettings.Location = new System.Drawing.Point(366, 662);
            this.btnCloseBooksSettings.Name = "btnCloseBooksSettings";
            this.btnCloseBooksSettings.Size = new System.Drawing.Size(75, 29);
            this.btnCloseBooksSettings.TabIndex = 2;
            this.btnCloseBooksSettings.Text = "Close";
            this.btnCloseBooksSettings.UseVisualStyleBackColor = true;
            this.btnCloseBooksSettings.Click += new System.EventHandler(this.btnCloseBooksSettings_Click);
            // 
            // btnSaveNewAmountOfBooksPerYear
            // 
            this.btnSaveNewAmountOfBooksPerYear.Location = new System.Drawing.Point(240, 16);
            this.btnSaveNewAmountOfBooksPerYear.Name = "btnSaveNewAmountOfBooksPerYear";
            this.btnSaveNewAmountOfBooksPerYear.Size = new System.Drawing.Size(68, 34);
            this.btnSaveNewAmountOfBooksPerYear.TabIndex = 3;
            this.btnSaveNewAmountOfBooksPerYear.Text = "Save";
            this.btnSaveNewAmountOfBooksPerYear.UseVisualStyleBackColor = true;
            this.btnSaveNewAmountOfBooksPerYear.Click += new System.EventHandler(this.btnSaveNewAmountOfBooksPerYear_Click);
            // 
            // fBooksSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 697);
            this.ControlBox = false;
            this.Controls.Add(this.btnSaveNewAmountOfBooksPerYear);
            this.Controls.Add(this.btnCloseBooksSettings);
            this.Controls.Add(this.tbBooksPerYear);
            this.Controls.Add(this.label1);
            this.Name = "fBooksSettings";
            this.Text = "Books settings";
            this.Load += new System.EventHandler(this.fBooksSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBooksPerYear;
        private System.Windows.Forms.Button btnCloseBooksSettings;
        private System.Windows.Forms.Button btnSaveNewAmountOfBooksPerYear;
    }
}
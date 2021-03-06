﻿namespace ListsApp
{
    partial class fBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fBooks));
            this.btnAddBook = new System.Windows.Forms.Button();
            this.lbBooks = new System.Windows.Forms.ListBox();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.tbNewBook = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnBooksSettings = new System.Windows.Forms.Button();
            this.lblLeftBooks = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddBook
            // 
            this.btnAddBook.Font = new System.Drawing.Font("Segoe Print", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddBook.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnAddBook.Location = new System.Drawing.Point(65, 470);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(121, 63);
            this.btnAddBook.TabIndex = 0;
            this.btnAddBook.Text = "Add";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // lbBooks
            // 
            this.lbBooks.BackColor = System.Drawing.Color.LavenderBlush;
            this.lbBooks.FormattingEnabled = true;
            this.lbBooks.ItemHeight = 20;
            this.lbBooks.Location = new System.Drawing.Point(12, 75);
            this.lbBooks.Name = "lbBooks";
            this.lbBooks.Size = new System.Drawing.Size(424, 304);
            this.lbBooks.TabIndex = 1;
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Font = new System.Drawing.Font("Segoe Print", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteBook.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnDeleteBook.Location = new System.Drawing.Point(237, 470);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(137, 63);
            this.btnDeleteBook.TabIndex = 2;
            this.btnDeleteBook.Text = "Delete";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // tbNewBook
            // 
            this.tbNewBook.Location = new System.Drawing.Point(12, 408);
            this.tbNewBook.Name = "tbNewBook";
            this.tbNewBook.Size = new System.Drawing.Size(424, 26);
            this.tbNewBook.TabIndex = 3;
            this.tbNewBook.TextChanged += new System.EventHandler(this.tbNewBook_TextChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(361, 650);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 35);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBooksSettings
            // 
            this.btnBooksSettings.Location = new System.Drawing.Point(12, 650);
            this.btnBooksSettings.Name = "btnBooksSettings";
            this.btnBooksSettings.Size = new System.Drawing.Size(78, 35);
            this.btnBooksSettings.TabIndex = 5;
            this.btnBooksSettings.Text = "Settings";
            this.btnBooksSettings.UseVisualStyleBackColor = true;
            this.btnBooksSettings.Click += new System.EventHandler(this.btnBooksSettings_Click);
            // 
            // lblLeftBooks
            // 
            this.lblLeftBooks.AutoSize = true;
            this.lblLeftBooks.BackColor = System.Drawing.Color.FloralWhite;
            this.lblLeftBooks.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLeftBooks.ForeColor = System.Drawing.Color.Indigo;
            this.lblLeftBooks.Image = global::ListsApp.Properties.Resources.Backgrounds_Blue_and_pink_background_035585_;
            this.lblLeftBooks.Location = new System.Drawing.Point(12, 25);
            this.lblLeftBooks.Name = "lblLeftBooks";
            this.lblLeftBooks.Size = new System.Drawing.Size(365, 31);
            this.lblLeftBooks.TabIndex = 8;
            this.lblLeftBooks.Text = "You have n books left to read this year";
            // 
            // fBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ListsApp.Properties.Resources.Backgrounds_Blue_and_pink_background_035585_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(453, 697);
            this.ControlBox = false;
            this.Controls.Add(this.lblLeftBooks);
            this.Controls.Add(this.btnBooksSettings);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbNewBook);
            this.Controls.Add(this.btnDeleteBook);
            this.Controls.Add(this.lbBooks);
            this.Controls.Add(this.btnAddBook);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fBooks";
            this.Text = "Books";
            this.Load += new System.EventHandler(this.fBooks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.ListBox lbBooks;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.TextBox tbNewBook;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnBooksSettings;
        private System.Windows.Forms.Label lblLeftBooks;
    }
}
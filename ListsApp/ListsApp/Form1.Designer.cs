namespace ListsApp
{
    partial class fMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.btnBooks = new System.Windows.Forms.Button();
            this.btnFilms = new System.Windows.Forms.Button();
            this.btnTVseries = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBooks
            // 
            this.btnBooks.Font = new System.Drawing.Font("Segoe Print", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBooks.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnBooks.Location = new System.Drawing.Point(132, 73);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(197, 87);
            this.btnBooks.TabIndex = 0;
            this.btnBooks.Text = "Books";
            this.btnBooks.UseVisualStyleBackColor = true;
            this.btnBooks.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFilms
            // 
            this.btnFilms.Font = new System.Drawing.Font("Segoe Print", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFilms.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnFilms.Location = new System.Drawing.Point(132, 198);
            this.btnFilms.Name = "btnFilms";
            this.btnFilms.Size = new System.Drawing.Size(197, 87);
            this.btnFilms.TabIndex = 1;
            this.btnFilms.Text = "Films";
            this.btnFilms.UseVisualStyleBackColor = true;
            this.btnFilms.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnTVseries
            // 
            this.btnTVseries.Font = new System.Drawing.Font("Segoe Print", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTVseries.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnTVseries.Location = new System.Drawing.Point(132, 325);
            this.btnTVseries.Name = "btnTVseries";
            this.btnTVseries.Size = new System.Drawing.Size(197, 87);
            this.btnTVseries.TabIndex = 2;
            this.btnTVseries.Text = "TV series";
            this.btnTVseries.UseVisualStyleBackColor = true;
            this.btnTVseries.Click += new System.EventHandler(this.button3_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::ListsApp.Properties.Resources.Backgrounds_Blue_and_pink_background_035585_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(453, 697);
            this.Controls.Add(this.btnTVseries);
            this.Controls.Add(this.btnFilms);
            this.Controls.Add(this.btnBooks);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fMain";
            this.Text = "Lists 2018";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Button btnFilms;
        private System.Windows.Forms.Button btnTVseries;
    }
}


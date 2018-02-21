using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;

namespace ListsApp
{
    public partial class fBooks : Form
    {
        fBooksSettings fbs = new fBooksSettings();
        void OpenBooks()
        {
            try
            {
                StreamReader file = new StreamReader("Books.rtf");
                string s;
                while (!file.EndOfStream)
                {
                    s = file.ReadLine();
                    lbBooks.Items.Add(s);
                }
                file.Close();
                lbBooks.Show();
            }
            catch
            {
                MessageBox.Show("error opening file\r\n");
            }
        }
        public fBooks()
        {
            InitializeComponent();
        }

        private void fBooks_Load(object sender, EventArgs e)
        {
            BooksSettings.GetSettings();
            lblLeftBooks.Text = "You have " + Convert.ToString(BooksSettings.BooksLeftPerYear) + " books left to read this year";
            lblLeftBooks.Show();
            OpenBooks();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            string s;
            s = "• " + tbNewBook.Text.ToString();
            lbBooks.Items.Add(s); 
            StreamWriter file = File.AppendText("Books.rtf");
            file.WriteLine(s);
            file.Close();  
            tbNewBook.Clear();
            BooksSettings.BooksLeftPerYear--;
            BooksSettings.SaveSettings();
            lblLeftBooks.Text = "You have " + Convert.ToString(BooksSettings.BooksLeftPerYear) + " books left to read this year";
            lblLeftBooks.Show();
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (lbBooks.SelectedItem != null)
            {
                lbBooks.Items.Remove(lbBooks.SelectedItem);
                BooksSettings.BooksLeftPerYear++;
                string s;
                File.WriteAllText("Books.rtf", "");
                StreamWriter file = File.AppendText("Books.rtf");
                for (int i = 0; i < lbBooks.Items.Count; i++)
                {
                    s = Convert.ToString(lbBooks.Items[i]);
                    file.WriteLine(s);
                }
                file.Close();

                BooksSettings.SaveSettings();
                lblLeftBooks.Text = "You have " + Convert.ToString(BooksSettings.BooksLeftPerYear) + " books left to read this year";
                lblLeftBooks.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbBooks.Items.Clear();
            this.Close();
        }

        private void btnBooksSettings_Click(object sender, EventArgs e)
        {
            fbs.ShowDialog();
        }

        private void tbNewBook_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

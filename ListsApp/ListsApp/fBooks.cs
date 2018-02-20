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
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            lbBooks.Items.Remove(lbBooks.SelectedItem);
            string s;
            File.WriteAllText("Books.rtf","");
            StreamWriter file = File.AppendText("Books.rtf");
            for (int i=0;i<lbBooks.Items.Count;i++)
            {
                s = Convert.ToString(lbBooks.Items[i]);
                file.WriteLine(s);
            }
            file.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbBooks.Items.Clear();
            this.Close();
        }
    }
}

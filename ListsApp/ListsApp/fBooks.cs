using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListsApp
{
    public partial class fBooks : Form
    {

        void OpenBooks()
        {
            try
            {
                rtb.LoadFile("Books.rtf");
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
            //rtb.LoadFile("Books.rtf");
            lbBooks.Text = rtb.Text;
            rtb.Show();
            lbBooks.Show();
            //if (lbBooks.Items.Count != 0)
                
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            string s;
            s = "• " + tbNewBook.Text.ToString();
            lbBooks.Items.Add(s);
            rtb.Text += s+"\r\n";
            rtb.SaveFile("Books.rtf");
            tbNewBook.Clear(); 


        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            lbBooks.Items.Remove(lbBooks.SelectedItem);
        }
    }
}

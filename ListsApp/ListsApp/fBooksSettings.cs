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
    public partial class fBooksSettings : Form
    {
        public fBooksSettings()
        {
            InitializeComponent();
        }

        private void btnCloseBooksSettings_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void fBooksSettings_Load(object sender, EventArgs e)
        {
            
            tbBooksPerYear.Text = Convert.ToString(BooksSettings.BooksPerYear);
        }

        private void btnSaveNewAmountOfBooksPerYear_Click(object sender, EventArgs e)
        {
            BooksSettings.BooksLeftPerYear += Convert.ToInt32(tbBooksPerYear.Text) - BooksSettings.BooksPerYear;
            BooksSettings.BooksPerYear = Convert.ToInt32(tbBooksPerYear.Text);
            BooksSettings.SaveSettings();
            this.Close();
        }
    }
}

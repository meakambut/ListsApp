using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace ListsApp
{
    public class BooksSettings
    {
        public static int BooksPerYear = 0;
        public static int BooksLeftPerYear = BooksPerYear;

        static string RegKeyName = "Software\\meakambut\\ListsApp";

        public static void SaveSettings()
        {
            RegistryKey rk = null;

            try
            {
                rk = Registry.CurrentUser.CreateSubKey(RegKeyName);
                if (rk == null) return;
                rk.SetValue("BooksPerYear", BooksPerYear);
                rk.SetValue("BooksLeftPerYear", BooksLeftPerYear);
            }

            finally
            {
                if (rk != null) rk.Close();
            }
        }

        public static void GetSettings()
        {
            RegistryKey rk = null;

            try
            {
                rk = Registry.CurrentUser.OpenSubKey(RegKeyName);
                if (rk != null)
                {
                    BooksPerYear = (int)rk.GetValue("BooksPerYear");
                    BooksLeftPerYear = (int)rk.GetValue("BooksLeftPerYear");
                }
            }

            finally
            {
                if (rk != null) rk.Close();
            }
        }
    }
}

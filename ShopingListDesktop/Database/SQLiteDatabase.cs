using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using ShopingListDesktop.Model;
using System.Windows;

namespace ShopingListDesktop.Database
{
    public class SqLiteDatabase
    {
        SQLiteConnection dbConnection;
        public async Task<bool> onCreate(string dbPath)
        {
            try
            {
                if(!CheckFileExists(dbPath).Result)
                {
                   // using (dbConnection = new SQLiteConnection(dbPath))
                       // dbConnection
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> CheckFileExists(string fileName)
        {
            try
            {
                    return true; 
            }
            catch
            {
                return false;
            }
        }
    }
}

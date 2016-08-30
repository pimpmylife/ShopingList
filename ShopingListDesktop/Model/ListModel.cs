using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopingListDesktop.Model
{
    public class ListModel
    {
        [SQLite.PrimaryKey, SQLite.AutoIncrement]
        public int id {set; get; }
        public string name { set; get; }
    }
}

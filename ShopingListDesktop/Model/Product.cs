using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopingListDesktop.Model
{
    public class Product
    {
       public int id { set; get; }
       public string name { set; get; }
       public string size { set; get; }
       public bool isInBasket { set; get; }
    }
}

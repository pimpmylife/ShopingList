using ShopingListDesktop.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ShopingListDesktop.ModelView
{
   public class ProductEditView : INotifyPropertyChanged
    {
        private string name;
        private bool check;
        private string size;
        public ProductEditView(Product product)
        {
            name = product.name;
            size = product.size;
            check = product.isInBasket;
        }

        public string nameProduct
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("nameProduct");
            }
        }

        
              public string sizeProduct
        {
            get { return size; }
            set
            {
                size = value;
                OnPropertyChanged("sizeProduct");
            }
        }

        public bool checkedValue
        {
            get { return check; }
            set
            {
                check = value;
                OnPropertyChanged("checkedValue");
            }
        }
        public ICommand Edit { get { return new RelayCommand(EditMe); } }

        private void EditMe()
        {
            //TODO edytuj wartosci i laduj to bazy danych 
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}

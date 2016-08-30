using ShopingListDesktop.Model;
using ShopingListDesktop.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ShopingListDesktop.ModelView
{
    public class ShopingListView : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<Product> products;
        private int jajka;
        public ShopingListView()
        {
            products = new ObservableCollection<Product>();
            Product a = new Product();
            a.isInBasket = false;
            a.name = "marchew";
            a.size = "2 kg";
            products.Add(a);
            jajka = -1;
        }
        public ObservableCollection<Product> Products
        {
            get { return products; }
            set
            {
                products = value;
                OnPropertyChanged("Products");
            }

        }


        public int SelectedProduct
        {
            get { return jajka; }
            set
            {
                jajka = value;
                OnPropertyChanged("SelectedProduct");
            }
        }
        public ICommand NewProduct
        {
            get { return new RelayCommand(AddProductToList); }
        }
        public ICommand DeleteProduct
        {
            get { return new RelayCommand(DeleteProductFromList, ProductIsSelected); }
        }

        private bool ProductIsSelected()
        {
            if (SelectedProduct > -1)
                return true;
            else
                return false;
        }

        private void DeleteProductFromList()
        {
            MessageBox.Show("Usunieto wybrany produkt"); 
            //TODO usunac produkt
        }

        private void AddProductToList()
        {
            AddProduct win = new AddProduct();
            win.Show();
        }

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

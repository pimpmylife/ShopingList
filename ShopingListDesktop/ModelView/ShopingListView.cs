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
        private Product item;
        private int jajka;
        private string name;
        public ShopingListView(string productName)
        {
            item = new Product();
            name = productName;
            products = new ObservableCollection<Product>();
            Product a = new Product();
            a.isInBasket = true;
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
        public Product SelectedItemProduct
        {
            get { return item; }
            set
            {
                item = value;
                OnPropertyChanged("SelectedItemProduct");
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
        public ICommand EditProduct
        {
            get { return new RelayCommand(EditProductFromList, ProductIsSelected); }
        }

        private void EditProductFromList()
        {
            ProductEdit win = new ProductEdit(item);
            win.Show();
        }
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
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
            //TODO usunac produkt z bazy danych 
        }

        private void AddProductToList()
        {
            AddProduct win = new AddProduct();
            win.Show();
        }

        public ICommand DeleteList
        {
            get { return new RelayCommand(DeleteSelectedList); }
        }

        private void DeleteSelectedList()
        {
            if(products.Count == 0 )
            {
                //TODO delte list
            }
            else
            {
                MessageBox.Show("Lista musi być pusta by ją usunąć, usun wszystkie jej elementy");
            }
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

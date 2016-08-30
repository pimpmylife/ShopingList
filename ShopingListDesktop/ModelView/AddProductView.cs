using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ShopingListDesktop.ModelView
{
    public class AddProductView : INotifyPropertyChanged
    {
        private string name;
        private string size;
        public AddProductView()
        {
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
        public string Size
        {
            get { return size; }
            set
            {
                size = value;
                OnPropertyChanged("Size");
            }
        }
        public ICommand Add
        {
            get { return new RelayCommand(AddProductToDatabase); }

        }

        private void AddProductToDatabase()
        {
            //TODO dodanie produkut do bazy danych 
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

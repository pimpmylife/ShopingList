using ShopingListDesktop.Model;
using ShopingListDesktop.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ShopingListDesktop.ModelView
{
    class MainWindowView : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<ListModel> listy;

        public MainWindowView()
        {
            
            listy = new ObservableCollection<ListModel>();
            ListModel a = new ListModel();
            a.id = 1;
            a.name = "Lista numer 1";
            listy.Add(a);

        }

        private void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if(handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
        public ICommand AddList { get { return new RelayCommand(NewList); }  }

      
        public void NewList()
        {
            ListAdd w = new ListAdd();
            w.Show();
        }
        public ObservableCollection<ListModel> Add
        {
            get { return listy; }
            set
            {
                listy = value;
                OnPropertyChanged("Add");
            }
        }
        public ListModel ShowList
        {
            get { return null; }
            set
            {
                OnPropertyChanged("ShowList");
                ShopingList win = new ShopingList();
                win.Show();
               
            }
        }
    }
}

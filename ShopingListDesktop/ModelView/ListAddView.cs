using ShopingListDesktop.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ShopingListDesktop.ModelView
{
    public class ListAddView: INotifyPropertyChanged
    {
        private string nameList;
        public event PropertyChangedEventHandler PropertyChanged;

        public ListAddView()
        { }
        private void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        public string NameList
        {
            get { return nameList; }
            set
            {
                nameList = value;
                OnPropertyChanged("NameList");
            }
        }

        public ICommand CloseCommand
        {
            get
            {
                return new RelayCommand (Add); 
            }
        }

        public void Add()
        {
            MessageBox.Show(nameList,NameList);
            if (NameList!= "" && NameList !=null)
            {
                MessageBox.Show("Dodales nowa nazwe listy"); 
                //TODO dodanie nazwy listy do bazy danych
            }
            else
            {
                MessageBox.Show("Podaj nazwę listy","Error");
            }
        }
        public Action CloseAction
        {
            //TODO chec zamkniecia okna od razu po dodaniu listy
            get;
            set;
        }
    }
}

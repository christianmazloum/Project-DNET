using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp.AppService;

namespace WpfApp
{
    public class MyViewModel : ViewModelBase
    {        

        public MyViewModel()
        {
            action();
            MyCommand = new RelayCommand(action, canExecute);
            this.ValueLabel = "Hello Label";
        }

        private string _valueLabel;

        public string ValueLabel
        {
            get
            {
                return _valueLabel;
            }

            set
            {
                if (_valueLabel == value) return;
                _valueLabel = value;
                RaisePropertyChanged("ValueLabel");
            }
        }

        public ICommand MyCommand
        {
            get; set;
        }

        private void action()
        {
            Service1Client client = new Service1Client();

            //ProductModel product = new ProductModel();
            //product.Name = 

            int id = 4;

            ProductModel category = client.GetProduct(id);

            this.ValueLabel = (category.Name);
        }

        private bool canExecute()
        {
            return (this.ValueLabel != " Clicked");
        }
    }
} 

using CefSharp.Wpf;
using menu.Models;
using menu.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace menu.ViewModel.Maps
{
   internal class MainWindowsViewModel :BaseViewModel
    {
        ChromiumWebBrowser webBrowser = new ModelBrowser().ChromiumModel();
        public MainWindowsViewModel()
        {

            _Chromium.Add(webBrowser);
            GetCommand = new Control.LambdaCommand(OnGetCommandExecute, CanGetCommandExecute);

        }
        private ObservableCollection<ChromiumWebBrowser> _Chromium = new ObservableCollection<ChromiumWebBrowser>();

        public ObservableCollection<ChromiumWebBrowser> Chromium
        {
            get { return _Chromium; }
            private set
            {
                if (value == _Chromium) return;
                _Chromium = value;
                OnPropertyChanged("Chromium");
            }
        }



        //public ChromiumWebBrowser Data { get=> new ChromiumWebBrowser("https://www.google.ru/maps/dir/45.1301107,38.985355/45.1270224,39.0233779/@45.1130018,39.0062976,14z/data=!4m2!4m1!3e3");}
        public ICommand GetCommand { get; }

        private bool CanGetCommandExecute(object param) => true;
        private void OnGetCommandExecute(object param)
        {

            MessageBox.Show(webBrowser.Address);
        }
    }
}

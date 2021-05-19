using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using menu.ViewModel.Base;
namespace menu.ViewModel.Menu
{
   public class ViewModelMenu: BaseViewModel
    {
        public ViewModelMenu()
        {
            Close = new Control.LambdaCommand(OnGetCommandExecuteClose, CanGetCommandExecuteClose);

          
        }

        public ICommand Close { get; }
        private bool CanGetCommandExecuteClose(object param) => true;
        private void OnGetCommandExecuteClose(object param) => Application.Current.Shutdown();
      
    }

}

using menu.Models;
using menu.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu.ViewModel.WorkKassaModul
{
    class MainWindowViewModelKassa: BaseViewModel
    {
      
            public MainWindowViewModelKassa()
            {


            }
            private ObservableCollection<ClassElements> res = new ObservableCollection<ClassElements>();
            public List<ClassElements> Name
            {
                get => res.Select(x => x).ToList<ClassElements>();
            }
        ~MainWindowViewModelKassa() { }
        }
    
}

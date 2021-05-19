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
            res = new ObservableCollection<ClassElements>();

            res.Add(new ClassElements { id=1, ImagePath= @"C:\Users\Roma\Desktop\Настя\New\NewProject\menu\Image\1.png", Name="Груз 1", Price="1000 руб/км"  });
            res.Add(new ClassElements { id = 2, ImagePath = @"C:\Users\Roma\Desktop\Настя\New\NewProject\menu\Image\2.png", Name = "Груз 2", Price = "1500 руб/км" });
            res.Add(new ClassElements { id = 3, ImagePath = @"C:\Users\Roma\Desktop\Настя\New\NewProject\menu\Image\3.png", Name = "Груз 3", Price = "1200 руб/км" });
            res.Add(new ClassElements { id = 4, ImagePath = @"C:\Users\Roma\Desktop\Настя\New\NewProject\menu\Image\1.png", Name = "Груз 4", Price = "1100 руб/км" });
            res.Add(new ClassElements { id = 5, ImagePath = @"C:\Users\Roma\Desktop\Настя\New\NewProject\menu\Image\2.png", Name = "Груз 5", Price = "1600 руб/км" });
            res.Add(new ClassElements { id = 6, ImagePath = @"C:\Users\Roma\Desktop\Настя\New\NewProject\menu\Image\3.png", Name = "Груз 6", Price = "1300 руб/км" });
            res.Add(new ClassElements { id = 7, ImagePath = @"C:\Users\Roma\Desktop\Настя\New\NewProject\menu\Image\1.png", Name = "Груз 7", Price = "1900 руб/км" });
            res.Add(new ClassElements { id = 8, ImagePath = @"C:\Users\Roma\Desktop\Настя\New\NewProject\menu\Image\2.png", Name = "Груз 8", Price = "1600 руб/км" });
            res.Add(new ClassElements { id = 9, ImagePath = @"C:\Users\Roma\Desktop\Настя\New\NewProject\menu\Image\3.png", Name = "Груз 9", Price = "1000 руб/км" });
            res.Add(new ClassElements { id = 10, ImagePath = @"C:\Users\Roma\Desktop\Настя\New\NewProject\menu\Image\3.png", Name = "Груз 10", Price = "1300 руб/км" });
            res.Add(new ClassElements { id = 11, ImagePath = @"C:\Users\Roma\Desktop\Настя\New\NewProject\menu\Image\1.png", Name = "Груз 11", Price = "1900 руб/км" });
            res.Add(new ClassElements { id = 12, ImagePath = @"C:\Users\Roma\Desktop\Настя\New\NewProject\menu\Image\2.png", Name = "Груз 12", Price = "1600 руб/км" });
            res.Add(new ClassElements { id = 13, ImagePath = @"C:\Users\Roma\Desktop\Настя\New\NewProject\menu\Image\3.png", Name = "Груз 13", Price = "1000 руб/км" });

              }
         public ObservableCollection<ClassElements> res { get; set; }
            public ObservableCollection<ClassElements> Name
            {
                get => res;
            }
        }
    
}

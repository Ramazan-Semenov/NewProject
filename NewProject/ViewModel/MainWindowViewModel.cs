using NewProject.WorkKassaModul.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject.WorkKassaModul.ViewModel
{
    class MainWindowViewModel
    {
        public MainWindowViewModel()
        {
            res.Add(new ClassElements { id = 1, Name = "Name", Price = "100", ImagePath = @"C:\Users\Roma\Desktop\Image\img5.jpg" });
            res.Add(new ClassElements { id = 2, Name = "Name", Price = "100", ImagePath = @"C:\Users\Roma\Desktop\Image\img4.jpg" });
            res.Add(new ClassElements { id = 3, Name = "Name", Price = "100", ImagePath = @"C:\Users\Roma\Desktop\Image\img3.jpg" });
            res.Add(new ClassElements { id = 4, Name = "Name", Price = "100", ImagePath = @"C:\Users\Roma\Desktop\Image\img2.jpg" });
            res.Add(new ClassElements { id = 5, Name = "Name", Price = "100", ImagePath = @"C:\Users\Roma\Desktop\Image\img5.jpg" });
            res.Add(new ClassElements { id = 6, Name = "Name", Price = "100", ImagePath = @"C:\Users\Roma\Desktop\Image\img5.jpg" });
            res.Add(new ClassElements { id = 6, Name = "Name", Price = "100", ImagePath = @"C:\Users\Roma\Desktop\Image\img5.jpg" });
            res.Add(new ClassElements { id = 6, Name = "Name", Price = "100", ImagePath = @"C:\Users\Roma\Desktop\Image\img5.jpg" });
            res.Add(new ClassElements { id = 6, Name = "Name", Price = "100", ImagePath = @"C:\Users\Roma\Desktop\Image\img5.jpg" });
            res.Add(new ClassElements { id = 6, Name = "Name", Price = "100", ImagePath = @"C:\Users\Roma\Desktop\Image\img5.jpg" });
            res.Add(new ClassElements { id = 6, Name = "Name", Price = "100", ImagePath = @"C:\Users\Roma\Desktop\Image\img5.jpg" });
            res.Add(new ClassElements { id = 6, Name = "Name", Price = "100", ImagePath = @"C:\Users\Roma\Desktop\Image\img5.jpg" });
            res.Add(new ClassElements { id = 6, Name = "Name", Price = "100", ImagePath = @"C:\Users\Roma\Desktop\Image\img5.jpg" });
            res.Add(new ClassElements { id = 6, Name = "Name", Price = "100", ImagePath = @"C:\Users\Roma\Desktop\Image\img5.jpg" });
            res.Add(new ClassElements { id = 6, Name = "sfgdsfg", Price = "100", ImagePath = @"C:\Users\Roma\Desktop\Image\img5.jpg" });


        }
        private  ObservableCollection<ClassElements> res = new ObservableCollection<ClassElements>();
        public List<ClassElements> Name
        {
            get => res.Select(x => x).ToList<ClassElements>();
        } 



    }
}

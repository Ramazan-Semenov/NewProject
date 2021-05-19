using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu.Models
{
    public class ClassElements
    {
        public ClassElements()
        {
        }
        public ClassElements (ObservableCollection<ClassElements> elements)
        {
       
        }

        public int id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string ImagePath { get; set; }

    }
}

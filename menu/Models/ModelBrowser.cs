using System;
using CefSharp;
using CefSharp.Wpf;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu.Models
{
    class ModelBrowser
    {
       readonly CefSettings settings;
        public ModelBrowser()
        {
            settings = new CefSettings();
           // Cef.Initialize(settings);
        }
        public ChromiumWebBrowser ChromiumModel()
        {

            return new ChromiumWebBrowser("https://www.google.ru/maps/dir/45.1301107,38.985355/45.1270224,39.0233779/@45.1130018,39.0062976,14z/data=!4m2!4m1!3e3")
            { Width = 2000, Height = 1500 };
        }
    }
}

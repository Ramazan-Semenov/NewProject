using CefSharp;
using CefSharp.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject.WPFMaps.Models
{
    class ModelBrowser
    {
        public ModelBrowser()
        {
            CefSettings settings = new CefSettings();
            Cef.Initialize(settings);
        }
        public ChromiumWebBrowser ChromiumModel()
        {

            return new ChromiumWebBrowser("https://www.google.ru/maps/dir/45.1301107,38.985355/45.1270224,39.0233779/@45.1130018,39.0062976,14z/data=!4m2!4m1!3e3") 
            { Width = 800, Height = 600 };
        }
    }
}

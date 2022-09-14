using MVVMApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMApp.Model
{
    public class Contlist:ViewModelbase
    {

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged("Name"); }
        }
        private string mobile;

        public string Mobile
        {
            get { return mobile; }
            set { mobile = value; OnPropertyChanged("Mobile"); }
        }
        
        private string image;

        public string Image
        {
            get { return image; }
            set { image = value; OnPropertyChanged("Image"); }
        }
        private string frdMobile;

        public string FrdMobile
        {
            get { return frdMobile; }
            set { frdMobile = value; OnPropertyChanged("FrdMobile"); }
        }
    }
}

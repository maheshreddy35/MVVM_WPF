using MVVMApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMApp.Model
{
    public class login:ViewModelbase
    {
        private string mobile;

        public string Mobile
        {
            get { return mobile; }
            set { mobile = value; OnPropertyChanged("Mobile"); }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; OnPropertyChanged("Password"); }
        }
    }
}

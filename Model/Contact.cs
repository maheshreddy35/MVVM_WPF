using MVVMApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMApp.Model
{
    public class Contact: ViewModelbase
    {

        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; OnPropertyChanged("FirstName"); }
        }
        private string mobile;

        public string Mobile
        {
            get { return mobile; }
            set { mobile = value; OnPropertyChanged("Mobile"); }
        }
        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; OnPropertyChanged("LastName"); }
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

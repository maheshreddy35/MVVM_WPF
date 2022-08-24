using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMApp.Model;
namespace MVVMApp.ViewModel
{
    public class UserViewModel:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }

        }
        private List<User> userlist;
        public List<User> Userlist
        {
            get { return userlist; }
            set { userlist = value;OnPropertyChanged("Userlist"); }
        }

        UserService user;
        
        public UserViewModel()
        {
             user = new UserService();
            LoadData();
        }
        private void LoadData()
        {
            Userlist = user.GetUsers();
        }

    }
}

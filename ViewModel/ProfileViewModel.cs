using MVVMApp.Commands;
using MVVMApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMApp.ViewModel
{
    class ProfileViewModel:ViewModelbase
    {
        private User currentuser;

        public User Currentuser
        {
            get { return currentuser; }
            set { currentuser = value; OnPropertyChanged("Currentuser"); }

        }
        public ProfileViewModel()
        {
            UserService user = new UserService();
            List<User> userlist = new List<User>();
            userlist = user.GetUsers();
            Currentuser = userlist.FirstOrDefault();
            saveCommand = new RelayCommand(Getuser);
        }
        private RelayCommand saveCommand;

        public RelayCommand SaveCommand
        {
            get { return saveCommand; }
        }
        public void Getuser()
        {
            try
            {
                

            }
            catch (Exception e)
            {
                throw;
            }
        }

    }
}

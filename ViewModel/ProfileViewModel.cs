using MVVMApp.Commands;
using MVVMApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace MVVMApp.ViewModel
{
    class ProfileViewModel:ViewModelbase, INotifyPropertyChanged
    {
        
        private string age;
        public string Age
        {
            get { return age; }
            set { age = value; NotifyPropertyChanged("Age"); }

        }


        private bool _isVisibleChecked;
        public bool IsVisibleChecked
        {
            get
            {
                return _isVisibleChecked;
            }
            set
            {
                _isVisibleChecked = value;
                NotifyPropertyChanged("IsVisibleChecked");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private string error;
        public string Error
        {
            get { return error; }
            set { error = value; OnPropertyChanged("Error"); }

        }
        private string url;


        public string Url
        {
            get { return url; }
            set { url = value; OnPropertyChanged("Url"); }

        }
        private User currentuser;

        public User Currentuser
        {
            get { return currentuser; }
            set { currentuser = value; OnPropertyChanged("Currentuser"); }

        }
        public ProfileViewModel()
        {
        
        string mail = Application.Current.Properties["mail"].ToString();
            url = "https://cdn4.iconfinder.com/data/icons/forum-buttons-and-community-signs-1/794/profile-3-512.png";
            UserService user = new UserService();
            List<User> userlist = new List<User>();
            userlist = user.GetUsers();
            Currentuser = userlist.Where(x=>x.Mobile==mail).FirstOrDefault();
            edit = new RelayCommand(Edituser);

        }
        private RelayCommand edit;

        public RelayCommand Edit
        {
            get { return edit; }
        }
        public void Edituser()
        {
            try
            {
                DeleteServices delete = new DeleteServices();
                RegistrationService reg = new RegistrationService(Currentuser);
                MessageBox.Show("Changes Made Successfully");

            }
            catch (Exception e)
            {
                throw;
            }
        }

    }
}

using MVVMApp.Commands;
using MVVMApp.Model;
using MVVMApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMApp.ViewModel
{
    public class RegistrationViewModel : ViewModelbase
    {
        private string errormessage;
        

        public string Errormessage
        {
            get { return errormessage; }
            set { errormessage = value; OnPropertyChanged("Errormessage"); }

        }
        private User currentuser;

        public User Currentuser
        {
            get { return currentuser; }
            set { currentuser = value;OnPropertyChanged("Currentuser"); }

        }
        public RegistrationViewModel()
        {
            Currentuser = new User();
            saveCommand = new RelayCommand(Save);
        }
        private RelayCommand saveCommand;

        public RelayCommand SaveCommand
        {
            get { return saveCommand; }
        }
        public void Save()
        {
            try
            {
                RegistrationService reg = new RegistrationService(Currentuser);
                Errormessage = "Registered Succesfully";
                
            }
            catch (Exception e)
            {
                Errormessage = e.Message;
            }
        }

    }
}

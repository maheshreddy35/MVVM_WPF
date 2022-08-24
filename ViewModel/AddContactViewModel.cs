using MVVMApp.Commands;
using MVVMApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMApp.ViewModel
{
    public class AddContactViewModel:ViewModelbase
    {
        private string errormessage;


        public string Errormessage
        {
            get { return errormessage; }
            set { errormessage = value; OnPropertyChanged("Errormessage"); }

        }
        private Contact contactuser;

        public Contact Contactuser
        {
            get { return contactuser; }
            set { contactuser = value; OnPropertyChanged("Contactuser"); }

        }
        public AddContactViewModel()
        {
            Contactuser = new Contact();
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
                ContactServices cont = new ContactServices(Contactuser);
                Errormessage = "Contact Added Succesfully";

            }
            catch (Exception e)
            {
                Errormessage = e.Message;
            }
        }

    }
}

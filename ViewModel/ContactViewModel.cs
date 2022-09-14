using MVVMApp.Commands;
using MVVMApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace MVVMApp.ViewModel
{
    class ContactViewModel : ViewModelbase, INotifyPropertyChanged
    {
        string ph = Application.Current.Properties["mail"].ToString();
        private List<Contlist> contactlist;
        public List<Contlist> Contactlist
        {
            get { return contactlist; }
            set { contactlist = value; OnPropertyChanged("Contactlist"); }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private string phone;
        public string Phone
        {
            get { return phone; }
            set
            {
                phone = value;
                NotifyPropertyChanged("Phone");
            }
        }

        private string frd;
        public string Frd
        {
            get { return frd; }
            set
            {
                frd = value;
                NotifyPropertyChanged("Frd");
            }
        }

        private string person;
        public string Person
        {
            get { return person; }
            set
            {
                person = value;
                NotifyPropertyChanged("Person");
            }
        }


        private Contlist selected;
        public Contlist Selected
        {
            get { return selected; }
            set
            {
                selected = value;
                NotifyPropertyChanged("Selected");
                Phone = Selected.Mobile;
                Person = Selected.Name;
                Frd = Selected.FrdMobile;
                
            }
        }


        ContactService contact;
       
        public ContactViewModel()
        {

            contact = new ContactService();
            Contactlist = contact.Getcontacts();
           

        }


    }
}

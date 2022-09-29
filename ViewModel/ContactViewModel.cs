using MVVMApp.Commands;
using MVVMApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace MVVMApp.ViewModel
{
    class ContactViewModel : ViewModelbase
    {
        string ph = Application.Current.Properties["mail"].ToString();
        private List<Contlist> contactlist;
        public List<Contlist> Contactlist
        {
            get { return contactlist; }
            set { contactlist = value; OnPropertyChanged("Contactlist"); }
        }


        //public event PropertyChangedEventHandler PropertyChanged;

        //private void NotifyPropertyChanged([CallerMemberName] string name = "")
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        //}

        private string phone;
        public string Phone
        {
            get { return phone; }
            set
            {
                phone = value;
                OnPropertyChanged("Phone");
            }
        }

        private string frd;
        public string Frd
        {
            get { return frd; }
            set
            {
                frd = value;
                OnPropertyChanged("Frd");
            }
        }

        private string person;
        public string Person
        {
            get { return person; }
            set
            {
                person = value;
                OnPropertyChanged("Person");
            }
        }

        private string contactfrd;
        public string ContactFrd
        {
            get { return contactfrd; }
            set
            {
                contactfrd = value;
                OnPropertyChanged("ContactFrd");
            }
        }

        private string contactPerson;
        public string ContactPerson
        {
            get { return contactPerson; }
            set
            {
                contactPerson = value;
                OnPropertyChanged("ContactPerson");
            }
        }

        private Contlist selectedContact;
        public Contlist SelectedContact
        {
            get { return selectedContact; }
            set
            {
                selectedContact = value;
                OnPropertyChanged("SelectedContact");
                ContactPerson = SelectedContact.Name;
                ContactFrd = SelectedContact.FrdMobile;
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=sample;Integrated Security=true");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update contact set Name='"+ ContactPerson+"' where frdMobile='" + ContactFrd + "'", con);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                

            }
        }


        private Contlist selected;
        public Contlist Selected
        {
            get { return selected; }
            set
            {
                selected = value;
                OnPropertyChanged("Selected");
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

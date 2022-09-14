using MVVMApp.Commands;
using MVVMApp.Model;
using MVVMApp.View;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVMApp.ViewModel
{
    public class LoginViewModel: ViewModelbase
    {
        public LoginViewModel()
        {
            User = new login();
            loginCommand = new RelayCommand(Login);
        }
        private string errormessage;
        public string Errormessage
        {
            get { return errormessage; }
            set { errormessage = value; OnPropertyChanged("Errormessage"); }

        }
        private login user;

        public login User
        {
            get { return user; }
            set { user = value; OnPropertyChanged("User"); }

        }
        private RelayCommand loginCommand;

        public RelayCommand LoginCommand
        {
            get { return loginCommand; }
        }
        public void Login()
        {

            HomeWindow home = new HomeWindow();

            

            try
            {
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=sample");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from Registration where Mobile='" + User.Mobile + "'  and password='" + User.Password + "'");
                cmd.Connection = con;
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                    Application.Current.Properties["name"] = (string)dr[0] + (string)dr[1];
                    Application.Current.Properties["mail"] = (string)dr[4];
                    

                    home.Show();
                    Errormessage = "";
                    
                }
                else
                {
                    Errormessage = "*Please enter valid credentials";
                }
            }
            catch (Exception e)
            {
                Errormessage = e.Message;
            }
        }
    }
}

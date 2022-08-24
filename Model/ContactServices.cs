using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVMApp.Model
{
    public class ContactServices
    {
        public ContactServices(Contact user)
        {
            try
            {
                string email = Application.Current.Properties["mail"].ToString();
                string name = user.FirstName+user.LastName;
                string url = user.Image;
                string frdemail = user.FrdEmail;

                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=sample");
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into contact values('" + email + "','" + name + "','" + url + "','" + frdemail + "')", con);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception e)
            {
                throw;
            }
        }
    }
}

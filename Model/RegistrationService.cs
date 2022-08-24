using MVVMApp.View;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMApp.Model
{
    public class RegistrationService
    {
        public RegistrationService(User user)
        {
            string firstname = user.FirstName;
            string lastname =user.LastName, email = user.Email, password = user.Password, address = user.Address;
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=sample;Integrated Security=true");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Registration (FirstName,LastName,Email,Password,Address) values('" + firstname + "','" + lastname + "','" + email + "','" + password + "','" + address + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            
        }

       
        
        
    }
}

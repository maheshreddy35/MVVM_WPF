using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMApp.Model
{
    public class UserService
    {
        static SqlConnection con;
        static SqlCommand cmd;
        List<User> userlist;
        
        public UserService()
        {
            userlist = new List<User>();
            con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=sample;Integrated Security=true");
            con.Open();

            cmd = new SqlCommand("select * from Registration");
            cmd.Connection = con;
            SqlDataReader dr = cmd.ExecuteReader();
            
            while (dr.Read())
            {
                User emp = new User();
                emp.FirstName = (string)dr[0];
                emp.LastName = (string)dr[1];
                emp.Email = (string)dr[2];
                emp.Password = (string)dr[3];
                emp.Address = (string)dr[4];

                userlist.Add(emp);

            }
        }
        public List<User> GetUsers()
        {
            return userlist;
        }
        

    
    }
}

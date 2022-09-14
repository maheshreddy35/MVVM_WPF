using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVMApp.Model
{
    public class DeleteServices
    {
        public DeleteServices()
        {
            string Email = Application.Current.Properties["mail"].ToString();
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=sample;Integrated Security=true");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete from Registration where Mobile='" + Email +"'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}

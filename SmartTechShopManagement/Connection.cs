using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SmartTechShopManagement
{
    public class Connection
    {   
        public SqlConnection Connect()
        {
            string connectionString = @"Data Source =.\SQLEXPRESS;Initial Catalog=STSMSdb; Integrated Security = True;";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;
        }
        public void push(string query)
        {
            SqlConnection conn = Connect();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

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
            conn.Close();
        }
        public DataTable pullForDataTable(string query)
        {
            DataTable datatable = new DataTable();
            SqlConnection conn = Connect();
            SqlDataAdapter dadp = new SqlDataAdapter(query, conn);
            dadp.Fill(datatable);
            return datatable;
        }
    }
}

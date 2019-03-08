using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystemSpyCoder.Models
{
    public class Connection
    {
        public string connectionString = @"Server=DESKTOP-IQOQ25D\SQLEXPRESS; Database=StockManagementSystem; Integrated Security = true ";


        public SqlConnection sqlConnection()
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            return sqlConnection;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu.Models.ModelDB
{
    class DBConnectMsSql
    {


        public SqlConnection connection = new SqlConnection(" ");
        public static string connectionString { get; set; }

        public void sqlconnection()
        {
            connection = new SqlConnection(connectionString);

        }
    }
}

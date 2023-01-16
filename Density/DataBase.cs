using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Density
{
    class DataBase
    {
        SqlConnection con = new SqlConnection(@"Data Source=VLG-5CD5491NCN; Initial Catalog=OperationalRegistrationTest;Integrated Security=True");

        public void OpenConnection()
        {
            if (con.State == System.Data.ConnectionState.Closed) con.Open();

        }
        public void CloseConnection()
        {
            if (con.State == System.Data.ConnectionState.Open) con.Close();

        }

        public SqlConnection GetConnection()
        {
            return con;
        }
              

    }
}

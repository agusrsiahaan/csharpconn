using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace testconnection
{
    class Koneksi
    {
        public SqlConnection GetConn()
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = @"Data Source = AGUS-PC\SQLEXPRESS; initial catalog=db_contoh; integrated security=true";
            return Conn;
        }
    }
}

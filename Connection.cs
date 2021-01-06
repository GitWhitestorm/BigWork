using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BigWork
{
    class Connection
    {
        public SqlConnection connection()
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-62K1PO6;Initial Catalog=library;Integrated Security=True");
            connection.Open();
            return connection;
        }
        public  SqlCommand command(string sql)
        {
            SqlCommand command = new SqlCommand(sql, connection());
            return command;
        }
        public int effectRows(SqlCommand command)
        {
            return command.ExecuteNonQuery();
        }
        public SqlDataReader read(string sql)
        {
            return command(sql).ExecuteReader();
        }
    }
}

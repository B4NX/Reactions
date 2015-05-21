using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Eve_Reaction_Calculator
{

    public static class SQLConnector
    {
        private static SqlConnection connection;

        static SQLConnector()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.Add("Server", "ARIA\\SQLEXPRESS");
            builder.Add("Database", "Mosaic");
            builder.Add("Integrated Security", true);

            connection = new SqlConnection(builder.ConnectionString);
            connection.Open();
        }

        public static object[] RunQuery(string query)
        {
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            object[] data = new object[2];

            while (reader.Read())
            {
                Console.WriteLine(reader[0]);
                data[0] = reader.GetValue(0);
                data[1] = reader[1];
            }
            reader.Close();
            return data;
        }
    }
}

using kursach_klient.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursach_klient.Helpers
{
    public static class DataBase
    {
        public static string ConnectionString= @"Data Source=.\SQLEXPRESS;Initial Catalog = kursach; Integrated Security = True";
        public static List<Teacher> Teachers
        {
            get
            {
                
            }
        }
        public static List<T> GetObjects<T>() where T : Model
        {
            List<T> objects = new List<T>();
            SendSQL($"SELECT *  FROM {typeof(T).Name}");
        }
        public static DataTable SendSQL(string query)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                DataTable result = new DataTable();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(result);
                return result;
            }
        }
    }
}

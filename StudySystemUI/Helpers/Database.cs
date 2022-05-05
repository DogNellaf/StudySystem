using StudySystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace StudySystem.Helpers
{
    public static class Database
    {
        public static string ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog = kursach; Integrated Security = True";

        public static List<Teacher> Teachers => GetObjects<Teacher>();

        public static List<Publication> Publications => GetObjects<Publication>();

        public static List<Publisher> Publishers => GetObjects<Publisher>();


        public static bool CreateObject<T>(T item) where T: Model => SendSQL($"SELECT *  FROM {typeof(T).Name}")

        public static List<T> GetObjects<T>() where T : Model
        {
            List<T> objects = new List<T>();
            var table = SendSQL($"SELECT *  FROM {typeof(T).Name}");
            foreach (DataRow row in table.Rows)
            {
                var data = new object[1] { row.ItemArray };
                T item = (T)Activator.CreateInstance(typeof(T), data);
                objects.Add(item);
            }
            return objects;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace POSFull {
    internal class Settings {
        public static MySqlConnection cnn;

        public static void OpenConnection() {
            string connectionString = "server=127.0.0.1;database=posfulldb;uid=root;pwd=AAb/29/5/2001@!#;";

            try {
                cnn = new MySqlConnection(connectionString);
                cnn.Open();
                Console.WriteLine("Connection Open!");
            } catch (MySqlException ex) {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public static void CloseConnection() {
            cnn.Close();
            Console.WriteLine("Connection Closed!");
        }
    }
}

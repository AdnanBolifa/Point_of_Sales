using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Threading.Tasks;
using System.Data;

namespace POSFull {
    internal class Items {
        public DataTable dtItem = new DataTable();
        public void LoadItem() {
            using (MySqlConnection cnn = new MySqlConnection()) {
                Settings.OpenConnection(); // Open the database connection using the Settings class

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Settings.cnn; // Use the existing connection from the Settings class
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "loadItemSP";

                dtItem.Load(cmd.ExecuteReader());

                Settings.CloseConnection(); // Close the database connection using the Settings class
            }
        }
        public int MaxID() {
            int id = 0;

            Settings.OpenConnection(); // Open the database connection using the Settings class

            try {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Settings.cnn; // Use the existing connection from the Settings class
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "MaxIDitemSP";

                id = Convert.ToInt32(cmd.ExecuteScalar());
            } catch (Exception) {
                throw;
            }

            Settings.CloseConnection(); // Close the database connection using the Settings class

            return id + 1;
        }
        public void InsertItems(int id, string name) {
            try {
                Settings.OpenConnection(); // Open the database connection using the Settings class

                using (MySqlCommand cmd = new MySqlCommand()) {
                    cmd.Connection = Settings.cnn; // Use the existing connection from the Settings class
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "InsertItemsSP";
                    cmd.Parameters.Add(new MySqlParameter("idParam", id));
                    cmd.Parameters.Add(new MySqlParameter("nameParam", name));

                    cmd.ExecuteNonQuery();
                }
            } finally {
                Settings.CloseConnection(); // Close the database connection using the Settings class
            }
        }   
        public void EditItem(int id, string name) {
            try {
                Settings.OpenConnection(); // Open the database connection using the Settings class

                using (MySqlCommand cmd = new MySqlCommand()) {
                    cmd.Connection = Settings.cnn; // Use the existing connection from the Settings class
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "UpdateItemsSP";
                    cmd.Parameters.Add(new MySqlParameter("idParam", id));
                    cmd.Parameters.Add(new MySqlParameter("nameParam", name));

                    cmd.ExecuteNonQuery();
                }
            } finally {
                Settings.CloseConnection(); // Close the database connection using the Settings class
            }
        }
        public void DeleteItem(int id) {
            try {
                Settings.OpenConnection(); // Open the database connection using the Settings class

                using (MySqlCommand cmd = new MySqlCommand()) {
                    cmd.Connection = Settings.cnn; // Use the existing connection from the Settings class
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "DeleteItemsSP";
                    cmd.Parameters.Add(new MySqlParameter("idParam", id));

                    cmd.ExecuteNonQuery();
                }
            } finally {
                Settings.CloseConnection(); // Close the database connection using the Settings class
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace POSFull {
    internal class PublicFun {
        public DataTable dtPublic = new DataTable();
        public void LoadPublic(string SPtext) {
            using (MySqlConnection cnn = new MySqlConnection()) {
                Settings.OpenConnection(); // Open the database connection using the Settings class

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Settings.cnn; // Use the existing connection from the Settings class
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = SPtext;

                dtPublic.Load(cmd.ExecuteReader());

                Settings.CloseConnection(); // Close the database connection using the Settings class
            }
        }
        public int MaxIDPublic(string SPtext) {
            int id = 0;

            Settings.OpenConnection(); // Open the database connection using the Settings class

            try {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Settings.cnn; // Use the existing connection from the Settings class
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = SPtext;

                id = Convert.ToInt32(cmd.ExecuteScalar());
            } catch (Exception) {
                id = 0;
            }

            Settings.CloseConnection(); // Close the database connection using the Settings class

            return id + 1;

        }
    }
}

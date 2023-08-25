using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSFull {
    internal class Customers {
        public void InsertCustomer(string name, string phone, string address) {
            try {
                Settings.OpenConnection(); // Open the database connection using the Settings class

                using (MySqlCommand cmd = new MySqlCommand()) {
                    cmd.Connection = Settings.cnn; // Use the existing connection from the Settings class
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "InsertCustomers";
                    cmd.Parameters.Add(new MySqlParameter("nameParam", name));
                    cmd.Parameters.Add(new MySqlParameter("phoneParam", phone));
                    cmd.Parameters.Add(new MySqlParameter("addressParam", address));

                    cmd.ExecuteNonQuery();
                }
            } finally {
                Settings.CloseConnection(); // Close the database connection using the Settings class
            }
        }
    }
}

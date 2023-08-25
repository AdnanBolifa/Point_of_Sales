using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSFull {
    internal class Customers : PublicFun {
        public void InsertCustomer(string name, string phone, string address) {
            try {
                Settings.OpenConnection(); // Open the database connection using the Settings class

                using (MySqlCommand cmd = new MySqlCommand()) {
                    cmd.Connection = Settings.cnn; // Use the existing connection from the Settings class
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "InsertCustomersSP";
                    cmd.Parameters.Add(new MySqlParameter("nameParam", name));
                    cmd.Parameters.Add(new MySqlParameter("phoneParam", phone));
                    cmd.Parameters.Add(new MySqlParameter("addressParam", address));

                    cmd.ExecuteNonQuery();
                }
            } finally {
                Settings.CloseConnection(); // Close the database connection using the Settings class
            }
        }
        public void DeleteCustomer(int id) {
            try {
                Settings.OpenConnection(); // Open the database connection using the Settings class

                using (MySqlCommand cmd = new MySqlCommand()) {
                    cmd.Connection = Settings.cnn; // Use the existing connection from the Settings class
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "DeleteCustomerSP";
                    cmd.Parameters.Add(new MySqlParameter("idParam", id));

                    cmd.ExecuteNonQuery();
                }
            } finally {
                Settings.CloseConnection(); // Close the database connection using the Settings class
            }
        }
        public void EditCustomer(int id,string name, string phone, string address) {
            try {
                Settings.OpenConnection(); // Open the database connection using the Settings class

                using (MySqlCommand cmd = new MySqlCommand()) {
                    cmd.Connection = Settings.cnn; // Use the existing connection from the Settings class
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "UpdateCustomersSP";
                    cmd.Parameters.Add(new MySqlParameter("idParam", id));
                    cmd.Parameters.Add(new MySqlParameter("nameParam", name));
                    cmd.Parameters.Add(new MySqlParameter("phoneParam", phone));
                    cmd.Parameters.Add(new MySqlParameter("addressParam", address));

                    cmd.ExecuteNonQuery();
                }
            } finally {
                Settings.CloseConnection(); // Close the database connection using the Settings class
            }
        }
        public DataTable dtCustomerSearch = new DataTable();
        public void SearchCustomer(string txt) {
            try {
                Settings.OpenConnection(); // Open the database connection using the Settings class

                using (MySqlCommand cmd = new MySqlCommand()) {
                    cmd.Connection = Settings.cnn; // Use the existing connection from the Settings class
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "SearchCustomersSP";
                    cmd.Parameters.Add(new MySqlParameter("txtParam", txt));
                    dtCustomerSearch.Load(cmd.ExecuteReader());
                }
            } finally {
                Settings.CloseConnection(); // Close the database connection using the Settings class
            }
        }
    }
}

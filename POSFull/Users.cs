using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using POSFull;
using System.Xml.Linq;

namespace POS {

    internal class Users {
        public DataTable dt = new DataTable();
        public void Login(string username, string password) {
            try {
                Settings.OpenConnection(); // Open the database connection using the Settings class

                using (MySqlCommand cmd = new MySqlCommand()) {
                    cmd.Connection = Settings.cnn; // Use the existing connection from the Settings class
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "loginSP";
                    cmd.Parameters.Add(new MySqlParameter("userParam", username));
                    cmd.Parameters.Add(new MySqlParameter("passParam", password));

                    DataTable dtUser = new DataTable();
                    dtUser.Load(cmd.ExecuteReader());

                    var mainForm = Application.OpenForms["MainForm"] as MainForm;
                    if (dtUser.Rows.Count > 0)
                        Enable(mainForm, true);
                    else
                        MessageBox.Show("Login Failed!");
                }
            } finally {
                Settings.CloseConnection(); // Close the database connection using the Settings class
            }
        }
        public void Enable(MainForm mainForm, bool flag) {
            mainForm.btnLogout.Enabled = flag;
            mainForm.storage.Enabled = flag;
            mainForm.Sales.Enabled = flag;
            mainForm.purchases.Enabled = flag;
            mainForm.users.Enabled = flag;
            mainForm.suppliers.Enabled = flag;
            mainForm.customers.Enabled = flag;
            mainForm.btnLogin.Enabled = !flag;
        }

    }
}

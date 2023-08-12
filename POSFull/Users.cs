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

namespace POS {

    internal class Users {
        public DataTable dt = new DataTable();
        public void Login(string username, string password) {
            using (MySqlConnection cnn = new MySqlConnection("server=localhost;database=posfulldb;uid=root;pwd=AAb/29/5/2001@!#;")) {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cnn;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "loginSP";
                cmd.Parameters.Add("userParam", MySqlDbType.VarChar, 45).Value = username;
                cmd.Parameters.Add("passParam", MySqlDbType.VarChar, 45).Value = password;

                cnn.Open();
                DataTable dtUser = new DataTable();
                dtUser.Load(cmd.ExecuteReader());


                var mainForm = Application.OpenForms["MainForm"] as MainForm;


                if (dtUser.Rows.Count > 0)
                    Enable(mainForm, true);
                else
                    MessageBox.Show("Login Failed!");
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

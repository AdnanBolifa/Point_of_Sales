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
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = Settings.cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "loadItemSP";

            Settings.cnn.Open();
            dtItem.Load(cmd.ExecuteReader());
            Settings.cnn.Close();
        }
    }
}

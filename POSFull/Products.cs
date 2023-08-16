using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace POSFull {
    internal class Products : PublicFun {
        public void InsertProductNotImage(int id, string code, string name, double pricePurchase, double priceSale, double priceEarn, double qty, int idItem) {
            Settings.OpenConnection(); // Open the database connection using the Settings class

            try {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Settings.cnn; // Use the existing connection from the Settings class
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertProductSP";
                cmd.Parameters.Add(new MySqlParameter("idParam", id));
                cmd.Parameters.Add(new MySqlParameter("codeParam", code));
                cmd.Parameters.Add(new MySqlParameter("nameParam", name));
                cmd.Parameters.Add(new MySqlParameter("pricePurchaseParam", pricePurchase));
                cmd.Parameters.Add(new MySqlParameter("priceSaleParam", priceSale));
                cmd.Parameters.Add(new MySqlParameter("priceEarnParam", priceEarn));
                cmd.Parameters.Add(new MySqlParameter("qtyParam", qty));
                cmd.Parameters.Add(new MySqlParameter("idItemParam", idItem));

                cmd.ExecuteNonQuery();

            } catch (Exception) {
                throw;
            }

            Settings.CloseConnection(); // Close the database connection using the Settings class
        }
    }
}

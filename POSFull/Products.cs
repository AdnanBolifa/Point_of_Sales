using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Xml.Linq;
using Encoder = System.Drawing.Imaging.Encoder;

namespace POSFull {
    internal class Products : PublicFun {
        //TODO IMAGE BUG:  
        //WHEN THE IMAGE IS HIGH-RESULOTION IT EXCEEDS THE MAXIMUM LIMIT FOR BLOB/LONGBLOB IN MYSQL
        //SOLUTIONS RESIZE OR COMPRESS THE IMAGES BEFORE STORING THEM.


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
        public void InsertProductImage(int id, string code, string name, double pricePurchase, double priceSale, double priceEarn, double qty, byte[] productImage, int idItem) {
            Settings.OpenConnection(); // Open the database connection using the Settings class

            try {
                byte[] compressedImage = CompressImage(productImage, 10); // Adjust the compression quality as needed (0-100)
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Settings.cnn; // Use the existing connection from the Settings class
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertProductImgSP";
                cmd.Parameters.Add(new MySqlParameter("idParam", id));
                cmd.Parameters.Add(new MySqlParameter("codeParam", code));
                cmd.Parameters.Add(new MySqlParameter("nameParam", name));
                cmd.Parameters.Add(new MySqlParameter("pricePurchaseParam", pricePurchase));
                cmd.Parameters.Add(new MySqlParameter("priceSaleParam", priceSale));
                cmd.Parameters.Add(new MySqlParameter("priceEarnParam", priceEarn));
                cmd.Parameters.Add(new MySqlParameter("qtyParam", qty));
                cmd.Parameters.Add(new MySqlParameter("imgParam", compressedImage));
                cmd.Parameters.Add(new MySqlParameter("idItemParam", idItem));

                cmd.ExecuteNonQuery();

            } catch (Exception) {
                throw;
            }

            Settings.CloseConnection(); // Close the database connection using the Settings class
        }
        public DataTable getImageProduct(string code) {
            DataTable dt = new DataTable();
            Settings.OpenConnection(); // Open the database connection using the Settings class

            try {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Settings.cnn; // Use the existing connection from the Settings class
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetImgProductSP";
                cmd.Parameters.Add(new MySqlParameter("codeParam", code));
                dt.Load(cmd.ExecuteReader());

            } catch (Exception) {
                throw;
            }
            Settings.CloseConnection();
            return dt;
        }
        public void UpdateProductNotImage(string name, double pricePurchase, double priceSale, double priceEarn, double qty, int idItem, string code) {
            Settings.OpenConnection(); // Open the database connection using the Settings class

            try {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Settings.cnn; // Use the existing connection from the Settings class
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateProductSP";
                cmd.Parameters.Add(new MySqlParameter("nameParam", name));
                cmd.Parameters.Add(new MySqlParameter("pricePurchaseParam", pricePurchase));
                cmd.Parameters.Add(new MySqlParameter("priceSaleParam", priceSale));
                cmd.Parameters.Add(new MySqlParameter("priceEarnParam", priceEarn));
                cmd.Parameters.Add(new MySqlParameter("qtyParam", qty));
                cmd.Parameters.Add(new MySqlParameter("idItemParam", idItem));
                cmd.Parameters.Add(new MySqlParameter("codeParam", code));

                cmd.ExecuteNonQuery();

            } catch (Exception) {
                throw;
            }

            Settings.CloseConnection(); // Close the database connection using the Settings class
        }
        public void UpdateProductImage(string name, double pricePurchase, double priceSale, double priceEarn, double qty, byte[] image, int idItem, string code) {
            Settings.OpenConnection(); // Open the database connection using the Settings class

            try {
                // Compress the image before passing it to the database
                byte[] compressedImage = CompressImage(image, 10); // Adjust the compression quality as needed (0-100)

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Settings.cnn; // Use the existing connection from the Settings class
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateProductImgSP";
                cmd.Parameters.Add(new MySqlParameter("nameParam", name));
                cmd.Parameters.Add(new MySqlParameter("pricePurchaseParam", pricePurchase));
                cmd.Parameters.Add(new MySqlParameter("priceSaleParam", priceSale));
                cmd.Parameters.Add(new MySqlParameter("priceEarnParam", priceEarn));
                cmd.Parameters.Add(new MySqlParameter("qtyParam", qty));
                cmd.Parameters.Add(new MySqlParameter("idItemParam", idItem));
                cmd.Parameters.Add(new MySqlParameter("imageParam", compressedImage)); // Use the compressed image byte array
                cmd.Parameters.Add(new MySqlParameter("codeParam", code));

                cmd.ExecuteNonQuery();
            } catch (Exception) {
                throw;
            }

            Settings.CloseConnection(); // Close the database connection using the Settings class
        }

        public void DeleteProduct(string code) {
            try {
                Settings.OpenConnection(); // Open the database connection using the Settings class

                using (MySqlCommand cmd = new MySqlCommand()) {
                    cmd.Connection = Settings.cnn; // Use the existing connection from the Settings class
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "DeleteProductSP";
                    cmd.Parameters.Add(new MySqlParameter("codeParam", code));

                    cmd.ExecuteNonQuery();
                }
            } finally {
                Settings.CloseConnection(); // Close the database connection using the Settings class
            }
        }
        private byte[] CompressImage(byte[] image, long quality) {
            using (MemoryStream inputStream = new MemoryStream(image))
            using (MemoryStream outputStream = new MemoryStream()) {
                // Load the image from the input stream
                Image originalImage = Image.FromStream(inputStream);

                // Create an EncoderParameters object to specify compression quality
                EncoderParameters encoderParameters = new EncoderParameters(1);
                encoderParameters.Param[0] = new EncoderParameter(Encoder.Quality, quality);

                // Get the JPEG codec
                ImageCodecInfo jpegCodec = GetEncoderInfo(ImageFormat.Jpeg);

                // Save the image to the output stream with specified compression quality
                originalImage.Save(outputStream, jpegCodec, encoderParameters);

                // Return the compressed image as a byte array
                return outputStream.ToArray();
            }
        }

        private ImageCodecInfo GetEncoderInfo(ImageFormat format) {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
            foreach (ImageCodecInfo codec in codecs) {
                if (codec.FormatID == format.Guid) {
                    return codec;
                }
            }
            return null;
        }
    }
}

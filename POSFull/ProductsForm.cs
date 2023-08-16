using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSFull {
    public partial class ProductsForm : Form {

        bool IS_ADD;
        public ProductsForm() {
            InitializeComponent();
            Items items = new Items();
            items.LoadItem();
            cbItem.DataSource = items.dtItem;
            cbItem.DisplayMember = "nameItem";
            cbItem.ValueMember = "id";
        }
        public void ClearText() {
            textCode.Clear();
            textID.Clear();
            textSale.Clear();
            textPurchase.Clear();
            textName.Clear();
            textEarn.Clear();
            textQty.Clear();
            pBox = null;
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            ClearText();
            Products products = new Products();
            int max = products.MaxIDPublic("MaxIDProductSP");
            textID.Text = max.ToString();

            IS_ADD = true;
            btnSave.Enabled = true;
            groupBox.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            IS_ADD = false;
            btnSave.Enabled = true;
            groupBox.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (IS_ADD) {
                //Insert method
                if (pBox == null) {  //Insert without an image
                    try {
                        Products products = new Products();
                        products.InsertProductNotImage(Convert.ToInt32(textID.Text), textCode.Text, textName.Text, Convert.ToDouble(textPurchase.Text), Convert.ToDouble(textSale.Text), Convert.ToDouble(textEarn.Text), Convert.ToDouble(textQty.Text), Convert.ToInt32(cbItem.SelectedValue));
                        MessageBox.Show("تمت الاضافة بنجاح -- بدون صورة!");
                    } catch (Exception) {
                        MessageBox.Show("الرجاء كتابة كل الحقول!");
                    }
                } else { //Insert with an image.. 
                     
                }
            } else {
                //Update || Edit
            }
            ClearText(); 
            btnSave.Enabled = false;
            groupBox.Enabled = false;
        }

        private void textPurchase_TextChanged(object sender, EventArgs e) {
            try {
                textEarn.Text = (Convert.ToDouble(textSale.Text) - Convert.ToDouble(textPurchase.Text)).ToString();
            } catch (Exception) {

                return;
            }
        }

        private void textEarn_TextChanged(object sender, EventArgs e) {
            try {
                if (Convert.ToDouble(textEarn.Text) <= 0) {
                    textEarn.BackColor = Color.Red;
                } else {
                    textEarn.BackColor = Color.Green;
                }

            } catch (Exception) {

                return;
            }
        }
    }
}

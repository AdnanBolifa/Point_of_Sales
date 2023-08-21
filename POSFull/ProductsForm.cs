using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;

namespace POSFull {
    public partial class ProductsForm : Form {

        bool IS_ADD;
        bool IS_DELETE_PIC;
        public ProductsForm() {
            InitializeComponent();
            Items items = new Items();
            items.LoadItem();
            cbItem.DataSource = items.dtItem;
            cbItem.DisplayMember = "nameItem";
            cbItem.ValueMember = "id";
            LoadProduct();
        }
        public void LoadProduct() {
            Products products = new Products();
            products.LoadPublic("LoadVproductItemSP");
            gridControlProduct.DataSource = products.dtPublic;
            dataGridViewProduct.DataSource = products.dtPublic;
        }
        public void ClearText() {
            textCode.Clear();
            textID.Clear();
            textSale.Clear();
            textPurchase.Clear();
            textName.Clear();
            textEarn.Clear();
            textQty.Clear();
            pBox.Image = null;
            textEarn.BackColor = Color.White;
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            ClearText();
            Products products = new Products();
            int max = products.MaxIDPublic("MaxIDProductSP");
            textID.Text = max.ToString();

            IS_ADD = true;
            btnSave.Enabled = true;
            groupBox.Enabled = true;
            textCode.ReadOnly = false;
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            IS_ADD = false;
            btnSave.Enabled = true;
            groupBox.Enabled = true;
            textCode.ReadOnly = true;

            try {
                if (dataGridViewProduct.CurrentRow != null) {
                    var cells = dataGridViewProduct.CurrentRow.Cells;

                    textID.Text = TryGetValue(cells, 0);
                    textCode.Text = TryGetValue(cells, 1);
                    textName.Text = TryGetValue(cells, 2);
                    textPurchase.Text = TryGetValue(cells, 3);
                    textSale.Text = TryGetValue(cells, 4);
                    textEarn.Text = TryGetValue(cells, 5);
                    textQty.Text = TryGetValue(cells, 6);
                    cbItem.Text = TryGetValue(cells, 8);

                    Products products = new Products();
                    byte[] image = (byte[])products.getImageProduct(TryGetValue(cells, 1)).Rows[0][0];
                    MemoryStream memoryStream = new MemoryStream(image);
                    pBox.Image = Image.FromStream(memoryStream);
                } else {
                    pBox.Image = null;
                }
            } catch (Exception) {
                pBox.Image = null;
            }

            string TryGetValue(DataGridViewCellCollection cells, int index) {
                return cells.Count > index && cells[index].Value != null ? cells[index].Value.ToString() : string.Empty;
            }
        }
 
        private void btnSave_Click(object sender, EventArgs e) {
            if (IS_ADD) {
                //Insert method
                if (pBox.Image == null) {  //Insert without an image
                    try {
                        Products products = new Products();
                        products.InsertProductNotImage(Convert.ToInt32(textID.Text), textCode.Text, textName.Text, Convert.ToDouble(textPurchase.Text), Convert.ToDouble(textSale.Text), Convert.ToDouble(textEarn.Text), Convert.ToDouble(textQty.Text), Convert.ToInt32(cbItem.SelectedValue));
                        MessageBox.Show("تمت الاضافة بنجاح -- بدون صورة!");
                    } catch (Exception) {
                        MessageBox.Show("الرجاء كتابة كل الحقول!");
                    }
                } else { //Insert with an image.. 
                    MemoryStream stream = new MemoryStream();
                    pBox.Image.Save(stream, pBox.Image.RawFormat);
                    byte[] image = stream.ToArray();

                    try {
                        Products products = new Products();
                        products.InsertProductImage(Convert.ToInt32(textID.Text), textCode.Text, textName.Text, Convert.ToDouble(textPurchase.Text), Convert.ToDouble(textSale.Text), Convert.ToDouble(textEarn.Text), Convert.ToDouble(textQty.Text), image, Convert.ToInt32(cbItem.SelectedValue));
                        MessageBox.Show("تمت الاضافة بنجاح -- بصورة!");
                    } catch (Exception) {
                        MessageBox.Show("الرجاء كتابة كل الحقول!");
                    }
                }
            } 
            else {
                //Update || Edit
                if (pBox.Image == null) {  //update without an image
                    try {
                        Products products = new Products();
                        products.UpdateProductNotImage(textName.Text, Convert.ToDouble(textPurchase.Text), Convert.ToDouble(textSale.Text), Convert.ToDouble(textEarn.Text), Convert.ToDouble(textQty.Text), Convert.ToInt32(cbItem.SelectedValue), textCode.Text);
                        MessageBox.Show("تم التعديل بنجاح -- بدون صورة!");
                    } catch (Exception) {
                        MessageBox.Show("الرجاء كتابة كل الحقول!");
                    }
                } 
                else { //update with an image.. 
                    MemoryStream stream = new MemoryStream();
                    pBox.Image.Save(stream, pBox.Image.RawFormat);
                    byte[] image = stream.ToArray();

                    try {
                        Products products = new Products();
                        products.UpdateProductImage(textName.Text, Convert.ToDouble(textPurchase.Text), Convert.ToDouble(textSale.Text), Convert.ToDouble(textEarn.Text), Convert.ToDouble(textQty.Text), image, Convert.ToInt32(cbItem.SelectedValue), textCode.Text);
                        MessageBox.Show("تم التعديل بنجاح -- بصورة!");
                    } catch (Exception) {
                        MessageBox.Show("الرجاء كتابة كل الحقول!");
                    }
                }
            }
            ClearText(); 
            btnSave.Enabled = false;
            groupBox.Enabled = false;
            textCode.ReadOnly = true;
            LoadProduct();
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

        private void btnSelectImage_Click(object sender, EventArgs e) {
            openFileDialog.Filter = "Image |*.jpeg; *.jpg; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                pBox.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void textPurchase_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }
        private void textSale_KeyPress(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            Products products = new Products();
            string code = dataGridViewProduct.CurrentRow.Cells[1].Value.ToString();
            DialogResult result = MessageBox.Show("؟هل انت متأكد من حذف هذا العنصر", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) {
                products.DeleteProduct(code);
            }
            LoadProduct();
        }

        private void btnDeletePic_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("هل انت متأكد من حذف هذه الصورة؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) {
                pBox.Image = null;
            }
        }

        private void Cancel_Click(object sender, EventArgs e) {
            btnSave.Enabled = false;
            groupBox.Enabled = false;
            textCode.ReadOnly = true;
            ClearText();
            LoadProduct();
        }
    }
}

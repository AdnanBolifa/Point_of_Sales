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
    public partial class ItemsForm : Form {

        Items items = new Items();
        bool IS_ADD;          //0 = ADD, 1 = EDIT
        public ItemsForm() {
            InitializeComponent();
            Items item = new Items();
            item.LoadItem();
            dataGridView.DataSource = item.dtItem;
            dataGridView.Select();
            dataGridView.Columns[0].HeaderText = "رقم الصنف";
            dataGridView.Columns[1].HeaderText = "اسم الصنف";  
        }
        private void btnAdd_Click(object sender, EventArgs e) {
            IS_ADD = true;
            textName.Enabled = true;  textName.Clear(); textName.Select();
            int id = dataGridView.Rows.Count + 1; //Max ID
            textID.Text = items.MaxID().ToString();

        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (IS_ADD) {    //  Add
                items.InsertItems(Convert.ToInt32(textID.Text), textName.Text);
                items.LoadItem();
                dataGridView.DataSource = items.dtItem;
                MessageBox.Show("تمت الاضافة بنجاح!");
                textName.Clear(); textName.Enabled = false; textID.Clear();
            } else { //Update
                items.EditItem(Convert.ToInt32(textID.Text), textName.Text);
                items.LoadItem();
                dataGridView.DataSource = items.dtItem;
                MessageBox.Show("تم التعديل بنجاح!");
                textName.Clear(); textName.Enabled = false; textID.Clear();
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            IS_ADD = false;
            textID.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
            textName.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            textName.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            textID.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
            DialogResult result = MessageBox.Show("هل انت متأكد من حذف هذا العنصر", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) {
                items.DeleteItem(Convert.ToInt32(textID.Text));
            }
            items.LoadItem();
            dataGridView.DataSource = items.dtItem;
        }
    }
}
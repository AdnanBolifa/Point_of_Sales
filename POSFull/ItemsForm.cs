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
            Items item = new Items();
            textName.Enabled = true;  textName.Clear(); textName.Select();
            int id = dataGridView.Rows.Count + 1; //Max ID
            textID.Text = id.ToString();

        }

        private void btnSave_Click(object sender, EventArgs e) {
            Items items = new Items();
            items.InsertItems(Convert.ToInt32(textID.Text), textName.Text);
            items.LoadItem();
            dataGridView.DataSource = items.dtItem;
            MessageBox.Show("تمت الاضافة بنجاح!");
            textName.Clear(); textName.Enabled = false; textID.Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e) {

        }
    }
}

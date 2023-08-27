using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace POSFull { 
    public partial class CustomerForm : Form {

        void txtClear() {
            txtAddress.Clear();
            txtPhone.Clear();
            txtName.Clear();
            txtID.Clear();
            txtName.Select();
        }
        void txtEnable(bool flag) {
            txtName.Enabled = flag;
            txtAddress.Enabled = flag;
            txtPhone.Enabled = flag;
        }
        public CustomerForm() {
            InitializeComponent();
            Customers customers = new Customers();
            customers.LoadPublic("loadCustomersSP");
            dataGridView.DataSource = customers.dtPublic;
            txtSearch.Select();
            dataGridView.Columns[1].HeaderText = "اسم العميل";
            dataGridView.Columns[2].HeaderText = "رقم العميل";
            dataGridView.Columns[3].HeaderText = "عنوان العميل";
        }

        enum OperationMode {
            None,
            Add,
            Edit
        }

        private OperationMode currentMode = OperationMode.None;
        private void btnAdd_Click(object sender, EventArgs e) {
            txtEnable(true);
            txtClear();
            currentMode = OperationMode.Add;
            Customers customers = new Customers();
            txtID.Text = customers.MaxIDPublic("MaxIDCustomersSP").ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            txtEnable(true);
            txtClear();
            currentMode = OperationMode.Edit;
            txtID.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            txtPhone.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            txtAddress.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            Customers customer = new Customers();  
            switch (currentMode) {
                case OperationMode.None:
                    MessageBox.Show("لم يتم تنفيذ شيء!");
                    break;
                case OperationMode.Add:
                    // Add function here
                    customer.InsertCustomer(Convert.ToInt32(txtID.Text), txtName.Text, txtPhone.Text, txtAddress.Text);
                    MessageBox.Show("تمت الإضافة بنجاح!");
                    break;
                case OperationMode.Edit:
                    // Edit function here
                    int id = (int)dataGridView.CurrentRow.Cells[0].Value;
                    customer.EditCustomer(id, txtName.Text, txtPhone.Text, txtAddress.Text);
                    MessageBox.Show("تم التعديل بنجاح!");
                    break;
            }
            currentMode = OperationMode.None; // Reset the mode after processing
            customer.LoadPublic("loadCustomersSP");
            dataGridView.DataSource= customer.dtPublic;
            txtClear();
            txtEnable(false);
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            Customers customers = new Customers();
            int id = (int)dataGridView.CurrentRow.Cells[0].Value;
            DialogResult result = MessageBox.Show("هل انت متأكد من حذف هذا العنصر", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) {
                customers.DeleteCustomer(id);
            }
            customers.LoadPublic("loadCustomersSP");
            dataGridView.DataSource = customers.dtPublic;
        }
        private void txtPhone_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                txtAddress.Select();
            }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                txtPhone.Select();
            }
        }

        private void txtAddress_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                btnSave.PerformClick();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) {
            Customers customers = new Customers();
            customers.SearchCustomer(txtSearch.Text);
            dataGridView.DataSource = customers.dtCustomerSearch;
        }

        private void btnDeleteAll_Click(object sender, EventArgs e) {
            Customers customers = new Customers();
            DialogResult result = MessageBox.Show("هل انت متأكد من حذف هذا العنصر", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) {
                customers.DeleteAllCustomer();
            }
            customers.LoadPublic("loadCustomersSP");
            dataGridView.DataSource = customers.dtPublic;

        }
    }
}

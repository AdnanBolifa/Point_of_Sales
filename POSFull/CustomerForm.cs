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
    public partial class CustomerForm : Form {

        void txtClear() {
            txtAddress.Clear();
            txtPhone.Clear();
            txtName.Clear();
            txtName.Select();
        }
        void txtEnable(bool flag) {
            txtName.Enabled = flag;
            txtAddress.Enabled = flag;
            txtPhone.Enabled = flag;
        }
        public CustomerForm() {
            InitializeComponent();
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
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            txtEnable(true);
            txtClear();
            currentMode = OperationMode.Edit;
        }

        private void btnSave_Click(object sender, EventArgs e) {
            Customers customer = new Customers();  
            switch (currentMode) {
                case OperationMode.None:
                    MessageBox.Show("لم يتم تنفيذ شيء!");
                    break;
                case OperationMode.Add:
                    // Add function here
                    customer.InsertCustomer(txtName.Text, txtPhone.Text, txtAddress.Text);
                    MessageBox.Show("تمت الإضافة بنجاح!");
                    break;
                case OperationMode.Edit:
                    // Edit function here
                    MessageBox.Show("تم التعديل بنجاح!");
                    break;
            }
            currentMode = OperationMode.None; // Reset the mode after processing
            txtClear();
            txtEnable(false);
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
    }
}

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
        public ItemsForm() {
            InitializeComponent();
            Items item = new Items();
            item.LoadPublic("loadItemSP");
            dataGridView.DataSource = item.dtPublic;
            dataGridView.Select();
            dataGridView.Columns[0].HeaderText = "رقم الصنف";
            dataGridView.Columns[1].HeaderText = "اسم الصنف";  
        }
        enum EditMode {
            None,
            Add,
            Edit
        }

        private EditMode currentEditMode = EditMode.None;

        private void btnAdd_Click(object sender, EventArgs e) {
            currentEditMode = EditMode.Add;
            textName.Enabled = true;
            textName.Clear();
            textName.Select();
            textID.Text = items.MaxIDPublic("MaxIDitemSP").ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            currentEditMode = EditMode.Edit;
            textID.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
            textName.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            textName.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(textID.Text) || string.IsNullOrEmpty(textName.Text)) {
                MessageBox.Show("يرجى إدخال بيانات صحيحة قبل الحفظ.");
                return;
            }

            if (!int.TryParse(textID.Text, out int id)) {
                MessageBox.Show("رقم يجب أن يكون رقمًا صحيحًا.");
                return;
            }

            string name = textName.Text;

            switch (currentEditMode) {
                case EditMode.None:
                    MessageBox.Show("لم يتم تنفيذ أي عملية!");
                    break;
                case EditMode.Add:
                    items.InsertItems(id, name);
                    MessageBox.Show("تمت الإضافة بنجاح!");
                    break;
                case EditMode.Edit:
                    items.EditItem(id, name);
                    MessageBox.Show("تم التعديل بنجاح!");
                    break;
            }

            items.LoadPublic("loadItemSP");
            dataGridView.DataSource = items.dtPublic;
            textName.Clear();
            textName.Enabled = false;
            textID.Clear();
            currentEditMode = EditMode.None;
        }
        private void btnDelete_Click(object sender, EventArgs e) {
            textID.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
            DialogResult result = MessageBox.Show("هل انت متأكد من حذف هذا العنصر", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) {
                items.DeleteItem(Convert.ToInt32(textID.Text));
            }
            items.LoadPublic("loadItemSP");
            dataGridView.DataSource = items.dtPublic;
        }
    }
}
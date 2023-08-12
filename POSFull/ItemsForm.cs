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
        }

        private void ItemsForm_Load(object sender, EventArgs e) {

        }
    }
}

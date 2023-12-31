﻿using POS;
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
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e) {
            Users users = new Users();
            users.Enable(this, false);
        }

        private void btnCategories_Click(object sender, EventArgs e) {
            ItemsForm itemsForm = new ItemsForm();
            itemsForm.ShowDialog();
        }

        private void btnProducts_Click(object sender, EventArgs e) {
            ProductsForm productsForm = new ProductsForm();
            productsForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e) {

        }

        private void btnSalesManegments_Click(object sender, EventArgs e) {
        }

        private void customersManagement_Click(object sender, EventArgs e) {
            CustomerForm customerForm = new CustomerForm();
            customerForm.ShowDialog();
        }
    }
}

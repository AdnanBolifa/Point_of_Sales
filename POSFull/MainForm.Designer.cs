namespace POSFull {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.Login = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnLogin = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnLogout = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.storage = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnCategories = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnProducts = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.Sales = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnSalesManegments = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnSaleOrders = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.purchases = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnPurchasesManagement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btnPurchaseOrders = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.suppliers = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.suppliersManagement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.customers = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.customersManagement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.users = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.usersManagement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // accordionControl1
            // 
            this.accordionControl1.Appearance.AccordionControl.BackColor = System.Drawing.Color.DimGray;
            this.accordionControl1.Appearance.AccordionControl.Options.UseBackColor = true;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.Login,
            this.storage,
            this.Sales,
            this.purchases,
            this.suppliers,
            this.customers,
            this.users});
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.Size = new System.Drawing.Size(260, 698);
            this.accordionControl1.TabIndex = 0;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // Login
            // 
            this.Login.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnLogin,
            this.btnLogout});
            this.Login.Expanded = true;
            this.Login.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Login.ImageOptions.Image")));
            this.Login.Name = "Login";
            this.Login.Text = "الدخول";
            // 
            // btnLogin
            // 
            this.btnLogin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.ImageOptions.Image")));
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnLogin.Text = "تسجيل الدخول";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Enabled = false;
            this.btnLogout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.ImageOptions.Image")));
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnLogout.Text = "تسجيل الخروج";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // storage
            // 
            this.storage.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnCategories,
            this.btnProducts});
            this.storage.Enabled = false;
            this.storage.Expanded = true;
            this.storage.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("storage.ImageOptions.Image")));
            this.storage.Name = "storage";
            this.storage.Text = "المخزن";
            // 
            // btnCategories
            // 
            this.btnCategories.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCategories.ImageOptions.Image")));
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnCategories.Text = "الاصناف";
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnProducts.ImageOptions.Image")));
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnProducts.Text = "المنتجات";
            // 
            // Sales
            // 
            this.Sales.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnSalesManegments,
            this.btnSaleOrders});
            this.Sales.Enabled = false;
            this.Sales.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Sales.ImageOptions.Image")));
            this.Sales.Name = "Sales";
            this.Sales.Text = "المبيعات";
            // 
            // btnSalesManegments
            // 
            this.btnSalesManegments.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSalesManegments.ImageOptions.Image")));
            this.btnSalesManegments.Name = "btnSalesManegments";
            this.btnSalesManegments.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnSalesManegments.Text = "ادارة المبيعات";
            // 
            // btnSaleOrders
            // 
            this.btnSaleOrders.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSaleOrders.ImageOptions.Image")));
            this.btnSaleOrders.Name = "btnSaleOrders";
            this.btnSaleOrders.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnSaleOrders.Text = "طلبات المبيعات";
            // 
            // purchases
            // 
            this.purchases.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btnPurchasesManagement,
            this.btnPurchaseOrders});
            this.purchases.Enabled = false;
            this.purchases.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("purchases.ImageOptions.Image")));
            this.purchases.Name = "purchases";
            this.purchases.Text = "المشتريات";
            // 
            // btnPurchasesManagement
            // 
            this.btnPurchasesManagement.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPurchasesManagement.ImageOptions.Image")));
            this.btnPurchasesManagement.Name = "btnPurchasesManagement";
            this.btnPurchasesManagement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnPurchasesManagement.Text = "ادارة المبيعات";
            // 
            // btnPurchaseOrders
            // 
            this.btnPurchaseOrders.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPurchaseOrders.ImageOptions.Image")));
            this.btnPurchaseOrders.Name = "btnPurchaseOrders";
            this.btnPurchaseOrders.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btnPurchaseOrders.Text = "طلبات المبيعات";
            // 
            // suppliers
            // 
            this.suppliers.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.suppliersManagement});
            this.suppliers.Enabled = false;
            this.suppliers.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("suppliers.ImageOptions.Image")));
            this.suppliers.Name = "suppliers";
            this.suppliers.Text = "الموردين";
            // 
            // suppliersManagement
            // 
            this.suppliersManagement.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("suppliersManagement.ImageOptions.Image")));
            this.suppliersManagement.Name = "suppliersManagement";
            this.suppliersManagement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.suppliersManagement.Text = "ادارة الموردين";
            // 
            // customers
            // 
            this.customers.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.customersManagement});
            this.customers.Enabled = false;
            this.customers.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("customers.ImageOptions.Image")));
            this.customers.Name = "customers";
            this.customers.Text = "العملاء";
            // 
            // customersManagement
            // 
            this.customersManagement.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("customersManagement.ImageOptions.Image")));
            this.customersManagement.Name = "customersManagement";
            this.customersManagement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.customersManagement.Text = "ادارة العملاء";
            // 
            // users
            // 
            this.users.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.usersManagement});
            this.users.Enabled = false;
            this.users.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("users.ImageOptions.Image")));
            this.users.Name = "users";
            this.users.Text = "المستخدمين";
            // 
            // usersManagement
            // 
            this.usersManagement.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("usersManagement.ImageOptions.Image")));
            this.usersManagement.Name = "usersManagement";
            this.usersManagement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.usersManagement.Text = "ادارة المستخديمن";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(809, 698);
            this.Controls.Add(this.accordionControl1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement Login;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnCategories;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnProducts;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnSalesManegments;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnSaleOrders;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnPurchasesManagement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btnPurchaseOrders;
        private DevExpress.XtraBars.Navigation.AccordionControlElement suppliersManagement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement customersManagement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement usersManagement;
        public DevExpress.XtraBars.Navigation.AccordionControlElement storage;
        public DevExpress.XtraBars.Navigation.AccordionControlElement Sales;
        public DevExpress.XtraBars.Navigation.AccordionControlElement purchases;
        public DevExpress.XtraBars.Navigation.AccordionControlElement suppliers;
        public DevExpress.XtraBars.Navigation.AccordionControlElement customers;
        public DevExpress.XtraBars.Navigation.AccordionControlElement users;
        public DevExpress.XtraBars.Navigation.AccordionControlElement btnLogin;
        public DevExpress.XtraBars.Navigation.AccordionControlElement btnLogout;
    }
}


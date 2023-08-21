namespace POSFull {
    partial class ProductsForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsForm));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gridControlProduct = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.btnDeletePic = new System.Windows.Forms.Button();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.cbItem = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pBox = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textQty = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textEarn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textSale = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textPurchase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(22, 517);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(157, 50);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(22, 441);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(157, 50);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "تعديل";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(22, 592);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(157, 50);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(22, 368);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(157, 50);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "اضافة";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gridControlProduct
            // 
            this.gridControlProduct.Location = new System.Drawing.Point(12, 12);
            this.gridControlProduct.MainView = this.gridView1;
            this.gridControlProduct.Name = "gridControlProduct";
            this.gridControlProduct.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControlProduct.Size = new System.Drawing.Size(698, 346);
            this.gridControlProduct.TabIndex = 32;
            this.gridControlProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlProduct;
            this.gridView1.Name = "gridView1";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.Cancel);
            this.groupBox.Controls.Add(this.btnDeletePic);
            this.groupBox.Controls.Add(this.btnSelectImage);
            this.groupBox.Controls.Add(this.cbItem);
            this.groupBox.Controls.Add(this.label9);
            this.groupBox.Controls.Add(this.pBox);
            this.groupBox.Controls.Add(this.label8);
            this.groupBox.Controls.Add(this.label7);
            this.groupBox.Controls.Add(this.textQty);
            this.groupBox.Controls.Add(this.label6);
            this.groupBox.Controls.Add(this.textEarn);
            this.groupBox.Controls.Add(this.label5);
            this.groupBox.Controls.Add(this.textSale);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.textPurchase);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.textName);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.textCode);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.textID);
            this.groupBox.Enabled = false;
            this.groupBox.Location = new System.Drawing.Point(202, 368);
            this.groupBox.Name = "groupBox";
            this.groupBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox.Size = new System.Drawing.Size(508, 274);
            this.groupBox.TabIndex = 33;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "بيانات المنتجات";
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.Image = ((System.Drawing.Image)(resources.GetObject("Cancel.Image")));
            this.Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cancel.Location = new System.Drawing.Point(66, 224);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(94, 28);
            this.Cancel.TabIndex = 55;
            this.Cancel.Text = "الغاء الامر";
            this.Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // btnDeletePic
            // 
            this.btnDeletePic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePic.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletePic.Image")));
            this.btnDeletePic.Location = new System.Drawing.Point(21, 186);
            this.btnDeletePic.Name = "btnDeletePic";
            this.btnDeletePic.Size = new System.Drawing.Size(25, 28);
            this.btnDeletePic.TabIndex = 54;
            this.btnDeletePic.UseVisualStyleBackColor = true;
            this.btnDeletePic.Click += new System.EventHandler(this.btnDeletePic_Click);
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectImage.Location = new System.Drawing.Point(52, 186);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(151, 28);
            this.btnSelectImage.TabIndex = 52;
            this.btnSelectImage.Text = "...";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // cbItem
            // 
            this.cbItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbItem.FormattingEnabled = true;
            this.cbItem.Location = new System.Drawing.Point(222, 238);
            this.cbItem.Name = "cbItem";
            this.cbItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbItem.Size = new System.Drawing.Size(184, 24);
            this.cbItem.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(413, 241);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(50, 17);
            this.label9.TabIndex = 50;
            this.label9.Text = "الصنف:";
            // 
            // pBox
            // 
            this.pBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox.Location = new System.Drawing.Point(20, 56);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(183, 124);
            this.pBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox.TabIndex = 49;
            this.pBox.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(66, 33);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(91, 17);
            this.label8.TabIndex = 48;
            this.label8.Text = "صورة المنتجح:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(413, 210);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(94, 17);
            this.label7.TabIndex = 47;
            this.label7.Text = "الكمبية المخزنة:";
            // 
            // textQty
            // 
            this.textQty.Location = new System.Drawing.Point(222, 210);
            this.textQty.Margin = new System.Windows.Forms.Padding(4);
            this.textQty.Name = "textQty";
            this.textQty.Size = new System.Drawing.Size(183, 23);
            this.textQty.TabIndex = 46;
            this.textQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(413, 183);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 45;
            this.label6.Text = "سعر الربح:";
            // 
            // textEarn
            // 
            this.textEarn.Location = new System.Drawing.Point(222, 180);
            this.textEarn.Margin = new System.Windows.Forms.Padding(4);
            this.textEarn.Name = "textEarn";
            this.textEarn.ReadOnly = true;
            this.textEarn.Size = new System.Drawing.Size(183, 23);
            this.textEarn.TabIndex = 44;
            this.textEarn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textEarn.TextChanged += new System.EventHandler(this.textEarn_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(413, 155);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 43;
            this.label5.Text = "سعر البيع:";
            // 
            // textSale
            // 
            this.textSale.Location = new System.Drawing.Point(222, 149);
            this.textSale.Margin = new System.Windows.Forms.Padding(4);
            this.textSale.Name = "textSale";
            this.textSale.Size = new System.Drawing.Size(183, 23);
            this.textSale.TabIndex = 42;
            this.textSale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textSale.TextChanged += new System.EventHandler(this.textPurchase_TextChanged);
            this.textSale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSale_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(413, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "سعر الشراء:";
            // 
            // textPurchase
            // 
            this.textPurchase.Location = new System.Drawing.Point(222, 118);
            this.textPurchase.Margin = new System.Windows.Forms.Padding(4);
            this.textPurchase.Name = "textPurchase";
            this.textPurchase.Size = new System.Drawing.Size(183, 23);
            this.textPurchase.TabIndex = 40;
            this.textPurchase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textPurchase.TextChanged += new System.EventHandler(this.textPurchase_TextChanged);
            this.textPurchase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPurchase_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 39;
            this.label3.Text = "الاسم:";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(222, 87);
            this.textName.Margin = new System.Windows.Forms.Padding(4);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(183, 23);
            this.textName.TabIndex = 38;
            this.textName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(413, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "الكود:";
            // 
            // textCode
            // 
            this.textCode.Location = new System.Drawing.Point(222, 56);
            this.textCode.Margin = new System.Windows.Forms.Padding(4);
            this.textCode.Name = "textCode";
            this.textCode.Size = new System.Drawing.Size(183, 23);
            this.textCode.TabIndex = 36;
            this.textCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(413, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "رقم المنتج:";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(222, 27);
            this.textID.Margin = new System.Windows.Forms.Padding(4);
            this.textID.Name = "textID";
            this.textID.ReadOnly = true;
            this.textID.Size = new System.Drawing.Size(183, 23);
            this.textID.TabIndex = 34;
            this.textID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.AllowUserToAddRows = false;
            this.dataGridViewProduct.AllowUserToDeleteRows = false;
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.Location = new System.Drawing.Point(22, 662);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.ReadOnly = true;
            this.dataGridViewProduct.Size = new System.Drawing.Size(157, 31);
            this.dataGridViewProduct.TabIndex = 53;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 660);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.dataGridViewProduct);
            this.Controls.Add(this.gridControlProduct);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "ProductsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة المنتجات";
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private DevExpress.XtraGrid.GridControl gridControlProduct;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.ComboBox cbItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textQty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textEarn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textSale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textPurchase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textID;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private System.Windows.Forms.Button btnDeletePic;
        private System.Windows.Forms.Button Cancel;
    }
}
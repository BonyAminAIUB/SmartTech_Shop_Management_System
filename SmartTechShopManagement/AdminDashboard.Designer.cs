namespace SmartTechShopManagement
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlLeftDashboard = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.pnlOverview = new System.Windows.Forms.Panel();
            this.pnlProductManagement = new System.Windows.Forms.Panel();
            this.cbxProductBrand = new System.Windows.Forms.ComboBox();
            this.txbProductPrice = new System.Windows.Forms.TextBox();
            this.txbProductQuantity = new System.Windows.Forms.TextBox();
            this.txbProductCatagory = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbProductName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAllProduct = new System.Windows.Forms.DataGridView();
            this.pnlSalesReport = new System.Windows.Forms.Panel();
            this.pnlStaffAccount = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvExistingStaff = new System.Windows.Forms.DataGridView();
            this.lblExistingStaff = new System.Windows.Forms.Label();
            this.pnlLeftDashboard.SuspendLayout();
            this.pnlProductManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllProduct)).BeginInit();
            this.pnlStaffAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExistingStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeftDashboard
            // 
            this.pnlLeftDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnlLeftDashboard.Controls.Add(this.button2);
            this.pnlLeftDashboard.Controls.Add(this.button1);
            this.pnlLeftDashboard.Controls.Add(this.button6);
            this.pnlLeftDashboard.Controls.Add(this.button4);
            this.pnlLeftDashboard.Controls.Add(this.btnProducts);
            this.pnlLeftDashboard.Controls.Add(this.lblDashboard);
            this.pnlLeftDashboard.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftDashboard.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftDashboard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlLeftDashboard.Name = "pnlLeftDashboard";
            this.pnlLeftDashboard.Size = new System.Drawing.Size(400, 1694);
            this.pnlLeftDashboard.TabIndex = 1;
            this.pnlLeftDashboard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLeftDashboard_Paint);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 363);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(400, 88);
            this.button2.TabIndex = 5;
            this.button2.Text = "Staff Accounts";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 273);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(400, 88);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sales Report";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Red;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(0, 1604);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(400, 88);
            this.button6.TabIndex = 3;
            this.button6.Text = "Log Out";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(0, 183);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(400, 88);
            this.button4.TabIndex = 2;
            this.button4.Text = "Product Management";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.SystemColors.Control;
            this.btnProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.Location = new System.Drawing.Point(0, 94);
            this.btnProducts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(400, 88);
            this.btnProducts.TabIndex = 1;
            this.btnProducts.Text = "Overview";
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.Location = new System.Drawing.Point(86, 4);
            this.lblDashboard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(209, 88);
            this.lblDashboard.TabIndex = 0;
            this.lblDashboard.Text = "Dashboard";
            // 
            // pnlOverview
            // 
            this.pnlOverview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOverview.Location = new System.Drawing.Point(400, 0);
            this.pnlOverview.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlOverview.Name = "pnlOverview";
            this.pnlOverview.Size = new System.Drawing.Size(2484, 1694);
            this.pnlOverview.TabIndex = 2;
            // 
            // pnlProductManagement
            // 
            this.pnlProductManagement.Controls.Add(this.cbxProductBrand);
            this.pnlProductManagement.Controls.Add(this.txbProductPrice);
            this.pnlProductManagement.Controls.Add(this.txbProductQuantity);
            this.pnlProductManagement.Controls.Add(this.txbProductCatagory);
            this.pnlProductManagement.Controls.Add(this.label7);
            this.pnlProductManagement.Controls.Add(this.label6);
            this.pnlProductManagement.Controls.Add(this.label5);
            this.pnlProductManagement.Controls.Add(this.label4);
            this.pnlProductManagement.Controls.Add(this.txbProductName);
            this.pnlProductManagement.Controls.Add(this.label3);
            this.pnlProductManagement.Controls.Add(this.label2);
            this.pnlProductManagement.Controls.Add(this.button8);
            this.pnlProductManagement.Controls.Add(this.label1);
            this.pnlProductManagement.Controls.Add(this.dgvAllProduct);
            this.pnlProductManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProductManagement.Location = new System.Drawing.Point(400, 0);
            this.pnlProductManagement.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlProductManagement.Name = "pnlProductManagement";
            this.pnlProductManagement.Size = new System.Drawing.Size(2484, 1694);
            this.pnlProductManagement.TabIndex = 0;
            // 
            // cbxProductBrand
            // 
            this.cbxProductBrand.FormattingEnabled = true;
            this.cbxProductBrand.Items.AddRange(new object[] {
            "Asus",
            "NZXT",
            "Asrock",
            "Hp",
            "Lenovo"});
            this.cbxProductBrand.Location = new System.Drawing.Point(666, 94);
            this.cbxProductBrand.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbxProductBrand.Name = "cbxProductBrand";
            this.cbxProductBrand.Size = new System.Drawing.Size(238, 33);
            this.cbxProductBrand.TabIndex = 15;
            // 
            // txbProductPrice
            // 
            this.txbProductPrice.Location = new System.Drawing.Point(1654, 98);
            this.txbProductPrice.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txbProductPrice.Name = "txbProductPrice";
            this.txbProductPrice.Size = new System.Drawing.Size(206, 31);
            this.txbProductPrice.TabIndex = 14;
            // 
            // txbProductQuantity
            // 
            this.txbProductQuantity.Location = new System.Drawing.Point(2160, 98);
            this.txbProductQuantity.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txbProductQuantity.Name = "txbProductQuantity";
            this.txbProductQuantity.Size = new System.Drawing.Size(280, 31);
            this.txbProductQuantity.TabIndex = 13;
            this.txbProductQuantity.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txbProductCatagory
            // 
            this.txbProductCatagory.Location = new System.Drawing.Point(1170, 102);
            this.txbProductCatagory.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txbProductCatagory.Name = "txbProductCatagory";
            this.txbProductCatagory.Size = new System.Drawing.Size(280, 31);
            this.txbProductCatagory.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1950, 98);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 37);
            this.label7.TabIndex = 11;
            this.label7.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1524, 94);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 37);
            this.label6.TabIndex = 10;
            this.label6.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(982, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 37);
            this.label5.TabIndex = 9;
            this.label5.Text = "Catagory";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(514, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 37);
            this.label4.TabIndex = 7;
            this.label4.Text = "Brand";
            // 
            // txbProductName
            // 
            this.txbProductName.Location = new System.Drawing.Point(200, 94);
            this.txbProductName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txbProductName.Name = "txbProductName";
            this.txbProductName.Size = new System.Drawing.Size(224, 31);
            this.txbProductName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(864, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Add New Product";
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(832, 169);
            this.button8.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(314, 58);
            this.button8.TabIndex = 3;
            this.button8.Text = "Save New Product";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(902, 233);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "All Product";
            // 
            // dgvAllProduct
            // 
            this.dgvAllProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllProduct.Location = new System.Drawing.Point(28, 290);
            this.dgvAllProduct.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvAllProduct.Name = "dgvAllProduct";
            this.dgvAllProduct.RowHeadersWidth = 82;
            this.dgvAllProduct.Size = new System.Drawing.Size(2436, 1381);
            this.dgvAllProduct.TabIndex = 0;
            // 
            // pnlSalesReport
            // 
            this.pnlSalesReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSalesReport.Location = new System.Drawing.Point(400, 0);
            this.pnlSalesReport.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlSalesReport.Name = "pnlSalesReport";
            this.pnlSalesReport.Size = new System.Drawing.Size(2484, 1694);
            this.pnlSalesReport.TabIndex = 0;
            // 
            // pnlStaffAccount
            // 
            this.pnlStaffAccount.Controls.Add(this.button5);
            this.pnlStaffAccount.Controls.Add(this.button3);
            this.pnlStaffAccount.Controls.Add(this.dgvExistingStaff);
            this.pnlStaffAccount.Controls.Add(this.lblExistingStaff);
            this.pnlStaffAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStaffAccount.Location = new System.Drawing.Point(400, 0);
            this.pnlStaffAccount.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlStaffAccount.Name = "pnlStaffAccount";
            this.pnlStaffAccount.Size = new System.Drawing.Size(2484, 1694);
            this.pnlStaffAccount.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(2270, 117);
            this.button5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(194, 54);
            this.button5.TabIndex = 3;
            this.button5.Text = "Refresh";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(884, 1544);
            this.button3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(476, 62);
            this.button3.TabIndex = 2;
            this.button3.Text = "Add New Employee";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgvExistingStaff
            // 
            this.dgvExistingStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExistingStaff.Location = new System.Drawing.Point(28, 183);
            this.dgvExistingStaff.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvExistingStaff.Name = "dgvExistingStaff";
            this.dgvExistingStaff.RowHeadersWidth = 82;
            this.dgvExistingStaff.Size = new System.Drawing.Size(2436, 1298);
            this.dgvExistingStaff.TabIndex = 1;
            this.dgvExistingStaff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblExistingStaff
            // 
            this.lblExistingStaff.AutoSize = true;
            this.lblExistingStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExistingStaff.Location = new System.Drawing.Point(762, 25);
            this.lblExistingStaff.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblExistingStaff.Name = "lblExistingStaff";
            this.lblExistingStaff.Size = new System.Drawing.Size(203, 37);
            this.lblExistingStaff.TabIndex = 0;
            this.lblExistingStaff.Text = "Existing Staff";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2884, 1694);
            this.Controls.Add(this.pnlProductManagement);
            this.Controls.Add(this.pnlStaffAccount);
            this.Controls.Add(this.pnlSalesReport);
            this.Controls.Add(this.pnlOverview);
            this.Controls.Add(this.pnlLeftDashboard);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlLeftDashboard.ResumeLayout(false);
            this.pnlLeftDashboard.PerformLayout();
            this.pnlProductManagement.ResumeLayout(false);
            this.pnlProductManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllProduct)).EndInit();
            this.pnlStaffAccount.ResumeLayout(false);
            this.pnlStaffAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExistingStaff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeftDashboard;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pnlOverview;
        private System.Windows.Forms.Panel pnlProductManagement;
        private System.Windows.Forms.Panel pnlSalesReport;
        private System.Windows.Forms.Panel pnlStaffAccount;
        private System.Windows.Forms.Label lblExistingStaff;
        private System.Windows.Forms.DataGridView dgvExistingStaff;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAllProduct;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbProductName;
        private System.Windows.Forms.TextBox txbProductPrice;
        private System.Windows.Forms.TextBox txbProductQuantity;
        private System.Windows.Forms.TextBox txbProductCatagory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxProductBrand;
    }
}
namespace SmartTechShopManagement
{
    partial class Dashboard
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
            this.button6 = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.pnlLeftDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeftDashboard
            // 
            this.pnlLeftDashboard.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlLeftDashboard.Controls.Add(this.button6);
            this.pnlLeftDashboard.Controls.Add(this.btnUsers);
            this.pnlLeftDashboard.Controls.Add(this.button4);
            this.pnlLeftDashboard.Controls.Add(this.button3);
            this.pnlLeftDashboard.Controls.Add(this.button2);
            this.pnlLeftDashboard.Controls.Add(this.btnDashboard);
            this.pnlLeftDashboard.Controls.Add(this.btnProducts);
            this.pnlLeftDashboard.Controls.Add(this.lblDashboard);
            this.pnlLeftDashboard.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftDashboard.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftDashboard.Name = "pnlLeftDashboard";
            this.pnlLeftDashboard.Size = new System.Drawing.Size(432, 1129);
            this.pnlLeftDashboard.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button6.Location = new System.Drawing.Point(62, 888);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(233, 101);
            this.button6.TabIndex = 7;
            this.button6.Text = "Products";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUsers.Location = new System.Drawing.Point(62, 763);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(233, 101);
            this.btnUsers.TabIndex = 6;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Location = new System.Drawing.Point(62, 645);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(233, 101);
            this.button4.TabIndex = 5;
            this.button4.Text = "Products";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(62, 524);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(233, 101);
            this.button3.TabIndex = 4;
            this.button3.Text = "Products";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(62, 404);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(233, 101);
            this.button2.TabIndex = 3;
            this.button2.Text = "Products";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDashboard.Location = new System.Drawing.Point(62, 170);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(233, 101);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnProducts.Location = new System.Drawing.Point(62, 288);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(233, 101);
            this.btnProducts.TabIndex = 1;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Gabriola", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.Location = new System.Drawing.Point(48, 9);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(323, 158);
            this.lblDashboard.TabIndex = 0;
            this.lblDashboard.Text = "SmartTech Shop\r\nManagement System";
            this.lblDashboard.Click += new System.EventHandler(this.lblDashboard_Click);
            // 
            // Dashboard
            // 
            this.AcceptButton = this.btnProducts;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1602, 1129);
            this.Controls.Add(this.pnlLeftDashboard);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlLeftDashboard.ResumeLayout(false);
            this.pnlLeftDashboard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeftDashboard;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDashboard;
    }
}
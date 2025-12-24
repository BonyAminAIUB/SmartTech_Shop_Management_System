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
            this.btnProducts = new System.Windows.Forms.Button();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.pnlLeftDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeftDashboard
            // 
            this.pnlLeftDashboard.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlLeftDashboard.Controls.Add(this.btnProducts);
            this.pnlLeftDashboard.Controls.Add(this.lblDashboard);
            this.pnlLeftDashboard.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftDashboard.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftDashboard.Name = "pnlLeftDashboard";
            this.pnlLeftDashboard.Size = new System.Drawing.Size(375, 1019);
            this.pnlLeftDashboard.TabIndex = 0;
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnProducts.Location = new System.Drawing.Point(61, 166);
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
            this.lblDashboard.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.Location = new System.Drawing.Point(72, 48);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(209, 88);
            this.lblDashboard.TabIndex = 0;
            this.lblDashboard.Text = "Dashboard";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1602, 1019);
            this.Controls.Add(this.pnlLeftDashboard);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.pnlLeftDashboard.ResumeLayout(false);
            this.pnlLeftDashboard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeftDashboard;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Button btnProducts;
    }
}
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
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.pnlLeftDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeftDashboard
            // 
            this.pnlLeftDashboard.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlLeftDashboard.Controls.Add(this.button6);
            this.pnlLeftDashboard.Controls.Add(this.button4);
            this.pnlLeftDashboard.Controls.Add(this.btnProducts);
            this.pnlLeftDashboard.Controls.Add(this.lblDashboard);
            this.pnlLeftDashboard.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftDashboard.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftDashboard.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLeftDashboard.Name = "pnlLeftDashboard";
            this.pnlLeftDashboard.Size = new System.Drawing.Size(200, 881);
            this.pnlLeftDashboard.TabIndex = 1;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Red;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(0, 834);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(200, 46);
            this.button6.TabIndex = 3;
            this.button6.Text = "Log Out";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(0, 95);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 46);
            this.button4.TabIndex = 2;
            this.button4.Text = "Employee Sales";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.SystemColors.Control;
            this.btnProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.Location = new System.Drawing.Point(0, 49);
            this.btnProducts.Margin = new System.Windows.Forms.Padding(2);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(200, 46);
            this.btnProducts.TabIndex = 1;
            this.btnProducts.Text = "POS";
            this.btnProducts.UseVisualStyleBackColor = false;
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.Location = new System.Drawing.Point(43, 2);
            this.lblDashboard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(113, 45);
            this.lblDashboard.TabIndex = 0;
            this.lblDashboard.Text = "Dashboard";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 881);
            this.Controls.Add(this.pnlLeftDashboard);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlLeftDashboard.ResumeLayout(false);
            this.pnlLeftDashboard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeftDashboard;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Label lblDashboard;
    }
}
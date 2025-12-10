namespace SmartTechShopManagement
{
    partial class Home
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
            this.lblSmartTech = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnPcbuild = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSmartTech
            // 
            this.lblSmartTech.AutoSize = true;
            this.lblSmartTech.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSmartTech.ForeColor = System.Drawing.Color.Black;
            this.lblSmartTech.Location = new System.Drawing.Point(12, 12);
            this.lblSmartTech.Name = "lblSmartTech";
            this.lblSmartTech.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSmartTech.Size = new System.Drawing.Size(156, 31);
            this.lblSmartTech.TabIndex = 0;
            this.lblSmartTech.Text = "SmartTech";
            this.lblSmartTech.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(174, 12);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(1009, 30);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Text = "Search";
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1189, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(31, 30);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnPcbuild
            // 
            this.btnPcbuild.Location = new System.Drawing.Point(1226, 12);
            this.btnPcbuild.Name = "btnPcbuild";
            this.btnPcbuild.Size = new System.Drawing.Size(100, 30);
            this.btnPcbuild.TabIndex = 3;
            this.btnPcbuild.Text = "Pc Build";
            this.btnPcbuild.UseVisualStyleBackColor = true;
            this.btnPcbuild.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(1332, 12);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(100, 30);
            this.btnProfile.TabIndex = 5;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1444, 881);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnPcbuild);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSmartTech);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.Text = "SmartTech Shop Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.btnSearch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSmartTech;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnPcbuild;
        private System.Windows.Forms.Button btnProfile;
    }
}


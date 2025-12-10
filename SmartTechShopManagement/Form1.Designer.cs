namespace SmartTechShopManagement
{
    partial class btnSearch
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnPcbuild = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSmartTech
            // 
            this.lblSmartTech.AutoSize = true;
            this.lblSmartTech.ForeColor = System.Drawing.Color.Black;
            this.lblSmartTech.Location = new System.Drawing.Point(197, 46);
            this.lblSmartTech.Name = "lblSmartTech";
            this.lblSmartTech.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSmartTech.Size = new System.Drawing.Size(118, 25);
            this.lblSmartTech.TabIndex = 0;
            this.lblSmartTech.Text = "SmartTech";
            this.lblSmartTech.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(550, 45);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 30);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Text = "Search";
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(648, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnPcbuild
            // 
            this.btnPcbuild.Location = new System.Drawing.Point(710, 42);
            this.btnPcbuild.Name = "btnPcbuild";
            this.btnPcbuild.Size = new System.Drawing.Size(127, 30);
            this.btnPcbuild.TabIndex = 3;
            this.btnPcbuild.Text = "PcBuild";
            this.btnPcbuild.UseVisualStyleBackColor = true;
            this.btnPcbuild.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(883, 42);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(94, 33);
            this.btnProfile.TabIndex = 5;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 899);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnPcbuild);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSmartTech);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "btnSearch";
            this.Text = "SmartTech Shop Management System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSmartTech;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPcbuild;
        private System.Windows.Forms.Button btnProfile;
    }
}


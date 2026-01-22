namespace SmartTechShopManagement
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.txtUserBlank = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPasswordBlank = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.picBoxPassHide = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPassHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 275);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(811, 51);
            this.label1.TabIndex = 3;
            this.label1.Text = "SmartTech Shop Mangement System | Log In";
            // 
            // txbUsername
            // 
            this.txbUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUsername.Location = new System.Drawing.Point(354, 415);
            this.txbUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(134, 39);
            this.txbUsername.TabIndex = 6;
            this.txbUsername.Text = "Username:";
            this.txbUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUserBlank
            // 
            this.txtUserBlank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserBlank.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserBlank.Location = new System.Drawing.Point(354, 469);
            this.txtUserBlank.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserBlank.Name = "txtUserBlank";
            this.txtUserBlank.Size = new System.Drawing.Size(554, 39);
            this.txtUserBlank.TabIndex = 7;
            this.txtUserBlank.TextChanged += new System.EventHandler(this.txtUserBlank_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(354, 533);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(134, 39);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.Text = "Password:";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtPasswordBlank
            // 
            this.txtPasswordBlank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPasswordBlank.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordBlank.Location = new System.Drawing.Point(354, 592);
            this.txtPasswordBlank.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPasswordBlank.Name = "txtPasswordBlank";
            this.txtPasswordBlank.Size = new System.Drawing.Size(554, 39);
            this.txtPasswordBlank.TabIndex = 9;
            this.txtPasswordBlank.UseSystemPasswordChar = true;
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.Color.White;
            this.btnLogIn.Location = new System.Drawing.Point(476, 738);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(320, 70);
            this.btnLogIn.TabIndex = 12;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // picBoxPassHide
            // 
            this.picBoxPassHide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxPassHide.Image = global::SmartTechShopManagement.Properties.Resources._159604;
            this.picBoxPassHide.Location = new System.Drawing.Point(918, 592);
            this.picBoxPassHide.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picBoxPassHide.Name = "picBoxPassHide";
            this.picBoxPassHide.Size = new System.Drawing.Size(58, 39);
            this.picBoxPassHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxPassHide.TabIndex = 10;
            this.picBoxPassHide.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SmartTechShopManagement.Properties.Resources.computer_icon;
            this.pictureBox2.Location = new System.Drawing.Point(476, 21);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(344, 215);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(525, 651);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 63);
            this.button1.TabIndex = 14;
            this.button1.Text = "Forget Password";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1332, 881);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.picBoxPassHide);
            this.Controls.Add(this.txtPasswordBlank);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserBlank);
            this.Controls.Add(this.txbUsername);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SmartTech Shop Management System | Log In";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPassHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.TextBox txtUserBlank;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPasswordBlank;
        private System.Windows.Forms.PictureBox picBoxPassHide;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button button1;
    }
}


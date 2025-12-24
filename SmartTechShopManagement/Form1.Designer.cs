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
            this.btnRegistration = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.txtUserBlank = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPasswordBlank = new System.Windows.Forms.TextBox();
            this.picBoxPassHide = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtForgotPass = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPassHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistration
            // 
            this.btnRegistration.Location = new System.Drawing.Point(866, 471);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(75, 23);
            this.btnRegistration.TabIndex = 1;
            this.btnRegistration.Text = "button2";
            this.btnRegistration.UseVisualStyleBackColor = true;
            this.btnRegistration.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "SmartTech Shop Mangement System | Log In";
            // 
            // txbUsername
            // 
            this.txbUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUsername.Location = new System.Drawing.Point(265, 428);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(100, 31);
            this.txbUsername.TabIndex = 6;
            this.txbUsername.Text = "Username:";
            this.txbUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUserBlank
            // 
            this.txtUserBlank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserBlank.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserBlank.Location = new System.Drawing.Point(265, 471);
            this.txtUserBlank.Name = "txtUserBlank";
            this.txtUserBlank.Size = new System.Drawing.Size(416, 31);
            this.txtUserBlank.TabIndex = 7;
            this.txtUserBlank.TextChanged += new System.EventHandler(this.txtUserBlank_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(265, 522);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 31);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.Text = "Password:";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtPasswordBlank
            // 
            this.txtPasswordBlank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPasswordBlank.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordBlank.Location = new System.Drawing.Point(265, 570);
            this.txtPasswordBlank.Name = "txtPasswordBlank";
            this.txtPasswordBlank.Size = new System.Drawing.Size(416, 31);
            this.txtPasswordBlank.TabIndex = 9;
            this.txtPasswordBlank.UseSystemPasswordChar = true;
            // 
            // picBoxPassHide
            // 
            this.picBoxPassHide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxPassHide.Image = global::SmartTechShopManagement.Properties.Resources._159604;
            this.picBoxPassHide.Location = new System.Drawing.Point(677, 595);
            this.picBoxPassHide.Name = "picBoxPassHide";
            this.picBoxPassHide.Size = new System.Drawing.Size(44, 31);
            this.picBoxPassHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxPassHide.TabIndex = 10;
            this.picBoxPassHide.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SmartTechShopManagement.Properties.Resources.multiply_logo;
            this.pictureBox3.Location = new System.Drawing.Point(890, 41);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 71);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SmartTechShopManagement.Properties.Resources.computer_icon;
            this.pictureBox2.Location = new System.Drawing.Point(294, 161);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(303, 225);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SmartTechShopManagement.Properties.Resources.pngtree_computer_icon_vector_png_image_6698791;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtForgotPass
            // 
            this.txtForgotPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtForgotPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtForgotPass.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtForgotPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtForgotPass.Location = new System.Drawing.Point(397, 607);
            this.txtForgotPass.Name = "txtForgotPass";
            this.txtForgotPass.Size = new System.Drawing.Size(155, 31);
            this.txtForgotPass.TabIndex = 11;
            this.txtForgotPass.Text = "Forgot Password?";
            this.txtForgotPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.Color.White;
            this.btnLogIn.Location = new System.Drawing.Point(356, 644);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(241, 44);
            this.btnLogIn.TabIndex = 12;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.txtForgotPass);
            this.Controls.Add(this.picBoxPassHide);
            this.Controls.Add(this.txtPasswordBlank);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserBlank);
            this.Controls.Add(this.txbUsername);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRegistration);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SmartTech Shop Management System | Log In";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPassHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistration;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.TextBox txtUserBlank;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPasswordBlank;
        private System.Windows.Forms.PictureBox picBoxPassHide;
        private System.Windows.Forms.TextBox txtForgotPass;
        private System.Windows.Forms.Button btnLogIn;
    }
}


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
            this.btnLogIn = new System.Windows.Forms.Button();
            this.llblForgetPass = new System.Windows.Forms.LinkLabel();
            this.picBoxPassHide = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPassHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistration
            // 
            this.btnRegistration.Location = new System.Drawing.Point(1172, 394);
            this.btnRegistration.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(100, 29);
            this.btnRegistration.TabIndex = 1;
            this.btnRegistration.Text = "button2";
            this.btnRegistration.UseVisualStyleBackColor = true;
            this.btnRegistration.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(512, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "SmartTech Shop Mangement System | Log In";
            // 
            // txbUsername
            // 
            this.txbUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUsername.Location = new System.Drawing.Point(353, 535);
            this.txbUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(133, 39);
            this.txbUsername.TabIndex = 6;
            this.txbUsername.Text = "Username:";
            this.txbUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUserBlank
            // 
            this.txtUserBlank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserBlank.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserBlank.Location = new System.Drawing.Point(353, 589);
            this.txtUserBlank.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserBlank.Name = "txtUserBlank";
            this.txtUserBlank.Size = new System.Drawing.Size(554, 39);
            this.txtUserBlank.TabIndex = 7;
            this.txtUserBlank.TextChanged += new System.EventHandler(this.txtUserBlank_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(353, 652);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(133, 39);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.Text = "Password:";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtPasswordBlank
            // 
            this.txtPasswordBlank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPasswordBlank.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordBlank.Location = new System.Drawing.Point(353, 712);
            this.txtPasswordBlank.Margin = new System.Windows.Forms.Padding(4);
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
            this.btnLogIn.Location = new System.Drawing.Point(475, 805);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(321, 55);
            this.btnLogIn.TabIndex = 12;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // llblForgetPass
            // 
            this.llblForgetPass.AutoSize = true;
            this.llblForgetPass.Location = new System.Drawing.Point(526, 757);
            this.llblForgetPass.Name = "llblForgetPass";
            this.llblForgetPass.Size = new System.Drawing.Size(186, 25);
            this.llblForgetPass.TabIndex = 13;
            this.llblForgetPass.TabStop = true;
            this.llblForgetPass.Text = "Forget Password?";
            // 
            // picBoxPassHide
            // 
            this.picBoxPassHide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxPassHide.Image = global::SmartTechShopManagement.Properties.Resources._159604;
            this.picBoxPassHide.Location = new System.Drawing.Point(915, 712);
            this.picBoxPassHide.Margin = new System.Windows.Forms.Padding(4);
            this.picBoxPassHide.Name = "picBoxPassHide";
            this.picBoxPassHide.Size = new System.Drawing.Size(58, 38);
            this.picBoxPassHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxPassHide.TabIndex = 10;
            this.picBoxPassHide.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SmartTechShopManagement.Properties.Resources.multiply_logo;
            this.pictureBox3.Location = new System.Drawing.Point(1187, 51);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(85, 89);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SmartTechShopManagement.Properties.Resources.computer_icon;
            this.pictureBox2.Location = new System.Drawing.Point(392, 201);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(404, 281);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SmartTechShopManagement.Properties.Resources.pngtree_computer_icon_vector_png_image_6698791;
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1333, 1000);
            this.Controls.Add(this.llblForgetPass);
            this.Controls.Add(this.btnLogIn);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SmartTech Shop Management System | Log In";
            this.Load += new System.EventHandler(this.LoginForm_Load);
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
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.LinkLabel llblForgetPass;
    }
}


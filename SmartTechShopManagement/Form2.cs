using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartTechShopManagement
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            //if (txtUsername.Text.Trim() == string.Empty)
            //{
            //    MessageBox.Show("Please enter user name.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}
            //else if (txtEmail.Text.Trim() == string.Empty)
            //{
            //    MessageBox.Show("Please enter email.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}
            //else
            //{
            //    string pass = Computer.Computer.ForgotPassword(
            //        txtUsername.Text.Trim(),
            //        txtEmail.Text.Trim()
            //    );

            //    if (pass != string.Empty)
            //    {
            //        MessageBox.Show(
            //            $"Your password is: {pass}",
            //            "Information",
            //            MessageBoxButtons.OK,
            //            MessageBoxIcon.Information
            //        );
            //    }
            //    else
            //    {
            //        MessageBox.Show(
            //            "Username or email is incorrect!",
            //            "Information",
            //            MessageBoxButtons.OK,
            //            MessageBoxIcon.Information
            //        );
            //    }
            //}
            Connection conn = new Connection();
            string query = $"update empInfoTb set empPassword = '{txtPassword.Text}'  where empUsername='{txtUserBlank.Text}'";
            conn.push(query);
            MessageBox.Show("Password Reset Successfully");

        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {

        }
    }
}

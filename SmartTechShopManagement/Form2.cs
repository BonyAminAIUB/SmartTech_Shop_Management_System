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

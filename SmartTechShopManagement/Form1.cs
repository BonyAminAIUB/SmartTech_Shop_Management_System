using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartTechShopManagement
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistrationForm regForm = new RegistrationForm();
            regForm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtUserBlank_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            //CashierDashboard dashboard = new CashierDashboard();
            //dashboard.Show();
            //this.Hide();
            if (cbxLogin.Text == "Admin") 
            {
                AdminDashboard adminDashboard = new AdminDashboard();
                adminDashboard.Show();
                this.Hide();
            }
            else if(cbxLogin.Text == "Cashier")
            {
                SalesmanDashboard cashierDashboard = new SalesmanDashboard();
                cashierDashboard.Show();
                this.Hide();
            }
            else if(cbxLogin.Text == "Manager")
            {
                ManagerDashboard managerDashboard = new ManagerDashboard();
                managerDashboard.Show();
                this.Hide();
            }
        }

        private void llblForgetPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}

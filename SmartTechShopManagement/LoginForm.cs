using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SmartTechShopManagement
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        public static string sharedUsername = "";

        private void button2_Click(object sender, EventArgs e)
        {
            //Form3 regForm = new RegistrationForm();
            //regForm.Show();
            //this.Hide();
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
            string query = "SELECT empUsername,empPassword, empRole FROM empInfoTb";
            Connection connection = new Connection();
            DataTable empUnameAndRole = connection.pullForDataTable(query);

            string username, password;
            username = txtUserBlank.Text;
            password = txtPasswordBlank.Text;
            sharedUsername = username;

            bool userfound = false;
            int lengthRow = empUnameAndRole.Rows.Count;

            for (int i = 0; userfound == false && i < lengthRow; i += 1)
            {
                if (empUnameAndRole.Rows[i]["empUsername"].ToString() == username && empUnameAndRole.Rows[i]["empPassword"].ToString() == password)
                {
                    userfound = true;
                    if (empUnameAndRole.Rows[i]["empRole"].ToString() == "Admin")
                    {
                        AdminDashboard adminDashboard = new AdminDashboard();
                        adminDashboard.Show();
                        this.Hide();
                    }
                    else if (empUnameAndRole.Rows[i]["empRole"].ToString() == "Manager")
                    {
                        ManagerDashboard managerDashboard = new ManagerDashboard();
                        managerDashboard.Show();
                        this.Hide();
                    }
                    else if (empUnameAndRole.Rows[i]["empRole"].ToString() == "Salesman")
                    {
                        SalesmanDashboard salesmanDashboard = new SalesmanDashboard();
                        salesmanDashboard.Show();
                        this.Hide();
                    }
                    break;
                    //else
                    //{
                    //    MessageBox.Show("")
                    //}
                }

                //break;
            }
            string query2 = "insert into loginTrackingTb (username, loginTime) values ('" + username + "', '" + DateTime.Now.ToString() + "')";
            connection.push(query2);
            if (userfound == false)
            {
                MessageBox.Show("Invalid Username or Password!");
            }

            //simple login
            //string role = cbxLogin.Text;
            //if(role == "Admin")
            //{
            //    AdminDashboard adminDashboard = new AdminDashboard();
            //    adminDashboard.Show();
            //    this.Hide();
            //}
            //else if(role == "Manager")
            //{
            //    ManagerDashboard managerDashboard = new ManagerDashboard();
            //    managerDashboard.Show();
            //    this.Hide();
            //}
            //else if (role == "Salesman")
            //{
            //    SalesmanDashboard salesmanDashboard = new SalesmanDashboard();
            //    salesmanDashboard.Show();
            //    this.Hide();
            //}
        }

        private void llblForgetPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}

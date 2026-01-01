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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void pnlLeftDashboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            pnlOverview.Visible = true;
            pnlProductManagement.Visible = false;
            pnlSalesReport.Visible = false;
            pnlStaffAccount.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pnlOverview.Visible = false;
            pnlProductManagement.Visible = true;
            pnlSalesReport.Visible = false;
            pnlStaffAccount.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlOverview.Visible = false;
            pnlProductManagement.Visible = false;
            pnlSalesReport.Visible = true;
            pnlStaffAccount.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlOverview.Visible = false;
            pnlProductManagement.Visible = false;
            pnlSalesReport.Visible = false;
            pnlStaffAccount.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //form2

        }
    }
}

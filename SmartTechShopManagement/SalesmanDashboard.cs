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
    public partial class SalesmanDashboard : Form
    {
        public SalesmanDashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlPos.Visible = true;
            pnlBrowseHardware.Visible = false;
            pnlCustomerHistory.Visible = false;
            pnlLowStockAlart.Visible = false;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            pnlPos.Visible = false;
            pnlBrowseHardware.Visible = false;
            pnlCustomerHistory.Visible = true;
            pnlLowStockAlart.Visible = false;
        }

        private void pnlPos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            pnlPos.Visible = false;
            pnlBrowseHardware.Visible = true;
            pnlCustomerHistory.Visible = false;
            pnlLowStockAlart.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pnlPos.Visible = false;
            pnlBrowseHardware.Visible = false;
            pnlCustomerHistory.Visible = false;
            pnlLowStockAlart.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}

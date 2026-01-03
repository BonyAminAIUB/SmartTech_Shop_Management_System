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

            string query = "SELECT * From empInfoTb ";

            Connection connection = new Connection();
            dgvExistingStaff.DataSource = connection.pullForDataTable(query);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Regestration regestration = new Regestration();
            regestration.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string query = "SELECT * From empInfoTb ";

            Connection connection = new Connection();
            dgvExistingStaff.DataSource = connection.pullForDataTable(query);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string pName, pBrand, pCatagory;
            int pPrice, pQuantity;

            pName = txbProductName.Text;
            pBrand = cbxProductBrand.Text;
            pCatagory = txbProductCatagory.Text;
            pPrice = int.Parse(txbProductPrice.Text);
            pQuantity =  int.Parse(txbProductQuantity.Text);

            Connection connection = new Connection();
            string query = "Insert into productInfoTb (ProductName,ProductBrand,ProductCatagory,ProductPrice,ProductQuantity) values ('"+pName+"','"+pBrand+"','"+pCatagory+"','"+pPrice+"','"+pQuantity+"')";
            connection.push(query);

            string queryForGetTable = "SELECT * FROM productInfoTb";
            dgvAllProduct.DataSource = connection.pullForDataTable(queryForGetTable);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SmartTechShopManagement
{
    public partial class ManagerDashboard : Form
    {
        public ManagerDashboard()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlUpdateStock.Visible = true;
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            pnlOverview.Visible = true;
            pnlStock.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pnlOverview.Visible = false;
            pnlStock.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string pName, pCatagory;
            string pPrice, pQuantity;
            pName = txtStockUpdateName.Text;
            pCatagory = txtStockUpdateCatagory.Text;
            pPrice = txtStockUpdatePrice.Text;
            pQuantity = txtStockUpdateQuantity.Text;

            int pPriceInt = int.Parse(pPrice);
            int pQuantityInt = int.Parse(pQuantity);

            string query = "Insert into ProductInfoTb (ProductName,ProductCatagory,ProductPrice, ProductQuantity) values('" + pName + "','" + pCatagory + "','" + pPriceInt + "','" + pQuantityInt + "')";

            Connection connection = new Connection();
            connection.push(query);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

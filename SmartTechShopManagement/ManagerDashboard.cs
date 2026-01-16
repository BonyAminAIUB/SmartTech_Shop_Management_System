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
            // Order-Management Button
        }
        private void btnProducts_Click(object sender, EventArgs e)
        { 
            // Product-Management Button
            pnlProfile.Visible = false;
            pnlUpdateInfo.Visible = false;
            pnlUpdateStock.Visible = false;
            pnlAddProduct.Visible = false;
            pnlDeleteProduct.Visible = false;
            pnlStockAlart.Visible = false;
            pnlManagerDashBoard.Visible = false;
            pnlProductManagement.Visible = true;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            // Profile Button
            pnlProfile.Visible = true;
            pnlUpdateInfo.Visible = false;
            pnlUpdateStock.Visible = false;
            pnlAddProduct.Visible = false;
            pnlDeleteProduct.Visible = false;
            pnlStockAlart.Visible = false;
            pnlManagerDashBoard.Visible = false;
            pnlProductManagement.Visible = false;   
        }
        private void button6_Click(object sender, EventArgs e)
        {
            // Log in form button
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
            pName = txtStockAddName.Text;
            pCatagory = comboBoxUpdateCategory.Text;
            pPrice = txtStockAddPrice.Text;
            pQuantity = txtStockAddQuantity.Text;

            int pPriceInt = int.Parse(pPrice);
            int pQuantityInt = int.Parse(pQuantity);

            string query = "Insert into ProductInfoTb (ProductName,ProductCatagory,ProductPrice, ProductQuantity) values('" + pName + "','" + pCatagory + "','" + pPriceInt + "','" + pQuantityInt + "')";

            Connection connection = new Connection();
            connection.push(query);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            // Log out Button
        }
        private void pnlProfile_Paint(object sender, PaintEventArgs e)
        {

        }
        private void txtRegEmail_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            pnlProductManagement.Visible = false;
            pnlUpdateStock.Visible = false;
            pnlAddProduct.Visible = false;
            pnlDeleteProduct.Visible = false;
            pnlStockAlart.Visible = false;
            pnlManagerDashBoard.Visible = false;
            pnlProfile.Visible = false;
            pnlUpdateInfo.Visible = true;
        }
        private void label14_Click(object sender, EventArgs e)
        {

        }
        private void btnBack_Click(object sender, EventArgs e)
        {                     
            pnlProductManagement.Visible = false;
            pnlUpdateStock.Visible = false;
            pnlAddProduct.Visible = false;
            pnlUpdateInfo.Visible = false;
            pnlDeleteProduct.Visible = false;
            pnlStockAlart.Visible = false;
            pnlManagerDashBoard.Visible = false;
            pnlProfile.Visible = true;
        }
        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Profile Updated!");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //button add product
            pnlProfile.Visible = false;
            pnlUpdateInfo.Visible = false;
            pnlProductManagement.Visible = false;
            pnlUpdateStock.Visible = false;
            pnlDeleteProduct.Visible = false;
            pnlStockAlart.Visible = false;
            pnlManagerDashBoard.Visible = false;
            pnlAddProduct.Visible = true;
        }
        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            pnlProfile.Visible = false;
            pnlUpdateInfo.Visible = false;
            pnlProductManagement.Visible = false;
            pnlAddProduct.Visible = false;
            pnlDeleteProduct.Visible = false;
            pnlStockAlart.Visible = false;
            pnlManagerDashBoard.Visible = false;
            pnlUpdateStock.Visible = true;
        }
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            pnlProfile.Visible = false;
            pnlUpdateInfo.Visible = false;
            pnlProductManagement.Visible = false;
            pnlAddProduct.Visible = false;
            pnlUpdateStock.Visible = false;
            pnlStockAlart.Visible = false;
            pnlManagerDashBoard.Visible = false;
            pnlDeleteProduct.Visible = true;
        }
        private void btnStockAlart_Click(object sender, EventArgs e)
        {
            pnlProfile.Visible = false;
            pnlUpdateInfo.Visible = false;
            pnlProductManagement.Visible = false;
            pnlAddProduct.Visible = false;
            pnlUpdateStock.Visible = false;
            pnlDeleteProduct.Visible = false;
            pnlManagerDashBoard.Visible = false;
            pnlStockAlart.Visible = true;
        }
        private void btnAddBack_Click(object sender, EventArgs e)
        {
            pnlProfile.Visible = false;
            pnlUpdateInfo.Visible = false;   
            pnlAddProduct.Visible = false;
            pnlUpdateStock.Visible = false;
            pnlDeleteProduct.Visible = false;
            pnlStockAlart.Visible = false;
            pnlManagerDashBoard.Visible = false;
            pnlProductManagement.Visible = true;
        }
        private void btnUpdateBack_Click(object sender, EventArgs e)
        {
            pnlProfile.Visible = false;
            pnlUpdateInfo.Visible = false;
            pnlAddProduct.Visible = false;
            pnlUpdateStock.Visible = false;
            pnlDeleteProduct.Visible = false;
            pnlStockAlart.Visible = false;
            pnlManagerDashBoard.Visible = false;
            pnlProductManagement.Visible = true;
        }
        private void btnDeleteBack_Click(object sender, EventArgs e)
        {
            pnlProfile.Visible = false;
            pnlUpdateInfo.Visible = false;
            pnlAddProduct.Visible = false;
            pnlUpdateStock.Visible = false;
            pnlDeleteProduct.Visible = false;
            pnlStockAlart.Visible = false;
            pnlManagerDashBoard.Visible = false;
            pnlProductManagement.Visible = true;
        }
        private void btnStockBack_Click(object sender, EventArgs e)
        {
            pnlProfile.Visible = false;
            pnlUpdateInfo.Visible = false;
            pnlAddProduct.Visible = false;
            pnlUpdateStock.Visible = false;
            pnlDeleteProduct.Visible = false;
            pnlStockAlart.Visible = false;
            pnlManagerDashBoard.Visible = false;
            pnlProductManagement.Visible = true;
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            pnlProfile.Visible = false;
            pnlUpdateInfo.Visible = false;
            pnlAddProduct.Visible = false;
            pnlUpdateStock.Visible = false;
            pnlDeleteProduct.Visible = false;
            pnlStockAlart.Visible = false;
            pnlProductManagement.Visible = false;
            pnlManagerDashBoard.Visible = true;            
        }

        private void pnlManagerDashBoard_Paint(object sender, PaintEventArgs e)
        {
            pnlProfile.Visible = false;
            pnlUpdateInfo.Visible = false;
            pnlAddProduct.Visible = false;
            pnlUpdateStock.Visible = false;
            pnlDeleteProduct.Visible = false;
            pnlStockAlart.Visible = false;
            pnlProductManagement.Visible = false;
            pnlManagerDashBoard.Visible = true;
        }
    }
}

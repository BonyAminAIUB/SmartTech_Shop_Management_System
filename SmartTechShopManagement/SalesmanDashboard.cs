using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
            pnlPos.Visible = false;
            pnlCustomerHistory.Visible = true;
            pnlLowStockAlart.Visible = false;
            pnlProduct.Visible = false;
            pnlProfile.Visible = false;
            pnlRefund.Visible = false;
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
            //pnlBrowseHardware.Visible = false;
            pnlCustomerHistory.Visible = true;
            pnlLowStockAlart.Visible = false;
        }

        private void pnlPos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            pnlPos.Visible = false;
            //pnlBrowseHardware.Visible = true;
            pnlCustomerHistory.Visible = false;
            pnlLowStockAlart.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pnlPos.Visible = false;
            //pnlBrowseHardware.Visible = false;
            pnlCustomerHistory.Visible = false;
            pnlLowStockAlart.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            if(txtCustomerName.Text == "" || txtCustomerMobileNo.Text=="")
            {
                MessageBox.Show("Customer Name or Mobile No cant be empty!");
            }
            else
            {
                if (txtCustomerMobileNo.TextLength != 11)
                {
                    MessageBox.Show("Mobile No not valid!");
                }
                else
                {
                    Connection connection = new Connection();
                    string query = $"INSERT into customerInfoTb(customerName, customerMobileNo,customerSoldBy) values('" + txtCustomerName.Text + "','" + txtCustomerMobileNo.Text + "','"+LoginForm.sharedUsername+"')";
                    connection.push(query);
                    MessageBox.Show("Customer Added");
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text == "" && txtCustomerMobileNo.Text == "")
            {
                Connection connection = new Connection();
                string query = "select customerName,customerMobileNo from customerInfoTb";
                dgvPOSCustomerInfo.DataSource = connection.pullForDataTable(query);
            }
            else if (txtCustomerName.Text != "")
            {
                Connection connection = new Connection();
                string query = $"select customerName,customerMobileNo from customerInfoTb where customerName = '{txtCustomerName.Text}'";
                dgvPOSCustomerInfo.DataSource = connection.pullForDataTable(query);
            }
            else if(txtCustomerMobileNo.Text != "")
            {
                Connection connection = new Connection();
                string query = $"select customerName,customerMobileNo, from customerInfoTb where customerMobileNo = '{txtCustomerMobileNo.Text}'";
                dgvPOSCustomerInfo.DataSource = connection.pullForDataTable(query);
            }
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dgvPOSCustomerInfo.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtMobileNo.Text = dgvPOSCustomerInfo.Rows[e.RowIndex].Cells[1].Value.ToString();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            if (txtProductSearch.Text != "")
            {
                string query = "Select * from productInfoTb";
                dgvPosSearchedProduct.DataSource = connection.pullForDataTable(query);
            }
            else if (txtProductSearch.Text != "Product Name / Model")
            {
                string query = "Select * from productInfoTb";
                dgvPosSearchedProduct.DataSource = connection.pullForDataTable(query);
            }
            else
            {
                string query = $"Select * from productInfoTb where ProductName = '{txtProductSearch.Text}' or productModel = '{txtProductSearch.Text}'";
                dgvPosSearchedProduct.DataSource = connection.pullForDataTable(query);
            }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            UpdateProfile updateProfile = new UpdateProfile();
            updateProfile.Show();

            
        }

        private void btnPos_Click(object sender, EventArgs e)
        {
            pnlPos.Visible = true;
            pnlCustomerHistory.Visible = false;
            pnlLowStockAlart.Visible = false; 
            pnlProduct.Visible = false;
            pnlProfile.Visible = false;
            pnlRefund.Visible = false;
        }

        private void txtCustomerMobileNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCustomerName_Click(object sender, EventArgs e)
        {
            txtCustomerName.Text = "";
        }

        private void txtCustomerMobileNo_Click(object sender, EventArgs e)
        {
            txtCustomerMobileNo.Text = "";
        }

        private void txtProductSearch_Click(object sender, EventArgs e)
        {
            txtProductSearch.Text = "";
        }

        public string productName, productPrice, productWarrenty;
        public int productStockQuantity;

        private void button1_Click_1(object sender, EventArgs e)
        {
            int sum = 0;
            if ((productStockQuantity - int.Parse(cbxPosQuantity.Text)) >= 0)
            {
                int productQuantity = int.Parse(cbxPosQuantity.Text);
                Connection connection = new Connection();
                try
                {
                    string query = "insert into cartTb (productName,productPrice,productWarrenty,productQuantity) values ('" + productName + "','" + productPrice + "','" + productWarrenty + "','" + productQuantity + "')";
                    connection.push(query);

                    string queryToShowValue = "select * from cartTb";
                    dgvPosCart.DataSource = connection.pullForDataTable(queryToShowValue);
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    if (ex.Message.Contains("Violation of PRIMARY KEY") || ex.Message.Contains("duplicate key"))
                    {
                        string updateQuery = $"UPDATE cartTb SET productQuantity ={productQuantity} WHERE productName = '{productName}'";
                        connection.push(updateQuery);

                        string queryToShowValue = "select * from cartTb";
                        dgvPosCart.DataSource = connection.pullForDataTable(queryToShowValue);
                    }
                    else
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
                int rowSize = dgvPosCart.Rows.Count;
                for(int i = 0;i< rowSize - 1; i++)
                {
                    int basePrice= int.Parse(dgvPosCart.Rows[i].Cells[1].Value.ToString()) ;
                    int quantity = int.Parse(dgvPosCart.Rows[i].Cells[3].Value.ToString());
                    sum += (basePrice * quantity);
                }
                lblPrice.Text = sum.ToString();
            }
            else
            {
                MessageBox.Show("Not Enough Product In Stock!");
            }

        }

        private void dgvPosSearchedProduct_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            int totalRows = dgvPosCart.Rows.Count;
            for (int i = 0; i < totalRows-1; i++)
            { 
                productName = dgvPosCart.Rows[i].Cells[0].Value.ToString();
                productPrice = dgvPosCart.Rows[i].Cells[1].Value.ToString();
                productWarrenty = dgvPosCart.Rows[i].Cells[2].Value.ToString();
                int productQuantity = int.Parse(dgvPosCart.Rows[i].Cells[3].Value.ToString());
                Connection connection = new Connection();
                string query = "insert into customerInfoTb (customerName,customerMobileNo,customerProduct,customerSoldBy,customerProductPrice,customerProductWarrenty,customerProductQuantity,customerProductSoldDate) values ('" + txtName.Text + "','" + txtMobileNo.Text + "','" + productName + "','" + LoginForm.sharedUsername + "','" + productPrice + "','" + productWarrenty + "','" + productQuantity + "','"+today+"')";
                connection.push(query);

                string queryForQuantityUpdate = $"update productInfoTb set productQuantity = productQuantity - {productQuantity} where productName = '{productName}'";
                connection.push(queryForQuantityUpdate);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            string query = "delete from cartTb";
            connection.push(query);

            string queryforReloadCart = "select * from cartTb";
            dgvPosCart.DataSource = connection.pullForDataTable(queryforReloadCart);
        }

        private void textBox11_Click(object sender, EventArgs e)
        {
            txtSearchCustomer.Text = "";
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            if(txtSearchCustomer.Text == "")
            {
                string query = "select * from customerInfoTb";
                dgvCustomerHistory.DataSource = connection.pullForDataTable(query);
            }
            else if(txtSearchCustomer.Text == "Search Customer Number")
            {
                string query = "select * from customerInfoTb";
                dgvCustomerHistory.DataSource = connection.pullForDataTable(query);
            }
            else
            {
                string query = $"select * from customerInfoTb where customerMobileNo = '{txtSearchCustomer.Text}'";
                dgvCustomerHistory.DataSource = connection.pullForDataTable(query);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            pnlPos.Visible = false;
            pnlCustomerHistory.Visible = false;
            pnlLowStockAlart.Visible = false;
            pnlProduct.Visible = true;
            pnlProfile.Visible = false;
            pnlRefund.Visible = false;

            Connection connection = new Connection();
            string query = "select * from productInfoTb";
            connection.pullForDataTable(query);
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            string query = $"select * from productInfoTb where productName = '{txtProductDetailsSearch.Text}'";
            dgvProductDetails.DataSource = connection.pullForDataTable(query);
        }

        private void dgvProductDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSelectedItem.Text = dgvProductDetails.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            string query = $"update productInfoTb set productStockStatus = 'Low Stock' where productName = '{txtSelectedItem.Text}'";
            connection.push(query);
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            pnlProduct.Visible = false;
            pnlLowStockAlart.Visible = true;
            pnlPos.Visible = false;
            pnlProfile.Visible = false;
            pnlCustomerHistory.Visible = false;

            Connection connection = new Connection();
            string query = "select * from productInfoTb where productStockStatus = 'Low Stock'";
            dgvLowstockAlart.DataSource = connection.pullForDataTable(query);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            pnlPos.Visible = false;
            pnlCustomerHistory.Visible = false;
            pnlLowStockAlart.Visible = false;
            pnlProduct.Visible = false;
            pnlProfile.Visible = true;
            pnlRefund.Visible = false;

            Connection connection = new Connection();
            string query = $"select * from empInfoTb where empUsername = '{LoginForm.sharedUsername}'";
            DataTable dt = connection.pullForDataTable(query);

            txtRegName.Text = dt.Rows[0]["empName"].ToString();
            txtRegUsername.Text = dt.Rows[0]["empUsername"].ToString();
            txtRegEmail.Text = dt.Rows[0]["empEmail"].ToString();
            txtRegPhoneNo.Text = dt.Rows[0]["empPhoneNo"].ToString();
            txtRegRole.Text = dt.Rows[0]["empRole"].ToString();
            txtRegQua.Text = dt.Rows[0]["empQualification"].ToString();
            txtRegGender.Text = dt.Rows[0]["empGender"].ToString();
            txtRegJoiningDate.Text = dt.Rows[0]["empJoiningDate"].ToString();
            txtRegDOB.Text = dt.Rows[0]["empDOB"].ToString();
            rtbxRegAddress.Text = dt.Rows[0]["empAddress"].ToString();

            string query2 = "select customerProduct,customerProductQuantity from customerInfoTb";
            DataTable dt2 = connection.pullForDataTable(query2);
            chart1.DataSource = dt2;
            chart1.Series["Series1"].XValueMember = "customerProduct"; 
            chart1.Series["Series1"].YValueMembers = "customerProductQuantity";
            chart1.DataBind();

            DateTime todaysDate = DateTime.Now;

            string query3 = "select customerProductPrice from customerInfoTb";
            DataTable dt3 = connection.pullForDataTable(query3);
            int totalSales = 0;

            for(int i =0; i< dt3.Rows.Count; i++)
            {
                totalSales += int.Parse(dt3.Rows[i]["customerProductPrice"].ToString());
            }
            lblTodaysSales.Text = totalSales.ToString() + " TK";
        }

        private void cbxNotification_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxNotification.Checked)
            {
                Connection connection = new Connection();
                string query = "select * from notificationTb";
                dgvNotification.DataSource = connection.pullForDataTable(query);
            }
            else
            {
                dgvNotification.DataSource = null;
            }
        }

        private void dgvNotification_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            pnlPos.Visible = false;
            pnlCustomerHistory.Visible = false;
            pnlLowStockAlart.Visible = false;
            pnlProduct.Visible = false;
            pnlProfile.Visible = false;
            pnlRefund.Visible = true;
        }

        private void dgvPosSearchedProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            productStockQuantity = int.Parse(dgvPosSearchedProduct.Rows[e.RowIndex].Cells[6].Value.ToString());
            productName = dgvPosSearchedProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
            productPrice = dgvPosSearchedProduct.Rows[e.RowIndex].Cells[5].Value.ToString();
            productWarrenty = dgvPosSearchedProduct.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void dgvPosSearchedProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

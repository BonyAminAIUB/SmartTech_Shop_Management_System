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
using System.Windows.Forms.DataVisualization.Charting;
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
            pnlProfile.Visible = false;
            pnlUpdateInfo.Visible = false;
            pnlUpdateStock.Visible = false;
            pnlAddProduct.Visible = false;
            pnlDeleteProduct.Visible = false;
            pnlStockAlart.Visible = false;
            pnlManagerDashBoard.Visible = false;
            pnlUpperOrderList.Visible = true;
            pnlUpperlbl.Visible = true;
            pnlOrderDetails.Visible = true;
            pnlOrderManagement.Visible = true;

            Connection connection = new Connection();
            string query2 = "select * from productInfoTb where productStockStatus = 'Peinding Approval'";
            dgvOrderManagement.DataSource = connection.pullForDataTable(query2);
        }
        //private void btnProducts_Click(object sender, EventArgs e)
        //{ 
        //    // Product-Management Button
        //    pnlProfile.Visible = false;
        //    pnlUpdateInfo.Visible = false;
        //    pnlUpdateStock.Visible = false;
        //    pnlAddProduct.Visible = false;
        //    pnlDeleteProduct.Visible = false;
        //    pnlStockAlart.Visible = false;
        //    pnlManagerDashBoard.Visible = false;
        //    pnlOrderManagement.Visible = false;
        //    pnlUpperOrderList.Visible = false;
        //    pnlUpperlbl.Visible = false;
        //    pnlOrderDetails.Visible = false;
        //    pnlProductManagement.Visible = true;
        //}
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
            pnlOrderManagement.Visible = false;
            pnlUpperOrderList.Visible = false;
            pnlUpperlbl.Visible = false;
            pnlOrderDetails.Visible = false;

            
            DataTable dt = new DataTable();
            Connection connection = new Connection();
            string query = "select * from empInfoTb where empUsername = '" + LoginForm.sharedUsername + "'";
            dt = connection.pullForDataTable(query);
            txtProfileName.Text = dt.Rows[0]["empName"].ToString();
            txtprofileEmail.Text = dt.Rows[0]["empEmail"].ToString();
            txtProfileDOB.Text = dt.Rows[0]["empDOB"].ToString();
            txtProfileGender.Text = dt.Rows[0]["empGender"].ToString();
            txtProfileJoiningDate.Text = dt.Rows[0]["empJoiningDate"].ToString();
            txtProfileQua.Text = dt.Rows[0]["empQualification"].ToString();
            rtbxProfileAddress.Text = dt.Rows[0]["empAddress"].ToString();
            txtProfilePhoneNo.Text = dt.Rows[0]["empPhoneNo"].ToString();
            txtProfileRole.Text = dt.Rows[0]["empRole"].ToString();
            txtProfileUsername.Text = dt.Rows[0]["empUsername"].ToString();
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
            pnlUpdateStock.Visible = false;
            pnlAddProduct.Visible = false;
            pnlDeleteProduct.Visible = false;
            pnlStockAlart.Visible = false;
            pnlManagerDashBoard.Visible = false;
            pnlProfile.Visible = false;
            pnlOrderManagement.Visible = false;
            pnlUpperOrderList.Visible = false;
            pnlUpperlbl.Visible = false;
            pnlOrderDetails.Visible = false;
            pnlUpdateInfo.Visible = true;

            DataTable dt = new DataTable();
            Connection connection = new Connection();
            string query = "select * from empInfoTb where empUsername = '" + LoginForm.sharedUsername + "'";
            dt = connection.pullForDataTable(query);
            txtProfileUpdateName.Text = dt.Rows[0]["empName"].ToString();
            txtUpdateEmail.Text = dt.Rows[0]["empEmail"].ToString();
            dateTimeUpdateDOB.Value = Convert.ToDateTime(dt.Rows[0]["empDOB"]);
            comboUpdateGender.Text = dt.Rows[0]["empGender"].ToString();
            dateTimeUpdateDate.Value = Convert.ToDateTime(dt.Rows[0]["empJoiningDate"]);
            cbxRegQualificatioin.Text = dt.Rows[0]["empQualification"].ToString();
            richTxtBoxUpdate.Text = dt.Rows[0]["empAddress"].ToString();
            txtUpdatePhone.Text = dt.Rows[0]["empPhoneNo"].ToString();
            txtUpdateProfileRole.Text = dt.Rows[0]["empRole"].ToString();
            txtProfileUsernameUpdate.Text = dt.Rows[0]["empUsername"].ToString();
        }
        private void label14_Click(object sender, EventArgs e)
        {

        }
        private void btnBack_Click(object sender, EventArgs e)
        {                     
            pnlUpdateStock.Visible = false;
            pnlAddProduct.Visible = false;
            pnlUpdateInfo.Visible = false;
            pnlDeleteProduct.Visible = false;
            pnlStockAlart.Visible = false;
            pnlManagerDashBoard.Visible = false;
            pnlOrderManagement.Visible = false;
            pnlUpperOrderList.Visible = false;
            pnlUpperlbl.Visible = false;
            pnlOrderDetails.Visible = false;
            pnlProfile.Visible = true;

            DataTable dt = new DataTable();
            Connection connection = new Connection();
            string query = "select * from empInfoTb where empUsername = '" + LoginForm.sharedUsername + "'";
            dt = connection.pullForDataTable(query);
            txtProfileName.Text = dt.Rows[0]["empName"].ToString();
            txtprofileEmail.Text = dt.Rows[0]["empEmail"].ToString();
            txtProfileDOB.Text = dt.Rows[0]["empDOB"].ToString();
            txtProfileGender.Text = dt.Rows[0]["empGender"].ToString();
            txtProfileJoiningDate.Text = dt.Rows[0]["empJoiningDate"].ToString();
            txtProfileQua.Text = dt.Rows[0]["empQualification"].ToString();
            rtbxProfileAddress.Text = dt.Rows[0]["empAddress"].ToString();
            txtProfilePhoneNo.Text = dt.Rows[0]["empPhoneNo"].ToString();
            txtProfileRole.Text = dt.Rows[0]["empRole"].ToString();
            txtProfileUsername.Text = dt.Rows[0]["empUsername"].ToString();
        }
        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            string query = "UPDATE empInfoTb SET " +
                   "empName = '" + txtProfileUpdateName.Text + "', " +
                   "empEmail = '" + txtUpdateEmail.Text + "', " +
                   "empPhoneNo = '" + txtUpdatePhone.Text + "', " +
                   "empRole = '" + txtUpdateProfileRole.Text + "', " +
                   "empQualification = '" + cbxRegQualificatioin.Text + "', " +
                   "empGender = '" + comboUpdateGender.Text + "', " +
                   "empJoiningDate = '" + dateTimeUpdateDate.Value.ToString("yyyy-MM-dd") + "', " +
                   "empDOB = '" + dateTimeUpdateDOB.Value.ToString("yyyy-MM-dd") + "', " +
                   "empAddress = '" + richTxtBoxUpdate.Text + "', " +
                   "empUsername = '" + txtProfileUsernameUpdate.Text + "' " +
                   "WHERE empUsername = '" + LoginForm.sharedUsername + "'";
            connection.push(query);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //button add product
            pnlProfile.Visible = false;
            pnlUpdateInfo.Visible = false;
            pnlUpdateStock.Visible = false;
            pnlDeleteProduct.Visible = false;
            pnlStockAlart.Visible = false;
            pnlManagerDashBoard.Visible = false;
            pnlOrderManagement.Visible = false;
            pnlUpperOrderList.Visible = false;
            pnlUpperlbl.Visible = false;
            pnlOrderDetails.Visible = false;
            pnlAddProduct.Visible = true;

            Connection connection = new Connection();
            string query = "select * from productInfoTb";
            dgvAddProduct.DataSource = connection.pullForDataTable(query);
        }
        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            pnlProfile.Visible = false;
            pnlUpdateInfo.Visible = false;
            pnlAddProduct.Visible = false;
            pnlDeleteProduct.Visible = false;
            pnlStockAlart.Visible = false;
            pnlManagerDashBoard.Visible = false;
            pnlOrderManagement.Visible = false;
            pnlUpperOrderList.Visible = false;
            pnlUpperlbl.Visible = false;
            pnlOrderDetails.Visible = false;
            pnlUpdateStock.Visible = true;

            Connection connection = new Connection();
            string query = "select * from productInfoTb";
            dgvUpdateProduct.DataSource = connection.pullForDataTable(query);
        }
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            pnlProfile.Visible = false;
            pnlUpdateInfo.Visible = false;
            pnlAddProduct.Visible = false;
            pnlUpdateStock.Visible = false;
            pnlStockAlart.Visible = false;
            pnlManagerDashBoard.Visible = false;
            pnlOrderManagement.Visible = false;
            pnlUpperOrderList.Visible = false;
            pnlUpperlbl.Visible = false;
            pnlOrderDetails.Visible = false;
            pnlDeleteProduct.Visible = true;

            Connection connection = new Connection();
            string query = "select * from productInfoTb";
            dgvDeletProduct.DataSource = connection.pullForDataTable(query);
        }
        private void btnStockAlart_Click(object sender, EventArgs e)
        {
            pnlProfile.Visible = false;
            pnlUpdateInfo.Visible = false;
            pnlAddProduct.Visible = false;
            pnlUpdateStock.Visible = false;
            pnlDeleteProduct.Visible = false;
            pnlManagerDashBoard.Visible = false;
            pnlOrderManagement.Visible = false;
            pnlUpperOrderList.Visible = false;
            pnlUpperlbl.Visible = false;
            pnlOrderDetails.Visible = false;
            pnlStockAlart.Visible = true;

            Connection conn = new Connection();
            string query = "select * from productInfoTb where productStockStatus = 'Low Stock'";
            gridViewAlertTable.DataSource = conn.pullForDataTable(query);

            string query2 = "select * from productInfoTb where productStockStatus = 'Out of Stock'";
            DataTable dt = conn.pullForDataTable(query2);
            lblOutStockValue.Text = dt.Rows.Count.ToString();

            lblLowAlartValue.Text = gridViewAlertTable.Rows.Count.ToString();

            string query4 = "select * from productInfoTb";
            DataTable dt2 = conn.pullForDataTable(query4);
            lblTotalValue.Text = dt2.Rows.Count.ToString();
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
            pnlOrderManagement.Visible = false;
            pnlUpperOrderList.Visible = false;
            pnlUpperlbl.Visible = false;
            pnlOrderDetails.Visible = false;
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
            pnlOrderManagement.Visible = false;
            pnlUpperOrderList.Visible = false;
            pnlUpperlbl.Visible = false;
            pnlOrderDetails.Visible = false;
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
            pnlOrderManagement.Visible = false;
            pnlUpperOrderList.Visible = false;
            pnlUpperlbl.Visible = false;
            pnlOrderDetails.Visible = false;
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
            pnlOrderManagement.Visible = false;
            pnlUpperOrderList.Visible = false;
            pnlUpperlbl.Visible = false;
            pnlOrderDetails.Visible = false;
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            pnlProfile.Visible = false;
            pnlUpdateInfo.Visible = false;
            pnlAddProduct.Visible = false;
            pnlUpdateStock.Visible = false;
            pnlDeleteProduct.Visible = false;
            pnlStockAlart.Visible = false;
            pnlOrderManagement.Visible = false;
            pnlUpperOrderList.Visible = false;
            pnlUpperlbl.Visible = false;
            pnlOrderDetails.Visible = false;
            pnlManagerDashBoard.Visible = true;

            Connection connection = new Connection();
            string query = "select * from customerInfoTb";
            DataTable dt = connection.pullForDataTable(query);

            DateTime todaysDate = DateTime.Now;
            long totalSales = 0;

            foreach (DataRow row in dt.Rows)
            {
                // TryParse is safe: it won't crash if a price is empty or text
                if (long.TryParse(row["customerProductPrice"].ToString(), out long price))
                {
                    totalSales += price;
                }
            }
            lblDailyValue.Text = totalSales.ToString();

            long MontlyValue = 0;

            foreach (DataRow row in dt.Rows)
            {
                // 2. Check if the row has a date (Not NULL) and is a valid date
                string dateString = row["customerProductSoldDate"].ToString();

                if (!string.IsNullOrEmpty(dateString) && DateTime.TryParse(dateString, out DateTime soldDate))
                {
                    // 3. Check if the sale happened in THIS Month and THIS Year
                    if (soldDate.Month == todaysDate.Month && soldDate.Year == todaysDate.Year)
                    {
                        // 4. Add the price to the total
                        // We use TryParse because your price column is text
                        if (long.TryParse(row["customerProductPrice"].ToString(), out long price))
                        {
                            MontlyValue += price;
                        }
                    }
                }
            }

            // 5. Show the result
            // Based on your screenshot, this should show "18500 TK" (only the last row counts)
            lblMontlyValue.Text = MontlyValue.ToString();

            long YearlyValue = 0;

            foreach (DataRow row in dt.Rows)
            {
                // 1. Get the date string safely
                string dateString = row["customerProductSoldDate"].ToString();

                // 2. Check if date exists and is valid
                if (!string.IsNullOrEmpty(dateString) && DateTime.TryParse(dateString, out DateTime soldDate))
                {
                    // 3. Check if the sale happened in THIS Year (e.g., 2026)
                    if (soldDate.Year == todaysDate.Year)
                    {
                        // 4. Add the price to the total
                        if (long.TryParse(row["customerProductPrice"].ToString(), out long price))
                        {
                            YearlyValue += price;
                        }
                    }
                }
            }

            lblYearlyValue.Text = YearlyValue.ToString();

            string query2 = "select * from productInfoTb where productStockStatus = 'Low Stock'";
            dgvLowStockManager.DataSource= connection.pullForDataTable(query2);

            int rowCount = dgvLowStockManager.Rows.Count;
            rowCount -=1; 
            lblLowStockManager.Text = rowCount.ToString();


            chartDashBoard.Series.Clear();

            Series series = new Series("SalesReport");

            series.ChartType = SeriesChartType.Pie;

            int daily = int.Parse(lblDailyValue.Text);
            int monthly = int.Parse(lblMontlyValue.Text);
            int yearly = int.Parse(lblYearlyValue.Text);

            series.Points.AddXY("Daily", daily);
            series.Points.AddXY("Monthly", monthly);
            series.Points.AddXY("Yearly", yearly);



        }

        private void pnlManagerDashBoard_Paint(object sender, PaintEventArgs e)
        {
            pnlProfile.Visible = false;
            pnlUpdateInfo.Visible = false;
            pnlAddProduct.Visible = false;
            pnlUpdateStock.Visible = false;
            pnlDeleteProduct.Visible = false;
            pnlStockAlart.Visible = false;
            pnlOrderManagement.Visible = false;
            pnlUpperOrderList.Visible = false;
            pnlUpperlbl.Visible = false;
            pnlOrderDetails.Visible = false;
            pnlManagerDashBoard.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            string query = "insert into productInfoTb (ProductName,productModel,ProductBrand,ProductCatagory,ProductPrice,ProductQuantity,productWarrenty,ProductAddingDate) values ('" + txtAddName.Text + "','" + txtAddModel.Text + "','" + cbxAddBrand.Text + "','" + cbxAddCategory.Text + "','" + txtAddPrice.Text + "','" + txtAddQuantity.Text + "','" + txtAddWarrenty.Text + "','" + date + "')";
            Connection connection = new Connection();
            connection.push(query);
            MessageBox.Show("New Product Added");
        }

        string id;
        private void dgvUpdateProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dgvUpdateProduct.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtUpdateName.Text = dgvUpdateProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtUpdateModel.Text = dgvUpdateProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbxUpdateCatagory.Text = dgvUpdateProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
            cbxUpdateBrand.Text = dgvUpdateProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtUpdatePrice.Text = dgvUpdateProduct.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtUpdateQuantity.Text = dgvUpdateProduct.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtUpdateWarrenty.Text = dgvUpdateProduct.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string query = "UPDATE productInfoTb SET " +
                           "ProductName = '" + txtUpdateName.Text + "', " +
                           "productModel = '" + txtUpdateModel.Text + "', " +
                           "ProductBrand = '" + cbxUpdateBrand.Text + "', " +
                           "ProductCatagory = '" + cbxUpdateCatagory.Text + "', " +
                           "ProductPrice = '" + txtUpdatePrice.Text + "', " +
                           "ProductQuantity = '" + txtUpdateQuantity.Text + "', " +
                           "productWarrenty = '" + txtUpdateWarrenty.Text + "' " +
                           "WHERE ProductId = " + id; 
            Connection connection = new Connection();
            connection.push(query);
            MessageBox.Show("Product Updated");
        }

        private void dgvDeletProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dgvDeletProduct.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDeleteName.Text = dgvDeletProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDelateModel.Text = dgvDeletProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBoxDeleteCategory.Text = dgvDeletProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
            comboBoxDeleteBrand.Text = dgvDeletProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtDeletePrice.Text = dgvDeletProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtDeleteQuantity.Text = dgvDeletProduct.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtDeleteWarrenty.Text = dgvDeletProduct.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void btnDeleteSave_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM productInfoTb WHERE ProductId = '" + id+"'";
            Connection connection = new Connection();
            connection.push(query);
            MessageBox.Show("Product was deleted");
        }

        private void txtProfileUsernameUpdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void lblDashBoardMSG_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void button5_Click_1(object sender, EventArgs e)
        {
            int price = int.Parse(txtOrderPrice.Text);
            int quantity = int.Parse(txtOrderQuantity.Text);
            Connection connection = new Connection();
            string query = $"insert into productInfoTb (ProductName, productModel, ProductBrand, ProductCatagory, ProductPrice, ProductQuantity, productWarrenty, ProductAddingDate, productStockStatus, productOrderedDate) values ('"+txtProductName.Text+"','"+txtOrderModel.Text+"','"+txtOrderBrand.Text+"','"+txtOrderCatagory.Text+"','"+price+"','"+quantity+"','"+txtOrderWarrenty.Text+"','"+DateTime.Now.ToString()+ "','Peinding Approval','" + DateTime.Now.ToString() + "')"; 
            connection.push(query);

            string query2 = "select * from productInfoTb where productStockStatus = 'Peinding Approval'";
            dgvOrderManagement.DataSource =  connection.pullForDataTable(query2);
        }

        private void dgvOrderManagement_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dgvOrderManagement.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtQuantity.Text = dgvOrderManagement.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtUnitPrice.Text = dgvOrderManagement.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtTotalPrice.Text = (int.Parse(txtQuantity.Text) * int.Parse(txtUnitPrice.Text)).ToString();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            string query = $"select productStockStatus from productInfoTb where ProductName = '{txtName.Text}'";
            DataTable dt = connection.pullForDataTable(query);
            string stockStatus = dt.Rows[0]["productStockStatus"].ToString();
            if (stockStatus == "Peinding Approval")
            {
                MessageBox.Show("Product Needs Admins Approval First!");
            }
            else
            {
                string query2 = $"update productInfoTb set productStockStatus = 'Ordered' where ProductName = '{txtName.Text}'";
                connection.push(query);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            string query = "delete from productInfoTb where ProductName = '" + txtName.Text + "'";
            connection.push(query);
            
            string query2 = "select * from productInfoTb where productStockStatus = 'Peinding Approval'";
            dgvOrderManagement.DataSource = connection.pullForDataTable(query2);
        }

        private void lblLowStock_Click(object sender, EventArgs e)
        {

        }

        private void lblLowStockManager_Click(object sender, EventArgs e)
        {

        }

        private void pnlAddProduct_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlUpperlbl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlUpdateStock_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

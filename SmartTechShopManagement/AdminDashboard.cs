using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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
            pnlProductManagement.Visible = true;
            pnlSalesReport.Visible = false;
            pnlLoginAudit.Visible = false;
            pnlUpdateEmployee.Visible = false;
            


            Connection connection = new Connection();
            string query = "select * from productInfoTb";
            dgvProductManagement.DataSource = connection.pullForDataTable(query);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //pnlOverview.Visible = false;
            pnlProductManagement.Visible = false;
            pnlSalesReport.Visible = false;
            //pnlStaffAccount.Visible = false;
            //pnlEmpManagement.Visible = true;
            //pnlNotification.Visible = false;
            //pnlMessages.Visible = false;    

            Connection connection = new Connection();
            string query = "select * from empInfoTb";
            dgvUpdateEmpInfo.DataSource = connection.pullForDataTable(query);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime todaysDate = DateTime.Now;
            //pnlOverview.Visible = false;
            pnlProductManagement.Visible = false;
            pnlSalesReport.Visible = true;
            //pnlStaffAccount.Visible = false;

            Connection connection = new Connection();
            string query = "select * from customerInfoTb";
            DataTable dt = connection.pullForDataTable(query);
            long totalSales = 0;

            foreach (DataRow row in dt.Rows)
            {
                // TryParse is safe: it won't crash if a price is empty or text
                if (long.TryParse(row["customerProductPrice"].ToString(), out long price))
                {
                    totalSales += price;
                }
            }
            lblDailySales.Text = totalSales.ToString() + " TK";

            long monthlySales = 0;

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
                            monthlySales += price;
                        }
                    }
                }
            }

            // 5. Show the result
            // Based on your screenshot, this should show "18500 TK" (only the last row counts)
            lblMonthlySales.Text = monthlySales.ToString() + " TK";

            long yearlySales = 0;

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
                            yearlySales += price;
                        }
                    }
                }
            }

            lblYearlySales.Text = yearlySales.ToString() + " TK";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //pnlOverview.Visible = false;
            pnlProductManagement.Visible = false;
            pnlSalesReport.Visible = false;
            //pnlStaffAccount.Visible = true;

            //string query = "SELECT * From empInfoTb ";

            Connection connection = new Connection();
            //dgvExistingStaff.DataSource = connection.pullForDataTable(query);
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
            //string query = "SELECT * From empInfoTb ";

            Connection connection = new Connection();
            //dgvExistingStaff.DataSource = connection.pullForDataTable(query);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            //String name = "rakib";
            //label11.Text = name; 
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void pnlOverview_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            pnlUpdateEmployee.Visible = true;
            //pnlEmpManagement.Visible = false;

            Connection connection = new Connection();
            string query = "select * from empInfoTb";
            dgvUpdateEmpInfo.DataSource = connection.pullForDataTable(query);
        }

        private void dgvAllEmp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void pnlUpdateEmployee_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            pnlUpdateEmployee.Visible = false;
            //pnlEmpManagement.Visible = true;
        }

        private void dgvUpdateEmpInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvUpdateEmpInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRegName.Text = dgvUpdateEmpInfo.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtRegUsername.Text = dgvUpdateEmpInfo.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtRegEmail.Text = dgvUpdateEmpInfo.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtRegPhoneNo.Text = dgvUpdateEmpInfo.Rows[e.RowIndex].Cells[3].Value.ToString();
            cbxRegRole.Text = dgvUpdateEmpInfo.Rows[e.RowIndex].Cells[4].Value.ToString();
            cbxRegQualificatioin.Text = dgvUpdateEmpInfo.Rows[e.RowIndex].Cells[5].Value.ToString();
            cbxRegGender.Text = dgvUpdateEmpInfo.Rows[e.RowIndex].Cells[6].Value.ToString();
            //dtpRegJoiningDate.Value = dgvUpdateEmpInfo.Rows[e.RowIndex].Cells[8].Value.ToString();
            //dtpRegDOB.Value = dgvUpdateEmpInfo.Rows[e.RowIndex].Cells[9].Value.ToString();
            rtbxRegAddress.Text = dgvUpdateEmpInfo.Rows[e.RowIndex].Cells[9].Value.ToString();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            string query = "update empInfoTb set empName='"+txtRegName.Text+ "',empUsername='"+txtRegUsername.Text+ "',empEmail='"+txtRegEmail.Text+ "',empPhoneNo='"+txtRegPhoneNo.Text+ "',empRole='"+cbxRegRole.Text+ "',empQualification='"+cbxRegQualificatioin.Text+ "',empGender='"+cbxRegGender.Text+ "',empJoiningDate='"+dtpRegJoiningDate.Value+ "',empDOB='"+dtpRegDOB.Value+ "',empAddress='"+rtbxRegAddress.Text+"' where empUsername='"+txtRegUsername.Text+"'";
            connection.push(query);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            string query = "select * from notificationTb";
            //dgvNotification.DataSource = connection.pullForDataTable(query);
        }

        private void btnSendMessages_Click(object sender, EventArgs e)
        {
            //Connection connection = new Connection();
            //string query = "insert into notificationTb (notifications) values ('"+tbxMessages.Text+"')";
            //connection.push(query);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            string query = "select * from notificationTb";
            //dataGridView1.DataSource=connection.pullForDataTable(query);
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            //pnlNotification.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //pnlMessages.Visible = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            Connection connection = new Connection();
            string query = "insert into empInfoTb (empName,empUsername,empEmail,empPhoneNo,empRole,empQualification,empGender,empJoiningDate,empDOB,empAddress) values ('"+txtRegName.Text+ "','"+txtRegUsername.Text+ "','"+txtRegEmail.Text+ "','"+txtRegPhoneNo.Text+ "','"+cbxRegRole.Text+"','"+cbxRegQualificatioin.Text+"','"+cbxRegGender.Text+"','"+dtpRegJoiningDate.Value+"','"+dtpRegDOB.Value+"','"+rtbxRegAddress.Text+"')";
            connection.push(query);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnApproveProfile_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            string query = "select * from empProfileUpdate";
            dgvUpdateEmpInfo.DataSource = connection.pullForDataTable(query);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            string query = "delete from empInfoTb where empUsername='"+txtRegUsername.Text+"'";
            connection.push(query);
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            //pnlEmpManagement.Visible = false;
            pnlProductManagement.Visible = false;
            pnlSalesReport.Visible = false;
            pnlUpdateEmployee.Visible = false;

            Connection connection = new Connection();
            string query = "select * from loginTrackingTb";
            dgvLoginAudit.DataSource = connection.pullForDataTable(query);
        }

        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(cbxNotification.Checked)
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
    }
}

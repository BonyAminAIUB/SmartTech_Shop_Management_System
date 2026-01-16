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
            pnlEmpManagement.Visible = false;

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
            pnlEmpManagement.Visible = true;
            pnlNotification.Visible = false;
            pnlMessages.Visible = false;    

            Connection connection = new Connection();
            string query = "select * from empInfoTb";
            dgvAllEmp.DataSource = connection.pullForDataTable(query);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //pnlOverview.Visible = false;
            pnlProductManagement.Visible = false;
            pnlSalesReport.Visible = true;
            //pnlStaffAccount.Visible = false;
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
            pnlEmpManagement.Visible = false;

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
            pnlEmpManagement.Visible = true;
        }

        private void dgvUpdateEmpInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvUpdateEmpInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRegName.Text = dgvUpdateEmpInfo.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtRegUsername.Text = dgvUpdateEmpInfo.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtRegEmail.Text = dgvUpdateEmpInfo.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtRegPhoneNo.Text = dgvUpdateEmpInfo.Rows[e.RowIndex].Cells[4].Value.ToString();
            cbxRegRole.Text = dgvUpdateEmpInfo.Rows[e.RowIndex].Cells[5].Value.ToString();
            cbxRegQualificatioin.Text = dgvUpdateEmpInfo.Rows[e.RowIndex].Cells[6].Value.ToString();
            cbxRegGender.Text = dgvUpdateEmpInfo.Rows[e.RowIndex].Cells[7].Value.ToString();
            //dtpRegJoiningDate.Value = dgvUpdateEmpInfo.Rows[e.RowIndex].Cells[8].Value.ToString();
            //dtpRegDOB.Value = dgvUpdateEmpInfo.Rows[e.RowIndex].Cells[9].Value.ToString();
            rtbxRegAddress.Text = dgvUpdateEmpInfo.Rows[e.RowIndex].Cells[10].Value.ToString();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
        //    Connection connection = new Connection();
        //    string query = "update empInfoTb where empPhoneNo ='"++"' set Name='" + txtname.Text + "',Email='" + txtemail.Text + "' where ID=" + txtid.Text + "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            string query = "select * from notificationTb";
            dgvNotification.DataSource = connection.pullForDataTable(query);
        }

        private void btnSendMessages_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            string query = "insert into notificationTb (notifications) values ('"+tbxMessages.Text+"')";
            connection.push(query);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            string query = "select * from notificationTb";
            dataGridView1.DataSource=connection.pullForDataTable(query);
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            pnlNotification.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pnlMessages.Visible = true;
        }
    }
}

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
                MessageBox.Show("Customer Name and Mobile No cant be empty!");
            }
            else
            {
                if (txtCustomerMobileNo.TextLength != 11)
                {
                    MessageBox.Show("Mobile No not valid!");
                }
                Connection connection = new Connection();
                string query = $"INSERT into customerInfoTb(customerName, customerMobileNo, customerSubscriptionStatus) values('" + txtCustomerName.Text + "','" + txtCustomerMobileNo.Text + "','Unsubscribed')";
                connection.push(query);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            string query = $"select * from customerInfoTb where customerMobileNo = {txtCustomerMobileNo.Text}";
            dgvCustomerInfo.DataSource = connection.pullForDataTable(query);
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dgvCustomerInfo.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtMobileNo.Text = dgvCustomerInfo.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSubscriptionStatus.Text = dgvCustomerInfo.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            string query = $"Select * from productInfoTb where ProductName = '{txtProductSearch.Text}'";
            dgvSearchedProduct.DataSource = connection.pullForDataTable(query);
        }
    }
}

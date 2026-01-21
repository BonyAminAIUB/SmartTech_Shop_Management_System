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
    public partial class UpdateProfile : Form
    {
        public UpdateProfile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            string query = $"insert into empProfileUpdate (empName,empUsername,empEmail,empPhoneNo,empRole,empQualification,empGender,empJoiningDate,empDOB,empAddress) values ('{txtUpdateRegName.Text}','{txtRegUsername.Text}','{txtRegEmail.Text}','{txtRegPhoneNo.Text}','{cbxRole.Text}','{cbxUpdateQua.Text}','{cbxGender.Text}','{dtpJoiningDate.Value}','{(dtpDOB.Value)}','{rtbxRegAddress.Text}')";
            connection.push(query);
        }

        private void UpdateProfile_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            string query = $"select * from empInfoTb where empUsername = '{LoginForm.sharedUsername}'";
            DataTable dt = connection.pullForDataTable(query);
            txtUpdateRegName.Text = dt.Rows[0]["empName"].ToString();
            txtRegUsername.Text = dt.Rows[0]["empUsername"].ToString();
            txtRegEmail.Text = dt.Rows[0]["empEmail"].ToString();
            txtRegPhoneNo.Text = dt.Rows[0]["empPhoneNo"].ToString();
            cbxRole.Text = dt.Rows[0]["empRole"].ToString();
            cbxUpdateQua.Text = dt.Rows[0]["empQualification"].ToString();
            cbxGender.Text = dt.Rows[0]["empGender"].ToString();
            dtpJoiningDate.Value = Convert.ToDateTime(dt.Rows[0]["empJoiningDate"].ToString());
            dtpDOB.Value = Convert.ToDateTime(dt.Rows[0]["empDOB"].ToString());
            rtbxRegAddress.Text = dt.Rows[0]["empAddress"].ToString();
        }
    }
}

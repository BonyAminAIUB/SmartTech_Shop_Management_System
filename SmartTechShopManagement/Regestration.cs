using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartTechShopManagement
{
    public partial class Regestration : Form
    {
        public Regestration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string regName,regUsername, regRole,regEmail, regPhoneNo , regQua, regGender,  regAddress;
            DateTime regJoiningDate, regDOB;
            regName = txtRegName.Text;
            regUsername = txtRegUsername.Text;
            regEmail = txtRegEmail.Text;
            regPhoneNo = txtRegPhoneNo.Text;
            regRole = cbxRegRole.Text;
            regQua = cbxRegQualificatioin.Text;
            regGender = cbxRegGender.Text;
            regJoiningDate = dtpRegJoiningDate.Value;
            regDOB = dtpRegDOB.Value;
            regAddress = rtbxRegAddress.Text;

            Connection connection1 = new Connection();
            string queryInsertIntoEmpInfoTb = "Insert into empInfoTb (empName,empUsername,empEmail,empPhoneNo,empRole,empQualification,empGender,empJoiningDate,empDOB,empAddress) values ('" + regName + "','" + regUsername + "','" + regEmail + "','" + regPhoneNo + "','" + regRole + "','" + regQua + "','" + regGender + "','" + regJoiningDate + "','" + regDOB + "','" + regAddress + "')";
            connection1.push(queryInsertIntoEmpInfoTb);
            MessageBox.Show("New Employee Saved!");

            //string querySelectFromEmpTb = "SELECT * From empInfoTb ";

            //Connection connection2 = new Connection();
            //private class Admin
            //adminDashboard.dgv.DataSource = connection2.pullForDataTable(query);

            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRegName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

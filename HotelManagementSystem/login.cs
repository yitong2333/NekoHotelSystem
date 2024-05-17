using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private bool IsValidataInput()
        {
            if (txtUser.Text.Trim() == "")
            {
                MessageBox.Show("请输入账号！", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUser.Focus();
                return false;
            }
            else if (txtPwd.Text == "")
            {
                MessageBox.Show("请输入密码！", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPwd.Focus();
                return false;
            }
            return true;
        }

        private bool IsValidataUser(string user, string pwd, ref string message)
        {
            string sql = string.Format("select count(*) from DB_ManageInfo where loginNo='{0}' and loginPwd='{1}'", user, pwd);
            int get = new DBHelper().GetSqlResult(sql);
            if (get < 1)
            {
                message = "账号或密码错误！";
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (IsValidataInput())
            {
                string user = txtUser.Text;
                string pwd = txtPwd.Text;
                string message = "账号或密码错误！";

                bool isValidUser = IsValidataUser(user, pwd, ref message);

                if (isValidUser)
                {
                    WFMain mainform = new WFMain();
                    mainform.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(message, "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private void btnExit_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("真的要退出程序吗？", "退出程序", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MRegister register = new MRegister();
            register.Show();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}

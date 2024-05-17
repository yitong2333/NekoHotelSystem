using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class MRegister : Form
    {
        public MRegister()
        {
            InitializeComponent();
        }
        #region 判断输入的是否正确
        private bool IsVaildataInput()
        {
            if (txtuid.Text=="")
            {
                MessageBox.Show("请输入用户名！！","用户注册",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtuid.Focus();
                return false;
            }
            else if (txtpwd.Text=="")
            {
                MessageBox.Show("请输入密码！！", "用户注册", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpwd.Focus();
                return false;
            }
            else if (txtpwd2.Text=="")
            {
                MessageBox.Show("请再输一遍密码！！", "用户注册", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpwd2.Focus();
                return false;
            }
            else if (txtpwd2.Text!=txtpwd.Text)
            {
                MessageBox.Show("两次密码不一样！！", "用户注册", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpwd.Clear();
                txtpwd2.Clear();
                txtpwd.Focus();
                return false;
            }
            else
            {
                return true;
            }
           
        }
        #endregion
        #region 判断是否已经有了
        private bool IsvaliDataUser(string uid, string pwd, string type, ref string message)
        {
            string sql = string.Format("select count(*) from DB_ManageInfo where loginNO='{0}' and loginType='{1}'", uid, type);
            int count = new DBHelper().GetDsqlResult(sql);
            if (count == 1)
            {
                message = "用户已经存在，请更换用户名";
                MessageBox.Show(message, "用户注册", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }


        #endregion
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnreg_Click(object sender, EventArgs e)
        {
            bool isValidUser = false;
            string message = "";

            // 验证是否合法
            if (IsVaildataInput())
            {
                isValidUser = IsvaliDataUser(txtuid.Text.Trim(), txtpwd.Text, "管理员", ref message);

                if (isValidUser)
                {
                    string sql = string.Format("insert into DB_ManageInfo(loginNo, loginPwd, loginType) values ('{0}', '{1}', '{2}')", txtuid.Text.Trim(), txtpwd.Text, "管理员");
                    int result = new DBHelper().GetDsqlResult(sql);

                    if (result == 1)
                    {
                        MessageBox.Show("注册成功！", "用户注册", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("注册失败，请重试！", "用户注册", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(message, "用户注册", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void MRegister_Load(object sender, EventArgs e)
        {
            txtuid.Focus();
        }
    }
}

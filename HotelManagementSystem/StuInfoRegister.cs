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
    public partial class StuInfoRegister : Form
    {
        public StuInfoRegister()
        {
            InitializeComponent();
        }

        private void btnIRExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIROK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIRID.Text) || string.IsNullOrEmpty(txtIRName.Text) || cboIRSex.SelectedItem == null || string.IsNullOrEmpty(txtIRContact.Text) || string.IsNullOrEmpty(txtIRPhone.Text))
            {
                MessageBox.Show("请填写完整信息");
                return;
            }
            string stuNo = txtIRID.Text.ToString();
            string stuName = txtIRName.Text.ToString();
            string stuSex = cboIRSex.SelectedItem.ToString();
            string stuTime = dtpRegTime.Value.ToString();
            string stuDepart = txtIRContact.Text.ToString();
            string stuPro = txtIRPhone.Text.ToString();
            string stuElse = txtIRBz.Text.ToString();
            string query = $"INSERT INTO DB_StuInfo (stuNo, stuName, stuSex, stuTime, stuDepart, stuPro, stuElse) " +
                           $"VALUES ('{stuNo}', '{stuName}','{stuSex}','{stuTime}','{stuDepart}','{stuPro}','{stuElse}')";
            int rowCount = new DBHelper().GetDsqlResult(query);

            if (rowCount > 0)
            {
                MessageBox.Show("记录添加成功");
                
            }
            else
            {
                MessageBox.Show("记录添加失败");
            }
        }

        private void StuInfoRegister_Load(object sender, EventArgs e)
        {

        }
    }
}

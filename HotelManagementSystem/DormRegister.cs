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
    public partial class DormRegister : Form
    {
        public DormRegister()
        {
            InitializeComponent();
        }
        private void FormState()
        {
            cboBuildArea.SelectedIndex = -1;
            cboBuildArea.Enabled = false;
            cboDormNo.Enabled = false;
            cboBuildNo.Enabled = false;
            txtStuId.Text = null;
            txtSex.Text = null;
            txtStuCom.Text = null;
            txtStuName.Text = null;
            txtStuTel.Text = null;


        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void RefreshListView()
        {
            //select没分配房间的人
            string query = "SELECT stuNo, stuName, stuSex, stuDepart, stuPro FROM DB_StuInfo where not exists(select * from DB_DormRegister where stuNo=DB_StuInfo.stuNo)";
            SqlDataReader reader = new DBHelper().GetResult(query);
            lvDr.Items.Clear();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["stuNo"].ToString());
                item.SubItems.Clear();
                item.SubItems[0].Text=reader["stuNo"].ToString();
                item.SubItems.Add(reader["stuName"].ToString());
                item.SubItems.Add(reader["stuSex"].ToString());
                item.SubItems.Add(reader["stuDepart"].ToString());
                item.SubItems.Add(reader["stuPro"].ToString());
                

                lvDr.Items.Add(item);
            }
        }
        private void buildAreaLoad()
        {

            string query = "select distinct buildArea from DB_BuildInfo";
            SqlDataReader reader = new DBHelper().GetResult(query);
            while (reader.Read())
            {
                cboBuildArea.Items.Add(reader["buildArea"].ToString());
            }
        }
        private void buildNoLoad()
        {
            cboBuildNo.SelectedIndex = -1;
            string query = string.Format("select distinct buildNo from DB_BuildInfo where buildArea='{0}'",cboBuildArea.Text);
            SqlDataReader reader = new DBHelper().GetResult(query);
            while (reader.Read())
            {
                cboBuildNo.Items.Add(reader["buildNo"].ToString());
            }
        }
        private void dormIdLoad()
        {
            //查有空床的area和buildNo
            cboDormNo.SelectedIndex = -1;
            string query = string.Format("select a.* from DB_DormInfo a where a.bedNum - (select count(*) from DB_DormRegister where buildArea" +
                "=a.buildArea and buildNo = a.buildNo and dormNo = a.dormNo) > 0 and a.buildArea ='{0}' and a.buildNo ={1}", cboBuildArea.Text, Convert.ToInt32(cboBuildNo.Text));
            SqlDataReader reader = new DBHelper().GetResult(query);
            while (reader.Read())
            {
                cboDormNo.Items.Add(reader["dormNo"].ToString());
            }
        }
        //查询有空床的客房
        private void bednumCx()
        {

            string query = string.Format("SELECT a.*, bedNumLeft = a.bedNum - (SELECT COUNT(*) FROM DB_DormRegister " +
                "WHERE buildArea = a.buildArea AND buildNo = a.buildNo AND dormNo = a.dormNo) FROM DB_DormInfo a WHERE " +
                "a.bedNum - (SELECT COUNT(*) FROM DB_DormRegister WHERE buildArea = a.buildArea AND buildNo = a.buildNo " +
                "AND dormNo = a.dormNo) > 0 AND a.buildArea = '{0}' AND a.buildNo = {1} AND a.dormNo = {2}", cboBuildArea.
                Text, Convert.ToInt32(cboBuildNo.Text), Convert.ToInt32(cboDormNo.Text));
            SqlDataReader reader = new DBHelper().GetResult(query);
            while (reader.Read())
            {
                txtBed.Text = (reader["bedNumLeft"].ToString());

            }
        }
        private void btnReg_Click(object sender, EventArgs e)
        {
            if (cboBuildArea.SelectedItem==null||cboBuildNo.SelectedItem==null||cboDormNo.SelectedItem==null)
            {
                MessageBox.Show("请填写完整信息");
                return;
            }

            string stuNo = txtStuId.Text.ToString();
            string buildArea = cboBuildArea.Text.ToString();
            string stuName = txtStuName.Text.ToString();
            string stuSex = txtSex.Text.ToString();
            string stuDepart = txtStuTel.Text.ToString();
            string stuPro = cboBuildNo.Text.ToString();
            string buildNo = cboBuildNo.Text.ToString();
            string dormNo = cboDormNo.Text.ToString();
            string query = $"INSERT INTO DB_DormRegister (stuNo, buildArea, buildNo, dormNo) " +
                           $"VALUES ('{stuNo}','{buildArea}','{buildNo}','{dormNo}')";
            int rowCount = new DBHelper().GetDsqlResult(query);

            if (rowCount > 0)
            {
                MessageBox.Show("入住成功！");
                RefreshListView();
            }
            else
            {
                MessageBox.Show("入住失败！");
            }
        }

        private void DormRegister_Load(object sender, EventArgs e)
        {
            FormState();
            RefreshListView();
        }

        private void lvDr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDr.SelectedItems.Count > 0)
            {
                cboBuildArea.Items.Clear();
                ListViewItem seletedItem = lvDr.SelectedItems[0];
                txtStuId.Text = seletedItem.SubItems[0].Text;
                txtStuName.Text = seletedItem.SubItems[1].Text;
                txtSex.Text = seletedItem.SubItems[2].Text;
                txtStuCom.Text = seletedItem.SubItems[3].Text;
                txtStuTel.Text = seletedItem.SubItems[4].Text;
                cboBuildArea.Enabled = true;
                cboBuildArea.Enabled = true;
                buildAreaLoad();
            }
        }

        private void cboBuildArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboBuildNo.Enabled = true;
            buildNoLoad();
        }

        private void cboBuildNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboDormNo.Enabled = true;
            dormIdLoad();
        }

        private void cboDormNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            bednumCx();
        }
    }
}

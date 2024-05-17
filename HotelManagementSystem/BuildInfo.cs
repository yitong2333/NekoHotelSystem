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
    public partial class BuildInfo : Form
    {
        public BuildInfo()
        {
            InitializeComponent();
        }

        private void LoadBuildAreas()
        {
            string query = "SELECT * FROM DB_BuildInfo";
            SqlDataReader reader = new DBHelper().GetResult(query);
            while (reader.Read())
            {
                cboSelectBuildArea.Items.Add(reader["buildArea"]);
            }
        }


        private void RefreshListView()
        {
            
            string query = "SELECT buildId, buildArea, buildNo, buildMsg FROM DB_BuildInfo";
            SqlDataReader reader = new DBHelper().GetResult(query);
            lvBuildInfo.Items.Clear();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["buildId"].ToString());
                item.SubItems.Add(reader["buildArea"].ToString());
                item.SubItems.Add(reader["buildNo"].ToString());
                item.SubItems.Add(reader["buildMsg"].ToString());

                lvBuildInfo.Items.Add(item);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void BuildInfo_Load(object sender, EventArgs e)
        {
            LoadBuildAreas(); // 加载地理区域
            RefreshListView(); // 刷新列表
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (cboSelectBuildArea.SelectedItem == null)
            {
                MessageBox.Show("请选择地理区域");
                return;
            }

            string selectedBuildArea = cboSelectBuildArea.SelectedItem.ToString();
            string query = $"SELECT buildId, buildArea, buildNo, buildMsg FROM DB_BuildInfo WHERE buildArea = '{selectedBuildArea}'";
            SqlDataReader reader = new DBHelper().GetResult(query);

            lvBuildInfo.Items.Clear();

            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["buildId"].ToString());
                item.SubItems.Add(reader["buildArea"].ToString());
                item.SubItems.Add(reader["buildNo"].ToString());
                item.SubItems.Add(reader["buildMsg"].ToString());

                lvBuildInfo.Items.Add(item);
            }

            //reader.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            RefreshListView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cboAddBuildArea.SelectedItem == null || string.IsNullOrEmpty(txtBuildNo.Text) || cboBuildMsg.SelectedItem == null)
            {
                MessageBox.Show("请填写完整信息");
                return;
            }

            string buildArea = cboAddBuildArea.SelectedItem.ToString();
            string buildNo = txtBuildNo.Text;
            string buildMsg = cboBuildMsg.SelectedItem.ToString();
            string query = $"INSERT INTO DB_BuildInfo (buildArea, buildNo, buildMsg) " +
                           $"VALUES ('{buildArea}', '{buildNo}','{buildMsg}')";
            int rowCount = new DBHelper().GetDsqlResult(query);

            if (rowCount > 0)
            {
                MessageBox.Show("记录添加成功");
                RefreshListView();
            }
            else
            {
                MessageBox.Show("记录添加失败");
            }
        }

        private void btnUUpdate_Click(object sender, EventArgs e)
        {
            if (lvBuildInfo.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择要更新的记录");
                return;
            }

            string buildId = txtUpdateId.Text.ToString();
            string buildArea = txtUpdateArea.Text.ToString();
            string buildNo = txtUpdateBID.Text.ToString();
            string buildMsg = cboUpdateMsg.SelectedItem.ToString();

            string query = $"UPDATE DB_BuildInfo SET buildArea = '{buildArea}', buildNo = {buildNo}, buildMsg = '{buildMsg}' " +
                           $"WHERE buildId = '{buildId}'";
            int rowCount = new DBHelper().GetDsqlResult(query);

            if (rowCount > 0)
            {
                MessageBox.Show("记录更新成功");
                RefreshListView();
            }
            else
            {
                MessageBox.Show("记录更新失败");
            }
        }

        private void btnUDelete_Click(object sender, EventArgs e)
        {
            if (lvBuildInfo.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择要删除的记录");
                return;
            }

            string buildId = lvBuildInfo.SelectedItems[0].Text;
            string query = $"DELETE FROM DB_BuildInfo WHERE buildId = {buildId}";
            int rowCount = new DBHelper().GetDsqlResult(query);

            if (rowCount > 0)
            {
                MessageBox.Show("记录删除成功");
                RefreshListView();
            }
            else
            {
                MessageBox.Show("记录删除失败");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //LoadBuildAreas();
            RefreshListView();
        }

        private void lvBuildInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvBuildInfo.SelectedItems.Count > 0)
            {
                ListViewItem seletedItem = lvBuildInfo.SelectedItems[0];
                txtUpdateId.Text = seletedItem.SubItems[0].Text;
                txtUpdateArea.Text = seletedItem.SubItems[1].Text;
                txtUpdateBID.Text = seletedItem.SubItems[2].Text;
                cboUpdateMsg.Text = seletedItem.SubItems[3].Text;
            }

        }

        private void cboSelectBuildArea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

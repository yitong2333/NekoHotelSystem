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
    public partial class FrmDormlnfo : Form
    {
        public FrmDormlnfo()
        {
            InitializeComponent();

        }
        private void LoadDormAreas()
        {
            string query = "SELECT * FROM DB_DormInfo";
            SqlDataReader reader = new DBHelper().GetResult(query);
            while (reader.Read())
            {
                cboArea.Items.Add(reader["buildArea"].ToString());
            }
        }
        private void LoadBuildId()
        {
            string query = "SELECT * FROM DB_DormInfo";
            SqlDataReader reader = new DBHelper().GetResult(query);
            while (reader.Read())
            {
                cboBuildId.Items.Add(reader["buildNo"]);
            }
        }
        private void RefreshListView()
        {

            string query = "SELECT * FROM DB_DormInfo";
            SqlDataReader reader = new DBHelper().GetResult(query);
            lvDormInfo.Items.Clear();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(reader["dormId"].ToString());
                //item.SubItems.Add(reader["dormId"].ToString());
                item.SubItems.Add(reader["buildArea"].ToString());
                item.SubItems.Add(reader["buildNo"].ToString());
                item.SubItems.Add(reader["dormNo"].ToString());
                item.SubItems.Add(reader["bedNum"].ToString());
                item.SubItems.Add(reader["dormElse"].ToString());

                lvDormInfo.Items.Add(item);
            }
        }
        private void Dormlnfo_Load(object sender, EventArgs e)
        {
            LoadDormAreas();
            LoadBuildId();
            RefreshListView();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshListView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cboAddArea.SelectedItem == null || string.IsNullOrEmpty(txtAddDormNo.Text) || cboAddBed.SelectedItem == null || cboAddBuildNo.SelectedItem == null)
            {
                MessageBox.Show("请填写完整信息");
                return;
            }
            
                string buildArea = cboAddArea.Text.ToString();
                string buildNo = cboAddBuildNo.Text.ToString();
                string dormNo = txtAddDormNo.Text.ToString();
                string bedNum = cboAddBed.Text.ToString();
                string dormElse = txtAddBz.Text.ToString();
                string query = $"INSERT INTO DB_DormInfo (buildArea, buildNo, dormNo, bedNum, dormElse) " +
                               $"VALUES ('{buildArea}','{buildNo}','{dormNo}','{bedNum}','{dormElse}')";
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

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (cboArea.SelectedItem == null)
            {
                MessageBox.Show("请选择地理区域");
                return;
            }
            if (cboBuildId.SelectedItem==null)
            {
                MessageBox.Show("请选择客房楼号");
                return;
            }
            RefreshListView();
        }

        private void lvDormInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDormInfo.SelectedItems.Count > 0)
            {
                ListViewItem seletedItem = lvDormInfo.SelectedItems[0];
                cboUpdateArea.SelectedItem = seletedItem.SubItems[1].Text;
                cboUpdataBuildId.Text = seletedItem.SubItems[2].Text;
                txtUpdateDormId.Text = seletedItem.SubItems[3].Text;
                cboUpdataBed.Text = seletedItem.SubItems[4].Text;
                txtUpdateBz.Text = seletedItem.SubItems[5].Text;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lvDormInfo.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择要更新的记录");
                return;
            }
            ListViewItem seletedItem = lvDormInfo.SelectedItems[0];
            string buildArea = cboUpdateArea.Text;
            int buildNo = Convert.ToInt32(cboUpdataBuildId.Text);
            int dormNo = Convert.ToInt32(txtUpdateDormId.Text);
            int bedNum = Convert.ToInt32(cboUpdataBed.Text);
            int dormId = int.Parse(seletedItem.SubItems[0].Text);
            string dormElse = txtUpdateBz.Text;

            string query = $"UPDATE DB_DormInfo SET buildArea = '{buildArea}', buildNo = '{buildNo}', dormNo = '{dormNo}',bedNum='{bedNum}',dormElse='{dormElse}'" +
                           $"WHERE dormId = '{dormId}'";
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

        private void cboArea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvDormInfo.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择要删除的记录");
                return;
            }

            string dormId = lvDormInfo.SelectedItems[0].Text;
            string query = $"DELETE FROM DB_DormInfo WHERE dormId = {dormId}";
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
    }
}

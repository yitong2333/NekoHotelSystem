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
    public partial class InfoSearch : Form
    {
        public InfoSearch()
        {
            InitializeComponent();
        }
        private void lvload()
        {
            //lvSIS.Clear();
            string query = "select b.buildArea,b.buildNo,b.dormNo,a.stuNo,a.stuName,a.stuSex,Convert(varchar(10),a.stuTime,120) as stuTime,a.stuDepart,a.stuPro,a.stuElse from DB_StuInfo a,DB_DormRegister b where a.stuNo= b.stuNo";
            SqlDataReader reader = new DBHelper().GetResult(query);
            while (reader.Read())
            {
                //cboArea.Items.Add(reader["bedNumLeft"].ToString());
                ListViewItem item = new ListViewItem(reader[0].ToString());
                item.SubItems.Add(reader[0].ToString());
                item.SubItems.Add(reader[1].ToString());
                item.SubItems.Add(reader[2].ToString());
                item.SubItems.Add(reader[3].ToString());
                item.SubItems.Add(reader[4].ToString());
                item.SubItems.Add(reader[5].ToString());
                item.SubItems.Add(reader[6].ToString());
                item.SubItems.Add(reader[7].ToString());
                item.SubItems.Add(reader[8].ToString());
                item.SubItems.Add(reader[9].ToString());
                lvSIS.Items.Add(item);
            }

        }
        private void areaload()
        {
            string query = "select distinct buildArea from DB_BuildInfo";
            SqlDataReader reader = new DBHelper().GetResult(query);
            while (reader.Read())
            {
                cboArea.Items.Add(reader["buildArea"].ToString());
            }
        }
        private void buildNoLoad()
        {
            cboBuildId.SelectedIndex = -1;
            string query = string.Format("select distinct buildNo from DB_BuildInfo where buildArea='{0}'", cboArea.Text);
            SqlDataReader reader = new DBHelper().GetResult(query);
            while (reader.Read())
            {
                cboBuildId.Items.Add(reader["buildNo"].ToString());
            }
        }
        private void dianleSelect()
        {
            //lvSIS.Clear();
            string query = string.Format("select b.buildArea,b.buildNo,b.dormNo,a.stuNo,a.stuName,a.stuSex,Convert(varchar(10),a.stuTime,120)as stuTime,a.stuDepart,a.stuPro,a.stuElse from DB_StuInfo a,DB_DormRegister b where a.stuNo=b.stuNo and b.buildArea='{0}'and b.buildNo={1} and b.dormNo={2}",cboArea.Text,cboBuildId.Text,cboDormId.Text);
            SqlDataReader reader = new DBHelper().GetResult(query);
            while (reader.Read())
            {
                
                ListViewItem item = new ListViewItem(reader[0].ToString());
                item.SubItems.Add(reader[0].ToString());
                item.SubItems.Add(reader[1].ToString());
                item.SubItems.Add(reader[2].ToString());
                item.SubItems.Add(reader[3].ToString());
                item.SubItems.Add(reader[4].ToString());
                item.SubItems.Add(reader[5].ToString());
                item.SubItems.Add(reader[6].ToString());
                item.SubItems.Add(reader[7].ToString());
                item.SubItems.Add(reader[8].ToString());
                item.SubItems.Add(reader[9].ToString());
                lvSIS.Items.Add(item);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboBuildId.Enabled = true;
            buildNoLoad();
        }

        private void btnReferesh_Click(object sender, EventArgs e)
        {
            
            lvload();
        }

        private void InfoSearch_Load(object sender, EventArgs e)
        {
            lvload();
            areaload();
        }

        private void cboBuildId_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboDormId.Items.Clear();
            cboDormId.Enabled = true;
            string query = string.Format("select dormNo from DB_DormInfo where buildArea ='" + cboArea.Text + "'and buildNo ='" + cboBuildId.Text + "' order by dormNo");
            SqlDataReader reader = new DBHelper().GetResult(query);
            while (reader.Read())
            {
                cboDormId.Items.Add(reader["dormNo"].ToString());
            }
        }

        private void cboDormId_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSelect.Enabled = true;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            
            dianleSelect();
        }
    }
}

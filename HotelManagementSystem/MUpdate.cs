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
    public partial class MUpdate : Form
    {

        public MUpdate()
        {
            InitializeComponent();
        }
        #region 把从数据库弄来的数据写在listview上
        private void MUpdate_Load(object sender, EventArgs e)
        {
            try
            {
                SqlDataReader dataReader = new DBHelper().GetResult("select * from DB_ManageInfo");
                bool hasNextData = dataReader.Read();
                while (hasNextData)
                {
                    ListViewItem lm = new ListViewItem();
                    lm.SubItems.Clear();
                    lm.Text = dataReader["loginId"].ToString();
                    //lm.SubItems.Add(dataReader["loginId"].ToString()); --就这行找了1小时
                    lm.SubItems.Add(dataReader["loginNo"].ToString());
                    lm.SubItems.Add(dataReader["loginPwd"].ToString());
                    lm.SubItems.Add(dataReader["loginType"].ToString());
                    lvManageInfo.Items.Add(lm);
                    hasNextData = dataReader.Read();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region 查询按钮事件
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (cbotype.Text == "")
            {
                MessageBox.Show("请选择需要查询权限的用户！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string sql = string.Format("select loginId,loginNo,loginPwd,loginType from DB_ManageInfo where loginType = '{0}'", cbotype.Text);
            try
            {
                SqlDataReader dataReader = new DBHelper().GetResult(sql);
                if (!dataReader.Read())
                {
                    lvManageInfo.Items.Clear();
                    MessageBox.Show("无此权限用户信息！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    sql = string.Format("select loginId,loginNo,loginPwd,loginType from DB_ManageInfo where loginType='{0}'", cbotype.Text);
                    using (SqlDataReader secondDataReader = new DBHelper().GetResult(sql))
                    {
                        lvManageInfo.Items.Clear();
                        while (secondDataReader.Read())
                        {
                            ListViewItem lm = new ListViewItem();
                            lm.SubItems.Clear();
                            lm.Text = secondDataReader["loginId"].ToString();
                            lm.SubItems.Add(secondDataReader["loginNo"].ToString());
                            lm.SubItems.Add(secondDataReader["loginPwd"].ToString());
                            lm.SubItems.Add(secondDataReader["loginType"].ToString());
                            lvManageInfo.Items.Add(lm);
                            
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtID.Clear();
            txtNo.Clear();
            txtPwd.Clear();
            cbotype.SelectedIndex = -1;
        }
        #endregion

        #region 刷新按钮事件
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lvManageInfo.Items.Clear();
            MUpdate_Load(sender, e);
        }
        #endregion
        #region 更新按钮事件

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lvManageInfo.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择要更新的用户", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtPwd.Text == "")
            {
                MessageBox.Show("请输入密码", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPwd.Focus();
                return;
            }
            DialogResult result = MessageBox.Show("确认要更新吗？", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                string sql = string.Format("update DB_ManageInfo set loginPwd='{0}' where loginId={1}", txtPwd.Text,Convert.ToInt32(txtNo.Text));
                try
                {
                    int count = new DBHelper().GetDsqlResult(sql);
                    if (count == 1)
                    {
                        MessageBox.Show("更新记录成功！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("更新记录失败！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (cbotype.Text == "")
                    {
                        lvManageInfo.Items.Clear();
                        MUpdate_Load(sender, e);
                    }
                    else
                    {
                        FormRefresh();
                    }
                }
            }
        }
        #endregion

        #region 刷新listview的方法
        private void FormRefresh()
        {
            lvManageInfo.Items.Clear();
            string sqlStr = string.Format("select * from DB_ManageInfo where loginType='{0}'", cbotype.Text);
            try
            {
                SqlDataReader dataReader = new DBHelper().GetResult(sqlStr);
                while (dataReader.Read())
                {
                    ListViewItem lm = new ListViewItem();
                    lm.SubItems.Clear();
                    lm.Text = dataReader["loginId"].ToString();
                    lm.SubItems.Add(dataReader["loginNo"].ToString());
                    lm.SubItems.Add(dataReader["loginPwd"].ToString());
                    lm.SubItems.Add(dataReader["loginType"].ToString());
                    lvManageInfo.Items.Add(lm);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                txtID.Text = "";
                txtNo.Text = "";
                txtPwd.Text = "";
                cbotype.SelectedIndex = -1;
            }
        }
        #endregion

        #region 删除按钮的事件
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lvManageInfo.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择要删除的用户记录", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult result = MessageBox.Show("确定删除此条信息？", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if (result == DialogResult.OK)
            {



                string sql = string.Format("delete from DB_ManageInfo where loginId={0}", Convert.ToInt32(txtNo.Text));
                //这一行也写错过 QWQ
                try
                {
                    int count = new DBHelper().GetDsqlResult(sql);
                    if (count == 1)
                    {
                        MessageBox.Show("删除记录成功!", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("删除记录失败，请重试！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {

                    if (cbotype.Text == "")
                    {
                        lvManageInfo.Items.Clear();
                        MUpdate_Load(sender, e);
                    }
                    else
                    {
                        FormRefresh();
                    }
                }
            }
        }

        #endregion

        #region listview选中时改变三个文本框的值

        private void lvManageInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvManageInfo.SelectedItems.Count>0)
            {
                ListViewItem seletedItem = lvManageInfo.SelectedItems[0];
                txtNo.Text = seletedItem.SubItems[0].Text;
                txtID.Text = seletedItem.SubItems[1].Text;
                txtPwd.Text = seletedItem.SubItems[2].Text;
            }
        }
        #endregion
    }
}

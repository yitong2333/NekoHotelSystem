using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace HotelManagementSystem
{
    public partial class WFMain : Form
    {
        public WFMain()
        {
            InitializeComponent();
        }
        private Form FindMdiChild(string childFormName)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.Name == childFormName)
                {
                    return childForm;
                }
            }

            return null;
        }

        private void WFMain_Load(object sender, EventArgs e)
        {

        }

        private void 管理员注册RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form existingChildForm = FindMdiChild("Mregister");
            if (existingChildForm != null)
            {
                existingChildForm.WindowState = FormWindowState.Normal;
                existingChildForm.Activate();
            }
            else
            {
                MRegister MRegister = new MRegister();
                MRegister.Name = "MRegister";
                MRegister.MdiParent = this;
                MRegister.Show();
            }
        }

        private void 管理员更新UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form existingChildForm = FindMdiChild("MUpdate");
            if (existingChildForm != null)
            {
                existingChildForm.WindowState = FormWindowState.Normal;
                existingChildForm.Activate();
            }
            else
            {
                MUpdate MUpdate = new MUpdate();
                MUpdate.Name = "MUpdate";
                MUpdate.MdiParent = this;
                MUpdate.Show();
            }
        }

        private void 客房楼管理BToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form existingChildForm = FindMdiChild("BuildInfo");
            if (existingChildForm != null)
            {
                existingChildForm.WindowState = FormWindowState.Normal;
                existingChildForm.Activate();
            }
            else
            {
                BuildInfo BuildInfo = new BuildInfo();
                BuildInfo.Name = "BuildInfo";
                BuildInfo.MdiParent = this;
                BuildInfo.Show();
            }
        }

        private void 客房管理DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form existingChildForm = FindMdiChild("FrmDormlnfo");
            if (existingChildForm != null)
            {
                existingChildForm.WindowState = FormWindowState.Normal;
                existingChildForm.Activate();
            }
            else
            {
                FrmDormlnfo FrmDormlnfo = new FrmDormlnfo();
                FrmDormlnfo.Name = "FrmDormlnfo";
                FrmDormlnfo.MdiParent = this;
                FrmDormlnfo.Show();
            }
        }

        private void 信息登记IToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form existingChildForm = FindMdiChild("StuInfoRegister");
            if (existingChildForm != null)
            {
                existingChildForm.WindowState = FormWindowState.Normal;
                existingChildForm.Activate();
            }
            else
            {
                StuInfoRegister StuInfoRegister = new StuInfoRegister();
                StuInfoRegister.Name = "StuInfoRegister";
                StuInfoRegister.MdiParent = this;
                StuInfoRegister.Show();
            }
        }

        private void 入住登记RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form existingChildForm = FindMdiChild("DormRegister");
            if (existingChildForm != null)
            {
                existingChildForm.WindowState = FormWindowState.Normal;
                existingChildForm.Activate();
            }
            else
            {
                DormRegister DormRegister = new DormRegister();
                DormRegister.Name = "DormRegister";
                DormRegister.MdiParent = this;
                DormRegister.Show();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Process.Start("http://blog.ytmc.fun");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form existingChildForm = FindMdiChild("InfoSearch");
            if (existingChildForm != null)
            {
                existingChildForm.WindowState = FormWindowState.Normal;
                existingChildForm.Activate();
            }
            else
            {
                InfoSearch InfoSearch = new InfoSearch();
                InfoSearch.Name = "InfoSearch";
                InfoSearch.MdiParent = this;
                InfoSearch.Show();
            }
        }
    }
}

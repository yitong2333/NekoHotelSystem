
namespace HotelManagementSystem
{
    partial class FrmDormlnfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.cboBuildId = new System.Windows.Forms.ComboBox();
            this.cboArea = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAddBz = new System.Windows.Forms.TextBox();
            this.cboAddBed = new System.Windows.Forms.ComboBox();
            this.cboAddBuildNo = new System.Windows.Forms.ComboBox();
            this.txtAddDormNo = new System.Windows.Forms.TextBox();
            this.cboAddArea = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtUpdateBz = new System.Windows.Forms.TextBox();
            this.txtUpdateDormId = new System.Windows.Forms.TextBox();
            this.cboUpdataBed = new System.Windows.Forms.ComboBox();
            this.cboUpdataBuildId = new System.Windows.Forms.ComboBox();
            this.cboUpdateArea = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lvDormInfo = new System.Windows.Forms.ListView();
            this.dormId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buildArea = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buildNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dormNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bedNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dormElse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnSelect);
            this.groupBox1.Controls.Add(this.cboBuildId);
            this.groupBox1.Controls.Add(this.cboArea);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选择查询条件";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(542, 55);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(80, 32);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(445, 55);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(82, 32);
            this.btnSelect.TabIndex = 4;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // cboBuildId
            // 
            this.cboBuildId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuildId.FormattingEnabled = true;
            this.cboBuildId.Location = new System.Drawing.Point(311, 55);
            this.cboBuildId.Name = "cboBuildId";
            this.cboBuildId.Size = new System.Drawing.Size(121, 32);
            this.cboBuildId.TabIndex = 3;
            // 
            // cboArea
            // 
            this.cboArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboArea.FormattingEnabled = true;
            this.cboArea.Location = new System.Drawing.Point(96, 55);
            this.cboArea.Name = "cboArea";
            this.cboArea.Size = new System.Drawing.Size(121, 32);
            this.cboArea.TabIndex = 2;
            this.cboArea.SelectedIndexChanged += new System.EventHandler(this.cboArea_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "客房楼号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "地理区域";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(0, 392);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 226);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.txtAddBz);
            this.tabPage1.Controls.Add(this.cboAddBed);
            this.tabPage1.Controls.Add(this.cboAddBuildNo);
            this.tabPage1.Controls.Add(this.txtAddDormNo);
            this.tabPage1.Controls.Add(this.cboAddArea);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 189);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "信息录入";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(512, 110);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(124, 68);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "插入";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAddBz
            // 
            this.txtAddBz.Location = new System.Drawing.Point(166, 110);
            this.txtAddBz.Multiline = true;
            this.txtAddBz.Name = "txtAddBz";
            this.txtAddBz.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAddBz.Size = new System.Drawing.Size(218, 71);
            this.txtAddBz.TabIndex = 9;
            // 
            // cboAddBed
            // 
            this.cboAddBed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAddBed.FormattingEnabled = true;
            this.cboAddBed.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cboAddBed.Location = new System.Drawing.Point(515, 61);
            this.cboAddBed.Name = "cboAddBed";
            this.cboAddBed.Size = new System.Drawing.Size(121, 32);
            this.cboAddBed.TabIndex = 8;
            // 
            // cboAddBuildNo
            // 
            this.cboAddBuildNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAddBuildNo.FormattingEnabled = true;
            this.cboAddBuildNo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cboAddBuildNo.Location = new System.Drawing.Point(515, 23);
            this.cboAddBuildNo.Name = "cboAddBuildNo";
            this.cboAddBuildNo.Size = new System.Drawing.Size(121, 32);
            this.cboAddBuildNo.TabIndex = 7;
            // 
            // txtAddDormNo
            // 
            this.txtAddDormNo.Location = new System.Drawing.Point(166, 66);
            this.txtAddDormNo.Name = "txtAddDormNo";
            this.txtAddDormNo.Size = new System.Drawing.Size(121, 31);
            this.txtAddDormNo.TabIndex = 6;
            // 
            // cboAddArea
            // 
            this.cboAddArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAddArea.FormattingEnabled = true;
            this.cboAddArea.Items.AddRange(new object[] {
            "阿努比斯",
            "办公大楼",
            "办公室",
            "炼狱小镇",
            "荒漠迷城",
            "炙热沙城"});
            this.cboAddArea.Location = new System.Drawing.Point(166, 23);
            this.cboAddArea.Name = "cboAddArea";
            this.cboAddArea.Size = new System.Drawing.Size(121, 32);
            this.cboAddArea.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(421, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "床位数";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(421, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "客房楼号";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "备注";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "客房号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "地理区域";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnDelete);
            this.tabPage2.Controls.Add(this.btnUpdate);
            this.tabPage2.Controls.Add(this.txtUpdateBz);
            this.tabPage2.Controls.Add(this.txtUpdateDormId);
            this.tabPage2.Controls.Add(this.cboUpdataBed);
            this.tabPage2.Controls.Add(this.cboUpdataBuildId);
            this.tabPage2.Controls.Add(this.cboUpdateArea);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 189);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "信息更新";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(470, 104);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 39);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(355, 104);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 38);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "更新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtUpdateBz
            // 
            this.txtUpdateBz.Location = new System.Drawing.Point(136, 104);
            this.txtUpdateBz.Multiline = true;
            this.txtUpdateBz.Name = "txtUpdateBz";
            this.txtUpdateBz.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUpdateBz.Size = new System.Drawing.Size(213, 77);
            this.txtUpdateBz.TabIndex = 10;
            // 
            // txtUpdateDormId
            // 
            this.txtUpdateDormId.Location = new System.Drawing.Point(136, 58);
            this.txtUpdateDormId.Name = "txtUpdateDormId";
            this.txtUpdateDormId.Size = new System.Drawing.Size(121, 31);
            this.txtUpdateDormId.TabIndex = 9;
            // 
            // cboUpdataBed
            // 
            this.cboUpdataBed.FormattingEnabled = true;
            this.cboUpdataBed.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cboUpdataBed.Location = new System.Drawing.Point(443, 58);
            this.cboUpdataBed.Name = "cboUpdataBed";
            this.cboUpdataBed.Size = new System.Drawing.Size(121, 32);
            this.cboUpdataBed.TabIndex = 8;
            // 
            // cboUpdataBuildId
            // 
            this.cboUpdataBuildId.FormattingEnabled = true;
            this.cboUpdataBuildId.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cboUpdataBuildId.Location = new System.Drawing.Point(443, 15);
            this.cboUpdataBuildId.Name = "cboUpdataBuildId";
            this.cboUpdataBuildId.Size = new System.Drawing.Size(121, 32);
            this.cboUpdataBuildId.TabIndex = 7;
            // 
            // cboUpdateArea
            // 
            this.cboUpdateArea.FormattingEnabled = true;
            this.cboUpdateArea.Items.AddRange(new object[] {
            "阿努比斯",
            "办公大楼",
            "办公室",
            "炼狱小镇",
            "荒漠迷城",
            "炙热沙城"});
            this.cboUpdateArea.Location = new System.Drawing.Point(136, 15);
            this.cboUpdateArea.Name = "cboUpdateArea";
            this.cboUpdateArea.Size = new System.Drawing.Size(121, 32);
            this.cboUpdateArea.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(350, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 25);
            this.label12.TabIndex = 4;
            this.label12.Text = "床位数";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(350, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 25);
            this.label11.TabIndex = 3;
            this.label11.Text = "客房楼号";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(48, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 25);
            this.label10.TabIndex = 2;
            this.label10.Text = "备注";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 25);
            this.label9.TabIndex = 1;
            this.label9.Text = "客房号";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "地理区域";
            // 
            // lvDormInfo
            // 
            this.lvDormInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dormId,
            this.buildArea,
            this.buildNo,
            this.dormNo,
            this.bedNum,
            this.dormElse});
            this.lvDormInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDormInfo.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvDormInfo.FullRowSelect = true;
            this.lvDormInfo.GridLines = true;
            this.lvDormInfo.HideSelection = false;
            this.lvDormInfo.Location = new System.Drawing.Point(0, 112);
            this.lvDormInfo.Name = "lvDormInfo";
            this.lvDormInfo.Size = new System.Drawing.Size(800, 280);
            this.lvDormInfo.TabIndex = 2;
            this.lvDormInfo.UseCompatibleStateImageBehavior = false;
            this.lvDormInfo.View = System.Windows.Forms.View.Details;
            this.lvDormInfo.SelectedIndexChanged += new System.EventHandler(this.lvDormInfo_SelectedIndexChanged);
            // 
            // dormId
            // 
            this.dormId.Text = "编号";
            // 
            // buildArea
            // 
            this.buildArea.Text = "地理区域";
            this.buildArea.Width = 167;
            // 
            // buildNo
            // 
            this.buildNo.Text = "客房楼号";
            this.buildNo.Width = 158;
            // 
            // dormNo
            // 
            this.dormNo.Text = "客房号";
            this.dormNo.Width = 100;
            // 
            // bedNum
            // 
            this.bedNum.Text = "床位号";
            this.bedNum.Width = 88;
            // 
            // dormElse
            // 
            this.dormElse.Text = "备注";
            this.dormElse.Width = 153;
            // 
            // Dormlnfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 618);
            this.Controls.Add(this.lvDormInfo);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Dormlnfo";
            this.Text = "客房信息管理";
            this.Load += new System.EventHandler(this.Dormlnfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ComboBox cboBuildId;
        private System.Windows.Forms.ComboBox cboArea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cboAddBed;
        private System.Windows.Forms.ComboBox cboAddBuildNo;
        private System.Windows.Forms.TextBox txtAddDormNo;
        private System.Windows.Forms.ComboBox cboAddArea;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvDormInfo;
        private System.Windows.Forms.TextBox txtAddBz;
        private System.Windows.Forms.ColumnHeader dormId;
        private System.Windows.Forms.ColumnHeader buildArea;
        private System.Windows.Forms.ColumnHeader buildNo;
        private System.Windows.Forms.ColumnHeader dormNo;
        private System.Windows.Forms.ColumnHeader bedNum;
        private System.Windows.Forms.ColumnHeader dormElse;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtUpdateBz;
        private System.Windows.Forms.TextBox txtUpdateDormId;
        private System.Windows.Forms.ComboBox cboUpdataBed;
        private System.Windows.Forms.ComboBox cboUpdataBuildId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboUpdateArea;
    }
}
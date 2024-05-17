
namespace HotelManagementSystem
{
    partial class BuildInfo
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboSelectBuildArea = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtBuildNo = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboBuildMsg = new System.Windows.Forms.ComboBox();
            this.cboAddBuildArea = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnUDelete = new System.Windows.Forms.Button();
            this.cboUpdateMsg = new System.Windows.Forms.ComboBox();
            this.btnUUpdate = new System.Windows.Forms.Button();
            this.txtUpdateBID = new System.Windows.Forms.TextBox();
            this.txtUpdateArea = new System.Windows.Forms.TextBox();
            this.txtUpdateId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lvBuildInfo = new System.Windows.Forms.ListView();
            this.floorNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.floorArea = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.floorId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.floorMsg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnSelect);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboSelectBuildArea);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(367, 41);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 34);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "更新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(269, 41);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(92, 34);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "地理区域";
            // 
            // cboSelectBuildArea
            // 
            this.cboSelectBuildArea.FormattingEnabled = true;
            this.cboSelectBuildArea.Location = new System.Drawing.Point(107, 41);
            this.cboSelectBuildArea.Name = "cboSelectBuildArea";
            this.cboSelectBuildArea.Size = new System.Drawing.Size(121, 32);
            this.cboSelectBuildArea.TabIndex = 0;
            this.cboSelectBuildArea.SelectedIndexChanged += new System.EventHandler(this.cboSelectBuildArea_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(0, 452);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(527, 217);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtBuildNo);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cboBuildMsg);
            this.tabPage1.Controls.Add(this.cboAddBuildArea);
            this.tabPage1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(519, 180);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "添加记录";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtBuildNo
            // 
            this.txtBuildNo.Location = new System.Drawing.Point(136, 55);
            this.txtBuildNo.Name = "txtBuildNo";
            this.txtBuildNo.Size = new System.Drawing.Size(160, 31);
            this.txtBuildNo.TabIndex = 20;
            this.txtBuildNo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.Location = new System.Drawing.Point(345, 35);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(142, 66);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "描述";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "客房楼号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "地理区域";
            // 
            // cboBuildMsg
            // 
            this.cboBuildMsg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuildMsg.FormattingEnabled = true;
            this.cboBuildMsg.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cboBuildMsg.Location = new System.Drawing.Point(136, 96);
            this.cboBuildMsg.Name = "cboBuildMsg";
            this.cboBuildMsg.Size = new System.Drawing.Size(160, 32);
            this.cboBuildMsg.TabIndex = 15;
            // 
            // cboAddBuildArea
            // 
            this.cboAddBuildArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAddBuildArea.FormattingEnabled = true;
            this.cboAddBuildArea.Items.AddRange(new object[] {
            "阿努比斯",
            "办公大楼",
            "办公室",
            "炼狱小镇",
            "荒漠迷城",
            "炙热沙城"});
            this.cboAddBuildArea.Location = new System.Drawing.Point(136, 16);
            this.cboAddBuildArea.Name = "cboAddBuildArea";
            this.cboAddBuildArea.Size = new System.Drawing.Size(160, 32);
            this.cboAddBuildArea.TabIndex = 14;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnUDelete);
            this.tabPage2.Controls.Add(this.cboUpdateMsg);
            this.tabPage2.Controls.Add(this.btnUUpdate);
            this.tabPage2.Controls.Add(this.txtUpdateBID);
            this.tabPage2.Controls.Add(this.txtUpdateArea);
            this.tabPage2.Controls.Add(this.txtUpdateId);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(519, 180);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "更新记录";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnUDelete
            // 
            this.btnUDelete.Location = new System.Drawing.Point(390, 134);
            this.btnUDelete.Name = "btnUDelete";
            this.btnUDelete.Size = new System.Drawing.Size(84, 32);
            this.btnUDelete.TabIndex = 10;
            this.btnUDelete.Text = "删除";
            this.btnUDelete.UseVisualStyleBackColor = true;
            this.btnUDelete.Click += new System.EventHandler(this.btnUDelete_Click);
            // 
            // cboUpdateMsg
            // 
            this.cboUpdateMsg.FormattingEnabled = true;
            this.cboUpdateMsg.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cboUpdateMsg.Location = new System.Drawing.Point(113, 134);
            this.cboUpdateMsg.Name = "cboUpdateMsg";
            this.cboUpdateMsg.Size = new System.Drawing.Size(121, 32);
            this.cboUpdateMsg.TabIndex = 9;
            // 
            // btnUUpdate
            // 
            this.btnUUpdate.Location = new System.Drawing.Point(265, 134);
            this.btnUUpdate.Name = "btnUUpdate";
            this.btnUUpdate.Size = new System.Drawing.Size(92, 32);
            this.btnUUpdate.TabIndex = 7;
            this.btnUUpdate.Text = "更新";
            this.btnUUpdate.UseVisualStyleBackColor = true;
            this.btnUUpdate.Click += new System.EventHandler(this.btnUUpdate_Click);
            // 
            // txtUpdateBID
            // 
            this.txtUpdateBID.Location = new System.Drawing.Point(113, 95);
            this.txtUpdateBID.Name = "txtUpdateBID";
            this.txtUpdateBID.Size = new System.Drawing.Size(100, 31);
            this.txtUpdateBID.TabIndex = 6;
            this.txtUpdateBID.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtUpdateArea
            // 
            this.txtUpdateArea.Location = new System.Drawing.Point(113, 54);
            this.txtUpdateArea.Name = "txtUpdateArea";
            this.txtUpdateArea.Size = new System.Drawing.Size(100, 31);
            this.txtUpdateArea.TabIndex = 5;
            // 
            // txtUpdateId
            // 
            this.txtUpdateId.Location = new System.Drawing.Point(113, 17);
            this.txtUpdateId.Name = "txtUpdateId";
            this.txtUpdateId.Size = new System.Drawing.Size(100, 31);
            this.txtUpdateId.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "描述";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "客房楼号";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "地理区域";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "编号";
            // 
            // lvBuildInfo
            // 
            this.lvBuildInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.floorNum,
            this.floorArea,
            this.floorId,
            this.floorMsg});
            this.lvBuildInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvBuildInfo.FullRowSelect = true;
            this.lvBuildInfo.GridLines = true;
            this.lvBuildInfo.HideSelection = false;
            this.lvBuildInfo.Location = new System.Drawing.Point(0, 96);
            this.lvBuildInfo.Name = "lvBuildInfo";
            this.lvBuildInfo.Size = new System.Drawing.Size(527, 356);
            this.lvBuildInfo.TabIndex = 4;
            this.lvBuildInfo.UseCompatibleStateImageBehavior = false;
            this.lvBuildInfo.View = System.Windows.Forms.View.Details;
            this.lvBuildInfo.SelectedIndexChanged += new System.EventHandler(this.lvBuildInfo_SelectedIndexChanged);
            // 
            // floorNum
            // 
            this.floorNum.Text = "编号";
            // 
            // floorArea
            // 
            this.floorArea.Text = "地理区域";
            this.floorArea.Width = 133;
            // 
            // floorId
            // 
            this.floorId.Text = "客房楼号";
            this.floorId.Width = 124;
            // 
            // floorMsg
            // 
            this.floorMsg.Text = "描述";
            this.floorMsg.Width = 84;
            // 
            // BuildInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 669);
            this.Controls.Add(this.lvBuildInfo);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "BuildInfo";
            this.Text = "客房楼信息管理";
            this.Load += new System.EventHandler(this.BuildInfo_Load);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSelectBuildArea;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtBuildNo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboBuildMsg;
        private System.Windows.Forms.ComboBox cboAddBuildArea;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cboUpdateMsg;
        private System.Windows.Forms.Button btnUUpdate;
        private System.Windows.Forms.TextBox txtUpdateBID;
        private System.Windows.Forms.TextBox txtUpdateArea;
        private System.Windows.Forms.TextBox txtUpdateId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUDelete;
        private System.Windows.Forms.ListView lvBuildInfo;
        private System.Windows.Forms.ColumnHeader floorNum;
        private System.Windows.Forms.ColumnHeader floorArea;
        private System.Windows.Forms.ColumnHeader floorId;
        private System.Windows.Forms.ColumnHeader floorMsg;
    }
}
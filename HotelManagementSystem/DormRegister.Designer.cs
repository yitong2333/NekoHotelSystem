
namespace HotelManagementSystem
{
    partial class DormRegister
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
            this.lvDr = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.txtBed = new System.Windows.Forms.TextBox();
            this.cboDormNo = new System.Windows.Forms.ComboBox();
            this.cboBuildNo = new System.Windows.Forms.ComboBox();
            this.cboBuildArea = new System.Windows.Forms.ComboBox();
            this.txtStuTel = new System.Windows.Forms.TextBox();
            this.txtStuCom = new System.Windows.Forms.TextBox();
            this.txtStuName = new System.Windows.Forms.TextBox();
            this.txtStuId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStuSex = new System.Windows.Forms.Label();
            this.lblStuName = new System.Windows.Forms.Label();
            this.lblStuNo = new System.Windows.Forms.Label();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvDr
            // 
            this.lvDr.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvDr.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvDr.FullRowSelect = true;
            this.lvDr.GridLines = true;
            this.lvDr.HideSelection = false;
            this.lvDr.Location = new System.Drawing.Point(12, 12);
            this.lvDr.Name = "lvDr";
            this.lvDr.Size = new System.Drawing.Size(803, 322);
            this.lvDr.TabIndex = 0;
            this.lvDr.UseCompatibleStateImageBehavior = false;
            this.lvDr.View = System.Windows.Forms.View.Details;
            this.lvDr.SelectedIndexChanged += new System.EventHandler(this.lvDr_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "编号";
            this.columnHeader1.Width = 66;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "姓名";
            this.columnHeader2.Width = 121;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "性别";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "联系方式";
            this.columnHeader4.Width = 114;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "手机号";
            this.columnHeader5.Width = 176;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSex);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnReg);
            this.groupBox1.Controls.Add(this.txtBed);
            this.groupBox1.Controls.Add(this.cboDormNo);
            this.groupBox1.Controls.Add(this.cboBuildNo);
            this.groupBox1.Controls.Add(this.cboBuildArea);
            this.groupBox1.Controls.Add(this.txtStuTel);
            this.groupBox1.Controls.Add(this.txtStuCom);
            this.groupBox1.Controls.Add(this.txtStuName);
            this.groupBox1.Controls.Add(this.txtStuId);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblStuSex);
            this.groupBox1.Controls.Add(this.lblStuName);
            this.groupBox1.Controls.Add(this.lblStuNo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(0, 340);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(827, 240);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "信息登记";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(693, 193);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 40);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "关闭";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(593, 193);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(94, 40);
            this.btnReg.TabIndex = 19;
            this.btnReg.Text = "入住";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // txtBed
            // 
            this.txtBed.Location = new System.Drawing.Point(593, 157);
            this.txtBed.Name = "txtBed";
            this.txtBed.Size = new System.Drawing.Size(72, 31);
            this.txtBed.TabIndex = 18;
            // 
            // cboDormNo
            // 
            this.cboDormNo.FormattingEnabled = true;
            this.cboDormNo.Location = new System.Drawing.Point(593, 115);
            this.cboDormNo.Name = "cboDormNo";
            this.cboDormNo.Size = new System.Drawing.Size(194, 32);
            this.cboDormNo.TabIndex = 17;
            this.cboDormNo.SelectedIndexChanged += new System.EventHandler(this.cboDormNo_SelectedIndexChanged);
            // 
            // cboBuildNo
            // 
            this.cboBuildNo.FormattingEnabled = true;
            this.cboBuildNo.Location = new System.Drawing.Point(593, 74);
            this.cboBuildNo.Name = "cboBuildNo";
            this.cboBuildNo.Size = new System.Drawing.Size(194, 32);
            this.cboBuildNo.TabIndex = 16;
            this.cboBuildNo.SelectedIndexChanged += new System.EventHandler(this.cboBuildNo_SelectedIndexChanged);
            // 
            // cboBuildArea
            // 
            this.cboBuildArea.FormattingEnabled = true;
            this.cboBuildArea.Location = new System.Drawing.Point(593, 33);
            this.cboBuildArea.Name = "cboBuildArea";
            this.cboBuildArea.Size = new System.Drawing.Size(194, 32);
            this.cboBuildArea.TabIndex = 15;
            this.cboBuildArea.SelectedIndexChanged += new System.EventHandler(this.cboBuildArea_SelectedIndexChanged);
            // 
            // txtStuTel
            // 
            this.txtStuTel.Location = new System.Drawing.Point(136, 193);
            this.txtStuTel.Name = "txtStuTel";
            this.txtStuTel.Size = new System.Drawing.Size(205, 31);
            this.txtStuTel.TabIndex = 13;
            // 
            // txtStuCom
            // 
            this.txtStuCom.Location = new System.Drawing.Point(136, 156);
            this.txtStuCom.Name = "txtStuCom";
            this.txtStuCom.Size = new System.Drawing.Size(205, 31);
            this.txtStuCom.TabIndex = 12;
            // 
            // txtStuName
            // 
            this.txtStuName.Location = new System.Drawing.Point(136, 76);
            this.txtStuName.Name = "txtStuName";
            this.txtStuName.Size = new System.Drawing.Size(205, 31);
            this.txtStuName.TabIndex = 10;
            // 
            // txtStuId
            // 
            this.txtStuId.Location = new System.Drawing.Point(136, 37);
            this.txtStuId.Name = "txtStuId";
            this.txtStuId.Size = new System.Drawing.Size(205, 31);
            this.txtStuId.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(485, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "剩余床位数";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(483, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "客房号";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(483, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "客房楼号";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(483, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 25);
            this.label9.TabIndex = 5;
            this.label9.Text = "地理区域";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "手机号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "联系方式";
            // 
            // lblStuSex
            // 
            this.lblStuSex.AutoSize = true;
            this.lblStuSex.Location = new System.Drawing.Point(46, 120);
            this.lblStuSex.Name = "lblStuSex";
            this.lblStuSex.Size = new System.Drawing.Size(50, 25);
            this.lblStuSex.TabIndex = 2;
            this.lblStuSex.Text = "性别";
            // 
            // lblStuName
            // 
            this.lblStuName.AutoSize = true;
            this.lblStuName.Location = new System.Drawing.Point(46, 79);
            this.lblStuName.Name = "lblStuName";
            this.lblStuName.Size = new System.Drawing.Size(50, 25);
            this.lblStuName.TabIndex = 1;
            this.lblStuName.Text = "姓名";
            // 
            // lblStuNo
            // 
            this.lblStuNo.AutoSize = true;
            this.lblStuNo.Location = new System.Drawing.Point(40, 40);
            this.lblStuNo.Name = "lblStuNo";
            this.lblStuNo.Size = new System.Drawing.Size(56, 25);
            this.lblStuNo.TabIndex = 0;
            this.lblStuNo.Text = "编号";
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(136, 117);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(72, 31);
            this.txtSex.TabIndex = 21;
            // 
            // DormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 580);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvDr);
            this.Name = "DormRegister";
            this.Text = "DormRegister";
            this.Load += new System.EventHandler(this.DormRegister_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvDr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.TextBox txtBed;
        private System.Windows.Forms.ComboBox cboDormNo;
        private System.Windows.Forms.ComboBox cboBuildNo;
        private System.Windows.Forms.ComboBox cboBuildArea;
        private System.Windows.Forms.TextBox txtStuTel;
        private System.Windows.Forms.TextBox txtStuCom;
        private System.Windows.Forms.TextBox txtStuName;
        private System.Windows.Forms.TextBox txtStuId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStuSex;
        private System.Windows.Forms.Label lblStuName;
        private System.Windows.Forms.Label lblStuNo;
        private System.Windows.Forms.TextBox txtSex;
    }
}
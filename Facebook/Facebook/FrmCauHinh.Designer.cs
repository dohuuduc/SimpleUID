namespace Facebook
{
    partial class FrmCauHinh
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkForword = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.chkBaiViet = new System.Windows.Forms.CheckBox();
            this.chkFriend = new System.Windows.Forms.CheckBox();
            this.chkUID = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTimkiemFB = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGoiLai = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTimerOut = new System.Windows.Forms.NumericUpDown();
            this.txtsysLimitCallApi = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gridQuocGia = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.làmTươiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lấyDữLiệuTừDataLoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAct = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Orderid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xoa = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtSeachQuocGia = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimkiemFB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGoiLai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimerOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsysLimitCallApi)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridQuocGia)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(401, 423);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(393, 359);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Account Facebook";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkForword);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.chkBaiViet);
            this.groupBox2.Controls.Add(this.chkFriend);
            this.groupBox2.Controls.Add(this.chkUID);
            this.groupBox2.Location = new System.Drawing.Point(8, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(438, 90);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Clear Data";
            // 
            // chkForword
            // 
            this.chkForword.AutoSize = true;
            this.chkForword.Location = new System.Drawing.Point(229, 42);
            this.chkForword.Name = "chkForword";
            this.chkForword.Size = new System.Drawing.Size(70, 17);
            this.chkForword.TabIndex = 5;
            this.chkForword.Text = "Theo Dõi";
            this.chkForword.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(303, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Thực Hiện";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chkBaiViet
            // 
            this.chkBaiViet.AutoSize = true;
            this.chkBaiViet.Location = new System.Drawing.Point(229, 19);
            this.chkBaiViet.Name = "chkBaiViet";
            this.chkBaiViet.Size = new System.Drawing.Size(149, 17);
            this.chkBaiViet.TabIndex = 2;
            this.chkBaiViet.Text = "Bài Viết - Like - Comments";
            this.chkBaiViet.UseVisualStyleBackColor = true;
            // 
            // chkFriend
            // 
            this.chkFriend.AutoSize = true;
            this.chkFriend.Location = new System.Drawing.Point(28, 42);
            this.chkFriend.Name = "chkFriend";
            this.chkFriend.Size = new System.Drawing.Size(126, 17);
            this.chkFriend.TabIndex = 1;
            this.chkFriend.Text = "Bạn bè / Thành Viên";
            this.chkFriend.UseVisualStyleBackColor = true;
            // 
            // chkUID
            // 
            this.chkUID.AutoSize = true;
            this.chkUID.Location = new System.Drawing.Point(28, 19);
            this.chkUID.Name = "chkUID";
            this.chkUID.Size = new System.Drawing.Size(143, 17);
            this.chkUID.TabIndex = 0;
            this.chkUID.Text = "Thông tin Uid, Gui, Page";
            this.chkUID.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTimkiemFB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtGoiLai);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTimerOut);
            this.groupBox1.Controls.Add(this.txtsysLimitCallApi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 109);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Facebook";
            // 
            // txtTimkiemFB
            // 
            this.txtTimkiemFB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimkiemFB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtTimkiemFB.Location = new System.Drawing.Point(303, 18);
            this.txtTimkiemFB.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.txtTimkiemFB.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtTimkiemFB.Name = "txtTimkiemFB";
            this.txtTimkiemFB.Size = new System.Drawing.Size(77, 22);
            this.txtTimkiemFB.TabIndex = 10;
            this.txtTimkiemFB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTimkiemFB.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Giới Hạn Tìm Kiếm FB";
            // 
            // txtGoiLai
            // 
            this.txtGoiLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGoiLai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtGoiLai.Location = new System.Drawing.Point(303, 45);
            this.txtGoiLai.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtGoiLai.Name = "txtGoiLai";
            this.txtGoiLai.Size = new System.Drawing.Size(77, 22);
            this.txtGoiLai.TabIndex = 8;
            this.txtGoiLai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGoiLai.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Gọi Lại:";
            // 
            // txtTimerOut
            // 
            this.txtTimerOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimerOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtTimerOut.Location = new System.Drawing.Point(104, 46);
            this.txtTimerOut.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.txtTimerOut.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.txtTimerOut.Name = "txtTimerOut";
            this.txtTimerOut.Size = new System.Drawing.Size(77, 22);
            this.txtTimerOut.TabIndex = 6;
            this.txtTimerOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTimerOut.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // txtsysLimitCallApi
            // 
            this.txtsysLimitCallApi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtsysLimitCallApi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtsysLimitCallApi.Location = new System.Drawing.Point(104, 19);
            this.txtsysLimitCallApi.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.txtsysLimitCallApi.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.txtsysLimitCallApi.Name = "txtsysLimitCallApi";
            this.txtsysLimitCallApi.Size = new System.Drawing.Size(77, 22);
            this.txtsysLimitCallApi.TabIndex = 5;
            this.txtsysLimitCallApi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtsysLimitCallApi.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Timer Out";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Giới Hạn Gọi API";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(393, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quốc Gia";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gridQuocGia
            // 
            this.gridQuocGia.AllowUserToAddRows = false;
            this.gridQuocGia.AllowUserToDeleteRows = false;
            this.gridQuocGia.AllowUserToResizeColumns = false;
            this.gridQuocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridQuocGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ma1,
            this.name,
            this.isAct,
            this.Orderid,
            this.xoa});
            this.gridQuocGia.ContextMenuStrip = this.contextMenuStrip1;
            this.gridQuocGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridQuocGia.Location = new System.Drawing.Point(0, 0);
            this.gridQuocGia.MultiSelect = false;
            this.gridQuocGia.Name = "gridQuocGia";
            this.gridQuocGia.RowHeadersVisible = false;
            this.gridQuocGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridQuocGia.Size = new System.Drawing.Size(387, 368);
            this.gridQuocGia.TabIndex = 0;
            this.gridQuocGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridQuocGia_CellClick);
            this.gridQuocGia.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridQuocGia_CellValueChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.làmTươiToolStripMenuItem,
            this.thêmMớiToolStripMenuItem,
            this.lấyDữLiệuTừDataLoadToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(226, 70);
            // 
            // làmTươiToolStripMenuItem
            // 
            this.làmTươiToolStripMenuItem.Name = "làmTươiToolStripMenuItem";
            this.làmTươiToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.làmTươiToolStripMenuItem.Text = "Làm Tươi";
            this.làmTươiToolStripMenuItem.Click += new System.EventHandler(this.làmTươiToolStripMenuItem_Click);
            // 
            // thêmMớiToolStripMenuItem
            // 
            this.thêmMớiToolStripMenuItem.Name = "thêmMớiToolStripMenuItem";
            this.thêmMớiToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.thêmMớiToolStripMenuItem.Text = "Thêm Mới";
            this.thêmMớiToolStripMenuItem.Click += new System.EventHandler(this.thêmMớiToolStripMenuItem_Click);
            // 
            // lấyDữLiệuTừDataLoadToolStripMenuItem
            // 
            this.lấyDữLiệuTừDataLoadToolStripMenuItem.Name = "lấyDữLiệuTừDataLoadToolStripMenuItem";
            this.lấyDữLiệuTừDataLoadToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.lấyDữLiệuTừDataLoadToolStripMenuItem.Text = "Lấy Dữ Liệu Từ Data Đã Load";
            this.lấyDữLiệuTừDataLoadToolStripMenuItem.Click += new System.EventHandler(this.lấyDữLiệuTừDataLoadToolStripMenuItem_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // ma1
            // 
            this.ma1.DataPropertyName = "ma";
            this.ma1.HeaderText = "Mã";
            this.ma1.Name = "ma1";
            this.ma1.Width = 80;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Tên Quốc Gia";
            this.name.Name = "name";
            this.name.Width = 180;
            // 
            // isAct
            // 
            this.isAct.DataPropertyName = "isAct";
            this.isAct.HeaderText = "Act";
            this.isAct.Name = "isAct";
            this.isAct.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isAct.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.isAct.Width = 30;
            // 
            // Orderid
            // 
            this.Orderid.DataPropertyName = "Orderid";
            this.Orderid.HeaderText = "VTrí";
            this.Orderid.Name = "Orderid";
            this.Orderid.Width = 50;
            // 
            // xoa
            // 
            this.xoa.HeaderText = "Xoá";
            this.xoa.Name = "xoa";
            this.xoa.Width = 40;
            // 
            // txtSeachQuocGia
            // 
            this.txtSeachQuocGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSeachQuocGia.Location = new System.Drawing.Point(0, 0);
            this.txtSeachQuocGia.Name = "txtSeachQuocGia";
            this.txtSeachQuocGia.Size = new System.Drawing.Size(387, 20);
            this.txtSeachQuocGia.TabIndex = 1;
            this.txtSeachQuocGia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSeachQuocGia_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSeachQuocGia);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 23);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.gridQuocGia);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(387, 368);
            this.panel2.TabIndex = 3;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.linkLabel1.Location = new System.Drawing.Point(180, 353);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(204, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Tham Khảo Mã Quốc Gia Trên Facebook";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FrmCauHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 423);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCauHinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cấu Hình";
            this.Load += new System.EventHandler(this.FrmCauHinh_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimkiemFB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGoiLai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimerOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsysLimitCallApi)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridQuocGia)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox chkBaiViet;
        private System.Windows.Forms.CheckBox chkFriend;
        private System.Windows.Forms.CheckBox chkUID;
        private System.Windows.Forms.NumericUpDown txtsysLimitCallApi;
        private System.Windows.Forms.NumericUpDown txtTimerOut;
        private System.Windows.Forms.CheckBox chkForword;
        private System.Windows.Forms.NumericUpDown txtGoiLai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView gridQuocGia;
        private System.Windows.Forms.NumericUpDown txtTimkiemFB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem làmTươiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lấyDữLiệuTừDataLoadToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isAct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Orderid;
        private System.Windows.Forms.DataGridViewImageColumn xoa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSeachQuocGia;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
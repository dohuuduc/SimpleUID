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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkForword = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.chkBaiViet = new System.Windows.Forms.CheckBox();
            this.chkFriend = new System.Windows.Forms.CheckBox();
            this.chkUID = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtsysTimeSleep = new System.Windows.Forms.NumericUpDown();
            this.txtsysLimitCallApi = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numGoiLai = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gridQuocGia = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAct = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtsysTimeSleep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsysLimitCallApi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGoiLai)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridQuocGia)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(462, 271);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(454, 245);
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
            this.groupBox2.Location = new System.Drawing.Point(8, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(438, 90);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Clear Data";
            // 
            // chkForword
            // 
            this.chkForword.AutoSize = true;
            this.chkForword.Location = new System.Drawing.Point(283, 42);
            this.chkForword.Name = "chkForword";
            this.chkForword.Size = new System.Drawing.Size(70, 17);
            this.chkForword.TabIndex = 5;
            this.chkForword.Text = "Theo Dõi";
            this.chkForword.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(357, 61);
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
            this.chkBaiViet.Location = new System.Drawing.Point(283, 19);
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
            this.groupBox1.Controls.Add(this.numGoiLai);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtsysTimeSleep);
            this.groupBox1.Controls.Add(this.txtsysLimitCallApi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 138);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Facebook";
            // 
            // txtsysTimeSleep
            // 
            this.txtsysTimeSleep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtsysTimeSleep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtsysTimeSleep.Location = new System.Drawing.Point(312, 42);
            this.txtsysTimeSleep.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.txtsysTimeSleep.Name = "txtsysTimeSleep";
            this.txtsysTimeSleep.Size = new System.Drawing.Size(120, 22);
            this.txtsysTimeSleep.TabIndex = 6;
            this.txtsysTimeSleep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtsysTimeSleep.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // txtsysLimitCallApi
            // 
            this.txtsysLimitCallApi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtsysLimitCallApi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtsysLimitCallApi.Location = new System.Drawing.Point(312, 15);
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
            this.txtsysLimitCallApi.Size = new System.Drawing.Size(120, 22);
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
            this.button1.Location = new System.Drawing.Point(357, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Gọi Lại:";
            // 
            // numGoiLai
            // 
            this.numGoiLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.numGoiLai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.numGoiLai.Location = new System.Drawing.Point(312, 75);
            this.numGoiLai.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numGoiLai.Name = "numGoiLai";
            this.numGoiLai.Size = new System.Drawing.Size(120, 22);
            this.numGoiLai.TabIndex = 8;
            this.numGoiLai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numGoiLai.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gridQuocGia);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(454, 245);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quốc Gia";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gridQuocGia
            // 
            this.gridQuocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridQuocGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ma1,
            this.name,
            this.isAct,
            this.Order});
            this.gridQuocGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridQuocGia.Location = new System.Drawing.Point(3, 3);
            this.gridQuocGia.MultiSelect = false;
            this.gridQuocGia.Name = "gridQuocGia";
            this.gridQuocGia.RowHeadersVisible = false;
            this.gridQuocGia.Size = new System.Drawing.Size(448, 239);
            this.gridQuocGia.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // ma1
            // 
            this.ma1.DataPropertyName = "ma";
            this.ma1.HeaderText = "Mã";
            this.ma1.Name = "ma1";
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Tên Quốc Gia";
            this.name.Name = "name";
            this.name.Width = 200;
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
            // Order
            // 
            this.Order.DataPropertyName = "Order";
            this.Order.HeaderText = "VTrí";
            this.Order.Name = "Order";
            this.Order.Width = 50;
            // 
            // FrmCauHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 271);
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
            ((System.ComponentModel.ISupportInitialize)(this.txtsysTimeSleep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsysLimitCallApi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGoiLai)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridQuocGia)).EndInit();
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
        private System.Windows.Forms.NumericUpDown txtsysTimeSleep;
        private System.Windows.Forms.CheckBox chkForword;
        private System.Windows.Forms.NumericUpDown numGoiLai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView gridQuocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isAct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order;
    }
}
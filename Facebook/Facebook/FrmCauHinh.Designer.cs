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
            this.button2 = new System.Windows.Forms.Button();
            this.chkBaiViet = new System.Windows.Forms.CheckBox();
            this.chkFriend = new System.Windows.Forms.CheckBox();
            this.chkUID = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtsysLimitCallApi = new System.Windows.Forms.NumericUpDown();
            this.txtsysTimeSleep = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtsysLimitCallApi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsysTimeSleep)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(426, 268);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(418, 242);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Account Facebook";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.chkBaiViet);
            this.groupBox2.Controls.Add(this.chkFriend);
            this.groupBox2.Controls.Add(this.chkUID);
            this.groupBox2.Location = new System.Drawing.Point(8, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(392, 106);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Clear Data";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(297, 73);
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
            this.chkBaiViet.Location = new System.Drawing.Point(29, 79);
            this.chkBaiViet.Name = "chkBaiViet";
            this.chkBaiViet.Size = new System.Drawing.Size(149, 17);
            this.chkBaiViet.TabIndex = 2;
            this.chkBaiViet.Text = "Bài Viết - Like - Comments";
            this.chkBaiViet.UseVisualStyleBackColor = true;
            // 
            // chkFriend
            // 
            this.chkFriend.AutoSize = true;
            this.chkFriend.Location = new System.Drawing.Point(29, 56);
            this.chkFriend.Name = "chkFriend";
            this.chkFriend.Size = new System.Drawing.Size(126, 17);
            this.chkFriend.TabIndex = 1;
            this.chkFriend.Text = "Bạn bè / Thành Viên";
            this.chkFriend.UseVisualStyleBackColor = true;
            // 
            // chkUID
            // 
            this.chkUID.AutoSize = true;
            this.chkUID.Location = new System.Drawing.Point(29, 33);
            this.chkUID.Name = "chkUID";
            this.chkUID.Size = new System.Drawing.Size(143, 17);
            this.chkUID.TabIndex = 0;
            this.chkUID.Text = "Thông tin Uid, Gui, Page";
            this.chkUID.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtsysTimeSleep);
            this.groupBox1.Controls.Add(this.txtsysLimitCallApi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 115);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Facebook";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Thời Gian Giửa 2 Lần Gọi";
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
            this.button1.Location = new System.Drawing.Point(297, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtsysLimitCallApi
            // 
            this.txtsysLimitCallApi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtsysLimitCallApi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtsysLimitCallApi.Location = new System.Drawing.Point(252, 20);
            this.txtsysLimitCallApi.Maximum = new decimal(new int[] {
            15000,
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
            // txtsysTimeSleep
            // 
            this.txtsysTimeSleep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtsysTimeSleep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtsysTimeSleep.Location = new System.Drawing.Point(252, 47);
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
            // FrmCauHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 268);
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
            ((System.ComponentModel.ISupportInitialize)(this.txtsysLimitCallApi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsysTimeSleep)).EndInit();
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
    }
}
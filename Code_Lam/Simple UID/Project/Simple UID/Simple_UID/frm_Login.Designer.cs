namespace Simple_UID
{
	// Token: 0x02000002 RID: 2
	public partial class frm_Login : global::System.Windows.Forms.Form
	{
		// Token: 0x06000008 RID: 8 RVA: 0x000020B6 File Offset: 0x000002B6
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002508 File Offset: 0x00000708
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Simple_UID.frm_Login));
			this.formSkin1 = new global::FlatUI.FormSkin();
			this.linkLabel2 = new global::System.Windows.Forms.LinkLabel();
			this.linkLabel1 = new global::System.Windows.Forms.LinkLabel();
			this.flatStickyButton2 = new global::FlatUI.FlatStickyButton();
			this.flatStickyButton1 = new global::FlatUI.FlatStickyButton();
			this.notify = new global::FlatUI.FlatAlertBox();
			this.btn_login = new global::FlatUI.FlatStickyButton();
			this.flatLabel1 = new global::FlatUI.FlatLabel();
			this.txt_email = new global::FlatUI.FlatTextBox();
			this.formSkin1.SuspendLayout();
			base.SuspendLayout();
			this.formSkin1.BackColor = global::System.Drawing.Color.White;
			this.formSkin1.BaseColor = global::System.Drawing.Color.FromArgb(60, 70, 73);
			this.formSkin1.BorderColor = global::System.Drawing.Color.FromArgb(53, 58, 60);
			this.formSkin1.Controls.Add(this.linkLabel2);
			this.formSkin1.Controls.Add(this.linkLabel1);
			this.formSkin1.Controls.Add(this.flatStickyButton2);
			this.formSkin1.Controls.Add(this.flatStickyButton1);
			this.formSkin1.Controls.Add(this.notify);
			this.formSkin1.Controls.Add(this.btn_login);
			this.formSkin1.Controls.Add(this.flatLabel1);
			this.formSkin1.Controls.Add(this.txt_email);
			this.formSkin1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.formSkin1.FlatColor = global::System.Drawing.SystemColors.MenuHighlight;
			this.formSkin1.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.formSkin1.HeaderColor = global::System.Drawing.Color.FromArgb(0, 132, 255);
			this.formSkin1.HeaderMaximize = false;
			this.formSkin1.Location = new global::System.Drawing.Point(0, 0);
			this.formSkin1.Name = "formSkin1";
			this.formSkin1.Size = new global::System.Drawing.Size(335, 245);
			this.formSkin1.TabIndex = 0;
			this.formSkin1.Text = "Đăng nhập tài khoản";
			this.linkLabel2.AutoSize = true;
			this.linkLabel2.BackColor = global::System.Drawing.Color.Transparent;
			this.linkLabel2.LinkColor = global::System.Drawing.Color.GreenYellow;
			this.linkLabel2.Location = new global::System.Drawing.Point(14, 179);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new global::System.Drawing.Size(148, 21);
			this.linkLabel2.TabIndex = 22;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "Hướng dẫn sử dụng";
			this.linkLabel2.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.BackColor = global::System.Drawing.Color.Transparent;
			this.linkLabel1.LinkColor = global::System.Drawing.Color.GreenYellow;
			this.linkLabel1.Location = new global::System.Drawing.Point(204, 178);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new global::System.Drawing.Size(125, 21);
			this.linkLabel1.TabIndex = 20;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Lấy access token";
			this.linkLabel1.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			this.flatStickyButton2.BackColor = global::System.Drawing.Color.Transparent;
			this.flatStickyButton2.BaseColor = global::System.Drawing.SystemColors.MenuHighlight;
			this.flatStickyButton2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.flatStickyButton2.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.flatStickyButton2.Location = new global::System.Drawing.Point(94, 140);
			this.flatStickyButton2.Name = "flatStickyButton2";
			this.flatStickyButton2.Rounded = false;
			this.flatStickyButton2.Size = new global::System.Drawing.Size(68, 31);
			this.flatStickyButton2.TabIndex = 19;
			this.flatStickyButton2.Text = "Thoát";
			this.flatStickyButton2.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.flatStickyButton2.Click += new global::System.EventHandler(this.flatStickyButton2_Click);
			this.flatStickyButton1.BackColor = global::System.Drawing.Color.Transparent;
			this.flatStickyButton1.BaseColor = global::System.Drawing.SystemColors.MenuHighlight;
			this.flatStickyButton1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.flatStickyButton1.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.flatStickyButton1.Location = new global::System.Drawing.Point(290, 12);
			this.flatStickyButton1.Name = "flatStickyButton1";
			this.flatStickyButton1.Rounded = false;
			this.flatStickyButton1.Size = new global::System.Drawing.Size(22, 18);
			this.flatStickyButton1.TabIndex = 18;
			this.flatStickyButton1.Text = "x";
			this.flatStickyButton1.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.flatStickyButton1.Click += new global::System.EventHandler(this.flatStickyButton1_Click);
			this.notify.BackColor = global::System.Drawing.Color.FromArgb(60, 70, 73);
			this.notify.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.notify.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.notify.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.notify.kind = global::FlatUI.FlatAlertBox._Kind.Success;
			this.notify.Location = new global::System.Drawing.Point(0, 203);
			this.notify.Name = "notify";
			this.notify.Size = new global::System.Drawing.Size(335, 42);
			this.notify.TabIndex = 17;
			this.notify.Text = "ATP TOKEN dòng 2";
			this.notify.Visible = false;
			this.btn_login.BackColor = global::System.Drawing.Color.Transparent;
			this.btn_login.BaseColor = global::System.Drawing.SystemColors.MenuHighlight;
			this.btn_login.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btn_login.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.btn_login.Location = new global::System.Drawing.Point(168, 140);
			this.btn_login.Name = "btn_login";
			this.btn_login.Rounded = false;
			this.btn_login.Size = new global::System.Drawing.Size(155, 31);
			this.btn_login.TabIndex = 16;
			this.btn_login.Text = "Đăng nhập";
			this.btn_login.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.btn_login.Click += new global::System.EventHandler(this.btn_login_Click);
			this.flatLabel1.AutoSize = true;
			this.flatLabel1.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel1.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel1.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel1.Location = new global::System.Drawing.Point(12, 79);
			this.flatLabel1.Name = "flatLabel1";
			this.flatLabel1.Size = new global::System.Drawing.Size(63, 13);
			this.flatLabel1.TabIndex = 13;
			this.flatLabel1.Text = "ATP TOKEN:";
			this.txt_email.BackColor = global::System.Drawing.Color.Transparent;
			this.txt_email.FocusOnHover = false;
			this.txt_email.Location = new global::System.Drawing.Point(94, 60);
			this.txt_email.MaxLength = 32767;
			this.txt_email.Multiline = true;
			this.txt_email.Name = "txt_email";
			this.txt_email.ReadOnly = false;
			this.txt_email.Size = new global::System.Drawing.Size(229, 74);
			this.txt_email.TabIndex = 12;
			this.txt_email.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.txt_email.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.txt_email.UseSystemPasswordChar = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(335, 245);
			base.Controls.Add(this.formSkin1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frm_Login";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frm_Login";
			base.TransparencyKey = global::System.Drawing.Color.Fuchsia;
			this.formSkin1.ResumeLayout(false);
			this.formSkin1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000002 RID: 2
		private global::System.ComponentModel.IContainer icontainer_0 = null;

		// Token: 0x04000003 RID: 3
		private global::FlatUI.FormSkin formSkin1;

		// Token: 0x04000004 RID: 4
		private global::FlatUI.FlatStickyButton btn_login;

		// Token: 0x04000005 RID: 5
		private global::FlatUI.FlatLabel flatLabel1;

		// Token: 0x04000006 RID: 6
		private global::FlatUI.FlatTextBox txt_email;

		// Token: 0x04000007 RID: 7
		private global::FlatUI.FlatAlertBox notify;

		// Token: 0x04000008 RID: 8
		private global::FlatUI.FlatStickyButton flatStickyButton1;

		// Token: 0x04000009 RID: 9
		private global::FlatUI.FlatStickyButton flatStickyButton2;

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Forms.LinkLabel linkLabel1;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.LinkLabel linkLabel2;
	}
}

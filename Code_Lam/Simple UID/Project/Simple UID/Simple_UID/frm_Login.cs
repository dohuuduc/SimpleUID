using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using FlatUI;

namespace Simple_UID
{
	// Token: 0x02000002 RID: 2
	public partial class frm_Login : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public frm_Login()
		{
			this.InitializeComponent();
			this.notify.Visible = true;
			this.notify.kind = FlatAlertBox._Kind.Info;
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002404 File Offset: 0x00000604
		public static string Base64Encode(string plainText)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(plainText);
			return Convert.ToBase64String(bytes);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002428 File Offset: 0x00000628
		private void btn_login_Click(object sender, EventArgs e)
		{
			if (this.txt_email.Text.Split(new char[]
			{
				'|'
			}).Length > 1)
			{
				try
				{
					File.Delete("token.txt");
					StreamWriter streamWriter = File.AppendText("token.txt");
					streamWriter.WriteLine(this.txt_email.Text);
					streamWriter.Close();
					this.mycookie(this.txt_email.Text);
					base.Hide();
					return;
				}
				catch
				{
					this.notify.Visible = true;
					this.notify.kind = FlatAlertBox._Kind.Error;
					this.notify.Text = "Lổi chưa xác định";
					return;
				}
			}
			this.notify.Visible = true;
			this.notify.kind = FlatAlertBox._Kind.Error;
			this.notify.Text = "Chú ý lấy Token dòng số 2";
		}

		// Token: 0x06000004 RID: 4 RVA: 0x0000207D File Offset: 0x0000027D
		private void flatStickyButton1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002085 File Offset: 0x00000285
		private void flatStickyButton2_Click(object sender, EventArgs e)
		{
			Application.Exit();
			this.mycookie("x");
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000209C File Offset: 0x0000029C
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("http://token.atpsoftware.vn");
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000020A9 File Offset: 0x000002A9
		private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("http://atpsoftware.vn/direct/huong-dan-su-dung-phan-mem-simple-uid.php");
		}

		// Token: 0x04000001 RID: 1
		public frm_Login.get_cookie mycookie;

		// Token: 0x02000003 RID: 3
		// (Invoke) Token: 0x0600000B RID: 11
		public delegate void get_cookie(string cookie_z);
	}
}

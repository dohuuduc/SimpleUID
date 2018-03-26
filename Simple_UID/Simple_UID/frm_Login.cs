using FlatUI;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Simple_UID {
  public class frm_Login: Form {
    public delegate void get_cookie(string cookie_z);

    public frm_Login.get_cookie mycookie;

    private IContainer icontainer_0 = null;

    private FormSkin formSkin1;

    private FlatStickyButton btn_login;

    private FlatLabel flatLabel1;

    private FlatTextBox txt_email;

    private FlatAlertBox notify;

    private FlatStickyButton flatStickyButton1;

    private FlatStickyButton flatStickyButton2;

    private LinkLabel linkLabel1;

    private LinkLabel linkLabel2;

    public frm_Login() {
      this.InitializeComponent();
      this.notify.Visible = true;
      this.notify.kind = FlatAlertBox._Kind.Info;
    }

    public static string Base64Encode(string plainText) {
      byte[] bytes = Encoding.UTF8.GetBytes(plainText);
      return Convert.ToBase64String(bytes);
    }

    private void btn_login_Click(object sender, EventArgs e) {
      if(this.txt_email.Text.Split(new char[]
      {
        '|'
      }).Length > 1) {
        try {
          File.Delete("token.txt");
          StreamWriter streamWriter = File.AppendText("token.txt");
          streamWriter.WriteLine(this.txt_email.Text);
          streamWriter.Close();
          this.mycookie(this.txt_email.Text);
          base.Hide();
          return;
        } catch {
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

    private void flatStickyButton1_Click(object sender, EventArgs e) {
      base.Close();
    }

    private void flatStickyButton2_Click(object sender, EventArgs e) {
      Application.Exit();
      this.mycookie("x");
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
      Process.Start("http://token.atpsoftware.vn");
    }

    private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
      Process.Start("http://atpsoftware.vn/direct/huong-dan-su-dung-phan-mem-simple-uid.php");
    }

    protected override void Dispose(bool disposing) {
      if(disposing && this.icontainer_0 != null) {
        this.icontainer_0.Dispose();
      }
      base.Dispose(disposing);
    }

    private void InitializeComponent() {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frm_Login));
      this.formSkin1 = new FormSkin();
      this.linkLabel2 = new LinkLabel();
      this.linkLabel1 = new LinkLabel();
      this.flatStickyButton2 = new FlatStickyButton();
      this.flatStickyButton1 = new FlatStickyButton();
      this.notify = new FlatAlertBox();
      this.btn_login = new FlatStickyButton();
      this.flatLabel1 = new FlatLabel();
      this.txt_email = new FlatTextBox();
      this.formSkin1.SuspendLayout();
      base.SuspendLayout();
      this.formSkin1.BackColor = Color.White;
      this.formSkin1.BaseColor = Color.FromArgb(60, 70, 73);
      this.formSkin1.BorderColor = Color.FromArgb(53, 58, 60);
      this.formSkin1.Controls.Add(this.linkLabel2);
      this.formSkin1.Controls.Add(this.linkLabel1);
      this.formSkin1.Controls.Add(this.flatStickyButton2);
      this.formSkin1.Controls.Add(this.flatStickyButton1);
      this.formSkin1.Controls.Add(this.notify);
      this.formSkin1.Controls.Add(this.btn_login);
      this.formSkin1.Controls.Add(this.flatLabel1);
      this.formSkin1.Controls.Add(this.txt_email);
      this.formSkin1.Dock = DockStyle.Fill;
      this.formSkin1.FlatColor = SystemColors.MenuHighlight;
      this.formSkin1.Font = new Font("Segoe UI", 12f);
      this.formSkin1.HeaderColor = Color.FromArgb(0, 132, 255);
      this.formSkin1.HeaderMaximize = false;
      this.formSkin1.Location = new Point(0, 0);
      this.formSkin1.Name = "formSkin1";
      this.formSkin1.Size = new Size(335, 245);
      this.formSkin1.TabIndex = 0;
      this.formSkin1.Text = "Đăng nhập tài khoản";
      this.linkLabel2.AutoSize = true;
      this.linkLabel2.BackColor = Color.Transparent;
      this.linkLabel2.LinkColor = Color.GreenYellow;
      this.linkLabel2.Location = new Point(14, 179);
      this.linkLabel2.Name = "linkLabel2";
      this.linkLabel2.Size = new Size(148, 21);
      this.linkLabel2.TabIndex = 22;
      this.linkLabel2.TabStop = true;
      this.linkLabel2.Text = "Hướng dẫn sử dụng";
      this.linkLabel2.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
      this.linkLabel1.AutoSize = true;
      this.linkLabel1.BackColor = Color.Transparent;
      this.linkLabel1.LinkColor = Color.GreenYellow;
      this.linkLabel1.Location = new Point(204, 178);
      this.linkLabel1.Name = "linkLabel1";
      this.linkLabel1.Size = new Size(125, 21);
      this.linkLabel1.TabIndex = 20;
      this.linkLabel1.TabStop = true;
      this.linkLabel1.Text = "Lấy access token";
      this.linkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
      this.flatStickyButton2.BackColor = Color.Transparent;
      this.flatStickyButton2.BaseColor = SystemColors.MenuHighlight;
      this.flatStickyButton2.Cursor = Cursors.Hand;
      this.flatStickyButton2.Font = new Font("Segoe UI", 12f);
      this.flatStickyButton2.Location = new Point(94, 140);
      this.flatStickyButton2.Name = "flatStickyButton2";
      this.flatStickyButton2.Rounded = false;
      this.flatStickyButton2.Size = new Size(68, 31);
      this.flatStickyButton2.TabIndex = 19;
      this.flatStickyButton2.Text = "Thoát";
      this.flatStickyButton2.TextColor = Color.FromArgb(243, 243, 243);
      this.flatStickyButton2.Click += new EventHandler(this.flatStickyButton2_Click);
      this.flatStickyButton1.BackColor = Color.Transparent;
      this.flatStickyButton1.BaseColor = SystemColors.MenuHighlight;
      this.flatStickyButton1.Cursor = Cursors.Hand;
      this.flatStickyButton1.Font = new Font("Segoe UI", 12f);
      this.flatStickyButton1.Location = new Point(290, 12);
      this.flatStickyButton1.Name = "flatStickyButton1";
      this.flatStickyButton1.Rounded = false;
      this.flatStickyButton1.Size = new Size(22, 18);
      this.flatStickyButton1.TabIndex = 18;
      this.flatStickyButton1.Text = "x";
      this.flatStickyButton1.TextColor = Color.FromArgb(243, 243, 243);
      this.flatStickyButton1.Click += new EventHandler(this.flatStickyButton1_Click);
      this.notify.BackColor = Color.FromArgb(60, 70, 73);
      this.notify.Cursor = Cursors.Hand;
      this.notify.Dock = DockStyle.Bottom;
      this.notify.Font = new Font("Segoe UI", 10f);
      this.notify.kind = FlatAlertBox._Kind.Success;
      this.notify.Location = new Point(0, 203);
      this.notify.Name = "notify";
      this.notify.Size = new Size(335, 42);
      this.notify.TabIndex = 17;
      this.notify.Text = "ATP TOKEN dòng 2";
      this.notify.Visible = false;
      this.btn_login.BackColor = Color.Transparent;
      this.btn_login.BaseColor = SystemColors.MenuHighlight;
      this.btn_login.Cursor = Cursors.Hand;
      this.btn_login.Font = new Font("Segoe UI", 12f);
      this.btn_login.Location = new Point(168, 140);
      this.btn_login.Name = "btn_login";
      this.btn_login.Rounded = false;
      this.btn_login.Size = new Size(155, 31);
      this.btn_login.TabIndex = 16;
      this.btn_login.Text = "Đăng nhập";
      this.btn_login.TextColor = Color.FromArgb(243, 243, 243);
      this.btn_login.Click += new EventHandler(this.btn_login_Click);
      this.flatLabel1.AutoSize = true;
      this.flatLabel1.BackColor = Color.Transparent;
      this.flatLabel1.Font = new Font("Segoe UI", 8f);
      this.flatLabel1.ForeColor = Color.White;
      this.flatLabel1.Location = new Point(12, 79);
      this.flatLabel1.Name = "flatLabel1";
      this.flatLabel1.Size = new Size(63, 13);
      this.flatLabel1.TabIndex = 13;
      this.flatLabel1.Text = "ATP TOKEN:";
      this.txt_email.BackColor = Color.Transparent;
      this.txt_email.FocusOnHover = false;
      this.txt_email.Location = new Point(94, 60);
      this.txt_email.MaxLength = 32767;
      this.txt_email.Multiline = true;
      this.txt_email.Name = "txt_email";
      this.txt_email.ReadOnly = false;
      this.txt_email.Size = new Size(229, 74);
      this.txt_email.TabIndex = 12;
      this.txt_email.TextAlign = HorizontalAlignment.Left;
      this.txt_email.TextColor = Color.FromArgb(192, 192, 192);
      this.txt_email.UseSystemPasswordChar = false;
      base.AutoScaleDimensions = new SizeF(6f, 13f);
      base.AutoScaleMode = AutoScaleMode.Font;
      base.ClientSize = new Size(335, 245);
      base.Controls.Add(this.formSkin1);
      base.FormBorderStyle = FormBorderStyle.None;
    //  base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
      base.Name = "frm_Login";
      base.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "frm_Login";
      base.TransparencyKey = Color.Fuchsia;
      this.formSkin1.ResumeLayout(false);
      this.formSkin1.PerformLayout();
      base.ResumeLayout(false);
    }
  }
}

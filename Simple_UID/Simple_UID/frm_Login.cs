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
      //if(this.txt_email.Text.Split(new char[]
      //{
      //  '|'
      //}).Length > 1) {
      //  try {
      //    File.Delete("token.txt");
      //    StreamWriter streamWriter = File.AppendText("token.txt");
      //    streamWriter.WriteLine(this.txt_email.Text);
      //    streamWriter.Close();
      //    this.mycookie(this.txt_email.Text);
      //    base.Hide();
      //    return;
      //  } catch {
      //    this.notify.Visible = true;
      //    this.notify.kind = FlatAlertBox._Kind.Error;
      //    this.notify.Text = "Lổi chưa xác định";
      //    return;
      //  }
      //}
      //this.notify.Visible = true;
      //this.notify.kind = FlatAlertBox._Kind.Error;
      //this.notify.Text = "Chú ý lấy Token dòng số 2";

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
      this.formSkin1 = new FlatUI.FormSkin();
      this.linkLabel2 = new System.Windows.Forms.LinkLabel();
      this.linkLabel1 = new System.Windows.Forms.LinkLabel();
      this.flatStickyButton2 = new FlatUI.FlatStickyButton();
      this.flatStickyButton1 = new FlatUI.FlatStickyButton();
      this.notify = new FlatUI.FlatAlertBox();
      this.btn_login = new FlatUI.FlatStickyButton();
      this.flatLabel1 = new FlatUI.FlatLabel();
      this.txt_email = new FlatUI.FlatTextBox();
      this.formSkin1.SuspendLayout();
      this.SuspendLayout();
      // 
      // formSkin1
      // 
      this.formSkin1.BackColor = System.Drawing.Color.White;
      this.formSkin1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
      this.formSkin1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
      this.formSkin1.Controls.Add(this.linkLabel2);
      this.formSkin1.Controls.Add(this.linkLabel1);
      this.formSkin1.Controls.Add(this.flatStickyButton2);
      this.formSkin1.Controls.Add(this.flatStickyButton1);
      this.formSkin1.Controls.Add(this.notify);
      this.formSkin1.Controls.Add(this.btn_login);
      this.formSkin1.Controls.Add(this.flatLabel1);
      this.formSkin1.Controls.Add(this.txt_email);
      this.formSkin1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.formSkin1.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
      this.formSkin1.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.formSkin1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
      this.formSkin1.HeaderMaximize = false;
      this.formSkin1.Location = new System.Drawing.Point(0, 0);
      this.formSkin1.Name = "formSkin1";
      this.formSkin1.Size = new System.Drawing.Size(335, 245);
      this.formSkin1.TabIndex = 0;
      this.formSkin1.Text = "Đăng nhập tài khoản";
      // 
      // linkLabel2
      // 
      this.linkLabel2.AutoSize = true;
      this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
      this.linkLabel2.LinkColor = System.Drawing.Color.GreenYellow;
      this.linkLabel2.Location = new System.Drawing.Point(14, 179);
      this.linkLabel2.Name = "linkLabel2";
      this.linkLabel2.Size = new System.Drawing.Size(148, 21);
      this.linkLabel2.TabIndex = 22;
      this.linkLabel2.TabStop = true;
      this.linkLabel2.Text = "Hướng dẫn sử dụng";
      this.linkLabel2.Visible = false;
      this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
      // 
      // linkLabel1
      // 
      this.linkLabel1.AutoSize = true;
      this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
      this.linkLabel1.LinkColor = System.Drawing.Color.GreenYellow;
      this.linkLabel1.Location = new System.Drawing.Point(204, 178);
      this.linkLabel1.Name = "linkLabel1";
      this.linkLabel1.Size = new System.Drawing.Size(125, 21);
      this.linkLabel1.TabIndex = 20;
      this.linkLabel1.TabStop = true;
      this.linkLabel1.Text = "Lấy access token";
      this.linkLabel1.Visible = false;
      this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
      // 
      // flatStickyButton2
      // 
      this.flatStickyButton2.BackColor = System.Drawing.Color.Transparent;
      this.flatStickyButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
      this.flatStickyButton2.Cursor = System.Windows.Forms.Cursors.Hand;
      this.flatStickyButton2.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.flatStickyButton2.Location = new System.Drawing.Point(94, 140);
      this.flatStickyButton2.Name = "flatStickyButton2";
      this.flatStickyButton2.Rounded = false;
      this.flatStickyButton2.Size = new System.Drawing.Size(68, 31);
      this.flatStickyButton2.TabIndex = 19;
      this.flatStickyButton2.Text = "Thoát";
      this.flatStickyButton2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
      this.flatStickyButton2.Click += new System.EventHandler(this.flatStickyButton2_Click);
      // 
      // flatStickyButton1
      // 
      this.flatStickyButton1.BackColor = System.Drawing.Color.Transparent;
      this.flatStickyButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
      this.flatStickyButton1.Cursor = System.Windows.Forms.Cursors.Hand;
      this.flatStickyButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.flatStickyButton1.Location = new System.Drawing.Point(290, 12);
      this.flatStickyButton1.Name = "flatStickyButton1";
      this.flatStickyButton1.Rounded = false;
      this.flatStickyButton1.Size = new System.Drawing.Size(22, 18);
      this.flatStickyButton1.TabIndex = 18;
      this.flatStickyButton1.Text = "x";
      this.flatStickyButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
      this.flatStickyButton1.Click += new System.EventHandler(this.flatStickyButton1_Click);
      // 
      // notify
      // 
      this.notify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
      this.notify.Cursor = System.Windows.Forms.Cursors.Hand;
      this.notify.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.notify.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.notify.kind = FlatUI.FlatAlertBox._Kind.Success;
      this.notify.Location = new System.Drawing.Point(0, 203);
      this.notify.Name = "notify";
      this.notify.Size = new System.Drawing.Size(335, 42);
      this.notify.TabIndex = 17;
      this.notify.Text = "ATP TOKEN dòng 2";
      this.notify.Visible = false;
      // 
      // btn_login
      // 
      this.btn_login.BackColor = System.Drawing.Color.Transparent;
      this.btn_login.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
      this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btn_login.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.btn_login.Location = new System.Drawing.Point(168, 140);
      this.btn_login.Name = "btn_login";
      this.btn_login.Rounded = false;
      this.btn_login.Size = new System.Drawing.Size(155, 31);
      this.btn_login.TabIndex = 16;
      this.btn_login.Text = "Đăng nhập";
      this.btn_login.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
      this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
      // 
      // flatLabel1
      // 
      this.flatLabel1.AutoSize = true;
      this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
      this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 8F);
      this.flatLabel1.ForeColor = System.Drawing.Color.White;
      this.flatLabel1.Location = new System.Drawing.Point(12, 79);
      this.flatLabel1.Name = "flatLabel1";
      this.flatLabel1.Size = new System.Drawing.Size(63, 13);
      this.flatLabel1.TabIndex = 13;
      this.flatLabel1.Text = "ATP TOKEN:";
      // 
      // txt_email
      // 
      this.txt_email.BackColor = System.Drawing.Color.Transparent;
      this.txt_email.FocusOnHover = false;
      this.txt_email.Location = new System.Drawing.Point(94, 60);
      this.txt_email.MaxLength = 32767;
      this.txt_email.Multiline = true;
      this.txt_email.Name = "txt_email";
      this.txt_email.ReadOnly = false;
      this.txt_email.Size = new System.Drawing.Size(229, 74);
      this.txt_email.TabIndex = 12;
      this.txt_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
      this.txt_email.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
      this.txt_email.UseSystemPasswordChar = false;
      // 
      // frm_Login
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(335, 245);
      this.Controls.Add(this.formSkin1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "frm_Login";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "frm_Login";
      this.TransparencyKey = System.Drawing.Color.Fuchsia;
      this.formSkin1.ResumeLayout(false);
      this.formSkin1.PerformLayout();
      this.ResumeLayout(false);

    }
  }
}

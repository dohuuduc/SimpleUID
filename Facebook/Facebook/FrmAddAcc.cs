using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facebook
{
    public partial class FrmAddAcc : Form
    {
        public FrmAddAcc()
        {
            
            InitializeComponent();
           
        }
        private string flag;
        private string username;
        private string password;
        private string token;
        public string Flage {
            get { return flag; }
            set { flag = value; }
        }
        public string UserName {
            get { return username; }
            set { username = value; }
        }
        public string PassWord {
            get { return password; }
            set { password = value; }
        }
        public string Token {
            get { return token; }
            set { token = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") {
                MessageBox.Show("Vui lòng nhập username", "Thông Báo");
                return;
            }
            if (textBox2.Text == "") {
                MessageBox.Show("Vui lòng nhập password", "Thông Báo");
                return;
            }
            FbAccount fb= new FbAccount();
            string token = "", account="", password="";
            if (radioButton1.Checked)
            {
                (new Waiting(() => fb = Facebook.Login(textBox1.Text, textBox2.Text))).ShowDialog();
                token = fb.token;
                account = fb.account;
                password = fb.password;
            }
            else {
                token = txtToken.Text;
                account = textBox1.Text;
                password = textBox2.Text;
            }

            List<FbAccount> fbAccounts =  SQLDatabase.LoadFbAccount(string.Format("select * from FbAccount where account='{0}'", textBox1.Text));
            if (fbAccounts.Count == 0) {
                SQLDatabase.AddFbAccount(new FbAccount() { account = account, password = password, token = token, IsAct = true });
            }
            else {
                SQLDatabase.UpdateFbAccount(new FbAccount() { account = account,password = password, token = token, IsAct = true });
            }
            /*goi hàm kiễm tra lại trạng thái token có vươc gioi han soa chưa?*/
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FrmAddAcc_Load(object sender, EventArgs e)
        {
            if (Flage.ToLower() == "them")
            {
                this.Text = "Thêm Account Facebook";
               
            }
            else
            {
                this.textBox1.Text = username;
                this.textBox2.Text = password;
                this.txtToken.Text = token;
                this.Text = "Cập Nhật Account Facebook";
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(null, null);
                e.Handled = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           txtToken.Enabled = !radioButton1.Checked;
        }
    }
}

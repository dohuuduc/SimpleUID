﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facebook
{
    public partial class FrmAddUID : Form
    {
        public FrmAddUID()
        {
            InitializeComponent();
        }
        private Guid chaId;
        public Guid ChaId {
            get { return chaId; }
            set { chaId = value; }
        }
        private NhomUID _nhom;
        private void FrmAddUID_Load(object sender, EventArgs e)
        {
            _nhom = new NhomUID();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") return;
            NhomUID temp = null; ;
            if (!textBox1.Text.Contains("https://www.facebook.com"))
            {
                if (Utilities.CheckNumberEnterKey(textBox1.Text)){
                    MessageBox.Show("Vui lòng kiễm tra UID", "Thông Báo");
                    return;
                }
                (new Waiting(() => temp = Facebook.ConvertUidToNhom(textBox1.Text))).ShowDialog();
            }
            else {
                (new Waiting(() => temp = Facebook.ConvertUrdToNhom(textBox1.Text))).ShowDialog();
            }
            if (temp == null)
            {
                MessageBox.Show("Không lấy được UID", "Thông Báo");
                return;
            }
            List<NhomUID> NhomUIDs = SQLDatabase.LoadNhomUID(string.Format("select * from NhomUID where uid='{0}'",temp.UID));
            SQLDatabase.AddNhomUID(temp);
            
            /*goi hàm kiễm tra lại trạng thái token có vươc gioi han soa chưa?*/
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(null,null);
            }
        }
    }
}

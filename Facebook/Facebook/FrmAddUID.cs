using System;
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
        private DmGroupUID _nhom;
        private void FrmAddUID_Load(object sender, EventArgs e)
        {
            _nhom = new DmGroupUID();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") return;
            DmGroupUID temp;
            if (!textBox1.Text.Contains("https://www.facebook.com"))
            {
                if (Utilities.CheckNumberEnterKey(textBox1.Text)){
                    MessageBox.Show("Vui lòng kiễm tra UID", "Thông Báo");
                    return;
                }
                temp = Facebook.ConvertUidToNhom(textBox1.Text);
            }
            else {
                temp = Facebook.ConvertUrdToNhom(textBox1.Text);
            }
            if (temp == null)
            {
                MessageBox.Show("Không lấy được UID", "Thông Báo");
                return;
            }
            List<DmGroupUID> dmGroupUIDs = SQLDatabase.LoadDmGroupUID(string.Format("select * from DmGroupUID where uid='{0}'",temp.UID));
            SQLDatabase.AddDmGroupUID(temp);
            
            /*goi hàm kiễm tra lại trạng thái token có vươc gioi han soa chưa?*/
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        
    }
}

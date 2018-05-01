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
    public partial class FrmCauHinh : Form
    {
        public FrmCauHinh()
        {
            InitializeComponent();
        }
        CauHinh cauHinh;
        private void FrmCauHinh_Load(object sender, EventArgs e)
        {
            cauHinh = SQLDatabase.LoadCauHinh("select * from cauhinh");
            txtsysLimitCallApi.Text = cauHinh.sysLimitCallApi.ToString();
            txtsysTimeSleep.Text = cauHinh.sysTimeSleep.ToString();
            txtsysLimitBaiViet.Text = cauHinh.sysLimitBaiViet.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (SQLDatabase.UpdateCauHinh(cauHinh))
                {
                    MessageBox.Show("Lưu Cấu Hình Thành Công", "Thông Báo");
                }
                else {
                    MessageBox.Show("Lưu Cấu Hình Thất Bại", "Thông Báo");
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "button1_Click");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show(string.Format("Bạn có muốn xoá các loại dữ liệu đã chọn không?"), "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    bool temp = false;
                    new Waiting(() => temp = Delete(), "Vui Lòng Chờ").ShowDialog();
                    if (temp)
                        MessageBox.Show("Đã xoá thành công", "Thông Báo");
                    else
                        MessageBox.Show("Đã xoá thất bại", "Thông Báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "button2_Click");
            }
        }
        public bool Delete() {
            try
            {
                if (chkFriend.Checked)
                {
                    SQLDatabase.ExcNonQuery("delete from [dbo].[FbFriend]");
                }
                if (chkUID.Checked)
                {
                    SQLDatabase.ExcNonQuery("delete from [dbo].[FbUID]");
                    SQLDatabase.ExcNonQuery("delete from [dbo].[FbPage]");
                    SQLDatabase.ExcNonQuery("delete from [dbo].[FbGUI]");
                }
                if (chkBaiViet.Checked)
                {
                    SQLDatabase.ExcNonQuery("delete from [dbo].[FbFeed]");
                    SQLDatabase.ExcNonQuery("delete from [dbo].[FbLike]");
                    SQLDatabase.ExcNonQuery("delete from [dbo].[FbComments]");

                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}

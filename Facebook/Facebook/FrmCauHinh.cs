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
    }
}

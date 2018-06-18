using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            try
            {
                cauHinh = SQLDatabase.LoadCauHinh("select * from cauhinh");
                txtsysLimitCallApi.Value = ConvertType.ToDecimal(cauHinh.LimitCallApi);
                txtTimerOut.Value = ConvertType.ToDecimal(cauHinh.TimerOut);
                txtGoiLai.Value = ConvertType.ToDecimal(cauHinh.GoiLai);
                txtTimkiemFB.Value = ConvertType.ToDecimal(cauHinh.LimitTimKiemFb);
                BindNhom(txtSeachQuocGia.Text);
                BindColumn();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "FrmCauHinh_Load");
            }
           

        }
       
        private void BindNhom(string strkh)
        {
            try
            {
                string str = strkh=="" ?    string.Format("select * from DM_QuocGia  order by OrderId") : 
                                            string.Format("select * from DM_QuocGia where ma LIKE '%{0}%' or name like '%{0}%' order by OrderId",strkh);
                DataTable tb = null;
                (new Waiting(() => tb = SQLDatabase.ExcDataTable(str))).ShowDialog();
                gridQuocGia.DataSource = tb;
                tabPage2.Text = string.Format("Quốc Gia: {0}",tb.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "BindGrid");
            }
        }
        private void BindColumn()
        {
            try
            {
                string str = string.Format("select ROW_NUMBER() OVER(ORDER BY OrderId ASC) AS stt,* from dm_column  order by OrderId");
                DataTable tb = null;
                (new Waiting(() => tb = SQLDatabase.ExcDataTable(str))).ShowDialog();
                gridViewColumn.DataSource = tb;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "BindGrid");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cauHinh.LimitTimKiemFb =ConvertType.ToInt(txtTimkiemFB.Value);
                cauHinh.GoiLai = ConvertType.ToInt(txtGoiLai.Value);
                cauHinh.TimerOut = ConvertType.ToInt(txtTimerOut.Value);
                cauHinh.LimitCallApi = ConvertType.ToInt(txtsysLimitCallApi.Value);

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
                if (chkForword.Checked) {
                    SQLDatabase.ExcNonQuery("delete from [dbo].[FbFollow]");
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void gridQuocGia_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    Guid ID = (Guid)gridQuocGia.Rows[e.RowIndex].Cells["id"].Value;
                    string ma = gridQuocGia.Rows[e.RowIndex].Cells["ma1"].Value.ToString();
                    string name = gridQuocGia.Rows[e.RowIndex].Cells["name"].Value.ToString();
                    bool isActive = (Boolean)gridQuocGia.Rows[e.RowIndex].Cells["isAct"].Value;
                    int vitri = ConvertType.ToInt(gridQuocGia.Rows[e.RowIndex].Cells["Orderid"].Value);

                    new Waiting((MethodInvoker)delegate
                    {
                        List<DM_QuocGia> model = SQLDatabase.LoadDM_QuocGia(string.Format("select * from DM_QuocGia where id='{0}'", ID));
                        if (model.Count > 0)
                        {
                            DM_QuocGia temp = model.FirstOrDefault();
                            temp.ma = ma;
                            temp.name = name;
                            temp.isAct = isActive;
                            temp.OrderId = ConvertType.ToInt(vitri);
                            SQLDatabase.UpdateDM_QuocGia(temp);
                        }
                    }, "Vui Lòng Chờ").ShowDialog();

                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to save the record. There might be a blank cell. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void gridQuocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                Guid bid = (Guid)gridQuocGia.Rows[e.RowIndex].Cells["id"].Value;
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xoá dòng này không?", "Thông Báo", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    if (SQLDatabase.DelDM_QuocGia(new DM_QuocGia() { id = bid }))
                        gridQuocGia.Rows.RemoveAt(e.RowIndex);
                }

            }
        }

        private void lấyDữLiệuTừDataLoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable model = SQLDatabase.ExcDataTable(";WITH cte AS(select locale from FbFollow group by locale union select locale from FbFriend group by locale ) SELECT* FROM cte WHERE locale not in(select ma from DM_QuocGia) order by locale");
                foreach (DataRow item in model.Rows)
                    SQLDatabase.AddDM_QuocGia(new DM_QuocGia() { isAct= true, ma= item[0].ToString(), OrderId= ConvertType.ToInt(SQLDatabase.ExcDataTable("select max(OrderId) from DM_QuocGia").Rows[0][0]) + 1 });
                BindNhom(txtSeachQuocGia.Text);
                MessageBox.Show("Hoàn thành lấy dữ liệu từ database", "Thông Báo");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "lấyDữLiệuTừDataLoadToolStripMenuItem_Click");
            }
        }

        private void làmTươiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BindNhom(txtSeachQuocGia.Text);
        }

        private void thêmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SQLDatabase.AddDM_QuocGia(new DM_QuocGia() { ma = "", name = "", isAct = true,
                                                        OrderId = ConvertType.ToInt(SQLDatabase.ExcDataTable("select max(OrderId) from DM_QuocGia").Rows[0][0]) + 1 });
            BindNhom(txtSeachQuocGia.Text);
        }

        private void txtSeachQuocGia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BindNhom(txtSeachQuocGia.Text);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://developers.facebook.com/docs/accountkit/countrycodes?locale=vi_VN");
        }

        private void gridViewColumn_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    int ID =ConvertType.ToInt(gridViewColumn.Rows[e.RowIndex].Cells["idCol"].Value);
                    string keys = gridViewColumn.Rows[e.RowIndex].Cells["KeysCol"].Value.ToString();
                    string name = gridViewColumn.Rows[e.RowIndex].Cells["namecol"].Value.ToString();
                    bool isActive = (Boolean)gridViewColumn.Rows[e.RowIndex].Cells["isActCol"].Value;
                    int vitri = ConvertType.ToInt(gridViewColumn.Rows[e.RowIndex].Cells["OrderidCol"].Value);

                    new Waiting((MethodInvoker)delegate
                    {
                        List<dm_column> model = SQLDatabase.Loaddm_column(string.Format("select * from dm_column where id='{0}'", ID));
                        if (model.Count > 0)
                        {
                            dm_column temp = model.FirstOrDefault();
                            temp.Keys = keys;
                            temp.name = name;
                            temp.act = isActive;
                            temp.orderid = ConvertType.ToInt(vitri);
                            SQLDatabase.Updatedm_column(temp);
                        }
                    }, "Vui Lòng Chờ").ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to save the record. There might be a blank cell. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
        
        private void làmTươiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BindColumn();
        }

    private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
      try {
        string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string fileName = "Mau_Friend";
        bool temp = false;
        new Waiting(() => temp = xuatfilemain(filePath + "\\" + fileName, "FbFriend"), "Vui Lòng Chờ").ShowDialog();
        MessageBox.Show("Đã xuất thành công file.", "Thông Báo");
      }
      catch (Exception ex) {

        MessageBox.Show(ex.Message, "linkLabel1_LinkClicked");
      }
    }

    private bool xuatfilemain(string filePath, string keys) {
      try {
        DataTable table = new DataTable();
        foreach (var item in getlistColumnByName(keys).Split(','))
          table.Columns.Add(item, typeof(string));

        ExcelAdapter excel = new ExcelAdapter(filePath);
        excel.CreateAndWrite(table, "Phone", 1);
        return true;
      }
      catch (Exception ex) {
        return false;
      }

    }
    private string getlistColumnByName(string keys) {
      try {
        string dscolumn = "";
        List<dm_column> collection = SQLDatabase.Loaddm_column("select * from dm_column where act=1 order by orderid ");
        int i = 3;
        foreach (dm_column item in collection) {
          dscolumn += string.Format("{0} ({1}),", item.name == "" ? item.Keys : item.name, i);
          i++;
        }
        dscolumn = dscolumn.Substring(0, dscolumn.Length - 1);

        //if (keys.Contains("FbFriend")) {
        //  dscolumn = "uid_quet \n(1),FriendUid\n(2)," + dscolumn;
        //}
        //else if (keys.Contains("FbFollow")) {
        //  dscolumn = "uid_quet \n(1),FollowUid\n(2)," + dscolumn;
        //}
        //else if (keys.Contains("FbLike")) {
        //  dscolumn = "UID_Chinh \n(1), feedid\n(2),  from_id [uid] \n(3), from_name \n(4),   from_xac_nhan\n(5), message\n(6), story, type\n(7)," +
        //             "status_type \n(8), description\n(9), List_Like\n(10), List_with_tags\n(11),  story_tags\n(12), created_time\n(13),    update_time\n(14), is_hidden\n(15),   is_expired\n(16), likes\n(17),   comments\n(18)";

        //}
        //else if (keys.Contains("FbComments")) {
        //  dscolumn = "UID_Chinh\n(1),	feedid\n(2),	message_baiviet\n(3),	description\n(4),	is_hidden\n(5),	is_expired\n(6),	likes\n(7),	comments\n(8),	from_id_commend\n(9),	from_name_commend\n(10),	from_xac_nhan_commend\n(11),	message_comment\n(12),	commend_create\n(13)";
        //}
        return dscolumn;
      }
      catch (Exception ex) {
        MessageBox.Show(ex.Message, "getlistColumn");
        return "";
      }
    }
    private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
      try {
        string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string fileName = "Mau_Follow";
        bool temp = false;
        new Waiting(() => temp = xuatfilemain(filePath + "\\" + fileName, "FbFollow"), "Vui Lòng Chờ").ShowDialog();
        MessageBox.Show("Đã xuất thành công file.", "Thông Báo");
      }
      catch (Exception ex) {

        MessageBox.Show(ex.Message, "linkLabel1_LinkClicked");
      }
    }

    private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
      try {
        string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string fileName = "Mau_Like";
        bool temp = false;
        new Waiting(() => temp = xuatfilemain(filePath + "\\" + fileName, "FbLike"), "Vui Lòng Chờ").ShowDialog();
        MessageBox.Show("Đã xuất thành công file.", "Thông Báo");
      }
      catch (Exception ex) {
        MessageBox.Show(ex.Message, "linkLabel3_LinkClicked");
      }
    }

    private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
      try {
        string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string fileName = "Mau_Comments";
        bool temp = false;
        new Waiting(() => temp = xuatfilemain(filePath + "\\" + fileName, "FbComments"), "Vui Lòng Chờ").ShowDialog();
        MessageBox.Show("Đã xuất thành công file.", "Thông Báo");
      }
      catch (Exception ex) {
        MessageBox.Show(ex.Message, "linkLabel3_LinkClicked");
      }
    }
  }
}

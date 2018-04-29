using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facebook
{
    public partial class FrmMain123 : Form
    {
        public FrmMain123()
        {
            InitializeComponent();
        }
        private CauHinh _cauHinh;
        private DataGridViewRow _mySelectedRowAcc;
        private DataGridViewSelectedRowCollection _mySelectedRowUid;
        private Thread theardProcess;
        private void BindAccount()
        {
            try
            {
                string strdk = chkShowAllAccount.Checked ? "[spLoadToken]" : "[spLoadToken] 1";
                DataTable tb = SQLDatabase.ExcDataTable(strdk);
                GridAccount.DataSource = tb;
                foreach (DataGridViewRow row in GridAccount.Rows)
                {
                    DataGridViewImageCell cell = row.Cells[0] as DataGridViewImageCell;
                    if (row.Cells["token"].Value.ToString() == "")
                    {
                        cell.Value = (System.Drawing.Image)Properties.Resources.Error;

                    }
                    else
                    {
                        cell.Value = (System.Drawing.Image)Properties.Resources.ok;
                    }
                }
                int n = ConvertType.ToInt(tb.Rows.Count);
                if (n > 0)
                {
                    chkShowAllAccount.Text = string.Format("(All) - Danh Sách Account {0}", n);
                    /*forcus den dong dau*/
                    //GridAccount.ClearSelection();
                    //int nRowIndex = 0;

                    //GridAccount.Rows[nRowIndex].Selected = true;
                   // GridAccount.Rows[nRowIndex].Cells[0].Selected = true;
                    BindAccount(GridAccount.Rows[0]);


                }
                else
                {
                    chkShowAllAccount.Text = string.Format("(All) - Danh Sách Account");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "BindUID");
                throw;
            }
        }
        private void BindAccount(DataGridViewRow row)
        {
            try
            {
                txtToken.Text = row.Cells["token"].Value.ToString();
                lblQataLimit.Text = string.Format("{0:#,#.}",ConvertType.ToInt(row.Cells["gioihan"].Value));
                lblQuataDaDung.Text = string.Format("{0:#,#.}", ConvertType.ToInt(row.Cells["dagoi"].Value));
                lblQuataConLai.Text = string.Format("{0:#,#.}", ConvertType.ToInt(row.Cells["conlai"].Value));

                grQuataAcc.Text = string.Format("Quata Acc: {0}/{1}/{2}", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "BindAccount");
            }
        }

            private void BindUID() {
            try
            {
               

                 DataTable tb = SQLDatabase.ExcDataTable(" select id,ROW_NUMBER() OVER (ORDER BY OrderID) AS stt,REPLACE(Name,'| Facebook','') as Name, UID, URD,REPLACE(URD,'www.facebook.com','...') as URD2 ,IsLoai, CASE " +
                                                        " WHEN IsLoai = 0 THEN N'Người Dùng'"+
                                                        " WHEN IsLoai = 1 THEN N'Trang'"+
                                                        " WHEN IsLoai = 1 THEN N'Nhóm'"+
                                                        "    ELSE NULL "+
                                                        " END AS 'LoaiFb'" +
                                                        " from NhomUID where [ParentId] in (select id from NhomUID where name = 'admin')");
                gridUID.DataSource = tb;
                foreach (DataGridViewRow row in gridUID.Rows)
                {
                    DataGridViewImageCell cell = row.Cells[0] as DataGridViewImageCell;
                    if (row.Cells["UID"].Value.ToString() == "")
                    {
                        cell.Value = (System.Drawing.Image)Properties.Resources.Error;
                    }
                    else {
                        cell.Value = (System.Drawing.Image)Properties.Resources.ok;
                    }
                }
                grDsUID.Text = string.Format("Danh Sách UID: {0}",tb.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "BindUID");
                throw;
            }
        }
       

        private void FrmMain_Load(object sender, EventArgs e)
        {
            _cauHinh = SQLDatabase.LoadCauHinh("select * from cauhinh");
            BindAccount();
            BindUID();

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAddUID frm = new FrmAddUID();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                BindUID();
            }
        }

        private void thêmAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddAcc frm = new FrmAddAcc();
            frm.Flage = "them";
            if (frm.ShowDialog() == DialogResult.OK)
            {
                BindAccount();
            }
        }

        private void sửaAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void GridAccount_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                string account = GridAccount.Rows[e.RowIndex].Cells["account"].Value.ToString();
                string password = GridAccount.Rows[e.RowIndex].Cells["password"].Value.ToString();
                FrmAddAcc frm = new FrmAddAcc();
                frm.Flage = "sua";
                frm.UserName = account;
                frm.PassWord = password;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    BindAccount();
                }
            }
        }

        

        private void GridAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                BindAccount(GridAccount.Rows[e.RowIndex]);
            }
        }

        private void resetTokenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_mySelectedRowAcc != null) {
                string account = _mySelectedRowAcc.Cells["account"].Value.ToString();
                string password = _mySelectedRowAcc.Cells["password"].Value.ToString();

                FbAccount fb = new FbAccount();
                (new Waiting(() => fb = Facebook.Login(account, password))).ShowDialog();
                if (fb.token != "")
                {
                    fb.IsAct = true;
                    SQLDatabase.UpdateFbAccount(fb);
                    BindAccount();
                }
            }
        }

        private void xoáAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (_mySelectedRowAcc == null) return;
                DialogResult result = MessageBox.Show(string.Format("Bạn có muốn xoá account '{0}' ?",_mySelectedRowAcc.Cells["account"].Value), "Warning",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    SQLDatabase.DelFbAccount(new FbAccount() { account = _mySelectedRowAcc.Cells["account"].Value.ToString() });
                    MessageBox.Show("Xoá thành công", "Thông Báo");
                    _mySelectedRowAcc = null;
                    BindAccount();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "xoáAccountToolStripMenuItem_Click");
            }
        }

        private void gridUID_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridUID_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
             _mySelectedRowUid = gridUID.SelectedRows;
        }
        private void GridAccount_MouseDown(object sender, MouseEventArgs e)
        {
            _mySelectedRowAcc = GridAccount.SelectedRows[0];
        }

        private void zToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void resetUIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (_mySelectedRowUid == null) return;
                string id = _mySelectedRowUid[0].Cells["id"].Value.ToString();
                string uid = _mySelectedRowUid[0].Cells["UID"].Value.ToString();
                string urd = _mySelectedRowUid[0].Cells["URD"].Value.ToString();
                if (uid == "" && urd == "") return;
                DialogResult result = MessageBox.Show(string.Format("Bạn có muốn reset lại UID đang chọn không?"), "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes){
                    NhomUID model = SQLDatabase.LoadNhomUID(string.Format("select * from NhomUID where id='{0}'",id)).FirstOrDefault();
                    NhomUID mo= new NhomUID();
                    if (uid != ""){
                        (new Waiting(() => mo = Facebook.ConvertUidToNhom(uid))).ShowDialog();
                    }
                    else {
                        (new Waiting(() => mo = Facebook.ConvertUrdToNhom(uid))).ShowDialog();
                    }
                    model.UID = mo.UID == "" ? model.UID : mo.UID;
                    model.URD = mo.URD == "" ? model.URD : mo.URD;
                    model.IsLoai = mo.IsLoai;
                    SQLDatabase.UpNhomUID(model);
                    BindUID();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông Báo");
            }
        }

        private void làmTươiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BindUID();
        }

        private void làmTươiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BindAccount();
        }

        private void asToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            string path = ofd.ShowDialog() == DialogResult.OK ? ofd.FileName : "";

            bool temp = false;
            (new Waiting(() => temp = importfile(path))).ShowDialog();
            if (temp)
                BindUID();
            else
                MessageBox.Show("Import file thất bại", "Lỗi");
        }

        private bool importfile(string path)
        {
            try
            {
                ExcelAdapter excel = new ExcelAdapter(path);
                DataTable tb = excel.ReadFromFile("SELECT * FROM [Sheet1$]");
                Guid NhomChaId = SQLDatabase.LoadNhomUID(string.Format("select * from NhomUID where name='admin'")).FirstOrDefault().id;
                foreach (DataRow item in tb.Rows)
                {
                    if (item["UID_URD"].ToString() != "")
                    {
                        NhomUID model;
                        if (item["UID_URD"].ToString().Contains("https://www.facebook.com/"))
                        {
                            model = Facebook.ConvertUrdToNhom(item["UID_URD"].ToString());
                        }
                        else {
                            model = Facebook.ConvertUidToNhom(item["UID_URD"].ToString());
                        }
                        model.ParentId = NhomChaId;
                        model.IsActi = true;
                        model.Note = item["Note"].ToString();
                        SQLDatabase.AddNhomUID(model);
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string fileName = "MauFacebook" + DateTime.Now.ToString("dd_MM_yyyy");
                bool temp = false;
                new Waiting(() => temp = xuatfilemain(filePath + "\\" + fileName), "Vui Lòng Chờ").ShowDialog();
                if(temp)
                    MessageBox.Show("Đã xuất thành công file.\n File:" + fileName, "Thông Báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "linkLabel1_LinkClicked");
            }
        }

        private bool xuatfilemain(string filePath)
        {
            try
            {
                DataTable table = new DataTable();
                table.Columns.Add("STT", typeof(int));
                table.Columns.Add("UID_URD", typeof(string));
                table.Columns.Add("Note", typeof(string));

                ExcelAdapter excel = new ExcelAdapter(filePath);
                excel.CreateAndWrite(table, "Sheet1", 1);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        private void xoáUIDThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (_mySelectedRowUid == null) return;
                DialogResult result = MessageBox.Show(string.Format("Bạn có muốn xoá UID '{0}' ?", _mySelectedRowUid[0].Cells["UID"].Value), "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    SQLDatabase.ExcNonQuery(string.Format("[spDelNhomUIDAndInfo] '{0}'", _mySelectedRowUid[0].Cells["id"].Value));
                    MessageBox.Show(string.Format("Xoá thành công uid '{0}'", _mySelectedRowUid[0].Cells["UID"].Value), "Thông Báo");
                    _mySelectedRowUid = null;
                    BindUID();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "zToolStripMenuItem_Click");
            }
        }

        private void lọcTrùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                NhomUID model = SQLDatabase.LoadNhomUID("Select * from NhomUID where name='admin'").FirstOrDefault();
                DialogResult result = MessageBox.Show(string.Format("Bạn có muốn lộc trùng!!! "), "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    
                    bool temp=false;
                    new Waiting(() => temp = SQLDatabase.ExcNonQuery(string.Format("[spLocTrungNhomUID] '{0}'", model.id)), "Vui Lòng Chờ").ShowDialog();
                    if (temp)
                        MessageBox.Show("Đã lộc trùng danh sách UID", "Thông Báo");
                    BindUID();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "zToolStripMenuItem_Click");
            }
        }

        private void xoáUIDLỗiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                NhomUID model = SQLDatabase.LoadNhomUID("Select * from NhomUID where name='admin'").FirstOrDefault();
                DialogResult result = MessageBox.Show(string.Format("Bạn có muốn xoá UID đang bị lổi (Thiếu UID)!!! "), "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {

                    bool temp = false;
                    new Waiting(() => temp = SQLDatabase.ExcNonQuery(string.Format("[spDelNhomUIDErr] '{0}'", model.id)), "Vui Lòng Chờ").ShowDialog();
                    if (temp)
                        MessageBox.Show("Đã xoá tất cả UID bị lổi", "Thông Báo");
                    BindUID();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "zToolStripMenuItem_Click");
            }
        }

        private void btnQuet_Click(object sender, EventArgs e)
        {
            ParameterizedThreadStart par;
            ArrayList arr;
            try
            {
                if (_mySelectedRowUid.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn Uid bạn cần quét", "Thông báo");
                    return;
                }
                if (btnQuet.Text == "Start")
                {
                    btnQuet.Text = "Stop";

                    TheardFacebookWriter.hasProcess = true;
                    chkShowAllAccount.Enabled = false;
                    grDsUID.Enabled = false;
                    grDoituongquet.Enabled = false;
                }
                else
                {
                    btnQuet.Text = "Start";
                    TheardFacebookWriter.hasProcess = false;

                    chkShowAllAccount.Enabled = false;
                    grDsUID.Enabled = false;
                    grDoituongquet.Enabled = false;
                }

                /*Cấu hình controll*/
                Control.CheckForIllegalCrossThreadCalls = false;

                par = new ParameterizedThreadStart(ProcessFB);
                theardProcess = new Thread(par);

                arr = new ArrayList();
                arr.Add(lblMessage1);
                arr.Add(lblPhanTram);
                arr.Add(lblQuataDaDung);
                arr.Add(txtToken);
                arr.Add(chkMe);
                arr.Add(chkBanBe);
                arr.Add(chkBaiViet);
                arr.Add(progressBar1);

                theardProcess.IsBackground = true;
                theardProcess.Start(arr);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "button2_Click");
            }
        }

        private void ProcessFB(object arrControl)
        {
            try
            {
                //----- Add control process from

                ArrayList arr1 = (ArrayList)arrControl;
                Label lblMessage1 = (Label)arr1[0];
                Label lblPhanTram = (Label)arr1[1];
                Label lblSluongGoi = (Label)arr1[2];
                TextBox txtToken = (TextBox)arr1[3];
                CheckBox chkMe = (CheckBox)arr1[4];
                CheckBox chkBanBe = (CheckBox)arr1[5];
                CheckBox chkBaiViet = (CheckBox)arr1[6];
                ProgressBar progressBar1 = (ProgressBar)arr1[7];

                List<NhomUID> listQuet = new List<NhomUID>();

                foreach (DataGridViewRow row in gridUID.SelectedRows)
                {
                    DataRow myRow = (row.DataBoundItem as DataRowView).Row;
                    NhomUID model = new NhomUID();
                    model.id = Guid.Parse(myRow["id"].ToString());
                    model.UID = myRow["UID"].ToString();
                    model.IsLoai = ConvertType.ToInt(myRow["IsLoai"]);
                    listQuet.Add(model);
                }

                /*===============================================================*/
                
                while (listQuet.Count > 0)
                {
                    if (!TheardFacebookWriter.hasProcess) break;
                    progressBar1.Maximum = listQuet.Count;
                    progressBar1.Value = 0;
                    lblPhanTram.Text = "0% Hoàn thành...";
                    lblPhanTram.Update();
                    /*neu dang stop thi khong dc phep xoa*/
                    if (TheardFacebookWriter.hasProcess)
                    {
                        /**************************Code here********************/
                        string uid = gridUID.SelectedRows[_mySelectedRowUid[0].Index].Cells["UID"].Value.ToString();
                        //string uid = gridUID.SelectedRows[_mySelectedRowUid[0].Index].Cells["UID"].Value.ToString();
                        var model = listQuet.Single(r => r.UID == uid);
                        TheardFacebookWriter.getwebBrowser(model, arrControl);
                        /******************************************************/
                        progressBar1.PerformStep();
                        progressBar1.Update();
                        /*KẾT THÚC 1 UID*/
                        if (gridUID.SelectedRows.Count > 0){
                            gridUID.SelectedRows[_mySelectedRowUid[0].Index].Selected = false;
                            gridUID.Update();

                            var row = listQuet.Single(r => r.UID == uid);
                            listQuet.Remove(row);
                        }

                       
                    }
                }
                //_mySelectedRowUid = null;
               
                /*===================================================================*/
                lblMessage1.Text = TheardFacebookWriter.hasProcess ? "Hoàn thành load số liệu." : "Tạm dừng do người dùng!!!";
                btnQuet.Text = "Start";
                TheardFacebookWriter.hasProcess = false;

                chkShowAllAccount.Enabled = true;
                grDsUID.Enabled = true;
                grDoituongquet.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ProcessTrangVang");
            }
        }

        private void chkShowAllAccount_CheckedChanged(object sender, EventArgs e)
        {
            BindAccount();
        }

        private void cấuHìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmCauHinh frm = new FrmCauHinh();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

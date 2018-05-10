﻿using System;
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
        private Dictionary<string, int> _dauso;
        private List<regexs> _regexs;
        private string _strdatabasename;

        private void BindAccount()
        {
            try
            {
                string strdk = chkShowAllAccount.Checked ? "[spLoadToken]" : "[spLoadToken] 1";
                DataTable tbTong = SQLDatabase.ExcDataTable("select count(*) from FbAccount");
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
                chkShowAllAccount.Text = string.Format("(All) - Danh Sách Account {0}/{1}", n, ConvertType.ToInt(tbTong.Rows[0][0]));
                if(n!=0) BindAccount(GridAccount.Rows[0]);
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

                grQuataAcc.Text = string.Format("Quata Acc: -> {0:00}/{1:00}/{2}", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);

                //string.Format("{0:00} - {1:00}", 5, 6);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "BindAccount");
            }
        }
        private void BindUID() {
            try
            {
                 DataTable tb = SQLDatabase.ExcDataTable(" select id,ROW_NUMBER() OVER (ORDER BY CreateDate desc) AS stt,REPLACE(Name,'| Facebook','') as Name, UID, URD,REPLACE(URD,'www.facebook.com','...') as URD2 ,IsLoai, CASE " +
                                                        " WHEN IsLoai = 0 THEN N'Người Dùng'"+
                                                        " WHEN IsLoai = 1 THEN N'Trang'"+
                                                        " WHEN IsLoai = 2 THEN N'Nhóm'"+
                                                        "    ELSE NULL "+
                                                        " END AS 'LoaiFb'" +
                                                        " from NhomUID where [ParentId] in (select id from NhomUID where name = 'admin') order by CreateDate desc");
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
                _mySelectedRowUid = gridUID.SelectedRows;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "BindUID");
                throw;
            }
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            //SQLDatabase.ExcNonQuery("select* from FbLog where CONVERT(date, GETDATE()) > CONVERT(date, create_date)");

            _cauHinh = SQLDatabase.LoadCauHinh("select * from cauhinh");
            BindAccount();
            BindUID();

            _regexs = SQLDatabase.LoadRegexs("select * from Regexs");
            DataTable tb_dausp = SQLDatabase.ExcDataTable(" select distinct dauso dauso,lenght  " +
                                                          " from dau_so where dauso is not null and dauso <> '' " +
                                                          " union all " +
                                                          " select distinct right(dauso, len(dauso) - 1)dauso, lenght -1" +
                                                          " from dau_so where dauso is not null and dauso <> ''");

            Dictionary<string, int> dauso = new Dictionary<string, int>();
            foreach (DataRow item in tb_dausp.Rows)
            {
                dauso.Add(item["dauso"].ToString(), ConvertType.ToInt(item["lenght"]));
            }
            _dauso = dauso;
            _strdatabasename = SQLDatabase.ExcDataTable(string.Format("SELECT DB_NAME(0)AS [DatabaseName]; ")).Rows[0]["DatabaseName"].ToString();

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
            try
            {
                _mySelectedRowUid = gridUID.SelectedRows;
            }
            catch (Exception)
            {

                throw;
            }
            
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
                DialogResult result = MessageBox.Show(string.Format("Bạn có muốn xoá tất cả thông tin và Uid đang chọn không? '{0}' ?", _mySelectedRowUid[0].Cells["name1"].Value), "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    SQLDatabase.ExcNonQuery(string.Format("[spDelDmGroupUIDAndInfo] '{0}'", _mySelectedRowUid[0].Cells["id"].Value));
                    MessageBox.Show(string.Format("Xoá thành công uid '{0}'", _mySelectedRowUid[0].Cells["name1"].Value), "Thông Báo");
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
                    new Waiting(() => temp = SQLDatabase.ExcNonQuery(string.Format("[spDelDmGroupUIDErr] '{0}'", model.id)), "Vui Lòng Chờ").ShowDialog();
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
                    MessageBox.Show("Vui lòng chọn Uid bạn cần quét: \n 1- Chính Uid \n 2- Bạn bè, thành viên \n 3- Bài viết, like, comments", "Thông báo");
                    return;
                }
                if (!chkMe.Checked && !chkBaiViet.Checked && !chkBanBe.Checked) {
                    MessageBox.Show("Vui lòng chọn quét thông tin nào? \n Bạn bè, Thành viên, bài viết.", "Thông báo");
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
                arr.Add(lblMessage2);
                arr.Add(lblQuataDaDung);
                arr.Add(txtToken);
                arr.Add(chkMe);
                arr.Add(chkBanBe);
                arr.Add(chkBaiViet);
                arr.Add(lblQuataDaDung);
                arr.Add(lblQuataConLai);
                

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
                Label lblMessage2 = (Label)arr1[1];
                Label lblSluongGoi = (Label)arr1[2];
                TextBox txtToken = (TextBox)arr1[3];
                CheckBox chkMe = (CheckBox)arr1[4];
                CheckBox chkBanBe = (CheckBox)arr1[5];
                CheckBox chkBaiViet = (CheckBox)arr1[6];
                Label lblQuataDaDung =(Label)arr1[7];
                Label lblQuataConLai = (Label)arr1[8];

                List<NhomUID> listQuet = new List<NhomUID>();

                foreach (DataGridViewRow row in gridUID.SelectedRows)
                {
                    DataRow myRow = (row.DataBoundItem as DataRowView).Row;
                    NhomUID model = new NhomUID();
                    model.id = Guid.Parse(myRow["id"].ToString());
                    model.UID = myRow["UID"].ToString();
                    model.URD = myRow["URD"].ToString();
                    model.IsLoai = ConvertType.ToInt(myRow["IsLoai"]);
                    model.Name = myRow["name"].ToString();
                    listQuet.Add(model);
                }
                lblMessage1.Text = string.Format("Đang xử lý: Số lượng uid sẽ quét: {0}", listQuet.Count());
                /*===============================================================*/
                while (listQuet.Count > 0)
                {
                    if (!TheardFacebookWriter.hasProcess) break;
                    /*neu dang stop thi khong dc phep xoa*/
                    if (TheardFacebookWriter.hasProcess)
                    {
                        /**************************Code here********************/
                        NhomUID model = listQuet.FirstOrDefault();

                        lblMessage1.Text = string.Format("Đang xử lý: {0} -Id: {1}", model.Name , model.UID);
                        lblMessage1.Update();

                        txtFbId.Text = model.UID;
                        txtFbId.Update();

                        txtFbName.Text = model.Name;
                        txtFbName.Update();

                        txtFbLink.Text = model.URD;
                        txtFbLink.Update();

                        txtFbLoai.Text = model.IsLoai == 0 ? "Người dùng" : model.IsLoai == 1 ? "Trang" : "Nhóm";
                        txtFbLoai.Update();

                        Thread.Sleep(1000);

                        TheardFacebookWriter.getwebBrowser(model, arrControl);
                        /******************************************************/
                        /*KẾT THÚC 1 UID*/
                        listQuet.Remove(model);
                    }
                }
               
                /*===================================================================*/
                lblMessage1.Text = TheardFacebookWriter.hasProcess ? "Hoàn thành load số liệu." : "Tạm dừng do người dùng, hoặc do hết Quata!!!";
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

        private void xuấtFileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }
        private string strDanhSachXuat() {
            string strdk = "";
            foreach (DataGridViewRow row in gridUID.SelectedRows)
            {
                strdk += string.Format("'{0}',", row.Cells["UID"].Value.ToString());
                break;
            }
            if (strdk.Length > 0)
            {
                strdk = strdk.Substring(0, strdk.Length - 1);
            }
            return strdk;
        }


       


        private void phoneEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string folderpath = "";
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                DialogResult dr = fbd.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    folderpath = fbd.SelectedPath;
                }

                string filePath = folderpath =="" ? Environment.GetFolderPath(Environment.SpecialFolder.Desktop): folderpath;
                new Waiting((MethodInvoker)delegate {
                    foreach (DataGridViewRow row in gridUID.SelectedRows)
                    {
                        DataRow myRow = (row.DataBoundItem as DataRowView).Row;
                        NhomUID model = new NhomUID();
                        model.UID = myRow["UID"].ToString();
                        model.Name = myRow["name"].ToString();

                        DataTable table = SQLDatabase.ExcDataTable(string.Format("[spXuatFileNhanhPhoneEmail] \"{0}\"", model.UID));
                        if (table != null)
                        {
                            foreach (DataRow item in table.Rows)
                            {
                                List<string> arrPhone = Utilities.getPhoneHTML(item["message"].ToString(), _dauso, _regexs);
                                string listPhone = "";
                                foreach (var dienthoai in arrPhone)
                                    listPhone += dienthoai + ";";
                                item["phone"] = listPhone;

                                List<string> arrEmail = Utilities.getEmail(new List<string>() { item["message"].ToString() });
                                string listemail = "";
                                foreach (var email in arrEmail)
                                    listemail += email + ";";
                                item["email"] = listemail;
                            }

                            string fileName = Utilities.convertToUnSign3(model.Name.Replace(".", "")) + "_email_phone_" + DateTime.Now.ToString("dd_MM_yyyy");
                            ExcelAdapter excel = new ExcelAdapter(filePath + "\\" + fileName);
                            excel.CreateAndWrite(table, "Sheet", 1);
                        }
                    }
                }, "Vui Lòng Chờ").ShowDialog();
                MessageBox.Show("Đã hoàn thành xuất file theo Phone và Email");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "xuấtFileToolStripMenuItem1_Click");
            }
        }

        private void clearThôngTinUidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (_mySelectedRowUid == null) return;
                DialogResult result = MessageBox.Show(string.Format("Bạn có muốn xoá tất cả thông tin từ Uid đang chọn không? '{0}' ?", _mySelectedRowUid[0].Cells["name1"].Value), "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    SQLDatabase.ExcNonQuery(string.Format("[spDelInfo] '{0}'", _mySelectedRowUid[0].Cells["id"].Value));
                    MessageBox.Show(string.Format("Xoá thành công uid '{0}'", _mySelectedRowUid[0].Cells["name1"].Value), "Thông Báo");
                    _mySelectedRowUid = null;
                    BindUID();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "zToolStripMenuItem_Click");
            }
        }

        private void quétToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnQuet_Click(null, null);
        }

        private void uIDVàNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string folderpath = "";
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                DialogResult dr = fbd.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    folderpath = fbd.SelectedPath;
                }

                string filePath = folderpath == "" ? Environment.GetFolderPath(Environment.SpecialFolder.Desktop) : folderpath;
                new Waiting((MethodInvoker)delegate {
                    foreach (DataGridViewRow row in gridUID.SelectedRows)
                    {
                        DataRow myRow = (row.DataBoundItem as DataRowView).Row;
                        NhomUID model = new NhomUID();
                        model.UID = myRow["UID"].ToString();
                        model.Name = myRow["name"].ToString();

                        DataTable table = SQLDatabase.ExcDataTable(string.Format("[spXuatFileNhanhUID] {0}", model.UID));
                        string fileName = Utilities.convertToUnSign3(model.Name.Replace(".","")) + "_uid_name_" + DateTime.Now.ToString("dd_MM_yyyy");
                        ExcelAdapter excel = new ExcelAdapter(filePath + "\\" + fileName);
                        excel.CreateAndWrite(table, "Sheet", 1);
                    }
                }, "Vui Lòng Chờ").ShowDialog();

                MessageBox.Show("Đã hoàn thành xuất file theo UID và Name");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "uIDVàNameToolStripMenuItem_Click");
            }
        }

        private void gridUID_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtFbId.Text = "";
            txtFbName.Text = "";
            txtFbLink.Text = "";
            txtFbLoai.Text = "";
            try
            {
                string uid = gridUID.Rows[e.RowIndex].Cells["uid"].Value.ToString();
                string name = gridUID.Rows[e.RowIndex].Cells["name1"].Value.ToString();
                string URD2 = gridUID.Rows[e.RowIndex].Cells["URD"].Value.ToString();
                string LoaiFb = gridUID.Rows[e.RowIndex].Cells["LoaiFb"].Value.ToString();
                txtFbId.Text = uid;
                txtFbName.Text = name;
                txtFbLink.Text = URD2;
                txtFbLoai.Text = LoaiFb;
            }
            catch (Exception)
            {

                throw;
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean mo = false;
                (new Waiting(() => mo = SQLDatabase.ExcNonQuery(string.Format("[spChuanHoa] '{0}'", 1)))).ShowDialog();
                MessageBox.Show(string.Format("Hoàn tất chuẩn hoá"), "Thông Báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "button2_Click");
            }
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                FrmSearch1 frm = new FrmSearch1();
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

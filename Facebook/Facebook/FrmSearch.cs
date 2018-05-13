using System;
using System.Collections;
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
    public partial class FrmSearch : Form
    {
        public FrmSearch()
        {
            InitializeComponent();
        }

        private ArrayList _arrController;

        private void button1_Click(object sender, EventArgs e)
        {
            string requestUriString = "";
            string strToken = "";
            try
            {
                
                if (txtSearch.Text=="") {
                    MessageBox.Show("Vui Lòng nhập thông tin tìm kiếm", "Thông báo");
                    return;
                }
                strToken = Facebook.Token(_arrController);
                if (strToken == "")
                {
                    MessageBox.Show("Bạn đã hết Quata token để thực thi việc gọi API của Facebook \n Vui lòng nạp Acc mới hay chờ đến ngày hôm sau.", "Thông báo");
                    return;
                };
                string strNoidungtimkiem = Uri.EscapeDataString(txtSearch.Text);

                switch (tabControl1.SelectedIndex)
                {
                    case 0: /*Page*/
                        requestUriString = string.Format(@"https://graph.facebook.com/search?q={0}&type={1}&limit={2}&fields={3}&access_token={4}", strNoidungtimkiem,"page", LimitTopSearch.Value, Facebook.SelectPage(), strToken);
                        new Waiting((MethodInvoker)delegate {
                            ListFbPageSearch model= TheardFacebookWriter.FbSearchByPage(requestUriString, _arrController, strToken, 1);
                            if (model.FbPageSearch.Count() != 0) {
                                BindgridPage(model);
                                return;
                            }
                        }, "Vui Lòng Chờ...").ShowDialog();

                        break;
                    case 1:
                        requestUriString = string.Format(@"https://graph.facebook.com/search?q={0}&type={1}&limit={2}&fields={3}&access_token={4}", strNoidungtimkiem, "user", LimitTopSearch.Value, Facebook.SelectUser(), strToken);
                        new Waiting((MethodInvoker)delegate {
                            ListFbUserSearch model = TheardFacebookWriter.FbSearchByUser(requestUriString, _arrController, strToken, 1);
                            if (model.FbUserSearch.Count() != 0)
                            {
                                BindgridUser(model);
                                //return;
                            }
                        }, "Vui Lòng Chờ...").ShowDialog();
                        break;
                    case 2:/*group*/
                        requestUriString = string.Format(@"https://graph.facebook.com/search?q={0}&limit={1}&fields={2}&type={3}&access_token={4}", strNoidungtimkiem, LimitTopSearch.Value, Facebook.SelectGroup(),"group", strToken);
                        new Waiting((MethodInvoker)delegate {
                            ListFbGroupSearch model = TheardFacebookWriter.FbSearchByGroup(requestUriString, _arrController, strToken, 1);
                            if (model.FbGroupSearch.Count() != 0)
                            {
                                BindgridGroup(model);
                                //return;
                            }
                        }, "Vui Lòng Chờ...").ShowDialog();
                        break;
                }
                MessageBox.Show(string.Format("Đã xử lý"), "Thông Báo");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "button1_Click");
            }
        }

        private void BindgridPage(ListFbPageSearch model)
        {
            try
            {

                var items = (from p in model.FbPageSearch
                             select new
                             {
                                 p.id,
                                 p.name,
                                 p.about,
                                 avata= p.cover==null ? null: ConvertType.GetImageFromUrl(p.cover.source),
                                 p.description,
                                 p.website,
                                 city= p.location ==null ? "": p.location.city,
                                 country = p.location == null ? "" : p.location.country,
                                 street = p.location == null ? "" : p.location.street,
                                 p.mission,
                                 p.link
                             }).ToList();

                var source = new BindingSource();
                source.DataSource = items;
                gridPage.Invoke((Action)delegate
                {
                    gridPage.DataSource = source;
                });

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "BindgridPage");
            }
        }

        private void BindgridUser(ListFbUserSearch model)
        {
            try
            {

                var items = (from p in model.FbUserSearch
                             select new
                             {
                                 p.id,
                                 p.name,
                                 avata = p.cover == null ? null : ConvertType.GetImageFromUrl(p.cover.source),
                                 p.link,
                                 hocvan = p.education == null ? null : string.Format("Trường: {0} \nTừng học tại {1}", p.education.FirstOrDefault().school == null ? "" : p.education.FirstOrDefault().school.name,
                                                                                                                       p.education.FirstOrDefault().concentration ==null ? "-" : p.education.FirstOrDefault().concentration.FirstOrDefault().name ),
                                 location=p.location == null ? null : p.location.name,
                                 work =p.work == null ? null : p.work.FirstOrDefault().employer.name
                             }).ToList();

                var source = new BindingSource();
                source.DataSource = items;
                gridUser.Invoke((Action)delegate
                {
                    gridUser.DataSource = source;
                });
                    

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "BindgridPage");
            }
        }
        private void BindgridGroup(ListFbGroupSearch model)
        {
            try
            {

                var items = (from p in model.FbGroupSearch
                             select new
                             {
                                 p.id,
                                 p.name,
                                 avata = p.cover == null ? null : ConvertType.GetImageFromUrl(p.cover.source),
                                 p.description
                             }).ToList();

                var source = new BindingSource();
                source.DataSource = items;
                
                gridGroup.Invoke((Action)delegate
                {
                    gridGroup.DataSource = source;
                });

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "BindgridPage");
            }
        }

        private void FrmSearch_Load(object sender, EventArgs e)
        {
            _arrController = new ArrayList();
            _arrController.Add(new Label());
            _arrController.Add(new Label());
            _arrController.Add(lblQataLimit);
            _arrController.Add(txtToken);
            _arrController.Add(new CheckBox());
            _arrController.Add(new CheckBox());
            _arrController.Add(new CheckBox());
            _arrController.Add(lblQuataDaDung);
            _arrController.Add(lblQuataConLai);
            Facebook.Token(_arrController);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(null, null);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                /*Page*/
                foreach (DataGridViewRow row in gridPage.Rows)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["checkPage"];
                    if (chk.Value !=null && (Boolean)chk.Value == true) {
                       string id = row.Cells["idPage"].Value.ToString();
                       string link = row.Cells["linkPage"].Value.ToString();
                        string name = row.Cells["namePage"].Value.ToString();
                        List<NhomUID> nhomUIDs = SQLDatabase.LoadNhomUID(string.Format("select * from NhomUID where ParentId in (select id from NhomUID where Name='admin') and UID='{0}'", id));
                        if (nhomUIDs.Count == 0)
                        {
                            NhomUID nhomUIDCha = SQLDatabase.LoadNhomUID("select * from NhomUID where name='admin'").FirstOrDefault();
                            SQLDatabase.AddNhomUID(new NhomUID() { UID= id, Name = name, URD= link, ParentId = nhomUIDCha.id, IsActi = true, IsLoai = 1});
                        }
                    }
                }
                /*User*/
                foreach (DataGridViewRow row in gridUser.Rows)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["checkUser"];
                    if (chk.Value != null && (Boolean)chk.Value == true)
                    {
                        string id = row.Cells["idUser"].Value.ToString();
                        string link = row.Cells["linkUser"].Value.ToString();
                        string name = row.Cells["nameUser"].Value.ToString();
                        List<NhomUID> nhomUIDs = SQLDatabase.LoadNhomUID(string.Format("select * from NhomUID where ParentId in (select id from NhomUID where Name='admin') and UID='{0}'", id));
                        if (nhomUIDs.Count == 0)
                        {
                            NhomUID nhomUIDCha = SQLDatabase.LoadNhomUID("select * from NhomUID where name='admin'").FirstOrDefault();
                            SQLDatabase.AddNhomUID(new NhomUID() { UID = id, Name = name, URD = link, ParentId = nhomUIDCha.id, IsActi = true, IsLoai = 0 });
                        }
                    }
                }
                /*Group*/
                foreach (DataGridViewRow row in gridGroup.Rows)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["checkNhom"];
                    if (chk.Value != null && (Boolean)chk.Value == true)
                    {
                        string id = row.Cells["idGroup"].Value.ToString();
                        string name = row.Cells["nameGroup"].Value.ToString();
                        List<NhomUID> nhomUIDs = SQLDatabase.LoadNhomUID(string.Format("select * from NhomUID where ParentId in (select id from NhomUID where Name='admin') and UID='{0}'", id));
                        if (nhomUIDs.Count == 0)
                        {
                            NhomUID nhomUIDCha = SQLDatabase.LoadNhomUID("select * from NhomUID where name='admin'").FirstOrDefault();
                            SQLDatabase.AddNhomUID(new NhomUID() { UID = id, Name = name ,URD= "https://www.facebook.com/", ParentId= nhomUIDCha.id, IsActi=true,IsLoai=2});
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "button2_Click");
            }
        }

        private void chkAllPage_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in gridPage.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["checkPage"];

                chk.Value = chkAllPage.Checked;

            }
            gridPage.EndEdit();
        }

        private void chkAllUser_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in gridUser.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["checkUser"];

                chk.Value = chkAllUser.Checked;

            }
            gridUser.EndEdit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in gridGroup.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["checkNhom"];

                chk.Value = checkBox1.Checked;

            }
            gridGroup.EndEdit();
        }
    }
}

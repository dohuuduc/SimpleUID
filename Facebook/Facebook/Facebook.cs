using HtmlAgilityPack;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Web;

namespace Facebook
{
    public class Android {
        public string app_name { get; set; }
        public string package { get; set; }
        public string url { get; set; }
    }
    public class Ios
    {
        public string app_name { get; set; }
        public string package { get; set; }
        public string url { get; set; }
    }
    public class App_links {
        public Android android { get; set; }
        public Ios ios { get; set; }
    }
    public class Category_list {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Cover {
        public string id { get; set; }
        public int cover_id { get; set; }
        public int offset_x { get; set; }
        public int offset_y { get; set; }
        public string source { get; set; }
    }
    public class Emails {
        public string emails { get; set; }
    }
    public class Page {
        public string id { get; set; }
        public string about { get; set; }/*Information about the Page*/
        public List<App_links> app_links { get; set; } /*AppLinks data associated with the Page's URL*/
        public string category { get; set; } /*The Page's category. e.g. Product/Service, Computers/Technology*/
        public List<Category_list> category_list { get; set; } /*The Page's sub-categories*/
        public int checkins { get; set; }/*Number of checkins at a place represented by a Page*/
        public Cover cover { get; set; }/*Information about the page's cover photo*/
        public string display_subtext { get; set; } /*Subtext about the Page being viewed*/
        public List<string> Emails { get; set; }/*The emails listed in the About section of a Page*/
        public string global_brand_page_name { get; set; }/*The name of the Page with country codes appended for Global Pages. Only visible to the Page admin*/
        public string has_added_app { get; set; }/*Indicates whether this Page has added the app making the query in a Page tab*/
        public string phone { get; set; } /*Phone number provided by a Page*/
        public string place_type { get; set; } /*For places, the category of the place*/
        public string username { get; set; }/*The alias of the Page. For example, for www.facebook.com/platform the username is 'platform'*/
        public string website { get; set; }/*The URL of the Page's website*/
        public int talking_about_count { get; set; } /*The number of people talking about this Page*/
    }


    public class Age_range {
        public int max { get; set; }
        public int min { get; set; }
    }
    #region devices
    public class Hardware {
        public string hardware { get; set; }
    }
    public class Os
    {
        public string os { get; set; }
    }
    public class Devices {
        public Hardware hardware;
        public Os os;
    }
    #endregion
    public class School {
        public string id { get; set; }
        public string name { get; set; }
    }
    public class Education {
        public string id { get; set; }
        public School school { get; set; }
        public string type { get; set; }
    }
    public class Favorite_athletes {
        public string id { get; set; }
        public string name { get; set; }
    }
    public class Hometown {
        public string id { get; set; }
        public string name { get; set; }
    }
    public class Interested_in {
        public string interested_in { get; set; }
    }
    public class Languages {
        public string id { get; set; }
        public string name { get; set; }
    }
    public class Location {
        public string id { get; set; }
        public string name { get; set; }
    }
    public class Employer {
        public string id { get; set; }
        public string name { get; set; }
    }
    public class Work {
        public string id { get; set; }
        public string description { get; set; }
        public Employer employer { get; set; }
        public string start_date { get; set; }
        public string end_date { get; set; }
    }
    public class User {
        public string id { get; set; }
        public Age_range age_range { get; set; }
        public string birthday { get; set; }
        public Cover convert { get; set; }
        public Devices devices { get; set; }
        public string email { get; set; }
        public Favorite_athletes favorite_Athletes { get; set; }
        public string name { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string name_format { get; set; }
        public string gender { get; set; }
        public Hometown hometown { get; set; }
        public string install_type { get; set; }
        public bool installed { get; set; }
        public List<Interested_in> interested_in { get; set; }
        public bool is_verified { get; set; }
        public Languages languages { get; set; }
        public string link { get; set; }
        public string locale { get; set; }
        public Location location { get; set; }
        public string quotes { get; set; }
        public string relationship_status {get;set;}
        public bool viewer_can_send_gift { get; set; }
        public List<Work> works { get; set; }

    }
    public class InfoFb {
        public string name { get; set; }
        public string uid { get; set; }
        public string urd { get; set; }
        public int loai { get; set; }
    }
    class Facebook
    {
        public static string Token(object arrControl) {
           

            FbAccount fbAccount = new FbAccount();
            try
            {
                ArrayList arr1 = (ArrayList)arrControl;
                System.Windows.Forms.Label lblMessage1 = (System.Windows.Forms.Label)arr1[0];
                System.Windows.Forms.Label lblMessage2 = (System.Windows.Forms.Label)arr1[1];
                System.Windows.Forms.Label lblSluongGoi = (System.Windows.Forms.Label)arr1[2];
                TextBox txtToken = (TextBox)arr1[3];
                CheckBox chkMe = (CheckBox)arr1[4];
                CheckBox chkBanBe = (CheckBox)arr1[5];
                CheckBox chkBaiViet = (CheckBox)arr1[6];
                System.Windows.Forms.Label lblQuataDaDung = (System.Windows.Forms.Label)arr1[7];
                System.Windows.Forms.Label lblQuataConLai = (System.Windows.Forms.Label)arr1[8];

                DataTable tb = SQLDatabase.ExcDataTable("spToken");
                if (tb.Rows.Count == 0) return "";

                fbAccount.id = (Guid)tb.Rows[0]["id"];
                fbAccount.account = tb.Rows[0]["account"].ToString();
                fbAccount.password =tb.Rows[0]["password"].ToString();
                fbAccount.token = tb.Rows[0]["token"].ToString();
                fbAccount.IsAct = Convert.ToBoolean(tb.Rows[0]["IsAct"].ToString());
                fbAccount.SoLuong = ConvertType.ToInt(tb.Rows[0]["sl"].ToString());
                fbAccount.maxx = ConvertType.ToInt(tb.Rows[0]["maxx"].ToString());

                /*update UI*/
                txtToken.Text = fbAccount.token;
                lblQuataDaDung.Text = string.Format("{0:#,#.}",fbAccount.SoLuong.ToString());
                lblQuataConLai.Text = string.Format("{0:#,#.}", fbAccount.maxx - fbAccount.SoLuong);
                txtToken.Update();
                lblQuataDaDung.Update();
                lblQuataConLai.Update();
                return fbAccount.token;
            }
            catch (Exception ex)
            {

                return "" ;
            }
        }
        public static NhomUID ConvertUrdToNhom(string strUrd)
        {
            try
            {
                NhomUID nhom = new NhomUID();
                string html = WebToolkit.GetHtml(strUrd);
                List<string> arrToken1 = html.Split(new char[] { '{' }).Where(p=>p.Contains("entity_id")).ToList();
                string arrToken2 = Regex.Split(arrToken1.FirstOrDefault(), "{").Where(p => p.Contains("entity_id")).FirstOrDefault();
                string arrToken3 = arrToken2.Split(new char[] { ';' }).Where(p => p.Contains("entity_id")).FirstOrDefault();
                string arrToken4 = arrToken3.Split(new char[] { ',' }).Where(p => p.Contains("entity_id")).FirstOrDefault();


                List<NhomUID> dm = SQLDatabase.LoadNhomUID("select * from NhomUID where name='admin'");
                nhom.UID = Regex.Match(arrToken4, @"\d+").Value;
                nhom.URD = strUrd;
                nhom.IsActi = true;
                nhom.OrderID = 0;
                nhom.ParentId = dm.FirstOrDefault().id;
                List<string> arrTieude = html.Split(new char[] { '<' }).Where(p => p.Contains("title id=\"pageTitle\"")).ToList();

                if (arrTieude.Count() > 0) {
                    nhom.Name = arrTieude.FirstOrDefault().Replace("title id=\"pageTitle\">", "");
                }
                /*cập nhật lại isLoai*/
                if (strUrd.Contains("https://www.facebook.com/groups/"))
                {
                    nhom.IsLoai = 2;
                }
                else {
                    if (!html.Contains("MESSAGE_PAGE"))
                    {
                        nhom.IsLoai = 0;
                    }
                    else {
                        nhom.IsLoai = 1;
                    }
                }
                

                return nhom;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static NhomUID ConvertUidToNhom(string strUid)
        {
            try
            {
                NhomUID nhom = new NhomUID();
                string html = WebToolkit.GetHtmlChuyenHtmlKhac(string.Format("https://www.facebook.com/profile.php?id={0}", strUid));

                List<string> arrToken1 = html.Split(new char[] { '\n', '\r' }).Where(p => p.Contains("entity_id")).ToList();
                List<string> arrToken2 = Regex.Split(arrToken1.FirstOrDefault(), "&amp;").Where(p => p.Contains("entity_id")).ToList();
                List<string> arrTokem3 = arrToken2.FirstOrDefault().Split(new char[] { '{' }).Where(p => p.Contains("entity_id")).ToList();
                List<string> arrTokem4 = arrToken2.FirstOrDefault().Split(new char[] { ',' }).Where(p => p.Contains("entity_id")).ToList();

                List<NhomUID> dm = SQLDatabase.LoadNhomUID("select * from NhomUID where name='admin'");
                nhom.UID = Regex.Match(arrTokem4.FirstOrDefault(), @"\d+").Value;

                /*tìm urd*/
                List<string> arrurd = html.Split(new char[] { '<' }).Where(p => p.Contains("link rel=\"alternate\" hreflang=\"x-default\"")).ToList();
                string strurl= Helpers.getUrlHtml2("<"+arrurd.FirstOrDefault()).FirstOrDefault();
                nhom.URD = strurl;
                nhom.IsActi = true;
                nhom.OrderID = 0;
                nhom.ParentId = dm.FirstOrDefault().id;
                List<string> arrTieude = html.Split(new char[] { '<' }).Where(p => p.Contains("title id=\"pageTitle\"")).ToList();

                if (arrTieude.Count() > 0)
                {
                    nhom.Name = arrTieude.FirstOrDefault().Replace("title id=\"pageTitle\">", "");
                }
                /*cập nhật lại isLoai*/
                if (nhom.URD.Contains("https://www.facebook.com/groups/"))
                {
                    nhom.IsLoai = 2;
                }
                else
                {
                    if (html.Contains("\"key\":\"friends\""))
                    {
                        nhom.IsLoai = 0;
                    }
                    else
                    {
                        nhom.IsLoai = 1;
                    }
                }

                return nhom;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static string RandomDigits(int length)
        {
            var random = new Random();
            string s = string.Empty;
            for (int i = 0; i < length; i++)
                s = String.Concat(s, random.Next(10).ToString());
            return s;
        }

        public static FbAccount Login(string username, string password)
        {
            try
            {
                string url = "https://www.facebook.com/login.php";
                string html = WebToolkit.GetHtmlChuyenHtmlKhac(url);

                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(html);
                HtmlNode documentNode = doc.DocumentNode;
                /*lgnrnd*/
                string dk_lgnrnd = "//input[@name='lgnrnd'][@value]";
                HtmlNode lgnrndNode = documentNode.SelectSingleNode(dk_lgnrnd);
                string lgnrnd = lgnrndNode.Attributes["value"].Value;


                string lgndim = "eyJ3IjoxMzY2LCJoIjo3NjgsImF3IjoxMzY2LCJhaCI6NzI4LCJjIjoyNH0=";
                List<string> lstserverTime = html.Split(new char[] { '{', '}' }).Where(p=>p.Contains("serverTime")).ToList();
                string serverTime = Regex.Match(lstserverTime.FirstOrDefault(), @"\d+").Value;


                string dk_lsd = "//input[@name='lsd'][@value]";
                HtmlNode dk_lsdNode = documentNode.SelectSingleNode(dk_lsd);
                string lsd = dk_lsdNode.Attributes["value"].Value;

                string dk_legacy_return = "//input[@name='legacy_return'][@value]";
                HtmlNode dk_legacy_returnNode = documentNode.SelectSingleNode(dk_legacy_return);
                string legacy_return = dk_legacy_returnNode.Attributes["value"].Value;

                /*trynum*/
                string dk_trynum = "//input[@name='trynum'][@value]";
                HtmlNode node_dk_trynum = documentNode.SelectSingleNode(dk_trynum);
                string trynum = node_dk_trynum.Attributes["value"].Value;

                /*prefill_source*/
                string dk_prefill_source = "//input[@name='prefill_source'][@value]";
                HtmlNode node_prefill_source = documentNode.SelectSingleNode(dk_prefill_source);
                string prefill_source = node_prefill_source == null ? "last_login" : node_prefill_source.Attributes["value"].Value;

                /*prefill_type*/
                string dk_prefill_type = "//input[@name='prefill_type'][@value]";
                HtmlNode node_prefill_type = documentNode.SelectSingleNode(dk_prefill_type);
                string prefill_type = node_prefill_type == null ? "contact_point" : node_prefill_type.Attributes["value"].Value;


                /*first_prefill_source*/
                string dk_first_prefill_source = "//input[@name='first_prefill_source'][@value]";
                HtmlNode node_first_prefill_source = documentNode.SelectSingleNode(dk_first_prefill_source);
                string first_prefill_source = node_first_prefill_source == null ? "last_login" : node_first_prefill_source.Attributes["value"].Value;

                /*first_prefill_type*/
                string dk_first_prefill_type = "//input[@name='first_prefill_type'][@value]";
                HtmlNode node_dk_first_prefill_type = documentNode.SelectSingleNode(dk_first_prefill_type);
                string first_prefill_type = node_dk_first_prefill_type == null ? "contact_point" : node_dk_first_prefill_type.Attributes["value"].Value;

                /*had_cp_prefilled*/
                string dk_had_cp_prefilled = "//input[@name='had_cp_prefilled'][@value]";
                HtmlNode node_dk_had_cp_prefilled = documentNode.SelectSingleNode(dk_had_cp_prefilled);
                string had_cp_prefilled = node_dk_had_cp_prefilled.Attributes["value"].Value;

                /*had_password_prefilled*/
                string dk_had_password_prefilled = "//input[@name='had_password_prefilled'][@value]";
                HtmlNode node_dk_had_password_prefilled = documentNode.SelectSingleNode(dk_had_password_prefilled);
                string had_password_prefilled = node_dk_had_password_prefilled.Attributes["value"].Value;


                string data = "lsd=" + lsd;
                data += "&display=" + "";
                data += "&enable_profile_selector=" + "";
                data += "&isprivate=" + "";
                data += "&legacy_return=" + legacy_return;
                data += "&profile_selector_ids=" + "";
                data += "&return_session=" + "";
                data += "&skip_api_login=" + "";
                data += "&signed_next=" + "";
                data += "&trynum=" + trynum;
                data += "&timezone=-60";
                data += "&lgndim=" + Uri.EscapeDataString(lgndim);
                data += "&lgnrnd=" + lgnrnd;
                data += "&lgnjs=" + serverTime;
                data += "&email=" + Uri.EscapeDataString(username);
                data += "&pass=" + Uri.EscapeDataString(password);
                data += "&prefill_contact_point=" + Uri.EscapeDataString(username);
                data += "&prefill_source=" + prefill_source.Substring(0,10);
                data += "&prefill_type=" + prefill_type;
                data += "&first_prefill_source=" + first_prefill_source;
                data += "&first_prefill_type=" + first_prefill_type;
                data += "&had_cp_prefilled=" + had_cp_prefilled;
                data += "&had_password_prefilled=" + had_password_prefilled;

                string html2 = getHTML(url, data);
                doc.LoadHtml(html2);
                documentNode = doc.DocumentNode;
                /*lgnrnd*/
                string loc = "//a[@class='accessible_elem']";
                HtmlNode nodeloc = documentNode.SelectNodes(loc).Where(p => p.OuterHtml.Contains("https://www.facebook.com/profile.php?id=")).FirstOrDefault();
                string url1 = nodeloc.Attributes["href"].Value;
                url1 = url1.IndexOf("&amp;") == 0 ? url1 : url1.Substring(0, url1.IndexOf("&amp;"));

                string html3 = WebToolkit.GetHtml(url1);
                string[] xx = html3.Split(new char[] { '\n', '\r' });
                var index = Array.Find(xx, x => x.Contains("access_token:\"EAAA"));
                string[] xx2 = index.Split(new char[] { ',' }).Where(p => p.Contains("access_token:\"EAAA")).ToArray();
                string stoken = xx2.FirstOrDefault().Split(new char[] { '\"' }).Where(p => p.Contains("EAAA")).FirstOrDefault();

                return new FbAccount() { account = username, password = password, token= stoken }; 
            }
            catch
            {
                return new FbAccount() { account =username, password= password  };
            }
        }

        private static string getHTML(string url, string data =null)
        {
            string html2 = "";
            int n = 3;
            while (n > 0)
            {
                if (data != null)
                {
                    html2 = WebToolkit.GetHtml(url, data);
                }else
                    html2 = WebToolkit.GetHtml(url);

                if (html2 != "") break;
                n--;
            }
            return html2;
        }

        public static string GetHtmlFB(string Url,string token)
        {
            string result;
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(Url);
                httpWebRequest.Method = "GET";
                httpWebRequest.ContentType = "application/x-www-form-urlencoded";
                httpWebRequest.Accept = "application/json, text/plain, */*";
                httpWebRequest.Headers.Add("Accept-Language: vi-VN,vi;q=0.8,fr-FR;q=0.6,fr;q=0.4,en-US;q=0.2,en;q=0.2,ja;q=0.2,de;q=0.2");
                httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/54.0.2840.99 Safari/537.36";
                WebResponse response = httpWebRequest.GetResponse();
                StreamReader streamReader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                string text = streamReader.ReadToEnd();
                streamReader.Close();
                response.Close();
                result = text;
            }
            catch
            {
                result = "";
            }
            Log(Url,token);
            return result;
        }

        public static void Log(string url,string token) {
            try
            {
               FbAccount model = SQLDatabase.LoadFbAccount(string.Format("select * from FbAccount where token='{0}'", token)).FirstOrDefault();
               SQLDatabase.AddFbLog(new FbLog() { account = model.account, command= url });
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Log");
            }
        }

        public static string SelectMyUIDOfUser()
        {
            List<string> lstMyUid = new List<string>();
            lstMyUid.Add("id");
            lstMyUid.Add("name");
            lstMyUid.Add("age_range"); /*The age segment for this person expressed as a minimum and maximum age. For example, more than 18, less than 21.*/
            lstMyUid.Add("birthday"); /*The person's birthday. This is a fixed format string, like MM/DD/YYYY. However, people can control who can see the year they were born separately from the month and day so this string can be only the year (YYYY) or the month + day (MM/DD)*/
            lstMyUid.Add("cover");/*The person's cover photo*/
            lstMyUid.Add("currency");/*The person's local currency information*/
            lstMyUid.Add("devices");/*The list of devices the person is using. This will return only iOS and Android devices*/
            lstMyUid.Add("education"); /*list < EducationExperience >*/
            lstMyUid.Add("work");/*list<WorkExperience>*/
            lstMyUid.Add("gender");/*The gender selected by this person, male or female. If the gender is set to a custom value, this value will be based off of the preferred pronoun; it will be omitted if the preferred preferred pronoun is neutral*/
            lstMyUid.Add("locale");/*he person's locale**/
            lstMyUid.Add("relationship_status");/*tình trạng hôn nhân*/
            lstMyUid.Add("mobile_phone");
            

            return string.Join(",", lstMyUid);
        }
        public static string SelectMyGUIOfUser()
        {
            List<string> lstMyUid = new List<string>();
            lstMyUid.Add("id");
            lstMyUid.Add("name");
            lstMyUid.Add("description"); /*The age segment for this person expressed as a minimum and maximum age. For example, more than 18, less than 21.*/
            lstMyUid.Add("email"); /*The person's birthday. This is a fixed format string, like MM/DD/YYYY. However, people can control who can see the year they were born separately from the month and day so this string can be only the year (YYYY) or the month + day (MM/DD)*/
            lstMyUid.Add("icon");/*The person's cover photo*/
            lstMyUid.Add("member_request_count");/*The person's local currency information*/
            lstMyUid.Add("owner");/*The list of devices the person is using. This will return only iOS and Android devices*/
            lstMyUid.Add("privacy"); /*list < EducationExperience >*/
            lstMyUid.Add("updated_time");/*list<WorkExperience>*/

            return string.Join(",", lstMyUid);
        }
        public static string SelectMyPageOfUser()
        {
            List<string> lstMyUid = new List<string>();
            lstMyUid.Add("id");
            lstMyUid.Add("name");
            lstMyUid.Add("app_links");
            lstMyUid.Add("about");

            return string.Join(",", lstMyUid);
        }
        public static string SelectFbFriend() {
            List<string> lstMyUid = new List<string>();
            lstMyUid.Add("id");
            lstMyUid.Add("name");
            lstMyUid.Add("first_name");
            lstMyUid.Add("last_name");
            lstMyUid.Add("name_format");
            lstMyUid.Add("name");
            lstMyUid.Add("mobile_phone");
            lstMyUid.Add("birthday");
            lstMyUid.Add("email");
            lstMyUid.Add("gender");
            lstMyUid.Add("location");
            lstMyUid.Add("age_range");
            lstMyUid.Add("cover");
            lstMyUid.Add("devices");
            lstMyUid.Add("education");
            lstMyUid.Add("favorite_athletes");
            lstMyUid.Add("favorite_teams");
            lstMyUid.Add("hometown");
            lstMyUid.Add("install_type");
            lstMyUid.Add("installed");
            lstMyUid.Add("interested_in");
            lstMyUid.Add("is_verified");
            lstMyUid.Add("languages");
            lstMyUid.Add("link");
            lstMyUid.Add("locale");
            lstMyUid.Add("political");
            lstMyUid.Add("quotes");
            lstMyUid.Add("relationship_status");
            lstMyUid.Add("religion");
            lstMyUid.Add("sports");
            lstMyUid.Add("third_party_id");
            lstMyUid.Add("website");
            lstMyUid.Add("work");

            return string.Join(",", lstMyUid);
        }

        public static string Selectcomments()
        {
            List<string> lstMyUid = new List<string>();
            lstMyUid.Add("id");
            lstMyUid.Add("message");

            /*from*/
            lstMyUid.Add("from.name");
            lstMyUid.Add("from.first_name");
            lstMyUid.Add("from.last_name");
            lstMyUid.Add("from.name_format");
            lstMyUid.Add("from.name");
            lstMyUid.Add("from.mobile_phone");
            lstMyUid.Add("from.birthday");
            lstMyUid.Add("from.email");
            lstMyUid.Add("from.gender");
            lstMyUid.Add("from.location");
            lstMyUid.Add("from.age_range");
            lstMyUid.Add("from.cover");
            lstMyUid.Add("from.devices");
            lstMyUid.Add("from.education");
            lstMyUid.Add("from.favorite_athletes");
            lstMyUid.Add("from.favorite_teams");
            lstMyUid.Add("from.hometown");
            lstMyUid.Add("from.install_type");
            lstMyUid.Add("from.installed");
            lstMyUid.Add("from.interested_in");
            lstMyUid.Add("from.is_verified");
            lstMyUid.Add("from.languages");
            lstMyUid.Add("from.link");
            lstMyUid.Add("from.locale");
            lstMyUid.Add("from.political");
            lstMyUid.Add("from.quotes");
            lstMyUid.Add("from.relationship_status");
            lstMyUid.Add("from.religion");
            lstMyUid.Add("from.sports");
            lstMyUid.Add("from.third_party_id");
            lstMyUid.Add("from.website");
            lstMyUid.Add("from.work");

            return string.Join(",", lstMyUid);
        }

    }


}

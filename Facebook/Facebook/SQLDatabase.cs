using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Facebook
{
    public class FbAccount
    {
        //id, account, password, token, createdate
        public Guid id { get; set; }
        public string account { get; set; }
        public string password { get; set; }
        public string token { get; set; }
        public bool IsAct { get; set; }
        public int SoLuong { get; set; }
        public int maxx { get; set; }
    }
    public class ListFbComments {
        [JsonProperty("data")]
        public List<FbComments> fbComments { get; set; }
    }
    public class FbComments {
        [JsonIgnore]
        public Guid id { get; set; }
        [JsonIgnore]
        public string uid { get; set; }
        [JsonIgnore]
        public string feedid { get; set; }
        [JsonProperty("id")]
        public string commendId { get; set; }
        public string message { get; set; }
        public from from { get; set; }
        public bool can_remove { get; set; }
        public int like_count { get; set; }
        public bool user_likes { get; set; }
        public string created_time { get; set; }
        public FbComments() {
            this.commendId = "";
            this.message = "";
            this.from = null;
            this.can_remove = false;
            this.like_count = 0;
            this.user_likes = false;
            this.created_time = "";
    }
    }
    public class FbUID
    {
        [JsonIgnore]
        public Guid id { get; set; }
        [JsonProperty("id")]
        public string uid { get; set; }
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("age_range")]
        public age_range age_ranges { get; set; }
        [JsonProperty("education")]
        public List<education> educations { get; set; }
        public location location { get; set; }
        public string mobile_phone { get; set; }
        public string birthday { get; set; }
        public string gender { get; set; }
        public string locale { get; set; }
        public string relationship_status { get; set; }
        public string currency { get; set; }
        public string email { get; set; }
        public cover cover { get; set; }
        public List<devices> devices { get; set; }
        public List<work> work { get; set; }

        public FbUID() {
            this.uid = "";
            this.name="";
            this.age_ranges = null;
            this.educations = null;
            this.location = null;
            this.mobile_phone = "";
            this.birthday = "";
            this.gender = "";
            this.locale = "";
            this.relationship_status = "";
            this.currency = "";
            this.email = "";
            this.cover = null;
            this.devices = null;
            this.work = null;
        }
    }
    public class dm_column
    {
        //id, account, password, token, createdate
        public int id { get; set; }
        public string Keys { get; set; }
        public string name { get; set; }
        public bool act { get; set; }
        public int orderid { get; set; }
    }
    public class FbPage {
        [JsonIgnore]
        public Guid id { get; set; }
        [JsonProperty("id")]
        public string uid { get; set; }
        [JsonProperty("name")]
        public string name { get; set; }
        public string about { get; set; } /*Information about the Page*/
        public app_links app_Links { get; set; }

        public FbPage() {
            this.uid = "";
            this.name = "";
            this.about = "";
            this.app_Links = null;
        }
    }
    public class app_links {
        public List<android> android { get; set; }
        public List<ios> ios { get; set; }
    }

    public class FbGUI
    {
        [JsonIgnore]
        public Guid id { get; set; }
        [JsonProperty("id")]
        public string uid { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string email { get; set; }
        public string icon { get; set; }
        public int member_request_count { get; set; }
        public owner owner { get; set; }
        public string privacy { get; set; }
        public string updated_time { get; set; }

        public FbGUI()
        {

            this.uid = "";
            this.name = "";
            this.description = "";
            this.email = "";
            this.icon = "";
            this.member_request_count = 0;
            this.owner = null;
            this.privacy = "";
            this.updated_time = "";
        }
    }


    //public class ListFbLike {
    //    [JsonProperty("data")]
    //    public string[] fbLike { get; set; } 
    //}
    public class FbLike {
       
        [JsonIgnore]
        public Guid id { get; set; }
        [JsonIgnore]
        public string uid { get; set; }
        [JsonProperty("feedid")]
        public string feedid { get; set; }
        [JsonProperty("id")]
        public string likeid { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string username { get; set; }
        public string gender { get; set; }
        public string link { get; set; }
        public location location { get; set; }
        public string locale { get; set; }
        public string updated_time { get; set; }
        public List<education> education { get; set; }
        public List<favorite_athletes> favorite_athletes { get; set; }
        public List<favorite_teams> favorite_teams { get; set; }
        public string relationship_status { get; set; }
        public List<work> work { get; set; }
        public bool can_post { get; set; }
        public string category { get; set; }
        public List<Category_list> category_list { get; set; }
        public cover cover { get; set; }
        public bool has_added_app { get; set; }
        public bool is_published { get; set; }
        public int likes { get; set; }
        public string name { get; set; }
        public int talking_about_count { get; set; }
        public int were_here_count { get; set; }

        public FbLike() {
            this.uid = "";
            this.feedid = "";
            this.likeid = "";
            this.first_name = "";
            this.last_name = "";
            this.username = "";
            this.gender = "";
            this.link = "";
            this.location = null;
            this.locale = "";
            this.updated_time = "";
            this.education = null;
            this.favorite_athletes = null;
            this.favorite_teams = null;
            this.relationship_status = "";
            this.work = null;
            this.can_post = false;
            this.category = "";
            this.category_list = null;
            this.cover = null;
            this.has_added_app = false;
            this.is_published = false;
            this.likes = 0;
            this.name = "";
            this.talking_about_count = 0;
            this.were_here_count = 0;
    }
    }
    public class ListFbFeed
    {
        [JsonProperty("data")]
        public List<FbFeed> FbFeed { get; set; }
    }
    public class FbFeed
    {
        [JsonIgnore]
        public Guid id { get; set; }
        [JsonIgnore]
        public string feedid { get; set; }
        [JsonProperty("id")]
        public string uid { get; set; }
        public string name { get; set; }
        public from from { get; set; }
        public string message { get; set; }
        [JsonProperty("message_tags")]
        public Dictionary<string,story_tags[]> message_tags { get; set; }
        public with_tags with_tags { get; set; }
        public string story { get; set; }
        [JsonProperty("story_tags")]
        public Dictionary<string,story_tags[]> story_tags { get; set; }
        public string picture { get; set; }
        public string link { get; set; }
        public string description { get; set; }
        public List<actions> actions { get; set; }
        public privacy privacy { get; set; }
        public string type { get; set; }
        public string status_type { get; set; }
        public string object_id { get; set; }
        public string created_time { get; set; }
        public string updated_time { get; set; }
        public bool is_hidden { get; set; }
        public bool is_expired { get; set; }
        public likes likes { get; set; }
        public comments comments { get; set; }

        public FbFeed() {
            this.uid = "";
            this.name = "";
            this.from = null;
            this.message = "";
            this.message_tags = null;
            this.story = "";
            this.picture = "";
            this.link = "";
            this.description = "";
            this.actions = null;
            this.privacy = null;
            this.type = "";
            this.status_type = "";
            this.object_id = "";
            this.created_time = "";
            this.updated_time = "";
            this.is_hidden = false;
            this.is_expired = false;
            this.likes = null;
            this.comments = null;
    }

    }
    public class Pagings
    {
        [JsonProperty("paging")]
        public Paging Paging { get; set; }
    }
    public partial class Paging
    {
        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }
    }


    public class with_tags {
        [JsonProperty("data")]
        public List<with_tags_data> data { get; set; }
    }
    public class with_tags_data {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class story_tags {
        public string id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public int offset { get; set; }
        public int length { get; set; }
    }
    public class comments {
        public int count { get; set; }
    }
    public class likes {
        public int count { get; set; }
    }
    public class privacy {
        public string value { get; set; }
        public string description { get; set; }
        public string friends { get; set; }
        public string allow { get; set; }
        public string deny { get; set; }
    }
    public class actions {
        public string name { get; set; }
        public string link { get; set; }
    }
    public class from {
        public string id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public location location { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string name_format { get; set; }
        public string mobile_phone { get; set; }
        public string birthday { get; set; }
        public age_range age_range { get; set; }
        public cover cover { get; set; }
        public List<devices> devices { get; set; }
        public List<education> education { get; set; }
        public List<favorite_athletes> favorite_athletes { get; set; }
        public List<favorite_teams> favorite_teams { get; set; }
        public Hometown hometown { get; set; }
        public string install_type { get; set; }
        public string installed { get; set; }
        public List<string> interested_in { get; set; }
        public bool is_verified { get;set; }
        public List<Languages> languages { get; set; }
        public string link { get; set; }
        public string locale { get; set; }
        public string political { get; set; }
        public string quotes { get; set; }
        public string relationship_status { get; set; }
        public string religion { get; set; } 
        public List<sports> sports { get; set; }
        public string third_party_id { get; set; }
        public string website { get; set; }
        public List<work> work { get; set; }
    }
    public class ListFbFriend {
        [JsonProperty("data")]
        public List<FbFriend> FbFriend { get; set; }
        public ListFbFriend() {
            this.FbFriend = new List<FbFriend>();
        }
    }

    public class FbFriend
    {
        [JsonIgnore]
        public Guid id { get; set; }
        public string uid { get; set; }
        [JsonProperty("id")]
        public string FriendUid { get; set; }
        public string name { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string name_format { get; set; }
        public string mobile_phone { get; set; }
        public string birthday { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public location location { get; set; }
        public age_range age_range { get; set; }
        public cover cover { get; set; }
        public List<devices> devices { get; set; }
        public List<education> education { get; set; }
        public List<favorite_athletes> favorite_athletes { get; set; }
        public List<favorite_teams> favorite_teams { get; set; }
        public Hometown hometown { get; set; }
        public string install_type { get; set; }
        public bool installed { get; set; }
        public List<string> interested_in { get; set; }
        public bool is_verified { get; set; }
        public List<Languages> languages { get; set; }
        public string link { get; set; }
        public string locale { get; set; }
        public string political { get; set; }
        public string quotes { get; set; }
        public string relationship_status { get; set; }
        public string religion { get; set; }
        public List<sports> sports { get; set; }
        public string third_party_id { get; set; }
        public string website { get; set; }
        public List<work> work { get; set; }

        public FbFriend() {
            this.uid = "";
            this.FriendUid = "";
            this.name = "";
            this.first_name = " ";
            this.last_name = " ";
            this.name_format = "";
            this.mobile_phone = "";
            this.birthday = "";
            this.email = "";
            this.gender = "";
            this.location = null;
            this.age_range = null;
            this.cover = null;
            this.devices = null;
            this.education = null;
            this.favorite_athletes = null;
            this.favorite_teams = null;
            this.hometown = null;
            this.install_type = "";
            this.installed = false;
            this.interested_in = null;
            this.is_verified = false;
            this.languages = null;
            this.link = "";
            this.locale = "";
            this.political = "";
            this.quotes = "";
            this.relationship_status = "";
            this.religion = "";
            this.sports = null;
            this.third_party_id = "";
            this.website = "";
            this.work = null;
    }
    }

    public class ListFbPageSearch {
        [JsonProperty("data")]
        public List<FbPageSearch> FbPageSearch { get; set; }
        public ListFbPageSearch()
        {
            this.FbPageSearch = new List<FbPageSearch>();
        }
    }
    public class FbPageSearch {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string link { get; set; }
        public string website { get; set; }
        public string about { get; set; }
        public location location { get; set; }
        public cover cover { get; set; }
        public string mission { get; set; }
    }

    public class ListFbUserSearch { 
        [JsonProperty("data")]
        public List<FbUserSearch> FbUserSearch { get; set; }
        public ListFbUserSearch()
        {
            this.FbUserSearch = new List<FbUserSearch>();
        }
    }

   

    public class FbUserSearch
    {
        public string id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
        public location location { get; set; }
        public cover cover { get; set; }
        public List<education> education { get; set; }
        public List<work> work { get; set; }
    }
    public class ListFbGroupSearch
    {
        [JsonProperty("data")]
        public List<FbGroupSearch> FbGroupSearch { get; set; }
        public ListFbGroupSearch()
        {
            this.FbGroupSearch = new List<FbGroupSearch>();
        }
    }
    public class FbGroupSearch
    {
        public string id { get; set; }
        public string name { get; set; }
        public cover cover { get; set; }
        public string description { get; set; }
    }
    public class sports {
        public string id { get; set; }
        public string name { get; set; }
        public List<with> with { get; set; }
    }
    public class with
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class favorite_teams {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class favorite_athletes {
        public string id { get; set; }
        public string name { get; set; }
    }
    public class owner {
        public string id { get; set; }
        public string name { get; set; }

    }

    public class android {
        public string app_name { get; set; }
        public string package { get; set; }
        public string url { get; set; }
    }
    public class ios
    {
        public string app_name { get; set; }
        public string app_store_id { get; set; }
        public string url { get; set; }
    }
    public class cover {
        public int offset_x { get; set; }
        public int offset_y { get; set; }
        public string source { get; set; }
    }
    public class devices{
        public string hardware { get; set; }
        public string os { get; set; }
    }
    public class age_range {
        public int min { get; set; }
        public int max { get; set; }
    }
    public class currency
    {
        public string currency_exchange { get; set; }
        public string currency_exchange_inverse { get; set; }
        public string currency_offset { get; set; }
        public string usd_exchange { get; set; }
        public string usd_exchange_inverse { get; set; }
        public string user_currency { get; set; }

    }
    public class education {
        public string id { get; set; }
        public string type { get; set; }
        [JsonProperty("school")]
        public school school { get; set; }
        [JsonProperty("concentration")]
        public List<concentration> concentration { get; set; }
        [JsonProperty("classes")]
        public List<classes> classes { get; set; }
        
    }
    public class concentration {
        public string id { get; set; }
        public string name { get; set; }
    }
    public class classes {
        public string id { get; set; }
        public string name { get; set; }
    }
    public class school {
        public string id { get; set; }
        public string name { get; set; }
    }
    #region likes

    public class Likes
    {
        [JsonProperty("data")]
        public List<like> like { get; set; }
    }

    public class like
    {
        public string id { get; set; }
        public string name { get; set; }
    }
    #endregion
    public class FbLog {
        public Guid id { get; set; }
        public string account { get; set; }
        public string command { get; set; }
    }
    public class data
    {
        public string fieldName;

        public string value;

        public data(string name, string val)
        {
            this.fieldName = name;
            this.value = val;
        }

        public data(string line)
        {
            char[] op = new char[]
            {
                '='
            };
            string[] s = line.Split(op);
            if (s.Length == 1 || s.Length == 0)
            {
                this.fieldName = null;
                this.value = null;
            }
            else if (s.Length == 2)
            {
                this.fieldName = s[0];
                this.value = s[1];
            }
            else
            {
                this.fieldName = s[0];
                this.value = line.Substring(s[0].Length + 1);
            }
        }
    }
    public class NhomUID {
        public Guid id { get; set; }
        public Guid? ParentId { get; set; }
        public string Name { get; set; }
        public string UID { get; set; }
        public string URD { get; set; }
        public string Note { get; set; }
        public bool IsActi { get; set; }
        public int IsLoai { get; set; }
        public int OrderID { get; set; }
        public DateTime CreateDate { get; set; }
        public NhomUID() {
            this.Name = "";
            this.UID = "";
            this.URD = "";
            this.Note = "";
            this.IsActi = false;
            this.IsLoai = 0;
            this.OrderID = 0;
        }
    }
    public class work {
        public string id { get; set; }
        public string start_date { get; set; }
        public string end_date { get; set; }
        public employer employer { get; set; }
        public location location { get; set; }
    }
    public class employer {
        public string id { get; set; } 
        public string name { get; set; }
    }

    public class location {
        public string id { get; set; }
        public string name { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string latitude { get; set; }
        public string located_in { get; set; }
        public string longitude { get; set; }
        public string street { get; set; }
        public string zip { get; set; }
    }
    
    public class CauHinh
    {
        public int LimitCallApi { get; set; }
        public int TimerOut { get; set; }
        public int GoiLai { get; set; }
        public int LimitTimKiemFb { get; set; }


    }

    public class dau_so
    {
        public int id { get; set; }
        public string nhanamg { get; set; }
        public int parentid { get; set; }
        public string dauso { get; set; }
        public int length { get; set; }
        public int orderid { get; set; }
    }

    public class regexs
    {
        public int id { get; set; }
        public string RegexName { get; set; }
        public string Regex { get; set; }
        public string Example { get; set; }
        public int OrderId { get; set; }
    }
    //id, ma, name, isAct, OrderId
    public class DM_QuocGia
    {
        public Guid id { get; set; }
        public string ma { get; set; }
        public string name { get; set; }
        public bool isAct { get; set; }
        public int OrderId { get; set; }

        public DM_QuocGia()
        {
            this.ma = "";
            this.name = "";
            this.isAct = true;
            this.OrderId = 0;
        }
    }
    class SQLDatabase
    {
        #region Fields
        public static string ConnectionString {
            get {
                FileDataDictionary FDD = new FileDataDictionary("setup.con");
                return FDD.getValue("connectionstring");
            }
        }
        #endregion // Fields

        #region Đầu số vs Regexs
        public static List<dau_so> Loaddau_so(string sql)
        {
            SqlConnection cnn = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;
            dau_so InfoCOMMANDTABLE;
            List<dau_so> InfoCOMMANDTABLEs = null;

            try
            {
                InfoCOMMANDTABLEs = new List<dau_so>();

                cnn = new SqlConnection();
                cnn.ConnectionString = ConnectionString;
                cnn.Open();
                cnn.FireInfoMessageEventOnUserErrors = false;

                cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = cnn;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    InfoCOMMANDTABLE = new dau_so();


                    if (!reader.IsDBNull(0))
                        InfoCOMMANDTABLE.id = reader.GetInt32(0);
                    if (!reader.IsDBNull(1))
                        InfoCOMMANDTABLE.nhanamg = reader.GetString(1);
                    if (!reader.IsDBNull(2))
                        InfoCOMMANDTABLE.parentid = reader.GetInt32(2);
                    if (!reader.IsDBNull(3))
                        InfoCOMMANDTABLE.dauso = reader.GetString(3);
                    if (!reader.IsDBNull(4))
                        InfoCOMMANDTABLE.length = reader.GetInt32(4);
                    if (!reader.IsDBNull(5))
                        InfoCOMMANDTABLE.orderid = reader.GetInt32(5);
                    InfoCOMMANDTABLEs.Add(InfoCOMMANDTABLE);
                }
                return InfoCOMMANDTABLEs;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
        }
        public static List<regexs> LoadRegexs(string sql)
        {
            SqlConnection cnn = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;
            regexs InfoCOMMANDTABLE;
            List<regexs> InfoCOMMANDTABLEs = null;

            try
            {
                InfoCOMMANDTABLEs = new List<regexs>();

                cnn = new SqlConnection();
                cnn.ConnectionString = ConnectionString;
                cnn.Open();
                cnn.FireInfoMessageEventOnUserErrors = false;

                cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = cnn;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    InfoCOMMANDTABLE = new regexs();


                    if (!reader.IsDBNull(0))
                        InfoCOMMANDTABLE.id = reader.GetInt32(0);
                    if (!reader.IsDBNull(1))
                        InfoCOMMANDTABLE.RegexName = reader.GetString(1);
                    if (!reader.IsDBNull(2))
                        InfoCOMMANDTABLE.Regex = reader.GetString(2);
                    if (!reader.IsDBNull(3))
                        InfoCOMMANDTABLE.Example = reader.GetString(3);
                    if (!reader.IsDBNull(4))
                        InfoCOMMANDTABLE.OrderId = reader.GetInt32(4);
                    InfoCOMMANDTABLEs.Add(InfoCOMMANDTABLE);
                }
                return InfoCOMMANDTABLEs;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
        }
        #endregion

        #region CauHinh
        public static CauHinh LoadCauHinh(string sql)
        {
            SqlConnection cnn = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;
            CauHinh InfoCOMMANDTABLE;
            List<CauHinh> InfoCOMMANDTABLEs = null;

            try
            {
                InfoCOMMANDTABLEs = new List<CauHinh>();

                cnn = new SqlConnection();
                cnn.ConnectionString = ConnectionString;
                cnn.Open();
                cnn.FireInfoMessageEventOnUserErrors = false;

                cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = cnn;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    InfoCOMMANDTABLE = new CauHinh();
                    if (!reader.IsDBNull(0))
                        InfoCOMMANDTABLE.LimitCallApi = reader.GetInt32(0);
                    if (!reader.IsDBNull(1))
                        InfoCOMMANDTABLE.TimerOut = reader.GetInt32(1);
                    if (!reader.IsDBNull(2))
                        InfoCOMMANDTABLE.GoiLai = reader.GetInt32(2);
                    if (!reader.IsDBNull(3))
                        InfoCOMMANDTABLE.LimitTimKiemFb = reader.GetInt32(3);
                    InfoCOMMANDTABLEs.Add(InfoCOMMANDTABLE);
                }
                return InfoCOMMANDTABLEs.FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
        }

        public static bool UpdateCauHinh(CauHinh record)
        {
            SqlConnection connection = null;
            SqlCommand cmd = null;

            try
            {
                if (record == null)
                    return false;

                // Make connection to database
                connection = new SqlConnection();
                connection.ConnectionString = ConnectionString;
                connection.FireInfoMessageEventOnUserErrors = false;
                connection.Open();
                // Create command to update GeneralGuessGroup record
                cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "Update [CauHinh] Set LimitCallApi=@LimitCallApi, TimerOut=@TimerOut, GoiLai=@GoiLai, LimitTimKiemFb=@LimitTimKiemFb";
                                   
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@LimitCallApi", record.LimitCallApi);
                cmd.Parameters.AddWithValue("@TimerOut", record.TimerOut);
                cmd.Parameters.AddWithValue("@GoiLai", record.GoiLai);
                cmd.Parameters.AddWithValue("@LimitTimKiemFb", record.LimitTimKiemFb);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        #endregion

        #region dm_column
        public static List<dm_column> Loaddm_column(string sql)
        {
            SqlConnection cnn = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;
            dm_column InfoCOMMANDTABLE;
            List<dm_column> InfoCOMMANDTABLEs = null;

            try
            {
                InfoCOMMANDTABLEs = new List<dm_column>();

                cnn = new SqlConnection();
                cnn.ConnectionString = ConnectionString;
                cnn.Open();
                cnn.FireInfoMessageEventOnUserErrors = false;

                cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = cnn;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    InfoCOMMANDTABLE = new dm_column();
                    if (!reader.IsDBNull(0))
                        InfoCOMMANDTABLE.id = reader.GetInt32(0);
                    if (!reader.IsDBNull(1))
                        InfoCOMMANDTABLE.Keys = reader.GetString(1);
                    if (!reader.IsDBNull(2))
                        InfoCOMMANDTABLE.name = reader.GetString(2);
                    if (!reader.IsDBNull(3))
                        InfoCOMMANDTABLE.act = reader.GetBoolean(3);
                    if (!reader.IsDBNull(4))
                        InfoCOMMANDTABLE.orderid = reader.GetInt32(4);
                    InfoCOMMANDTABLEs.Add(InfoCOMMANDTABLE);
                }
                return InfoCOMMANDTABLEs;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
        }
        public static bool Updatedm_column(dm_column record)
        {
            SqlConnection connection = null;
            SqlCommand cmd = null;

            try
            {
                if (record == null)
                    return false;

                // Make connection to database
                connection = new SqlConnection();
                connection.ConnectionString = ConnectionString;
                connection.FireInfoMessageEventOnUserErrors = false;
                connection.Open();
                // Create command to update GeneralGuessGroup record
                cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "Update [dm_column] Set  Keys=@Keys,name=@name, act=@act, orderid=@orderid " +
                                 " where id='" + record.id + "'";
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@Keys", record.Keys);
                cmd.Parameters.AddWithValue("@name", record.name);
                cmd.Parameters.AddWithValue("@act", record.act);
                cmd.Parameters.AddWithValue("@orderid", record.orderid);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }
        #endregion

        #region DM_QuocGia
        public static List<DM_QuocGia> LoadDM_QuocGia(string sql)
        {
            SqlConnection cnn = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;
            DM_QuocGia InfoCOMMANDTABLE;
            List<DM_QuocGia> InfoCOMMANDTABLEs = null;

            try
            {
                InfoCOMMANDTABLEs = new List<DM_QuocGia>();

                cnn = new SqlConnection();
                cnn.ConnectionString = ConnectionString;
                cnn.Open();
                cnn.FireInfoMessageEventOnUserErrors = false;

                cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = cnn;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    InfoCOMMANDTABLE = new DM_QuocGia();
                    if (!reader.IsDBNull(0))
                        InfoCOMMANDTABLE.id = reader.GetGuid(0);
                    if (!reader.IsDBNull(1))
                        InfoCOMMANDTABLE.ma = reader.GetString(1);
                    if (!reader.IsDBNull(2))
                        InfoCOMMANDTABLE.name = reader.GetString(2);
                    if (!reader.IsDBNull(3))
                        InfoCOMMANDTABLE.isAct = reader.GetBoolean(3);
                    if (!reader.IsDBNull(4))
                        InfoCOMMANDTABLE.OrderId = reader.GetInt32(4);

                    InfoCOMMANDTABLEs.Add(InfoCOMMANDTABLE);
                }
                return InfoCOMMANDTABLEs;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
        }
        public static bool AddDM_QuocGia(DM_QuocGia record)
        {
            SqlConnection cnn = null;
            SqlCommand cmd = null;

            try
            {
                if (record == null)
                    return false;

                cnn = new SqlConnection();
                cnn.ConnectionString = ConnectionString;
                cnn.FireInfoMessageEventOnUserErrors = false;
                cnn.Open();

                cmd = new SqlCommand();
                cmd.Connection = cnn;
                //--- Insert Record
                cmd.CommandText = "Insert into DM_QuocGia(ma, name, isAct, OrderId) OUTPUT inserted.id " +
                                  " values(@ma, @name, @isAct, @OrderId);";


                cmd.Parameters.AddWithValue("@ma", record.ma);
                cmd.Parameters.AddWithValue("@name", record.name);
                cmd.Parameters.AddWithValue("@isAct", record.isAct);
                cmd.Parameters.AddWithValue("@OrderId", record.OrderId);
                Guid guid = (Guid)cmd.ExecuteScalar();

                if (guid == null || guid == Guid.Empty)
                    return false;

                record.id = new Guid(guid.ToString());

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
        }

        public static bool UpdateDM_QuocGia(DM_QuocGia record)
        {
            SqlConnection connection = null;
            SqlCommand cmd = null;

            try
            {
                if (record == null)
                    return false;

                // Make connection to database
                connection = new SqlConnection();
                connection.ConnectionString = ConnectionString;
                connection.FireInfoMessageEventOnUserErrors = false;
                connection.Open();
                // Create command to update GeneralGuessGroup record
                cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "Update [DM_QuocGia] Set  ma=@ma, name=@name, isAct=@isAct, OrderId=@OrderId "+
                                 " where id='" + record.id + "'";
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@ma", record.ma);
                cmd.Parameters.AddWithValue("@name", record.name);
                cmd.Parameters.AddWithValue("@isAct", record.isAct);
                cmd.Parameters.AddWithValue("@OrderId", record.OrderId);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        public static bool DelDM_QuocGia(DM_QuocGia recode)
        {
            SqlConnection connection = null;
            SqlCommand command = null;

            try
            {
                if (recode == null)
                    return false;

                connection = new SqlConnection();
                connection.ConnectionString = ConnectionString;
                connection.FireInfoMessageEventOnUserErrors = false;
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "DELETE FROM DM_QuocGia WHERE id ='" + recode.id + "'";

                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DelDM_QuocGia");
                return false;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        #endregion

        #region FbAccount
        public static List<FbAccount> LoadFbAccount(string sql)
        {
            SqlConnection cnn = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;
            FbAccount InfoCOMMANDTABLE;
            List<FbAccount> InfoCOMMANDTABLEs = null;

            try
            {
                InfoCOMMANDTABLEs = new List<FbAccount>();

                cnn = new SqlConnection();
                cnn.ConnectionString = ConnectionString;
                cnn.Open();
                cnn.FireInfoMessageEventOnUserErrors = false;

                cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = cnn;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    InfoCOMMANDTABLE = new FbAccount();


                    if (!reader.IsDBNull(0))
                        InfoCOMMANDTABLE.id = reader.GetGuid(0);
                    if (!reader.IsDBNull(1))
                        InfoCOMMANDTABLE.account = reader.GetString(1);
                    if (!reader.IsDBNull(2))
                        InfoCOMMANDTABLE.password = reader.GetString(2);
                    if (!reader.IsDBNull(3))
                        InfoCOMMANDTABLE.token = reader.GetString(3);
                    if (!reader.IsDBNull(4))
                        InfoCOMMANDTABLE.IsAct = reader.GetBoolean(4);

                    InfoCOMMANDTABLEs.Add(InfoCOMMANDTABLE);
                }
                return InfoCOMMANDTABLEs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "LoadFbAccount");
                throw ex;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
        }

        public static bool AddFbAccount(FbAccount record)
        {
            SqlConnection cnn = null;
            SqlCommand cmd = null;

            try
            {
                if (record == null)
                    return false;

                cnn = new SqlConnection();
                cnn.ConnectionString = ConnectionString;
                cnn.FireInfoMessageEventOnUserErrors = false;
                cnn.Open();

                cmd = new SqlCommand();
                cmd.Connection = cnn;
                //--- Insert Record
                cmd.CommandText = "Insert into FbAccount(account, password, token,IsAct) OUTPUT inserted.id " +
                                  " values(@account, @password, @token,@IsAct);";

                
                cmd.Parameters.AddWithValue("@account", record.account);
                cmd.Parameters.AddWithValue("@password", record.password);
                cmd.Parameters.AddWithValue("@token", record.token ==null ? "" : record.token);
                cmd.Parameters.AddWithValue("@IsAct", record.IsAct);
                Guid guid = (Guid)cmd.ExecuteScalar();

                if (guid == null || guid == Guid.Empty)
                    return false;

                record.id = new Guid(guid.ToString());

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
        }

        public static bool UpdateFbAccount(FbAccount record)
        {
            SqlConnection connection = null;
            SqlCommand cmd = null;

            try
            {
                if (record == null)
                    return false;

                // Make connection to database
                connection = new SqlConnection();
                connection.ConnectionString = ConnectionString;
                connection.FireInfoMessageEventOnUserErrors = false;
                connection.Open();
                // Create command to update GeneralGuessGroup record
                cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "Update [FbAccount] Set password=@password, token=@token,IsAct=@IsAct"
                                    + " where account='" + record.account + "'";
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@password", record.password);
                cmd.Parameters.AddWithValue("@token", record.token==null ? "": record.token);
                cmd.Parameters.AddWithValue("@IsAct", record.IsAct);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        public static bool DelFbAccount(FbAccount recode)
        {
            SqlConnection connection = null;
            SqlCommand command = null;

            try
            {
                if (recode == null)
                    return false;

                connection = new SqlConnection();
                connection.ConnectionString = ConnectionString;
                connection.FireInfoMessageEventOnUserErrors = false;
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "DELETE FROM FbAccount WHERE account ='" + recode.account + "'";

                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DelFbAccount");
                return false;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }
        #endregion

        #region FbFriend

        public static bool AddFbFriend(FbFriend record)
        {
            SqlConnection cnn = null;
            SqlCommand cmd = null;

            try
            {
                if (record == null)
                    return false;

                cnn = new SqlConnection();
                cnn.ConnectionString = ConnectionString;
                cnn.FireInfoMessageEventOnUserErrors = false;
                cnn.Open();

                cmd = new SqlCommand();
                cmd.Connection = cnn;
                //--- Insert Record

                cmd.CommandText = "Insert into FbFriend(UID,FriendUid, first_name, last_name, name_format, [name], mobile_phone, birthday, email, gender, location, age_range, cover, devices, education, favorite_athletes, favorite_teams, hometown, install_type, installed, interested_in, is_verified, languages, link, locale, political, quotes, relationship_status, religion, sports, third_party_id, website, work) OUTPUT inserted.id " +
                                  " values(@UID,@FriendUid, @first_name, @last_name, @name_format, @name, @mobile_phone, @birthday, @email, @gender, @location, @age_range, @cover, @devices, @education, @favorite_athletes, @favorite_teams, @hometown, @install_type, @installed, @interested_in, @is_verified, @languages, @link, @locale, @political, @quotes, @relationship_status, @religion, @sports, @third_party_id, @website, @work);";

                cmd.Parameters.AddWithValue("@uid", record.uid);
                cmd.Parameters.AddWithValue("@FriendUid", record.FriendUid);
                cmd.Parameters.AddWithValue("@name", record.name);
                cmd.Parameters.AddWithValue("@first_name", record.first_name);
                cmd.Parameters.AddWithValue("@last_name", record.last_name);
                cmd.Parameters.AddWithValue("@name_format", record.name_format);
                cmd.Parameters.AddWithValue("@mobile_phone", record.mobile_phone);
                cmd.Parameters.AddWithValue("@birthday", record.birthday);
                cmd.Parameters.AddWithValue("@email", record.email);
                cmd.Parameters.AddWithValue("@gender", record.gender);

                if (record.location == null)
                    cmd.Parameters.AddWithValue("@location", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@location", ConvertType.GetXMLFromObject(record.location));

                if (record.age_range == null)
                    cmd.Parameters.AddWithValue("@age_range", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@age_range", ConvertType.GetXMLFromObject(record.age_range));

                if (record.cover == null)
                    cmd.Parameters.AddWithValue("@cover", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@cover", ConvertType.GetXMLFromObject(record.cover));

                if (record.devices == null)
                    cmd.Parameters.AddWithValue("@devices", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@devices", ConvertType.GetXMLFromObject(record.devices));

                if (record.education == null)
                    cmd.Parameters.AddWithValue("@education", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@education", ConvertType.GetXMLFromObject(record.education));

                if (record.favorite_athletes == null)
                    cmd.Parameters.AddWithValue("@favorite_athletes", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@favorite_athletes", ConvertType.GetXMLFromObject(record.favorite_athletes));
                if (record.favorite_teams == null)
                    cmd.Parameters.AddWithValue("@favorite_teams", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@favorite_teams", ConvertType.GetXMLFromObject(record.favorite_teams));
                if (record.hometown == null)
                    cmd.Parameters.AddWithValue("@hometown", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@hometown", ConvertType.GetXMLFromObject(record.hometown));
                cmd.Parameters.AddWithValue("@install_type", record.install_type);
                cmd.Parameters.AddWithValue("@installed", record.installed);
                if (record.interested_in == null)
                    cmd.Parameters.AddWithValue("@interested_in", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@interested_in", ConvertType.GetXMLFromObject(record.interested_in));
                cmd.Parameters.AddWithValue("@is_verified", record.is_verified);
                if (record.languages == null)
                    cmd.Parameters.AddWithValue("@languages", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@languages", ConvertType.GetXMLFromObject(record.languages));
                cmd.Parameters.AddWithValue("@link", record.link);
                cmd.Parameters.AddWithValue("@locale", record.locale);
                cmd.Parameters.AddWithValue("@political", record.political);
                cmd.Parameters.AddWithValue("@quotes", record.quotes);
                cmd.Parameters.AddWithValue("@relationship_status", record.relationship_status);
                cmd.Parameters.AddWithValue("@religion", record.religion);
                if (record.sports == null)
                    cmd.Parameters.AddWithValue("@sports", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@sports", ConvertType.GetXMLFromObject(record.sports));
                cmd.Parameters.AddWithValue("@third_party_id", record.third_party_id);
                cmd.Parameters.AddWithValue("@website", record.website);
                if (record.work == null)
                    cmd.Parameters.AddWithValue("@work", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@work", ConvertType.GetXMLFromObject(record.work));
                Guid guid = (Guid)cmd.ExecuteScalar();

                if (guid == null || guid == Guid.Empty)
                    return false;

                record.id = new Guid(guid.ToString());

                return true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "AddFbFriend");
                return false;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
        }

        public static bool UpdateFbFriend(FbFriend record)
        {
            SqlConnection connection = null;
            SqlCommand cmd = null;

            try
            {
                if (record == null)
                    return false;

                // Make connection to database
                connection = new SqlConnection();
                connection.ConnectionString = ConnectionString;
                connection.FireInfoMessageEventOnUserErrors = false;
                connection.Open();
                // Create command to update GeneralGuessGroup record
                cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = " Update [FbFriend] Set first_name=@first_name, last_name=@last_name, name_format=@name_format, name=@name, mobile_phone=@mobile_phone, birthday=@birthday, email=@email, gender=@gender, location=@location, age_range=@age_range, cover=@cover, devices=@devices, education=@education, favorite_athletes=@favorite_athletes, favorite_teams=@favorite_teams, hometown=@hometown, install_type=@install_type, installed=@installed, interested_in=@interested_in, is_verified=@is_verified, languages=@languages, link=@link, locale=@locale, political=@political, quotes=@quotes, relationship_status=@relationship_status, religion=@religion, sports=@sports, third_party_id=@third_party_id, website=@website, work=@work"
                                + " where uid='" + record.uid + "' and FriendUid='"+record.FriendUid+"'";
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@name", record.name);
                cmd.Parameters.AddWithValue("@first_name", record.first_name);
                cmd.Parameters.AddWithValue("@last_name", record.last_name);
                cmd.Parameters.AddWithValue("@name_format", record.name_format);
                cmd.Parameters.AddWithValue("@mobile_phone", record.mobile_phone);
                cmd.Parameters.AddWithValue("@birthday", record.birthday);
                cmd.Parameters.AddWithValue("@email", record.email);
                cmd.Parameters.AddWithValue("@gender", record.gender);

                if (record.location == null)
                    cmd.Parameters.AddWithValue("@location", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@location", ConvertType.GetXMLFromObject(record.location));

                if (record.age_range == null)
                    cmd.Parameters.AddWithValue("@age_range", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@age_range", ConvertType.GetXMLFromObject(record.age_range));

                if (record.cover == null)
                    cmd.Parameters.AddWithValue("@cover", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@cover", ConvertType.GetXMLFromObject(record.cover));

                if (record.devices == null)
                    cmd.Parameters.AddWithValue("@devices", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@devices", ConvertType.GetXMLFromObject(record.devices));

                if (record.education == null)
                    cmd.Parameters.AddWithValue("@education", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@education", ConvertType.GetXMLFromObject(record.education));

                if (record.favorite_athletes == null)
                    cmd.Parameters.AddWithValue("@favorite_athletes", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@favorite_athletes", ConvertType.GetXMLFromObject(record.favorite_athletes));
                if (record.favorite_teams == null)
                    cmd.Parameters.AddWithValue("@favorite_teams", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@favorite_teams", ConvertType.GetXMLFromObject(record.favorite_teams));
                if (record.hometown == null)
                    cmd.Parameters.AddWithValue("@hometown", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@hometown", ConvertType.GetXMLFromObject(record.hometown));
                cmd.Parameters.AddWithValue("@install_type", record.install_type);
                cmd.Parameters.AddWithValue("@installed", record.installed);
                if (record.interested_in == null)
                    cmd.Parameters.AddWithValue("@interested_in", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@interested_in", ConvertType.GetXMLFromObject(record.interested_in));
                cmd.Parameters.AddWithValue("@is_verified", record.is_verified);
                if (record.languages == null)
                    cmd.Parameters.AddWithValue("@languages", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@languages", ConvertType.GetXMLFromObject(record.languages));
                cmd.Parameters.AddWithValue("@link", record.link);
                cmd.Parameters.AddWithValue("@locale", record.locale);
                cmd.Parameters.AddWithValue("@political", record.political);
                cmd.Parameters.AddWithValue("@quotes", record.quotes);
                cmd.Parameters.AddWithValue("@relationship_status", record.relationship_status);
                cmd.Parameters.AddWithValue("@religion", record.religion);
                if (record.sports == null)
                    cmd.Parameters.AddWithValue("@sports", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@sports", ConvertType.GetXMLFromObject(record.sports));
                cmd.Parameters.AddWithValue("@third_party_id", record.third_party_id);
                cmd.Parameters.AddWithValue("@website", record.website);
                if (record.work == null)
                    cmd.Parameters.AddWithValue("@work", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@work", ConvertType.GetXMLFromObject(record.work));

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "UpdateFbFriend");
                return false;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        #endregion

        #region FbFollow

        public static bool AddFbFollow(FbFriend record)
        {
            SqlConnection cnn = null;
            SqlCommand cmd = null;

            try
            {
                if (record == null)
                    return false;

                cnn = new SqlConnection();
                cnn.ConnectionString = ConnectionString;
                cnn.FireInfoMessageEventOnUserErrors = false;
                cnn.Open();

                cmd = new SqlCommand();
                cmd.Connection = cnn;
                //--- Insert Record

                cmd.CommandText = "Insert into FbFollow(UID,FollowUid, first_name, last_name, name_format, name, mobile_phone, birthday, email, gender, location, age_range, cover, devices, education, favorite_athletes, favorite_teams, hometown, install_type, installed, interested_in, is_verified, languages, link, locale, political, quotes, relationship_status, religion, sports, third_party_id, website, work) OUTPUT inserted.id " +
                                  " values(@UID,@FollowUid, @first_name, @last_name, @name_format, @name, @mobile_phone, @birthday, @email, @gender, @location, @age_range, @cover, @devices, @education, @favorite_athletes, @favorite_teams, @hometown, @install_type, @installed, @interested_in, @is_verified, @languages, @link, @locale, @political, @quotes, @relationship_status, @religion, @sports, @third_party_id, @website, @work);";

                cmd.Parameters.AddWithValue("@uid", record.uid);
                cmd.Parameters.AddWithValue("@FollowUid", record.FriendUid);
                cmd.Parameters.AddWithValue("@name", record.name);
                cmd.Parameters.AddWithValue("@first_name", record.first_name);
                cmd.Parameters.AddWithValue("@last_name", record.last_name);
                cmd.Parameters.AddWithValue("@name_format", record.name_format);
                cmd.Parameters.AddWithValue("@mobile_phone", record.mobile_phone);
                cmd.Parameters.AddWithValue("@birthday", record.birthday);
                cmd.Parameters.AddWithValue("@email", record.email);
                cmd.Parameters.AddWithValue("@gender", record.gender);

                if (record.location == null)
                    cmd.Parameters.AddWithValue("@location", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@location", ConvertType.GetXMLFromObject(record.location));

                if (record.age_range == null)
                    cmd.Parameters.AddWithValue("@age_range", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@age_range", ConvertType.GetXMLFromObject(record.age_range));

                if (record.cover == null)
                    cmd.Parameters.AddWithValue("@cover", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@cover", ConvertType.GetXMLFromObject(record.cover));

                if (record.devices == null)
                    cmd.Parameters.AddWithValue("@devices", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@devices", ConvertType.GetXMLFromObject(record.devices));

                if (record.education == null)
                    cmd.Parameters.AddWithValue("@education", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@education", ConvertType.GetXMLFromObject(record.education));

                if (record.favorite_athletes == null)
                    cmd.Parameters.AddWithValue("@favorite_athletes", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@favorite_athletes", ConvertType.GetXMLFromObject(record.favorite_athletes));
                if (record.favorite_teams == null)
                    cmd.Parameters.AddWithValue("@favorite_teams", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@favorite_teams", ConvertType.GetXMLFromObject(record.favorite_teams));
                if (record.hometown == null)
                    cmd.Parameters.AddWithValue("@hometown", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@hometown", ConvertType.GetXMLFromObject(record.hometown));
                cmd.Parameters.AddWithValue("@install_type", record.install_type);
                cmd.Parameters.AddWithValue("@installed", record.installed);
                if (record.interested_in == null)
                    cmd.Parameters.AddWithValue("@interested_in", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@interested_in", ConvertType.GetXMLFromObject(record.interested_in));
                cmd.Parameters.AddWithValue("@is_verified", record.is_verified);
                if (record.languages == null)
                    cmd.Parameters.AddWithValue("@languages", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@languages", ConvertType.GetXMLFromObject(record.languages));
                cmd.Parameters.AddWithValue("@link", record.link);
                cmd.Parameters.AddWithValue("@locale", record.locale);
                cmd.Parameters.AddWithValue("@political", record.political);
                cmd.Parameters.AddWithValue("@quotes", record.quotes);
                cmd.Parameters.AddWithValue("@relationship_status", record.relationship_status);
                cmd.Parameters.AddWithValue("@religion", record.religion);
                if (record.sports == null)
                    cmd.Parameters.AddWithValue("@sports", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@sports", ConvertType.GetXMLFromObject(record.sports));
                cmd.Parameters.AddWithValue("@third_party_id", record.third_party_id);
                cmd.Parameters.AddWithValue("@website", record.website);
                if (record.work == null)
                    cmd.Parameters.AddWithValue("@work", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@work", ConvertType.GetXMLFromObject(record.work));
                Guid guid = (Guid)cmd.ExecuteScalar();

                if (guid == null || guid == Guid.Empty)
                    return false;

                record.id = new Guid(guid.ToString());

                return true;
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message, "AddFbFollow");
                return false;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
        }

        public static bool UpdateFbFollow(FbFriend record)
        {
            SqlConnection connection = null;
            SqlCommand cmd = null;

            try
            {
                if (record == null)
                    return false;

                // Make connection to database
                connection = new SqlConnection();
                connection.ConnectionString = ConnectionString;
                connection.FireInfoMessageEventOnUserErrors = false;
                connection.Open();
                // Create command to update GeneralGuessGroup record
                cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = " Update [FbFollow] Set first_name=@first_name, last_name=@last_name, name_format=@name_format, name=@name, mobile_phone=@mobile_phone, birthday=@birthday, email=@email, gender=@gender, location=@location, age_range=@age_range, cover=@cover, devices=@devices, education=@education, favorite_athletes=@favorite_athletes, favorite_teams=@favorite_teams, hometown=@hometown, install_type=@install_type, installed=@installed, interested_in=@interested_in, is_verified=@is_verified, languages=@languages, link=@link, locale=@locale, political=@political, quotes=@quotes, relationship_status=@relationship_status, religion=@religion, sports=@sports, third_party_id=@third_party_id, website=@website, work=@work"
                                + " where uid='" + record.uid + "' and FollowUid='" + record.FriendUid + "'";
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@name", record.name);
                cmd.Parameters.AddWithValue("@first_name", record.first_name);
                cmd.Parameters.AddWithValue("@last_name", record.last_name);
                cmd.Parameters.AddWithValue("@name_format", record.name_format);
                cmd.Parameters.AddWithValue("@mobile_phone", record.mobile_phone);
                cmd.Parameters.AddWithValue("@birthday", record.birthday);
                cmd.Parameters.AddWithValue("@email", record.email);
                cmd.Parameters.AddWithValue("@gender", record.gender);

                if (record.location == null)
                    cmd.Parameters.AddWithValue("@location", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@location", ConvertType.GetXMLFromObject(record.location));

                if (record.age_range == null)
                    cmd.Parameters.AddWithValue("@age_range", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@age_range", ConvertType.GetXMLFromObject(record.age_range));

                if (record.cover == null)
                    cmd.Parameters.AddWithValue("@cover", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@cover", ConvertType.GetXMLFromObject(record.cover));

                if (record.devices == null)
                    cmd.Parameters.AddWithValue("@devices", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@devices", ConvertType.GetXMLFromObject(record.devices));

                if (record.education == null)
                    cmd.Parameters.AddWithValue("@education", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@education", ConvertType.GetXMLFromObject(record.education));

                if (record.favorite_athletes == null)
                    cmd.Parameters.AddWithValue("@favorite_athletes", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@favorite_athletes", ConvertType.GetXMLFromObject(record.favorite_athletes));
                if (record.favorite_teams == null)
                    cmd.Parameters.AddWithValue("@favorite_teams", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@favorite_teams", ConvertType.GetXMLFromObject(record.favorite_teams));
                if (record.hometown == null)
                    cmd.Parameters.AddWithValue("@hometown", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@hometown", ConvertType.GetXMLFromObject(record.hometown));
                cmd.Parameters.AddWithValue("@install_type", record.install_type);
                cmd.Parameters.AddWithValue("@installed", record.installed);
                if (record.interested_in == null)
                    cmd.Parameters.AddWithValue("@interested_in", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@interested_in", ConvertType.GetXMLFromObject(record.interested_in));
                cmd.Parameters.AddWithValue("@is_verified", record.is_verified);
                if (record.languages == null)
                    cmd.Parameters.AddWithValue("@languages", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@languages", ConvertType.GetXMLFromObject(record.languages));
                cmd.Parameters.AddWithValue("@link", record.link);
                cmd.Parameters.AddWithValue("@locale", record.locale);
                cmd.Parameters.AddWithValue("@political", record.political);
                cmd.Parameters.AddWithValue("@quotes", record.quotes);
                cmd.Parameters.AddWithValue("@relationship_status", record.relationship_status);
                cmd.Parameters.AddWithValue("@religion", record.religion);
                if (record.sports == null)
                    cmd.Parameters.AddWithValue("@sports", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@sports", ConvertType.GetXMLFromObject(record.sports));
                cmd.Parameters.AddWithValue("@third_party_id", record.third_party_id);
                cmd.Parameters.AddWithValue("@website", record.website);
                if (record.work == null)
                    cmd.Parameters.AddWithValue("@work", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@work", ConvertType.GetXMLFromObject(record.work));

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "UpdateFollowUid");
                return false;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        #endregion

        #region FbUID

        public static bool AddFbUID(FbUID record)
        {
            SqlConnection cnn = null;
            SqlCommand cmd = null;

            try
            {
                if (record == null)
                    return false;

                cnn = new SqlConnection();
                cnn.ConnectionString = ConnectionString;
                cnn.FireInfoMessageEventOnUserErrors = false;
                cnn.Open();

                cmd = new SqlCommand();
                cmd.Connection = cnn;
                //--- Insert Record
              
                cmd.CommandText = "Insert into FbUID(UID, name, age_ranges, educations, location, mobile_phone, birthday, gender, locale, relationship_status, currency, email, cover, devices,[work]) OUTPUT inserted.id " +
                                  " values(@UID, @name, @age_ranges, @educations, @location, @mobile_phone, @birthday, @gender, @locale, @relationship_status, @currency, @email, @cover, @devices, @work);";


              

                cmd.Parameters.AddWithValue("@UID", record.uid);
                cmd.Parameters.AddWithValue("@name", record.name);
                if (record.age_ranges == null)
                    cmd.Parameters.AddWithValue("@age_ranges", SqlXml.Null);
                else
                   cmd.Parameters.AddWithValue("@age_ranges", ConvertType.GetXMLFromObject(record.age_ranges));
                
                if (record.educations == null)
                    cmd.Parameters.AddWithValue("@educations", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@educations", ConvertType.GetXMLFromObject(record.educations));
                if (record.location == null)
                    cmd.Parameters.AddWithValue("@location", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@location", ConvertType.GetXMLFromObject(record.location));

                cmd.Parameters.AddWithValue("@mobile_phone", record.mobile_phone);
                cmd.Parameters.AddWithValue("@birthday", record.birthday);
                cmd.Parameters.AddWithValue("@gender", record.gender);
                cmd.Parameters.AddWithValue("@locale", record.locale);
                cmd.Parameters.AddWithValue("@relationship_status", record.relationship_status);
                cmd.Parameters.AddWithValue("@currency", record.currency);
                cmd.Parameters.AddWithValue("@email", record.email);

                if (record.cover == null)
                    cmd.Parameters.AddWithValue("@cover", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@cover", ConvertType.GetXMLFromObject(record.cover));

                if (record.devices == null)
                    cmd.Parameters.AddWithValue("@devices", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@devices", ConvertType.GetXMLFromObject(record.devices));

                if (record.work == null)
                    cmd.Parameters.AddWithValue("@work", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@work", ConvertType.GetXMLFromObject(record.work));
                    
                Guid guid = (Guid)cmd.ExecuteScalar();
                if (guid == null || guid == Guid.Empty)
                    return false;

                record.id = new Guid(guid.ToString());

                return true;
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message, "AddFbUID");
                return false;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
        }
        public static bool UpFbUID(FbUID record)
        {
            SqlConnection connection = null;
            SqlCommand cmd = null;

            try
            {
                if (record == null)
                    return false;

                // Make connection to database
                connection = new SqlConnection();
                connection.ConnectionString = ConnectionString;
                connection.FireInfoMessageEventOnUserErrors = false;
                connection.Open();
                // Create command to update GeneralGuessGroup record
                cmd = new SqlCommand();
                cmd.Connection = connection;
                //id, uid, urd, createdate
                cmd.CommandText = "Update [FbUID] Set  name=@name, age_ranges=@age_ranges, educations=@educations, location=@location, mobile_phone=@mobile_phone, birthday=@birthday, gender=@gender, locale=@locale, relationship_status=@relationship_status, currency=@currency, email=@email, cover=@cover, devices=@devices"
                                    + " where UID='" + record.uid + "'";
                cmd.CommandType = CommandType.Text;
              
                cmd.Parameters.AddWithValue("@name", record.name);
                if (record.age_ranges == null)
                    cmd.Parameters.AddWithValue("@age_ranges", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@age_ranges", ConvertType.GetXMLFromObject(record.age_ranges));

                if (record.educations == null)
                    cmd.Parameters.AddWithValue("@educations", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@educations", ConvertType.GetXMLFromObject(record.educations));
                if (record.location == null)
                    cmd.Parameters.AddWithValue("@location", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@location", ConvertType.GetXMLFromObject(record.location));

                cmd.Parameters.AddWithValue("@mobile_phone", record.mobile_phone);
                cmd.Parameters.AddWithValue("@birthday", record.birthday);
                cmd.Parameters.AddWithValue("@gender", record.gender);
                cmd.Parameters.AddWithValue("@locale", record.locale);
                cmd.Parameters.AddWithValue("@relationship_status", record.relationship_status);
                cmd.Parameters.AddWithValue("@currency", record.currency);
                cmd.Parameters.AddWithValue("@email", record.email);

                if (record.cover == null)
                    cmd.Parameters.AddWithValue("@cover", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@cover", ConvertType.GetXMLFromObject(record.cover));

                if (record.devices == null)
                    cmd.Parameters.AddWithValue("@devices", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@devices", ConvertType.GetXMLFromObject(record.devices));

                if (record.work == null)
                    cmd.Parameters.AddWithValue("@work", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@work", ConvertType.GetXMLFromObject(record.work));


                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "UpFbUID");
                return false;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }


        #endregion

        #region FbPage

        public static bool AddFbPage(FbPage record)
        {
            SqlConnection cnn = null;
            SqlCommand cmd = null;

            try
            {
                if (record == null)
                    return false;

                cnn = new SqlConnection();
                cnn.ConnectionString = ConnectionString;
                cnn.FireInfoMessageEventOnUserErrors = false;
                cnn.Open();

                cmd = new SqlCommand();
                cmd.Connection = cnn;
                //--- Insert Record

                cmd.CommandText = "Insert into FbPage(UID, name, app_links, about) OUTPUT inserted.id " +
                                  " values(@UID, @name, @app_links, @about);";

                cmd.Parameters.AddWithValue("@UID", record.uid);
                cmd.Parameters.AddWithValue("@name", record.name);
                if (record.app_Links == null)
                    cmd.Parameters.AddWithValue("@app_links", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@app_links", ConvertType.GetXMLFromObject(record.app_Links));
                cmd.Parameters.AddWithValue("@about", record.about);

                Guid guid = (Guid)cmd.ExecuteScalar();
                if (guid == null || guid == Guid.Empty)
                    return false;

                record.id = new Guid(guid.ToString());

                return true;
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message, "AddFbPage");
                return false;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
        }
        public static bool UpFbPage(FbPage record)
        {
            SqlConnection connection = null;
            SqlCommand cmd = null;

            try
            {
                if (record == null)
                    return false;

                // Make connection to database
                connection = new SqlConnection();
                connection.ConnectionString = ConnectionString;
                connection.FireInfoMessageEventOnUserErrors = false;
                connection.Open();
                // Create command to update GeneralGuessGroup record
                cmd = new SqlCommand();
                cmd.Connection = connection;
                //id, uid, urd, createdate
                cmd.CommandText = " Update [FbPage] Set name=@name, app_links =@app_links, about =@about "
                                + " where UID='" + record.uid + "'";
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@name", record.name);
                cmd.Parameters.AddWithValue("@about", record.about);
                if (record.app_Links == null)
                    cmd.Parameters.AddWithValue("@app_links", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@app_links", ConvertType.GetXMLFromObject(record.app_Links));

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message, "UpFbPage");
                return false;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }


        #endregion

        #region FbGUI

        public static bool AddFbGUI(FbGUI record)
        {
            SqlConnection cnn = null;
            SqlCommand cmd = null;

            try
            {
                if (record == null)
                    return false;

                cnn = new SqlConnection();
                cnn.ConnectionString = ConnectionString;
                cnn.FireInfoMessageEventOnUserErrors = false;
                cnn.Open();

                cmd = new SqlCommand();
                cmd.Connection = cnn;
                //--- Insert Record

                cmd.CommandText = "Insert into FbGUI(UID, name, description, email, icon, member_request_count, owner, privacy, updated_time) OUTPUT inserted.id " +
                                  " values(@UID, @name, @description, @email, @icon, @member_request_count, @owner, @privacy, @updated_time);";

                cmd.Parameters.AddWithValue("@UID", record.uid);
                cmd.Parameters.AddWithValue("@name", record.name);
                cmd.Parameters.AddWithValue("@description", record.description);
                cmd.Parameters.AddWithValue("@email", record.email);
                cmd.Parameters.AddWithValue("@icon", record.icon);
                cmd.Parameters.AddWithValue("@member_request_count", record.member_request_count);
                if (record.owner == null)
                    cmd.Parameters.AddWithValue("@owner", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@owner", ConvertType.GetXMLFromObject(record.owner));
                cmd.Parameters.AddWithValue("@privacy", record.privacy);
                cmd.Parameters.AddWithValue("@updated_time", record.updated_time);

                Guid guid = (Guid)cmd.ExecuteScalar();
                if (guid == null || guid == Guid.Empty)
                    return false;

                record.id = new Guid(guid.ToString());

                return true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "AddFbGUI"); 
                return false;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
        }
        public static bool UpFbGUI(FbGUI record)
        {
            SqlConnection connection = null;
            SqlCommand cmd = null;

            try
            {
                if (record == null)
                    return false;

                // Make connection to database
                connection = new SqlConnection();
                connection.ConnectionString = ConnectionString;
                connection.FireInfoMessageEventOnUserErrors = false;
                connection.Open();
                // Create command to update GeneralGuessGroup record
                cmd = new SqlCommand();
                cmd.Connection = connection;
                //id, uid, urd, createdate
                cmd.CommandText = " Update [FbGUI] Set name=@name, description=@description, email=@email, icon=@icon, member_request_count=@member_request_count, owner=@owner, privacy=@privacy, updated_time=@updated_time "
                                + " where UID='" + record.uid + "'";
                cmd.CommandType = CommandType.Text;

                //cmd.Parameters.AddWithValue("@UID", record.uid);
                cmd.Parameters.AddWithValue("@name", record.name);
                cmd.Parameters.AddWithValue("@description", record.description);
                cmd.Parameters.AddWithValue("@email", record.email);
                cmd.Parameters.AddWithValue("@icon", record.icon);
                cmd.Parameters.AddWithValue("@member_request_count", record.member_request_count);
                if (record.owner == null)
                    cmd.Parameters.AddWithValue("@owner", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@owner", ConvertType.GetXMLFromObject(record.owner));
                cmd.Parameters.AddWithValue("@privacy", record.privacy);
                cmd.Parameters.AddWithValue("@updated_time", record.updated_time);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message, "UpFbGUI");
                return false;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }


        #endregion

        #region Nhom
        public static List<NhomUID> LoadNhomUID(string sql)
        {
            SqlConnection cnn = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;
            NhomUID InfoCOMMANDTABLE;
            List<NhomUID> InfoCOMMANDTABLEs = null;

            try
            {
                InfoCOMMANDTABLEs = new List<NhomUID>();

                cnn = new SqlConnection();
                cnn.ConnectionString = ConnectionString;
                cnn.Open();
                cnn.FireInfoMessageEventOnUserErrors = false;

                cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Connection = cnn;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    InfoCOMMANDTABLE = new NhomUID();
                    //id, ParentId, Name, UID, URD, Note, IsActi, IsPage, OrderID, CreateDate

                    if (!reader.IsDBNull(0))
                        InfoCOMMANDTABLE.id = reader.GetGuid(0);
                    if (!reader.IsDBNull(1))
                        InfoCOMMANDTABLE.ParentId = reader.GetGuid(1);
                    if (!reader.IsDBNull(2))
                        InfoCOMMANDTABLE.Name = reader.GetString(2);
                    if (!reader.IsDBNull(3))
                        InfoCOMMANDTABLE.UID = reader.GetString(3);
                    if (!reader.IsDBNull(4))
                        InfoCOMMANDTABLE.URD = reader.GetString(4);
                    if (!reader.IsDBNull(5))
                        InfoCOMMANDTABLE.Note = reader.GetString(5);
                    if (!reader.IsDBNull(6))
                        InfoCOMMANDTABLE.IsActi = reader.GetBoolean(6);
                    if (!reader.IsDBNull(7))
                        InfoCOMMANDTABLE.IsLoai = reader.GetInt32(7);
                    if (!reader.IsDBNull(8))
                        InfoCOMMANDTABLE.OrderID = reader.GetInt32(8);
                    if (!reader.IsDBNull(9))
                        InfoCOMMANDTABLE.CreateDate = reader.GetDateTime(9);

                    InfoCOMMANDTABLEs.Add(InfoCOMMANDTABLE);
                }
                return InfoCOMMANDTABLEs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "LoadNhomUID");
                throw ex;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
        }

        public static bool AddNhomUID(NhomUID record)
        {
            SqlConnection cnn = null;
            SqlCommand cmd = null;

            try
            {
                if (record == null)
                    return false;

                cnn = new SqlConnection();
                cnn.ConnectionString = ConnectionString;
                cnn.FireInfoMessageEventOnUserErrors = false;
                cnn.Open();

                cmd = new SqlCommand();
                cmd.Connection = cnn;
                //--- Insert Record
                cmd.CommandText = "Insert into NhomUID(ParentId, Name, UID, URD, Note, IsActi,IsLoai, OrderID) OUTPUT inserted.id " +
                                    "values(@ParentId, @Name, @UID, @URD, @Note, @IsActi,@IsLoai, @OrderID);";
                                    

                if (record.ParentId == null)
                    cmd.Parameters.AddWithValue("@ParentId", SqlGuid.Null);
                else
                    cmd.Parameters.AddWithValue("@ParentId", record.ParentId);

                cmd.Parameters.AddWithValue("@Name", record.Name);
                cmd.Parameters.AddWithValue("@UID", record.UID);
                cmd.Parameters.AddWithValue("@URD", record.URD);
                cmd.Parameters.AddWithValue("@Note", record.Note==null ? "": record.Note);
                cmd.Parameters.AddWithValue("@IsActi", record.IsActi);
                cmd.Parameters.AddWithValue("@IsLoai", record.IsLoai);
                cmd.Parameters.AddWithValue("@OrderID", record.OrderID);
                Guid guid = (Guid)cmd.ExecuteScalar();

                if (guid == null || guid == Guid.Empty)
                    return false;

                record.id = new Guid(guid.ToString());

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "AddNhomUID");
                return false;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
        }

        public static bool UpNhomUID(NhomUID record)
        {
            SqlConnection connection = null;
            SqlCommand cmd = null;

            try
            {
                if (record == null)
                    return false;

                // Make connection to database
                connection = new SqlConnection();
                connection.ConnectionString = ConnectionString;
                connection.FireInfoMessageEventOnUserErrors = false;
                connection.Open();
                // Create command to update GeneralGuessGroup record
                cmd = new SqlCommand();
                cmd.Connection = connection;
                //id, uid, urd, createdate
                //id, ParentId, Name, UID, URD, Note, IsActi, IsPage, OrderID, CreateDate
                cmd.CommandText = "Update [NhomUID] Set ParentId=@ParentId,Name=@Name, UID=@UID,URD=@URD,Note=@Note,IsActi=@IsActi,IsLoai=@IsLoai,OrderID=@OrderID"
                                    + " where ID='" + record.id + "'";
                cmd.CommandType = CommandType.Text;
                if (record.ParentId == null)
                    cmd.Parameters.AddWithValue("@ParentId", SqlGuid.Null);
                else
                    cmd.Parameters.AddWithValue("@ParentId", record.ParentId);

                cmd.Parameters.AddWithValue("@Name", record.Name);
                cmd.Parameters.AddWithValue("@UID", record.UID);
                cmd.Parameters.AddWithValue("@URD", record.URD);
                cmd.Parameters.AddWithValue("@Note", record.Note);
                cmd.Parameters.AddWithValue("@IsActi", record.IsActi);
                cmd.Parameters.AddWithValue("@IsLoai", record.IsLoai);
                cmd.Parameters.AddWithValue("@OrderID", record.OrderID);


                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "UpNhomUID");
                return false;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        public static bool UpNhomUIDByUid(NhomUID record)
        {
            SqlConnection connection = null;
            SqlCommand cmd = null;

            try
            {
                if (record == null)
                    return false;

                // Make connection to database
                connection = new SqlConnection();
                connection.ConnectionString = ConnectionString;
                connection.FireInfoMessageEventOnUserErrors = false;
                connection.Open();
                // Create command to update GeneralGuessGroup record
                cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "Update [NhomUID] Set Name=@Name, URD=@URD,Note=@Note,IsActi=@IsActi,IsPage=@IsPage,OrderID=@OrderID"
                                    + " where uid='" + record.UID + "'";
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@Name", record.Name);
                cmd.Parameters.AddWithValue("@URD", record.URD);
                cmd.Parameters.AddWithValue("@Note", record.Note);
                cmd.Parameters.AddWithValue("@IsActi", record.IsActi);
                cmd.Parameters.AddWithValue("@OrderID", record.OrderID);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "UpNhomUIDByUid");
                return false;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        public static bool DelNhomUID(NhomUID recode)
        {
            SqlConnection connection = null;
            SqlCommand command = null;

            try
            {
                if (recode == null)
                    return false;

                connection = new SqlConnection();
                connection.ConnectionString = ConnectionString;
                connection.FireInfoMessageEventOnUserErrors = false;
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "DELETE FROM NhomUID WHERE id ='" + recode.id + "'";

                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DelNhomUID");
                return false;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        #endregion

        #region FbFeed

        public static bool AddFbFeed(FbFeed record)
        {
            SqlConnection cnn = null;
            SqlCommand cmd = null;

            try
            {
                if (record == null)
                    return false;

                cnn = new SqlConnection();
                cnn.ConnectionString = ConnectionString;
                cnn.FireInfoMessageEventOnUserErrors = false;
                cnn.Open();

                cmd = new SqlCommand();
                cmd.Connection = cnn;
                //--- Insert Record




        cmd.CommandText = "Insert into FbFeed(UID, feedId, [from],    message, message_tags, with_tags, story,  story_tags, picture, link, name, description, actions, privacy, [type], status_type, object_id, created_time, update_time, is_hidden, is_expired, likes, comments) OUTPUT inserted.id " +
                                        " values(@UID, @feedId, @from,@message,@message_tags,@with_tags, @story,@story_tags, @picture, @link, @name, @description, @actions, @privacy, @type, @status_type, @object_id, @created_time, @update_time, @is_hidden, @is_expired, @likes, @comments);";

                cmd.Parameters.AddWithValue("@UID", record.uid);
                cmd.Parameters.AddWithValue("@feedId", record.feedid);
                if (record.from == null)
                    cmd.Parameters.AddWithValue("@from", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@from", ConvertType.GetXMLFromObject(record.from));
                cmd.Parameters.AddWithValue("@message", record.message);
                if (record.message_tags == null)
                    cmd.Parameters.AddWithValue("@message_tags", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@message_tags", ConvertType.GetXMLFromObject(record.message_tags));
                if (record.story_tags == null)
                    cmd.Parameters.AddWithValue("@story_tags", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@story_tags", ConvertType.GetXMLFromObject(record.story_tags));
                cmd.Parameters.AddWithValue("@story", record.story);
                if (record.with_tags == null)
                    cmd.Parameters.AddWithValue("@with_tags", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@with_tags", ConvertType.GetXMLFromObject(record.with_tags));
                cmd.Parameters.AddWithValue("@picture", record.picture);
                cmd.Parameters.AddWithValue("@link", record.link);
                cmd.Parameters.AddWithValue("@name", record.name);
                cmd.Parameters.AddWithValue("@description", record.description);
                if (record.actions == null)
                    cmd.Parameters.AddWithValue("@actions", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@actions", ConvertType.GetXMLFromObject(record.actions));
                if (record.privacy == null)
                    cmd.Parameters.AddWithValue("@privacy", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@privacy", ConvertType.GetXMLFromObject(record.privacy));
                cmd.Parameters.AddWithValue("@type", record.type);
                cmd.Parameters.AddWithValue("@status_type", record.status_type);
                cmd.Parameters.AddWithValue("@object_id", record.object_id);
                cmd.Parameters.AddWithValue("@created_time", record.created_time);
                cmd.Parameters.AddWithValue("@update_time", record.updated_time);
                cmd.Parameters.AddWithValue("@is_hidden", record.is_hidden);
                cmd.Parameters.AddWithValue("@is_expired", record.is_expired);
                if (record.likes == null)
                    cmd.Parameters.AddWithValue("@likes", SqlInt32.Null);
                else
                    cmd.Parameters.AddWithValue("@likes", record.likes.count);
                if (record.comments == null)
                    cmd.Parameters.AddWithValue("@comments", SqlInt32.Null);
                else
                    cmd.Parameters.AddWithValue("@comments", record.comments.count);
                Guid guid = (Guid)cmd.ExecuteScalar();
                if (guid == null || guid == Guid.Empty)
                    return false;

                record.id = new Guid(guid.ToString());

                return true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "AddFbFeed");
                return false;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
        }
        public static bool UpFbFeed(FbFeed record)
        {
            SqlConnection connection = null;
            SqlCommand cmd = null;

            try
            {
                if (record == null)
                    return false;

                // Make connection to database
                connection = new SqlConnection();
                connection.ConnectionString = ConnectionString;
                connection.FireInfoMessageEventOnUserErrors = false;
                connection.Open();
                // Create command to update GeneralGuessGroup record
                cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = " Update [FbFeed] Set [from]=@from, message=@message,message_tags=@message_tags,with_tags=@with_tags,story=@story,story_tags=@story_tags, picture=@picture, link=@link, name=@name, description=@description, actions=@actions, privacy=@privacy, type=@type, status_type=@status_type, object_id=@object_id, created_time=@created_time, update_time=@update_time, is_hidden=@is_hidden, is_expired=@is_expired, likes=@likes, comments=@comments "
                                + " where feedId= '"+record.feedid+"'";
                cmd.CommandType = CommandType.Text;

                if (record.from == null)
                    cmd.Parameters.AddWithValue("@from", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@from", ConvertType.GetXMLFromObject(record.from));
                cmd.Parameters.AddWithValue("@message", record.message);
                if (record.message_tags == null)
                    cmd.Parameters.AddWithValue("@message_tags", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@message_tags", ConvertType.GetXMLFromObject(record.message_tags));
                if (record.story_tags == null)
                    cmd.Parameters.AddWithValue("@story_tags", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@story_tags", ConvertType.GetXMLFromObject(record.story_tags));
                cmd.Parameters.AddWithValue("@story", record.story);
                if (record.with_tags == null)
                    cmd.Parameters.AddWithValue("@with_tags", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@with_tags", ConvertType.GetXMLFromObject(record.with_tags));
                cmd.Parameters.AddWithValue("@picture", record.picture);
                cmd.Parameters.AddWithValue("@link", record.link);
                cmd.Parameters.AddWithValue("@name", record.name);
                cmd.Parameters.AddWithValue("@description", record.description);
                if (record.actions == null)
                    cmd.Parameters.AddWithValue("@actions", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@actions", ConvertType.GetXMLFromObject(record.actions));
                if (record.privacy == null)
                    cmd.Parameters.AddWithValue("@privacy", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@privacy", ConvertType.GetXMLFromObject(record.privacy));
                cmd.Parameters.AddWithValue("@type", record.type);
                cmd.Parameters.AddWithValue("@status_type", record.status_type);
                cmd.Parameters.AddWithValue("@object_id", record.object_id);
                cmd.Parameters.AddWithValue("@created_time", record.created_time);
                cmd.Parameters.AddWithValue("@update_time", record.updated_time);
                cmd.Parameters.AddWithValue("@is_hidden", record.is_hidden);
                cmd.Parameters.AddWithValue("@is_expired", record.is_expired);
                if (record.likes == null)
                    cmd.Parameters.AddWithValue("@likes", SqlInt32.Null);
                else
                    cmd.Parameters.AddWithValue("@likes", record.likes.count);
                if (record.comments == null)
                    cmd.Parameters.AddWithValue("@comments", SqlInt32.Null);
                else
                    cmd.Parameters.AddWithValue("@comments", record.comments.count);


                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "UpFbFeed");
                return false;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }


        #endregion


        #region FbLike
        public static bool AddFbLike(FbLike record)
        {
            SqlConnection cnn = null;
            SqlCommand cmd = null;

            try
            {
                if (record == null)
                    return false;

                cnn = new SqlConnection();
                cnn.ConnectionString = ConnectionString;
                cnn.FireInfoMessageEventOnUserErrors = false;
                cnn.Open();

                cmd = new SqlCommand();
                cmd.Connection = cnn;
                //--- Insert Record
                cmd.CommandText = " Insert into FbLike(uid, feedid, likeid, first_name, last_name, username, gender, link, location, locale, updated_time, education, favorite_athletes, favorite_teams,                relationship_status, work, can_post, category,    category_list, cover,     has_added_app, is_published, likes, name, talking_about_count, were_here_count) OUTPUT inserted.id " +
                                  " values(            @uid, @feedid, @likeid, @first_name, @last_name, @username, @gender, @link, @location, @locale, @updated_time, @education, @favorite_athletes, @favorite_teams, @relationship_status, @work, @can_post, @category, @category_list, @cover, @has_added_app, @is_published, @likes, @name, @talking_about_count, @were_here_count);";

                //cmd.CommandText = " Insert into FbLike(uid, feedid, likeid, first_name,last_name,  gender, link) OUTPUT inserted.id " +
                //                 " values(            @uid, @feedid, @likeid, @first_name, @last_name,  @gender, @link);";

                cmd.Parameters.AddWithValue("@uid", record.uid);
                cmd.Parameters.AddWithValue("@feedid", record.feedid);
                cmd.Parameters.AddWithValue("@likeid", record.likeid);
                cmd.Parameters.AddWithValue("@first_name", record.first_name);
                cmd.Parameters.AddWithValue("@last_name", record.last_name);
                cmd.Parameters.AddWithValue("@username", record.username);
                cmd.Parameters.AddWithValue("@gender", record.gender);
                cmd.Parameters.AddWithValue("@link", record.link);
                if (record.location == null)
                    cmd.Parameters.AddWithValue("@location", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@location", ConvertType.GetXMLFromObject(record.location));
                cmd.Parameters.AddWithValue("@locale", record.locale);
                cmd.Parameters.AddWithValue("@updated_time", record.updated_time);
                if (record.education == null)
                    cmd.Parameters.AddWithValue("@education", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@education", ConvertType.GetXMLFromObject(record.education));
                if (record.favorite_athletes == null)
                    cmd.Parameters.AddWithValue("@favorite_athletes", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@favorite_athletes", ConvertType.GetXMLFromObject(record.favorite_athletes));
                if (record.favorite_teams == null)
                    cmd.Parameters.AddWithValue("@favorite_teams", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@favorite_teams", ConvertType.GetXMLFromObject(record.favorite_teams));
                cmd.Parameters.AddWithValue("@relationship_status", record.relationship_status);
                if (record.work == null)
                    cmd.Parameters.AddWithValue("@work", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@work", ConvertType.GetXMLFromObject(record.work));

                cmd.Parameters.AddWithValue("@can_post", record.can_post);
                cmd.Parameters.AddWithValue("@category", record.category);
                if (record.category_list == null)
                    cmd.Parameters.AddWithValue("@category_list", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@category_list", ConvertType.GetXMLFromObject(record.category_list));
                if (record.cover == null)
                    cmd.Parameters.AddWithValue("@cover", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@cover", ConvertType.GetXMLFromObject(record.cover));
                cmd.Parameters.AddWithValue("@has_added_app", record.has_added_app);
                cmd.Parameters.AddWithValue("@is_published", record.is_published);
                cmd.Parameters.AddWithValue("@likes", record.likes);
                cmd.Parameters.AddWithValue("@name", record.name);
                cmd.Parameters.AddWithValue("@talking_about_count", record.talking_about_count);
                cmd.Parameters.AddWithValue("@were_here_count", record.were_here_count);

                Guid guid = (Guid)cmd.ExecuteScalar();

                if (guid == null || guid == Guid.Empty)
                    return false;

                record.id = new Guid(guid.ToString());

                return true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "AddFbLike");
                return false;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
        }

        public static bool UpFbLike(FbLike record)
        {
            SqlConnection connection = null;
            SqlCommand cmd = null;

            try
            {
                if (record == null)
                    return false;

                // Make connection to database
                connection = new SqlConnection();
                connection.ConnectionString = ConnectionString;
                connection.FireInfoMessageEventOnUserErrors = false;
                connection.Open();
                // Create command to update GeneralGuessGroup record
                cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "Update [FbLike] Set  first_name=@first_name, last_name=@last_name, username=@username, gender=@gender, link=@link, location=@location, locale=@locale, updated_time=@updated_time, education=@education, favorite_athletes=@favorite_athletes, favorite_teams=@favorite_teams, relationship_status=@relationship_status, work=@work, can_post=@can_post, category=@category, category_list=@category_list, cover=@cover, has_added_app=@has_added_app, is_published=@is_published, likes=@likes, name=@name, talking_about_count=@talking_about_count, were_here_count=@were_here_count "
                                    + " where uid='" + record.uid + "' and feedid='"+ record.feedid + "' and likeid='" + record.likeid+"'";


                //cmd.Parameters.AddWithValue("@uid", record.uid);
                //cmd.Parameters.AddWithValue("@feedid", record.feedid);
                //cmd.Parameters.AddWithValue("@likeid", record.likeid);
                cmd.Parameters.AddWithValue("@first_name", record.first_name);
                cmd.Parameters.AddWithValue("@last_name", record.last_name);
                cmd.Parameters.AddWithValue("@username", record.username);
                cmd.Parameters.AddWithValue("@gender", record.gender);
                cmd.Parameters.AddWithValue("@link", record.link);
                if (record.location == null)
                    cmd.Parameters.AddWithValue("@location", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@location", ConvertType.GetXMLFromObject(record.location));
                cmd.Parameters.AddWithValue("@locale", record.locale);
                cmd.Parameters.AddWithValue("@updated_time", record.updated_time);
                if (record.education == null)
                    cmd.Parameters.AddWithValue("@education", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@education", ConvertType.GetXMLFromObject(record.education));
                if (record.favorite_athletes == null)
                    cmd.Parameters.AddWithValue("@favorite_athletes", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@favorite_athletes", ConvertType.GetXMLFromObject(record.favorite_athletes));
                if (record.favorite_teams == null)
                    cmd.Parameters.AddWithValue("@favorite_teams", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@favorite_teams", ConvertType.GetXMLFromObject(record.favorite_teams));
                cmd.Parameters.AddWithValue("@relationship_status", record.relationship_status);
                if (record.work == null)
                    cmd.Parameters.AddWithValue("@work", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@work", ConvertType.GetXMLFromObject(record.work));

                cmd.Parameters.AddWithValue("@can_post", record.can_post);
                cmd.Parameters.AddWithValue("@category", record.category);
                if (record.category_list == null)
                    cmd.Parameters.AddWithValue("@category_list", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@category_list", ConvertType.GetXMLFromObject(record.category_list));
                if (record.cover == null)
                    cmd.Parameters.AddWithValue("@cover", SqlXml.Null);
                else
                    cmd.Parameters.AddWithValue("@cover", ConvertType.GetXMLFromObject(record.cover));
                cmd.Parameters.AddWithValue("@has_added_app", record.has_added_app);
                cmd.Parameters.AddWithValue("@is_published", record.is_published);
                cmd.Parameters.AddWithValue("@likes", record.likes);
                cmd.Parameters.AddWithValue("@name", record.name);
                cmd.Parameters.AddWithValue("@talking_about_count", record.talking_about_count);
                cmd.Parameters.AddWithValue("@were_here_count", record.were_here_count);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "UpFbLike");
                return false;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }
        #endregion

        #region FbComments
        public static bool AddFbComments(FbComments record)
        {
            SqlConnection cnn = null;
            SqlCommand cmd = null;

            try
            {
                if (record == null)
                    return false;

                cnn = new SqlConnection();
                cnn.ConnectionString = ConnectionString;
                cnn.FireInfoMessageEventOnUserErrors = false;
                cnn.Open();

                cmd = new SqlCommand();
                cmd.Connection = cnn;
                //--- Insert Record
                cmd.CommandText = " Insert into FbComments(uid, feedid, commendId, message, [from], created_time) OUTPUT inserted.id " +
                                  " values(@uid, @feedid, @commendId, @message, @from, @created_time);";

                cmd.Parameters.AddWithValue("@uid", record.uid);
                cmd.Parameters.AddWithValue("@feedid", record.feedid);
                cmd.Parameters.AddWithValue("@commendId", record.commendId);
                cmd.Parameters.AddWithValue("@message",record.message);
                if (record.from == null)
                    cmd.Parameters.AddWithValue("@from", SqlGuid.Null);
                else
                    cmd.Parameters.AddWithValue("@from", ConvertType.GetXMLFromObject(record.from));
                cmd.Parameters.AddWithValue("@created_time", record.created_time);

                Guid guid = (Guid)cmd.ExecuteScalar();

                if (guid == null || guid == Guid.Empty)
                    return false;

                record.id = new Guid(guid.ToString());

                return true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "AddFbComments");
                return false;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
        }

        public static bool UpFbComments(FbComments record)
        {
            SqlConnection connection = null;
            SqlCommand cmd = null;

            try
            {
                if (record == null)
                    return false;

                // Make connection to database
                connection = new SqlConnection();
                connection.ConnectionString = ConnectionString;
                connection.FireInfoMessageEventOnUserErrors = false;
                connection.Open();
                // Create command to update GeneralGuessGroup record
                cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "Update [FbComments] Set  message =@message, [from]=@from "
                                    + " where commendId='" + record.commendId + "'";
                
                cmd.Parameters.AddWithValue("@message",record.message);
                if (record.from == null)
                    cmd.Parameters.AddWithValue("@from", SqlGuid.Null);
                else
                    cmd.Parameters.AddWithValue("@from", ConvertType.GetXMLFromObject(record.from));
                cmd.Parameters.AddWithValue("@created_time", record.created_time);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "UpFbComments");
                return false;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }
        #endregion

        #region FbLogCallApi
        public static bool AddFbLog(FbLog record)
        {
            SqlConnection cnn = null;
            SqlCommand cmd = null;

            try
            {
                if (record == null)
                    return false;

                cnn = new SqlConnection();
                cnn.ConnectionString = ConnectionString;
                cnn.FireInfoMessageEventOnUserErrors = false;
                cnn.Open();

                cmd = new SqlCommand();
                cmd.Connection = cnn;
                //--- Insert Record
                //id, fb_acc_id, call_api_fb, create_date
                cmd.CommandText = " Insert into FbLog(account, command) OUTPUT inserted.id " +
                                  " values(@account, @command);";

                cmd.Parameters.AddWithValue("@account", record.account);
                cmd.Parameters.AddWithValue("@command", record.command);

                Guid guid = (Guid)cmd.ExecuteScalar();
                if (guid == null || guid == Guid.Empty)
                    return false;

                record.id = new Guid(guid.ToString());

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "AddFbLog");
                return false;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
        }

        #endregion

       

        #region Execute SQL

        public static bool ExcNonQuery(string sqlcommand)
        {
            SqlConnection connection = null;
            SqlCommand command = null;

            try
            {
                connection = new SqlConnection();
                connection.ConnectionString = ConnectionString;
                connection.Open();
                command = new SqlCommand(sqlcommand, connection);
                command.CommandTimeout = 36000;
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ExcNonQuery");
                return false;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        public static object ExcScalar(string sqlcommand)
        {
            SqlConnection connection = null;
            SqlCommand command = null;
            object result = null;

            try
            {
                connection = new SqlConnection();
                connection.ConnectionString = ConnectionString;
                connection.Open();
                command = new SqlCommand(sqlcommand, connection);
                command.CommandTimeout = 36000;
                result = command.ExecuteScalar();
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ExcScalar");
                return null;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        public static DataTable ExcDataTable(string sqlcommand)
        {
            SqlConnection connection = null;
            SqlCommand command = null;
            SqlDataAdapter adp = null;
            DataTable table = null;

            try
            {
                connection = new SqlConnection();
                connection.ConnectionString = ConnectionString;
                connection.Open();
                command = new SqlCommand(sqlcommand, connection);
                command.CommandTimeout = 36000;
                table = new DataTable();
                adp = new SqlDataAdapter(command);
                adp.Fill(table);
                return table;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "ExcDataTable");
                return null;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        public static bool CheckExist(string sqlcommand)
        {
            SqlConnection connection = null;
            SqlCommand command = null;
            SqlDataReader reader = null;

            try
            {
                connection = new SqlConnection();
                connection.ConnectionString = ConnectionString;
                connection.FireInfoMessageEventOnUserErrors = false;
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = sqlcommand;
                command.CommandType = CommandType.Text;
                reader = command.ExecuteReader();
                if (reader.Read())
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "CheckExist");
                return false;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        #endregion  // Execute SQL

        #region Execute OleDB

        public static DataTable ExcOleDbSchemaTable(string connectionString)
        {
            OleDbConnection oleConnect = null;
            DataTable table = null;

            try
            {
                oleConnect = new OleDbConnection();
                oleConnect.ConnectionString = connectionString;
                oleConnect.Open();
                table = oleConnect.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
                return table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ExcOleDbSchemaTable");
                return null;
            }

        }

        public static DataTable ExcOleDbSchemaColumn(string connectionString, string tableName)
        {
            OleDbConnection oleConnect = null;
            DataTable table = null;

            try
            {
                oleConnect = new OleDbConnection();
                oleConnect.ConnectionString = connectionString;
                oleConnect.Open();
                table = oleConnect.GetOleDbSchemaTable(OleDbSchemaGuid.Columns, new object[] { null, null, tableName, null });
                return table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ExcOleDbSchemaColumn");
                return null;
            }
        }

        public static OleDbDataReader ExcOleReaderDataSource(string connectionString, string tableName, string[] columnNames)
        {
            OleDbConnection oleConnect = null;
            OleDbCommand oleCommand = null;
            OleDbDataReader oleReader = null;
            string sqlcommand = "Select ";
            string[] getType;

            try
            {
                getType = connectionString.ToString().Split('.');
                //----- Get string command
                switch (getType[getType.Length - 1])
                {
                    case "mdb":
                    case "MDB":
                        for (int i = 0; i < columnNames.Length; i++)
                        {
                            if (i == columnNames.Length - 1)
                                sqlcommand += "[" + columnNames[i] + "] ";
                            else
                                sqlcommand += "[" + columnNames[i] + "],";
                        }
                        sqlcommand += "FROM [" + tableName + "]";
                        break;
                    case "dbf":
                    case "DBF":
                        for (int i = 0; i < columnNames.Length; i++)
                        {
                            if (i == columnNames.Length - 1)
                                sqlcommand += columnNames[i] + " ";
                            else
                                sqlcommand += columnNames[i] + ",";
                        }
                        sqlcommand += "FROM [" + tableName + "] Order by " + columnNames[0];
                        break;
                    default:
                        for (int i = 0; i < columnNames.Length; i++)
                        {
                            if (i == columnNames.Length - 1)
                                sqlcommand += "[" + columnNames[i] + "] ";
                            else
                                sqlcommand += "[" + columnNames[i] + "],";
                        }
                        sqlcommand += "FROM [" + tableName + "$]";
                        break;
                }

                oleConnect = new OleDbConnection(connectionString);
                oleConnect.Open();
                oleCommand = new OleDbCommand(sqlcommand, oleConnect);
                oleReader = oleCommand.ExecuteReader();
                return oleReader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ExcOleReaderDataSource");
                return null;
            }
        }

        public static OleDbDataReader ExcOleReaderDataSource(string connectionString, string tableName, string[] columnNames, string stringWhere)
        {
            OleDbConnection oleConnect = null;
            OleDbCommand oleCommand = null;
            OleDbDataReader oleReader = null;
            string sqlcommand = "Select ";
            string[] getType;

            try
            {
                getType = connectionString.ToString().Split('.');
                //----- Get string command
                switch (getType[getType.Length - 1])
                {
                    case "mdb":
                    case "MDB":
                        for (int i = 0; i < columnNames.Length; i++)
                        {
                            if (i == columnNames.Length - 1)
                                sqlcommand += "[" + columnNames[i] + "] ";
                            else
                                sqlcommand += "[" + columnNames[i] + "],";
                        }
                        sqlcommand += "FROM [" + tableName + "] Where " + stringWhere;
                        break;
                    case "dbf":
                    case "DBF":
                        for (int i = 0; i < columnNames.Length; i++)
                        {
                            if (i == columnNames.Length - 1)
                                sqlcommand += columnNames[i] + " ";
                            else
                                sqlcommand += columnNames[i] + ",";
                        }
                        sqlcommand += "FROM [" + tableName + "] Where " + stringWhere + " Order by " + columnNames[0];
                        break;
                    default:
                        for (int i = 0; i < columnNames.Length; i++)
                        {
                            if (i == columnNames.Length - 1)
                                sqlcommand += "[" + columnNames[i] + "] ";
                            else
                                sqlcommand += "[" + columnNames[i] + "],";
                        }
                        sqlcommand += "FROM [" + tableName + "$] Where " + stringWhere;
                        break;
                }

                oleConnect = new OleDbConnection(connectionString);
                oleConnect.Open();
                oleCommand = new OleDbCommand(sqlcommand, oleConnect);
                oleReader = oleCommand.ExecuteReader();
                return oleReader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ExcOleReaderDataSource");
                return null;
            }
        }

        public static OleDbDataReader ExcOleReaderDataSource(string connectionString, string tableName, string[] columnNames, int topRow)
        {
            OleDbConnection oleConnect = null;
            OleDbCommand oleCommand = null;
            OleDbDataReader oleReader = null;
            string sqlcommand = "Select ";
            string[] getType;

            try
            {
                getType = connectionString.ToString().Split('.');
                sqlcommand += "Top " + topRow + " ";
                //----- Get string command
                switch (getType[getType.Length - 1])
                {
                    case "mdb":
                    case "MDB":
                        for (int i = 0; i < columnNames.Length; i++)
                        {
                            if (i == columnNames.Length - 1)
                                sqlcommand += "[" + columnNames[i] + "] ";
                            else
                                sqlcommand += "[" + columnNames[i] + "],";
                        }
                        sqlcommand += "FROM [" + tableName + "]";
                        break;
                    case "dbf":
                    case "DBF":
                        for (int i = 0; i < columnNames.Length; i++)
                        {
                            if (i == columnNames.Length - 1)
                                sqlcommand += columnNames[i] + " ";
                            else
                                sqlcommand += columnNames[i] + ",";
                        }
                        sqlcommand += "FROM [" + tableName + "] Order by " + columnNames[0] + " desc";
                        break;
                    default:
                        for (int i = 0; i < columnNames.Length; i++)
                        {
                            if (i == columnNames.Length - 1)
                                sqlcommand += "[" + columnNames[i] + "] ";
                            else
                                sqlcommand += "[" + columnNames[i] + "],";
                        }
                        sqlcommand += "FROM [" + tableName + "$]";
                        break;
                }

                oleConnect = new OleDbConnection(connectionString);
                oleConnect.Open();
                oleCommand = new OleDbCommand(sqlcommand, oleConnect);
                oleReader = oleCommand.ExecuteReader();
                return oleReader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ExcOleReaderDataSource");
                return null;
            }
        }

        public static object ExcOleScalar(string connectionString, string sqlcommand)
        {
            OleDbConnection oleConnect = null;
            OleDbCommand oleCommand = null;
            object result;

            try
            {
                oleConnect = new OleDbConnection(connectionString);
                oleConnect.Open();
                oleCommand = new OleDbCommand(sqlcommand, oleConnect);
                result = oleCommand.ExecuteScalar();
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ExcOleScalar");
                return null;
            }
        }

        #endregion  // Execute OleDB
    }
    public class FileDataDictionary
    {
        private System.Collections.Generic.Dictionary<string, string> ds;

        public FileDataDictionary(string fileName)
        {
            try
            {
                this.ds = new System.Collections.Generic.Dictionary<string, string>();
                System.IO.StreamReader sr = new System.IO.StreamReader(fileName);
                while (sr.Peek() != -1)
                {
                    string line = sr.ReadLine();
                    if (line.Substring(0, 2) != "//")
                    {
                        data d = new data(line);
                        if (d.value != null)
                        {
                            this.ds.Add(d.fieldName, d.value);
                        }
                    }
                }
                sr.Close();
            }
            catch (System.Exception e_8D)
            {
            }
        }

        public string getValue(string name)
        {
            string result;
            if (this.ds.ContainsKey(name))
            {
                result = this.ds[name];
            }
            else
            {
                result = null;
            }
            return result;
        }

        public bool writeFile(string filePath)
        {
            if (System.IO.File.Exists(filePath))
            {
                System.IO.File.Delete(filePath);
            }
            System.IO.TextWriter writer = new System.IO.StreamWriter(filePath);
            foreach (System.Collections.Generic.KeyValuePair<string, string> pair in this.ds)
            {
                string line = pair.Key + "=" + pair.Value;
                writer.WriteLine(line);
            }
            writer.Close();
            return false;
        }
    }
}

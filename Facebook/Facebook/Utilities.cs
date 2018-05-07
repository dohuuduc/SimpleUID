using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using COMExcel = Microsoft.Office.Interop.Excel;

namespace Facebook
{
    class Utilities
    {

        public static bool CheckNumberEnterKey(string uid)
        {
            try
            {
                return int.TryParse(uid, out int n);
            }
            catch
            {
                return false;
            }
        }
        public static string convertToUnSign3(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }
        public static List<string> getPhoneHTML(string content, Dictionary<string, int> dauso, List<regexs> _regexs, bool? istestTrung = null)
        {
            List<string> hashSet = new List<string>();
            List<string> phoneChuan = new List<string>();
            if (content == null || content == "") return null;
            content = content.Replace("(84)", "0").Replace("(+84)", "0").Replace("+84", "0");
            foreach (regexs re in _regexs)
            {
                Regex rg = new Regex(string.Format(@"{0}", re.Regex), RegexOptions.Multiline | RegexOptions.IgnorePatternWhitespace);
                MatchCollection m = rg.Matches(content);
                foreach (Match g in m)
                {
                    string item = RemoveSymbolInPhone(g.Value);
                    if (istestTrung == null || istestTrung == true)
                    {
                        if (!hashSet.Contains(item))
                        {
                            hashSet.Add(item);
                        }
                    }
                    else
                    {
                        hashSet.Add(item);
                    }
                }
            }

            /*01/2018 bo xung theo kiem tra so luong chuoi dien thoai*/
            /*xu ly so lieu*/
            foreach (var item in hashSet)
            {
                string dienthoai = item;
                Dictionary<string, int> dausothieu0 = dauso.Where(p => !p.Key.StartsWith("0")).ToDictionary(p => p.Key, p => p.Value);
                bool kiemtra0 = dausothieu0.Where(x => (dienthoai.StartsWith(x.Key) && dienthoai.Length == x.Value)).Count() > 0;
                if (kiemtra0)
                    dienthoai = string.Format("0{0}", dienthoai);

                if (dienthoai.Length >= 10 && dienthoai.Length <= 11)
                {
                    bool kiemtra = dauso.Where(x => (dienthoai.StartsWith(x.Key) && dienthoai.Length == x.Value)).Count() > 0;
                    if (kiemtra)
                        phoneChuan.Add(dienthoai);
                }
            }
            return phoneChuan;
        }
        public static List<string> getPhoneHTML(List<string> datahtml, Dictionary<string, int> dauso, List<regexs> _regexs, bool? istestTrung = null)
        {
            List<string> hashSet = new List<string>();
            List<string> phoneChuan = new List<string>();
            foreach (var chuoi in datahtml)
            {
                string content = chuoi.Replace("(84)", "0").Replace("(+84)", "0").Replace("+84", "0");

                foreach (regexs re in _regexs)
                {
                    Regex rg = new Regex(string.Format(@"{0}", re.Regex), RegexOptions.Multiline | RegexOptions.IgnorePatternWhitespace);
                    MatchCollection m = rg.Matches(content);
                    foreach (Match g in m)
                    {
                        string item = RemoveSymbolInPhone(g.Value);
                        if (istestTrung == null || istestTrung == true)
                        {
                            if (!hashSet.Contains(item))
                            {
                                hashSet.Add(item);
                            }
                        }
                        else
                        {
                            hashSet.Add(item);
                        }
                    }
                }
            }
            /*01/2018 bo xung theo kiem tra so luong chuoi dien thoai*/
            /*xu ly so lieu*/
            foreach (var item in hashSet)
            {
                string dienthoai = item;
                Dictionary<string, int> dausothieu0 = dauso.Where(p => !p.Key.StartsWith("0")).ToDictionary(p => p.Key, p => p.Value);
                bool kiemtra0 = dausothieu0.Where(x => (dienthoai.StartsWith(x.Key) && dienthoai.Length == x.Value)).Count() > 0;
                if (kiemtra0)
                    dienthoai = string.Format("0{0}", dienthoai);

                if (dienthoai.Length >= 10 && dienthoai.Length <= 11)
                {
                    bool kiemtra = dauso.Where(x => (dienthoai.StartsWith(x.Key) && dienthoai.Length == x.Value)).Count() > 0;
                    if (kiemtra)
                        phoneChuan.Add(dienthoai);
                }
            }
            return phoneChuan;
        }
        public static string RemoveSymbolInPhone(string phonenum)
        {
            string text = phonenum;
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                if (!char.IsDigit(c))
                {
                    phonenum = phonenum.Replace(c.ToString(), "");
                }
            }
            return phonenum;
        }


        public static List<string> getEmail(List<string> datahtml)
        {
            try
            {
                List<string> emailList = new List<string>();
                foreach (var item in datahtml)
                {
                    Regex rg = new Regex(@"([\w\.])+@([a-zA-Z0-9\-])+\.([a-zA-Z]{2,4})(\.[a-zA-Z]{2,4})?");
                    MatchCollection m = rg.Matches(item);
                    foreach (Match g in m)
                    {
                        if (g.Groups[0].Value.Length > 0)
                            if (emailList.Count(x => x.Contains(g.Groups[0].Value)) == 0)
                                emailList.Add(g.Groups[0].Value);
                    }
                }
                return emailList;
            }
            catch (Exception ex)
            {
                return null;

            }
        }

        public static string clearString(string strWithTabs) {
            return  strWithTabs.Replace("\t", "").Replace("\r","").Replace("\n","").ToString();
        }
    }

    public class Log
    {
        public string Message { get; set; }
        public string LogTime { get; set; }
        public string LogDate { get; set; }

        public Log(string message)
        {
            Message = message;
            LogDate = DateTime.Now.ToString("yyyy-MM-dd");
            LogTime = DateTime.Now.ToString("hh:mm:ss.fff tt");
        }
    }
    public class LogWriter
    {
        private static LogWriter instance;
        private static Queue<Log> logQueue;
        private static string logDir = "D";//<Path to your Log Dir or Config Setting>;
        private static string logFile = "log.txt";//<Your Log File Name or Config Setting>;
        private static int maxLogAge = int.Parse("5000");
        private static int queueSize = int.Parse("0");
        private static DateTime LastFlushed = DateTime.Now;

        /// <summary>
        /// Private constructor to prevent instance creation
        /// </summary>
        private LogWriter() { }

        /// <summary>
        /// An LogWriter instance that exposes a single instance
        /// </summary>
        public static LogWriter Instance {
            get {
                // If the instance is null then create one and init the Queue
                if (instance == null)
                {
                    instance = new LogWriter();
                    logQueue = new Queue<Log>();
                }
                return instance;
            }
        }


        /// <summary>
        /// The single instance method that writes to the log file
        /// </summary>
        /// <param name="message">The message to write to the log</param>
        public void WriteToLog(string message)
        {
            // Lock the queue while writing to prevent contention for the log file
            lock (logQueue)
            {
                // Create the entry and push to the Queue
                Log logEntry = new Log(message);
                logQueue.Enqueue(logEntry);

                // If we have reached the Queue Size then flush the Queue
                if (logQueue.Count >= queueSize || DoPeriodicFlush())
                {
                    FlushLog();
                }
            }
        }

        private bool DoPeriodicFlush()
        {
            TimeSpan logAge = DateTime.Now - LastFlushed;
            if (logAge.TotalSeconds >= maxLogAge)
            {
                LastFlushed = DateTime.Now;
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Flushes the Queue to the physical log file
        /// </summary>
        private void FlushLog()
        {
            while (logQueue.Count > 0)
            {
                Log entry = logQueue.Dequeue();
                string logPath = logDir + entry.LogDate + "_" + logFile;

                // This could be optimised to prevent opening and closing the file for each write
                using (FileStream fs = File.Open(logPath, FileMode.Append, FileAccess.Write))
                {
                    using (StreamWriter log = new StreamWriter(fs))
                    {
                        log.WriteLine(string.Format("{0}\t{1}", entry.LogTime, entry.Message));
                    }
                }
            }
        }
    }

    public static class TheardFacebookWriter
    {
        public static bool hasProcess = true; /*khai bao bien stop*/

        private static LogWriter writer;

        public static void getwebBrowser(NhomUID model, object arrControl)
        {
            ArrayList arr1 = (ArrayList)arrControl;
            Label lblMessage1 = (Label)arr1[0];
            Label lblMessage2 = (Label)arr1[1];
            Label lblSluongGoi = (Label)arr1[2];
            TextBox txtToken = (TextBox)arr1[3];
            CheckBox chkMe = (CheckBox)arr1[4];
            CheckBox chkBanBe = (CheckBox)arr1[5];
            CheckBox chkBaiViet = (CheckBox)arr1[6];
            string strToken = "";
            try
            {
                if (!TheardFacebookWriter.hasProcess) return;

                /*Lấy thông tin của UID*/
                #region Get Me
                if (chkMe.Checked)
                {

                    strToken = Facebook.Token(arrControl);
                    if (strToken == "")
                    {
                        TheardFacebookWriter.hasProcess = false;
                        return;
                    };
                    string requestUriString = string.Format(@"https://graph.facebook.com/{0}/?fields={1}&access_token={2}", model.UID,
                                    model.IsLoai == 0 ? Facebook.SelectMyUIDOfUser() :
                                    model.IsLoai == 1 ? Facebook.SelectMyPageOfUser() :
                                                        Facebook.SelectMyGUIOfUser()
                        , strToken);

                    string json = Facebook.GetHtmlFB(requestUriString, strToken);
                    if (model.IsLoai == 0)
                    {
                        FbUID resultsFbUID = JsonConvert.DeserializeObject<FbUID>(json);
                        if (resultsFbUID != null)
                        {
                            /*kiem tra xem thông tin có chưa? nếu có rồi thì update ngược lại thêm mới*/
                            DataTable tbFbUID = SQLDatabase.ExcDataTable(string.Format("select count(*) from FbUID where uid='{0}'", resultsFbUID.uid));
                            if (ConvertType.ToInt(tbFbUID.Rows[0][0]) == 0)
                            {
                                /*Thêm mới*/
                                SQLDatabase.AddFbUID(resultsFbUID);
                            }
                            else
                            {
                                //update
                                SQLDatabase.UpFbUID(resultsFbUID);
                            }
                        }
                        lblMessage2.Text = string.Format("Quét Thông Tin UID: {0}-{1}", resultsFbUID.uid, resultsFbUID.name);
                        lblMessage2.Update();
                    }
                    else if (model.IsLoai == 1)
                    {
                        FbPage resultsFbPage = JsonConvert.DeserializeObject<FbPage>(json);
                        if (resultsFbPage != null)
                        {
                            DataTable tbFbPage = SQLDatabase.ExcDataTable(string.Format("select count(*) from FbPage where uid='{0}'", resultsFbPage.uid));
                            if (ConvertType.ToInt(tbFbPage.Rows[0][0]) == 0)
                            {
                                SQLDatabase.AddFbPage(resultsFbPage);
                            }
                            else
                            {
                                SQLDatabase.UpFbPage(resultsFbPage);
                            }
                        }
                        lblMessage2.Text = string.Format("Quét Thông Tin Page: {0}-{1}", resultsFbPage.uid, resultsFbPage.name);
                        lblMessage2.Update();
                    }
                    else if (model.IsLoai == 2)
                    {
                        FbGUI resultsFbGUI = JsonConvert.DeserializeObject<FbGUI>(json);
                        if (resultsFbGUI != null)
                        {
                            DataTable tbFbUID = SQLDatabase.ExcDataTable(string.Format("select count(*) from FbGUI where uid='{0}'", resultsFbGUI.uid));
                            if (ConvertType.ToInt(tbFbUID.Rows[0][0]) == 0)
                            {
                                SQLDatabase.AddFbGUI(resultsFbGUI);
                            }
                            else
                            {
                                SQLDatabase.UpFbGUI(resultsFbGUI);
                            }
                        }
                        lblMessage2.Text = string.Format("Quét Thông Tin FbGUI: {0}-{1}", resultsFbGUI.uid, resultsFbGUI.name);
                        lblMessage2.Update();
                    }


                }
                #endregion

                #region Bạn bè / Thành Viên
                if (chkBanBe.Checked && model.IsLoai != 1)
                {
                    strToken = Facebook.Token(arrControl);
                    if (strToken == "")
                    {
                        TheardFacebookWriter.hasProcess = false;
                        return;
                    };

                    string requestUriString = string.Format(@"https://graph.facebook.com/{0}/{1}?limit=100&fields={2}&access_token={3}", model.UID,
                                  model.IsLoai == 0 ? "friends" : "members",
                                  model.IsLoai == 0 ? Facebook.SelectFbFriend() : Facebook.SelectFbFriend(), strToken);

                    string json = Facebook.GetHtmlFB(requestUriString, strToken);
                    ListFbFriend resultsFbFrend = JsonConvert.DeserializeObject<ListFbFriend>(json);
                    foreach (FbFriend item in resultsFbFrend.FbFriend)
                    {
                        item.uid = model.UID;
                        DataTable tbFbUID = SQLDatabase.ExcDataTable(string.Format("select count(*) from FbFriend where Uid='{0}' and FriendUid='{1}'",item.uid ,item.FriendUid));
                        if (ConvertType.ToInt(tbFbUID.Rows[0][0]) == 0)
                            SQLDatabase.AddFbFriend(item);
                        else
                            SQLDatabase.UpdateFbFriend(item);
                        lblMessage2.Text = string.Format("Quét {0} ->Id: {1} -Name: {2}", model.IsLoai == 0 ? "bạn bè" : "thành viên",item.FriendUid ,item.name);
                        lblMessage2.Update();
                    }
                }
                #endregion

                #region Bài Viết / Like + Comment
                if (chkBaiViet.Checked)
                {
                    strToken = Facebook.Token(arrControl);
                    if (strToken == "")
                    {
                        TheardFacebookWriter.hasProcess = false;
                        return;
                    };
                    string requestUriString = string.Format(@"https://graph.facebook.com/{0}/feed?limit=500&access_token={1}", model.UID, strToken);
                    ListFbFeed modeFeed = GetFbFeed(requestUriString,strToken);
                    foreach (var mFeed in modeFeed.FbFeed){
                        mFeed.feedid = mFeed.uid;
                        mFeed.uid = model.UID;
                        /********************************************************/
                        DataTable tbFbFeed = SQLDatabase.ExcDataTable(string.Format("select count(*) from FbFeed where [feedId]='{0}'", mFeed.feedid));
                        if (ConvertType.ToInt(tbFbFeed.Rows[0][0]) == 0)
                            SQLDatabase.AddFbFeed(mFeed);
                        else
                            SQLDatabase.UpFbFeed(mFeed);

                        lblMessage2.Text = string.Format("Quét Feed ->mã bài {0} \n Nội dung: {1}", mFeed.feedid, mFeed.message);
                        lblMessage2.Update();

                        #region Like
                        if (model.IsLoai == 0) // chỉ có trường hợp user
                        {
                            strToken = Facebook.Token(arrControl);
                            if (strToken == "")
                            {
                                TheardFacebookWriter.hasProcess = false;
                                return;
                            };
                            string requestUriLike = string.Format(@"https://graph.facebook.com/{0}/likes?limit=200&access_token={1}", mFeed.feedid, strToken);
                            Dictionary<string, FbLike> resultsLikechitiets = GetLike(requestUriLike, arrControl, strToken);
                            foreach (KeyValuePair<string, FbLike> itemLike in resultsLikechitiets)
                            {
                                itemLike.Value.uid = model.UID;
                                itemLike.Value.likeid = itemLike.Key;
                                itemLike.Value.feedid = mFeed.feedid;
                                DataTable tbFbLike = SQLDatabase.ExcDataTable(string.Format("select count(*) from FbLike where uid='{0}' and [feedId]='{1}' and likeid='{2}'", itemLike.Value.uid, itemLike.Value.feedid, itemLike.Value.likeid));
                                if (ConvertType.ToInt(tbFbLike.Rows[0][0]) == 0)
                                    SQLDatabase.AddFbLike(itemLike.Value);
                                else
                                    SQLDatabase.UpFbLike(itemLike.Value);

                                lblMessage2.Text = string.Format("Quét Like ->mã bài: {0} | user like:{1} \n Link: {2}", itemLike.Value.feedid, itemLike.Value.likeid,itemLike.Value.link);
                                lblMessage2.Update();
                            }
                        }
                        #endregion

                        #region Comment
                        strToken = Facebook.Token(arrControl);
                        if (strToken == "")
                        {
                            TheardFacebookWriter.hasProcess = false;
                            return;
                        };
                        string requestComment = string.Format(@"https://graph.facebook.com/{0}/comments?limit=500&fields={1}&access_token={2}", mFeed.feedid, Facebook.Selectcomments(), strToken);
                        ListFbComments modeComment = GetFbCommend(requestComment, strToken);
                        foreach (FbComments itemComment in modeComment.fbComments)
                        {
                            itemComment.uid = mFeed.uid;
                            itemComment.feedid = mFeed.feedid;

                            DataTable tbFbCommnet = SQLDatabase.ExcDataTable(string.Format("select count(*) from FbComments where commendId='{0}'", itemComment.commendId));
                            if (ConvertType.ToInt(tbFbCommnet.Rows[0][0]) == 0)
                                SQLDatabase.AddFbComments(itemComment);
                            else
                                SQLDatabase.UpFbComments(itemComment);


                            lblMessage2.Text = string.Format("Quét comment ->mã bài {0}_{1} \nNội dung: {2}", itemComment.feedid, itemComment.commendId, itemComment.message);
                            lblMessage2.Update();
                        }
                        #endregion
                    }

                    #endregion
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "getwebBrowser");
            }
        }
        public static void AddRange<T>(this ICollection<T> target, IEnumerable<T> source)
        {
            if (target == null)
                throw new ArgumentNullException(nameof(target));
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            foreach (var element in source)
                target.Add(element);
        }


        public static Dictionary<string, FbLike> GetLike(string requestUriString, object arrControl, string token)
        {
            Dictionary<string, FbLike> resul = new Dictionary<string, FbLike>();
            Likes model = new Likes();
            model.like = new List<like>();
            bool flag = true;
            try
            {
                while (flag)
                {
                    string json = Facebook.GetHtmlFB(requestUriString, token);
                    if (json != "")
                    {
                        Likes resultsComment = JsonConvert.DeserializeObject<Likes>(json);
                        if (resultsComment.like.Count == 0) break;
                        Pagings paging = JsonConvert.DeserializeObject<Pagings>(json);
                        /*******************************/
                        string dsUIDLike = "";
                        foreach (like item1 in resultsComment.like)
                        {
                            dsUIDLike += item1.id + ",";
                        }
                        dsUIDLike = dsUIDLike.Substring(0, dsUIDLike.Length - 1);
                        string strToken = Facebook.Token(arrControl);
                        if (strToken == "")
                        {
                            TheardFacebookWriter.hasProcess = false;
                            return resul;
                        };

                        string strdsLike = string.Format(@"https://graph.facebook.com/?ids={0}&access_token={1}", dsUIDLike, strToken);
                        string jsonLikechitiet = Facebook.GetHtmlFB(strdsLike, token);
                        Dictionary<string, FbLike> resultsLikechitiets = JsonConvert.DeserializeObject<Dictionary<string, FbLike>>(jsonLikechitiet);
                        foreach (var newAnimal in resultsLikechitiets)
                            resul.Add(newAnimal.Key, newAnimal.Value);

                        /*******************************/
                        if (paging.Paging.Next != null)
                            requestUriString = paging.Paging.Next;
                        else
                            flag = false;

                    }
                }
                return resul;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "GetFbLike");
                return resul;
            }
        }

        public static ListFbFeed GetFbFeed(string requestUriString,string token)
        {
            ListFbFeed model = new ListFbFeed();
            model.FbFeed = new List<FbFeed>();
            bool flag = true;
            try
            {
                while (flag)
                {
                    string json = Facebook.GetHtmlFB(requestUriString,token);
                    ListFbFeed resultsFbFeed = JsonConvert.DeserializeObject<ListFbFeed>(json);
                    if (resultsFbFeed.FbFeed.Count() == 0) return model ;
                    Pagings paging = JsonConvert.DeserializeObject<Pagings>(json);
                    /*******************************/
                    model.FbFeed.AddRange(resultsFbFeed.FbFeed);
                    /*******************************/
                    if (paging.Paging != null)
                        requestUriString = paging.Paging.Next;
                    else
                        flag = false;
                }
                return model;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "GetFbFeed");
                return model;
            }
        }

        public static ListFbComments GetFbCommend(string requestUriString,string token)
        {
            ListFbComments model = new ListFbComments();
            model.fbComments = new List<FbComments>();
            bool flag = true;
            try
            {
                while (flag)
                {
                    string jsonComment = Facebook.GetHtmlFB(requestUriString,token);
                    if (jsonComment != "")
                    {
                        ListFbComments resultsComment = JsonConvert.DeserializeObject<ListFbComments>(jsonComment);
                        if (resultsComment.fbComments.Count == 0) break;
                        Pagings paging = JsonConvert.DeserializeObject<Pagings>(jsonComment);
                        /********************************/
                        model.fbComments.AddRange(resultsComment.fbComments);
                        /*******************************/
                        if (paging.Paging.Next != null)
                            requestUriString = paging.Paging.Next;
                        else
                            flag = false;
                    }
                }
                return model;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "GetFbCommend");
                return model;
            }
        }

    }

    public static class Helpers
    {
        private static LogWriter writer;
        public static int vitritim(List<string> array, string xx)
        {
            try
            {
                int i = 0;
                foreach (var bale in array)
                {
                    if (bale.Contains(xx))
                    {
                        return i;
                    }
                    i++;
                }
                return -1;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        public static int vitritim(List<string> array, string xx, int vt)
        {
            try
            {
                if (vt == array.Count()) return -1;
                vt++;
                for (int i = vt; i < array.Count(); i++)
                {
                    if (array[i].Contains(xx))
                        return i;
                }
                return -1;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }


        //<INPUT type=hidden value=011 name=code>
        public static string getValueHtml(string tabHTML)
        {
            //b1: cho tất cả vào mảng cách nhau bởi khoản trắng
            string[] arrGetHtmlDocument = tabHTML.Trim().Split(' ');
            //b2: tìm mảng nào có chứa value
            string giatri = Array.Find(arrGetHtmlDocument, n => n.Contains("value"));
            //b3: cắt giatri có trong string ra
            // Location of the letter c.
            int i_dau = giatri.IndexOf("'") + 1;
            int i_cuoi = giatri.LastIndexOf("'");
            string d = giatri.Substring(i_dau, i_cuoi - i_dau);
            return d;
        }


        /// <param name="chuoi1"></param>
        /// <param name="chuoi2"></param>
        /// <param name="and_or">and_or: and =true; or= false</param>
        /// <returns></returns>
        public static int vitritim(List<string> array, string chuoi1, string chuoi2, bool and_or)
        {
            try
            {
                int i = 0;
                foreach (var bale in array)
                {

                    if (and_or && (bale.Contains(chuoi1) && bale.Contains(chuoi2)))
                    {
                        return i;
                    }
                    if (!and_or && (bale.Contains(chuoi1) || bale.Contains(chuoi2)))
                    {
                        return i;
                    }
                    i++;
                }
                return -1;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }



        public static List<string> getUrlHtml2(string html)
        {
            try
            {
                List<string> xx = new List<string>();
                while (html.IndexOf("href=\"") != -1)
                {
                    int vt1 = html.IndexOf("href=\"") + 6;
                    int vt2 = 0;
                    for (int i = vt1; i < html.Length; i++)
                    {
                        if (html[i].Equals('"'))
                        {
                            vt2 = i;
                            break;
                        }
                    }

                    xx.Add(html.Substring(vt1, (vt2 - vt1)));
                    html = html.Substring(vt2, html.Length - vt2);
                }
                return xx;
            }
            catch (Exception)
            {

                return null;
            }

        }

        public static List<string> getUrlHtml3(string html)
        {
            try
            {
                List<string> xx = new List<string>();
                while (html.IndexOf("href=\'") != -1)
                {
                    int vt1 = html.IndexOf("href=\'") + 6;
                    int vt2 = 0;
                    for (int i = vt1; i < html.Length; i++)
                    {
                        if (html[i].Equals('\''))
                        {
                            vt2 = i;
                            break;
                        }
                    }

                    xx.Add(html.Substring(vt1, (vt2 - vt1)));
                    html = html.Substring(vt2, html.Length - vt2);
                }
                return xx;
            }
            catch (Exception)
            {

                return null;
            }

        }

        public static string getUrlHtml(string tabHTML)
        {
            //b1: cho tất cả vào mảng cách nhau bởi khoản trắng
            string[] arrGetHtmlDocument = tabHTML.Trim().Split(' ');
            //b2: tìm mảng nào có chứa value
            string giatri = Array.Find(arrGetHtmlDocument, n => n.Contains("href"));
            //b3: cắt giatri có trong string ra
            // Location of the letter c.
            int i_dau = giatri.IndexOf("\"") + 1;
            int i_cuoi = giatri.LastIndexOf("\"");
            string d = giatri.Substring(i_dau, i_cuoi - i_dau);
            return d;
        }
        public static string getClassHtml(string tabHTML)
        {
            //b1: cho tất cả vào mảng cách nhau bởi khoản trắng
            string[] arrGetHtmlDocument = tabHTML.Trim().Split(' ');
            //b2: tìm mảng nào có chứa value
            string giatri = Array.Find(arrGetHtmlDocument, n => n.Contains("class"));
            //b3: cắt giatri có trong string ra
            // Location of the letter c.
            int i_dau = giatri.IndexOf("\"") + 1;
            int i_cuoi = giatri.LastIndexOf("\"");
            string d = giatri.Substring(i_dau, i_cuoi - i_dau);
            return d;
        }
        public static List<string> getDataHTML(string tabHTML)
        {
            List<string> arr = new List<string>();
            int vt1 = 0, vt2 = 0;
            try
            {

                for (int i = 0; i < tabHTML.Length - 1; i++)
                {
                    if (tabHTML[i].Equals('>'))
                    {
                        vt1 = i;
                        for (int j = i; j < tabHTML.Length; j++)
                        {
                            if (tabHTML[j].Equals('<'))
                            {
                                vt2 = j;
                                break;
                            }
                        }
                        if (vt2 == 0 && tabHTML.Length > 0)/*by luulong:16/06/2017*/
                            vt2 = tabHTML.Length;

                        if (!string.IsNullOrEmpty(tabHTML.Substring(vt1 + 1, vt2 - vt1 - 1)))
                            arr.Add(tabHTML.Substring(vt1 + 1, vt2 - vt1 - 1).Trim());
                    }
                }
                return arr;
            }
            catch
            {
                //writer = LogWriter.Instance;
                //writer.WriteToLog(string.Format("{0}", tabHTML));
                //MessageBox.Show("Lỗi cấu trúc không đúng Vui lòng nhấn enter để tiếp tục\n " + ex.Message, "getHTML");
                return arr;
            }
        }
        public static void LogMessage(string msg)
        {
            string sFilePath = Environment.CurrentDirectory + "Log_" + System.AppDomain.CurrentDomain.FriendlyName + ".txt";

            System.IO.StreamWriter sw = System.IO.File.AppendText(sFilePath);
            try
            {
                string logLine = System.String.Format(
                    "{0:G}: {1}.", System.DateTime.Now, msg);
                sw.WriteLine(logLine);
            }
            finally
            {
                sw.Close();
            }
        }
        public static List<string> FindAllPhone(string tabHTML)
        {
            try
            {
                List<string> danhsachdienthoai = new List<string>();
                string[] danhsachdauso = { "09", "01" };
                foreach (var item_dauso in danhsachdauso)
                {
                    int vt1 = 0;
                    while (vt1 <= tabHTML.Length)
                    {
                        vt1 = tabHTML.IndexOf(item_dauso, vt1);
                        if (vt1 == -1)
                            break;
                        string chuoitamlay = tabHTML.Substring(vt1, 20);
                        string dienthoai = "";
                        foreach (var item in chuoitamlay)
                        {
                            if (System.Text.RegularExpressions.Regex.IsMatch(item.ToString(), "[0-9]"))
                                dienthoai += item;
                        }

                        if (item_dauso == "09")
                        {
                            if (dienthoai.Length >= 10)
                            {
                                danhsachdienthoai.Add(dienthoai.Substring(0, 10));
                                vt1 = vt1 + 10;
                            }
                            else
                            {
                                vt1 = vt1 + dienthoai.Length;
                            }
                        }
                        if (item_dauso == "01")
                        {
                            if (dienthoai.Length >= 11)
                            {
                                danhsachdienthoai.Add(dienthoai.Substring(0, 11));
                                vt1 = vt1 + 11;
                            }
                            else
                            {
                                vt1 = vt1 + dienthoai.Length;
                            }
                        }
                    }
                }
                return danhsachdienthoai;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static string FindAllEmail(string tabHTML)
        {
            int vt1 = 0;
            try
            {
                tabHTML = tabHTML.Replace(":&nbsp;", "").Replace("&nbsp;", "").Trim();
                List<string> danhsachemail = new List<string>();
                vt1 = tabHTML.IndexOf("@", vt1);
                int i_dau = tabHTML.LastIndexOf(" ", vt1);
                int i_cuoi = tabHTML.IndexOf(" ", vt1);
                if (i_dau == -1)
                    i_dau = 0;
                if (i_cuoi == -1)
                    i_cuoi = tabHTML.Length;
                string email = tabHTML.Substring(i_dau, i_cuoi - i_dau);
                return email;

            }
            catch (Exception ex)
            {
                return "";
            }
        }

        public static bool islink(string link)
        {
            try
            {
                if (link.Length < 8)
                    return false;
                if (link.StartsWith("http://") || link.StartsWith("https://"))
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool IsNumber(string s)
        {
            return s.All(char.IsDigit);
        }
        public static string getDomain(string link)
        {
            try
            {
                int i = 0;
                for (i = link.IndexOf("//") + 2; i < link.Length; i++)
                {
                    if (link[i] == '/')
                        break;
                }

                return link.Substring(0, i);
            }
            catch
            {
                return "";
            }
        }

        public static string getTitleWeb(string html)
        {
            try
            {
                int vt1 = html.IndexOf("<title>");
                if (vt1 == -1)
                    return "";
                vt1 = vt1 + 7;
                int vt2 = html.IndexOf("</title>", vt1);
                return html.Substring(vt1, vt2 - vt1);
            }
            catch
            {
                return "";
            }
        }

        public static string convertToUnSign3(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }
    }

    public class ConvertType
    {
        public static int ToInt(object obj)
        {
            try
            {
                if (obj == null)
                    return 0;
                int rs = System.Convert.ToInt32(obj);
                if (rs < 0)
                    return 0;
                return rs;
            }
            catch
            {
                return 0;
            }
        }
        public static double ToDouble(object obj)
        {
            try
            {
                if (obj == null)
                    return 0;
                double rs = System.Convert.ToDouble(obj);
                if (rs < 0)
                    return 0;
                return rs;
            }
            catch
            {
                return 0;
            }
        }
        public static decimal ToDecimal(object obj)
        {
            try
            {
                if (obj == null)
                    return 0;
                decimal rs = System.Convert.ToDecimal(obj);
                if (rs < 0)
                    rs = 0;
                return rs;
            }
            catch { return 0; }
        }
        public static string ToString(object obj)
        {
            try
            {
                if (obj == null)
                    return "";
                return System.Convert.ToString(obj);
            }
            catch
            {
                return "";
            }
        }
        public static float ToFloat(object obj)
        {
            try
            {
                if (obj == null)
                    return 0;
                float rs = float.Parse(obj.ToString());
                if (rs < 0)
                    return 0;
                return rs;
            }
            catch
            {
                return 0;
            }
        }
        public static DateTime ToDateTime(object obj)
        {
            try
            {
                if (obj == null)
                    return DateTime.Now;
                DateTime dt = System.Convert.ToDateTime(obj, System.Globalization.CultureInfo.InvariantCulture);

                return dt;
            }
            catch
            {
                return DateTime.Now;
            }
        }
        public static Guid ToGuid(object obj)
        {
            try
            {
                if (obj == null)
                    return Guid.Empty;
                Guid dt = new Guid(obj.ToString());
                return dt;
            }
            catch
            {
                return Guid.Empty;
            }
        }

        public static string StripDiacritics(string accented)
        {
            return Regex.Replace(StripDiacriticsNormalize(accented), @"\s+", "-");
        }
        public static string StripDiacriticsNormalize(string accented)
        {
            Regex regex = new Regex(@"\p{IsCombiningDiacriticalMarks}+");
            string strFormD = accented.Normalize(System.Text.NormalizationForm.FormD);
            strFormD = regex.Replace(strFormD, String.Empty);
            strFormD = strFormD.Replace("Đ", "D").Replace("đ", "d");
            return Regex.Replace(strFormD, @"[^A-Za-z0-9 ]", "").Trim().ToLower();
        }
        const string HTML_TAG_PATTERN = "<.*?>";

        public static string StripHTML(object inputString, int charactor)
        {
            string str = Regex.Replace(ConvertType.ToString(inputString), HTML_TAG_PATTERN, string.Empty);
            if (str.Length > charactor)
                return str.Substring(0, charactor) + "...";
            return str;
        }
        public static string StripHTML(object inputString)
        {
            string str = Regex.Replace(ConvertType.ToString(inputString), HTML_TAG_PATTERN, string.Empty);
            return str;
        }
        public static string Encode(object str)
        {
            byte[] encbuff = System.Text.Encoding.UTF8.GetBytes(str.ToString());
            return Convert.ToBase64String(encbuff);
        }
        public static string Decode(object str)
        {
            byte[] decbuff = Convert.FromBase64String(str.ToString());
            return System.Text.Encoding.UTF8.GetString(decbuff);
        }
        public static string getTime120(System.DateTime dt)
        {
            int dd = dt.Day;
            int mm = dt.Month;
            int yy = dt.Year;
            int hh = dt.Hour;
            int min = dt.Minute;
            int ss = dt.Second;
            return string.Concat(new string[]
            {
        "convert(datetime,'",
        yy.ToString(),
        "-",
        mm.ToString(),
        "-",
        dd.ToString(),
        " ",
        hh.ToString(),
        ":",
        min.ToString(),
        ":",
        ss.ToString(),
        "',120)"
            });
        }


        //public static string GetXMLFromObject(object dataToSerialize)
        //{
        //    if (dataToSerialize == null) return null;

        //    using (StringWriter stringwriter = new System.IO.StringWriter())
        //    {
        //        var serializer = new XmlSerializer(dataToSerialize.GetType());
        //        serializer.Serialize(stringwriter, dataToSerialize);
        //        return stringwriter.ToString();
        //    }
        //}


        public static string GetXMLFromObject(object o)
        {
            StringWriter sw = new StringWriter();
            XmlTextWriter tw = null;
            try
            {
                XmlSerializer serializer = new XmlSerializer(o.GetType());
                tw = new XmlTextWriter(sw);
                serializer.Serialize(tw, o);
            }
            catch (Exception ex)
            {
                //Handle Exception Code
            }
            finally
            {
                sw.Close();
                if (tw != null)
                {
                    tw.Close();
                }
            }
            return sw.ToString();
        }


    }


    public class ExcelAdapter
    {
        protected string sFilePath;
        public string SFilePath {
            get { if (sFilePath == null) return ""; return sFilePath; }
            set { sFilePath = value; }
        }

        public ExcelAdapter(string filePath)
        {
            this.SFilePath = filePath;
        }

        public bool DeleteFile()
        {
            if (File.Exists(this.SFilePath))
            {
                File.Delete(this.SFilePath);
                return true;
            }
            else
                return false;
        }

        public bool IsExist()
        {
            return File.Exists(this.SFilePath);
        }

        public DataTable ReadFromFile(string commandText)
        {
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + this.sFilePath + ";Extended Properties=\"Excel 8.0;HDR=YES;\"";



            DbProviderFactory factory = DbProviderFactories.GetFactory("System.Data.OleDb");

            DbDataAdapter adapter = factory.CreateDataAdapter();

            DbCommand selectCommand = factory.CreateCommand();
            selectCommand.CommandText = commandText;

            DbConnection connection = factory.CreateConnection();
            connection.ConnectionString = connectionString;

            selectCommand.Connection = connection;

            adapter.SelectCommand = selectCommand;

            DataSet cities = new DataSet();

            adapter.Fill(cities);

            connection.Close();
            adapter.Dispose();

            return cities.Tables[0];
        }

        protected void FormatDate(COMExcel.Worksheet sheet, int rstart, int cstart, int rend, int cend)
        {
            COMExcel.Range range = (COMExcel.Range)sheet.Range[sheet.Cells[rstart, cstart], sheet.Cells[rend, cend]];
            range.NumberFormat = "DD/MM/YYYY";
        }

        protected void FormatMoney(COMExcel.Worksheet sheet, int rstart, int cstart, int rend, int cend)
        {
            COMExcel.Range range = (COMExcel.Range)sheet.Range[sheet.Cells[rstart, cstart], sheet.Cells[rend, cend]];
            range.NumberFormat = "#,##0";
        }

        protected void Format(COMExcel.Worksheet sheet, int rstart, int cstart, int rend, int cend, string type)
        {
            COMExcel.Range range = (COMExcel.Range)sheet.Range[sheet.Cells[rstart, cstart], sheet.Cells[rend, cend]];
            range.NumberFormat = type;
        }

        public string CreateAndWrite(DataTable dt, string sheetName, int noSheet)
        {
            using (new ExcelUILanguageHelper())
            {
                COMExcel.Application exApp = new COMExcel.Application();
                COMExcel.Workbook exBook = exApp.Workbooks.Add(
                              COMExcel.XlWBATemplate.xlWBATWorksheet);
                try
                {
                    // Không hiển thị chương trình excel
                    exApp.Visible = false;

                    // Lấy sheet 1.
                    COMExcel.Worksheet exSheet = (COMExcel.Worksheet)exBook.Worksheets[noSheet];
                    exSheet.Name = sheetName;

                    //////////////////////
                    int rowCount = dt.Rows.Count;
                    int colCount = dt.Columns.Count;

                    // insert header name             
                    for (int j = 1; j <= colCount; j++)
                    {
                        exSheet.Cells[1, j] = dt.Columns[j - 1].Caption;
                    }

                    // format cho header
                    COMExcel.Range headr = (COMExcel.Range)exSheet.Range[exSheet.Cells[1, 1], exSheet.Cells[1, colCount]];
                    headr.Interior.Color = System.Drawing.Color.Gray.ToArgb();
                    headr.Font.Bold = true;
                    headr.Font.Name = "Arial";
                    headr.Font.Color = System.Drawing.Color.White.ToArgb();
                    headr.Cells.RowHeight = 30;
                    headr.Cells.ColumnWidth = 20;
                    headr.HorizontalAlignment = COMExcel.Constants.xlCenter;


                    //format cho cot ngay, tien, so
                    for (int i = 1; i <= colCount; i++)
                    {
                        if (dt.Columns[i - 1].DataType == Type.GetType("System.DateTime"))
                        {
                            FormatDate(exSheet, 2, i, rowCount + 1, i);
                        }
                        else if (dt.Columns[i - 1].DataType == Type.GetType("System.Decimal"))
                        {
                            Format(exSheet, 2, i, rowCount + 1, i, "##0.0");
                        }
                        else if (dt.Columns[i - 1].DataType == Type.GetType("System.Int64"))
                        {
                            FormatMoney(exSheet, 2, i, rowCount + 1, i);
                        }
                        else if (dt.Columns[i - 1].DataType == Type.GetType("System.Int32"))
                        {
                        }
                        else
                        {
                            Format(exSheet, 2, i, rowCount + 1, i, "@");
                        }
                    }
                    for (int i = 1; i <= rowCount; i++)
                    {
                        for (int j = 1; j <= colCount; j++)
                        {
                            exSheet.Cells[i + 1, j] = dt.Rows[i - 1][j - 1].ToString();
                        }
                    }

                    //format cho toan bo sheet
                    COMExcel.Range Sheet = (COMExcel.Range)exSheet.Range[exSheet.Cells[1, 1], exSheet.Cells[rowCount + 1, colCount]];
                    Sheet.Borders.Color = System.Drawing.Color.Black.ToArgb();
                    Sheet.WrapText = true;

                    // Save file
                    exBook.SaveAs(this.SFilePath, COMExcel.XlFileFormat.xlWorkbookNormal,
                                     null, null, false, false,
                                     COMExcel.XlSaveAsAccessMode.xlExclusive,
                                     false, false, false, false, false);


                    return "Export file excel thành công.\nĐường dẫn là: " + this.sFilePath;
                }
                catch (Exception ex)
                {
                    Thread.CurrentThread.CurrentCulture.DateTimeFormat = new System.Globalization.CultureInfo("en-US").DateTimeFormat;
                    return ex.ToString();
                }
                finally
                {
                    Thread.CurrentThread.CurrentCulture.DateTimeFormat = new System.Globalization.CultureInfo("en-US").DateTimeFormat;
                    // Đóng chương trình
                    exBook.Close(false, false, false);
                    exApp.Quit();
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(exBook);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(exApp);
                }
            }
        }

        public string CreateAndWrite(DataTable[] dtList, string[] sheetNames)
        {
            using (new ExcelUILanguageHelper())
            {
                COMExcel.Application exApp = new COMExcel.Application();
                COMExcel.Workbook exBook = exApp.Workbooks.Add(
                              COMExcel.XlWBATemplate.xlWBATWorksheet);
                try
                {
                    // Không hiển thị chương trình excel
                    exApp.Visible = false;

                    //List<COMExcel.Worksheet> exSheetList = new List<Microsoft.Office.Interop.Excel.Worksheet>();
                    for (int i = 1; i < dtList.Length; i++)
                    {
                        //exSheetList.Add((COMExcel.Worksheet)exBook.Worksheets[i]);
                        exBook.Worksheets.Add(Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                    }
                    int noSheet = 1;
                    foreach (DataTable dt in dtList)
                    {
                        COMExcel.Worksheet exSheet = (COMExcel.Worksheet)exBook.Worksheets[noSheet];
                        exSheet.Name = sheetNames[noSheet - 1];

                        //////////////////////
                        int rowCount = dt.Rows.Count;
                        int colCount = dt.Columns.Count;

                        // insert header name             
                        for (int j = 1; j <= colCount; j++)
                        {
                            exSheet.Cells[1, j] = dt.Columns[j - 1].Caption;
                        }

                        // format cho header
                        COMExcel.Range headr = (COMExcel.Range)exSheet.Range[exSheet.Cells[1, 1], exSheet.Cells[1, colCount]];
                        headr.Interior.Color = System.Drawing.Color.Gray.ToArgb();
                        headr.Font.Bold = true;
                        headr.Font.Name = "Arial";
                        headr.Font.Color = System.Drawing.Color.White.ToArgb();
                        headr.Cells.RowHeight = 30;
                        headr.Cells.ColumnWidth = 20;
                        headr.HorizontalAlignment = COMExcel.Constants.xlCenter;


                        //format cho cot ngay, tien, so
                        for (int i = 1; i <= colCount; i++)
                        {
                            if (dt.Columns[i - 1].DataType == Type.GetType("System.DateTime"))
                            {
                                FormatDate(exSheet, 2, i, rowCount + 1, i);
                            }
                            else if (dt.Columns[i - 1].DataType == Type.GetType("System.Decimal"))
                            {
                                Format(exSheet, 2, i, rowCount + 1, i, "##0.0");
                            }
                            else if (dt.Columns[i - 1].DataType == Type.GetType("System.Int64"))
                            {
                                FormatMoney(exSheet, 2, i, rowCount + 1, i);
                            }
                            else if (dt.Columns[i - 1].DataType == Type.GetType("System.Int32"))
                            {
                            }
                            else
                            {
                                Format(exSheet, 2, i, rowCount + 1, i, "@");
                            }
                        }

                        for (int i = 1; i <= rowCount; i++)
                        {
                            for (int j = 1; j <= colCount; j++)
                            {
                                exSheet.Cells[i + 1, j] = dt.Rows[i - 1][j - 1].ToString();
                            }
                        }

                        //format cho toan bo sheet
                        COMExcel.Range Sheet = (COMExcel.Range)exSheet.Range[exSheet.Cells[1, 1], exSheet.Cells[rowCount + 1, colCount]];
                        Sheet.Borders.Color = System.Drawing.Color.Black.ToArgb();
                        Sheet.WrapText = true;

                        noSheet++;
                    }
                    // Save file
                    exBook.SaveAs(this.SFilePath, COMExcel.XlFileFormat.xlWorkbookNormal,
                                    null, null, false, false,
                                    COMExcel.XlSaveAsAccessMode.xlExclusive,
                                    false, false, false, false, false);


                    return "Export file excel thành công.\nĐường dẫn là: " + this.sFilePath;
                }
                catch (Exception ex)
                {
                    Thread.CurrentThread.CurrentCulture.DateTimeFormat = new System.Globalization.CultureInfo("en-US").DateTimeFormat;
                    return ex.ToString();
                }
                finally
                {
                    Thread.CurrentThread.CurrentCulture.DateTimeFormat = new System.Globalization.CultureInfo("en-US").DateTimeFormat;
                    // Đóng chương trình
                    exBook.Close(false, false, false);
                    exApp.Quit();
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(exBook);
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(exApp);
                }
            }
        }

        public class ExcelUILanguageHelper : IDisposable
        {
            private System.Globalization.CultureInfo m_CurrentCulture;

            public ExcelUILanguageHelper()
            {
                // save current culture and set culture to en-US            
                Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                m_CurrentCulture = Thread.CurrentThread.CurrentCulture;
                m_CurrentCulture.DateTimeFormat.ShortDatePattern = "MM/dd/yyyy";
            }

            #region IDisposable Members

            public void Dispose()
            {
                // return to normal culture
                Thread.CurrentThread.CurrentCulture = m_CurrentCulture;
            }

            #endregion
        }

    }
}

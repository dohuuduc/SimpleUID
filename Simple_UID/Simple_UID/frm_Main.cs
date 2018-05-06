using FlatUI;
using Microsoft.CSharp.RuntimeBinder;
using Microsoft.VisualBasic;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace Simple_UID {
  public class frm_Main: Form {
    [CompilerGenerated]
    private sealed class Class0 {
      public string string_0;

      public frm_Main frm_Main_0;

      internal void method_0() {
        this.frm_Main_0.friendsofuid(this.string_0, this.frm_Main_0.data_friends);
      }
    }

    [CompilerGenerated]
    private sealed class Class1 {
      public DataGridView dataGridView_0;

      public string string_0;

      public frm_Main frm_Main_0;

      public MethodInvoker methodInvoker_0;

      internal void method_0() {
        this.frm_Main_0.status.Text = string.Concat(new object[]
        {
          "Quét thành công. (",
          this.string_0,
          "/",
          this.dataGridView_0.Rows.Count,
          ")"
        });
      }
    }

    [CompilerGenerated]
    private sealed class Class2 {
      public string string_0;

      public string string_1;

      public string string_2;

      public string string_3;

      public string string_4;

      public string string_5;

      public string string_6;

      public frm_Main.Class1 class1_0;

      internal void method_0() {
        this.class1_0.dataGridView_0.Rows.Add(new object[]
        {
          this.class1_0.dataGridView_0.Rows.Count,
          this.string_0,
          this.string_1,
          this.string_2,
          this.string_3,
          this.string_4,
          this.string_5,
          this.string_6
        });
      }
    }

    [CompilerGenerated]
    private sealed class Class3 {
      public DataGridView dataGridView_0;

      public string string_0;

      public frm_Main frm_Main_0;

      public MethodInvoker methodInvoker_0;

      internal void method_0() {
        this.frm_Main_0.status.Text = string.Concat(new object[]
        {
          "Quét thành công. (",
          this.string_0,
          "/",
          this.dataGridView_0.Rows.Count,
          ")"
        });
      }
    }

    [CompilerGenerated]
    private sealed class Class4 {
      public string string_0;

      public string string_1;

      public string string_2;

      public string string_3;

      public string string_4;

      public string string_5;

      public string string_6;

      public frm_Main.Class3 class3_0;

      internal void method_0() {
        this.class3_0.dataGridView_0.Rows.Add(new object[]
        {
          this.class3_0.dataGridView_0.Rows.Count,
          this.string_0,
          this.string_1,
          this.string_2,
          this.string_3,
          this.string_4,
          this.string_5,
          this.string_6
        });
      }
    }

    [CompilerGenerated]
    private sealed class Class5 {
      public string[] string_0;

      public frm_Main frm_Main_0;

      internal void method_0() {
        this.frm_Main_0.loc(this.string_0);
      }
    }

    [CompilerGenerated]
    private sealed class Class6 {
      public string string_0;

      public frm_Main frm_Main_0;

      internal void method_0() {
        this.frm_Main_0.membersofgid(this.string_0, this.frm_Main_0.datamembers);
      }
    }

    [CompilerGenerated]
    private sealed class Class7 {
      public string[] string_0;

      public frm_Main frm_Main_0;

      internal void method_0() {
        this.frm_Main_0.loc2(this.string_0);
      }
    }

    [CompilerGenerated]
    private sealed class Class8 {
      public string string_0;

      public frm_Main frm_Main_0;

      internal void method_0() {
        this.frm_Main_0.getcmt(this.string_0, this.frm_Main_0.data_cmt);
      }
    }

    [CompilerGenerated]
    private sealed class Class9 {
      public DataGridView dataGridView_0;

      public string string_0;

      public frm_Main frm_Main_0;

      public MethodInvoker methodInvoker_0;

      internal void method_0() {
        this.frm_Main_0.status.Text = string.Concat(new object[]
        {
          "Quét thành công. (",
          this.string_0,
          "/",
          this.dataGridView_0.Rows.Count,
          ")"
        });
      }
    }

    [CompilerGenerated]
    private sealed class Class10 {
      public string string_0;

      public string string_1;

      public string string_2;

      public string string_3;

      public string string_4;

      public string string_5;

      public string string_6;

      public string string_7;

      public frm_Main.Class9 class9_0;

      internal void method_0() {
        this.class9_0.dataGridView_0.Rows.Add(new object[]
        {
          this.class9_0.dataGridView_0.Rows.Count,
          this.string_0,
          this.string_1,
          this.string_2,
          this.string_3,
          this.string_4,
          this.string_5,
          this.string_6,
          this.string_7
        });
      }
    }

    [CompilerGenerated]
    private static class Class11 {
      public static CallSite<Func<CallSite, object, object>> callSite_0;

      public static CallSite<Func<CallSite, object, string, object>> callSite_1;

      public static CallSite<Func<CallSite, object, string>> callSite_2;

      public static CallSite<Func<CallSite, object, string, object>> callSite_3;

      public static CallSite<Func<CallSite, object, string>> callSite_4;

      public static CallSite<Func<CallSite, object, string, object>> callSite_5;

      public static CallSite<Func<CallSite, object, string>> callSite_6;

      public static CallSite<Func<CallSite, object, string, object>> callSite_7;

      public static CallSite<Func<CallSite, object, string>> callSite_8;

      public static CallSite<Func<CallSite, object, string, object>> callSite_9;

      public static CallSite<Func<CallSite, object, string>> callSite_10;

      public static CallSite<Func<CallSite, object, string, object>> callSite_11;

      public static CallSite<Func<CallSite, object, string>> callSite_12;

      public static CallSite<Func<CallSite, object, string, object>> callSite_13;

      public static CallSite<Func<CallSite, object, object, object>> callSite_14;

      public static CallSite<Func<CallSite, object, bool>> callSite_15;

      public static CallSite<Func<CallSite, object, string, object>> callSite_16;

      public static CallSite<Func<CallSite, object, string, object>> callSite_17;

      public static CallSite<Func<CallSite, object, string>> callSite_18;
    }

    [CompilerGenerated]
    private sealed class Class12 {
      public DataGridView dataGridView_0;

      public string string_0;

      public frm_Main frm_Main_0;

      public MethodInvoker methodInvoker_0;

      internal void method_0() {
        this.frm_Main_0.status.Text = string.Concat(new object[]
        {
          "Quét thành công. (",
          this.string_0,
          "/",
          this.dataGridView_0.Rows.Count,
          ")"
        });
      }

      internal void method_1() {
        this.frm_Main_0.status.Text = "Kết nối thất bại " + this.string_0;
      }
    }

    [CompilerGenerated]
    private sealed class Class13 {
      public string string_0;

      public string string_1;

      public string string_2;

      public string string_3;

      public string string_4;

      public string string_5;

      public string string_6;

      public frm_Main.Class12 class12_0;

      internal void method_0() {
        this.class12_0.dataGridView_0.Rows.Add(new object[]
        {
          this.class12_0.dataGridView_0.Rows.Count,
          this.string_0,
          this.string_1,
          this.string_2,
          this.string_3,
          this.string_4,
          this.string_5,
          this.string_6
        });
      }
    }

    [CompilerGenerated]
    private sealed class Class14 {
      public string[] string_0;

      public frm_Main frm_Main_0;

      internal void method_0() {
        this.frm_Main_0.loc3(this.string_0);
      }
    }

    [CompilerGenerated]
    private sealed class Class15 {
      public string[] string_0;

      public frm_Main frm_Main_0;

      internal void method_0() {
        this.frm_Main_0.loc4(this.string_0);
      }
    }

    [CompilerGenerated]
    private sealed class Class16 {
      public string string_0;

      public frm_Main frm_Main_0;

      internal void method_0() {
        this.frm_Main_0.getlike(this.string_0, this.frm_Main_0.data_like);
      }
    }

    [CompilerGenerated]
    private sealed class Class17 {
      public string string_0;

      public frm_Main frm_Main_0;

      internal void method_0() {
        this.frm_Main_0.getfeed(this.string_0, this.frm_Main_0.data_feed);
      }
    }

    [CompilerGenerated]
    private sealed class Class18 {
      public DataGridView dataGridView_0;

      public string string_0;

      public frm_Main frm_Main_0;

      public MethodInvoker methodInvoker_0;

      internal void method_0() {
        this.frm_Main_0.status.Text = string.Concat(new object[]
        {
          "Quét thành công. (",
          this.string_0,
          "/",
          this.dataGridView_0.Rows.Count,
          ")"
        });
      }
    }

    [CompilerGenerated]
    private sealed class Class19 {
      public string string_0;

      public string string_1;

      public string string_2;

      public string string_3;

      public string string_4;

      public frm_Main.Class18 class18_0;

      internal void method_0() {
        this.class18_0.dataGridView_0.Rows.Add(new object[]
        {
          this.class18_0.dataGridView_0.Rows.Count,
          this.string_0,
          this.string_1,
          this.string_2,
          this.string_3,
          this.string_4
        });
      }
    }

    [CompilerGenerated]
    private sealed class Class20 {
      public string[] string_0;

      public frm_Main frm_Main_0;

      internal void method_0() {
        this.frm_Main_0.loc5(this.string_0);
      }
    }

    [CompilerGenerated]
    private sealed class Class21 {
      public List<string> list_0;

      public frm_Main frm_Main_0;

      internal void method_0() {
        this.frm_Main_0.loc4(this.list_0.ToArray());
      }
    }

    [CompilerGenerated]
    private sealed class Class22 {
      public List<string> list_0;

      public frm_Main frm_Main_0;

      internal void method_0() {
        this.frm_Main_0.loc3(this.list_0.ToArray());
      }
    }

    public string String_0 {
      get { return string_0; }
      set { string_0 = value; }
    }

    private string string_0 = "";

    private string string_1 = "";

    private string string_2 = "";

    private IContainer icontainer_0 = null;

    private FlatClose flatClose1;

    private FlatTabControl flatTabControl1;

    private TabPage tabPage1;

    private TabPage tabPage2;

    private FormSkin formSkin1;

    private TabPage tabPage3;

    private TabPage tabPage4;

    private DataGridView data_friends;

    private FlatButton btn_get_friends_from_file;

    private FlatButton flatButton3;

    private FlatButton flatButton2;

    private FlatButton btn_get_friends_1_uid;

    private FlatAlertBox status;

    private FlatProgressBar process;

    private FlatButton flatButton1;

    private FlatButton flatButton4;

    private FlatButton flatButton5;

    private FlatButton flatButton6;

    private DataGridView datamembers;

    private TabPage tabPage5;

    private FlatButton flatButton7;

    private FlatButton flatButton8;

    private FlatButton flatButton9;

    private FlatButton flatButton10;

    private DataGridView data_like;

    private FlatButton flatButton11;

    private FlatButton flatButton12;

    private FlatButton flatButton13;

    private FlatButton flatButton14;

    private DataGridView data_cmt;

    private FlatButton flatButton15;

    private FlatButton flatButton16;

    private FlatButton flatButton17;

    private FlatButton flatButton18;

    private FlatLabel flatLabel1;

    private DataGridView data_feed;

    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;

    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;

    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;

    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;

    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;

    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;

    private FlatButton flatButton19;

    private FlatButton flatButton20;

    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

    private DataGridViewTextBoxColumn fullname;

    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

    private DataGridViewTextBoxColumn gender;

    private DataGridViewTextBoxColumn bd;

    private DataGridViewTextBoxColumn email;

    private DataGridViewTextBoxColumn sdt;

    private DataGridViewTextBoxColumn location;

    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;

    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;

    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;

    private DataGridViewTextBoxColumn SDTDasmdas;

    private DataGridViewTextBoxColumn locationccnsac;

    private FlatButton flatButton22;

    private FlatButton flatButton23;

    private FlatButton flatButton24;

    private FlatButton flatButton25;

    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;

    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;

    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;

    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;

    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;

    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;

    private DataGridViewTextBoxColumn sdt2;

    private DataGridViewTextBoxColumn nca;

    private DataGridViewTextBoxColumn Column1;

    private FlatButton flatButton26;

    private FlatButton flatButton27;

    private NumericUpDown limit_request;

    private LinkLabel linkLabel3;

    private LinkLabel linkLabel2;

    private LinkLabel linkLabel1;

    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;

    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;

    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;

    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;

    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;

    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;

    private DataGridViewTextBoxColumn SDT22;
    private DataGridViewTextBoxColumn STT;
    private DataGridViewTextBoxColumn UID;
    private DataGridViewTextBoxColumn Locationsss;

    public frm_Main() {
      this.InitializeComponent();
      this.status.Visible = true;
      this.status.kind = FlatAlertBox._Kind.Info;
      try {
        string text = File.ReadAllText("token.txt");
        this.string_0 = text.Split(new char[]
        {
          '|'
        })[2];
        this.string_1 = text.Split(new char[]
        {
          '|'
        })[3];
        this.string_2 = text.Split(new char[]
        {
          '|'
        })[1];
        string a = this.gethtml("https://graph.facebook.com/me?access_token=" + this.string_0);
        if(a == "") {
          this.string_0 = "";
        }
      } catch {
      }
    }

    public string gethtml(string Url) {
      string result;
      try {
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
      } catch {
        result = "";
      }
      return result;
    }

    public void get_cookie(string cookie_z) {
      if(cookie_z == "x") {
        this.string_0 = "x";
        base.Close();
        Application.Exit();
      } else {
        this.string_0 = cookie_z;
      }
    }

    private void frm_Main_Load(object sender, EventArgs e) {
      while(this.string_0 == "") {
        new frm_Login {
          mycookie = new frm_Login.get_cookie(this.get_cookie)
        }.ShowDialog();
      }
    }

    private void btn_get_friends_1_uid_Click(object sender, EventArgs e) {
      frm_Main.Class0 @class = new frm_Main.Class0();
      @class.frm_Main_0 = this;
      @class.string_0 = Interaction.InputBox("Vui lòng nhập UID?", "Nhập 1 UID", "me", -1, -1);
      if(@class.string_0.Length > 0) {
        Thread thread = new Thread(new ThreadStart(@class.method_0));
        thread.Start();
      }
    }

    public void membersofgid(string gid, DataGridView dgv) {
      frm_Main.Class1 @class = new frm_Main.Class1();
      @class.frm_Main_0 = this;
      @class.dataGridView_0 = dgv;
      @class.string_0 = gid;
      try {
        string requestUriString = "https://graph.facebook.com/" + @class.string_0 + "/members?limit=500&fields=id,name,birthday,email,gender,mobile_phone,location&access_token=" + this.string_0;
        bool flag = true;
        while(flag) {
          HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUriString);
          httpWebRequest.UserAgent = "Dalvik/1.6.0 (Linux; U; Android 4.3; Z10 Build/10.3.2.110) [FBAN/FB4A;FBAV/19.0.0.23.14;FBLC/vi_VN;FBBV/4694056;FBCR/null;FBMF/RIM;FBBD/BlackBerry;FBDV/Z10;FBSV/4.3;FBCA/armeabi-v7a:armeabi;FBDM/{density=2.0,width=768,height=1174};FB_FW/1;]";
          HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
          string json = new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd();
          JObject jObject = JObject.Parse(json);
          foreach(JToken current in ((IEnumerable<JToken>)jObject["data"])) {
            frm_Main.Class2 class2 = new frm_Main.Class2();
            class2.class1_0 = @class;
            class2.string_1 = (string)current["id"];
            class2.string_0 = (string)current["name"];
            class2.string_2 = (string)current["gender"];
            class2.string_3 = (string)current["birthday"];
            class2.string_4 = (string)current["email"];
            class2.string_5 = (string)current["mobile_phone"];
            class2.string_6 = "";
            if(current["location"] != null) {
              class2.string_6 = (string)current["location"]["name"];
            }
            base.Invoke(new MethodInvoker(class2.method_0));
          }
          if(jObject["paging"]["next"] != null) {
            requestUriString = (string)jObject["paging"]["next"];
          } else {
            flag = false;
          }
          MethodInvoker arg_209_1;
          if((arg_209_1 = @class.methodInvoker_0) == null) {
            arg_209_1 = (@class.methodInvoker_0 = new MethodInvoker(@class.method_0));
          }
          base.Invoke(arg_209_1);
        }
      } catch {
        base.Invoke(new MethodInvoker(this.method_1));
      }
    }

    public void friendsofuid(string uid, DataGridView dgv) {
      frm_Main.Class3 @class = new frm_Main.Class3();
      @class.frm_Main_0 = this;
      @class.dataGridView_0 = dgv;
      @class.string_0 = uid;
      try {
        string requestUriString = "https://graph.facebook.com/" + @class.string_0 + "/friends?limit=500&fields=id,name,mobile_phone,birthday,email,gender,location&access_token=" + this.string_0;
        bool flag = true;
        while(flag) {
          HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUriString);
          httpWebRequest.UserAgent = "Dalvik/1.6.0 (Linux; U; Android 4.3; Z10 Build/10.3.2.110) [FBAN/FB4A;FBAV/19.0.0.23.14;FBLC/vi_VN;FBBV/4694056;FBCR/null;FBMF/RIM;FBBD/BlackBerry;FBDV/Z10;FBSV/4.3;FBCA/armeabi-v7a:armeabi;FBDM/{density=2.0,width=768,height=1174};FB_FW/1;]";
          HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
          string json = new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd();
          JObject jObject = JObject.Parse(json);
          foreach(JToken current in ((IEnumerable<JToken>)jObject["data"])) {
            frm_Main.Class4 class2 = new frm_Main.Class4();
            class2.class3_0 = @class;
            class2.string_1 = (string)current["id"];
            class2.string_0 = (string)current["name"];
            class2.string_2 = (string)current["gender"];
            class2.string_3 = (string)current["birthday"];
            class2.string_5 = (string)current["mobile_phone"];
            class2.string_6 = "";
            if(current["location"] != null) {
              class2.string_6 = (string)current["location"]["name"];
            }
            class2.string_4 = (string)current["email"];
            base.Invoke(new MethodInvoker(class2.method_0));
          }
          if(jObject["paging"]["next"] != null) {
            requestUriString = (string)jObject["paging"]["next"];
          } else {
            flag = false;
          }
          MethodInvoker arg_209_1;
          if((arg_209_1 = @class.methodInvoker_0) == null) {
            arg_209_1 = (@class.methodInvoker_0 = new MethodInvoker(@class.method_0));
          }
          base.Invoke(arg_209_1);
        }
      } catch {
        base.Invoke(new MethodInvoker(this.method_2));
      }
    }

    private void btn_get_friends_from_file_Click(object sender, EventArgs e) {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
      openFileDialog.FilterIndex = 1;
      openFileDialog.Multiselect = false;
      if(openFileDialog.ShowDialog() == DialogResult.OK) {
        try {
          frm_Main.Class5 @class = new frm_Main.Class5();
          @class.frm_Main_0 = this;
          @class.string_0 = File.ReadAllLines(openFileDialog.FileName);
          this.process.Maximum = @class.string_0.Count<string>();
          Path.GetDirectoryName(openFileDialog.FileName);
          Thread thread = new Thread(new ThreadStart(@class.method_0));
          thread.Start();
        } catch {
        }
      }
    }

    public void loc(string[] list) {
      for(int i = 0; i < list.Length; i++) {
        string text = list[i];
        base.Invoke(new MethodInvoker(this.method_3));
        try {
          this.friendsofuid(text.Split(new char[]
          {
            '|'
          })[0], this.data_friends);
        } catch {
        }
      }
    }

    public void loc2(string[] list) {
      for(int i = 0; i < list.Length; i++) {
        string text = list[i];
        base.Invoke(new MethodInvoker(this.method_4));
        try {
          this.membersofgid(text.Split(new char[]
          {
            '|'
          })[0], this.datamembers);
        } catch {
        }
      }
    }

    public void loc3(string[] list) {
      for(int i = 0; i < list.Length; i++) {
        string text = list[i];
        base.Invoke(new MethodInvoker(this.method_5));
        try {
          this.getcmt(text.Split(new char[]
          {
            '|'
          })[0], this.data_cmt);
        } catch {
        }
      }
    }

    public void loc4(string[] list) {
      for(int i = 0; i < list.Length; i++) {
        string text = list[i];
        base.Invoke(new MethodInvoker(this.method_6));
        try {
          this.getlike(text.Split(new char[]
          {
            '|'
          })[0], this.data_like);
        } catch {
        }
      }
    }

    public void loc5(string[] list) {
      for(int i = 0; i < list.Length; i++) {
        string text = list[i];
        base.Invoke(new MethodInvoker(this.method_7));
        try {
          this.getfeed(text.Split(new char[]
          {
            '|'
          })[0], this.data_feed);
        } catch {
        }
      }
    }

    private void flatButton2_Click(object sender, EventArgs e) {
      this.data_friends.Rows.Clear();
    }

    private void flatButton3_Click(object sender, EventArgs e) {
      this.savefile(this.data_friends);
    }

    public void savefile(DataGridView dtg) {
      DialogResult dialogResult = MessageBox.Show("Bạn có muốn lưu đầy đủ thông tin?. Chọn NO để lưu chỉ ID", "Lưu đầy đủ", MessageBoxButtons.YesNo);
      if(dialogResult == DialogResult.Yes) {
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.FileName = "Xuất File-" + DateTime.Now.ToString("MM-dd-yyyy-HH-mm-ss-fff") + ".xls";
        saveFileDialog.Filter = "Text File | *.xls";
        if(saveFileDialog.ShowDialog() != DialogResult.OK) {
          return;
        }
        this.status.Text = "Đang lưu file...";
        try {
          StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName, false, Encoding.Unicode);
          for(int i = 0; i <= dtg.Rows.Count - 1; i++) {
            string text = "";
            for(int j = 0; j <= dtg.Columns.Count - 1; j++) {
              if(dtg.Rows[i].Cells[j].Value != null) {
                string text2 = dtg.Rows[i].Cells[j].Value.ToString();
                if(text2.Length < 100) {
                  text = text + dtg.Rows[i].Cells[j].Value.ToString() + "\t";
                } else {
                  text += "ẩn\t";
                }
              } else {
                text += "\t";
              }
            }
            streamWriter.WriteLine(text);
          }
          streamWriter.Dispose();
          streamWriter.Close();
          this.status.Text = "Xuất file Excel thành công.";
          return;
        } catch(Exception ex) {
          this.status.Text = ex.Message;
          return;
        }
      }
      if(dialogResult == DialogResult.No) {
        SaveFileDialog saveFileDialog2 = new SaveFileDialog();
        saveFileDialog2.FileName = "Xuất File-" + DateTime.Now.ToString("MM-dd-yyyy-HH-mm-ss-fff") + ".txt";
        saveFileDialog2.Filter = "Text File | *.txt";
        if(saveFileDialog2.ShowDialog() == DialogResult.OK) {
          this.status.Text = "Đang lưu file...";
          try {
            StreamWriter streamWriter2 = new StreamWriter(saveFileDialog2.FileName, false, Encoding.Unicode);
            for(int k = 0; k <= dtg.Rows.Count - 1; k++) {
              string text3 = "";
              text3 = text3 + dtg.Rows[k].Cells[2].Value.ToString() + "\n";
              streamWriter2.WriteLine(text3);
            }
            streamWriter2.Dispose();
            streamWriter2.Close();
            this.status.Text = "Xuất file TXT thành công.";
          } catch(Exception) {
          }
        }
      }
    }

    private void flatButton6_Click(object sender, EventArgs e) {
      frm_Main.Class6 @class = new frm_Main.Class6();
      @class.frm_Main_0 = this;
      @class.string_0 = Interaction.InputBox("Vui lòng nhập GID?", "Nhập 1 GID", "", -1, -1);
      if(@class.string_0.Length > 0) {
        Thread thread = new Thread(new ThreadStart(@class.method_0));
        thread.Start();
      }
    }

    private void flatButton1_Click(object sender, EventArgs e) {
      this.datamembers.Rows.Clear();
    }

    private void flatButton4_Click(object sender, EventArgs e) {
      this.savefile(this.datamembers);
    }

    private void flatButton5_Click(object sender, EventArgs e) {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
      openFileDialog.FilterIndex = 1;
      openFileDialog.Multiselect = false;
      if(openFileDialog.ShowDialog() == DialogResult.OK) {
        try {
          frm_Main.Class7 @class = new frm_Main.Class7();
          @class.frm_Main_0 = this;
          @class.string_0 = File.ReadAllLines(openFileDialog.FileName);
          this.process.Maximum = @class.string_0.Count<string>();
          Path.GetDirectoryName(openFileDialog.FileName);
          Thread thread = new Thread(new ThreadStart(@class.method_0));
          thread.Start();
        } catch {
        }
      }
    }

    private void flatButton14_Click(object sender, EventArgs e) {
      frm_Main.Class8 @class = new frm_Main.Class8();
      @class.frm_Main_0 = this;
      @class.string_0 = Interaction.InputBox("Vui lòng nhập ID?", "Nhập 1 ID", "", -1, -1);
      if(@class.string_0.Length > 0) {
        Thread thread = new Thread(new ThreadStart(@class.method_0));
        thread.Start();
      }
    }

    public void getcmt(string uid, DataGridView dgv) {
      frm_Main.Class9 @class = new frm_Main.Class9();
      @class.frm_Main_0 = this;
      @class.dataGridView_0 = dgv;
      @class.string_0 = uid;
      try {
        string url = "https://graph.facebook.com/" + @class.string_0 + "/comments?limit=500&fields=message,from.location,from.birthday,from.email,from.gender,from.name,from.mobile_phone&access_token=" + this.string_0;
        bool flag = true;
        while(flag) {
          string json = this.gethtml(url);
          JObject jObject = JObject.Parse(json);
          foreach(JToken current in ((IEnumerable<JToken>)jObject["data"])) {
            frm_Main.Class10 class2 = new frm_Main.Class10();
            class2.class9_0 = @class;
            JToken jToken = current["from"];
            class2.string_1 = (string)jToken["id"];
            class2.string_0 = (string)jToken["name"];
            class2.string_2 = (string)jToken["gender"];
            class2.string_7 = (string)current["message"];
            class2.string_3 = (string)jToken["birthday"];
            class2.string_4 = (string)jToken["email"];
            class2.string_5 = (string)jToken["mobile_phone"];
            class2.string_6 = "";
            if(jToken["location"] != null) {
              class2.string_6 = (string)jToken["location"]["name"];
            }
            base.Invoke(new MethodInvoker(class2.method_0));
          }
          if(jObject["paging"]["next"] != null) {
            url = (string)jObject["paging"]["next"];
          } else {
            flag = false;
          }
          MethodInvoker arg_1FF_1;
          if((arg_1FF_1 = @class.methodInvoker_0) == null) {
            arg_1FF_1 = (@class.methodInvoker_0 = new MethodInvoker(@class.method_0));
          }
          base.Invoke(arg_1FF_1);
        }
      } catch(Exception) {
        base.Invoke(new MethodInvoker(this.method_8));
      }
    }

    public void getlike(string uid, DataGridView dgv) {
      frm_Main.Class12 @class = new frm_Main.Class12();
      @class.frm_Main_0 = this;
      @class.dataGridView_0 = dgv;
      @class.string_0 = uid;
      try {
        string requestUriString = "https://graph.facebook.com/" + @class.string_0 + "/likes?limit=30000&access_token=" + this.string_0;
        bool flag = true;
        bool flag2 = false;
        int num = 200;
        int num2 = 0;
        List<string> list = new List<string>();
        List<string> list2 = new List<string>();
        while(flag) {
          string text = "";
          if(!flag2) {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUriString);
            httpWebRequest.UserAgent = "Dalvik/1.6.0 (Linux; U; Android 4.3; Z10 Build/10.3.2.110) [FBAN/FB4A;FBAV/19.0.0.23.14;FBLC/vi_VN;FBBV/4694056;FBCR/null;FBMF/RIM;FBBD/BlackBerry;FBDV/Z10;FBSV/4.3;FBCA/armeabi-v7a:armeabi;FBDM/{density=2.0,width=768,height=1174};FB_FW/1;]";
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            string json = new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd();
            JObject jObject = JObject.Parse(json);
            foreach(JToken current in ((IEnumerable<JToken>)jObject["data"])) {
              string text2 = (string)current["id"];
              list.Add(text2);
              if(text2.Length > 10) {
                if(text2.Substring(0, 4) == "1000") {
                  text = text + text2 + ",";
                }
              } else {
                text = text + text2 + ",";
              }
            }
            if(text == "") {
              string requestUriString2 = "https://graph.facebook.com/" + @class.string_0 + "/reactions?summary=true&access_token=" + this.string_0;
              HttpWebRequest httpWebRequest2 = (HttpWebRequest)WebRequest.Create(requestUriString2);
              httpWebRequest2.UserAgent = "Dalvik/1.6.0 (Linux; U; Android 4.3; Z10 Build/10.3.2.110) [FBAN/FB4A;FBAV/19.0.0.23.14;FBLC/vi_VN;FBBV/4694056;FBCR/null;FBMF/RIM;FBBD/BlackBerry;FBDV/Z10;FBSV/4.3;FBCA/armeabi-v7a:armeabi;FBDM/{density=2.0,width=768,height=1174};FB_FW/1;]";
              HttpWebResponse httpWebResponse2 = (HttpWebResponse)httpWebRequest2.GetResponse();
              string json2 = new StreamReader(httpWebResponse2.GetResponseStream()).ReadToEnd();
              JObject jObject2 = JObject.Parse(json2);
              num2 = (int)jObject2["summary"]["total_count"];
              if(num2 > 0) {
                flag2 = true;
                if(num > num2 && num2 > 1) {
                  num = num2 - 1;
                }
              } else {
                flag = false;
              }
            }
            if(jObject["paging"]["next"] != null) {
              requestUriString = (string)jObject["paging"]["next"];
            }
          }
          if(flag2) {
            string[] array = @class.string_0.Split(new char[]
            {
              '_'
            });
            if(array.Length > 1) {
              @class.string_0 = @class.string_0.Split(new char[]
              {
                '_'
              })[1];
            }
            if(list.Count == 0) {
              requestUriString = string.Concat(new object[]
              {
                "https://www.facebook.com/ufi/reaction/profile/browser/fetch?limit=",
                num,
                "&total_count=",
                num2,
                "&ft_ent_identifier=",
                @class.string_0,
                "&dpr=2&__user=",
                this.string_2,
                "&__a=1&__dyn=5V4cjLx2ByK5A9UoGSF8CC5EWq2W8GAdyediheCHxG7Uqzob4q6oG8zFGUpxSaxu3ubG4UJu9x2axuF8iBAVXxWUPwzxGt0TyKdwJAAhKe-uumegmUOaAz8gCxm3i7oG9J4y8G6EhwCwBxq69LCx2i227Wxqp3FK5e9yEoxO5pVkdxCi79FEGqfxm2yWKu4ooAghzRGm5Apy8lwxgC8CwByXyU-8gmyES3m6pUydy9o_WUW264oW4ogyp8PxDAXCDU8JkiayUylwVBAyEiyprx6uegiVk&__req=10&__be=1&__pc=PHASED%3ADEFAULT&__rev=3637914&__spin_r=3637914&__spin_b=trunk&__spin_t=1518174310"
              });
            }
            HttpWebRequest httpWebRequest3 = (HttpWebRequest)WebRequest.Create(requestUriString);
            httpWebRequest3.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.186 Safari/537.36";
            string[] array2 = this.string_1.Split(new char[]
            {
              ';'
            });
            string[] array3 = array2[0].Split(new char[]
            {
              '='
            });
            string[] array4 = array2[1].Split(new char[]
            {
              '='
            });
            try {
              CookieContainer cookieContainer = new CookieContainer();
              Cookie cookie = new Cookie(array3[0].Trim(), array3[1].Trim(), "/", ".facebook.com");
              cookieContainer.Add(cookie);
              Cookie cookie2 = new Cookie(array4[0].Trim(), array4[1].Trim(), "/", ".facebook.com");
              cookieContainer.Add(cookie2);
              httpWebRequest3.CookieContainer = cookieContainer;
              goto IL_C45;
            } catch(Exception value) {
              Debug.Write(value);
              goto IL_C45;
            }
            IL_3AF:
            string[] array5;
            try {
              string text3 = array5[1];
              text3 = Regex.Split(text3, "\\\"")[0];
              string input = text3.Split(new char[]
              {
                '&'
              })[0];
              string[] array6 = Regex.Split(input, "\\\\u00252C");
              list.AddRange(array6);
              text3 = string.Join(",", array6);
              requestUriString = string.Concat(new object[]
              {
                "https://www.facebook.com/ufi/reaction/profile/browser/fetch?limit=",
                num,
                "&shown_ids=",
                text3,
                "&total_count=",
                num2,
                "&ft_ent_identifier=",
                @class.string_0,
                "&dpr=2&__user=",
                this.string_2,
                "&__a=1&__dyn=5V4cjLx2ByK5A9UoGSF8CC5EWq2W8GAdyediheCHxG7Uqzob4q6oG8zFGUpxSaxu3ubG4UJu9x2axuF8iBAVXxWUPwzxGt0TyKdwJAAhKe-uumegmUOaAz8gCxm3i7oG9J4y8G6EhwCwBxq69LCx2i227Wxqp3FK5e9yEoxO5pVkdxCi79FEGqfxm2yWKu4ooAghzRGm5Apy8lwxgC8CwByXyU-8gmyES3m6pUydy9o_WUW264oW4ogyp8PxDAXCDU8JkiayUylwVBAyEiyprx6uegiVk&__req=10&__be=1&__pc=PHASED%3ADEFAULT&__rev=3637914&__spin_r=3637914&__spin_b=trunk&__spin_t=1518174310"
              });
              text = "";
              if(array6.Length == 0) {
                flag = false;
              } else {
                int num3 = 0;
                while(num3 < array6.Length && num3 < 199) {
                  string text4 = array6[num3];
                  if(text4.Length > 10) {
                    if(text4.Substring(0, 4) == "1000") {
                      text = text + text4 + ",";
                    }
                  } else {
                    text = text + text4 + ",";
                  }
                  num3++;
                }
              }
              goto IL_4FD;
            } catch(Exception value2) {
              Debug.Write(value2);
              goto IL_4FD;
            }
            goto IL_4FB;
            IL_C45:
            HttpWebResponse httpWebResponse3 = (HttpWebResponse)httpWebRequest3.GetResponse();
            string input2 = new StreamReader(httpWebResponse3.GetResponseStream()).ReadToEnd();
            array5 = Regex.Split(input2, ";shown_ids=");
            if(array5.Length > 1) {
              goto IL_3AF;
            }
            IL_4FB:
            flag = false;
          }
          IL_4FD:
          try {
            text = text.Replace("\\u00252C", ",");
            string requestUriString3 = "https://graph.facebook.com/?ids=" + text.Substring(0, text.Length - 1) + "&access_token=" + this.string_0;
            HttpWebRequest httpWebRequest4 = (HttpWebRequest)WebRequest.Create(requestUriString3);
            httpWebRequest4.UserAgent = "Dalvik/1.6.0 (Linux; U; Android 4.3; Z10 Build/10.3.2.110) [FBAN/FB4A;FBAV/19.0.0.23.14;FBLC/vi_VN;FBBV/4694056;FBCR/null;FBMF/RIM;FBBD/BlackBerry;FBDV/Z10;FBSV/4.3;FBCA/armeabi-v7a:armeabi;FBDM/{density=2.0,width=768,height=1174};FB_FW/1;]";
            HttpWebResponse httpWebResponse4 = (HttpWebResponse)httpWebRequest4.GetResponse();
            string json3 = new StreamReader(httpWebResponse4.GetResponseStream()).ReadToEnd();
            JObject jObject3 = JObject.Parse(json3);
            foreach(object current2 in ((IEnumerable<JToken>)jObject3)) {
              frm_Main.Class13 class2 = new frm_Main.Class13();
              class2.class12_0 = @class;
              if(frm_Main.Class11.callSite_0 == null) {
                frm_Main.Class11.callSite_0 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "Value", typeof(frm_Main), new CSharpArgumentInfo[]
                {
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
                }));
              }
              object arg = frm_Main.Class11.callSite_0.Target(frm_Main.Class11.callSite_0, current2);
              frm_Main.Class13 arg_68A_0 = class2;
              if(frm_Main.Class11.callSite_2 == null) {
                frm_Main.Class11.callSite_2 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(frm_Main)));
              }
              Func<CallSite, object, string> arg_685_0 = frm_Main.Class11.callSite_2.Target;
              CallSite arg_685_1 = frm_Main.Class11.callSite_2;
              if(frm_Main.Class11.callSite_1 == null) {
                frm_Main.Class11.callSite_1 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(frm_Main), new CSharpArgumentInfo[]
                {
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
                }));
              }
              arg_68A_0.string_1 = arg_685_0(arg_685_1, frm_Main.Class11.callSite_1.Target(frm_Main.Class11.callSite_1, arg, "id"));
              frm_Main.Class13 arg_727_0 = class2;
              if(frm_Main.Class11.callSite_4 == null) {
                frm_Main.Class11.callSite_4 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(frm_Main)));
              }
              Func<CallSite, object, string> arg_722_0 = frm_Main.Class11.callSite_4.Target;
              CallSite arg_722_1 = frm_Main.Class11.callSite_4;
              if(frm_Main.Class11.callSite_3 == null) {
                frm_Main.Class11.callSite_3 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(frm_Main), new CSharpArgumentInfo[]
                {
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
                }));
              }
              arg_727_0.string_0 = arg_722_0(arg_722_1, frm_Main.Class11.callSite_3.Target(frm_Main.Class11.callSite_3, arg, "name"));
              frm_Main.Class13 arg_7C4_0 = class2;
              if(frm_Main.Class11.callSite_6 == null) {
                frm_Main.Class11.callSite_6 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(frm_Main)));
              }
              Func<CallSite, object, string> arg_7BF_0 = frm_Main.Class11.callSite_6.Target;
              CallSite arg_7BF_1 = frm_Main.Class11.callSite_6;
              if(frm_Main.Class11.callSite_5 == null) {
                frm_Main.Class11.callSite_5 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(frm_Main), new CSharpArgumentInfo[]
                {
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
                }));
              }
              arg_7C4_0.string_2 = arg_7BF_0(arg_7BF_1, frm_Main.Class11.callSite_5.Target(frm_Main.Class11.callSite_5, arg, "gender"));
              frm_Main.Class13 arg_861_0 = class2;
              if(frm_Main.Class11.callSite_8 == null) {
                frm_Main.Class11.callSite_8 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(frm_Main)));
              }
              Func<CallSite, object, string> arg_85C_0 = frm_Main.Class11.callSite_8.Target;
              CallSite arg_85C_1 = frm_Main.Class11.callSite_8;
              if(frm_Main.Class11.callSite_7 == null) {
                frm_Main.Class11.callSite_7 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(frm_Main), new CSharpArgumentInfo[]
                {
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
                }));
              }
              arg_861_0.string_3 = arg_85C_0(arg_85C_1, frm_Main.Class11.callSite_7.Target(frm_Main.Class11.callSite_7, arg, "birthday"));
              frm_Main.Class13 arg_8FE_0 = class2;
              if(frm_Main.Class11.callSite_10 == null) {
                frm_Main.Class11.callSite_10 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(frm_Main)));
              }
              Func<CallSite, object, string> arg_8F9_0 = frm_Main.Class11.callSite_10.Target;
              CallSite arg_8F9_1 = frm_Main.Class11.callSite_10;
              if(frm_Main.Class11.callSite_9 == null) {
                frm_Main.Class11.callSite_9 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(frm_Main), new CSharpArgumentInfo[]
                {
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
                }));
              }
              arg_8FE_0.string_4 = arg_8F9_0(arg_8F9_1, frm_Main.Class11.callSite_9.Target(frm_Main.Class11.callSite_9, arg, "email"));
              frm_Main.Class13 arg_99B_0 = class2;
              if(frm_Main.Class11.callSite_12 == null) {
                frm_Main.Class11.callSite_12 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(frm_Main)));
              }
              Func<CallSite, object, string> arg_996_0 = frm_Main.Class11.callSite_12.Target;
              CallSite arg_996_1 = frm_Main.Class11.callSite_12;
              if(frm_Main.Class11.callSite_11 == null) {
                frm_Main.Class11.callSite_11 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(frm_Main), new CSharpArgumentInfo[]
                {
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
                }));
              }
              arg_99B_0.string_5 = arg_996_0(arg_996_1, frm_Main.Class11.callSite_11.Target(frm_Main.Class11.callSite_11, arg, "mobile_phone"));
              class2.string_6 = "";
              if(frm_Main.Class11.callSite_15 == null) {
                frm_Main.Class11.callSite_15 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(frm_Main), new CSharpArgumentInfo[]
                {
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
                }));
              }
              Func<CallSite, object, bool> arg_A96_0 = frm_Main.Class11.callSite_15.Target;
              CallSite arg_A96_1 = frm_Main.Class11.callSite_15;
              if(frm_Main.Class11.callSite_14 == null) {
                frm_Main.Class11.callSite_14 = CallSite<Func<CallSite, object, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.NotEqual, typeof(frm_Main), new CSharpArgumentInfo[]
                {
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, null)
                }));
              }
              Func<CallSite, object, object, object> arg_A91_0 = frm_Main.Class11.callSite_14.Target;
              CallSite arg_A91_1 = frm_Main.Class11.callSite_14;
              if(frm_Main.Class11.callSite_13 == null) {
                frm_Main.Class11.callSite_13 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(frm_Main), new CSharpArgumentInfo[]
                {
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
                }));
              }
              if(arg_A96_0(arg_A96_1, arg_A91_0(arg_A91_1, frm_Main.Class11.callSite_13.Target(frm_Main.Class11.callSite_13, arg, "location"), null))) {
                frm_Main.Class13 arg_B8C_0 = class2;
                if(frm_Main.Class11.callSite_18 == null) {
                  frm_Main.Class11.callSite_18 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(frm_Main)));
                }
                Func<CallSite, object, string> arg_B87_0 = frm_Main.Class11.callSite_18.Target;
                CallSite arg_B87_1 = frm_Main.Class11.callSite_18;
                if(frm_Main.Class11.callSite_17 == null) {
                  frm_Main.Class11.callSite_17 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(frm_Main), new CSharpArgumentInfo[]
                  {
                    CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
                    CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
                  }));
                }
                Func<CallSite, object, string, object> arg_B82_0 = frm_Main.Class11.callSite_17.Target;
                CallSite arg_B82_1 = frm_Main.Class11.callSite_17;
                if(frm_Main.Class11.callSite_16 == null) {
                  frm_Main.Class11.callSite_16 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(frm_Main), new CSharpArgumentInfo[]
                  {
                    CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
                    CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
                  }));
                }
                arg_B8C_0.string_6 = arg_B87_0(arg_B87_1, arg_B82_0(arg_B82_1, frm_Main.Class11.callSite_16.Target(frm_Main.Class11.callSite_16, arg, "location"), "name"));
              }
              if(!list2.Contains(class2.string_1)) {
                list2.Add(class2.string_1);
                base.Invoke(new MethodInvoker(class2.method_0));
              }
            }
          } catch(Exception) {
            base.Invoke(new MethodInvoker(this.method_9));
          }
          MethodInvoker arg_C1A_1;
          if((arg_C1A_1 = @class.methodInvoker_0) == null) {
            arg_C1A_1 = (@class.methodInvoker_0 = new MethodInvoker(@class.method_0));
          }
          base.Invoke(arg_C1A_1);
          list = list.Distinct<string>().ToList<string>();
          if(list.Count > num2) {
            flag = false;
          }
        }
      } catch(Exception) {
        base.Invoke(new MethodInvoker(@class.method_1));
      }
    }

    private void flatButton13_Click(object sender, EventArgs e) {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
      openFileDialog.FilterIndex = 1;
      openFileDialog.Multiselect = false;
      if(openFileDialog.ShowDialog() == DialogResult.OK) {
        try {
          frm_Main.Class14 @class = new frm_Main.Class14();
          @class.frm_Main_0 = this;
          @class.string_0 = File.ReadAllLines(openFileDialog.FileName);
          this.process.Maximum = @class.string_0.Count<string>();
          Path.GetDirectoryName(openFileDialog.FileName);
          Thread thread = new Thread(new ThreadStart(@class.method_0));
          thread.Start();
        } catch {
        }
      }
    }

    private void flatButton9_Click(object sender, EventArgs e) {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
      openFileDialog.FilterIndex = 1;
      openFileDialog.Multiselect = false;
      if(openFileDialog.ShowDialog() == DialogResult.OK) {
        try {
          frm_Main.Class15 @class = new frm_Main.Class15();
          @class.frm_Main_0 = this;
          @class.string_0 = File.ReadAllLines(openFileDialog.FileName);
          this.process.Maximum = @class.string_0.Count<string>();
          Path.GetDirectoryName(openFileDialog.FileName);
          Thread thread = new Thread(new ThreadStart(@class.method_0));
          thread.Start();
        } catch {
        }
      }
    }

    private void flatButton10_Click(object sender, EventArgs e) {
      frm_Main.Class16 @class = new frm_Main.Class16();
      @class.frm_Main_0 = this;
      @class.string_0 = Interaction.InputBox("Vui lòng nhập ID?", "Nhập 1 ID", "", -1, -1);
      if(@class.string_0.Length > 0) {
        Thread thread = new Thread(new ThreadStart(@class.method_0));
        thread.Start();
      }
    }

    private void flatButton8_Click(object sender, EventArgs e) {
      this.savefile(this.data_like);
    }

    private void flatButton12_Click(object sender, EventArgs e) {
      this.savefile(this.data_cmt);
    }

    private void flatButton7_Click(object sender, EventArgs e) {
      this.data_like.Rows.Clear();
    }

    private void flatButton11_Click(object sender, EventArgs e) {
      this.data_cmt.Rows.Clear();
    }

    private void flatButton15_Click(object sender, EventArgs e) {
      this.data_feed.Rows.Clear();
    }

    private void flatButton16_Click(object sender, EventArgs e) {
      this.savefile(this.data_feed);
    }

    private void flatButton18_Click(object sender, EventArgs e) {
      frm_Main.Class17 @class = new frm_Main.Class17();
      @class.frm_Main_0 = this;
      @class.string_0 = Interaction.InputBox("Vui lòng nhập ID?", "Nhập 1 ID", "", -1, -1);
      if(@class.string_0.Length > 0) {
        Thread thread = new Thread(new ThreadStart(@class.method_0));
        thread.Start();
      }
    }

    public void getfeed(string uid, DataGridView dgv) {
      frm_Main.Class18 @class = new frm_Main.Class18();
      @class.frm_Main_0 = this;
      @class.dataGridView_0 = dgv;
      @class.string_0 = uid;
      try {
        string requestUriString = "https://graph.facebook.com/" + @class.string_0 + "/feed?access_token=" + this.string_0;
        bool flag = true;
        while(flag) {
          HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUriString);
          httpWebRequest.UserAgent = "Dalvik/1.6.0 (Linux; U; Android 4.3; Z10 Build/10.3.2.110) [FBAN/FB4A;FBAV/19.0.0.23.14;FBLC/vi_VN;FBBV/4694056;FBCR/null;FBMF/RIM;FBBD/BlackBerry;FBDV/Z10;FBSV/4.3;FBCA/armeabi-v7a:armeabi;FBDM/{density=2.0,width=768,height=1174};FB_FW/1;]";
          HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
          string json = new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd();
          JObject jObject = JObject.Parse(json);
          foreach(JToken current in ((IEnumerable<JToken>)jObject["data"])) {
            frm_Main.Class19 class2 = new frm_Main.Class19();
            class2.class18_0 = @class;
            class2.string_1 = (string)current["id"];
            class2.string_0 = (string)current["message"];
            class2.string_4 = "0";
            try {
              class2.string_4 = (string)current["shares"]["count"];
              goto IL_1D6;
            } catch {
              goto IL_1D6;
            }
            //try {
              IL_11F:
              class2.string_2 = (string)current["likes"]["count"];
            //} catch {
            //}
            class2.string_3 = "0";
            //try {
              class2.string_3 = (string)current["comments"]["count"];
            //} catch {
            //}

            var a= (string)current["type"];
            base.Invoke(new MethodInvoker(class2.method_0));
            if(class2.class18_0.dataGridView_0.Rows.Count >= (int)this.limit_request.Value) {
              flag = false;
              continue;
            }
            continue;
            IL_1D6:
            class2.string_2 = "0";
            goto IL_11F;
          }
          if(jObject["paging"]["next"] != null) {
            requestUriString = (string)jObject["paging"]["next"];
          } else {
            flag = false;
          }
          MethodInvoker arg_252_1;
          if((arg_252_1 = @class.methodInvoker_0) == null) {
            arg_252_1 = (@class.methodInvoker_0 = new MethodInvoker(@class.method_0));
          }
          base.Invoke(arg_252_1);
        }
      } catch {
        base.Invoke(new MethodInvoker(this.method_10));
      }
    }

    private void flatButton17_Click(object sender, EventArgs e) {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
      openFileDialog.FilterIndex = 1;
      openFileDialog.Multiselect = false;
      if(openFileDialog.ShowDialog() == DialogResult.OK) {
        try {
          frm_Main.Class20 @class = new frm_Main.Class20();
          @class.frm_Main_0 = this;
          @class.string_0 = File.ReadAllLines(openFileDialog.FileName);
          this.process.Maximum = @class.string_0.Count<string>();
          Path.GetDirectoryName(openFileDialog.FileName);
          Thread thread = new Thread(new ThreadStart(@class.method_0));
          thread.Start();
        } catch {
        }
      }
    }

    private void formSkin1_Click(object sender, EventArgs e) {
    }

    private void flatButton19_Click(object sender, EventArgs e) {
      try {
        frm_Main.Class21 @class = new frm_Main.Class21();
        @class.frm_Main_0 = this;
        @class.list_0 = new List<string>();
        for(int i = 0; i <= this.data_feed.Rows.Count - 1; i++) {
          if(this.data_feed.Rows[i].Cells[2].Value != null) {
            @class.list_0.Add(this.data_feed.Rows[i].Cells[2].Value.ToString());
          }
        }
        Thread thread = new Thread(new ThreadStart(@class.method_0));
        thread.Start();
      } catch {
      }
    }

    private void flatButton20_Click(object sender, EventArgs e) {
      try {
        frm_Main.Class22 @class = new frm_Main.Class22();
        @class.frm_Main_0 = this;
        @class.list_0 = new List<string>();
        for(int i = 0; i <= this.data_feed.Rows.Count - 1; i++) {
          if(this.data_feed.Rows[i].Cells[2].Value != null) {
            @class.list_0.Add(this.data_feed.Rows[i].Cells[2].Value.ToString());
          }
        }
        Thread thread = new Thread(new ThreadStart(@class.method_0));
        thread.Start();
      } catch {
      }
    }

    public void removedouble(DataGridView grv) {
      for(int i = 0; i < grv.RowCount; i++) {
        for(int j = i + 1; j < grv.RowCount; j++) {
          if(grv.Rows[i].Cells[2].Value != null && grv.Rows[i].Cells[2].Value.Equals(grv.Rows[j].Cells[2].Value)) {
            grv.Rows.Remove(grv.Rows[j]);
          }
        }
      }
    }

    private void method_0(object sender, EventArgs e) {
      this.removedouble(this.data_friends);
    }

    private void flatButton22_Click(object sender, EventArgs e) {
      this.removedouble(this.datamembers);
    }

    private void flatButton23_Click(object sender, EventArgs e) {
      this.removedouble(this.data_like);
    }

    private void flatButton24_Click(object sender, EventArgs e) {
      this.removedouble(this.data_cmt);
    }

    private void flatButton25_Click(object sender, EventArgs e) {
      this.removedouble(this.data_feed);
    }

    private void flatButton26_Click(object sender, EventArgs e) {
      this.savefile2(this.data_cmt);
    }

    public void savefile2(DataGridView dtg) {
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.FileName = "Xuất File-" + DateTime.Now.ToString("MM-dd-yyyy-HH-mm-ss-fff") + ".xls";
      saveFileDialog.Filter = "Text File | *.xls";
      if(saveFileDialog.ShowDialog() == DialogResult.OK) {
        this.status.Text = "Đang lưu file...";
        try {
          StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName, false, Encoding.Unicode);
          for(int i = 0; i <= dtg.Rows.Count - 1; i++) {
            if(dtg.Rows[i].Cells[8].Value != null) {
              string text = dtg.Rows[i].Cells[8].Value.ToString();
              if(text.Contains("@")) {
                Regex regex = new Regex("\\w+([-+.]\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*", RegexOptions.IgnoreCase);
                MatchCollection matchCollection = regex.Matches(text);
                new StringBuilder();
                int num = 0;
                foreach(Match arg_100_0 in matchCollection) {
                  num++;
                }
                string text2 = "";
                if(num > 0) {
                  for(int j = 0; j <= dtg.Columns.Count - 1; j++) {
                    if(dtg.Rows[i].Cells[j].Value != null) {
                      dtg.Rows[i].Cells[j].Value.ToString();
                      text2 = text2 + dtg.Rows[i].Cells[j].Value.ToString() + "\t";
                    } else {
                      text2 += "\t";
                    }
                  }
                }
                streamWriter.WriteLine(text2);
              }
            }
          }
          streamWriter.Dispose();
          streamWriter.Close();
          this.status.Text = "Xuất file Excel thành công.";
        } catch(Exception) {
        }
      }
    }

    private void status_Click(object sender, EventArgs e) {
      this.status.Visible = true;
      this.status.kind = FlatAlertBox._Kind.Info;
      this.status.Text = "ATP Software Company";
    }

    private void flatButton27_Click(object sender, EventArgs e) {
      new frm_Login {
        mycookie = new frm_Login.get_cookie(this.get_cookie)
      }.ShowDialog();
    }

    private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
      Process.Start("https://atpsoftware.vn/direct/youtube-atp.php?ref=simpleuid");
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
      Process.Start("https://atpsoftware.vn/direct/group-support-atp.php?ref=simpleuid");
    }

    private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
      Process.Start("https://atpsoftware.vn?ref=simpleuid");
    }

    protected override void Dispose(bool disposing) {
      if(disposing && this.icontainer_0 != null) {
        this.icontainer_0.Dispose();
      }
      base.Dispose(disposing);
    }

    private void InitializeComponent() {
            this.formSkin1 = new FlatUI.FormSkin();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.flatTabControl1 = new FlatUI.FlatTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flatButton27 = new FlatUI.FlatButton();
            this.flatButton2 = new FlatUI.FlatButton();
            this.flatButton3 = new FlatUI.FlatButton();
            this.btn_get_friends_from_file = new FlatUI.FlatButton();
            this.btn_get_friends_1_uid = new FlatUI.FlatButton();
            this.data_friends = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flatButton22 = new FlatUI.FlatButton();
            this.flatButton1 = new FlatUI.FlatButton();
            this.flatButton4 = new FlatUI.FlatButton();
            this.flatButton5 = new FlatUI.FlatButton();
            this.flatButton6 = new FlatUI.FlatButton();
            this.datamembers = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDTDasmdas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationccnsac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.flatButton23 = new FlatUI.FlatButton();
            this.flatButton7 = new FlatUI.FlatButton();
            this.flatButton8 = new FlatUI.FlatButton();
            this.flatButton9 = new FlatUI.FlatButton();
            this.flatButton10 = new FlatUI.FlatButton();
            this.data_like = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Locationsss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.flatButton11 = new FlatUI.FlatButton();
            this.flatButton24 = new FlatUI.FlatButton();
            this.flatButton26 = new FlatUI.FlatButton();
            this.flatButton12 = new FlatUI.FlatButton();
            this.flatButton13 = new FlatUI.FlatButton();
            this.flatButton14 = new FlatUI.FlatButton();
            this.data_cmt = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.limit_request = new System.Windows.Forms.NumericUpDown();
            this.flatButton25 = new FlatUI.FlatButton();
            this.flatButton20 = new FlatUI.FlatButton();
            this.flatButton19 = new FlatUI.FlatButton();
            this.flatLabel1 = new FlatUI.FlatLabel();
            this.flatButton15 = new FlatUI.FlatButton();
            this.flatButton16 = new FlatUI.FlatButton();
            this.flatButton17 = new FlatUI.FlatButton();
            this.flatButton18 = new FlatUI.FlatButton();
            this.data_feed = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flatClose1 = new FlatUI.FlatClose();
            this.process = new FlatUI.FlatProgressBar();
            this.status = new FlatUI.FlatAlertBox();
            this.formSkin1.SuspendLayout();
            this.flatTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_friends)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datamembers)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_like)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_cmt)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.limit_request)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_feed)).BeginInit();
            this.SuspendLayout();
            // 
            // formSkin1
            // 
            this.formSkin1.BackColor = System.Drawing.Color.White;
            this.formSkin1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.formSkin1.BorderColor = System.Drawing.Color.Aqua;
            this.formSkin1.Controls.Add(this.linkLabel3);
            this.formSkin1.Controls.Add(this.linkLabel2);
            this.formSkin1.Controls.Add(this.linkLabel1);
            this.formSkin1.Controls.Add(this.flatTabControl1);
            this.formSkin1.Controls.Add(this.flatClose1);
            this.formSkin1.Controls.Add(this.process);
            this.formSkin1.Controls.Add(this.status);
            this.formSkin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkin1.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.formSkin1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.formSkin1.ForeColor = System.Drawing.Color.Black;
            this.formSkin1.HeaderColor = System.Drawing.Color.CornflowerBlue;
            this.formSkin1.HeaderMaximize = false;
            this.formSkin1.Location = new System.Drawing.Point(0, 0);
            this.formSkin1.Name = "formSkin1";
            this.formSkin1.Size = new System.Drawing.Size(784, 512);
            this.formSkin1.TabIndex = 0;
            this.formSkin1.Text = "Simple UID 1.0.10";
            this.formSkin1.Click += new System.EventHandler(this.formSkin1_Click);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel3.LinkColor = System.Drawing.Color.White;
            this.linkLabel3.Location = new System.Drawing.Point(308, 12);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(167, 21);
            this.linkLabel3.TabIndex = 6;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Kênh video hướng dẫn";
            this.linkLabel3.Visible = false;
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2.LinkColor = System.Drawing.Color.White;
            this.linkLabel2.Location = new System.Drawing.Point(611, 12);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(92, 21);
            this.linkLabel2.TabIndex = 5;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Software.vn";
            this.linkLabel2.Visible = false;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(493, 13);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(105, 21);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Group Hỗ Trợ";
            this.linkLabel1.Visible = false;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // flatTabControl1
            // 
            this.flatTabControl1.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.flatTabControl1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.flatTabControl1.Controls.Add(this.tabPage1);
            this.flatTabControl1.Controls.Add(this.tabPage2);
            this.flatTabControl1.Controls.Add(this.tabPage3);
            this.flatTabControl1.Controls.Add(this.tabPage4);
            this.flatTabControl1.Controls.Add(this.tabPage5);
            this.flatTabControl1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatTabControl1.ItemSize = new System.Drawing.Size(120, 40);
            this.flatTabControl1.Location = new System.Drawing.Point(0, 50);
            this.flatTabControl1.Name = "flatTabControl1";
            this.flatTabControl1.SelectedIndex = 0;
            this.flatTabControl1.Size = new System.Drawing.Size(784, 433);
            this.flatTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.flatTabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage1.Controls.Add(this.flatButton27);
            this.tabPage1.Controls.Add(this.flatButton2);
            this.tabPage1.Controls.Add(this.flatButton3);
            this.tabPage1.Controls.Add(this.btn_get_friends_from_file);
            this.tabPage1.Controls.Add(this.btn_get_friends_1_uid);
            this.tabPage1.Controls.Add(this.data_friends);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(776, 385);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bạn bè của UID";
            // 
            // flatButton27
            // 
            this.flatButton27.BackColor = System.Drawing.Color.Transparent;
            this.flatButton27.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.flatButton27.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton27.Dock = System.Windows.Forms.DockStyle.Left;
            this.flatButton27.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton27.Location = new System.Drawing.Point(471, 298);
            this.flatButton27.Name = "flatButton27";
            this.flatButton27.Rounded = false;
            this.flatButton27.Size = new System.Drawing.Size(302, 84);
            this.flatButton27.TabIndex = 6;
            this.flatButton27.Text = "Đổi tài khoản";
            this.flatButton27.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton27.Click += new System.EventHandler(this.flatButton27_Click);
            // 
            // flatButton2
            // 
            this.flatButton2.BackColor = System.Drawing.Color.Transparent;
            this.flatButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.flatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton2.Dock = System.Windows.Forms.DockStyle.Left;
            this.flatButton2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton2.Location = new System.Drawing.Point(354, 298);
            this.flatButton2.Name = "flatButton2";
            this.flatButton2.Rounded = false;
            this.flatButton2.Size = new System.Drawing.Size(117, 84);
            this.flatButton2.TabIndex = 2;
            this.flatButton2.Text = "Xóa danh sách";
            this.flatButton2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton2.Click += new System.EventHandler(this.flatButton2_Click);
            // 
            // flatButton3
            // 
            this.flatButton3.BackColor = System.Drawing.Color.Transparent;
            this.flatButton3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.flatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton3.Dock = System.Windows.Forms.DockStyle.Left;
            this.flatButton3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton3.Location = new System.Drawing.Point(237, 298);
            this.flatButton3.Name = "flatButton3";
            this.flatButton3.Rounded = false;
            this.flatButton3.Size = new System.Drawing.Size(117, 84);
            this.flatButton3.TabIndex = 3;
            this.flatButton3.Text = "Lưu danh sách";
            this.flatButton3.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton3.Click += new System.EventHandler(this.flatButton3_Click);
            // 
            // btn_get_friends_from_file
            // 
            this.btn_get_friends_from_file.BackColor = System.Drawing.Color.Transparent;
            this.btn_get_friends_from_file.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.btn_get_friends_from_file.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_get_friends_from_file.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_get_friends_from_file.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_get_friends_from_file.Location = new System.Drawing.Point(120, 298);
            this.btn_get_friends_from_file.Name = "btn_get_friends_from_file";
            this.btn_get_friends_from_file.Rounded = false;
            this.btn_get_friends_from_file.Size = new System.Drawing.Size(117, 84);
            this.btn_get_friends_from_file.TabIndex = 1;
            this.btn_get_friends_from_file.Text = "Quét tệp UID";
            this.btn_get_friends_from_file.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btn_get_friends_from_file.Click += new System.EventHandler(this.btn_get_friends_from_file_Click);
            // 
            // btn_get_friends_1_uid
            // 
            this.btn_get_friends_1_uid.BackColor = System.Drawing.Color.Transparent;
            this.btn_get_friends_1_uid.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.btn_get_friends_1_uid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_get_friends_1_uid.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_get_friends_1_uid.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_get_friends_1_uid.Location = new System.Drawing.Point(3, 298);
            this.btn_get_friends_1_uid.Name = "btn_get_friends_1_uid";
            this.btn_get_friends_1_uid.Rounded = false;
            this.btn_get_friends_1_uid.Size = new System.Drawing.Size(117, 84);
            this.btn_get_friends_1_uid.TabIndex = 4;
            this.btn_get_friends_1_uid.Text = "Quét 1 UID";
            this.btn_get_friends_1_uid.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btn_get_friends_1_uid.Click += new System.EventHandler(this.btn_get_friends_1_uid_Click);
            // 
            // data_friends
            // 
            this.data_friends.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_friends.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_friends.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.fullname,
            this.UID,
            this.gender,
            this.bd,
            this.email,
            this.sdt,
            this.location});
            this.data_friends.Dock = System.Windows.Forms.DockStyle.Top;
            this.data_friends.Location = new System.Drawing.Point(3, 3);
            this.data_friends.Name = "data_friends";
            this.data_friends.Size = new System.Drawing.Size(770, 295);
            this.data_friends.TabIndex = 0;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // fullname
            // 
            this.fullname.HeaderText = "Tên FB";
            this.fullname.Name = "fullname";
            this.fullname.ReadOnly = true;
            // 
            // UID
            // 
            this.UID.FillWeight = 10F;
            this.UID.HeaderText = "UID";
            this.UID.Name = "UID";
            this.UID.ReadOnly = true;
            this.UID.Visible = false;
            // 
            // gender
            // 
            this.gender.HeaderText = "Giới Tính";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // bd
            // 
            this.bd.HeaderText = "Ngày sinh";
            this.bd.Name = "bd";
            this.bd.ReadOnly = true;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // sdt
            // 
            this.sdt.HeaderText = "SĐT";
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            // 
            // location
            // 
            this.location.HeaderText = "Location";
            this.location.Name = "location";
            this.location.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage2.Controls.Add(this.flatButton22);
            this.tabPage2.Controls.Add(this.flatButton1);
            this.tabPage2.Controls.Add(this.flatButton4);
            this.tabPage2.Controls.Add(this.flatButton5);
            this.tabPage2.Controls.Add(this.flatButton6);
            this.tabPage2.Controls.Add(this.datamembers);
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(776, 385);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thành viên nhóm";
            // 
            // flatButton22
            // 
            this.flatButton22.BackColor = System.Drawing.Color.Transparent;
            this.flatButton22.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.flatButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton22.Dock = System.Windows.Forms.DockStyle.Left;
            this.flatButton22.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton22.Location = new System.Drawing.Point(471, 298);
            this.flatButton22.Name = "flatButton22";
            this.flatButton22.Rounded = false;
            this.flatButton22.Size = new System.Drawing.Size(117, 84);
            this.flatButton22.TabIndex = 10;
            this.flatButton22.Text = "Lọc trùng";
            this.flatButton22.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton22.Click += new System.EventHandler(this.flatButton22_Click);
            // 
            // flatButton1
            // 
            this.flatButton1.BackColor = System.Drawing.Color.Transparent;
            this.flatButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.flatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flatButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton1.Location = new System.Drawing.Point(354, 298);
            this.flatButton1.Name = "flatButton1";
            this.flatButton1.Rounded = false;
            this.flatButton1.Size = new System.Drawing.Size(117, 84);
            this.flatButton1.TabIndex = 7;
            this.flatButton1.Text = "Xóa danh sách";
            this.flatButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton1.Click += new System.EventHandler(this.flatButton1_Click);
            // 
            // flatButton4
            // 
            this.flatButton4.BackColor = System.Drawing.Color.Transparent;
            this.flatButton4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.flatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton4.Dock = System.Windows.Forms.DockStyle.Left;
            this.flatButton4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton4.Location = new System.Drawing.Point(237, 298);
            this.flatButton4.Name = "flatButton4";
            this.flatButton4.Rounded = false;
            this.flatButton4.Size = new System.Drawing.Size(117, 84);
            this.flatButton4.TabIndex = 8;
            this.flatButton4.Text = "Lưu danh sách";
            this.flatButton4.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton4.Click += new System.EventHandler(this.flatButton4_Click);
            // 
            // flatButton5
            // 
            this.flatButton5.BackColor = System.Drawing.Color.Transparent;
            this.flatButton5.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.flatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton5.Dock = System.Windows.Forms.DockStyle.Left;
            this.flatButton5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton5.Location = new System.Drawing.Point(120, 298);
            this.flatButton5.Name = "flatButton5";
            this.flatButton5.Rounded = false;
            this.flatButton5.Size = new System.Drawing.Size(117, 84);
            this.flatButton5.TabIndex = 6;
            this.flatButton5.Text = "Quét tệp GID";
            this.flatButton5.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton5.Click += new System.EventHandler(this.flatButton5_Click);
            // 
            // flatButton6
            // 
            this.flatButton6.BackColor = System.Drawing.Color.Transparent;
            this.flatButton6.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.flatButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton6.Dock = System.Windows.Forms.DockStyle.Left;
            this.flatButton6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton6.Location = new System.Drawing.Point(3, 298);
            this.flatButton6.Name = "flatButton6";
            this.flatButton6.Rounded = false;
            this.flatButton6.Size = new System.Drawing.Size(117, 84);
            this.flatButton6.TabIndex = 9;
            this.flatButton6.Text = "Quét 1 GID";
            this.flatButton6.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton6.Click += new System.EventHandler(this.flatButton6_Click);
            // 
            // datamembers
            // 
            this.datamembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datamembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datamembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.SDTDasmdas,
            this.locationccnsac});
            this.datamembers.Dock = System.Windows.Forms.DockStyle.Top;
            this.datamembers.Location = new System.Drawing.Point(3, 3);
            this.datamembers.Name = "datamembers";
            this.datamembers.Size = new System.Drawing.Size(770, 295);
            this.datamembers.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "STT";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên FB";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "UID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Giới Tính";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Ngày sinh";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Email";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // SDTDasmdas
            // 
            this.SDTDasmdas.HeaderText = "SĐT";
            this.SDTDasmdas.Name = "SDTDasmdas";
            this.SDTDasmdas.ReadOnly = true;
            // 
            // locationccnsac
            // 
            this.locationccnsac.HeaderText = "Location";
            this.locationccnsac.Name = "locationccnsac";
            this.locationccnsac.ReadOnly = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage3.Controls.Add(this.flatButton23);
            this.tabPage3.Controls.Add(this.flatButton7);
            this.tabPage3.Controls.Add(this.flatButton8);
            this.tabPage3.Controls.Add(this.flatButton9);
            this.tabPage3.Controls.Add(this.flatButton10);
            this.tabPage3.Controls.Add(this.data_like);
            this.tabPage3.Location = new System.Drawing.Point(4, 44);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(776, 385);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Quét Like bài viết";
            // 
            // flatButton23
            // 
            this.flatButton23.BackColor = System.Drawing.Color.Transparent;
            this.flatButton23.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.flatButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton23.Dock = System.Windows.Forms.DockStyle.Left;
            this.flatButton23.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton23.Location = new System.Drawing.Point(471, 298);
            this.flatButton23.Name = "flatButton23";
            this.flatButton23.Rounded = false;
            this.flatButton23.Size = new System.Drawing.Size(117, 84);
            this.flatButton23.TabIndex = 15;
            this.flatButton23.Text = "Lọc trùng";
            this.flatButton23.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton23.Click += new System.EventHandler(this.flatButton23_Click);
            // 
            // flatButton7
            // 
            this.flatButton7.BackColor = System.Drawing.Color.Transparent;
            this.flatButton7.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.flatButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton7.Dock = System.Windows.Forms.DockStyle.Left;
            this.flatButton7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton7.Location = new System.Drawing.Point(354, 298);
            this.flatButton7.Name = "flatButton7";
            this.flatButton7.Rounded = false;
            this.flatButton7.Size = new System.Drawing.Size(117, 84);
            this.flatButton7.TabIndex = 12;
            this.flatButton7.Text = "Xóa danh sách";
            this.flatButton7.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton7.Click += new System.EventHandler(this.flatButton7_Click);
            // 
            // flatButton8
            // 
            this.flatButton8.BackColor = System.Drawing.Color.Transparent;
            this.flatButton8.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.flatButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton8.Dock = System.Windows.Forms.DockStyle.Left;
            this.flatButton8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton8.Location = new System.Drawing.Point(237, 298);
            this.flatButton8.Name = "flatButton8";
            this.flatButton8.Rounded = false;
            this.flatButton8.Size = new System.Drawing.Size(117, 84);
            this.flatButton8.TabIndex = 13;
            this.flatButton8.Text = "Lưu danh sách";
            this.flatButton8.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton8.Click += new System.EventHandler(this.flatButton8_Click);
            // 
            // flatButton9
            // 
            this.flatButton9.BackColor = System.Drawing.Color.Transparent;
            this.flatButton9.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.flatButton9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton9.Dock = System.Windows.Forms.DockStyle.Left;
            this.flatButton9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton9.Location = new System.Drawing.Point(120, 298);
            this.flatButton9.Name = "flatButton9";
            this.flatButton9.Rounded = false;
            this.flatButton9.Size = new System.Drawing.Size(117, 84);
            this.flatButton9.TabIndex = 11;
            this.flatButton9.Text = "Quét tệp ID";
            this.flatButton9.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton9.Click += new System.EventHandler(this.flatButton9_Click);
            // 
            // flatButton10
            // 
            this.flatButton10.BackColor = System.Drawing.Color.Transparent;
            this.flatButton10.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.flatButton10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton10.Dock = System.Windows.Forms.DockStyle.Left;
            this.flatButton10.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton10.Location = new System.Drawing.Point(3, 298);
            this.flatButton10.Name = "flatButton10";
            this.flatButton10.Rounded = false;
            this.flatButton10.Size = new System.Drawing.Size(117, 84);
            this.flatButton10.TabIndex = 14;
            this.flatButton10.Text = "Quét 1 ID";
            this.flatButton10.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton10.Click += new System.EventHandler(this.flatButton10_Click);
            // 
            // data_like
            // 
            this.data_like.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_like.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_like.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.SDT22,
            this.Locationsss});
            this.data_like.Dock = System.Windows.Forms.DockStyle.Top;
            this.data_like.Location = new System.Drawing.Point(3, 3);
            this.data_like.Name = "data_like";
            this.data_like.Size = new System.Drawing.Size(770, 295);
            this.data_like.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "STT";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Tên FB";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "UID";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Giới Tính";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Ngày sinh";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Email";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // SDT22
            // 
            this.SDT22.HeaderText = "SĐT";
            this.SDT22.Name = "SDT22";
            this.SDT22.ReadOnly = true;
            // 
            // Locationsss
            // 
            this.Locationsss.HeaderText = "Location";
            this.Locationsss.Name = "Locationsss";
            this.Locationsss.ReadOnly = true;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage4.Controls.Add(this.flatButton11);
            this.tabPage4.Controls.Add(this.flatButton24);
            this.tabPage4.Controls.Add(this.flatButton26);
            this.tabPage4.Controls.Add(this.flatButton12);
            this.tabPage4.Controls.Add(this.flatButton13);
            this.tabPage4.Controls.Add(this.flatButton14);
            this.tabPage4.Controls.Add(this.data_cmt);
            this.tabPage4.Location = new System.Drawing.Point(4, 44);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(776, 385);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Quét cmt bài viết";
            // 
            // flatButton11
            // 
            this.flatButton11.BackColor = System.Drawing.Color.Transparent;
            this.flatButton11.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.flatButton11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton11.Dock = System.Windows.Forms.DockStyle.Left;
            this.flatButton11.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton11.Location = new System.Drawing.Point(624, 298);
            this.flatButton11.Name = "flatButton11";
            this.flatButton11.Rounded = false;
            this.flatButton11.Size = new System.Drawing.Size(117, 84);
            this.flatButton11.TabIndex = 12;
            this.flatButton11.Text = "Xóa danh sách";
            this.flatButton11.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton11.Click += new System.EventHandler(this.flatButton11_Click);
            // 
            // flatButton24
            // 
            this.flatButton24.BackColor = System.Drawing.Color.Transparent;
            this.flatButton24.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.flatButton24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton24.Dock = System.Windows.Forms.DockStyle.Left;
            this.flatButton24.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton24.Location = new System.Drawing.Point(507, 298);
            this.flatButton24.Name = "flatButton24";
            this.flatButton24.Rounded = false;
            this.flatButton24.Size = new System.Drawing.Size(117, 84);
            this.flatButton24.TabIndex = 15;
            this.flatButton24.Text = "Lọc trùng";
            this.flatButton24.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton24.Click += new System.EventHandler(this.flatButton24_Click);
            // 
            // flatButton26
            // 
            this.flatButton26.BackColor = System.Drawing.Color.Transparent;
            this.flatButton26.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.flatButton26.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton26.Dock = System.Windows.Forms.DockStyle.Left;
            this.flatButton26.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton26.Location = new System.Drawing.Point(354, 298);
            this.flatButton26.Name = "flatButton26";
            this.flatButton26.Rounded = false;
            this.flatButton26.Size = new System.Drawing.Size(153, 84);
            this.flatButton26.TabIndex = 16;
            this.flatButton26.Text = "Lưu cmt có mail";
            this.flatButton26.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton26.Click += new System.EventHandler(this.flatButton26_Click);
            // 
            // flatButton12
            // 
            this.flatButton12.BackColor = System.Drawing.Color.Transparent;
            this.flatButton12.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.flatButton12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton12.Dock = System.Windows.Forms.DockStyle.Left;
            this.flatButton12.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton12.Location = new System.Drawing.Point(237, 298);
            this.flatButton12.Name = "flatButton12";
            this.flatButton12.Rounded = false;
            this.flatButton12.Size = new System.Drawing.Size(117, 84);
            this.flatButton12.TabIndex = 13;
            this.flatButton12.Text = "Lưu danh sách";
            this.flatButton12.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton12.Click += new System.EventHandler(this.flatButton12_Click);
            // 
            // flatButton13
            // 
            this.flatButton13.BackColor = System.Drawing.Color.Transparent;
            this.flatButton13.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.flatButton13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton13.Dock = System.Windows.Forms.DockStyle.Left;
            this.flatButton13.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton13.Location = new System.Drawing.Point(120, 298);
            this.flatButton13.Name = "flatButton13";
            this.flatButton13.Rounded = false;
            this.flatButton13.Size = new System.Drawing.Size(117, 84);
            this.flatButton13.TabIndex = 11;
            this.flatButton13.Text = "Quét tệp ID";
            this.flatButton13.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton13.Click += new System.EventHandler(this.flatButton13_Click);
            // 
            // flatButton14
            // 
            this.flatButton14.BackColor = System.Drawing.Color.Transparent;
            this.flatButton14.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.flatButton14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton14.Dock = System.Windows.Forms.DockStyle.Left;
            this.flatButton14.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton14.Location = new System.Drawing.Point(3, 298);
            this.flatButton14.Name = "flatButton14";
            this.flatButton14.Rounded = false;
            this.flatButton14.Size = new System.Drawing.Size(117, 84);
            this.flatButton14.TabIndex = 14;
            this.flatButton14.Text = "Quét 1 ID";
            this.flatButton14.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton14.Click += new System.EventHandler(this.flatButton14_Click);
            // 
            // data_cmt
            // 
            this.data_cmt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_cmt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_cmt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.sdt2,
            this.nca,
            this.Column1});
            this.data_cmt.Dock = System.Windows.Forms.DockStyle.Top;
            this.data_cmt.Location = new System.Drawing.Point(3, 3);
            this.data_cmt.Name = "data_cmt";
            this.data_cmt.Size = new System.Drawing.Size(770, 295);
            this.data_cmt.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "STT";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "Tên FB";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.FillWeight = 10F;
            this.dataGridViewTextBoxColumn15.HeaderText = "UID";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Visible = false;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.HeaderText = "Giới Tính";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.HeaderText = "Ngày sinh";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.FillWeight = 60F;
            this.dataGridViewTextBoxColumn18.HeaderText = "Email";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // sdt2
            // 
            this.sdt2.HeaderText = "SĐT";
            this.sdt2.Name = "sdt2";
            this.sdt2.ReadOnly = true;
            // 
            // nca
            // 
            this.nca.HeaderText = "Location";
            this.nca.Name = "nca";
            this.nca.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nội dung";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage5.Controls.Add(this.limit_request);
            this.tabPage5.Controls.Add(this.flatButton25);
            this.tabPage5.Controls.Add(this.flatButton20);
            this.tabPage5.Controls.Add(this.flatButton19);
            this.tabPage5.Controls.Add(this.flatLabel1);
            this.tabPage5.Controls.Add(this.flatButton15);
            this.tabPage5.Controls.Add(this.flatButton16);
            this.tabPage5.Controls.Add(this.flatButton17);
            this.tabPage5.Controls.Add(this.flatButton18);
            this.tabPage5.Controls.Add(this.data_feed);
            this.tabPage5.Location = new System.Drawing.Point(4, 44);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(776, 385);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Quét bài viết";
            // 
            // limit_request
            // 
            this.limit_request.Location = new System.Drawing.Point(695, 334);
            this.limit_request.Name = "limit_request";
            this.limit_request.Size = new System.Drawing.Size(73, 25);
            this.limit_request.TabIndex = 26;
            // 
            // flatButton25
            // 
            this.flatButton25.BackColor = System.Drawing.Color.Transparent;
            this.flatButton25.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.flatButton25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton25.Dock = System.Windows.Forms.DockStyle.Left;
            this.flatButton25.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton25.Location = new System.Drawing.Point(572, 298);
            this.flatButton25.Name = "flatButton25";
            this.flatButton25.Rounded = false;
            this.flatButton25.Size = new System.Drawing.Size(117, 84);
            this.flatButton25.TabIndex = 25;
            this.flatButton25.Text = "Lọc trùng";
            this.flatButton25.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton25.Click += new System.EventHandler(this.flatButton25_Click);
            // 
            // flatButton20
            // 
            this.flatButton20.BackColor = System.Drawing.Color.Transparent;
            this.flatButton20.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.flatButton20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton20.Dock = System.Windows.Forms.DockStyle.Left;
            this.flatButton20.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton20.Location = new System.Drawing.Point(455, 298);
            this.flatButton20.Name = "flatButton20";
            this.flatButton20.Rounded = false;
            this.flatButton20.Size = new System.Drawing.Size(117, 84);
            this.flatButton20.TabIndex = 24;
            this.flatButton20.Text = "Quét CMT DS";
            this.flatButton20.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton20.Click += new System.EventHandler(this.flatButton20_Click);
            // 
            // flatButton19
            // 
            this.flatButton19.BackColor = System.Drawing.Color.Transparent;
            this.flatButton19.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.flatButton19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton19.Dock = System.Windows.Forms.DockStyle.Left;
            this.flatButton19.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton19.Location = new System.Drawing.Point(338, 298);
            this.flatButton19.Name = "flatButton19";
            this.flatButton19.Rounded = false;
            this.flatButton19.Size = new System.Drawing.Size(117, 84);
            this.flatButton19.TabIndex = 23;
            this.flatButton19.Text = "Quét Like DS";
            this.flatButton19.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton19.Click += new System.EventHandler(this.flatButton19_Click);
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(702, 314);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(51, 13);
            this.flatLabel1.TabIndex = 21;
            this.flatLabel1.Text = "Giới hạn";
            // 
            // flatButton15
            // 
            this.flatButton15.BackColor = System.Drawing.Color.Transparent;
            this.flatButton15.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.flatButton15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton15.Dock = System.Windows.Forms.DockStyle.Left;
            this.flatButton15.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton15.Location = new System.Drawing.Point(259, 298);
            this.flatButton15.Name = "flatButton15";
            this.flatButton15.Rounded = false;
            this.flatButton15.Size = new System.Drawing.Size(79, 84);
            this.flatButton15.TabIndex = 16;
            this.flatButton15.Text = "Xóa DS";
            this.flatButton15.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton15.Click += new System.EventHandler(this.flatButton15_Click);
            // 
            // flatButton16
            // 
            this.flatButton16.BackColor = System.Drawing.Color.Transparent;
            this.flatButton16.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.flatButton16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton16.Dock = System.Windows.Forms.DockStyle.Left;
            this.flatButton16.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton16.Location = new System.Drawing.Point(187, 298);
            this.flatButton16.Name = "flatButton16";
            this.flatButton16.Rounded = false;
            this.flatButton16.Size = new System.Drawing.Size(72, 84);
            this.flatButton16.TabIndex = 17;
            this.flatButton16.Text = "Lưu DS";
            this.flatButton16.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton16.Click += new System.EventHandler(this.flatButton16_Click);
            // 
            // flatButton17
            // 
            this.flatButton17.BackColor = System.Drawing.Color.Transparent;
            this.flatButton17.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.flatButton17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton17.Dock = System.Windows.Forms.DockStyle.Left;
            this.flatButton17.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton17.Location = new System.Drawing.Point(89, 298);
            this.flatButton17.Name = "flatButton17";
            this.flatButton17.Rounded = false;
            this.flatButton17.Size = new System.Drawing.Size(98, 84);
            this.flatButton17.TabIndex = 15;
            this.flatButton17.Text = "Quét tệp ID";
            this.flatButton17.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton17.Click += new System.EventHandler(this.flatButton17_Click);
            // 
            // flatButton18
            // 
            this.flatButton18.BackColor = System.Drawing.Color.Transparent;
            this.flatButton18.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.flatButton18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton18.Dock = System.Windows.Forms.DockStyle.Left;
            this.flatButton18.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton18.Location = new System.Drawing.Point(3, 298);
            this.flatButton18.Name = "flatButton18";
            this.flatButton18.Rounded = false;
            this.flatButton18.Size = new System.Drawing.Size(86, 84);
            this.flatButton18.TabIndex = 18;
            this.flatButton18.Text = "Quét 1 ID";
            this.flatButton18.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton18.Click += new System.EventHandler(this.flatButton18_Click);
            // 
            // data_feed
            // 
            this.data_feed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_feed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_feed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24});
            this.data_feed.Dock = System.Windows.Forms.DockStyle.Top;
            this.data_feed.Location = new System.Drawing.Point(3, 3);
            this.data_feed.Name = "data_feed";
            this.data_feed.Size = new System.Drawing.Size(770, 295);
            this.data_feed.TabIndex = 22;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.HeaderText = "STT";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.HeaderText = "Nội dung";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.HeaderText = "ID";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.HeaderText = "Likes";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.HeaderText = "Comments";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.HeaderText = "Shares";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            // 
            // flatClose1
            // 
            this.flatClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatClose1.BackColor = System.Drawing.Color.White;
            this.flatClose1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.flatClose1.Font = new System.Drawing.Font("Marlett", 10F);
            this.flatClose1.Location = new System.Drawing.Point(754, 12);
            this.flatClose1.Name = "flatClose1";
            this.flatClose1.Size = new System.Drawing.Size(18, 18);
            this.flatClose1.TabIndex = 0;
            this.flatClose1.Text = "flatClose1";
            this.flatClose1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // process
            // 
            this.process.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.process.DarkerProgress = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(148)))), ((int)(((byte)(92)))));
            this.process.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.process.Location = new System.Drawing.Point(0, 428);
            this.process.Maximum = 100;
            this.process.Name = "process";
            this.process.Pattern = true;
            this.process.PercentSign = false;
            this.process.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.process.ShowBalloon = true;
            this.process.Size = new System.Drawing.Size(784, 42);
            this.process.TabIndex = 3;
            this.process.Text = "flatProgressBar1";
            this.process.Value = 0;
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.status.Cursor = System.Windows.Forms.Cursors.Hand;
            this.status.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.status.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.status.kind = FlatUI.FlatAlertBox._Kind.Success;
            this.status.Location = new System.Drawing.Point(0, 470);
            this.status.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.status.Name = "status";
            this.status.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.status.Size = new System.Drawing.Size(784, 42);
            this.status.TabIndex = 2;
            this.status.Text = "Software Company";
            this.status.Visible = false;
            this.status.Click += new System.EventHandler(this.status_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 512);
            this.Controls.Add(this.formSkin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Main";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.formSkin1.ResumeLayout(false);
            this.formSkin1.PerformLayout();
            this.flatTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_friends)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datamembers)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_like)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_cmt)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.limit_request)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_feed)).EndInit();
            this.ResumeLayout(false);

    }

    [CompilerGenerated]
    private void method_1() {
      this.status.Text = "Kết nối thất bại";
    }

    [CompilerGenerated]
    private void method_2() {
      this.status.Text = "Kết nối thất bại";
    }

    [CompilerGenerated]
    private void method_3() {
      FlatProgressBar expr_06 = this.process;
      int value = expr_06.Value;
      expr_06.Value = value + 1;
    }

    [CompilerGenerated]
    private void method_4() {
      FlatProgressBar expr_06 = this.process;
      int value = expr_06.Value;
      expr_06.Value = value + 1;
    }

    [CompilerGenerated]
    private void method_5() {
      FlatProgressBar expr_06 = this.process;
      int value = expr_06.Value;
      expr_06.Value = value + 1;
    }

    [CompilerGenerated]
    private void method_6() {
      FlatProgressBar expr_06 = this.process;
      int value = expr_06.Value;
      expr_06.Value = value + 1;
    }

    [CompilerGenerated]
    private void method_7() {
      FlatProgressBar expr_06 = this.process;
      int value = expr_06.Value;
      expr_06.Value = value + 1;
    }

    [CompilerGenerated]
    private void method_8() {
      this.status.Text = "Kết nối thất bại";
    }

    [CompilerGenerated]
    private void method_9() {
      this.status.Text = "Kết nối thất bại.";
    }

    [CompilerGenerated]
    private void method_10() {
      this.status.Text = "Kết nối thất bại";
    }
  }
}

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
using FlatUI;
using Microsoft.CSharp.RuntimeBinder;
using Microsoft.VisualBasic;
using Newtonsoft.Json.Linq;

namespace Simple_UID
{
	// Token: 0x02000005 RID: 5
	public partial class frm_Main : Form
	{
		// Token: 0x0600000F RID: 15 RVA: 0x00002E04 File Offset: 0x00001004
		public frm_Main()
		{
			this.InitializeComponent();
			this.status.Visible = true;
			this.status.kind = FlatAlertBox._Kind.Info;
			try
			{
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
				if (a == "")
				{
					this.string_0 = "";
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002EF8 File Offset: 0x000010F8
		public string gethtml(string Url)
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
			return result;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002F9C File Offset: 0x0000119C
		public void get_cookie(string cookie_z)
		{
			if (cookie_z == "x")
			{
				this.string_0 = "x";
				base.Close();
				Application.Exit();
			}
			else
			{
				this.string_0 = cookie_z.Split(new char[]
				{
					'|'
				})[2];
				this.string_1 = cookie_z.Split(new char[]
				{
					'|'
				})[3];
				this.string_2 = cookie_z.Split(new char[]
				{
					'|'
				})[1];
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0000301C File Offset: 0x0000121C
		private void frm_Main_Load(object sender, EventArgs e)
		{
			while (this.string_0 == "")
			{
				new frm_Login
				{
					mycookie = new frm_Login.get_cookie(this.get_cookie)
				}.ShowDialog();
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00003060 File Offset: 0x00001260
		private void btn_get_friends_1_uid_Click(object sender, EventArgs e)
		{
			frm_Main.Class0 @class = new frm_Main.Class0();
			@class.frm_Main_0 = this;
			@class.string_0 = Interaction.InputBox("Vui lòng nhập UID?", "Nhập 1 UID", "me", -1, -1);
			if (@class.string_0.Length > 0)
			{
				Thread thread = new Thread(new ThreadStart(@class.method_0));
				thread.Start();
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000030C0 File Offset: 0x000012C0
		public void membersofgid(string gid, DataGridView dgv)
		{
			frm_Main.Class1 @class = new frm_Main.Class1();
			@class.frm_Main_0 = this;
			@class.dataGridView_0 = dgv;
			@class.string_0 = gid;
			try
			{
				string requestUriString = "https://graph.facebook.com/" + @class.string_0 + "/members?limit=500&fields=id,name,birthday,email,gender,mobile_phone,location&access_token=" + this.string_0;
				bool flag = true;
				while (flag)
				{
					HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUriString);
					httpWebRequest.UserAgent = "Dalvik/1.6.0 (Linux; U; Android 4.3; Z10 Build/10.3.2.110) [FBAN/FB4A;FBAV/19.0.0.23.14;FBLC/vi_VN;FBBV/4694056;FBCR/null;FBMF/RIM;FBBD/BlackBerry;FBDV/Z10;FBSV/4.3;FBCA/armeabi-v7a:armeabi;FBDM/{density=2.0,width=768,height=1174};FB_FW/1;]";
					HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
					string json = new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd();
					JObject jobject = JObject.Parse(json);
					foreach (JToken jtoken in ((IEnumerable<JToken>)jobject["data"]))
					{
						frm_Main.Class2 class2 = new frm_Main.Class2();
						class2.class1_0 = @class;
						class2.string_1 = (string)jtoken["id"];
						class2.string_0 = (string)jtoken["name"];
						class2.string_2 = (string)jtoken["gender"];
						class2.string_3 = (string)jtoken["birthday"];
						class2.string_4 = (string)jtoken["email"];
						class2.string_5 = (string)jtoken["mobile_phone"];
						class2.string_6 = "";
						if (jtoken["location"] != null)
						{
							class2.string_6 = (string)jtoken["location"]["name"];
						}
						base.Invoke(new MethodInvoker(class2.method_0));
					}
					if (jobject["paging"]["next"] != null)
					{
						requestUriString = (string)jobject["paging"]["next"];
					}
					else
					{
						flag = false;
					}
					MethodInvoker method;
					if ((method = @class.methodInvoker_0) == null)
					{
						method = (@class.methodInvoker_0 = new MethodInvoker(@class.method_0));
					}
					base.Invoke(method);
				}
			}
			catch
			{
				base.Invoke(new MethodInvoker(this.method_1));
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00003330 File Offset: 0x00001530
		public void friendsofuid(string uid, DataGridView dgv)
		{
			frm_Main.Class3 @class = new frm_Main.Class3();
			@class.frm_Main_0 = this;
			@class.dataGridView_0 = dgv;
			@class.string_0 = uid;
			try
			{
				string requestUriString = "https://graph.facebook.com/" + @class.string_0 + "/friends?limit=500&fields=id,name,mobile_phone,birthday,email,gender,location&access_token=" + this.string_0;
				bool flag = true;
				while (flag)
				{
					HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUriString);
					httpWebRequest.UserAgent = "Dalvik/1.6.0 (Linux; U; Android 4.3; Z10 Build/10.3.2.110) [FBAN/FB4A;FBAV/19.0.0.23.14;FBLC/vi_VN;FBBV/4694056;FBCR/null;FBMF/RIM;FBBD/BlackBerry;FBDV/Z10;FBSV/4.3;FBCA/armeabi-v7a:armeabi;FBDM/{density=2.0,width=768,height=1174};FB_FW/1;]";
					HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
					string json = new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd();
					JObject jobject = JObject.Parse(json);
					foreach (JToken jtoken in ((IEnumerable<JToken>)jobject["data"]))
					{
						frm_Main.Class4 class2 = new frm_Main.Class4();
						class2.class3_0 = @class;
						class2.string_1 = (string)jtoken["id"];
						class2.string_0 = (string)jtoken["name"];
						class2.string_2 = (string)jtoken["gender"];
						class2.string_3 = (string)jtoken["birthday"];
						class2.string_5 = (string)jtoken["mobile_phone"];
						class2.string_6 = "";
						if (jtoken["location"] != null)
						{
							class2.string_6 = (string)jtoken["location"]["name"];
						}
						class2.string_4 = (string)jtoken["email"];
						base.Invoke(new MethodInvoker(class2.method_0));
					}
					if (jobject["paging"]["next"] != null)
					{
						requestUriString = (string)jobject["paging"]["next"];
					}
					else
					{
						flag = false;
					}
					MethodInvoker method;
					if ((method = @class.methodInvoker_0) == null)
					{
						method = (@class.methodInvoker_0 = new MethodInvoker(@class.method_0));
					}
					base.Invoke(method);
				}
			}
			catch
			{
				base.Invoke(new MethodInvoker(this.method_2));
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000035A0 File Offset: 0x000017A0
		private void btn_get_friends_from_file_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
			openFileDialog.FilterIndex = 1;
			openFileDialog.Multiselect = false;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					frm_Main.Class5 @class = new frm_Main.Class5();
					@class.frm_Main_0 = this;
					@class.string_0 = File.ReadAllLines(openFileDialog.FileName);
					this.process.Maximum = @class.string_0.Count<string>();
					Path.GetDirectoryName(openFileDialog.FileName);
					Thread thread = new Thread(new ThreadStart(@class.method_0));
					thread.Start();
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00003648 File Offset: 0x00001848
		public void loc(string[] list)
		{
			foreach (string text in list)
			{
				base.Invoke(new MethodInvoker(this.method_3));
				try
				{
					this.friendsofuid(text.Split(new char[]
					{
						'|'
					})[0], this.data_friends);
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000036B0 File Offset: 0x000018B0
		public void loc2(string[] list)
		{
			foreach (string text in list)
			{
				base.Invoke(new MethodInvoker(this.method_4));
				try
				{
					this.membersofgid(text.Split(new char[]
					{
						'|'
					})[0], this.datamembers);
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00003718 File Offset: 0x00001918
		public void loc3(string[] list)
		{
			foreach (string text in list)
			{
				base.Invoke(new MethodInvoker(this.method_5));
				try
				{
					this.getcmt(text.Split(new char[]
					{
						'|'
					})[0], this.data_cmt);
				}
				catch
				{
				}
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00003780 File Offset: 0x00001980
		public void loc4(string[] list)
		{
			foreach (string text in list)
			{
				base.Invoke(new MethodInvoker(this.method_6));
				try
				{
					this.getlike(text.Split(new char[]
					{
						'|'
					})[0], this.data_like);
				}
				catch
				{
				}
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000037E8 File Offset: 0x000019E8
		public void loc5(string[] list)
		{
			foreach (string text in list)
			{
				base.Invoke(new MethodInvoker(this.method_7));
				try
				{
					this.getfeed(text.Split(new char[]
					{
						'|'
					})[0], this.data_feed);
				}
				catch
				{
				}
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000020E3 File Offset: 0x000002E3
		private void flatButton2_Click(object sender, EventArgs e)
		{
			this.data_friends.Rows.Clear();
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000020F5 File Offset: 0x000002F5
		private void flatButton3_Click(object sender, EventArgs e)
		{
			this.savefile(this.data_friends);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00003850 File Offset: 0x00001A50
		public void savefile(DataGridView dtg)
		{
			DialogResult dialogResult = MessageBox.Show("Bạn có muốn lưu đầy đủ thông tin?. Chọn NO để lưu chỉ ID", "Lưu đầy đủ", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				SaveFileDialog saveFileDialog = new SaveFileDialog();
				saveFileDialog.FileName = "Xuất File-" + DateTime.Now.ToString("MM-dd-yyyy-HH-mm-ss-fff") + ".xls";
				saveFileDialog.Filter = "Text File | *.xls";
				if (saveFileDialog.ShowDialog() != DialogResult.OK)
				{
					return;
				}
				this.status.Text = "Đang lưu file...";
				try
				{
					StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName, false, Encoding.Unicode);
					for (int i = 0; i <= dtg.Rows.Count - 1; i++)
					{
						string text = "";
						for (int j = 0; j <= dtg.Columns.Count - 1; j++)
						{
							if (dtg.Rows[i].Cells[j].Value != null)
							{
								string text2 = dtg.Rows[i].Cells[j].Value.ToString();
								if (text2.Length < 100)
								{
									text = text + dtg.Rows[i].Cells[j].Value.ToString() + "\t";
								}
								else
								{
									text += "ẩn\t";
								}
							}
							else
							{
								text += "\t";
							}
						}
						streamWriter.WriteLine(text);
					}
					streamWriter.Dispose();
					streamWriter.Close();
					this.status.Text = "Xuất file Excel thành công.";
					return;
				}
				catch (Exception ex)
				{
					this.status.Text = ex.Message;
					return;
				}
			}
			if (dialogResult == DialogResult.No)
			{
				SaveFileDialog saveFileDialog2 = new SaveFileDialog();
				saveFileDialog2.FileName = "Xuất File-" + DateTime.Now.ToString("MM-dd-yyyy-HH-mm-ss-fff") + ".txt";
				saveFileDialog2.Filter = "Text File | *.txt";
				if (saveFileDialog2.ShowDialog() == DialogResult.OK)
				{
					this.status.Text = "Đang lưu file...";
					try
					{
						StreamWriter streamWriter2 = new StreamWriter(saveFileDialog2.FileName, false, Encoding.Unicode);
						for (int k = 0; k <= dtg.Rows.Count - 1; k++)
						{
							string text3 = "";
							text3 = text3 + dtg.Rows[k].Cells[2].Value.ToString() + "\n";
							streamWriter2.WriteLine(text3);
						}
						streamWriter2.Dispose();
						streamWriter2.Close();
						this.status.Text = "Xuất file TXT thành công.";
					}
					catch (Exception)
					{
					}
				}
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00003B4C File Offset: 0x00001D4C
		private void flatButton6_Click(object sender, EventArgs e)
		{
			frm_Main.Class6 @class = new frm_Main.Class6();
			@class.frm_Main_0 = this;
			@class.string_0 = Interaction.InputBox("Vui lòng nhập GID?", "Nhập 1 GID", "", -1, -1);
			if (@class.string_0.Length > 0)
			{
				Thread thread = new Thread(new ThreadStart(@class.method_0));
				thread.Start();
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002103 File Offset: 0x00000303
		private void flatButton1_Click(object sender, EventArgs e)
		{
			this.datamembers.Rows.Clear();
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002115 File Offset: 0x00000315
		private void flatButton4_Click(object sender, EventArgs e)
		{
			this.savefile(this.datamembers);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003BAC File Offset: 0x00001DAC
		private void flatButton5_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
			openFileDialog.FilterIndex = 1;
			openFileDialog.Multiselect = false;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					frm_Main.Class7 @class = new frm_Main.Class7();
					@class.frm_Main_0 = this;
					@class.string_0 = File.ReadAllLines(openFileDialog.FileName);
					this.process.Maximum = @class.string_0.Count<string>();
					Path.GetDirectoryName(openFileDialog.FileName);
					Thread thread = new Thread(new ThreadStart(@class.method_0));
					thread.Start();
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003C54 File Offset: 0x00001E54
		private void flatButton14_Click(object sender, EventArgs e)
		{
			frm_Main.Class8 @class = new frm_Main.Class8();
			@class.frm_Main_0 = this;
			@class.string_0 = Interaction.InputBox("Vui lòng nhập ID?", "Nhập 1 ID", "", -1, -1);
			if (@class.string_0.Length > 0)
			{
				Thread thread = new Thread(new ThreadStart(@class.method_0));
				thread.Start();
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00003CB4 File Offset: 0x00001EB4
		public void getcmt(string uid, DataGridView dgv)
		{
			frm_Main.Class9 @class = new frm_Main.Class9();
			@class.frm_Main_0 = this;
			@class.dataGridView_0 = dgv;
			@class.string_0 = uid;
			try
			{
				string url = "https://graph.facebook.com/" + @class.string_0 + "/comments?limit=500&fields=message,from.location,from.birthday,from.email,from.gender,from.name,from.mobile_phone&access_token=" + this.string_0;
				bool flag = true;
				while (flag)
				{
					string json = this.gethtml(url);
					JObject jobject = JObject.Parse(json);
					foreach (JToken jtoken in ((IEnumerable<JToken>)jobject["data"]))
					{
						frm_Main.Class10 class2 = new frm_Main.Class10();
						class2.class9_0 = @class;
						JToken jtoken2 = jtoken["from"];
						class2.string_1 = (string)jtoken2["id"];
						class2.string_0 = (string)jtoken2["name"];
						class2.string_2 = (string)jtoken2["gender"];
						class2.string_7 = (string)jtoken["message"];
						class2.string_3 = (string)jtoken2["birthday"];
						class2.string_4 = (string)jtoken2["email"];
						class2.string_5 = (string)jtoken2["mobile_phone"];
						class2.string_6 = "";
						if (jtoken2["location"] != null)
						{
							class2.string_6 = (string)jtoken2["location"]["name"];
						}
						base.Invoke(new MethodInvoker(class2.method_0));
					}
					if (jobject["paging"]["next"] != null)
					{
						url = (string)jobject["paging"]["next"];
					}
					else
					{
						flag = false;
					}
					MethodInvoker method;
					if ((method = @class.methodInvoker_0) == null)
					{
						method = (@class.methodInvoker_0 = new MethodInvoker(@class.method_0));
					}
					base.Invoke(method);
				}
			}
			catch (Exception)
			{
				base.Invoke(new MethodInvoker(this.method_8));
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003F18 File Offset: 0x00002118
		public void getlike(string uid, DataGridView dgv)
		{
			frm_Main.Class12 @class = new frm_Main.Class12();
			@class.frm_Main_0 = this;
			@class.dataGridView_0 = dgv;
			@class.string_0 = uid;
			try
			{
				string requestUriString = "https://graph.facebook.com/" + @class.string_0 + "/likes?limit=200&access_token=" + this.string_0;
				bool flag = true;
				bool flag2 = false;
				int num = 200;
				int num2 = 0;
				List<string> list = new List<string>();
				List<string> list2 = new List<string>();
				while (flag)
				{
					string text = "";
					if (!flag2)
					{
						HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUriString);
						httpWebRequest.UserAgent = "Dalvik/1.6.0 (Linux; U; Android 4.3; Z10 Build/10.3.2.110) [FBAN/FB4A;FBAV/19.0.0.23.14;FBLC/vi_VN;FBBV/4694056;FBCR/null;FBMF/RIM;FBBD/BlackBerry;FBDV/Z10;FBSV/4.3;FBCA/armeabi-v7a:armeabi;FBDM/{density=2.0,width=768,height=1174};FB_FW/1;]";
						HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
						string json = new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd();
						JObject jobject = JObject.Parse(json);
						foreach (JToken jtoken in ((IEnumerable<JToken>)jobject["data"]))
						{
							string text2 = (string)jtoken["id"];
							list.Add(text2);
							if (text2.Length > 10)
							{
								if (text2.Substring(0, 4) == "1000")
								{
									text = text + text2 + ",";
								}
							}
							else
							{
								text = text + text2 + ",";
							}
						}
						if (text == "")
						{
							string requestUriString2 = "https://graph.facebook.com/" + @class.string_0 + "/reactions?summary=true&access_token=" + this.string_0;
							HttpWebRequest httpWebRequest2 = (HttpWebRequest)WebRequest.Create(requestUriString2);
							httpWebRequest2.UserAgent = "Dalvik/1.6.0 (Linux; U; Android 4.3; Z10 Build/10.3.2.110) [FBAN/FB4A;FBAV/19.0.0.23.14;FBLC/vi_VN;FBBV/4694056;FBCR/null;FBMF/RIM;FBBD/BlackBerry;FBDV/Z10;FBSV/4.3;FBCA/armeabi-v7a:armeabi;FBDM/{density=2.0,width=768,height=1174};FB_FW/1;]";
							HttpWebResponse httpWebResponse2 = (HttpWebResponse)httpWebRequest2.GetResponse();
							string json2 = new StreamReader(httpWebResponse2.GetResponseStream()).ReadToEnd();
							JObject jobject2 = JObject.Parse(json2);
							num2 = (int)jobject2["summary"]["total_count"];
							if (num2 > 0)
							{
								flag2 = true;
								if (num > num2 && num2 > 1)
								{
									num = num2 - 1;
								}
							}
							else
							{
								flag = false;
							}
						}
						if (jobject["paging"]["next"] != null)
						{
							requestUriString = (string)jobject["paging"]["next"];
						}
					}
					if (flag2)
					{
						string[] array = @class.string_0.Split(new char[]
						{
							'_'
						});
						if (array.Length > 1)
						{
							@class.string_0 = @class.string_0.Split(new char[]
							{
								'_'
							})[1];
						}
						if (list.Count == 0)
						{
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
						try
						{
							CookieContainer cookieContainer = new CookieContainer();
							Cookie cookie = new Cookie(array3[0].Trim(), array3[1].Trim(), "/", ".facebook.com");
							cookieContainer.Add(cookie);
							Cookie cookie2 = new Cookie(array4[0].Trim(), array4[1].Trim(), "/", ".facebook.com");
							cookieContainer.Add(cookie2);
							httpWebRequest3.CookieContainer = cookieContainer;
							goto IL_C45;
						}
						catch (Exception value)
						{
							Debug.Write(value);
							goto IL_C45;
						}
						IL_3AF:
						string[] array5;
						try
						{
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
							if (array6.Length == 0)
							{
								flag = false;
							}
							else
							{
								int num3 = 0;
								while (num3 < array6.Length && num3 < 199)
								{
									string text4 = array6[num3];
									if (text4.Length > 10)
									{
										if (text4.Substring(0, 4) == "1000")
										{
											text = text + text4 + ",";
										}
									}
									else
									{
										text = text + text4 + ",";
									}
									num3++;
								}
							}
							goto IL_4FD;
						}
						catch (Exception value2)
						{
							Debug.Write(value2);
							goto IL_4FD;
						}
						goto IL_4FB;
						IL_C45:
						HttpWebResponse httpWebResponse3 = (HttpWebResponse)httpWebRequest3.GetResponse();
						string input2 = new StreamReader(httpWebResponse3.GetResponseStream()).ReadToEnd();
						array5 = Regex.Split(input2, ";shown_ids=");
						if (array5.Length > 1)
						{
							goto IL_3AF;
						}
						IL_4FB:
						flag = false;
					}
					IL_4FD:
					try
					{
						text = text.Replace("\\u00252C", ",");
						string requestUriString3 = "https://graph.facebook.com/?ids=" + text.Substring(0, text.Length - 1) + "&access_token=" + this.string_0;
						HttpWebRequest httpWebRequest4 = (HttpWebRequest)WebRequest.Create(requestUriString3);
						httpWebRequest4.UserAgent = "Dalvik/1.6.0 (Linux; U; Android 4.3; Z10 Build/10.3.2.110) [FBAN/FB4A;FBAV/19.0.0.23.14;FBLC/vi_VN;FBBV/4694056;FBCR/null;FBMF/RIM;FBBD/BlackBerry;FBDV/Z10;FBSV/4.3;FBCA/armeabi-v7a:armeabi;FBDM/{density=2.0,width=768,height=1174};FB_FW/1;]";
						HttpWebResponse httpWebResponse4 = (HttpWebResponse)httpWebRequest4.GetResponse();
						string json3 = new StreamReader(httpWebResponse4.GetResponseStream()).ReadToEnd();
						JObject jobject3 = JObject.Parse(json3);
						foreach (object arg in ((IEnumerable<JToken>)jobject3))
						{
							frm_Main.Class13 class2 = new frm_Main.Class13();
							class2.class12_0 = @class;
							if (frm_Main.Class11.callSite_0 == null)
							{
								frm_Main.Class11.callSite_0 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "Value", typeof(frm_Main), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							object arg2 = frm_Main.Class11.callSite_0.Target(frm_Main.Class11.callSite_0, arg);
							frm_Main.Class13 class3 = class2;
							if (frm_Main.Class11.callSite_2 == null)
							{
								frm_Main.Class11.callSite_2 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(frm_Main)));
							}
							Func<CallSite, object, string> target = frm_Main.Class11.callSite_2.Target;
							CallSite callSite_ = frm_Main.Class11.callSite_2;
							if (frm_Main.Class11.callSite_1 == null)
							{
								frm_Main.Class11.callSite_1 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(frm_Main), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
								}));
							}
							class3.string_1 = target(callSite_, frm_Main.Class11.callSite_1.Target(frm_Main.Class11.callSite_1, arg2, "id"));
							frm_Main.Class13 class4 = class2;
							if (frm_Main.Class11.callSite_4 == null)
							{
								frm_Main.Class11.callSite_4 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(frm_Main)));
							}
							Func<CallSite, object, string> target2 = frm_Main.Class11.callSite_4.Target;
							CallSite callSite_2 = frm_Main.Class11.callSite_4;
							if (frm_Main.Class11.callSite_3 == null)
							{
								frm_Main.Class11.callSite_3 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(frm_Main), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
								}));
							}
							class4.string_0 = target2(callSite_2, frm_Main.Class11.callSite_3.Target(frm_Main.Class11.callSite_3, arg2, "name"));
							frm_Main.Class13 class5 = class2;
							if (frm_Main.Class11.callSite_6 == null)
							{
								frm_Main.Class11.callSite_6 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(frm_Main)));
							}
							Func<CallSite, object, string> target3 = frm_Main.Class11.callSite_6.Target;
							CallSite callSite_3 = frm_Main.Class11.callSite_6;
							if (frm_Main.Class11.callSite_5 == null)
							{
								frm_Main.Class11.callSite_5 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(frm_Main), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
								}));
							}
							class5.string_2 = target3(callSite_3, frm_Main.Class11.callSite_5.Target(frm_Main.Class11.callSite_5, arg2, "gender"));
							frm_Main.Class13 class6 = class2;
							if (frm_Main.Class11.callSite_8 == null)
							{
								frm_Main.Class11.callSite_8 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(frm_Main)));
							}
							Func<CallSite, object, string> target4 = frm_Main.Class11.callSite_8.Target;
							CallSite callSite_4 = frm_Main.Class11.callSite_8;
							if (frm_Main.Class11.callSite_7 == null)
							{
								frm_Main.Class11.callSite_7 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(frm_Main), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
								}));
							}
							class6.string_3 = target4(callSite_4, frm_Main.Class11.callSite_7.Target(frm_Main.Class11.callSite_7, arg2, "birthday"));
							frm_Main.Class13 class7 = class2;
							if (frm_Main.Class11.callSite_10 == null)
							{
								frm_Main.Class11.callSite_10 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(frm_Main)));
							}
							Func<CallSite, object, string> target5 = frm_Main.Class11.callSite_10.Target;
							CallSite callSite_5 = frm_Main.Class11.callSite_10;
							if (frm_Main.Class11.callSite_9 == null)
							{
								frm_Main.Class11.callSite_9 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(frm_Main), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
								}));
							}
							class7.string_4 = target5(callSite_5, frm_Main.Class11.callSite_9.Target(frm_Main.Class11.callSite_9, arg2, "email"));
							frm_Main.Class13 class8 = class2;
							if (frm_Main.Class11.callSite_12 == null)
							{
								frm_Main.Class11.callSite_12 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(frm_Main)));
							}
							Func<CallSite, object, string> target6 = frm_Main.Class11.callSite_12.Target;
							CallSite callSite_6 = frm_Main.Class11.callSite_12;
							if (frm_Main.Class11.callSite_11 == null)
							{
								frm_Main.Class11.callSite_11 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(frm_Main), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
								}));
							}
							class8.string_5 = target6(callSite_6, frm_Main.Class11.callSite_11.Target(frm_Main.Class11.callSite_11, arg2, "mobile_phone"));
							class2.string_6 = "";
							if (frm_Main.Class11.callSite_15 == null)
							{
								frm_Main.Class11.callSite_15 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(frm_Main), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							Func<CallSite, object, bool> target7 = frm_Main.Class11.callSite_15.Target;
							CallSite callSite_7 = frm_Main.Class11.callSite_15;
							if (frm_Main.Class11.callSite_14 == null)
							{
								frm_Main.Class11.callSite_14 = CallSite<Func<CallSite, object, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.NotEqual, typeof(frm_Main), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, null)
								}));
							}
							Func<CallSite, object, object, object> target8 = frm_Main.Class11.callSite_14.Target;
							CallSite callSite_8 = frm_Main.Class11.callSite_14;
							if (frm_Main.Class11.callSite_13 == null)
							{
								frm_Main.Class11.callSite_13 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(frm_Main), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
								}));
							}
							if (target7(callSite_7, target8(callSite_8, frm_Main.Class11.callSite_13.Target(frm_Main.Class11.callSite_13, arg2, "location"), null)))
							{
								frm_Main.Class13 class9 = class2;
								if (frm_Main.Class11.callSite_18 == null)
								{
									frm_Main.Class11.callSite_18 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(frm_Main)));
								}
								Func<CallSite, object, string> target9 = frm_Main.Class11.callSite_18.Target;
								CallSite callSite_9 = frm_Main.Class11.callSite_18;
								if (frm_Main.Class11.callSite_17 == null)
								{
									frm_Main.Class11.callSite_17 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(frm_Main), new CSharpArgumentInfo[]
									{
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
									}));
								}
								Func<CallSite, object, string, object> target10 = frm_Main.Class11.callSite_17.Target;
								CallSite callSite_10 = frm_Main.Class11.callSite_17;
								if (frm_Main.Class11.callSite_16 == null)
								{
									frm_Main.Class11.callSite_16 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.GetIndex(CSharpBinderFlags.None, typeof(frm_Main), new CSharpArgumentInfo[]
									{
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
									}));
								}
								class9.string_6 = target9(callSite_9, target10(callSite_10, frm_Main.Class11.callSite_16.Target(frm_Main.Class11.callSite_16, arg2, "location"), "name"));
							}
							if (!list2.Contains(class2.string_1))
							{
								list2.Add(class2.string_1);
								base.Invoke(new MethodInvoker(class2.method_0));
							}
						}
					}
					catch (Exception)
					{
						base.Invoke(new MethodInvoker(this.method_9));
					}
					MethodInvoker method;
					if ((method = @class.methodInvoker_0) == null)
					{
						method = (@class.methodInvoker_0 = new MethodInvoker(@class.method_0));
					}
					base.Invoke(method);
					list = list.Distinct<string>().ToList<string>();
					if (list.Count > num2)
					{
						flag = false;
					}
				}
			}
			catch (Exception)
			{
				base.Invoke(new MethodInvoker(@class.method_1));
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00004C58 File Offset: 0x00002E58
		private void flatButton13_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
			openFileDialog.FilterIndex = 1;
			openFileDialog.Multiselect = false;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					frm_Main.Class14 @class = new frm_Main.Class14();
					@class.frm_Main_0 = this;
					@class.string_0 = File.ReadAllLines(openFileDialog.FileName);
					this.process.Maximum = @class.string_0.Count<string>();
					Path.GetDirectoryName(openFileDialog.FileName);
					Thread thread = new Thread(new ThreadStart(@class.method_0));
					thread.Start();
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00004D00 File Offset: 0x00002F00
		private void flatButton9_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
			openFileDialog.FilterIndex = 1;
			openFileDialog.Multiselect = false;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					frm_Main.Class15 @class = new frm_Main.Class15();
					@class.frm_Main_0 = this;
					@class.string_0 = File.ReadAllLines(openFileDialog.FileName);
					this.process.Maximum = @class.string_0.Count<string>();
					Path.GetDirectoryName(openFileDialog.FileName);
					Thread thread = new Thread(new ThreadStart(@class.method_0));
					thread.Start();
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00004DA8 File Offset: 0x00002FA8
		private void flatButton10_Click(object sender, EventArgs e)
		{
			frm_Main.Class16 @class = new frm_Main.Class16();
			@class.frm_Main_0 = this;
			@class.string_0 = Interaction.InputBox("Vui lòng nhập ID?", "Nhập 1 ID", "", -1, -1);
			if (@class.string_0.Length > 0)
			{
				Thread thread = new Thread(new ThreadStart(@class.method_0));
				thread.Start();
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002123 File Offset: 0x00000323
		private void flatButton8_Click(object sender, EventArgs e)
		{
			this.savefile(this.data_like);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002131 File Offset: 0x00000331
		private void flatButton12_Click(object sender, EventArgs e)
		{
			this.savefile(this.data_cmt);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x0000213F File Offset: 0x0000033F
		private void flatButton7_Click(object sender, EventArgs e)
		{
			this.data_like.Rows.Clear();
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002151 File Offset: 0x00000351
		private void flatButton11_Click(object sender, EventArgs e)
		{
			this.data_cmt.Rows.Clear();
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002163 File Offset: 0x00000363
		private void flatButton15_Click(object sender, EventArgs e)
		{
			this.data_feed.Rows.Clear();
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002175 File Offset: 0x00000375
		private void flatButton16_Click(object sender, EventArgs e)
		{
			this.savefile(this.data_feed);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00004E08 File Offset: 0x00003008
		private void flatButton18_Click(object sender, EventArgs e)
		{
			frm_Main.Class17 @class = new frm_Main.Class17();
			@class.frm_Main_0 = this;
			@class.string_0 = Interaction.InputBox("Vui lòng nhập ID?", "Nhập 1 ID", "", -1, -1);
			if (@class.string_0.Length > 0)
			{
				Thread thread = new Thread(new ThreadStart(@class.method_0));
				thread.Start();
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00004E68 File Offset: 0x00003068
		public void getfeed(string uid, DataGridView dgv)
		{
			frm_Main.Class18 @class = new frm_Main.Class18();
			@class.frm_Main_0 = this;
			@class.dataGridView_0 = dgv;
			@class.string_0 = uid;
			try
			{
				string requestUriString = "https://graph.facebook.com/" + @class.string_0 + "/feed?access_token=" + this.string_0;
				bool flag = true;
				while (flag)
				{
					HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUriString);
					httpWebRequest.UserAgent = "Dalvik/1.6.0 (Linux; U; Android 4.3; Z10 Build/10.3.2.110) [FBAN/FB4A;FBAV/19.0.0.23.14;FBLC/vi_VN;FBBV/4694056;FBCR/null;FBMF/RIM;FBBD/BlackBerry;FBDV/Z10;FBSV/4.3;FBCA/armeabi-v7a:armeabi;FBDM/{density=2.0,width=768,height=1174};FB_FW/1;]";
					HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
					string json = new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd();
					JObject jobject = JObject.Parse(json);
					foreach (JToken jtoken in ((IEnumerable<JToken>)jobject["data"]))
					{
						frm_Main.Class19 class2 = new frm_Main.Class19();
						class2.class18_0 = @class;
						class2.string_1 = (string)jtoken["id"];
						class2.string_0 = (string)jtoken["message"];
						class2.string_4 = "0";
						try
						{
							class2.string_4 = (string)jtoken["shares"]["count"];
							goto IL_1D6;
						}
						catch
						{
							goto IL_1D6;
						}
						try
						{
							IL_11F:
							class2.string_2 = (string)jtoken["likes"]["count"];
						}
						catch
						{
						}
						class2.string_3 = "0";
						try
						{
							class2.string_3 = (string)jtoken["comments"]["count"];
						}
						catch
						{
						}
						//(string)jtoken["type"];
						base.Invoke(new MethodInvoker(class2.method_0));
						if (class2.class18_0.dataGridView_0.Rows.Count >= (int)this.limit_request.Value)
						{
							flag = false;
							continue;
						}
						continue;
						IL_1D6:
						class2.string_2 = "0";
						//goto IL_11F;
					}
					if (jobject["paging"]["next"] != null)
					{
						requestUriString = (string)jobject["paging"]["next"];
					}
					else
					{
						flag = false;
					}
					MethodInvoker method;
					if ((method = @class.methodInvoker_0) == null)
					{
						method = (@class.methodInvoker_0 = new MethodInvoker(@class.method_0));
					}
					base.Invoke(method);
				}
			}
			catch
			{
				base.Invoke(new MethodInvoker(this.method_10));
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00005168 File Offset: 0x00003368
		private void flatButton17_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
			openFileDialog.FilterIndex = 1;
			openFileDialog.Multiselect = false;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					frm_Main.Class20 @class = new frm_Main.Class20();
					@class.frm_Main_0 = this;
					@class.string_0 = File.ReadAllLines(openFileDialog.FileName);
					this.process.Maximum = @class.string_0.Count<string>();
					Path.GetDirectoryName(openFileDialog.FileName);
					Thread thread = new Thread(new ThreadStart(@class.method_0));
					thread.Start();
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002183 File Offset: 0x00000383
		private void formSkin1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00005210 File Offset: 0x00003410
		private void flatButton19_Click(object sender, EventArgs e)
		{
			try
			{
				frm_Main.Class21 @class = new frm_Main.Class21();
				@class.frm_Main_0 = this;
				@class.list_0 = new List<string>();
				for (int i = 0; i <= this.data_feed.Rows.Count - 1; i++)
				{
					if (this.data_feed.Rows[i].Cells[2].Value != null)
					{
						@class.list_0.Add(this.data_feed.Rows[i].Cells[2].Value.ToString());
					}
				}
				Thread thread = new Thread(new ThreadStart(@class.method_0));
				thread.Start();
			}
			catch
			{
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000052DC File Offset: 0x000034DC
		private void flatButton20_Click(object sender, EventArgs e)
		{
			try
			{
				frm_Main.Class22 @class = new frm_Main.Class22();
				@class.frm_Main_0 = this;
				@class.list_0 = new List<string>();
				for (int i = 0; i <= this.data_feed.Rows.Count - 1; i++)
				{
					if (this.data_feed.Rows[i].Cells[2].Value != null)
					{
						@class.list_0.Add(this.data_feed.Rows[i].Cells[2].Value.ToString());
					}
				}
				Thread thread = new Thread(new ThreadStart(@class.method_0));
				thread.Start();
			}
			catch
			{
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000053A8 File Offset: 0x000035A8
		public void removedouble(DataGridView grv)
		{
			for (int i = 0; i < grv.RowCount; i++)
			{
				for (int j = i + 1; j < grv.RowCount; j++)
				{
					if (grv.Rows[i].Cells[2].Value != null && grv.Rows[i].Cells[2].Value.Equals(grv.Rows[j].Cells[2].Value))
					{
						grv.Rows.Remove(grv.Rows[j]);
					}
				}
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002185 File Offset: 0x00000385
		private void method_0(object sender, EventArgs e)
		{
			this.removedouble(this.data_friends);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002193 File Offset: 0x00000393
		private void flatButton22_Click(object sender, EventArgs e)
		{
			this.removedouble(this.datamembers);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000021A1 File Offset: 0x000003A1
		private void flatButton23_Click(object sender, EventArgs e)
		{
			this.removedouble(this.data_like);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000021AF File Offset: 0x000003AF
		private void flatButton24_Click(object sender, EventArgs e)
		{
			this.removedouble(this.data_cmt);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000021BD File Offset: 0x000003BD
		private void flatButton25_Click(object sender, EventArgs e)
		{
			this.removedouble(this.data_feed);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000021CB File Offset: 0x000003CB
		private void flatButton26_Click(object sender, EventArgs e)
		{
			this.savefile2(this.data_cmt);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00005460 File Offset: 0x00003660
		public void savefile2(DataGridView dtg)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.FileName = "Xuất File-" + DateTime.Now.ToString("MM-dd-yyyy-HH-mm-ss-fff") + ".xls";
			saveFileDialog.Filter = "Text File | *.xls";
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.status.Text = "Đang lưu file...";
				try
				{
					StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName, false, Encoding.Unicode);
					for (int i = 0; i <= dtg.Rows.Count - 1; i++)
					{
						if (dtg.Rows[i].Cells[8].Value != null)
						{
							string text = dtg.Rows[i].Cells[8].Value.ToString();
							if (text.Contains("@"))
							{
								Regex regex = new Regex("\\w+([-+.]\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*", RegexOptions.IgnoreCase);
								MatchCollection matchCollection = regex.Matches(text);
								new StringBuilder();
								int num = 0;
								foreach (object obj in matchCollection)
								{
									Match match = (Match)obj;
									num++;
								}
								string text2 = "";
								if (num > 0)
								{
									for (int j = 0; j <= dtg.Columns.Count - 1; j++)
									{
										if (dtg.Rows[i].Cells[j].Value != null)
										{
											dtg.Rows[i].Cells[j].Value.ToString();
											text2 = text2 + dtg.Rows[i].Cells[j].Value.ToString() + "\t";
										}
										else
										{
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
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000021D9 File Offset: 0x000003D9
		private void status_Click(object sender, EventArgs e)
		{
			this.status.Visible = true;
			this.status.kind = FlatAlertBox._Kind.Info;
			this.status.Text = "ATP Software Company";
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000056CC File Offset: 0x000038CC
		private void flatButton27_Click(object sender, EventArgs e)
		{
			new frm_Login
			{
				mycookie = new frm_Login.get_cookie(this.get_cookie)
			}.ShowDialog();
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002203 File Offset: 0x00000403
		private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://atpsoftware.vn/direct/youtube-atp.php?ref=simpleuid");
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002210 File Offset: 0x00000410
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://atpsoftware.vn/direct/group-support-atp.php?ref=simpleuid");
		}

		// Token: 0x06000041 RID: 65 RVA: 0x0000221D File Offset: 0x0000041D
		private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://atpsoftware.vn?ref=simpleuid");
		}

		// Token: 0x06000044 RID: 68 RVA: 0x0000224F File Offset: 0x0000044F
		[CompilerGenerated]
		private void method_1()
		{
			this.status.Text = "Kết nối thất bại";
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000224F File Offset: 0x0000044F
		[CompilerGenerated]
		private void method_2()
		{
			this.status.Text = "Kết nối thất bại";
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00009188 File Offset: 0x00007388
		[CompilerGenerated]
		private void method_3()
		{
			FlatProgressBar flatProgressBar = this.process;
			int value = flatProgressBar.Value;
			flatProgressBar.Value = value + 1;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00009188 File Offset: 0x00007388
		[CompilerGenerated]
		private void method_4()
		{
			FlatProgressBar flatProgressBar = this.process;
			int value = flatProgressBar.Value;
			flatProgressBar.Value = value + 1;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00009188 File Offset: 0x00007388
		[CompilerGenerated]
		private void method_5()
		{
			FlatProgressBar flatProgressBar = this.process;
			int value = flatProgressBar.Value;
			flatProgressBar.Value = value + 1;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00009188 File Offset: 0x00007388
		[CompilerGenerated]
		private void method_6()
		{
			FlatProgressBar flatProgressBar = this.process;
			int value = flatProgressBar.Value;
			flatProgressBar.Value = value + 1;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00009188 File Offset: 0x00007388
		[CompilerGenerated]
		private void method_7()
		{
			FlatProgressBar flatProgressBar = this.process;
			int value = flatProgressBar.Value;
			flatProgressBar.Value = value + 1;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000224F File Offset: 0x0000044F
		[CompilerGenerated]
		private void method_8()
		{
			this.status.Text = "Kết nối thất bại";
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002261 File Offset: 0x00000461
		[CompilerGenerated]
		private void method_9()
		{
			this.status.Text = "Kết nối thất bại.";
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0000224F File Offset: 0x0000044F
		[CompilerGenerated]
		private void method_10()
		{
			this.status.Text = "Kết nối thất bại";
		}

		// Token: 0x0400000C RID: 12
		private string string_0 = "";

		// Token: 0x0400000D RID: 13
		private string string_1 = "";

		// Token: 0x0400000E RID: 14
		private string string_2 = "";

		// Token: 0x02000006 RID: 6
		[CompilerGenerated]
		private sealed class Class0
		{
			// Token: 0x0600004F RID: 79 RVA: 0x0000227B File Offset: 0x0000047B
			internal void method_0()
			{
				this.frm_Main_0.friendsofuid(this.string_0, this.frm_Main_0.data_friends);
			}

			// Token: 0x04000067 RID: 103
			public string string_0;

			// Token: 0x04000068 RID: 104
			public frm_Main frm_Main_0;
		}

		// Token: 0x02000007 RID: 7
		[CompilerGenerated]
		private sealed class Class1
		{
			// Token: 0x06000051 RID: 81 RVA: 0x000091AC File Offset: 0x000073AC
			internal void method_0()
			{
				this.frm_Main_0.status.Text = string.Concat(new object[]
				{
					"Quét thành công. (",
					this.string_0,
					"/",
					this.dataGridView_0.Rows.Count,
					")"
				});
			}

			// Token: 0x04000069 RID: 105
			public DataGridView dataGridView_0;

			// Token: 0x0400006A RID: 106
			public string string_0;

			// Token: 0x0400006B RID: 107
			public frm_Main frm_Main_0;

			// Token: 0x0400006C RID: 108
			public MethodInvoker methodInvoker_0;
		}

		// Token: 0x02000008 RID: 8
		[CompilerGenerated]
		private sealed class Class2
		{
			// Token: 0x06000053 RID: 83 RVA: 0x00009210 File Offset: 0x00007410
			internal void method_0()
			{
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

			// Token: 0x0400006D RID: 109
			public string string_0;

			// Token: 0x0400006E RID: 110
			public string string_1;

			// Token: 0x0400006F RID: 111
			public string string_2;

			// Token: 0x04000070 RID: 112
			public string string_3;

			// Token: 0x04000071 RID: 113
			public string string_4;

			// Token: 0x04000072 RID: 114
			public string string_5;

			// Token: 0x04000073 RID: 115
			public string string_6;

			// Token: 0x04000074 RID: 116
			public frm_Main.Class1 class1_0;
		}

		// Token: 0x02000009 RID: 9
		[CompilerGenerated]
		private sealed class Class3
		{
			// Token: 0x06000055 RID: 85 RVA: 0x00009298 File Offset: 0x00007498
			internal void method_0()
			{
				this.frm_Main_0.status.Text = string.Concat(new object[]
				{
					"Quét thành công. (",
					this.string_0,
					"/",
					this.dataGridView_0.Rows.Count,
					")"
				});
			}

			// Token: 0x04000075 RID: 117
			public DataGridView dataGridView_0;

			// Token: 0x04000076 RID: 118
			public string string_0;

			// Token: 0x04000077 RID: 119
			public frm_Main frm_Main_0;

			// Token: 0x04000078 RID: 120
			public MethodInvoker methodInvoker_0;
		}

		// Token: 0x0200000A RID: 10
		[CompilerGenerated]
		private sealed class Class4
		{
			// Token: 0x06000057 RID: 87 RVA: 0x000092FC File Offset: 0x000074FC
			internal void method_0()
			{
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

			// Token: 0x04000079 RID: 121
			public string string_0;

			// Token: 0x0400007A RID: 122
			public string string_1;

			// Token: 0x0400007B RID: 123
			public string string_2;

			// Token: 0x0400007C RID: 124
			public string string_3;

			// Token: 0x0400007D RID: 125
			public string string_4;

			// Token: 0x0400007E RID: 126
			public string string_5;

			// Token: 0x0400007F RID: 127
			public string string_6;

			// Token: 0x04000080 RID: 128
			public frm_Main.Class3 class3_0;
		}

		// Token: 0x0200000B RID: 11
		[CompilerGenerated]
		private sealed class Class5
		{
			// Token: 0x06000059 RID: 89 RVA: 0x00002299 File Offset: 0x00000499
			internal void method_0()
			{
				this.frm_Main_0.loc(this.string_0);
			}

			// Token: 0x04000081 RID: 129
			public string[] string_0;

			// Token: 0x04000082 RID: 130
			public frm_Main frm_Main_0;
		}

		// Token: 0x0200000C RID: 12
		[CompilerGenerated]
		private sealed class Class6
		{
			// Token: 0x0600005B RID: 91 RVA: 0x000022AC File Offset: 0x000004AC
			internal void method_0()
			{
				this.frm_Main_0.membersofgid(this.string_0, this.frm_Main_0.datamembers);
			}

			// Token: 0x04000083 RID: 131
			public string string_0;

			// Token: 0x04000084 RID: 132
			public frm_Main frm_Main_0;
		}

		// Token: 0x0200000D RID: 13
		[CompilerGenerated]
		private sealed class Class7
		{
			// Token: 0x0600005D RID: 93 RVA: 0x000022CA File Offset: 0x000004CA
			internal void method_0()
			{
				this.frm_Main_0.loc2(this.string_0);
			}

			// Token: 0x04000085 RID: 133
			public string[] string_0;

			// Token: 0x04000086 RID: 134
			public frm_Main frm_Main_0;
		}

		// Token: 0x0200000E RID: 14
		[CompilerGenerated]
		private sealed class Class8
		{
			// Token: 0x0600005F RID: 95 RVA: 0x000022DD File Offset: 0x000004DD
			internal void method_0()
			{
				this.frm_Main_0.getcmt(this.string_0, this.frm_Main_0.data_cmt);
			}

			// Token: 0x04000087 RID: 135
			public string string_0;

			// Token: 0x04000088 RID: 136
			public frm_Main frm_Main_0;
		}

		// Token: 0x0200000F RID: 15
		[CompilerGenerated]
		private sealed class Class9
		{
			// Token: 0x06000061 RID: 97 RVA: 0x00009384 File Offset: 0x00007584
			internal void method_0()
			{
				this.frm_Main_0.status.Text = string.Concat(new object[]
				{
					"Quét thành công. (",
					this.string_0,
					"/",
					this.dataGridView_0.Rows.Count,
					")"
				});
			}

			// Token: 0x04000089 RID: 137
			public DataGridView dataGridView_0;

			// Token: 0x0400008A RID: 138
			public string string_0;

			// Token: 0x0400008B RID: 139
			public frm_Main frm_Main_0;

			// Token: 0x0400008C RID: 140
			public MethodInvoker methodInvoker_0;
		}

		// Token: 0x02000010 RID: 16
		[CompilerGenerated]
		private sealed class Class10
		{
			// Token: 0x06000063 RID: 99 RVA: 0x000093E8 File Offset: 0x000075E8
			internal void method_0()
			{
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

			// Token: 0x0400008D RID: 141
			public string string_0;

			// Token: 0x0400008E RID: 142
			public string string_1;

			// Token: 0x0400008F RID: 143
			public string string_2;

			// Token: 0x04000090 RID: 144
			public string string_3;

			// Token: 0x04000091 RID: 145
			public string string_4;

			// Token: 0x04000092 RID: 146
			public string string_5;

			// Token: 0x04000093 RID: 147
			public string string_6;

			// Token: 0x04000094 RID: 148
			public string string_7;

			// Token: 0x04000095 RID: 149
			public frm_Main.Class9 class9_0;
		}

		// Token: 0x02000011 RID: 17
		[CompilerGenerated]
		private static class Class11
		{
			// Token: 0x04000096 RID: 150
			public static CallSite<Func<CallSite, object, object>> callSite_0;

			// Token: 0x04000097 RID: 151
			public static CallSite<Func<CallSite, object, string, object>> callSite_1;

			// Token: 0x04000098 RID: 152
			public static CallSite<Func<CallSite, object, string>> callSite_2;

			// Token: 0x04000099 RID: 153
			public static CallSite<Func<CallSite, object, string, object>> callSite_3;

			// Token: 0x0400009A RID: 154
			public static CallSite<Func<CallSite, object, string>> callSite_4;

			// Token: 0x0400009B RID: 155
			public static CallSite<Func<CallSite, object, string, object>> callSite_5;

			// Token: 0x0400009C RID: 156
			public static CallSite<Func<CallSite, object, string>> callSite_6;

			// Token: 0x0400009D RID: 157
			public static CallSite<Func<CallSite, object, string, object>> callSite_7;

			// Token: 0x0400009E RID: 158
			public static CallSite<Func<CallSite, object, string>> callSite_8;

			// Token: 0x0400009F RID: 159
			public static CallSite<Func<CallSite, object, string, object>> callSite_9;

			// Token: 0x040000A0 RID: 160
			public static CallSite<Func<CallSite, object, string>> callSite_10;

			// Token: 0x040000A1 RID: 161
			public static CallSite<Func<CallSite, object, string, object>> callSite_11;

			// Token: 0x040000A2 RID: 162
			public static CallSite<Func<CallSite, object, string>> callSite_12;

			// Token: 0x040000A3 RID: 163
			public static CallSite<Func<CallSite, object, string, object>> callSite_13;

			// Token: 0x040000A4 RID: 164
			public static CallSite<Func<CallSite, object, object, object>> callSite_14;

			// Token: 0x040000A5 RID: 165
			public static CallSite<Func<CallSite, object, bool>> callSite_15;

			// Token: 0x040000A6 RID: 166
			public static CallSite<Func<CallSite, object, string, object>> callSite_16;

			// Token: 0x040000A7 RID: 167
			public static CallSite<Func<CallSite, object, string, object>> callSite_17;

			// Token: 0x040000A8 RID: 168
			public static CallSite<Func<CallSite, object, string>> callSite_18;
		}

		// Token: 0x02000012 RID: 18
		[CompilerGenerated]
		private sealed class Class12
		{
			// Token: 0x06000065 RID: 101 RVA: 0x00009478 File Offset: 0x00007678
			internal void method_0()
			{
				this.frm_Main_0.status.Text = string.Concat(new object[]
				{
					"Quét thành công. (",
					this.string_0,
					"/",
					this.dataGridView_0.Rows.Count,
					")"
				});
			}

			// Token: 0x06000066 RID: 102 RVA: 0x000022FB File Offset: 0x000004FB
			internal void method_1()
			{
				this.frm_Main_0.status.Text = "Kết nối thất bại " + this.string_0;
			}

			// Token: 0x040000A9 RID: 169
			public DataGridView dataGridView_0;

			// Token: 0x040000AA RID: 170
			public string string_0;

			// Token: 0x040000AB RID: 171
			public frm_Main frm_Main_0;

			// Token: 0x040000AC RID: 172
			public MethodInvoker methodInvoker_0;
		}

		// Token: 0x02000013 RID: 19
		[CompilerGenerated]
		private sealed class Class13
		{
			// Token: 0x06000068 RID: 104 RVA: 0x000094DC File Offset: 0x000076DC
			internal void method_0()
			{
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

			// Token: 0x040000AD RID: 173
			public string string_0;

			// Token: 0x040000AE RID: 174
			public string string_1;

			// Token: 0x040000AF RID: 175
			public string string_2;

			// Token: 0x040000B0 RID: 176
			public string string_3;

			// Token: 0x040000B1 RID: 177
			public string string_4;

			// Token: 0x040000B2 RID: 178
			public string string_5;

			// Token: 0x040000B3 RID: 179
			public string string_6;

			// Token: 0x040000B4 RID: 180
			public frm_Main.Class12 class12_0;
		}

		// Token: 0x02000014 RID: 20
		[CompilerGenerated]
		private sealed class Class14
		{
			// Token: 0x0600006A RID: 106 RVA: 0x0000231D File Offset: 0x0000051D
			internal void method_0()
			{
				this.frm_Main_0.loc3(this.string_0);
			}

			// Token: 0x040000B5 RID: 181
			public string[] string_0;

			// Token: 0x040000B6 RID: 182
			public frm_Main frm_Main_0;
		}

		// Token: 0x02000015 RID: 21
		[CompilerGenerated]
		private sealed class Class15
		{
			// Token: 0x0600006C RID: 108 RVA: 0x00002330 File Offset: 0x00000530
			internal void method_0()
			{
				this.frm_Main_0.loc4(this.string_0);
			}

			// Token: 0x040000B7 RID: 183
			public string[] string_0;

			// Token: 0x040000B8 RID: 184
			public frm_Main frm_Main_0;
		}

		// Token: 0x02000016 RID: 22
		[CompilerGenerated]
		private sealed class Class16
		{
			// Token: 0x0600006E RID: 110 RVA: 0x00002343 File Offset: 0x00000543
			internal void method_0()
			{
				this.frm_Main_0.getlike(this.string_0, this.frm_Main_0.data_like);
			}

			// Token: 0x040000B9 RID: 185
			public string string_0;

			// Token: 0x040000BA RID: 186
			public frm_Main frm_Main_0;
		}

		// Token: 0x02000017 RID: 23
		[CompilerGenerated]
		private sealed class Class17
		{
			// Token: 0x06000070 RID: 112 RVA: 0x00002361 File Offset: 0x00000561
			internal void method_0()
			{
				this.frm_Main_0.getfeed(this.string_0, this.frm_Main_0.data_feed);
			}

			// Token: 0x040000BB RID: 187
			public string string_0;

			// Token: 0x040000BC RID: 188
			public frm_Main frm_Main_0;
		}

		// Token: 0x02000018 RID: 24
		[CompilerGenerated]
		private sealed class Class18
		{
			// Token: 0x06000072 RID: 114 RVA: 0x00009564 File Offset: 0x00007764
			internal void method_0()
			{
				this.frm_Main_0.status.Text = string.Concat(new object[]
				{
					"Quét thành công. (",
					this.string_0,
					"/",
					this.dataGridView_0.Rows.Count,
					")"
				});
			}

			// Token: 0x040000BD RID: 189
			public DataGridView dataGridView_0;

			// Token: 0x040000BE RID: 190
			public string string_0;

			// Token: 0x040000BF RID: 191
			public frm_Main frm_Main_0;

			// Token: 0x040000C0 RID: 192
			public MethodInvoker methodInvoker_0;
		}

		// Token: 0x02000019 RID: 25
		[CompilerGenerated]
		private sealed class Class19
		{
			// Token: 0x06000074 RID: 116 RVA: 0x000095C8 File Offset: 0x000077C8
			internal void method_0()
			{
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

			// Token: 0x040000C1 RID: 193
			public string string_0;

			// Token: 0x040000C2 RID: 194
			public string string_1;

			// Token: 0x040000C3 RID: 195
			public string string_2;

			// Token: 0x040000C4 RID: 196
			public string string_3;

			// Token: 0x040000C5 RID: 197
			public string string_4;

			// Token: 0x040000C6 RID: 198
			public frm_Main.Class18 class18_0;
		}

		// Token: 0x0200001A RID: 26
		[CompilerGenerated]
		private sealed class Class20
		{
			// Token: 0x06000076 RID: 118 RVA: 0x0000237F File Offset: 0x0000057F
			internal void method_0()
			{
				this.frm_Main_0.loc5(this.string_0);
			}

			// Token: 0x040000C7 RID: 199
			public string[] string_0;

			// Token: 0x040000C8 RID: 200
			public frm_Main frm_Main_0;
		}

		// Token: 0x0200001B RID: 27
		[CompilerGenerated]
		private sealed class Class21
		{
			// Token: 0x06000078 RID: 120 RVA: 0x00002392 File Offset: 0x00000592
			internal void method_0()
			{
				this.frm_Main_0.loc4(this.list_0.ToArray());
			}

			// Token: 0x040000C9 RID: 201
			public List<string> list_0;

			// Token: 0x040000CA RID: 202
			public frm_Main frm_Main_0;
		}

		// Token: 0x0200001C RID: 28
		[CompilerGenerated]
		private sealed class Class22
		{
			// Token: 0x0600007A RID: 122 RVA: 0x000023AA File Offset: 0x000005AA
			internal void method_0()
			{
				this.frm_Main_0.loc3(this.list_0.ToArray());
			}

			// Token: 0x040000CB RID: 203
			public List<string> list_0;

			// Token: 0x040000CC RID: 204
			public frm_Main frm_Main_0;
		}
	}
}

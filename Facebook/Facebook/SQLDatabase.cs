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
    }
    public class FbUID
    {
        //id, account, password, token, createdate
        public Guid id { get; set; }
        public string name { get; set; }
        public string uid { get; set; }
        public string urd { get; set; }
    }
    public class FbFriend {
        public Guid id { get; set; }
        public string uid { get; set; }
        public string name { get; set; }
        public string name_format { get; set; }
        public string mobile_phone { get; set; }
        public string birthday { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public string link { get; set; }
        public string locale { get; set; }

        public int offset_x { get; set; }
        public int offset_y { get; set; }

        public string source { get; set; }
        public string political { get; set; }
        public string quotes { get; set; }
        public string relationship_status { get; set; }
        public string religion { get; set; }
        public string short_name { get; set; }
        public int test_group { get; set; }
        public string third_party_id { get; set; }
        public string updated_time { get; set; }
        public string viewer_can_send_gift { get; set; }
        public string website { get; set; }
        public string can_review_measurement_request { get; set; }
        public string install_type { get; set; }
        public string installed { get; set; }
        public string is_verified { get; set; }
        public Guid FbAccountID { get; set; }
        public Guid FbUID { get; set; }
    }
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
    public class DmGroupUID {
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
    }

    public class CauHinh
    {
        public int sysLimitCallApi { get; set; }
        public int sysTimeSleep { get; set; }
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
                        InfoCOMMANDTABLE.sysLimitCallApi = reader.GetInt32(0);
                    if (!reader.IsDBNull(1))
                        InfoCOMMANDTABLE.sysTimeSleep = reader.GetInt32(1);

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
                //sysLimitCallApi, sysTimeSleep
                cmd.CommandText = "Update [CauHinh] Set sysLimitCallApi=@sysLimitCallApi, sysTimeSleep=@sysTimeSleep";
                                   
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@sysLimitCallApi", record.sysLimitCallApi);
                cmd.Parameters.AddWithValue("@sysTimeSleep", record.sysTimeSleep);

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
        public static List<FbFriend> LoadFbFriend(string sql)
        {
            SqlConnection cnn = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;
            FbFriend InfoCOMMANDTABLE;
            List<FbFriend> InfoCOMMANDTABLEs = null;

            try
            {
                InfoCOMMANDTABLEs = new List<FbFriend>();

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
                    InfoCOMMANDTABLE = new FbFriend();

                    if (!reader.IsDBNull(0))
                        InfoCOMMANDTABLE.id = reader.GetGuid(0);
                    if (!reader.IsDBNull(1))
                        InfoCOMMANDTABLE.uid = reader.GetString(1);
                    if (!reader.IsDBNull(2))
                        InfoCOMMANDTABLE.name = reader.GetString(2);
                    if (!reader.IsDBNull(3))
                        InfoCOMMANDTABLE.name_format = reader.GetString(3);
                    if (!reader.IsDBNull(4))
                        InfoCOMMANDTABLE.mobile_phone = reader.GetString(4);
                    if (!reader.IsDBNull(5))
                        InfoCOMMANDTABLE.birthday = reader.GetString(5);
                    if (!reader.IsDBNull(6))
                        InfoCOMMANDTABLE.email = reader.GetString(6);
                    if (!reader.IsDBNull(7))
                        InfoCOMMANDTABLE.gender = reader.GetString(7);
                    if (!reader.IsDBNull(8))
                        InfoCOMMANDTABLE.link = reader.GetString(8);
                    if (!reader.IsDBNull(9))
                        InfoCOMMANDTABLE.locale = reader.GetString(9);
                    if (!reader.IsDBNull(10))
                        InfoCOMMANDTABLE.offset_x = reader.GetInt32(10);
                    if (!reader.IsDBNull(11))
                        InfoCOMMANDTABLE.offset_y = reader.GetInt32(11);
                    if (!reader.IsDBNull(4))
                        InfoCOMMANDTABLE.source = reader.GetString(4);
                    if (!reader.IsDBNull(12))
                        InfoCOMMANDTABLE.political = reader.GetString(12);
                    if (!reader.IsDBNull(13))
                        InfoCOMMANDTABLE.quotes = reader.GetString(13);
                    if (!reader.IsDBNull(14))
                        InfoCOMMANDTABLE.relationship_status = reader.GetString(14);
                    if (!reader.IsDBNull(15))
                        InfoCOMMANDTABLE.religion = reader.GetString(15);
                    if (!reader.IsDBNull(16))
                        InfoCOMMANDTABLE.short_name = reader.GetString(16);
                    if (!reader.IsDBNull(17))
                        InfoCOMMANDTABLE.test_group = reader.GetInt32(17);
                    if (!reader.IsDBNull(18))
                        InfoCOMMANDTABLE.third_party_id = reader.GetString(18);
                    if (!reader.IsDBNull(19))
                        InfoCOMMANDTABLE.updated_time = reader.GetString(19);
                    if (!reader.IsDBNull(20))
                        InfoCOMMANDTABLE.viewer_can_send_gift = reader.GetString(20);
                    if (!reader.IsDBNull(21))
                        InfoCOMMANDTABLE.website = reader.GetString(21);
                    if (!reader.IsDBNull(22))
                        InfoCOMMANDTABLE.can_review_measurement_request = reader.GetString(22);
                    if (!reader.IsDBNull(23))
                        InfoCOMMANDTABLE.install_type = reader.GetString(23);
                    if (!reader.IsDBNull(24))
                        InfoCOMMANDTABLE.installed = reader.GetString(24);
                    if (!reader.IsDBNull(25))
                        InfoCOMMANDTABLE.is_verified = reader.GetString(25);
                    if (!reader.IsDBNull(26))
                        InfoCOMMANDTABLE.FbAccountID = reader.GetGuid(26);
                    if (!reader.IsDBNull(27))
                        InfoCOMMANDTABLE.FbUID = reader.GetGuid(27);
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
                
                cmd.CommandText = "Insert into dm_DialogColumn(uid, name, name_format, mobile_phone, birthday, email, gender, link, locale, offset_x, offset_y, source, political, quotes, relationship_status, religion, short_name, test_group, third_party_id, updated_time, viewer_can_send_gift, website, can_review_measurement_request, install_type, installed, is_verified, FbAccountID, FbUID)" +
                                    "values(@uid, @name, @name_format, @mobile_phone, @birthday, @email, @gender, @link, @locale, @offset_x, @offset_y, @source, @political, @quotes, @relationship_status, @religion, @short_name, @test_group, @third_party_id, @updated_time, @viewer_can_send_gift, @website, @can_review_measurement_request, @install_type, @installed, @is_verified, @FbAccountID, @FbUID);" +
                                    "Select SCOPE_IDENTITY();";

                //id, uid, name, name_format, mobile_phone, birthday, email, gender, link, locale, offset_x, offset_y, source, 
                //political, quotes, relationship_status, religion, short_name, test_group, third_party_id, updated_time, viewer_can_send_gift, website,
                //can_review_measurement_request, install_type, installed, is_verified, FbAccountID, FbUID, createdate

                cmd.Parameters.AddWithValue("@uid", record.uid);
                cmd.Parameters.AddWithValue("@name", record.name);
                cmd.Parameters.AddWithValue("@name_format", record.name_format);
                cmd.Parameters.AddWithValue("@mobile_phone", record.mobile_phone);
                cmd.Parameters.AddWithValue("@birthday", record.birthday);
                cmd.Parameters.AddWithValue("@email", record.email);
                cmd.Parameters.AddWithValue("@gender", record.gender);
                cmd.Parameters.AddWithValue("@link", record.link);
                cmd.Parameters.AddWithValue("@locale", record.locale);
                cmd.Parameters.AddWithValue("@offset_x", record.offset_x);
                cmd.Parameters.AddWithValue("@offset_y", record.offset_y);
                cmd.Parameters.AddWithValue("@source", record.source);
                cmd.Parameters.AddWithValue("@political", record.political);
                cmd.Parameters.AddWithValue("@quotes", record.quotes);
                cmd.Parameters.AddWithValue("@relationship_status", record.relationship_status);
                cmd.Parameters.AddWithValue("@religion", record.religion);
                cmd.Parameters.AddWithValue("@short_name", record.short_name);
                cmd.Parameters.AddWithValue("@test_group", record.test_group);
                cmd.Parameters.AddWithValue("@third_party_id", record.third_party_id);
                cmd.Parameters.AddWithValue("@updated_time", record.updated_time);
                cmd.Parameters.AddWithValue("@viewer_can_send_gift", record.viewer_can_send_gift);
                cmd.Parameters.AddWithValue("@website", record.website);
                cmd.Parameters.AddWithValue("@can_review_measurement_request", record.can_review_measurement_request);
                cmd.Parameters.AddWithValue("@install_type", record.install_type);
                cmd.Parameters.AddWithValue("@installed", record.installed);
                cmd.Parameters.AddWithValue("@is_verified", record.is_verified);
                cmd.Parameters.AddWithValue("@FbAccountID", record.FbAccountID);
                cmd.Parameters.AddWithValue("@FbUID", record.FbUID);
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

        #endregion

        #region FbUID

        public static List<FbUID> LoadFbUID(string sql)
        {
            SqlConnection cnn = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;
            FbUID InfoCOMMANDTABLE;
            List<FbUID> InfoCOMMANDTABLEs = null;

            try
            {
                InfoCOMMANDTABLEs = new List<FbUID>();

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
                    InfoCOMMANDTABLE = new FbUID();


                    if (!reader.IsDBNull(0))
                        InfoCOMMANDTABLE.id = reader.GetGuid(0);
                    if (!reader.IsDBNull(1))
                        InfoCOMMANDTABLE.name = reader.GetString(1);
                    if (!reader.IsDBNull(2))
                        InfoCOMMANDTABLE.uid = reader.GetString(2);
                    if (!reader.IsDBNull(3))
                        InfoCOMMANDTABLE.urd = reader.GetString(3);
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
                cmd.CommandText = "Insert into dm_DialogColumn(name,uid, urd)" +
                                    "values(@name,@uid, @urd);" +
                                    "Select SCOPE_IDENTITY();";
                cmd.Parameters.AddWithValue("@name", record.name);
                cmd.Parameters.AddWithValue("@uid", record.uid);
                cmd.Parameters.AddWithValue("@urd", record.urd);

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
                cmd.CommandText = "Update [FbUID] Set name=@name,uid=@uid, urd=@urd"
                                    + " where ID='" + record.id + "'";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@name", record.name);
                cmd.Parameters.AddWithValue("@uid", record.uid);
                cmd.Parameters.AddWithValue("@urd", record.urd);


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

        #region Nhom
        public static List<DmGroupUID> LoadDmGroupUID(string sql)
        {
            SqlConnection cnn = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;
            DmGroupUID InfoCOMMANDTABLE;
            List<DmGroupUID> InfoCOMMANDTABLEs = null;

            try
            {
                InfoCOMMANDTABLEs = new List<DmGroupUID>();

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
                    InfoCOMMANDTABLE = new DmGroupUID();
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
                throw ex;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
        }

        public static bool AddDmGroupUID(DmGroupUID record)
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
                cmd.CommandText = "Insert into DmGroupUID(ParentId, Name, UID, URD, Note, IsActi, OrderID) OUTPUT inserted.id " +
                                    "values(@ParentId, @Name, @UID, @URD, @Note, @IsActi, @OrderID);";
                                    

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
                return false;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
        }

        public static bool UpDmGroupUID(DmGroupUID record)
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
                cmd.CommandText = "Update [DmGroupUID] Set ParentId=@ParentId,Name=@Name, UID=@UID,URD=@URD,Note=@Note,IsActi=@IsActi,IsLoai=@IsLoai,OrderID=@OrderID"
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
                return false;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        public static bool UpDmGroupUIDByUid(DmGroupUID record)
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
                cmd.CommandText = "Update [dmNhom] Set Name=@Name, URD=@URD,Note=@Note,IsActi=@IsActi,IsPage=@IsPage,OrderID=@OrderID"
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
                return false;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        public static bool DelDmGroupUID(DmGroupUID recode)
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
                command.CommandText = "DELETE FROM DmGroupUID WHERE id ='" + recode.id + "'";

                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DelDmGroupUID");
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

using System;
using System.Collections.Generic;
using System.Linq;

namespace ASHK.SRTApp.Common
{
    public static class StaticAppHelper
    {
        public static Data.SQLServerHelper SQLServerHelper = new Data.SQLServerHelper();
        public static ASHK.Common.Data.Model.Perco.User PercoUser { get; set; } = null;
        public static Settings.AppSettings Settings { get; set; } = new Settings.AppSettings();
        public static LocalLog LocalLog { get; set; } = new LocalLog();
        public static bool IsCheckUpdate { get; set; } = false;
        public static bool IsUpdateAvailable { get; set; } = false;
        public static string PercoUserProc = "[dbo].[sp_STAFF_SelectByCard]";
        public static string ScanTire = "[dbo].[Выбрать_ПокрышкиПоШК]";
        public static string InsertWeigRawTiers = "[dbo].[Вставить_ВзвешиванияПокрышек]";
        public static string InsertWeig = "[dbo].[Вставить_Взвешивания]";
        public static string SelectRawTiers = "[dbo].[Выбрать_Покрышки]";
        public static string SelectWeighingTire = "[dbo].[Выбрать_ВзвешиванияПокрышек]";
        public static bool IsExit { get; set; } = false;

        public static void FinalizeApp()
        {
            StaticAppHelper.Settings.LoadFromDB();
            StaticAppHelper.Settings.SaveToFile(ASHK.Common.IO.Folders.SettingsFile());
        }

        public static void InitializeApp()
        {
            try
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("ru-RU");
            }
            catch (Exception ex)
            {
                Common.StaticAppHelper.LogWrite(ex);
                System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-EN");
            }
            StaticAppHelper.LocalLog.SQLConnection = SQLServerHelper.SqlConnection;
            StaticAppHelper.Settings.LoadFromFile(ASHK.Common.IO.Folders.SettingsFile());
            OpenConnect();
            StaticAppHelper.Settings.LoadFromDB();
            RefreshLogerSettings();
            CleanLogFiles();
        }

        public static void OpenConnect()
        {
            try
            {
                SQLServerHelper.SqlConnection.Open();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Common.StaticAppHelper.LogWrite(ex);
            }
            catch (Exception ex)
            {
                Common.StaticAppHelper.LogWrite(ex);
            }
        }

        public static void CloseConnect()
        {
            try
            {
                SQLServerHelper.SqlConnection.Close();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Common.StaticAppHelper.LogWrite(ex);
            }
            catch (Exception ex)
            {
                Common.StaticAppHelper.LogWrite(ex);
            }
        }

        #region "Logs"
        private static void CleanLogFiles()
        {
            string path = ASHK.Common.IO.Folders.AppLogsFolder();
            if (Settings.LogsSettings.CleanFile && Settings.LogsSettings.CleanFileCount > 0)
            {
                try
                {
                    var files = System.IO.Directory.GetFiles(path);
                    int fileCount = files.Count();
                    int cleanFileCount = Settings.LogsSettings.CleanFileCount;
                    if (fileCount > cleanFileCount)
                    {
                        int i;
                        var loopTo = fileCount - cleanFileCount;
                        for (i = 0; i <= loopTo; i++)
                        {
                            string str2 = files[i];
                            System.IO.File.Delete(str2);
                        }
                    }
                }
                catch (Exception exception1)
                {
                    Common.StaticAppHelper.LogWrite(exception1);
                }
            }
        }

        public static void RefreshLogerSettings()
        {
            StaticAppHelper.LocalLog.SaveFile = StaticAppHelper.Settings.LogsSettings.SaveFile;
            StaticAppHelper.LocalLog.SaveDB = StaticAppHelper.Settings.LogsSettings.SaveDB;
            StaticAppHelper.LocalLog.SaveEvent = StaticAppHelper.Settings.LogsSettings.SaveEvent;
            StaticAppHelper.LocalLog.CleanFile = StaticAppHelper.Settings.LogsSettings.CleanFile;
            StaticAppHelper.LocalLog.CleanFileCount = StaticAppHelper.Settings.LogsSettings.CleanFileCount;
        }
        public static void LogWrite(Exception ex)
        {
            string[] str = ex.StackTrace is null ? new string[] { "Нет значения" } : ex.StackTrace.Split('\n');
            Common.StaticAppHelper.LocalLog.Write(string.Format("Ошибка - {0}\r\nМесто ошибки - {1}", ex.Message, str[str.Length - 1]), ASHK.Common.Log.MessageType.Error);
        }
        public static void LogWrite(Exception ex, ASHK.Common.Log.MessageType messageType)
        {
            string[] str = ex.StackTrace is null ? new string[] { "Нет значения" } : ex.StackTrace.Split('\n');
            Common.StaticAppHelper.LocalLog.Write(string.Format("Ошибка - {0}\r\nМесто ошибки - {1}", ex.Message, str[str.Length - 1]), messageType);
        }
        #endregion
        #region "Запросы к БД"
        static public ASHK.Common.Data.Model.Perco.User GetPercoUserByCardIdentifier(int cardIdentifier)
        {
            ASHK.Common.Data.Model.Perco.User u = default;
            System.Data.SqlClient.SqlDataReader reader = null;
            try
            {
                reader = ASHK.Common.Data.SqlHelper.ExecuteReader(SQLServerHelper.SqlConnection, PercoUserProc, cardIdentifier);
                if (reader is object)
                {
                    if (reader.Read())
                    {
                        u = new ASHK.Common.Data.Model.Perco.User();
                        u.ID = (int)reader[0];
                        u.LastName = reader[1].ToString();
                        u.FirstName = reader[2].ToString();
                        u.MiddleName = reader[3].ToString();
                        u.TabelId = reader[4].ToString();
                        u.AccessDateBegin = DateTime.Parse(reader[7].ToString());
                        u.AccessDateEnd = DateTime.Parse(reader[8].ToString());
                        u.DateBegin = DateTime.Parse(reader[11].ToString());
                        u.Portret = (byte[])reader[12];
                        u.ShortFIO = reader[23].ToString();
                        u.CardId = (int)reader[25];
                        u.CardIdentifier = (long)reader[26];
                        u.CardDateBegin = DateTime.Parse(reader[27].ToString());
                        u.CardDateEnd = DateTime.Parse(reader[28].ToString());
                    }

                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Нет подключения к серверу!", "Ошибка", System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Error);
                Common.StaticAppHelper.LogWrite(ex);
            }
            catch (Exception ex)
            {
                Common.StaticAppHelper.LogWrite(ex);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
            return u;
        }
        static public Common.Model.RawTire GetRawTireByCode(string Code)
        {
            Common.Model.RawTire r = default;
            System.Data.SqlClient.SqlDataReader reader = null;
            try
            {
                reader = ASHK.Common.Data.SqlHelper.ExecuteReader(SQLServerHelper.SqlConnection.ConnectionString, ScanTire, Code);
                if (reader is object)
                {
                    if (reader.Read())
                    {
                        r = new Common.Model.RawTire(
                        new Guid(reader[0].ToString()),
                        reader[1].ToString(),
                        reader[2].ToString(),
                        float.Parse(reader[3].ToString()),
                        float.Parse(reader[4].ToString()),
                        float.Parse(reader[5].ToString()));

                    }

                }

            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Нет подключения к серверу!", "Ошибка", System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Error);
                Common.StaticAppHelper.LogWrite(ex);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Нет подключения к серверу!", "Ошибка", System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Error);
                Common.StaticAppHelper.LogWrite(ex);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
            return r;
        }
        static public List<Common.Model.RawTire> GetRawTire()
        {
            List<Common.Model.RawTire> r = new List<Common.Model.RawTire>();
            System.Data.SqlClient.SqlDataReader reader = null;
            try
            {
                reader = ASHK.Common.Data.SqlHelper.ExecuteReader(SQLServerHelper.SqlConnection.ConnectionString, SelectRawTiers);
                if (reader is object)
                {
                    while (reader.Read())
                    {
                        r.Add(new Common.Model.RawTire(
                        new Guid(reader[0].ToString()),
                        reader[1].ToString(),
                        reader[2].ToString(),
                        float.Parse(reader[3].ToString()),
                        float.Parse(reader[4].ToString()),
                        float.Parse(reader[5].ToString())));
                    }

                }

            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Нет подключения к серверу!", "Ошибка", System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Error);
                Common.StaticAppHelper.LogWrite(ex);
            }
            catch (Exception ex)
            {
                Common.StaticAppHelper.LogWrite(ex);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
            return r;
        }
        static public List<Common.Model.WeighingTire> GetWeighingTire()
        {
            List<Common.Model.WeighingTire> r = new List<Common.Model.WeighingTire>();
            System.Data.SqlClient.SqlDataReader reader = null;
            try
            {
                reader = ASHK.Common.Data.SqlHelper.ExecuteReader(SQLServerHelper.SqlConnection.ConnectionString, SelectWeighingTire);
                if (reader is object)
                {
                    while (reader.Read())
                    {
                        r.Add(new Common.Model.WeighingTire()
                        {
                            ID = (Int64)reader[0],
                            IDPercoUser = (int)reader[1],
                            IDTire = new Guid(reader[2].ToString()),
                            NameTire = reader[3].ToString(),
                            ShortName = reader[4].ToString(),
                            WeightNominal = float.Parse(reader[5].ToString()),
                            limitMax = float.Parse(reader[6].ToString()),
                            limitMin = float.Parse(reader[7].ToString()),
                            IDStatus = (int)reader[8],
                            Status = reader[9].ToString(),
                            Code = reader[10].ToString(),
                            Weight = float.Parse(reader[11].ToString()),
                            CreateData = (DateTime)reader[12],
                            FullFIO = reader[13].ToString()
                        });
                    }

                }

            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Нет подключения к серверу!", "Ошибка", System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Error);
                Common.StaticAppHelper.LogWrite(ex);
            }
            catch (Exception ex)
            {
                Common.StaticAppHelper.LogWrite(ex);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
            return r;
        }
        static public bool InsertWeighingRawTiers(Common.Model.RawTire rawTire, StateRawTire stateRawTire, Guid transactionWeighing, bool manually)
        {
            try
            {
                var stateQuery = ASHK.Common.Data.SqlHelper.ExecuteNonQuery(SQLServerHelper.SqlConnection.ConnectionString, InsertWeigRawTiers,
                                                                                                                                           rawTire.ID,
                                                                                                                                           stateRawTire,
                                                                                                                                           transactionWeighing,
                                                                                                                                           manually);
                if (stateQuery == 0)
                    return true;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Нет подключения к серверу!", "Ошибка", System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Error);
                Common.StaticAppHelper.LogWrite(ex);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Нет подключения к серверу!", "Ошибка", System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Error);
                Common.StaticAppHelper.LogWrite(ex);
            }
            return false;
        }

        static public Guid InsertWeighing(string code, float weight)
        {
            System.Data.SqlClient.SqlDataReader reader = null;
            try
            {
                reader = ASHK.Common.Data.SqlHelper.ExecuteReader(SQLServerHelper.SqlConnection.ConnectionString, InsertWeig,
                                                                                                                             PercoUser.ID,
                                                                                                                             code,
                                                                                                                             weight);
                if(reader.Read())
                {
                    return new Guid(reader[0].ToString());
                }
                
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Нет подключения к серверу!", "Ошибка", System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Error);
                Common.StaticAppHelper.LogWrite(ex);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Нет подключения к серверу!", "Ошибка", System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Error);
                Common.StaticAppHelper.LogWrite(ex);
            }
            return Guid.Empty;
        }
        #endregion        
    }
}

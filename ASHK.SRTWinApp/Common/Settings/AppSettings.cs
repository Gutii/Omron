using System;

namespace ASHK.SRTApp.Common.Settings
{
    public class AppSettings : ASHK.Common.Settings.ISettings
    {
        public ScalesSettings ScalesSettings { get; set; } = new ScalesSettings();
        public LogsSettings LogsSettings { get; set; } = new LogsSettings();
        public FontSizeSettings FontSizeSettings { get; set; } = new FontSizeSettings();
        public AplicationSettings AplicationSettings { get; set; } = new AplicationSettings();

        public string InsertSettingsBD = "[dbo].[Вставить_Настройки]";
        public string LoadSettingsBD = "[dbo].[Выбрать_Настройки]";
        public void LoadFromFile(string fileName)
        {
            try
            {
                var _iniFile = new ASHK.Common.INI.IniFile(fileName);
                #region "AplicationSettings"
                try
                {
                    this.AplicationSettings.LoadDB = bool.Parse(_iniFile.GetValue("AplicationSettings", "LoadDB"));
                }
                catch (Exception ex)
                {
                    Common.StaticAppHelper.LogWrite(ex);
                }
                try
                {
                    this.AplicationSettings.ClientName = _iniFile.GetValue("AplicationSettings", "ClientName").ToString();
                }
                catch (Exception ex)
                {
                    Common.StaticAppHelper.LogWrite(ex);
                }
                try
                {
                    this.AplicationSettings.EnableConnectDB = bool.Parse(_iniFile.GetValue("AplicationSettings", "EnableConnectDB"));
                }
                catch (Exception ex)
                {
                    Common.StaticAppHelper.LogWrite(ex);
                }
                try
                {
                    this.AplicationSettings.EnableSettings = bool.Parse(_iniFile.GetValue("AplicationSettings", "EnableSettings"));
                }
                catch (Exception ex)
                {
                    Common.StaticAppHelper.LogWrite(ex);
                }
                try
                {
                    this.AplicationSettings.AutoUpdate = bool.Parse(_iniFile.GetValue("AplicationSettings", "AutoUpdate"));
                }
                catch (Exception ex)
                {
                    Common.StaticAppHelper.LogWrite(ex);
                }
                try
                {
                    this.AplicationSettings.PathUpdate = _iniFile.GetValue("AplicationSettings", "PathUpdate").ToString();
                }
                catch (Exception ex)
                {
                    Common.StaticAppHelper.LogWrite(ex);
                }
                #endregion
                #region "LogsSettings"
                try
                {
                    this.LogsSettings.SaveFile = bool.Parse(_iniFile.GetValue("LogsSettings", "SaveFile"));
                }
                catch (Exception ex)
                {
                    Common.StaticAppHelper.LogWrite(ex);
                }

                try
                {

                    this.LogsSettings.CleanFile = bool.Parse(_iniFile.GetValue("LogsSettings", "CleanFile"));
                }
                catch (Exception ex)
                {
                    Common.StaticAppHelper.LogWrite(ex);
                }

                try
                {
                    this.LogsSettings.CleanFileCount = int.Parse(_iniFile.GetValue("LogsSettings", "CleanFileCount"));
                }
                catch (Exception ex)
                {
                    Common.StaticAppHelper.LogWrite(ex);
                }

                try
                {
                    this.LogsSettings.SaveDB = bool.Parse(_iniFile.GetValue("LogsSettings", "SaveDB"));
                }
                catch (Exception ex)
                {
                    Common.StaticAppHelper.LogWrite(ex);
                }

                try
                {
                    this.LogsSettings.SaveEvent = bool.Parse(_iniFile.GetValue("LogsSettings", "SaveEvent"));
                }
                catch (Exception ex)
                {
                    Common.StaticAppHelper.LogWrite(ex);
                }
                #endregion
                #region "ScalesSettings"
                try
                {
                    this.ScalesSettings.IP = _iniFile.GetValue("ScalesSettings", "IP");
                }
                catch (Exception ex)
                {
                    Common.StaticAppHelper.LogWrite(ex);
                }

                try
                {
                    this.ScalesSettings.Port = int.Parse(_iniFile.GetValue("ScalesSettings", "Port"));
                }
                catch (Exception ex)
                {
                    Common.StaticAppHelper.LogWrite(ex);
                }

                try
                {
                    this.ScalesSettings.Name = _iniFile.GetValue("ScalesSettings", "Name");
                }
                catch (Exception ex)
                {
                    Common.StaticAppHelper.LogWrite(ex);
                }
                #endregion
                #region "FontSizeSettings"
                try
                {
                    this.FontSizeSettings.MainLabelSettings = float.Parse(_iniFile.GetValue("FontSizeSettings", "MainLabelSettings"));
                }
                catch (Exception ex)
                {
                    Common.StaticAppHelper.LogWrite(ex);
                }
                try
                {
                    this.FontSizeSettings.GroupRawTireSettings = float.Parse(_iniFile.GetValue("FontSizeSettings", "GroupRawTireSettings"));
                }
                catch (Exception ex)
                {
                    Common.StaticAppHelper.LogWrite(ex);
                }
                #endregion
            }
            catch (Exception ex)
            {
                Common.StaticAppHelper.LogWrite(ex);

            }
        }
        public void SaveToFile(string fileName)
        {
            try
            {
                var _iniFile = new ASHK.Common.INI.IniFile(fileName);

                _iniFile.SetValue("AplicationSettings", "ClientName", this.AplicationSettings.ClientName.ToString());
                _iniFile.SetValue("AplicationSettings", "EnableConnectDB", this.AplicationSettings.EnableConnectDB.ToString());
                _iniFile.SetValue("AplicationSettings", "EnableSettings", this.AplicationSettings.EnableSettings.ToString());
                _iniFile.SetValue("AplicationSettings", "LoadDB", this.AplicationSettings.LoadDB.ToString());
                _iniFile.SetValue("AplicationSettings", "AutoUpdate", this.AplicationSettings.AutoUpdate.ToString());
                _iniFile.SetValue("AplicationSettings", "PathUpdate", this.AplicationSettings.PathUpdate.ToString());

                _iniFile.SetValue("LogsSettings", "SaveFile", this.LogsSettings.SaveFile.ToString());
                _iniFile.SetValue("LogsSettings", "CleanFile", this.LogsSettings.CleanFile.ToString());
                _iniFile.SetValue("LogsSettings", "CleanFileCount", this.LogsSettings.CleanFileCount.ToString());
                _iniFile.SetValue("LogsSettings", "SaveDB", this.LogsSettings.SaveDB.ToString());
                _iniFile.SetValue("LogsSettings", "SaveEvent", this.LogsSettings.SaveEvent.ToString());

                _iniFile.SetValue("ScalesSettings", "IP", this.ScalesSettings.IP);
                _iniFile.SetValue("ScalesSettings", "Port", this.ScalesSettings.Port.ToString());
                _iniFile.SetValue("ScalesSettings", "Name", this.ScalesSettings.Name);

                _iniFile.SetValue("FontSizeSettings", "GroupRawTireSettings", this.FontSizeSettings.GroupRawTireSettings.ToString());
                _iniFile.SetValue("FontSizeSettings", "MainLabelSettings", this.FontSizeSettings.MainLabelSettings.ToString());

                _iniFile.SaveFile();
            }
            catch (Exception ex)
            {
                Common.StaticAppHelper.LogWrite(ex);
            }
        }

        public void LoadFromDB()
        {
            if (this.AplicationSettings.ClientName.ToString().Trim() == "" & !this.AplicationSettings.LoadDB)
                return;
            System.Data.SqlClient.SqlDataReader reader = null;
            try
            {
                reader = ASHK.Common.Data.SqlHelper.ExecuteReader(Common.StaticAppHelper.SQLServerHelper.SqlConnection.ConnectionString, LoadSettingsBD, this.AplicationSettings.ClientName);
                if (reader is object)
                {
                    if (reader.Read())
                    {
                        #region "AplicationSettings"
                        Common.StaticAppHelper.Settings.AplicationSettings.ClientName = reader[0].ToString();
                        Common.StaticAppHelper.Settings.AplicationSettings.LoadDB = (bool)reader[1];
                        Common.StaticAppHelper.Settings.AplicationSettings.EnableSettings = (bool)reader[2];
                        Common.StaticAppHelper.Settings.AplicationSettings.EnableConnectDB = (bool)reader[3];
                        Common.StaticAppHelper.Settings.AplicationSettings.AutoUpdate = (bool)reader[14];
                        Common.StaticAppHelper.Settings.AplicationSettings.PathUpdate = reader[15].ToString();
                        #endregion
                        #region "ScalesSettings"
                        Common.StaticAppHelper.Settings.ScalesSettings.IP = reader[4].ToString();
                        Common.StaticAppHelper.Settings.ScalesSettings.Port = (int)reader[5];
                        Common.StaticAppHelper.Settings.ScalesSettings.Name = reader[6].ToString();
                        #endregion
                        #region "FontSizeSettings"
                        Common.StaticAppHelper.Settings.FontSizeSettings.MainLabelSettings = (int)reader[7];
                        Common.StaticAppHelper.Settings.FontSizeSettings.GroupRawTireSettings = (int)reader[8];
                        #endregion
                        #region "LogsSettings"
                        Common.StaticAppHelper.Settings.LogsSettings.SaveEvent = (bool)reader[9];
                        Common.StaticAppHelper.Settings.LogsSettings.SaveDB = (bool)reader[10];
                        Common.StaticAppHelper.Settings.LogsSettings.SaveFile = (bool)reader[11];
                        Common.StaticAppHelper.Settings.LogsSettings.CleanFile = (bool)reader[12];
                        Common.StaticAppHelper.Settings.LogsSettings.CleanFileCount = (int)reader[13];
                        #endregion

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

        }
        public void SaveToBD()
        {
            if (this.AplicationSettings.ClientName.ToString().Trim() == "" & !this.AplicationSettings.LoadDB)
                return;

            try
            {
                var stateQuery = ASHK.Common.Data.SqlHelper.ExecuteNonQuery(Common.StaticAppHelper.SQLServerHelper.SqlConnection.ConnectionString, InsertSettingsBD,
                                                                                                                                           this.AplicationSettings.ClientName.ToString(),
                                                                                                                                           this.AplicationSettings.LoadDB.ToString(),
                                                                                                                                           this.AplicationSettings.EnableSettings.ToString(),
                                                                                                                                           this.AplicationSettings.EnableConnectDB.ToString(),
                                                                                                                                           this.ScalesSettings.IP,
                                                                                                                                           this.ScalesSettings.Port.ToString(),
                                                                                                                                           this.ScalesSettings.Name,
                                                                                                                                           this.FontSizeSettings.MainLabelSettings.ToString(),
                                                                                                                                           this.FontSizeSettings.GroupRawTireSettings.ToString(),
                                                                                                                                           this.LogsSettings.SaveEvent.ToString(),
                                                                                                                                           this.LogsSettings.SaveDB.ToString(),
                                                                                                                                           this.LogsSettings.SaveFile.ToString(),
                                                                                                                                           this.LogsSettings.CleanFile.ToString(),
                                                                                                                                           this.LogsSettings.CleanFileCount.ToString(),
                                                                                                                                           this.AplicationSettings.AutoUpdate,
                                                                                                                                           this.AplicationSettings.PathUpdate);

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

    }
}

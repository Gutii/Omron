using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ASHK.SRTApp.Common.Data
{
    public class SQLServerHelper
    {
        public SqlConnection SqlConnection { get; private set; }

        public SQLServerHelper()
        {
            if (SqlConnection == null)
                SqlConnection = new SqlConnection();

            ASHK.Common.Data.DataLink.UdlHelper u = new ASHK.Common.Data.DataLink.UdlHelper();
            if (System.IO.File.Exists(u.FilePath))
            {
                this.SqlConnection.ConnectionString = u.ParseFile();
            }
            else if (MessageBox.Show("Настроить подключение к БД ?", "Подключение к БД", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.SqlConnection.ConnectionString = u.GetConnectionString();
            }
        }

        public void SettingConnect()
        {
            ASHK.Common.Data.DataLink.UdlHelper u = new ASHK.Common.Data.DataLink.UdlHelper();
            var result = MessageBox.Show("Настроить подключение к БД ?", "Подключение к БД", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Common.StaticAppHelper.CloseConnect();
                    this.SqlConnection.ConnectionString = u.GetConnectionString();
                    Common.StaticAppHelper.OpenConnect();
                }
                catch (System.Data.SqlClient.SqlException sqex)
                {
                    MessageBox.Show("Ошибка подключения к БД", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    Common.StaticAppHelper.LogWrite(sqex);
                }
                catch (Exception ex)
                {
                    Common.StaticAppHelper.LogWrite(ex);
                }
            }
        }


    }
}

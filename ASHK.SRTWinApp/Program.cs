using AutoUpdaterDotNET;
using System;
using System.IO;
using System.Windows.Forms;

namespace ASHK.SRTApp
{
    static class Program
    {
        private static Guid _proectGUID = Guid.Empty;

        public static Guid ProectGUID
        {
            get => _proectGUID;
            private set
            {
                var assembly = typeof(Program).Assembly;
                var attribute = (System.Runtime.InteropServices.GuidAttribute)assembly.GetCustomAttributes(typeof(System.Runtime.InteropServices.GuidAttribute), true)[0];
                _proectGUID = new Guid(attribute.Value);
                value = _proectGUID;
            }
        }
        private static FileStream UniqueInstanceStream = null;

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(App_ThreadingException);
            //AddHandler Application.Idle, New EventHandler(AddressOf App_Idle)
            //Application.ThreadExit += new EventHandler(App_ThreadExit);
            Application.ApplicationExit += new EventHandler(App_Exit);
            if (EnsureUniqueInstance())
            {
                Common.StaticAppHelper.InitializeApp();
                Common.StaticAppHelper.LocalLog.Write(string.Format("Начало работы программы"), ASHK.Common.Log.MessageType.Information);

                if (Common.StaticAppHelper.Settings.AplicationSettings.AutoUpdate && Common.StaticAppHelper.Settings.AplicationSettings.PathUpdate != string.Empty && !Common.StaticAppHelper.IsCheckUpdate)
                {
                    AutoUpdater.ApplicationExitEvent += AutoUpdater_ApplicationExitEvent;
                    AutoUpdater.CheckForUpdateEvent += AutoUpdater_CheckForUpdateEventHandler;
                    AutoUpdater.Mandatory = true;
                    AutoUpdater.UpdateMode = AutoUpdaterDotNET.Mode.Forced;
                    AutoUpdater.Start(Common.StaticAppHelper.Settings.AplicationSettings.PathUpdate);
                    Common.StaticAppHelper.IsCheckUpdate = true;
                }

                do
                {
                    if (Common.StaticAppHelper.PercoUser == null)
                        Application.Run(new Forms.User());

                    //Common.StaticAppHelper.PercoUser = Common.StaticAppHelper.GetPercoUserByCardIdentifier(int.Parse("0004419868"));
                    if (Common.StaticAppHelper.PercoUser != null)
                        Application.Run(new Forms.Main());

                }
                while (!Common.StaticAppHelper.IsExit);
                Common.StaticAppHelper.FinalizeApp();
            }

        }


        private static bool EnsureUniqueInstance()
        {
            //bool ret = false;
            string lockDir = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "UniqueInstanceApps");
            string lockPath = System.IO.Path.Combine(lockDir, ProectGUID + ".unique");
            System.IO.Directory.CreateDirectory(lockDir);
            try
            {
                UniqueInstanceStream = System.IO.File.Open(lockPath, FileMode.Create, FileAccess.Write, FileShare.None);
                UniqueInstanceStream.Write(new byte[] { 0 }, 0, 1);
                UniqueInstanceStream.Flush();
                return true;
            }
            catch
            {
                Common.StaticAppHelper.LocalLog.Write(string.Format("Копия программы уже запущена"), ASHK.Common.Log.MessageType.Information);
                return false;
            }

            //return ret;
        }

        [Obsolete]
        public static void App_ThreadExit(object sender, EventArgs e)
        {
            try
            {
                // StaticAppHelper.appLogger.Write(String.Format("Приложение закрыто"), MessageType.SystemAction)
                //StaticAppHelper.appLogger.Write(string.Format("Выход из потока id={0}", AppDomain.GetCurrentThreadId().ToString()), MessageType.SystemAction);
            }
            catch
            {
            }
            // System.Diagnostics.Debug.WriteLine("App_ThreadExit on thread id= " & System.AppDomain.GetCurrentThreadId().ToString())
        }
        public static void AutoUpdater_ApplicationExitEvent()
        {
            try
            {
                Common.StaticAppHelper.LocalLog.Write(string.Format("Обновлена программа"), ASHK.Common.Log.MessageType.Information);
                System.Threading.Thread.Sleep(5000);
                Common.StaticAppHelper.IsExit = true;
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void AutoUpdater_CheckForUpdateEventHandler(AutoUpdaterDotNET.EventArg.UpdateInfoEventArgs args)
        {
            Common.StaticAppHelper.IsCheckUpdate = true;
            Common.StaticAppHelper.IsUpdateAvailable = args.IsUpdateAvailable;
        }
        public static void App_Exit(object sender, EventArgs e)
        {
            try
            {
                Common.StaticAppHelper.LocalLog.Write(string.Format("Приложение закрыто" + " "+ Common.StaticAppHelper.IsExit.ToString()), ASHK.Common.Log.MessageType.Information);
            }
            catch
            {
            }
        }


        public static void App_ThreadingException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            try
            {
                Common.StaticAppHelper.LocalLog.Write(String.Format("App_ThreadException"), ASHK.Common.Log.MessageType.SystemAction);
                Common.StaticAppHelper.LocalLog.Write(string.Format("Ошибка приложения - {0}", e.Exception.Message), ASHK.Common.Log.MessageType.Error);
            }
            catch
            {
            }
            // System.Diagnostics.Debug.WriteLine("App_ThreadException")
            string msg = "Ошибка - " + e.Exception.Message + "\r\n" + "Продолжить работу приложения, чтобы сохранить данные?";
            DialogResult res = MessageBox.Show(msg, "Ошибка приложения", MessageBoxButtons.YesNo);
            if (res == System.Windows.Forms.DialogResult.Yes)
                return;
            else
            {
                Common.StaticAppHelper.IsExit = true;
                Application.Exit();
            }

        }

    }
}

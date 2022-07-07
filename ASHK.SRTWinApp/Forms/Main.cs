using AutoUpdaterDotNET;
using System;
using System.Threading;
using System.Windows.Forms;

namespace ASHK.SRTApp.Forms
{
    public partial class Main : DevExpress.XtraEditors.XtraForm
    {
        public Main()
        {
            InitializeComponent();
            accElemSettings.Enabled = Common.StaticAppHelper.Settings.AplicationSettings.EnableSettings;
            accElemConnectDB.Enabled = Common.StaticAppHelper.Settings.AplicationSettings.EnableConnectDB;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            var options = new DevExpress.XtraSplashScreen.OverlayWindowOptions(true, true, this.BackColor, this.ForeColor, 50);
            DevExpress.XtraSplashScreen.IOverlaySplashScreenHandle handle = DevExpress.XtraSplashScreen.SplashScreenManager.ShowOverlayForm(this, options);
            this.ribbonControl1.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            if (Common.StaticAppHelper.IsUpdateAvailable & Common.StaticAppHelper.IsCheckUpdate)
                flyoutPanel2.ShowPopup();
            if (Common.StaticAppHelper.PercoUser is null)
            {
                Exception ex = new Exception("Отсутствует Перко юзер, нет связи с БД или неверная БД");
                Common.StaticAppHelper.LogWrite(ex);

            }
            else
                this.Text = Text + " [" + Common.StaticAppHelper.PercoUser.FIO() + "]";
            try
            {
                OpenMainForm();
            }
            finally
            {
                handle.Close();
            }
        }


        private void OpenMainForm()
        {
            bool found = false;
            foreach (var frm in this.MdiChildren)
            {
                if (frm.Name == "Weighing")
                {
                    found = true;
                    frm.Select();
                    break;
                }
            }

            if (!found)
            {
                var f = new Forms.Weighing() { MdiParent = this };
                f.Show();
            }
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {

        }

        private void accSettings_Click(object sender, EventArgs e)
        {
            flyoutPanel1.ShowPopup();
        }

        private void accElemSettings_Click(object sender, EventArgs e)
        {
            Forms.FormSettings formSettings = new FormSettings();
            formSettings.Show();
        }

        private void accElemConnectDB_Click(object sender, EventArgs e)
        {
            Common.StaticAppHelper.SQLServerHelper.SettingConnect();
        }

        private void accFormScales_Click(object sender, EventArgs e)
        {
            OpenMainForm();
        }

        private void accExit_Click(object sender, EventArgs e)
        {
            Common.StaticAppHelper.IsExit = true;
            this.Close();
        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            bool found = false;
            foreach (var frm in this.MdiChildren)
            {
                if (frm.Name == "Журнал взвешиваний")
                {
                    found = true;
                    frm.Select();
                    break;
                }
            }

            if (!found)
            {
                var f = new Forms.BaseGrid(Common.Catalog.WeighingRawTires)
                {
                    MdiParent = this,
                    FormCaption = "Журнал взвешиваний",
                    FormMenuCaption = "Журнал взвешиваний",
                };
                f.Show();
            }
        }

        private void accRawTire_Click(object sender, EventArgs e)
        {
            bool found = false;
            foreach (var frm in this.MdiChildren)
            {
                if (frm.Name == "Сырые покрышки")
                {
                    found = true;
                    frm.Select();
                    break;
                }
            }

            if (!found)
            {
                var f = new Forms.BaseGrid(Common.Catalog.RawTires)
                {
                    MdiParent = this,
                    FormCaption = "Сырые покрышки",
                    FormMenuCaption = "Сырые покрышки",
                };
                f.Show();
            }
        }

        private void accInfo_Click(object sender, EventArgs e)
        {
            Forms.FormAbout formAbout = new Forms.FormAbout();
            formAbout.ShowDialog();
        }

        private void accReautoristion_Click(object sender, EventArgs e)
        {
            Common.StaticAppHelper.PercoUser = null;
            this.Close();
        }

        private void accordionControlElement2_Click_1(object sender, EventArgs e)
        {
            if (Common.StaticAppHelper.IsUpdateAvailable & Common.StaticAppHelper.IsCheckUpdate)
            {
                var res = System.Windows.Forms.MessageBox.Show("Вы уверены, что хотите обновить программу?", "Информация", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    Thread thread = new Thread(AutoUpdater.ShowUpdateForm);
                    thread.SetApartmentState(ApartmentState.STA);
                    thread.Start();
                }
            }
            else System.Windows.Forms.MessageBox.Show("Вы используете последнюю версию", "Информация", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
        }
    }
}

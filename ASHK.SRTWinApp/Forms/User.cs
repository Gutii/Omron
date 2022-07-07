using DevExpress.XtraSplashScreen;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ASHK.SRTApp.Forms
{
    public partial class User : Form
    {
        private ReadTechDataTimer ReadTechDataTimer;
        private ASHK.Common.Data.Model.Perco.User _percoUser = null;
        private int timeSet = 400;
        public ASHK.Common.Data.Model.Perco.User PercoUser
        {
            get
            {
                return this._percoUser;
            }

            set
            {
                this._percoUser = value;
                try
                {
                    if (value is null)
                    {
                        this.labelControl1.BringToFront();
                        this.PersonalNumber.Text = string.Empty;
                        this.LastName.Text = string.Empty;
                        this.FirstName.Text = string.Empty;
                        this.MiddleName.Text = string.Empty;
                        this.Date.Text = string.Empty;
                        this.PORTRET.Image = null;
                        this.barCodeControl1.Text = string.Empty;
                        this.simpleButton1.Enabled = false;
                        this.tablePanel1.Visible = false;
                        try
                        {
                            throw new Exception("Карта не действительна либо отсутствует в базе данных. Номер карты - " + ReadTechDataTimer.StrInput);
                        }
                        catch (Exception ex)
                        {
                            Common.StaticAppHelper.LogWrite(ex, ASHK.Common.Log.MessageType.Warning);
                            MessageBox.Show("Карта не действительна либо отсутствует в базе данных ." + "\r\n" + "Номер карты - " + ReadTechDataTimer.StrInput, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                    else
                    {
                        this.tablePanel1.BringToFront();
                        this.PersonalNumber.Text = value.TabelId.ToString();
                        this.FirstName.Text = value.FirstName;
                        this.LastName.Text = value.LastName;
                        this.MiddleName.Text = value.MiddleName;
                        this.Date.Text = value.DateBegin.ToString();
                        try
                        {
                            this.PORTRET.Image = Image.FromStream(new System.IO.MemoryStream(value.Portret));
                        }
                        catch (Exception ex)
                        {
                            int i = 0;
                        }

                        this.barCodeControl1.Text = value.ID.ToString();
                        this.simpleButton1.Enabled = true;
                        this.tablePanel1.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                    // log Common.StaticAppHelper.appLogger.Write(string.Format("Ошибка - {0}", ex.Message), MessageType.Error);
                }
            }
        }        
        public User()
        {
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e)
        {
            var options = new OverlayWindowOptions(true, true, this.BackColor, this.ForeColor, 50);
            IOverlaySplashScreenHandle handle = SplashScreenManager.ShowOverlayForm(this, options);
            try
            {
                ReadTechDataTimer = new ReadTechDataTimer(timeSet, InvokeSetUser);
                this.KeyPreview = true;
                this.simpleButton1.Enabled = false;
                this.labelControl1.BringToFront();
            }
            catch (Exception ex)
            {
                Common.StaticAppHelper.LogWrite(ex);
            }
            finally
            {
                handle.Close();
            }
        }

        public void InvokeSetUser(string str)
        {
            try
            {
                Action<string> action = SetUser;
                if (!this.IsDisposed)
                    this.Invoke(action, new object[] { str });
            }
            catch (Exception ex)
            {
                Common.StaticAppHelper.LogWrite(ex);
            }
        }
        private void User_KeyPress(object sender, KeyPressEventArgs e)
        {
            ReadTechDataTimer.StrInput += e.KeyChar.ToString();
            ReadTechDataTimer.ReastartTimer();
        }

        public void SetUser(string str)
        {
            if (str == string.Empty)
                return;

            var options = new OverlayWindowOptions(true, true, this.BackColor, this.ForeColor, 50);
            IOverlaySplashScreenHandle handle = SplashScreenManager.ShowOverlayForm(this, options);
            try
            {
                PercoUser = Common.StaticAppHelper.GetPercoUserByCardIdentifier(int.Parse(str));
                handle.Close();
                if (PercoUser != null)
                {
                    Common.StaticAppHelper.PercoUser = PercoUser;
                    System.Timers.Timer timer = new System.Timers.Timer() { Interval = 1250 };
                    timer.AutoReset = false;
                    timer.Elapsed += (ss, ee) =>
                    {
                        Action action = this.Close;
                        this.Invoke(action);
                    };
                    timer.Start();

                }
            }
            catch (System.Data.SqlClient.SqlException sqlExc)
            {
                Common.StaticAppHelper.LogWrite(sqlExc);
                MessageBox.Show(sqlExc.Message, "Ошибка БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exc)
            {
                Common.StaticAppHelper.LogWrite(exc);
                //MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                handle.Close();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (e != System.EventArgs.Empty)
            {
                Common.StaticAppHelper.IsExit = true;
                this.Close();
            }
        }

        private void User_FormClosed(object sender, FormClosedEventArgs e)
        {
            ReadTechDataTimer.Dispose();
        }
    }
}

using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ASHK.SRTApp.Forms
{
    public partial class Weighing : DevExpress.XtraEditors.XtraForm
    {
        private ReadTechDataTimer ReadTechDataTimer;
        private Common.WeighingHelper WeighingHelper;
        private int timeSet = 400;
        private string Code { get; set; } = null;
        private Common.Model.RawTire _rawTire = null;
        private Common.StateRawTire StateRawTire;
        private Common.Model.RawTire RawTire
        {
            get
            {
                return _rawTire;
            }
            set
            {
                this._rawTire = value;
                try
                {
                    if (value is null)
                    {
                        this.MainLabelContol.Visible = true;
                        this.MainLabelContol.BringToFront();
                        this.groupRawTire.Visible = false;
                        //WeighingHelper.Lights.StateLights(Common.StateWeighing.NotAllow);
                        this.ProductName.Text = string.Empty;
                        this.NominalWeight.Text = string.Empty;
                        this.ScalesWeight.Text = string.Empty;
                        this.splitTire.Visible = false;
                    }
                    else
                    {
                        if (System.Math.Round(value.WeightNominal - value.limitMin, 2) < WeighingHelper.Weigh.ScalesWeghing & System.Math.Round(value.WeightNominal + value.limitMax, 2) > WeighingHelper.Weigh.ScalesWeghing)
                        {
                            StateRawTire = Common.StateRawTire.Normal;
                            WeighingHelper.Lights.SetStateLights(Common.StateLights.Allow);
                        }
                        else
                        {
                            StateRawTire = Common.StateRawTire.Defect;
                            WeighingHelper.Lights.SetStateLights(Common.StateLights.NotAllow);
                        }


                        this.ProductName.Text = value.Name.ToString();

                        int kgw = (int)System.Math.Truncate((double)WeighingHelper.Weigh.ScalesWeghing);
                        int grammw = (int)(System.Math.Round(WeighingHelper.Weigh.ScalesWeghing - kgw, 2) * 100);
                        this.ScalesWeight.Text = kgw.ToString() + " кг " + grammw + " грамм";

                        int kgN = (int)System.Math.Truncate((double)value.WeightNominal);
                        int grammN = (int)(System.Math.Round(value.WeightNominal - kgN, 2) * 100);
                        this.NominalWeight.Text = kgN.ToString() + " кг " + grammN + " грамм";

                        int kgMax = (int)System.Math.Truncate((double)value.limitMax);
                        int grammMax = (int)(System.Math.Round(value.limitMax - kgMax, 2) * 100);
                        this.AllowedMax.Text = kgMax.ToString() + " кг " + grammMax + " грамм";

                        int kgMin = (int)System.Math.Truncate((double)value.limitMin);
                        int grammMin = (int)(System.Math.Round(value.limitMin - kgMin, 2) * 100);
                        this.AllowedMin.Text = kgMin.ToString() + " кг " + grammMin + " грамм";
                    }
                }
                catch (Exception ex)
                {
                    Common.StaticAppHelper.LogWrite(ex);
                }
            }
        }

        private Guid transactionWeighing = Guid.Empty;

        public Weighing()
        {
            InitializeComponent();            
        }
        #region "События формы"
        private void Weighing_Load(object sender, EventArgs e)
        {
            Common.Lights lights = new Common.Lights(panel2, panel3);
            WeighingHelper = new Common.WeighingHelper(this, MainLabelContol, groupRawTire, splitTire, lights);
            this.MainLabelContol.BringToFront();
            this.groupRawTire.Visible = false;
            this.splitTire.Visible = false;
            ReadTechDataTimer = new ReadTechDataTimer(timeSet, InvokeSetCode);            
            RefreshFont();
        }

        private void Weighing_KeyPress(object sender, KeyPressEventArgs e)
        {
            ReadTechDataTimer.StrInput += e.KeyChar.ToString();
            ReadTechDataTimer.ReastartTimer();
        }

        #endregion

        private Font newFount(Font font, float size)
        {
            return new Font(font.FontFamily, size, font.Style, font.Unit, font.GdiCharSet, font.GdiVerticalFont);
        }
        public void InvokeSetCode(string str)
        {
            try
            {
                Action<string> action = SetCode;
                if (!this.IsDisposed)
                    this.Invoke(action, new object[] { str });
            }
            catch (Exception ex)
            {
                Common.StaticAppHelper.LogWrite(ex);
            }
        }

        public void SetCode(string str)
        {
            var options = new DevExpress.XtraSplashScreen.OverlayWindowOptions(true, true, this.BackColor, this.ForeColor, 50);
            DevExpress.XtraSplashScreen.IOverlaySplashScreenHandle handle = DevExpress.XtraSplashScreen.SplashScreenManager.ShowOverlayForm(this, options);
            try
            {
                if (!IsSetCode(str))
                {
                    handle.Close();
                    return;
                }
                WeighingHelper.Weigh.ScalesWeghing = WeighingHelper.Weigh.ScalesWeghing / 1000;
                transactionWeighing = Common.StaticAppHelper.InsertWeighing(str, WeighingHelper.Weigh.ScalesWeghing);

                if(transactionWeighing == Guid.Empty)
                {
                    throw new Exception("Ошибка транзакции");
                }

                RawTire = Common.StaticAppHelper.GetRawTireByCode(str);
                if (RawTire != null)
                {
                    handle.Close();
                    WeighingHelper.Weigh.NextState();
                    Common.StaticAppHelper.InsertWeighingRawTiers(RawTire, StateRawTire, transactionWeighing, false);
                }
                else
                {
                    handle.Close();
                    DialogResult dialogResult = MessageBox.Show("Такоq штрих код не был найден в базе данных.\n Ввести покрышку вручную?", "Инфомрация", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(dialogResult == DialogResult.Yes)
                    {
                        gridRawTires.DataSource = Common.StaticAppHelper.GetRawTire();
                        gridView1.BestFitColumns();
                        WeighingHelper.Weigh.WaitSelectTire();
                    }
                }
            }
            catch (System.Data.SqlClient.SqlException sqlExc)
            {
                Common.StaticAppHelper.LogWrite(sqlExc);
            }
            catch (Exception exc)
            {
                Common.StaticAppHelper.LogWrite(exc);
            }
            finally
            {
                handle.Close();
            }
        }

        public void RefreshFont()
        {
            MainLabelContol.Font = newFount(MainLabelContol.Font, Common.StaticAppHelper.Settings.FontSizeSettings.MainLabelSettings);

            labelProductName.Font = newFount(labelProductName.Font, Common.StaticAppHelper.Settings.FontSizeSettings.GroupRawTireSettings);
            ProductName.Font = newFount(ProductName.Font, Common.StaticAppHelper.Settings.FontSizeSettings.GroupRawTireSettings);
            //labelProductNameShort.Font = newFount(labelProductNameShort.Font, Common.StaticAppHelper.Settings.FontSizeSettings.GroupRawTireSettings);
            //ProductNameShort.Font = newFount(ProductNameShort.Font, Common.StaticAppHelper.Settings.FontSizeSettings.GroupRawTireSettings);
            labelScalesWeight.Font = newFount(labelScalesWeight.Font, Common.StaticAppHelper.Settings.FontSizeSettings.GroupRawTireSettings);
            ScalesWeight.Font = newFount(ScalesWeight.Font, Common.StaticAppHelper.Settings.FontSizeSettings.GroupRawTireSettings);
            labelNominalWeight.Font = newFount(labelNominalWeight.Font, Common.StaticAppHelper.Settings.FontSizeSettings.GroupRawTireSettings);
            NominalWeight.Font = newFount(NominalWeight.Font, Common.StaticAppHelper.Settings.FontSizeSettings.GroupRawTireSettings);
            labelAllowedMax.Font = newFount(labelAllowedMax.Font, Common.StaticAppHelper.Settings.FontSizeSettings.GroupRawTireSettings);
            AllowedMax.Font = newFount(AllowedMax.Font, Common.StaticAppHelper.Settings.FontSizeSettings.GroupRawTireSettings);
            labelAllowedMin.Font = newFount(labelAllowedMin.Font, Common.StaticAppHelper.Settings.FontSizeSettings.GroupRawTireSettings);
            AllowedMin.Font = newFount(AllowedMin.Font, Common.StaticAppHelper.Settings.FontSizeSettings.GroupRawTireSettings);
        }

        private bool IsSetCode(string str)
        {
            if (!WeighingHelper.TimerState.Enabled)
            {
                WeighingHelper.StartTimer();
                System.Threading.Thread.Sleep(1200);
            }
            
            if(!WeighingHelper.Weigh.IsSetCode())
            {
                return false;
            }

            if (WeighingHelper.Weigh.ScalesWeghing == 0)
            {
                MessageBox.Show("Нет подключения к весам!", "Ошибка", System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Error);
                throw new Exception("Нет подключения к весам!");
            }

            return true;
        }

        private void Weighing_FormClosed(object sender, FormClosedEventArgs e)
        {
            WeighingHelper.Dispose();
            ReadTechDataTimer.Dispose();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            WeighingHelper.Weigh.CloseSelectTire();
            this.ActiveControl = null;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {            
            RawTire = (Common.Model.RawTire) gridView1.GetRow(gridView1.FocusedRowHandle);
            WeighingHelper.Weigh.NextState();
            Common.StaticAppHelper.InsertWeighingRawTiers(RawTire, StateRawTire, transactionWeighing, true);            
        }
        
    }
}

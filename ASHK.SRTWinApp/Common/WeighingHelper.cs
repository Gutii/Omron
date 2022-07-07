using System;
using System.Windows.Forms;

namespace ASHK.SRTApp.Common
{   

    public enum StateRawTire
    {
        Defect,
        Normal
    }

    class WeighingHelper : IDisposable
    {
        public Common.Lights Lights = null;
        public System.Timers.Timer TimerState { get; private set; } = null;
        private System.Timers.Timer TimerDiskonectScales { get; set; } = null;
        public StateForm.Weigh Weigh { get; set; } = null;
        private Forms.Weighing WeighingForm { get; set; } = null;
        public static ASHK.MassaK.MassaKScale MassaKScale { get; set; } = null;
        public WeighingHelper(Forms.Weighing weighingForm, DevExpress.XtraEditors.LabelControl labelState, DevExpress.XtraEditors.GroupControl groupControl, DevExpress.XtraEditors.SplitContainerControl splitTire, Lights lights)
        {
            try
            {
                Weigh = new StateForm.Weigh(new StateForm.Weighing(), weighingForm, labelState, groupControl, splitTire, lights);
                Lights = lights;
                WeighingForm = weighingForm;
                Lights.SetStateLights(StateLights.Default);
                try
                {
                    MassaKScale = new MassaK.MassaKScale(StaticAppHelper.Settings.ScalesSettings.IP, StaticAppHelper.Settings.ScalesSettings.Port, StaticAppHelper.Settings.ScalesSettings.Name);
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Нет подключения к весам!", "Ошибка", System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Error);
                    Common.StaticAppHelper.LogWrite(ex);
                    StartTimerDiskonect();
                }

                StartTimer();

            }
            catch (Exception ex)
            {
                Common.StaticAppHelper.LogWrite(ex);
            }
        }

        private void StartTimerDiskonect()
        {
            MassaKScale = null;
            if (TimerDiskonectScales != null)
                return;
            TimerDiskonectScales = new System.Timers.Timer() { Interval = 1000, AutoReset = false };
            TimerDiskonectScales.Elapsed += DisconectScales;
            TimerDiskonectScales.Start();
        }

        private void DisconectScales(object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                MassaKScale = new MassaK.MassaKScale(StaticAppHelper.Settings.ScalesSettings.IP, StaticAppHelper.Settings.ScalesSettings.Port, StaticAppHelper.Settings.ScalesSettings.Name);
                if (MassaKScale != null)
                {
                    TimerDiskonectScales.Stop();
                    TimerDiskonectScales.Dispose();
                    TimerDiskonectScales = null;
                    StartTimer();
                }
                else
                    TimerDiskonectScales.Start();
            }
            catch (Exception exept)
            {
                TimerDiskonectScales.Start();
            }
        }

        public void StartTimer()
        {
            TimerState = new System.Timers.Timer() { Interval = 1000, AutoReset = false };
            TimerState.Elapsed += (aa, ss) =>
            {
                try
                {

                    int? res = null;
                    if (MassaKScale == null)
                    {
                        StartTimerDiskonect();
                    }                        
                    else
                    {
                        res = (int?)WeighingForm.Invoke(MassaKScale.GetWeight);
                        //if (res is null)
                        //    res = 10000;
                    }                       

                    if (res is null)
                    {
                       Weigh.Weighing();
                    }
                    else
                    {
                        if(Weigh.State is Common.StateForm.Weighing)
                        {
                            Weigh.ScalesWeghing = (float)res;
                            Weigh.NextState();
                        }
                    }

                    if (TimerState != null)
                    {
                        TimerState.Start();
                    }                      

                }
                catch (Exception ex)
                {
                    Weigh.Weighing();
                    if (!WeighingForm.IsDisposed)
                        System.Windows.Forms.MessageBox.Show("Нет подключения к весам!", "Ошибка", System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Error);
                    Common.StaticAppHelper.LogWrite(ex);
                    StartTimerDiskonect();
                }
            };
            TimerState.Start();
        }
            
        public void Dispose()
        {
            if (TimerState != null)
            {
                TimerState.Stop();
                TimerState.Dispose();
            }
        }
    }
}

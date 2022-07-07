namespace ASHK.SRTApp.Common
{
    public enum StateLights
    {
        Default,
        Allow,
        NotAllow
    }


    public class Lights
    {
        public StateLights StateLightsSelect { get; private set; } = StateLights.Default;
        System.Windows.Forms.Panel Panel1 { get; set; } = null;
        System.Windows.Forms.Panel Panel2 { get; set; } = null;
        public Lights(System.Windows.Forms.Panel Panel1, System.Windows.Forms.Panel Panel2)
        {
            this.Panel1 = Panel1;
            this.Panel2 = Panel2;
        }
        /// <summary>
        ////Меняет цвет Panel от состояния
        /// </summary>
        /// <param name="stateWeighing"></param>
        public void SetStateLights(StateLights stateLights)
        {
            StateLightsSelect = stateLights;
            switch (StateLightsSelect)
            {
                case StateLights.Allow:
                    Panel1.BackColor = System.Drawing.Color.Lime;
                    Panel2.BackColor = System.Drawing.Color.Lime;
                    break;
                case StateLights.NotAllow:
                    Panel1.BackColor = System.Drawing.Color.Red;
                    Panel2.BackColor = System.Drawing.Color.Red;
                    break;
                case StateLights.Default:
                    Panel1.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
                    Panel2.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
                    break;
            }

        }

    }
}

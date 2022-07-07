using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASHK.SRTApp.Common.StateForm
{
    public class Weighing : IWeighState
    {
        string WeightNotSet = "Положите изделие на весы";
        

        public void Invoke(Weigh weigh)
        {
            if (!weigh.WeighingForm.IsDisposed)
            {
                Action labelStateAc = () => { weigh.LabelState.Text = WeightNotSet; weigh.LabelState.Visible = true; weigh.LabelState.BringToFront(); };
                Action splitTireAc = () => { weigh.SplitTire.Visible = false; };
                Action groupControlAc = () => { weigh.GroupControl.Visible = false; };
                weigh.GroupControl.Invoke(groupControlAc);
                weigh.SplitTire.Invoke(splitTireAc);
                weigh.LabelState.Invoke(labelStateAc);
                weigh.lights.SetStateLights(Common.StateLights.Default);
                weigh.ScalesWeghing = 0;
            }
        }

        public bool IsSetCode()
        {
            return false;
        }

        public void NextState(Weigh weigh)
        {
            weigh.State = new ScaningBarCode();
            weigh.Invoke();
        }

        void IWeighState.Weighing(Weigh weigh)
        {
            
        }
    }
}

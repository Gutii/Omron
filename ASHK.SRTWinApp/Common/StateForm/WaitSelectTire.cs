using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASHK.SRTApp.Common.StateForm
{
    public class WaitSelectTire : IWeighState
    {
        public void Invoke(Weigh weigh)
        {
            if (!weigh.WeighingForm.IsDisposed)
            {
                Action splitTireAc = () => { weigh.SplitTire.Visible = true; weigh.SplitTire.BringToFront(); };
                weigh.SplitTire.Invoke(splitTireAc);
                weigh.lights.SetStateLights(Common.StateLights.Default);
            }
        }

        public bool IsSetCode()
        {
            return false;
        }

        public void NextState(Weigh weigh)
        {
            weigh.State = new Result();
            weigh.Invoke();
        }

        public void Weighing(Weigh weigh)
        {
            weigh.State = new Weighing();
            weigh.Invoke();
        }
    }
}

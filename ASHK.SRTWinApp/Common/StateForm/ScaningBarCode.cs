using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASHK.SRTApp.Common.StateForm
{
    public class ScaningBarCode : IWeighState
    {
        string WeightRec = "Отсканируйте штрих код изделия";
        public void Invoke(Weigh weigh)
        {
            Action action = () => { weigh.LabelState.Text = WeightRec; };
            weigh.LabelState.Invoke(action);
        }

        public bool IsSetCode()
        {
            return true;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASHK.SRTApp.Common.StateForm
{
    public interface IWeighState
    {
        void Weighing(Weigh weigh);
        void NextState(Weigh weigh);
        bool IsSetCode();
        void Invoke(Weigh weigh);
    }
}

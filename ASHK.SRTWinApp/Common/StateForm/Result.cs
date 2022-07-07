using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASHK.SRTApp.Common.StateForm
{
    public class Result : IWeighState
    {
        public void Invoke(Weigh weigh)
        {
            Action labelStateAc = () => { weigh.LabelState.Visible = false; };
            Action splitTireAc = () => { weigh.SplitTire.Visible = false; };
            Action groupControlAc = () => { weigh.GroupControl.Visible = true; };
            weigh.GroupControl.Invoke(groupControlAc);
            weigh.SplitTire.Invoke(splitTireAc);
            weigh.LabelState.Invoke(labelStateAc);
        }

        public bool IsSetCode()
        {
            var dialogResult = MessageBox.Show("Вы уже записали это изделие. Отсканировать его снова?", "Инфомрация", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
                return false;

            return true;
        }

        public void NextState(Weigh weigh)
        {
            weigh.State = new Weighing();
            weigh.Invoke();
        }

        public void Weighing(Weigh weigh)
        {
            weigh.State = new Weighing();
            weigh.Invoke();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASHK.SRTApp.Common.StateForm
{
    public class Weigh
    {
        public IWeighState State { get; set; }
        public Forms.Weighing WeighingForm { get; private set; }
        public DevExpress.XtraEditors.LabelControl LabelState { get; private set; }
        public DevExpress.XtraEditors.GroupControl GroupControl { get; private set; }
        public DevExpress.XtraEditors.SplitContainerControl SplitTire { get; private set; }
        public Lights lights { get; private set; }
        public float ScalesWeghing { get; set; }

        public Weigh(IWeighState ws, Forms.Weighing weighingForm, DevExpress.XtraEditors.LabelControl labelState, DevExpress.XtraEditors.GroupControl groupControl, DevExpress.XtraEditors.SplitContainerControl splitTire, Lights lights)
        {
            WeighingForm = weighingForm;
            LabelState = labelState;
            GroupControl = groupControl;
            SplitTire = splitTire;
            this.lights = lights;
            State = ws;
        }

        public void Invoke()
        {
            State.Invoke(this);
        }

        public bool IsSetCode()
        {
           return State.IsSetCode();
        }

        public void Weighing()
        {
            if(!(State is WaitSelectTire))
                State.Weighing(this);
        }
        public void NextState()
        {
            State.NextState(this);
        }

        public void WaitSelectTire()
        {
            if(State is ScaningBarCode)
            {
                State = new WaitSelectTire();
                State.Invoke(this);
            }            
        }

        public void CloseSelectTire()
        {
            if (State is WaitSelectTire)
            {
                State = new Weighing();
                State.Invoke(this);
            }            
        }

    }
}

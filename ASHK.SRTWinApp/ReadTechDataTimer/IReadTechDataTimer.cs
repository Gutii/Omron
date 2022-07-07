using System.Timers;

namespace ASHK.SRTApp
{
    interface IReadTechDataTimer
    {
        Timer TimerInput { get; set; }
        int ReadTimeOut { get; set; }
        string StrInput { get; set; }
        void ReastartTimer();

    }
}

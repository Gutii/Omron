using System;
using System.Timers;

namespace ASHK.SRTApp
{
    class ReadTechDataTimer : IReadTechDataTimer, IDisposable
    {
        public Timer TimerInput { get; set; }
        public int ReadTimeOut { get; set; }
        public string StrInput { get; set; } = string.Empty;
        private Action<string> InvokeMethod { get; set; }
        /// <summary>
        /// Читает нажатые клавиши с клавиатуры до указанного времени
        /// </summary>
        /// <param name="readTimeOut">Количество милисекунд таймера</param>
        /// <param name="invokeMethod">Вызов метода формы, со строкой результата</param>
        public ReadTechDataTimer(int readTimeOut, Action<string> invokeMethod)
        {
            this.ReadTimeOut = readTimeOut;
            InvokeMethod = invokeMethod;
        }
        /// <summary>
        /// Пересоздает таймер если он не запущен
        /// </summary>
        public void ReastartTimer()
        {
            if (TimerInput == null || !TimerInput.Enabled)
            {
                TimerInput = new Timer() { Interval = ReadTimeOut };
                TimerInput.AutoReset = false;
                TimerInput.Elapsed += this.TimerInput_Tick;
                TimerInput.Start();
            }
        }

        private void TimerInput_Tick(object sender, EventArgs e)
        {
            TimerInput.Stop();
            StrInput = StrInput.Replace("\r", "");
            StrInput = StrInput.Replace("\n", "");
            InvokeMethod(StrInput);
            StrInput = string.Empty;
        }

        public void Dispose()
        {
            if (TimerInput != null)
            {
                TimerInput.Stop();
                TimerInput.Dispose();
            }
        }
    }
}

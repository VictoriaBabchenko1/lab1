using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace task1
{
    public delegate void TimerDelegate();

    class Timer
    {
        private TimerDelegate methodToCall;
        private int intervalInSeconds;

        public Timer(TimerDelegate method, int interval)
        {
            methodToCall = method;
            intervalInSeconds = interval;
        }

        public void Start()
        {
            while (true)
            {
                Thread.Sleep(intervalInSeconds * 1000);
                methodToCall();
            }
        }
    }
}

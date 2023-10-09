using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Threading;

namespace BumBum_Hrdy
{
    class Bomb
    {
        public int Countdown { get; private set; }
        public Action Detonation;

        private DispatcherTimer timer;
        
        public Bomb(int TimeToDetonate)
        {
            Countdown = TimeToDetonate;
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0,0,1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Countdown--;
            if(Countdown < 0)
            {
                Detonation?.Invoke();
            }
        }

    }
}

using Solution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockExercise
{
    internal class Clock
    {

        private int totalSecondes;
        public Clock(ITimerService timer) 
        {
            timer.Tick += this.onTick;
        }

        private void onTick()
        {
            totalSecondes++;
            NotifyS();
            NotifyM();
            NotifyH();
            NotifyD();
          
        }

        private void NotifyS()
        {
            SecondPassed?.Invoke(totalSecondes);

        }

        private void NotifyM()
        {
            if(totalSecondes % 60 == 0)
            {
                MinutePassed?.Invoke(totalSecondes / 60);
            }

        }

        private void NotifyH()
        {
            if(totalSecondes % (60 * 60) == 0)
            {
                HourPassed?.Invoke(totalSecondes / (60 * 60));
            }
        }

        private void NotifyD()
        {
            if(totalSecondes % ((60 * 60) * 24)  == 0)
            {
                DayPassed?.Invoke(totalSecondes / ((60*60)*24));
            }
        }


        public event Action<int> SecondPassed;
        public event Action<int> MinutePassed;
        public event Action<int> HourPassed;
        public event Action<int> DayPassed;
    }
}

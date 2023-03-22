using System;
using System.Collections.Generic;
using System.Text;

namespace TimeExercise
{
    internal class Time
    {

        public Time(int hours, int minutes, int seconds)
        {
            this.TotalSeconds = hours * 3600 + minutes * 60 + seconds;
        }

        public int TotalSeconds { get; }

        public int Seconds => TotalSeconds % 60;

        public int Minutes => (TotalSeconds / 60) % 60;

        public int Hours => TotalSeconds / 60 / 60;
    }
}

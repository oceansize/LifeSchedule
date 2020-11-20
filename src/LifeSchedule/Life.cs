using System;

namespace LifeSchedule
{
    public class Life
    {
        public Life(DateTime startDate)
        {
            StartDate = startDate;
        }

        public DateTime StartDate { get; }
    }
}
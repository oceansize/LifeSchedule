using System;

namespace LifeSchedule
{
    public class Life
    {
        public Life(DateTime startDate)
        {
            StartDate = startDate;
            EndDate = startDate.AddYears(90);
            WeeksOfLife = 90 * 52;
        }

        public DateTime StartDate { get; }
        public DateTime EndDate { get; }
        public int WeeksOfLife { get; }
    }
}
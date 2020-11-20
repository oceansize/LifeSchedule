using System;
using Xunit;

namespace LifeSchedule.UnitTests
{
    public class LifeShould
    {
        [Fact]
        public void HaveStartDate()
        {
            var birthday = new DateTime(1995, 03, 02);
            var life = new Life(birthday);

            Assert.Equal(life.StartDate, birthday);
        }

        [Fact]
        public void HaveEndDate()
        {
            var birthday = new DateTime(1995, 03, 02);
            var expiration = new DateTime(2085, 03, 02);
            var life = new Life(birthday);

            Assert.Equal(life.EndDate, expiration);
        }
    }
}
using System;
using Expedia;
using NUnit.Framework;

namespace ExpediaTest
{
	[TestFixture()]
	public class FlightTest
	{
		//TODO Task 7 items go here
        [Test()]
        public void TestThatFlightInitializes()
        {
            var target = new Flight(new DateTime(2005, 10, 20), new DateTime(2005, 10, 25), 200);
            Assert.IsNotNull(target);
        }

        [Test()]
        public void TestThatFlightHasCorrectBasePriceForOneDayStay()
        {
            var target = new Flight(new DateTime(2005, 10, 20), new DateTime(2005, 10, 21), 200);
            Assert.AreEqual(220, target.getBasePrice());
        }

        [Test()]
        public void TestThatFlightHasCorrectBasePriceForTwoDayStay()
        {
            var target = new Flight(new DateTime(2005, 10, 20), new DateTime(2005, 10, 22), 200);
            Assert.AreEqual(240, target.getBasePrice());
        }

        [Test()]
        public void TestThatFlightHasCorrectBasePriceForTenDayStay()
        {
            var target = new Flight(new DateTime(2005, 10, 20), new DateTime(2005, 10, 30), 200);
            Assert.AreEqual(400, target.getBasePrice());
        }

        [Test()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestThatFlightThrowsOnBadDates()
        {
            new Flight(new DateTime(2005, 10, 20), new DateTime(2005, 10, 15), 200);
        }

        [Test()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestThatFlightThrowsOnBadMiles()
        {
            new Flight(new DateTime(2005, 10, 20), new DateTime(2005, 10, 25), -200);
        }
        
	}
}

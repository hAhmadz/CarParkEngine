using System;
using CarParkEng;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class WeekendRatesTest
    {
        string EntryDate;
        string EntryTime;
        string ExitDate;
        string ExitTime;
        Carpark cp = new Carpark();
        DateTime currTime = DateTime.Now;

        /*
        * Entry Time - Saturday, 11:00AM 
        * Exit Time - Monday, 1:00AM
        * Expected Result - Not Weekend Rate
        */
        [TestMethod]
        public void NotWeekendRate_ExitAfterSunMidnight()
        {
            EntryDate = new DateTime(2019, 2, 2, 0, 0, 0).ToShortDateString();
            ExitDate = new DateTime(2019, 2, 4, 0, 0, 0).ToShortDateString();
            EntryTime = new DateTime(2019, 2, 2,11, 0, 0).TimeOfDay.ToString();
            ExitTime = new DateTime(2019, 2, 4, 1, 0, 0).TimeOfDay.ToString();
            string result = cp.CalculateCost(EntryDate, EntryTime, ExitDate, ExitTime);
            Assert.AreNotEqual("Weekend Rates", result.Split(':')[0]);
        }

        /*
        * Entry Time - Thursday, 11:00PM
        * Exit Time - Sunday, 11:00pm
        * Expected Result - Not Weekend Rate
        */
        [TestMethod]
        public void NotWeekendRate_EnterBeforeFriMidNight()
        {
            EntryDate = new DateTime(2019, 1, 31, 0, 0, 0).ToShortDateString();
            ExitDate = new DateTime(2019, 2, 3, 0, 0, 0).ToShortDateString();
            EntryTime = new DateTime(2019, 1, 31, 23, 0, 0).TimeOfDay.ToString();
            ExitTime = new DateTime(2019, 2, 3, 23, 0, 0).TimeOfDay.ToString();
            string result = cp.CalculateCost(EntryDate, EntryTime, ExitDate, ExitTime);
            Assert.AreNotEqual("Weekend Rates", result.Split(':')[0]);
        }

        /*
        * Entry Time - Saturday, 11:00AM
        * Exit Time - Sunday, 11:00pm
        * Expected Result - Weekend Rate
        */
        [TestMethod]
        public void IsWeekendRate()
        {
            EntryDate = new DateTime(2019, 2, 2, 0, 0, 0).ToShortDateString();
            ExitDate = new DateTime(2019, 2, 3, 0, 0, 0).ToShortDateString();
            EntryTime = new DateTime(2019, 2, 2, 11, 0, 0).TimeOfDay.ToString();
            ExitTime = new DateTime(2019, 2, 3, 23, 0, 0).TimeOfDay.ToString();
            string result = cp.CalculateCost(EntryDate, EntryTime, ExitDate, ExitTime);
            Assert.AreEqual("Weekend Rates", result.Split(':')[0]);
        }
    }
}

using System;
using CarParkEng;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class InvalidTimeTests
    {
        string EntryDate;
        string EntryTime;
        string ExitDate;
        string ExitTime;
        Carpark cp = new Carpark();
        DateTime currTime = DateTime.Now;

        /*
        * Entry Time - Current time + 2 hours
        * Exit Time - Current Time
        * Expected Result - Incorrect time entered.. 
        */

        [TestMethod]
        public void InvalidTime_EntryTimeHigherThanCurrentorExitTime()
        {
            EntryDate = currTime.ToShortDateString();
            ExitDate = currTime.ToShortDateString();
            EntryTime = currTime.AddHours(2.0).TimeOfDay.ToString();
            ExitTime = currTime.TimeOfDay.ToString();
            string result = cp.CalculateCost(EntryDate, EntryTime, ExitDate, ExitTime);
            Assert.AreEqual("Incorrect time entrered.", result);
        }

        /*
        * Entry Time - Current time
        * Exit Time - Current Time + 2
        * Expected Result - Incorrect time entered.. 
        */

        [TestMethod]
        public void InvalidTime_ExitTimeHigherThanCurrent()
        {
            EntryDate = currTime.ToShortDateString();
            ExitDate = currTime.ToShortDateString();
            EntryTime = currTime.TimeOfDay.ToString();
            ExitTime = currTime.AddHours(2.0).TimeOfDay.ToString();
            string result = cp.CalculateCost(EntryDate, EntryTime, ExitDate, ExitTime);
            Assert.AreEqual("Incorrect time entrered.", result);
        }

        /*
        * Entry DateTime - 18/8/2010 7:00pm
        * Exit DateTime -  18/8/2010 5:00pm
        * Expected Result - Night Rate .. 
        */

        [TestMethod]
        public void InvalidTime_ExitTimeLowerThanEnterTime()
        {
            EntryDate = new DateTime(2010, 8, 18, 0, 0, 0).ToShortDateString();
            ExitDate = new DateTime(2010, 8, 18, 0, 0, 0).ToShortDateString();
            EntryTime = new DateTime(2010, 8, 18, 19, 0, 0).TimeOfDay.ToString();
            ExitTime = new DateTime(2010, 8, 18, 17, 0, 0).TimeOfDay.ToString();
            string result = cp.CalculateCost(EntryDate, EntryTime, ExitDate, ExitTime);
            Assert.AreEqual("Incorrect time entrered.", result);
        }
    }
}

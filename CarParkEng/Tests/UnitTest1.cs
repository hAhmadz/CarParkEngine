using System;
using CarParkEng;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class NightRatesTest
    {
        string EntryDate;
        string EntryTime;
        string ExitDate;
        string ExitTime;
        Carpark cp = new Carpark();
        DateTime currTime = DateTime.Now;


        /******************************************************************************
                                    Invalid Time Tests
        /******************************************************************************

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

        /******************************************************************************
                                    Night Rate Tests
        /******************************************************************************

        /*
        * Entry DateTime - 18/8/2010 7:00pm
        * Exit DateTime - 18/8/2010 11:00pm
        * Expected Result - Night Rate .. 
        */

        [TestMethod]
        public void IsNightRate_SameNightLeave()
        {
            EntryDate = new DateTime(2010, 8, 18,0,0,0).ToShortDateString();
            ExitDate = new DateTime(2010, 8, 18, 0, 0, 0).ToShortDateString();
            EntryTime = new DateTime(2010, 8, 18,19,0,0).TimeOfDay.ToString(); 
            ExitTime = new DateTime(2010, 8, 18, 23, 0, 0).TimeOfDay.ToString();
            string result = cp.CalculateCost(EntryDate, EntryTime, ExitDate, ExitTime);
            Assert.AreEqual("Night Rates", result.Split(':')[0]);
        }

        /*
        * Entry DateTime - 18/8/2010 11:00pm
        * Exit DateTime - 19/8/2010 4:00am
        * Expected Result - Night Rate .. 
        */
        [TestMethod]
        public void IsNightRate_DiffNightLeave()
        {
            EntryDate = new DateTime(2010, 8, 18, 0, 0, 0).ToShortDateString();
            ExitDate = new DateTime(2010, 8, 19, 0, 0, 0).ToShortDateString();
            EntryTime = new DateTime(2010, 8, 18, 23, 0, 0).TimeOfDay.ToString();
            ExitTime = new DateTime(2010, 8, 19, 4, 0, 0).TimeOfDay.ToString();
            string result = cp.CalculateCost(EntryDate, EntryTime, ExitDate, ExitTime);
            Assert.AreEqual("Night Rates", result.Split(':')[0]); 
        }

        /******************************************************************************
                                    Early Bird Rate Tests
        /******************************************************************************
        /*
        * Entry DateTime - 18/8/2010 8:00am
        * Exit DateTime - 18/8/2010 8:30pm
        * Expected Result - Early Bird Rate.. 
        */

        [TestMethod]
        public void IsEarlyBirdRateTest()
        {
            EntryDate = new DateTime(2010, 8, 18, 0, 0, 0).ToShortDateString();
            ExitDate = new DateTime(2010, 8, 18, 0, 0, 0).ToShortDateString();
            EntryTime = new DateTime(2010, 8, 18, 8, 0, 0).TimeOfDay.ToString();
            ExitTime = new DateTime(2010, 8, 18, 20, 30, 0).TimeOfDay.ToString();
            string result = cp.CalculateCost(EntryDate, EntryTime, ExitDate, ExitTime);
            Assert.AreEqual("Early Bird Rates", result.Split(':')[0]);
        }


        /******************************************************************************
                                    Weekend Rate Tests
        /******************************************************************************/

        /*
        * Entry DateTime - 
        * Exit DateTime - 
        * Expected Result - 
        */

        /******************************************************************************
                                    Normal Rate Tests
        /******************************************************************************/
        /*
        * Entry DateTime - 
        * Exit DateTime - 
        * Expected Result - 
        */
    }
}

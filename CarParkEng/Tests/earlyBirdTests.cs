using System;
using CarParkEng;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class EarlyBirdTests
    {
        string EntryDate;
        string EntryTime;
        string ExitDate;
        string ExitTime;
        Carpark cp = new Carpark();
        DateTime currTime = DateTime.Now;

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

        /*
        * Entry DateTime - 18/8/2010 10:00am
        * Exit DateTime - 18/8/2010 8:30pm
        * Expected Result - Early Bird Rate.. 
        */

        [TestMethod]
        public void IsNotEarlyBird_EntryAfter9AM()
        {
            EntryDate = new DateTime(2010, 8, 18, 0, 0, 0).ToShortDateString();
            ExitDate = new DateTime(2010, 8, 18, 0, 0, 0).ToShortDateString();
            EntryTime = new DateTime(2010, 8, 18, 10, 0, 0).TimeOfDay.ToString();
            ExitTime = new DateTime(2010, 8, 18, 20, 30, 0).TimeOfDay.ToString();
            string result = cp.CalculateCost(EntryDate, EntryTime, ExitDate, ExitTime);
            Assert.AreNotEqual("Early Bird Rates", result.Split(':')[0]);
        }

        /*
        * Entry DateTime - 18/8/2010 5:00am
        * Exit DateTime - 18/8/2010 8:30pm
        * Expected Result - Early Bird Rate.. 
        */

        [TestMethod]
        public void IsNotEarlyBird_EntryBefore6AM()
        {
            EntryDate = new DateTime(2010, 8, 18, 0, 0, 0).ToShortDateString();
            ExitDate = new DateTime(2010, 8, 18, 0, 0, 0).ToShortDateString();
            EntryTime = new DateTime(2010, 8, 18, 5, 0, 0).TimeOfDay.ToString();
            ExitTime = new DateTime(2010, 8, 18, 20, 30, 0).TimeOfDay.ToString();
            string result = cp.CalculateCost(EntryDate, EntryTime, ExitDate, ExitTime);
            Assert.AreNotEqual("Early Bird Rates", result.Split(':')[0]);
        }

        /*
       * Entry DateTime - 18/8/2010 8:00am
       * Exit DateTime - 18/8/2010 11:45pm
       * Expected Result - Not Early Bird Rate.. 
       */

        [TestMethod]
        public void IsNotEarlyBird_ExitAfter1130PM()
        {
            EntryDate = new DateTime(2010, 8, 18, 0, 0, 0).ToShortDateString();
            ExitDate = new DateTime(2010, 8, 18, 0, 0, 0).ToShortDateString();
            EntryTime = new DateTime(2010, 8, 18, 8, 0, 0).TimeOfDay.ToString();
            ExitTime = new DateTime(2010, 8, 18, 23, 45, 0).TimeOfDay.ToString();
            string result = cp.CalculateCost(EntryDate, EntryTime, ExitDate, ExitTime);
            Assert.AreNotEqual("Early Bird Rates", result.Split(':')[0]);
        }

        /*
       * Entry DateTime - 18/8/2010 8:00am
       * Exit DateTime - 18/8/2010 1:00pm
       * Expected Result - Not Early Bird Rate.. 
       */

        [TestMethod]
        public void IsNotEarlyBird_exitBefore330PM()
        {
            EntryDate = new DateTime(2010, 8, 18, 0, 0, 0).ToShortDateString();
            ExitDate = new DateTime(2010, 8, 18, 0, 0, 0).ToShortDateString();
            EntryTime = new DateTime(2010, 8, 18, 8, 0, 0).TimeOfDay.ToString();
            ExitTime = new DateTime(2010, 8, 18, 13, 0, 0).TimeOfDay.ToString();
            string result = cp.CalculateCost(EntryDate, EntryTime, ExitDate, ExitTime);
            Assert.AreNotEqual("Early Bird Rates", result.Split(':')[0]);
        }
    }
}

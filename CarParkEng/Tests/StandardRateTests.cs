using System;
using CarParkEng;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class StandardRateTests
    {
        string EntryDate;
        string EntryTime;
        string ExitDate;
        string ExitTime;
        Carpark cp = new Carpark();
        DateTime currTime = DateTime.Now;

        /*
        * Entry DateTime - 3:00PM
        * Exit DateTime - 3:45PM
        * Expected Result - Hourly Rate: $5 
        */

        [TestMethod]
        public void IsHourlyRate_0to1Hr()
        {
            EntryDate = new DateTime(2010, 8, 18, 0, 0, 0).ToShortDateString();
            ExitDate = new DateTime(2010, 8, 18, 0, 0, 0).ToShortDateString();
            EntryTime = new DateTime(2010, 8, 18, 15, 0, 0).TimeOfDay.ToString();
            ExitTime = new DateTime(2010, 8, 18, 15, 45, 0).TimeOfDay.ToString();
            string result = cp.CalculateCost(EntryDate, EntryTime, ExitDate, ExitTime);
            Assert.AreEqual("Hourly Rate: $5",result);
        }

        /*
        * Entry DateTime - 3:00PM
        * Exit DateTime - 4:30PM
        * Expected Result - Hourly Rate: $10 
        */

        [TestMethod]
        public void IsHourlyRate_1to2Hr()
        {
            EntryDate = new DateTime(2010, 8, 18, 0, 0, 0).ToShortDateString();
            ExitDate = new DateTime(2010, 8, 18, 0, 0, 0).ToShortDateString();
            EntryTime = new DateTime(2010, 8, 18, 15, 0, 0).TimeOfDay.ToString();
            ExitTime = new DateTime(2010, 8, 18, 16, 30, 0).TimeOfDay.ToString();
            string result = cp.CalculateCost(EntryDate, EntryTime, ExitDate, ExitTime);
            Assert.AreEqual("Hourly Rate: $10", result);
        }

        /*
        * Entry DateTime - 3:00PM
        * Exit DateTime - 5:40PM
        * Expected Result - Hourly Rate: $15 
        */

        [TestMethod]
        public void IsHourlyRate_2to3Hr()
        {
            EntryDate = new DateTime(2010, 8, 18, 0, 0, 0).ToShortDateString();
            ExitDate = new DateTime(2010, 8, 18, 0, 0, 0).ToShortDateString();
            EntryTime = new DateTime(2010, 8, 18, 15, 0, 0).TimeOfDay.ToString();
            ExitTime = new DateTime(2010, 8, 18, 17, 40, 0).TimeOfDay.ToString();
            string result = cp.CalculateCost(EntryDate, EntryTime, ExitDate, ExitTime);
            Assert.AreEqual("Hourly Rate: $15", result);
        }

        /*
        * Entry DateTime - 3:00PM
        * Exit DateTime - 7:00PM
        * Expected Result - Hourly Rate: $20
        */

        [TestMethod]
        public void IsHourlyRateGreater3Hr()
        {
            EntryDate = new DateTime(2010, 8, 18, 0, 0, 0).ToShortDateString();
            ExitDate = new DateTime(2010, 8, 18, 0, 0, 0).ToShortDateString();
            EntryTime = new DateTime(2010, 8, 18, 15, 0, 0).TimeOfDay.ToString();
            ExitTime = new DateTime(2010, 8, 18, 19, 0, 0).TimeOfDay.ToString();
            string result = cp.CalculateCost(EntryDate, EntryTime, ExitDate, ExitTime);
            Assert.AreEqual("Hourly Rate: $20", result);
        }

        /*
        * Entry DateTime - 18/8/2010 3:00PM
        * Exit DateTime - 20/8/2010 3:00PM
        * Expected Result - Hourly Rate: $40
        */

        [TestMethod]
        public void IsHourlyRateGreater2Days()
        {
            EntryDate = new DateTime(2010, 8, 18, 0, 0, 0).ToShortDateString();
            ExitDate = new DateTime(2010, 8, 20, 0, 0, 0).ToShortDateString();
            EntryTime = new DateTime(2010, 8, 18, 15, 0, 0).TimeOfDay.ToString();
            ExitTime = new DateTime(2010, 8, 20, 15, 0, 0).TimeOfDay.ToString();
            string result = cp.CalculateCost(EntryDate, EntryTime, ExitDate, ExitTime);
            Assert.AreEqual("Hourly Rate: $40", result);
        }

        /*
        * Entry DateTime - 2/2/2019 3:00PM
        * Exit DateTime - 3/2/2019 3:00PM
        * Expected Result - Not Hourly Rate
        */

        [TestMethod]
        public void IsNotHourlyRate_Weekend()
        {
            EntryDate = new DateTime(2019, 2, 2, 0, 0, 0).ToShortDateString();
            ExitDate = new DateTime(2019, 2, 3, 0, 0, 0).ToShortDateString();
            EntryTime = new DateTime(2019, 2, 2, 15, 0, 0).TimeOfDay.ToString();
            ExitTime = new DateTime(2019, 2, 3, 15, 0, 0).TimeOfDay.ToString();
            string result = cp.CalculateCost(EntryDate, EntryTime, ExitDate, ExitTime);
            Assert.AreNotEqual("Hourly Rate", result.Split(':')[0]);
        }
    }
}

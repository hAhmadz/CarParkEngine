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
    }
}

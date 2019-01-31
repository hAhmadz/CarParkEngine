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
        [TestMethod]
        public void isNightRate_SameNight()
        {
            EntryDate = new DateTime(2010, 8, 18,0,0,0).ToShortDateString();
            EntryTime = new DateTime(2010, 8, 18,19,0,0).TimeOfDay.ToString(); //Random day but time focused
            ExitDate = new DateTime(2010, 8, 18,0,0,0).ToShortDateString();
            ExitTime = new DateTime(2010, 8, 18, 23, 0, 0).TimeOfDay.ToString();
            
            Carpark cp = new Carpark();
            string result = cp.CalculateCost(EntryDate, EntryTime, ExitDate, ExitTime);
            Assert.AreEqual("Night Rates", result.Split(':')[0]);
        }
        [TestMethod]
        public void isNightRate_DiffNight()
        {
            EntryDate = new DateTime(2010, 8, 18,0,0,0).ToShortDateString();
            EntryTime = new DateTime(2010, 8, 18, 23, 0, 0).TimeOfDay.ToString();
            ExitDate = new DateTime(2010, 9, 18,0,0,0).ToShortDateString();
            ExitTime = new DateTime(2010, 9, 18, 4, 0, 0).TimeOfDay.ToString();

            Carpark cp = new Carpark();
            string result = cp.CalculateCost(EntryDate, EntryTime, ExitDate, ExitTime);
            Assert.AreEqual("Night Rates", result.Split(':')[0]);
        }

    }
}

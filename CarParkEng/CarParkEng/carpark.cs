using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParkEng
{
    public class Carpark
    {
        private const double EarlyBirdRate = 13.00;
        private const double WeekendRate = 10.00;
        private const double NightRate = 6.50;
        private const double NormalRate = 5.00;

        public Carpark()
        {

        }
        private bool IsEarlyBirdRate(DateTime start, DateTime end)
        {
            decimal dayDiff = Convert.ToDecimal(end.Subtract(start).TotalDays);
            dayDiff = Math.Floor(dayDiff);
            if (dayDiff < 1)
            {
                DateTime entryStartRange = new DateTime(start.Year, start.Month, start.Day, 6, 0, 0);
                DateTime entryEndRange = new DateTime(start.Year, start.Month, start.Day, 9, 0, 0);
                DateTime exitStartRange = new DateTime(end.Year, end.Month, end.Day, 15, 30, 0);
                DateTime exitEndRange = new DateTime(end.Year, end.Month, end.Day, 23, 30, 0);

                if (start.TimeOfDay >= entryStartRange.TimeOfDay && start.TimeOfDay <= entryEndRange.TimeOfDay)
                    if (end.TimeOfDay >= exitStartRange.TimeOfDay && end.TimeOfDay <= exitEndRange.TimeOfDay)
                        return true;
            }

            return false;
        }
        private bool IsWeekendRate(DateTime start, DateTime end)
        {
            string startDayName = start.DayOfWeek.ToString();
            string endDayName = end.DayOfWeek.ToString();

            if (startDayName.Equals("Saturday") || startDayName.Equals("Sunday"))
                if (endDayName.Equals("Saturday") || endDayName.Equals("Sunday"))
                    return true;

            return false;
        }
        private bool IsNightRate(DateTime start, DateTime end)
        {
            DateTime entryStartRange = new DateTime(start.Year, start.Month, start.Day, 18, 0, 0);
            DateTime entryEndRange = new DateTime(start.Year, start.Month, start.Day, 23, 59, 59);
            DateTime exitRange = new DateTime(end.Year, end.Month, end.Day, 6, 0, 0);
            if (end.Day - start.Day == 0)
                exitRange = exitRange.AddDays(1);

            string startDayName = start.DayOfWeek.ToString();
            if (!(startDayName.Equals("Sunday") || startDayName.Equals("Saturday")))
                if (start.TimeOfDay >= entryStartRange.TimeOfDay && start.TimeOfDay <= entryEndRange.TimeOfDay)
                    if (end <= exitRange)
                        return true;

            return false;
        }

        private string IsNormalRate(DateTime start, DateTime end)
        {
            double output = 0.0;
            decimal timeDiff = Convert.ToDecimal(end.Subtract(start).TotalHours);
            timeDiff = Math.Ceiling(timeDiff);
            switch (timeDiff)
            {
                case 1:
                    output = NormalRate;
                    break;
                case 2:
                    output = NormalRate * 2;
                    break;
                case 3:
                    output = NormalRate * 3;
                    break;
                default:
                    double daydiff = Convert.ToDouble(Math.Ceiling(Convert.ToDecimal(end.Subtract(start).TotalDays)));
                    output = NormalRate * 4 * daydiff;
                    break;
            }
            return output.ToString();
        }

        public string CalculateCost(string entryDate, string entryTime, string exitDate, string exitTime)
        {
            string outputMsg = "";
            DateTime StartDT = DateTime.Parse(String.Format("{0} {1}", entryDate, entryTime));
            DateTime EndDT = DateTime.Parse(String.Format("{0} {1}", exitDate, exitTime));
            if (EndDT > StartDT)
            {
                if (IsWeekendRate(StartDT, EndDT))
                    outputMsg = $"Weekend Rates: ${WeekendRate.ToString()} ";
                else if (IsEarlyBirdRate(StartDT, EndDT))
                    outputMsg = $"Early Bird Rates: ${EarlyBirdRate.ToString()} ";
                else if (IsNightRate(StartDT, EndDT))
                    outputMsg = $"Night Rates: ${NightRate.ToString()} ";
                else
                    outputMsg = $"Hourly Rate: ${IsNormalRate(StartDT, EndDT)}";
            }
            else
                outputMsg = "Time not in format!";

            return outputMsg;
        }

    }
}

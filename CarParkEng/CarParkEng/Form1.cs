using System;
using System.Windows.Forms;

//************************************
/*
 *  Project: CarPark Project for TallyIT 
 *  Version 1.0
 *  Haaris Ahmad
 *  Date: 01/02/2019

 */
//************************************

namespace CarParkEng
{
    public partial class Form1 : Form
    {
        //**Constant Variables**
        public const double EarlyBirdRate = 13.00;
        public const double WeekendRate= 10.00;
        public const double NightRate = 6.50;
        public const double NormalRate = 5.00;

        public Form1()
        {
            InitializeComponent();
            InitializeCustoms();
        }

        void InitializeCustoms()
        {
            currDateLbl.Text = DateTime.Now.ToLongDateString();
        }

        private bool isEarlyBirdRate(DateTime start, DateTime end)
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
        private bool isWeekendRate(DateTime start, DateTime end)
        {
            string startDayName = start.DayOfWeek.ToString();
            string endDayName = end.DayOfWeek.ToString();

            if (startDayName.Equals("Saturday") || startDayName.Equals("Sunday"))
                if (endDayName.Equals("Saturday") || endDayName.Equals("Sunday"))
                    return true;

            return false;
        }
        private bool isNightRate(DateTime start, DateTime end)
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

        private string isNormalRate(DateTime start, DateTime end)
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

        private string calculateCost(string entryDate,string entryTime,string exitDate, string exitTime)
        {
            string outputMsg = "";
            DateTime StartDT = DateTime.Parse(String.Format("{0} {1}",entryDate , entryTime));
            DateTime EndDT = DateTime.Parse(String.Format("{0} {1}", exitDate, exitTime));
            if (EndDT > StartDT)
            {

                //Checking packages
                if (isWeekendRate(StartDT, EndDT))
                    outputMsg = $"Weekend Rates: ${WeekendRate.ToString()} ";
                else if (isEarlyBirdRate(StartDT, EndDT))
                    outputMsg = $"Early Bird Rates: ${EarlyBirdRate.ToString()} ";
                else if (isNightRate(StartDT, EndDT))
                    outputMsg = $"Night Rates: ${NightRate.ToString()} ";
                else
                    outputMsg = $"Hourly Rate: ${isNormalRate(StartDT, EndDT)}";
            }
            else
                MessageBox.Show("Entry time must occur before the exit time!");

            return outputMsg;
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            var EntryDate = Convert.ToDateTime(EntryDatePicker.Text).ToShortDateString();
            var EntryTime = Convert.ToDateTime(EntryTimePicker.Text).TimeOfDay.ToString();
            var ExitDate = Convert.ToDateTime(ExitDatePicker.Text).ToShortDateString();
            var ExitTime = Convert.ToDateTime(ExitTimePicker.Text).TimeOfDay.ToString();

            string result = calculateCost(EntryDate,EntryTime,ExitDate,ExitTime);
            outputLbl.Text = result;
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            outputLbl.Text = "";
        }
    }
}

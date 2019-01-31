using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarParkEng
{
    public partial class Form1 : Form
    {

        string extractedTime;
        public const double EarlyBirdRate = 13.00;
        public const double WeekendRate= 10.00;
        public const double NightRate = 6.50;


        public Form1()
        {
            InitializeComponent();
        }

        private bool isEarlyBirdRate(DateTime start, DateTime end)
        {
            DateTime entryStartRange = new DateTime(start.Year,start.Month,start.Day,6,0,0);
            DateTime entryEndRange = new DateTime(start.Year, start.Month, start.Day, 9, 0, 0);
            DateTime exitStartRange = new DateTime(end.Year, end.Month, end.Day, 15, 30, 0);
            DateTime exitEndRange = new DateTime(end.Year, end.Month, end.Day, 23, 30, 0);

            if (start.TimeOfDay >= entryStartRange.TimeOfDay && start.TimeOfDay <= entryEndRange.TimeOfDay)
                if(end.TimeOfDay >= exitStartRange.TimeOfDay && end.TimeOfDay <= exitEndRange.TimeOfDay)
                    return true;

            return false;
        }
        private bool isWeekendRate()
        {
            bool result = false;
            return result;
        }
        private bool isNightRate(DateTime start, DateTime end)
        {
            DateTime entryStartRange = new DateTime(start.Year, start.Month, start.Day, 18, 0, 0);
            DateTime entryEndRange = new DateTime(start.Year, start.Month, start.Day, 23, 59, 59);
            DateTime exitRange = new DateTime(end.Year, end.Month, end.Day, 6, 0, 0);
            string startDayName = start.DayOfWeek.ToString();
            if (!(startDayName.Equals("Sunday") || startDayName.Equals("Saturday")))
                if (start.TimeOfDay >= entryStartRange.TimeOfDay && start.TimeOfDay <= entryEndRange.TimeOfDay)
                    if (end.TimeOfDay <= exitRange.TimeOfDay)
                        return true;
            return false;
        }


        private string calculateCost(string entryDate,string entryTime,string exitDate, string exitTime)
        {
            string outputMsg = "";
            DateTime StartDT = DateTime.Parse(String.Format("{0} {1}",entryDate , entryTime));
            DateTime EndDT = DateTime.Parse(String.Format("{0} {1}", exitDate, exitTime));
            if (EndDT > StartDT)
            {
                //Checking packages
                if (entryDate.Equals(exitDate))
                {
                    if (isEarlyBirdRate(StartDT, EndDT))
                        outputMsg = $"Early Bird Rates: ${EarlyBirdRate.ToString()} ";
                }    
                else if (isNightRate(StartDT, EndDT))
                    outputMsg = $"Night Rates: ${NightRate.ToString()} ";

                /*
                else if ()      //Weekend Rate
                {

                }
                */

            }
            else
                outputMsg = "Entry time must occur before the exit time!";

            return outputMsg;
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            var EntryDate = Convert.ToDateTime(EntryDatePicker.Text).ToShortDateString();
            var EntryTime = Convert.ToDateTime(EntryTimePicker.Text).TimeOfDay.ToString();
            var ExitDate = Convert.ToDateTime(ExitDatePicker.Text).ToShortDateString();
            var ExitTime = Convert.ToDateTime(ExitTimePicker.Text).TimeOfDay.ToString();

            string result = calculateCost(EntryDate,EntryTime,ExitDate,ExitTime);
            pkgLbl.Visible = true;
            pkgLbl.Text = result;
            //pkgLbl.Text = result;
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            pkgLbl.Text = "";
            costOutput.Text = "";
        }
    }
}

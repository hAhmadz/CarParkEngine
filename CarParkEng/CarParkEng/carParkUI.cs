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
    public partial class MainForm : Form
    {
        Carpark cpark;
        public MainForm()
        {
            InitializeComponent();
            InitializeCustoms();
        }
        void InitializeCustoms()
        {
            currDateLbl.Text = DateTime.Now.ToLongDateString();
            DatePickerSetup();
            cpark = new Carpark();
        }

        void DatePickerSetup()
        {
            EntryDatePicker.Value = DateTime.Now;
            EntryDatePicker.MaxDate = DateTime.Now;
            ExitDatePicker.MaxDate = DateTime.Now;
            ExitDatePicker.Value = DateTime.Now;
        }
        
        private void calculateBtn_Click(object sender, EventArgs e)
        {
            DateTime currTime = DateTime.Now;
            var EntryDate = Convert.ToDateTime(EntryDatePicker.Text).ToShortDateString();
            var EntryTime = Convert.ToDateTime(EntryTimePicker.Text).TimeOfDay.ToString();
            var ExitDate = Convert.ToDateTime(ExitDatePicker.Text).ToShortDateString();
            var ExitTime = Convert.ToDateTime(ExitTimePicker.Text).TimeOfDay.ToString();

            string result = cpark.CalculateCost(EntryDate,EntryTime,ExitDate,ExitTime);
            outputLbl.Text = result;
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            outputLbl.Text = "";
        }

        private void EntryDatePicker_ValueChanged(object sender, EventArgs e)
        {
            ExitDatePicker.MinDate = EntryDatePicker.Value;
        }
    }
}

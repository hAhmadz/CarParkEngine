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
        DateTime EntryDate;
        DateTime EntryTime;
        DateTime ExitDate;
        DateTime ExitTime;
        string extractedTime;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void calculateBtn_Click(object sender, EventArgs e)
        {
            extractedTime = (DateTime.Parse(EntryDatePicker.Text)).ToShortTimeString();
            EntryDate = Convert.ToDateTime(extractedTime);
            EntryTime = DateTime.Parse(EntryTimePicker.Text);
            ExitDate = DateTime.Parse(ExitDatePicker.Text);
            ExitTime = DateTime.Parse(ExitTimePicker.Text);

            System.Diagnostics.Debug.WriteLine(extractedTime);
            System.Diagnostics.Debug.WriteLine(EntryDate);
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            pkgLbl.Text = "";
            costOutput.Text = "";
        }
    }
}

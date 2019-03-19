using Calendar.NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class demo : Form
    {
        public demo()
        {
            InitializeComponent();

            calendar1.CalendarDate = DateTime.Now;
            calendar1.CalendarView = Calendar.NET.CalendarViews.Month;

            var ce = new CustomEvent();
            ce.IgnoreTimeComponent = false;
            ce.EventText = "Interview";
            ce.Date = new DateTime(2019, 2, 5);
            ce.EventLengthInHours = 2f;
            ce.RecurringFrequency = RecurringFrequencies.None;
            ce.EventFont = new Font("Verdana", 12, FontStyle.Regular);
            ce.Enabled = true;
            calendar1.AddEvent(ce);
        }



        private void demo_Load(object sender, EventArgs e)
        {

        }

        
    }
}

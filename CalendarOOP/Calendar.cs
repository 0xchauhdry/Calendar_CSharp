using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarOOP
{
    public partial class Calendar : Form
    {
        public static int month, year;
        public Calendar()
        {
            InitializeComponent();
            DisplayDays();
            Holiday.addPredefinedHolidays();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            pnlDaysContainer.Controls.Clear();
            month--;
            if (month < 1)
            {
                year--;
                month = 12;
            }
            DisplayMonth();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            pnlDaysContainer.Controls.Clear();
            month++;
            if (month > 12)
            {
                year++;
                month = 1;
            }
            DisplayMonth();
        }

        private void DisplayDays()
        {
            newTimer.Tick += NewTimer_Tick;

            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            lblCurrentDate.Text = now.ToString("dddd, MMMM dd, yyyy");

            DisplayMonth();
        }

        private void NewTimer_Tick(object sender, EventArgs e)
        {
            lblCurrentTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        public void DisplayMonth()
        {
            myMonth date = new myMonth(month,year);

            lblMonthAndYear.Text = date.monthAndYear();

            for (int i = 1; i <= date.weekdays(date.firstDay()); i++)
            {
                myUserControl ucbutton = new myUserControl(true, i);
                pnlDaysContainer.Controls.Add(ucbutton);
            }

            for (int i = 1; i <= date.days(); i++)
            {
                myUserControl ucbutton = new myUserControl(false, i);
                var holidaydic = Holiday.holidayDictionary;
                if (holidaydic.ContainsKey(ucbutton.selectDate(i.ToString())))
                {
                    ucbutton.btnUC.BackColor = SystemColors.Info;
                }
                    pnlDaysContainer.Controls.Add(ucbutton);
            }
        }
    }
}

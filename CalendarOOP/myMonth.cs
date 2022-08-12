using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CalendarOOP
{
    class myMonth
    {
        public static int Month {get; set;}

        public static int Year { get; set; }

        public myMonth(int month, int year) 
        {
            Year = year;
            Month = month;
        }

        public string monthAndYear()
        {
            String displayMonth = DateTimeFormatInfo.CurrentInfo.GetMonthName(Month);
            string monthandyear = displayMonth + " " + Year;
            return monthandyear;
        }

        public DateTime firstDay ()
        {
            DateTime monthStart = new DateTime(Year, Month, 1);
            return monthStart;
        }

        public int days()
        {
            int noOfDays = DateTime.DaysInMonth(Year, Month);
            return noOfDays;
        }
        
        public int weekdays(DateTime dayOne)
        {
            int daysofweek = Convert.ToInt32(dayOne.DayOfWeek.ToString("d"));
            return daysofweek;
        }
    }
}

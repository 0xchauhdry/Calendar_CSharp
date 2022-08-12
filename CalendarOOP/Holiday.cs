using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarOOP
{
    class Holiday
    {
        public static string holidayDate = "12/8/2022";
        public static string holidayDescription = "No Holiday";

        public static IDictionary<string, string> holidayDictionary = new Dictionary<string, string>();

        public static void addPredefinedHolidays()
        {
            holidayDictionary.Add("5/2/2022", "Kashmir Day");
            holidayDictionary.Add("23/3/2022", "Pakistan Day");
            holidayDictionary.Add("14/8/2022", "Independance Day");
            holidayDictionary.Add("25/12/2022", "Christmas Day");
            holidayDictionary.Add("1/5/2022", "Labour Day");
            holidayDictionary.Add("9/11/2022", "Iqbal Day");
            holidayDictionary.Add("28/5/2022", "Day of Greatness");
            holidayDictionary.Add("6/9/2022", "Defense Day");
            holidayDictionary.Add("24/10/2022", "Azad Kashmir Day");
            holidayDictionary.Add("1/11/2022", "Gilgit-Baltistan Day");
            holidayDictionary.Add("8/7/2022", "Ashura");
            holidayDictionary.Add("9/7/2022", "Ashura");
            holidayDictionary.Add("10/6/2022", "Eid al-Adha");
            holidayDictionary.Add("2/5/2022", "Eid al-Fitr");
        }
        

        public Holiday()
        {

        }

        public static void UpdateHolidays()
        {
            holidayDictionary.Add(holidayDate, holidayDescription);
        }
    }
}

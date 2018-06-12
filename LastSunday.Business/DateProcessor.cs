using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace LastSunday.Business
{
    public class DateProcessor
    {
        public DateProcessor()
        {

        }

        public List<DateTime> GetLastSundayForEachMonth(int year)
        {
            var lastSundayDateForEachMonth = new List<DateTime>();
            var listOfallSundayDatesForMonth = new List<DateTime>();
            var lastDate = new DateTime(year, 12, 31);

            const DayOfWeek sunday = DayOfWeek.Sunday;
            var currentCulture = Thread.CurrentThread.CurrentCulture;


            for (var x = 1; x<= lastDate.Month; x++)
            {
                for (var i = 1; i <= currentCulture.Calendar.GetDaysInMonth(year, x); i++)
                {
                    var date = new DateTime(year, x, i);

                    if (IsEqualTo(sunday, date))
                    {
                        AddDateToAllSundayDatesOfTheMonth(listOfallSundayDatesForMonth, date);
                    }
                }

                AddDateToListOfsLastSundayDate(lastSundayDateForEachMonth, listOfallSundayDatesForMonth);
                listOfallSundayDatesForMonth = new List<DateTime>();
            }

            return lastSundayDateForEachMonth;
        }

        private static bool IsEqualTo(DayOfWeek sunday, DateTime date)
        {
                return date.DayOfWeek == sunday;
        }

        private static void AddDateToAllSundayDatesOfTheMonth(ICollection<DateTime> listOfallSundayDatesForMonth, DateTime date)
        {
            listOfallSundayDatesForMonth.Add(date);
        }

        private static void AddDateToListOfsLastSundayDate(ICollection<DateTime> lastSundayDateForEachMonth, IEnumerable<DateTime> allSundayDatesForMonth)
        {
            var lastSundayDate = allSundayDatesForMonth.Last();
            lastSundayDateForEachMonth.Add(lastSundayDate);
        }
    }
}
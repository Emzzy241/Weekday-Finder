using System;

namespace WeekdayFinder.Models
{
    public class MyWeekdayFinder
    {

        public MyWeekdayFinder()
        {
            
        }
        
        // The method to return the date
        public string DayOfWeekCalculator(string inputDate)
        {
            DateTime date = DateTime.Parse(inputDate);
            // Get the current day of the week and return it
            return date.DayOfWeek.ToString();
            
        }
    }


}
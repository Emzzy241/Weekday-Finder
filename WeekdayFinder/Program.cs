using System;
using WeekdayFinder.Models;

namespace WeekdayFinder.Models
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Weekday Finder Application");

            Console.WriteLine();
           
           try
           {
                Console.WriteLine("Enter a date in the format MM/DD/YYYY");
                string userDate = Console.ReadLine();
                
                MyWeekdayFinder newWeekdayFinder = new MyWeekdayFinder();

                string result = newWeekdayFinder.DayOfWeekCalculator(userDate);
                Console.WriteLine();
                Console.WriteLine("--------------------------------------");
                Console.WriteLine($"Your result is: {result}");
                Console.WriteLine("--------------------------------------");
                


           }
           catch
           {
             Console.WriteLine("Oops!!!, you did not enter in the correct date format of: MM/DD/YYYY");
             Console.WriteLine();
             Console.WriteLine("Give the app one more shot");
             Console.WriteLine();
             Console.WriteLine();
             Main();

           }

            
            
        }        
    }
}
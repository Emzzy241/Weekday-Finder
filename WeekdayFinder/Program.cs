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

                string dayOfWeek = newWeekdayFinder.DayOfWeekCalculator(userDate);
                Console.WriteLine();
                Console.WriteLine("--------------------------------------");
                DateTime date = DateTime.Parse(userDate);
                Console.WriteLine("The day of the week for " + date.ToShortDateString() + " is " + dayOfWeek);
                Console.WriteLine("--------------------------------------");
                
                Console.WriteLine();
                Console.WriteLine("To check another day of the week, enter 'Y', to exit app, enter 'N");
                string userResponse = Console.ReadLine().ToUpper();

                switch (userResponse)
                {
                    case "Y":
                        Console.WriteLine();
                        Console.WriteLine();
                        Main();
                        break;
                    
                    case "N":
                        Console.WriteLine();
                        Console.WriteLine("Bye Bye");
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Sorry, I did not get that, try again");
                        Main();
                        break;
                }
                


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
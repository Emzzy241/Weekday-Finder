using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeekdayFinder.Models;

namespace WeekdayFinder.Tests
{
    // bn=
    [TestClass]
    public class WeekdayFinderTests
    {
        

        // 1st Test: Testing the DayOfWeekCalculator() method
        [TestMethod]
        public void DayOfWeekCalculator_FindsDayOfWeek_String()
        {
            // Arrange
            string inputDate = "12/25/2023";
            string expecedDayOfWeek = "Monday";
            MyWeekdayFinder newWeekdayFinder = new MyWeekdayFinder();

            // Act
            string returnedDayOfWeek = newWeekdayFinder.DayOfWeekCalculator(inputDate);

            // Assert
            Assert.AreEqual(expecedDayOfWeek, returnedDayOfWeek);


        }
    }
}

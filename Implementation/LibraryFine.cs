using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        string currentDate = Console.ReadLine();
		string[] currentDateArray = currentDate.Split(' ');

		string expectedDate = Console.ReadLine();
		string[] expectedDateArray = expectedDate.Split(' ');


		string currentDay = currentDateArray[0].ToString();
		string currentMonth = currentDateArray[1].ToString();
		string currentYear = currentDateArray[2].ToString();


		string expectedDay = expectedDateArray[0].ToString();
		string expectedMonth = expectedDateArray[1].ToString();
		string expectedYear = expectedDateArray[2].ToString();


		if (currentDate == expectedDate)
		{
			Console.WriteLine("0");
		}
		else if (currentYear != expectedYear)
		{
			int currentYearInt = Convert.ToInt32(currentYear);
			int expectedYearInt = Convert.ToInt32(expectedYear);
			if (expectedYearInt > currentYearInt)
			{
				Console.WriteLine("0");
			}
			else
			{
				Console.WriteLine("10000");
			}
		}
		else if (currentYear == expectedYear && currentMonth != expectedMonth)
		{
			int currentMonthInt = Convert.ToInt32(currentMonth);
			int expectedMonthInt = Convert.ToInt32(expectedMonth);
			int differenceInMonths = currentMonthInt - expectedMonthInt;
			if (differenceInMonths > 0)
			{
				Console.WriteLine(differenceInMonths * 500);
			}
			else
			{
				Console.WriteLine("0");
			}
		}
		else if (currentYear == expectedYear && currentMonth == expectedMonth && currentDay != expectedDay)
		{
			int currentDayInt = Convert.ToInt32(currentDay);
			int expectedDayInt = Convert.ToInt32(expectedDay);
			int differenceInMonths = currentDayInt - expectedDayInt;
			if (differenceInMonths > 0)
			{
				Console.WriteLine(differenceInMonths * 15);
			}
			else
			{
				Console.WriteLine("0");
			}
		}
	}
}

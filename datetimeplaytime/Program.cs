using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace datetimeplaytime
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Console.WriteLine(DateTime.Now);
            //    DateTime CurrentDay = DateTime.Now;

            //    int week = (int)CurrentDay.DayOfWeek;

            //    string days = "";
            //    switch (week)
            //    {
            //        case 1:
            //            days = "Monday";
            //            break;

            //        case 2:
            //            days = "Tuesday";
            //            break;

            //        case 3:
            //            days = "Wednesday";
            //            break;

            //        case 4:
            //            days = "Thursday";
            //            break;

            //        case 5:
            //            days = "Friday";
            //            break;

            //        case 6:
            //            days = "Saturday";
            //            break;

            //        case 7:
            //            days = "Sunday";
            //            break;

            //        default:
            //            break;
            //    }
            //    Console.WriteLine("\nToday is " + days);



            //    DateTime Tomorrow = GetTomorrow();

            //    int future = (int)Tomorrow.DayOfWeek;

            //    string tom = "";
            //    switch (future)
            //    {
            //        case 1:
            //            tom = "Monday";
            //            break;

            //        case 2:
            //            tom = "Tuesday";
            //            break;

            //        case 3:
            //            tom = "Wednesday";
            //            break;

            //        case 4:
            //            tom = "Thursday";
            //            break;

            //        case 5:
            //            tom = "Friday";
            //            break;

            //        case 6:
            //            tom = "Saturday";
            //            break;

            //        case 7:
            //            tom = "Sunday";
            //            break;

            //        default:
            //            break;
            //    }
            //    Console.Write("\nTomorrow is " + tom);


            //    DateTime Yesterday = GetYesterday();

            //    int past = (int)Yesterday.DayOfWeek;

            //    string yest = "";
            //    switch (past)
            //    {
            //        case 1:
            //            yest = "Monday";
            //            break;

            //        case 2:
            //            yest = "Tuesday";
            //            break;

            //        case 3:
            //            yest = "Wednesday";
            //            break;

            //        case 4:
            //            yest = "Thursday";
            //            break;

            //        case 5:
            //            yest = "Friday";
            //            break;

            //        case 6:
            //            yest = "Saturday";
            //            break;

            //        case 7:
            //            yest = "Sunday";
            //            break;

            //        default:
            //            break;
            //    }
            //    Console.Write("\n\nYesterday was " + yest);
            //    Console.WriteLine("\n");
            //}

            //// METHODS 
            //static DateTime GetTomorrow()
            //{
            //    return DateTime.Now.AddDays(1);
            //}

            //static DateTime GetYesterday()
            //{
            //    return DateTime.Now.AddDays(-1);
            //}




            ////Span between 2 dates
            ////365 days in a year 
            ////December 22 = 355 days (-10)

            //DateTime startDate = new DateTime(2017, 01, 01);
            //DateTime bday = new DateTime(2017, 12, 22);

            //TimeSpan daysOf = bday - startDate;

            //int daysOfBday = daysOf.Days;

            //Console.WriteLine("My birthday is {0} of the year.", daysOfBday);



            ////Calulate age from birthday
            //Console.WriteLine("Enter your birth date MM/DD/YYYY");
            //DateTime birthDate = DateTime.Parse(Console.ReadLine());

            //DateTime today = DateTime.Today;
            //int age = today.Year - birthDate.Year;

            //if (birthDate > today.AddYears(-age)) age--;
            //    {
            //        Console.WriteLine("You're {0} years old.", age);
            //    } 


            //int Feb = 2;
            //int daysDec = DateTime.DaysInMonth(2017, Feb);
            //Console.WriteLine(daysDec);

            //Console.Write("Do you want to know how many days are in the month of 2017?");
            //Console.Write("\nPick a month in MMM format.\n");
            //DateTime month = DateTime.Parse(Console.ReadLine());


            int days = DateTime.DaysInMonth(2017, 12);
            Console.WriteLine(days);
        }      
        
    }
}

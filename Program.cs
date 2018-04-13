using System;

//All of the information provided indicates that the following are mandatory .NET classes,
    //but they will not work in Visual Studio when I try to run them. It states unnecessary
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


namespace Lab1Part2DateChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
           

            //Description of what we will compute
            Console.WriteLine("We will calculate the total differences between two dates.");

            //Request for user to input date
            Console.WriteLine("Enter First Date:(MM-DD-YYYY)");
            DateTime Date1 = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Enter Second Date:(MM-DD-YYYY)");
            DateTime Date2 = Convert.ToDateTime(Console.ReadLine());

            //Calculates the differences between the two dates
            TimeSpan span = Date1.Subtract(Date2);
            //If it is for a future date, calculations are negative
            //If it is for an older date, the calculations are positive

            //Provides the breakdown for the difference in seconds, minutes, hours, days and months
            Console.WriteLine("The difference in Days are " + span.TotalDays);
            Console.WriteLine("The difference in Hours are " + span.TotalHours);
            Console.WriteLine("The difference in Minutes are " + span.TotalMinutes);
                   
            
            //Provides the output in one line
            string output = string.Format("Total Difference: {0} days, {1} hours, {2} minutes", span.Days, span.TotalHours, span.TotalMinutes);
            Console.WriteLine(output);

            Console.ReadKey();
        }
    }
}

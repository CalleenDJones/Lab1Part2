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
        private static double year;

        static void Main(string[] args)
        {
           

            //Description of what we will compute
            Console.WriteLine("We will calculate the total differences between two dates.");

            //Request for user to input date
            Console.WriteLine("Enter First Date:(MM/DD/YYYY)");
            DateTime Date1 = Convert.ToDateTime(Console.ReadLine());
        
            Console.WriteLine("Enter Second Date:(MM-DD-YYYY)");
            DateTime Date2 = Convert.ToDateTime(Console.ReadLine());
          
            //Calculates the differences between the two dates
            TimeSpan span = Date1 - Date2;
            //If it is for a future date, calculations are negative
            //If it is for an older date, the calculations are positive
            //Need to resolve issue

            //Provides the breakdown for the difference in Years, Days, Hours and Minutes

            Console.WriteLine("The difference in Years are " + ((span.TotalDays) / 365));
            Console.WriteLine("The difference in Days are " + span.TotalDays);
            Console.WriteLine("The difference in Hours are " + span.TotalHours);
            Console.WriteLine("The difference in Minutes are " + span.TotalMinutes);
                   
            
            //Provides the output in one line
            string output = $"Total Difference: {((span.TotalDays) / 365)} years, {span.Days} days, {span.TotalHours} hours, {span.TotalMinutes} minutes";
            //The calculation for the year returns a decimal if the time span is less than 365 days.  I have made multiple attempts to correct it, but I am unable to resolve the issue.  
            //I have searched Slack and other forums.  Issue still needs to be resolved
            
            Console.WriteLine(output);

            Console.ReadKey();
        }
    }
}

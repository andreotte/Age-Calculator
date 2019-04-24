using System;

namespace lab2bonus
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Array to hold birthday in 'yyyy/mm/dd' format
            string[] date = new string[3];
            Console.WriteLine("Hello! I'm going calculate your age");

            // Get birthday from user.
            // TODO: write a method for this validation that takes user input as a param 
            while (true)
            try
            {
                Console.WriteLine("What year were you born in?");
                string year = Console.ReadLine();
                date[0] = year;
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Enter the year as an integer");
                continue;
            }

            while (true)
            try
            {
                Console.WriteLine("What month were you born in?");
                string month = Console.ReadLine();
                date[1] = month;
                break; 
            }
            catch (Exception)
            {
                Console.WriteLine("Enter the month as an integer");
                continue;
            }

            while (true)
            try
            {
                Console.WriteLine("What day were you born on?");
                string day = Console.ReadLine();
                date[2] = day;
                break;
            }
            catch (Exception)
            {
                Console.WriteLine("Enter the day as an integer");
                continue;
            }

            // Convert array holding birthday to DateTime datatype
            DateTime birthday = new DateTime(Convert.ToInt32(date[0]), Convert.ToInt32(date[1]), Convert.ToInt32(date[2]));

            int yearsOld = new DateTime(DateTime.Today.Subtract(birthday).Ticks).Year - 1;
            DateTime lastBirthday = birthday.AddYears(yearsOld);
            int daysSinceBirthday = DateTime.Today.Subtract(lastBirthday).Days; 
            double secondsOld = DateTime.Today.Subtract(birthday).TotalSeconds;

            // Display years and days old
            Console.WriteLine($"You are {yearsOld} years and {daysSinceBirthday} days old.");
            // Display seconds old
            Console.WriteLine($"You are {secondsOld} seconds old!");            
        }
    }
}

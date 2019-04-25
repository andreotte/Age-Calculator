using System;

namespace lab2bonus
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello! I'm going calculate your age");
            DateTime birthday = Birthday();

            int yearsOld = new DateTime(DateTime.Today.Subtract(birthday).Ticks).Year - 1;
            DateTime lastBirthday = birthday.AddYears(yearsOld);
            int daysSinceBirthday = DateTime.Today.Subtract(lastBirthday).Days;
            double secondsOld = DateTime.Today.Subtract(birthday).TotalSeconds;

            // Display years and days old
            Console.WriteLine($"You are {yearsOld} years and {daysSinceBirthday} days old.");
            // Display seconds old
            Console.WriteLine($"You are {secondsOld} seconds old!");
        }

        public static DateTime Birthday()
        {
            // Array to hold birthday in 'yyyy/mm/dd' format
            string[] date = new string[3];
            DateTime birthday;
        
            // Get birthday from user.
            Console.WriteLine("What year were you born in?");
            string year = Console.ReadLine();
            date[0] = year;

            Console.WriteLine("What month were you born in?");
            string month = Console.ReadLine();
            date[1] = month;

            Console.WriteLine("What day were you born on?");
            string day = Console.ReadLine();
            date[2] = day;

            // Check for valid user input
            try
            {
                birthday = new DateTime(Convert.ToInt32(date[0]), Convert.ToInt32(date[1]), Convert.ToInt32(date[2]));
                return birthday;
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input. Please enter dates as integers in format: year as yyyy, month as mm, and day as dd.");
                return Birthday();
            }            
        }
    }
}

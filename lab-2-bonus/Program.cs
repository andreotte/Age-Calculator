using System;

namespace lab2bonus
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] date = new string[3];
            Console.WriteLine("Hello! I'm going calculate your age");

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

            DateTime birthday = new DateTime(Convert.ToInt32(date[0]), Convert.ToInt32(date[1]), Convert.ToInt32(date[2]));
            Console.WriteLine(birthday);

            //DateTime today = DateTime.Today;

            int years = new DateTime(DateTime.Today.Subtract(birthday).Ticks).Year - 1;

            Console.WriteLine(years);

            DateTime lastBirthday = birthday.AddYears(years);
            lastBirthday.AddMonths(4);

            //int i = 1;
            //while (lastBirthday < DateTime.Now) 
            //{
            //    lastBirthday.AddMonths(i);
            //    i += 1;
            //}

            Console.WriteLine(lastBirthday);
        }
    }
}

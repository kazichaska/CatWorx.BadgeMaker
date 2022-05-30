using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        static void Main(string[] args) //entry point
        {
            List<Employee> employees;
            Console.WriteLine("Would you like to enter an employee? (y/n): ");
            string answer_1 = Console.ReadLine();
            if (answer_1 == "y" || answer_1 == "Y" || answer_1 == "yes" || answer_1 == "Yes" || answer_1 == "YES")
            {
                employees = PeopleFetcher.GetEmployees();
                // employees = PeopleFetcher.GetFromAPI();
                Util.PrintEnployees(employees);
                Util.MakeCSV(employees);
                Util.MakeBadges(employees);
            }

            Console.WriteLine("Would you like to fetch data from API? (y/n): ");
            string answer_2 = Console.ReadLine();
            if (answer_2 == "y" || answer_2 == "Y" || answer_2 == "yes" || answer_2 == "Yes" || answer_2 == "YES")
            {
                // employees = PeopleFetcher.GetEmployees();
                employees = PeopleFetcher.GetFromAPI();
                Util.PrintEnployees(employees);
                Util.MakeCSV(employees);
                Util.MakeBadges(employees);
            }  
        }
    }
}

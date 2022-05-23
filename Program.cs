using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        static List<Employee> GetEmployees()
            {
                List<Employee> employees = new List<Employee>();
                // Collect user values until the value is an empty string
                while (true)
                {
                    Console.WriteLine("Please enter a name: (leave empty and hit ENTER to exit!): ");
                    string firstName = Console.ReadLine();
                    // Break if the user hits ENETER without typing a name
                    if (firstName == "")
                    {
                        break;
                    }
                    // add a Console.ReadLine() for each value
                    Console.WriteLine("Enter last name: ");
                    string lastName = Console.ReadLine();
                    Console.WriteLine("Enter ID: ");
                    int id = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Enter photo URL: ");
                    string photoUrl = Console.ReadLine();
                    // Create a new Employee instance
                    Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);
                    // Add currentEmployee, not a string
                    employees.Add(currentEmployee);
                }
                // This is important to return the list of employees
                return employees;
            }

        // Change the type of the employee parameter
            static void PrintEnployees(List<Employee> employees)
            {
                for (int i = 0; i < employees.Count; i++)
                {
                    string template = "{0,-10}\t{1,-20}\t{2}";
                    Console.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetName(), employees[i].GetPhotoUrl()));
                }
            }

           static void Main(string[] args) //entry point
            {
                List<Employee> employees = GetEmployees();
                PrintEnployees(employees);
            }
        
    }
}

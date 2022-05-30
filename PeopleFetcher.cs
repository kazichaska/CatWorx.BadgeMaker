using System;
using System.Net;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace CatWorx.BadgeMaker {
    class PeopleFetcher
    {
        public static List<Employee> GetEmployees()
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

        public static List<Employee> GetFromAPI() {
            List<Employee> employees = new List<Employee>();

            using (WebClient client = new WebClient())
            {
                // Image example
                // Image.FromStream(client.OpenRead("image.png"));
                string response = client.DownloadString("https://randomuser.me/api/?results=10&nat=us&inc=name,id,picture");
                // Console.WriteLine(response);
                JObject json = JObject.Parse(response);
                // Console.WriteLine(json.SelectToken("results[0].name.first"));
                // Console.WriteLine(json.SelectToken("results[1].name.first"));
                // Console.WriteLine(json.SelectToken("results[2].name.first"));

                foreach (JToken person in json.SelectToken("results"))
                {
                    // Parse JSON data
                    Employee employee = new Employee
                    (
                        person.SelectToken("name.first").ToString(),
                        person.SelectToken("name.last").ToString(),
                        Int32.Parse(person.SelectToken("id.value").ToString().Replace("-", "")),
                        person.SelectToken("picture.large").ToString()
                    );
                    employees.Add(employee);
                }
            }
            return employees;
        }
    }
}
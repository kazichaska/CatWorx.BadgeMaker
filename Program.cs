using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        static void Main(string[] args) //entry point
        {
            {
                // String interpolation

                // string greeting = "Helllo";
                // greeting = greeting + "World";
                // Console.WriteLine("greeting" + greeting);
                // Console.WriteLine($"greeting {greeting}");
                // Console.WriteLine("greeting: {0}", greeting);

                // How do you find the area of a square? Area = side * side
                // double side = 3.14;
                // double area = side * side;
                // Console.WriteLine("area: {0}", area.GetType());
                
                // Math operations

                // Console.WriteLine(2 * 3);         // Basic Arithmetic: +, -, /, *
                // Console.WriteLine(10 % 3);        // Modulus Op => remainder of 10/3
                // Console.WriteLine(1 + 2 * 3);     // order of operations
                // Console.WriteLine(10 / 3.0);      // int's and doubles
                // Console.WriteLine(10 / 3);        // int's 
                // Console.WriteLine("12" + "3");    // What happens here?
                // int num = 10;
                // num += 100;
                // Console.WriteLine(num);
                // num ++;
                // Console.WriteLine(num);

                // Booleans

                // bool isCold = true;
                // Console.WriteLine(isCold ? "drink" : "add ice");
                // Console.WriteLine(!isCold ? "drink" : "add ice");

                // Type conversion

                // string stringNum = "2";
                // int intNum = Convert.ToInt16(stringNum);
                // Console.WriteLine(intNum);
                // Console.WriteLine(intNum.GetType());

                // Dictionary 

                Dictionary<string, int> myScoreBoard = new Dictionary<string, int>();
                
                myScoreBoard.Add("firstInning", 10);
                myScoreBoard.Add("secondInning", 20);
                myScoreBoard.Add("thirdInning", 30);
                myScoreBoard.Add("fourthInning", 40);
                myScoreBoard.Add("fifthInning", 50);

                // or we can do this
                // Dictionary<string, int> myScoreBoard = new Dictionary<string, int>(){
                //     { "firstInning", 10 },
                //     { "secondInning", 20},
                //     { "thirdInning", 30},
                //     { "fourthInning", 40},
                //     { "fifthInning", 50}
                // };
            
                Console.WriteLine("------------------");
                Console.WriteLine("  Score Board     ");
                Console.WriteLine("------------------");
                Console.WriteLine("Inning  |    Score");
                Console.WriteLine("   1    |     {0}", myScoreBoard["firstInning"]);
                Console.WriteLine("   2    |     {0}", myScoreBoard["secondInning"]);
                Console.WriteLine("   3    |     {0}", myScoreBoard["thirdInning"]);
                Console.WriteLine("   4    |     {0}", myScoreBoard["fourthInning"]);
                Console.WriteLine("   5    |     {0}", myScoreBoard["fifthInning"]);
                Console.WriteLine("------------------");
                Console.WriteLine("---------------------------------------");
                // Arrays
                string[] favFoods = new string[]{ "pizza", "doughnuts", "icecream", "gyro" };
                string firstFood = favFoods[0];
                string secondFood = favFoods[1];
                string thirdFood = favFoods[2];
                string fourthFood = favFoods[3];
                Console.WriteLine("I like {0}, {1}, {2} and {3}", firstFood, secondFood, thirdFood, fourthFood);
                Console.WriteLine("---------------------------------------");

                // Lists
                List<string> employees = new List<string>() { "adam", "amy" };
                employees.Add("barbara");
                employees.Add("billy");
                // Console.WriteLine("My employees include {0}, {1}, {2}, {3}", employees[0], employees[1], employees[2], employees[3]);
                for (int i = 0; i < employees.Count; i++)
                {
                    Console.WriteLine(employees[i]);
                }
            }
        }
    }
}

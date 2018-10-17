using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    class Program
    {
        static void Main(string[] args)
        {


            //create array
            string[,] studentInfo = new string[15, 3]
                {
                 { "Michael Hern", "Canton, MI", "Chicken Wings" } ,
                 { "Taylor Everts", "Caro, MI", "Cordon Bleu" },
                 { "Joshua Zimmerman", "Taylor, MI", "Turkey" },
                 { "Lin-Z Chang", "Toledo, OH", "Ice Cream" },
                 { "Madelyn Hilty", "Oxford, MI", "Croissent" },
                 { "Nana Banahene", "Guana", "Empanadas" },
                 { "Rochelle Toles", "Mars", "Space Cheese" },
                 { "Shah Shahid", "Newark, NJ", "Chicken Wings" },
                 { "Tim Broughton", "Detroit, MI", "Chicken Parm" },
                 { "Abby Wessels", "Traverse City, MI", "Soup" },
                 { "Blake Shaw", "Los Angeles, CA", "Cannolis" },
                 { "Bob Valentic", "St. Clair Shores, MI", "Pizza" },
                 { "Jordan Owiesny", "Warren, MI", "Burgers" },
                 { "Jay Stiles", "Macomb, MI", "Pickles" },
                 { "Jon Shaw", "Huntington Woods, MI", "Ribs" }
                };

            while (true)//verify user input
            {
                //get user input
                Console.Write("Welcome to our C# class. Which student would you like to learn more about? (There are only 15 students, please enter a number between 1 and 15): ");
                int studentChoice = int.Parse(Console.ReadLine());

                while (studentChoice > 15 || studentChoice < 1)//verify user input
                {
                    Console.Write("Please enter a number between 1 and 15: ");
                    studentChoice = int.Parse(Console.ReadLine());
                }

                //set up which column is which. 
                //studentChoice - 1 was needed since everything starts at 0
                //0, 1, and 2 represent the three columns of name, town, and food
                string name = studentInfo[studentChoice - 1, 0];
                string town = studentInfo[studentChoice - 1, 1];
                string food = studentInfo[studentChoice - 1, 2];

            //ask for user input hometown or food
            tryAgain: //learned this was a thing last night, had to try it somewhere
                Console.Write("Student " + studentChoice + " is " + name + ". What would you like to know about " + name + "? (enter hometown or favorite food): ");
                string homeOrFoodChoice = Console.ReadLine();
                string check;

                //print to screen name then print out town if the input == 1
                if (homeOrFoodChoice == "hometown")
                {
                    Console.WriteLine(name + " is from " + town);
                    homeOrFoodChoice = "0";

                }
                // print to screen name and then print food if input == 2
                if (homeOrFoodChoice == "favorite food")
                {
                    Console.WriteLine("Student " + name + " favorite food is " + food);
                    homeOrFoodChoice = "0";

                }
                else
                {
                    goto tryAgain;
                }

                //Check to continue to another student
                Console.Write("Continue y/n: ");
                check = Console.ReadLine();
                if (check != "y")
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    continue;
                }
            }

        }

    }

}



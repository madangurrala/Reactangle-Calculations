using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingAssignment1
{
    class Program
    {
        public static int ValidateMenuSelection()
        {
            string userInput = "";
            bool validMenuSelect = false;

            while (validMenuSelect == false)
            {
                Console.WriteLine("1 : Get rectangle length");
                Console.WriteLine("2 : Change rectangle length");
                Console.WriteLine("3 : Get rectangle width");
                Console.WriteLine("4 : Change rectangle width");
                Console.WriteLine("5 : Get rectangle perimeter");
                Console.WriteLine("6 : Get rectangle Area");
                Console.WriteLine("7 : Exit\n");

                Console.WriteLine("Please select an option by entering a number\n");
                userInput = Console.ReadLine();

                if ( userInput != "1" &&
                    userInput != "2" &&
                    userInput != "3" &&
                    userInput != "4" &&
                    userInput != "5" &&
                    userInput != "6" &&
                    userInput != "7"
                    )
                {
                    Console.WriteLine("Please enter the correct number\n");
                }
                else
                {
                    validMenuSelect = true;
                }


            }
            Console.WriteLine();
            return int.Parse(userInput);
        }

        //INput validation
     public static int ValidUserInput(string rectSide)
        {
            int number = 1;
            bool isValid = false;
             while (isValid == false)
            {
                Console.WriteLine("Please enter the {rectSide} of your rectangle:");
                string userInput = Console.ReadLine();
                Console.WriteLine();

                bool result = int.TryParse(userInput, out number);

                if (result == false)
                {
                    Console.WriteLine("That's not a valid input, please try again\n");
                }else if(number < 0){
                    Console.WriteLine("Number can not be less than Zero, please try again");
                }
                else
                {
                    isValid = true;
                    Console.WriteLine("");
                }

                return int.Parse(userInput);
            }
        }
        static void Main(string[] args)
        {

            ValidateMenuSelection();
        }
    }
}

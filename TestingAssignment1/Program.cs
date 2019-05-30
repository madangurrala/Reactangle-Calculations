using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingAssignment1
{
    class Program
    {
        public static String input = string.Empty;
        public static int length, width, choice;
        public static void LengthInput()
        {
            Console.Write("\nEnter the Length of Rectangle: ");
            input = Console.ReadLine();
         
            bool lengthResult = !int.TryParse(input, out length);
            if (length <= 0)
            {
                Console.WriteLine("Please enter the correct input");
                LengthInput();
            }

        }

        public static void WidthInput()
        {
            Console.Write("\nEnter the Width of Rectangle: ");
            input = Console.ReadLine();
            bool widthResult = !int.TryParse(input, out width);

            if (width <= 0)
            {
                Console.WriteLine("Please enter the correct input");
                WidthInput();
            }
        }
        
        public static void RectangleMenu()
        {
            Rectangle rectangle = new Rectangle(length, width);
            bool menuResult = true;
           
            while (menuResult == true) {

                Console.WriteLine("\nHere is your Menu Options");
                Console.WriteLine("\n1.Get Rectangle Length");
                Console.WriteLine("2.Change Rectangle Length");
                Console.WriteLine("3.Get Rectangle Width");
                Console.WriteLine("4.Change Rectangle Width");
                Console.WriteLine("5.Get Rectangle Perimeter");
                Console.WriteLine("6.GetRectangle Area");
                Console.WriteLine("7.Exit");

                Console.WriteLine("\nYou can choose options by entering correct number\n");
                input = Console.ReadLine();

                if (input != "1" &&
                    input != "2" &&
                    input != "3" &&
                    input != "4" &&
                    input != "5" &&
                    input != "6" &&
                    input != "7")
                {
                    Console.WriteLine("\nYou have selected an invalid option. Please choose the correct option\n");
                }
                else
                {
                    menuResult = true;
                }

                bool menu = !int.TryParse(input, out choice);
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Current Length of Rectangle=" + rectangle.GetLength());
                        break;
                    case 2:
                        do
                        {
                            Console.Write("Enter new Length: ");
                            input = Console.ReadLine();
                        } while (!int.TryParse(input, out length) || (length <= 0));
                        Console.WriteLine("Updated Rectangle Length=" + rectangle.SetLength(length));
                        break;
                    case 3:
                        Console.WriteLine("Current Width of Rectangle=" + rectangle.GetWidth());
                        break;
                    case 4:
                        do
                        {
                            Console.Write("Enter new Width: ");
                            input = Console.ReadLine();
                        } while (!int.TryParse(input, out width) || (width <= 0));
                        Console.WriteLine("Updated Rectngle Width=" + rectangle.SetWidth(width));
                        break;
                    case 5:
                        Console.WriteLine("Perimeter of the Rectangle=" + rectangle.GetPerimeter());
                        break;
                    case 6:
                        Console.WriteLine("Area of the Rectangle=" + rectangle.GetArea());
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please select a valid option");
                        break;
                }

            }
            
        }
        
    static void Main(string[] args)
        {
            LengthInput();
            WidthInput();
            RectangleMenu();

            Console.ReadKey();
        }
        
    }
}

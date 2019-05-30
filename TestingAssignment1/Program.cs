using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingAssignment1
{
    class Program
    {
         static void Main(string[] args)
        {
            int length, width, option;
            Rectangle Rect = new Rectangle();
            String input = string.Empty;
            do
            {
                Console.Write("Enter the Length of Rectangle: ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out length) || (length <= 0));

            if (length <= 0)
            {
                Console.WriteLine("Please enter the valid input");
            }

            do
            {
                Console.Write("Enter the Width of Rectangle: ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out width) || (width <= 0));

            Rectangle rectangle = new Rectangle(length, width);

            while (true)
            {
                do
                {
                    Console.WriteLine("1.Get Rectangle Length");
                    Console.WriteLine("2.Change Rectangle Length");
                    Console.WriteLine("3.Get Rectangle Width");
                    Console.WriteLine("4.Change Rectangle Width");
                    Console.WriteLine("5.Get Rectangle Perimeter");
                    Console.WriteLine("6.Get Rectangle Area");
                    Console.WriteLine("7.Exit");
                    input = Console.ReadLine();
                } while (!int.TryParse(input, out option) || (option <= 0 && option >= 8));

                switch (option)
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
    }
}

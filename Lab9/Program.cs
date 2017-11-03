using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab9;

namespace Lab9
{
    class Program
    {

        static void Main(string[] args)
        {
            int c = 0;
            while (true)
            {

                double userInput = 0.0;
                Console.Write("Enter the radius of a circle: ");
                userInput = Validator.InputValidator();
                if (userInput == 0 || userInput < 0)
                {
                    continue;
                }

                c++;

                CircleApp diameter = new CircleApp(userInput);

                double circumference = diameter.GetCircumference();
                string formatCirc = diameter.GetFormattedCircumference();

                double area = diameter.GetArea();

                string formatArea = diameter.GetFormattedArea();
                Console.WriteLine($"Circumference : {formatCirc}");
                Console.WriteLine($"Area:           {formatArea}");

                Console.WriteLine(Continue(c));
            }
        }

        public static string Continue(int x)
        {

            while (true)
            {
                Console.Write("\nDo you have another radius to enter? Yes or No: ");
                string test = Console.ReadLine().ToLower();

                if (test == "y" || test == "yes")
                {
                    return "ok";
                }
                else if (test == "n" || test == "no")
                {
                    Console.WriteLine($"Bye! You created {x} Circle Objects. ");
                    Console.ReadLine();
                    Environment.Exit(1);
                }
            }
        }
    }
}

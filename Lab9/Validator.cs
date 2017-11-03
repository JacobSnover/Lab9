using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab9;

namespace Lab9
{
    public class Validator
    {
        
        public static double InputValidator()
        {
            double userInput = 0.0;
            string input = Console.ReadLine();
            
            try
            {
                userInput = double.Parse(input);
            }
            catch (Exception e)
            {

                Console.WriteLine("wrong");
            }
            return userInput;
            

        }
    }
}

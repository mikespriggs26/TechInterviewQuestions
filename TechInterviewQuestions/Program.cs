using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechInterviewQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer:");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput % 3 == 0 && userInput % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (userInput % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            
            else if ( userInput % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine("That integer is not divisible by 3 or 5");
            }
        }
    }
}

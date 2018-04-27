using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5RecursionVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;

            while (repeat)
            {
                int number = Validate("Please enter a number between 1 and 10: ");
                Console.WriteLine(GetFactorial(number));
                repeat = Confirm("Do you want to try it again? (Y/N): ");
            }
        }

        public static long GetFactorial(int number)
        {
            if(number > 1)
            {
                return number * GetFactorial(number - 1);
            }
            else
            {
                return 1;
            }
        }

        public static int Validate(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            int number;

            while (!int.TryParse(input, out number) || number < 1 || number > 10)
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 10!");
                input = Console.ReadLine();
            }
            return number;
        }

        public static bool Confirm(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();

            if (input.ToLower() == "yes" || input.ToLower() == "y")
            {
                return true;
            }
            else if (input.ToLower() == "no" || input.ToLower() == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Invalid input. ");
                return Confirm(message);
            }
        }

    }
}

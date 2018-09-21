using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotjar4InputOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            bool newQuery = true;
            while (newQuery)
            {
                int value;
                bool notValid = false; 
                Console.WriteLine();
                Console.WriteLine("Please enter first number: ");
                int firstNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter operator: ");
                string operators = Console.ReadLine();
                Console.WriteLine("Please enter Second number: ");
                int secondNumber = Convert.ToInt32(Console.ReadLine());
                if (operators == "-")
                {
                    value = firstNumber - secondNumber;
                    Console.WriteLine($"{firstNumber} {operators} {secondNumber} = " + value);
                }
                else if (operators == "/")
                {
                    value = firstNumber / secondNumber;
                    Console.WriteLine($"{firstNumber} {operators} {secondNumber} = " + value);
                }
                else if (operators == "*" || operators == "x")
                {
                    value = firstNumber * secondNumber;
                    Console.WriteLine($"{firstNumber} {operators} {secondNumber} = " + value);
                }
                else
                {
                    value = firstNumber + secondNumber;
                    Console.WriteLine($"{firstNumber} {operators} {secondNumber} = " + value);
                }
                Console.WriteLine("Would you like to make another operation? If so, enter 'y' or 'yes', otherwise press ");
                string decision = Console.ReadLine();

                if (decision == "yes" || decision == "y")
                {
                    newQuery = true;
                }
                else
                {
                    newQuery = false;
                }
            } 
        }
    }
}

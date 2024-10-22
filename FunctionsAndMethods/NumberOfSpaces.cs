using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsAndMethods
{
    internal class NumberOfSpaces
    {
        public static void MainNumberOfSpaces()
        {
            Console.WriteLine("Please insert the string: ");
            string message = Console.ReadLine();
            Console.WriteLine($"The sum of spaces is: {CountTheSpaces(message)}"); 
        }

        static int CountTheSpaces(string message) {
            int sum = 0;
            foreach (char c in message) {
                if (c == ' ') { sum++; }
            }
            return sum;
        }
    }
}

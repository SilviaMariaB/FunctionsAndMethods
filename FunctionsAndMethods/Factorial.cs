using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsAndMethods
{
    internal class Factorial
    {
        public static void MainFactorial()
        {
            SharedMethods.ReadANumber(out int number, "number");

            Console.WriteLine($"The factorial of {number} is {CalculateFactorial(number)}");
            

        }

        static int CalculateFactorial(int number)
        {
            int result = 1;
            for (int i = 0; i < number; i++) {
                result = result * (i+1);
            }
            return result;
        }
    }
}

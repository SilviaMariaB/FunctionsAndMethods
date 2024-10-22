using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsAndMethods
{
    internal class SumOfNumbers
    {
        public static void MainSumOfNumbers()
        {
            SharedMethods.ReadTwoNumbers(out int num1, out int num2);
            Console.WriteLine($"The sum is: {Add(num1,num2)}");
        }

        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

    }
}

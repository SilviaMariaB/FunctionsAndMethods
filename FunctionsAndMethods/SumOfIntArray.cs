using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsAndMethods
{
    internal class SumOfIntArray
    {
        public static void MainSumOfIntArray()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine($"The sum of the numbers in the array is {SumOfNumbers(numbers)}");
        }

        static int SumOfNumbers(int[] numbers)
        {
            int sum = 0;
            foreach (int i in numbers)
            {
                sum += i;
            }
            return sum;
        }
    }
}

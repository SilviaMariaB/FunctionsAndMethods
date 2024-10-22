using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsAndMethods
{
    internal class SwapInts
    {
        public static void MainSwapInts()
        {
            SharedMethods.ReadTwoNumbers(out int num1, out int num2);
            Console.WriteLine($"Number 1 is: {num1}, number 2 is: {num2}");
            SwapInt(ref num1,ref num2);
            Console.WriteLine($"Number 1 is: {num1}, number 2 is: {num2}");
        }

        static void SwapInt(ref int num1, ref int num2)
        {
            int swap = num1;
            num1 = num2;
            num2 = swap;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsAndMethods
{
    internal class SharedMethods
    {
        public static void ReadTwoNumbers(out int num1, out int num2) {
            Console.WriteLine("\nPlease insert 1st number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please insert 2nd number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
        }

        public static void ReadANumber(out int number, string message)
        {
            Console.WriteLine($"Insert a {message}");
            number = Convert.ToInt32(Console.ReadLine());
        }
    }
}

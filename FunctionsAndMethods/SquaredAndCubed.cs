using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsAndMethods
{
    internal class SquaredAndCubed
    {
        public static void MainSquaredAndCubed()
        {
            Console.WriteLine("Please insert a number: ");

            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The number {number} squared is: {Squared(number)} and cubed is: {Cubed(number)}");
        }

        static int Squared(int num)
        {
            return num * num;
        }

        static int Cubed(int num)
        {
            return (int)Math.Pow(num, 3);
        }
    }
}

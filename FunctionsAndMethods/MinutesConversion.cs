using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsAndMethods
{
    internal class MinutesConversion
    {
        public static void MainMinutesConversion()
        {
            SharedMethods.ReadANumber(out int minutes, "number of minutes");

            Console.WriteLine($"The number of seconds in {minutes} minutes is {CalculateSeconds(minutes)}.");
        }

        static int CalculateSeconds(int minutes)
        {
            return minutes * 60;
        }
    }
}

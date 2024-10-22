using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsAndMethods
{
    internal class AreaOfTriangle
    {
        public static void MainAreaOfTriangle()
        {
            Console.WriteLine("\nPlease insert width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please insert height: ");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The area of the triangle is: {TriangleArea(width, height)}");
        }

        static int TriangleArea(int width, int height)
        {
            return (width * height) / 2;
        }
    }
}

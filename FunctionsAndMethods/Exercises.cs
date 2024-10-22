using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsAndMethods
{
    internal class Exercises
    {
        public static void MainExercises()
        {
            //Console.WriteLine(Welcome()); 
            //Console.WriteLine(Introduction()); 
            //Console.WriteLine("\n"+Goodbye());

            Print(Welcome());
            Print(Introduction(), true);
            Print(Goodbye(), true);

            //task6 - named console print
            //Print(Welcome());
            //Print(message: Introduction(), inline: true);
            //Print(inline: true, message: Goodbye());

            Console.WriteLine("\nPlease insert 1st number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please insert 2nd number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            if (Remainder(number1, number2, out int result))
            {
                Console.WriteLine("Divisible!");
            }
            else
            {
                Console.WriteLine("Not divisible! The remainder is " + result);
            }
            bool mainCheck = false;
            int mainResult = 0;

            Remainder(ref mainCheck, number1, number2, ref mainResult);
            if (mainCheck)
            {
                Console.WriteLine("Divisible!");
            }
            else
            {
                Console.WriteLine("Not divisible! The remainder is " + result);
            }

            Console.ReadLine();
        }

        //task 1 - print name in function
        static string Introduction()
        {
            return "My name is Silvia and I'm 27 years old.";
        }

        //task 2&3 - welcome and goodbye functions + return welcome and goodbye
        static string Welcome()
        {
            return "Welcome to my programme!";
        }

        static string Goodbye()
        {
            return "Bye bye now.";
        }

        //task4 - Console print
        static void Print(string message)
        {
            Console.WriteLine(message);
        }

        //task5 - inline console print
        static void Print(string message, bool inline = false)
        {
            if (inline)
            {
                Console.Write(message);
            }
            else
            {
                Console.WriteLine(message);
            }
        }

        //task7 - remainder return
        static bool Remainder(int num1, int num2, out int result)
        {
            result = num1 % num2;
            if (result == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //task8 - remainder ref return
        static void Remainder(ref bool check, int num1, int num2, ref int result)
        {
            result = num1 % num2;
            if (result == 0)
            {
                check = true;
            }
            else
            {
                check = false;
            }
        }

    }

}


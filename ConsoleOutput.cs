using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorizor
{
    public class ConsoleOutput
    {
        public static void Write(string str)
        {
            Console.Write(str);
        }

        public static void WriteLine(string str)
        {
            Console.WriteLine(str);
        }

        public static void Factors(int number, int[] factors)
        {
            Console.WriteLine($"The factors of this {number} are: ");
            for(int i = 0; i < factors.Length; i++)
            {
                Console.WriteLine("\t" + factors[i]);
                Console.ReadLine();
            }
        }

        public static void PrimeNumberResult(int number, bool isPrime)
        {
            Console.WriteLine($"{number} is {(isPrime ? "" : "not ")} a prime number.");
            Console.ReadLine();
        }

        public static void PerfectNumberResult(int number, bool isPerfect)
        {
            Console.WriteLine($"{number} is {(isPerfect ? "" : "not ")} a perfect number.");
            Console.ReadLine();
        }
    }
}

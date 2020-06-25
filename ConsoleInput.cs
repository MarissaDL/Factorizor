using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorizor
{
    public class ConsoleInput
    {
        /// <summary>
        /// Get number from UI
        /// </summary>
        /// <param name="prompt">Input promt for number</param>
        /// <param name="min">Minimum allowed (inclusive) number. Default is min int (~2.4B)</param>
        /// <param name="max">Maximum allowed (inclusive)  number. Default is max int (~2.4B)</param>
        /// <returns>User specified valid input</returns>
        public static int GetNumberFromUser(string prompt, int min = int.MinValue, int max = int.MaxValue)
        {
            string inputNumb;
            int output;
            bool firstTime = true;

            do
            {
                if(!firstTime)
                {
                    ConsoleOutput.WriteLine("Invalid input!");
                }
                firstTime = false;

                ConsoleOutput.Write(prompt);
                inputNumb = Console.ReadLine();

            } while (!int.TryParse(inputNumb, out output) || output < min || output > max);

            return output;
        }
    }
}

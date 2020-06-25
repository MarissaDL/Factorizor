using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factorizor.BLL;

namespace Factorizor
{
    public class Workflow
    {
        public void Execute()
        {
            //get number to factorize
            int number = ConsoleInput.GetNumberFromUser("What number would you like to factor? ", 1);

            //determine factors (static)
            int[] factors = FactorFinder.Execute(number);
            ConsoleOutput.Factors(number, factors);

            //prime it (is not static)
            PrimeChecker primeChecker = new PrimeChecker();
            bool result = primeChecker.IsPrimeNumber(number);
            ConsoleOutput.PrimeNumberResult(number, result);

            //perfect num
            PerfectChecker perfectChecker = new PerfectChecker();
            perfectChecker.Number = number;
            bool isPerfect = perfectChecker.IsPerfectNumber();
            ConsoleOutput.PerfectNumberResult(number, result);

        }
    }
}

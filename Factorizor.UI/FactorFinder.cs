using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorizor.BLL
{
    public class FactorFinder
    {
        public static int[] Execute(int numbers)
        {
            List<int> factors = new List<int>();

            for(int i = 1; i <= numbers; ++i)
            {
                if(numbers % i == 0)
                {
                    factors.Add(i);
                }
            }
            return factors.ToArray();
        }
    }
}

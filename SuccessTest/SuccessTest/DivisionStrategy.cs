using System;
using System.Collections.Generic;
using System.Text;

namespace SuccessTest
{
    public class DivisionStrategy: IPrimaryCheckingStrategy
    {
        public bool isPrime(int number)
        {
            if (number <= 1)
                return false;

            if (number % 2 == 0 && number != 2)
            {
                return false;
            }

            for (int i = 3; i < Math.Floor(Math.Sqrt(i)); i += 2)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        public IList<int> getPrimes(int intervalStart, int intervalEnd)
        {
            List<int> primaryNumbers = new List<int>();
            // Could improve performance here twice by adding a special case for [2, b]:
            // add 2 to primes and iterate over every second element starting from 3.
            for (int i = intervalStart; i <= intervalEnd; i++)
            {
                if (isPrime(i)) primaryNumbers.Add(i);
            }
            return primaryNumbers;
        }
    }
}

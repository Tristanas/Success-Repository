using System;
using System.Collections.Generic;
using System.Text;

namespace SuccessTest
{
    class EratosthenesSieveStrategy : IPrimaryCheckingStrategy
    {
        int maximumNumber;
        IList<int> primaryNumbers;
        public EratosthenesSieveStrategy(int max)
        {
            this.maximumNumber = max;
            primaryNumbers = new List<int>();
            generatePrimaryNumbers();
        }

        public IList<int> getPrimaryNumbers(int intervalStart, int intervalEnd)
        {
            List<int> primes = new List<int>();
            foreach (int prime in primaryNumbers)
            {
                if (prime >= intervalStart)
                    primes.Add(prime);
            }
            return primes;
        }

        public bool isPrimary(int number)
        {
            if (number > maximumNumber)
            {
                Console.WriteLine("Warning, checking a number that is higher than the highest checked number");
                return false;
            }
            return primaryNumbers.Contains(number);
        }

        private void generatePrimaryNumbers()
        {
            List<int> numbers = new List<int>();
            // Populating the list with all potential primary numbers.
            int newPrime = 3;
            primaryNumbers.Add(2);
            primaryNumbers.Add(newPrime);
            // Not even adding even numbers.
            for (int i = 3; i <= maximumNumber; i += 2)
            {
                numbers.Add(i);
            }

            while (numbers.Count > 0)
            {
                numbers.RemoveAll(number => number % newPrime == 0);
                newPrime = numbers[0];
                primaryNumbers.Add(newPrime);
                numbers.RemoveAt(0);
            }
        }
    }
}

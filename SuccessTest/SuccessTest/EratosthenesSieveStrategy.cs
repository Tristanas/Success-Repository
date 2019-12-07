using System;
using System.Collections.Generic;
using System.Text;

namespace SuccessTest
{
    public class EratosthenesSieveStrategy : IPrimaryCheckingStrategy
    {
        int maximumNumber;
        List<int> primes;
        public EratosthenesSieveStrategy(int max)
        {
            // Adding 1 to make the interval inclusive.
            this.maximumNumber = max + 1;
            primes = new List<int>();
        }

        public IList<int> getPrimes(int intervalStart, int intervalEnd)
        {
            if (this.primes.Count == 0)
                generatePrimaryNumbers();
            List<int> primes = new List<int>();
            foreach (int prime in this.primes)
            {
                if (prime > intervalEnd)
                    break;
                if (prime >= intervalStart)
                    primes.Add(prime);
            }
            return primes;
        }

        public bool isPrime(int number)
        {
            if (number > maximumNumber)
            {
                Console.WriteLine("Warning, checking a number that is higher than the highest checked number");
                return false;
            }
            return primes.Contains(number);
        }

        private void generatePrimaryNumbers()
        {
            short[] numbers = new short[maximumNumber + 1];
            // Populating the list with all potential primary numbers.
            numbers[2] = 1;
            // Not even adding even numbers.
            for (int i = 3; i <= maximumNumber; i += 2)
            {
                numbers[i] = 1;
            }

            for (int i = 3; i <= maximumNumber; i += 2)
            {
                if (numbers[i] != 0)
                {
                    for (int j = 2; i * j <= maximumNumber; j++)
                    {
                        numbers[i * j] = 0;
                    }
                }
            }

            getPrimesFromSieve(numbers);
        }

        private void getPrimesFromSieve(short[] numbers)
        {
            for (int i = 1; i <= maximumNumber; i++)
            {
                if (numbers[i] != 0)
                {
                    primes.Add(i);
                }
            }
        }
    }
}

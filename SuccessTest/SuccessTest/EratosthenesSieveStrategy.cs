using System;
using System.Collections.Generic;
using System.Text;

namespace SuccessTest
{
    class EratosthenesSieveStrategy : IPrimaryCheckingStrategy
    {
        int maximumNumber;
        List<int> primaryNumbers;
        public EratosthenesSieveStrategy(int max)
        {
            // Adding 1 to make the interval inclusive.
            this.maximumNumber = max + 1;
            primaryNumbers = new List<int>();
        }

        public IList<int> getPrimaryNumbers(int intervalStart, int intervalEnd)
        {
            if (primaryNumbers.Count == 0)
                generatePrimaryNumbers();
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

        // This is awfully inefficient. Eratosthenes sieve actually requires no division.
        // And not each element should be iterated. When removing multiples.
        private void generatePrimaryNumbers()
        {
            int[] numbers = new int[maximumNumber + 1];
            // Populating the list with all potential primary numbers.
            primaryNumbers.Add(2);
            // Not even adding even numbers.
            for (int i = 3; i <= maximumNumber; i += 2)
            {
                numbers[i] = i;
            }

            int currentPrime = 3;
            do
            {
                primaryNumbers.Add(currentPrime); 
                removeAllMultiples(numbers, currentPrime);
                currentPrime = findNextPrime(numbers, currentPrime);
            } while (currentPrime != 0);
        }

        // Navigates through the array which models an Eratosthenes sieve. Looks for the next prime.
        // Returns 0 if end of array is reached.
        private int findNextPrime(int[] array, int prime)
        {
            int nextPrime = prime + 1;
            while (array[nextPrime] == 0)
            {
                if (++nextPrime >= maximumNumber)
                    return 0;
            }
            return nextPrime;
        }

        private void removeAllMultiples(int[] array, int number)
        {
            for (int i = number * 2; i <= maximumNumber; i += number)
            {
                array[i] = 0;
            }
        }
    }
}

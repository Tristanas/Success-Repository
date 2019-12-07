using System;
using System.Collections.Generic;
using System.Text;

namespace SuccessTest
{
    public class PrimaryNumberChecker
    {
        IPrimaryCheckingStrategy strategy;

        public PrimaryNumberChecker(IPrimaryCheckingStrategy strategy)
        {
            this.strategy = strategy;
        }

        public bool isPrime(int number)
        {
            return strategy.isPrime(number);
        }

        public IList<int> getPrimaryNumbers(int intervalStart, int intervalEnd)
        {
            return strategy.getPrimes(intervalStart, intervalEnd);
        }

        public void setStrategy(IPrimaryCheckingStrategy strategy)
        {
            this.strategy = strategy;
        }
    }
}

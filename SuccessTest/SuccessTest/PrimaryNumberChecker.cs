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

        public bool isPrimary(int number)
        {
            return strategy.isPrimary(number);
        }

        public IList<int> getPrimaryNumbers(int intervalStart, int intervalEnd)
        {
            return strategy.getPrimaryNumbers(intervalStart, intervalEnd);
        }

        public void setStrategy(IPrimaryCheckingStrategy strategy)
        {
            this.strategy = strategy;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SuccessTest
{
    public class DivisionStrategy: IPrimaryCheckingStrategy
    {
        public bool isPrimary(int number)
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

        public IList<int> getPrimaryNumbers(int intervalStart, int intervalEnd)
        {
            List<int> primaryNumbers = new List<int>();
            for (int i = intervalStart; i <= intervalEnd; i++)
            {
                if (isPrimary(i)) primaryNumbers.Add(i);
            }
            return primaryNumbers;
        }
    }
}

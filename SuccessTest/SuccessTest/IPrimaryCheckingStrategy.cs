using System.Collections.Generic;

namespace SuccessTest
{
    public interface IPrimaryCheckingStrategy
    {
        bool isPrime(int number);

        IList<int> getPrimes(int intervalStart, int intervalEnd);
    }
}
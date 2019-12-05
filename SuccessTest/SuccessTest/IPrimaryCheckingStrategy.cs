using System.Collections.Generic;

namespace SuccessTest
{
    public interface IPrimaryCheckingStrategy
    {
        bool isPrimary(int number);

        IList<int> getPrimaryNumbers(int intervalStart, int intervalEnd);
    }
}
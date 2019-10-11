using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrimaryUnitTest
{
    [TestClass]
    public class PrimaryNumberTest
    {
        [TestMethod]
        public void OneIsNotPrime()
        {
            PrimaryNumberChecker checker = new PrimaryNumberChecker();
            bool isOnePrime = checker.isPrime(1);
            
        }
    }
}

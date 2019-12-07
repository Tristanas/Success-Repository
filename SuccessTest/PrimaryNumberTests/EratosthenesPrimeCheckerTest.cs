using NUnit.Framework;
using SuccessTest;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrimaryNumberTests
{
    class EratosthenesPrimeCheckerTest
    {
        PrimaryNumberChecker checker;
        [SetUp]
        public void Setup()
        {
            checker = new PrimaryNumberChecker(new EratosthenesSieveStrategy(1000));
            checker.getPrimaryNumbers(1, 4);
        }

        public void OneIsNotPrime()
        {
            Assert.False(checker.isPrime(1));
        }

        [Test]
        public void primesFromInterval_inclusivityTest()
        {
            IList<int> primes = checker.getPrimaryNumbers(5, 17);
            Assert.AreEqual(5, primes[0]);
            Assert.AreEqual(17, primes[primes.Count - 1]);
        }


        [Test]
        public void NegativeShouldNotBePrime()
        {
            Assert.False(checker.isPrime(-17));
        }

        [Test]
        public void EvenNumbersPrimaryCheck()
        {
            Assert.True(checker.isPrime(2));
            for (int i = 4; i < 100; i += 2)
            {
                Assert.False(checker.isPrime(i));
            }
        }

        [Test]
        public void PrimaryNumberShouldReturnTrue()
        {
            Assert.True(checker.isPrime(997));
        }
    }
}

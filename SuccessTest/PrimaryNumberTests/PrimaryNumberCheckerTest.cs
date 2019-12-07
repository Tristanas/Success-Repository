using NUnit.Framework;
using SuccessTest;

namespace PrimaryNumberTests
{
    public class PrimaryNumberCheckerTest
    {
        PrimaryNumberChecker checker;
        [SetUp]
        public void Setup()
        {
            checker = new PrimaryNumberChecker(new DivisionStrategy());
        }

        [Test]
        public void OneIsNotPrimary()
        {
            Assert.False(checker.isPrime(1));
        }


        [Test]
        public void NegativeShouldNotBePrimary()
        {
            Assert.False(checker.isPrime(-7790));
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
            Assert.True(checker.isPrime(7919));
        }
    }
}
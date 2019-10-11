using NUnit.Framework;
using SuccessTest;

namespace PrimaryNumberCheckerTest
{
    public class Tests
    {
        PrimaryNumberChecker checker;
        [SetUp]
        public void Setup()
        {
            checker = new PrimaryNumberChecker();
        }

        [Test]
        public void OneIsNotPrimary()
        {
            Assert.False(checker.isPrimary(1));
        }

        [Test]
        public void EvenNumbersPrimaryCheck()
        {
            Assert.True(checker.isPrimary(2));
            for (int i = 4; i < 100; i += 2)
            {
                Assert.False(checker.isPrimary(i));
            }
        }

        [Test]
        public void PrimaryNumberShouldReturnTrue()
        {
            Assert.True(checker.isPrimary(7919));
        }
    }
}
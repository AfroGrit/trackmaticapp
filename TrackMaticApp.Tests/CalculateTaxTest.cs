using TrackMaticApp;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }



        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }

    [TestFixture]
    public class TaxCalculatorTester : ITaxCalculator
    {
        [Test]
        public float CalculateTax(Cart cart)
        {
            return 1;
        }
    }
}
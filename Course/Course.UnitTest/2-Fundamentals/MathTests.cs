using Course._2_Fundamentals;
using NUnit.Framework;
using System.Linq;

namespace Course.UnitTests._2_Fundamentals
{
    [TestFixture]
    class MethTests
    {
        Math _math;

        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }

        [TearDown]
        public void TearDown()
        {
            //disposing, erase, clear
        }

        [Test]
        public void Max_FirstValueBiggerThanSecond_ReturnFirst()
        {
            //arrange
            var math = new Math();

            //act
            var result = math.Max(3, 1);

            //assert
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Max_SecondValueBiggerThanFirst_ReturnSecond()
        {
            //arrange

            //act
            var result = _math.Max(1, 4);

            //assert
            Assert.That(result, Is.EqualTo(4));
        }

        [Ignore("because I want")]
        [Test]
        public void Max_Equals_ReturnFirst()
        {
            //arrange
            
            //act
            var result = _math.Max(1, 1);

            //assert
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        [TestCase(1, 2, 2)]
        [TestCase(5, 2, 5)]
        [TestCase(1, 1, 1)]
        [TestCase(1, 2, 2)]
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedValue)
        {
            //arrange
            
            //act
            var result = _math.Max(a, b);

            //assert
            Assert.That(result, Is.EqualTo(expectedValue));
        }

        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit()
        {
            var result = _math.GetOddNumbers(5);

            Assert.That(result, Is.Not.Empty);

            Assert.That(result.Count(), Is.EqualTo(3));

            Assert.That(result, Does.Contain(1));
            Assert.That(result, Does.Contain(3));
            Assert.That(result, Does.Contain(5));

            Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5 }));

            Assert.That(result, Is.Ordered);
            Assert.That(result, Is.Unique);

        }
    }
}

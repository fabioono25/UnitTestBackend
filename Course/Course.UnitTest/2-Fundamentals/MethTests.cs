using Course._2_Fundamentals;
using NUnit.Framework;

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
        public void Max_ReceiveValues_ReturnMaxOne(int a, int b, int expectedValue)
        {
            //arrange
            
            //act
            var result = _math.Max(a, b);

            //assert
            Assert.That(result, Is.EqualTo(expectedValue));
        }
    }
}

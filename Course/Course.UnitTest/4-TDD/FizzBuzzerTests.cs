using Course._4_TDD;
using NUnit.Framework;

namespace Course.UnitTests._4_TDD
{
    [TestFixture]
    class FizzBuzzerTests
    {
        [Test]
        public void GetValue_Receive1_Returns1()
        {
            //arrange
            var fizzBuzz = new FizzBuzzer();

            //act
            var result = fizzBuzz.GetValue(1);

            //assert
            Assert.That(result, Is.EqualTo("1"));
        }

        [Test]
        public void GetValue_Receive2_Returns2()
        {
            //arrange
            var fizzBuzz = new FizzBuzzer();

            //act
            var result = fizzBuzz.GetValue(2);

            //assert
            Assert.That(result, Is.EqualTo("2"));
        }

        [Test]
        public void GetValue_Receive3_ReturnsFizz()
        {
            //arrange
            var fizzBuzz = new FizzBuzzer();

            //act
            var result = fizzBuzz.GetValue(3);

            //assert
            Assert.That(result, Is.EqualTo("Fizz"));
        }
    }
}

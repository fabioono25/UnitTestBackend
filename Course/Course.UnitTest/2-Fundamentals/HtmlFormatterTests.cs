using Course._2_Fundamentals;
using NUnit.Framework;

namespace Course.UnitTests._2_Fundamentals
{
    [TestFixture]
    class HtmlFormatterTests
    {
        [Test]
        public void FormatAsBold_SendText_ShouldReturnBold()
        {
            //arrange
            var formatter = new HtmlFormatter();

            //act
            var result = formatter.FormatAsBold("Abc");

            //assert
            Assert.That(result, Is.EqualTo("<strong>Abc</strong>"));
            Assert.That(result, Does.Contain("abc").IgnoreCase);
            Assert.That(result, Does.StartWith("<strong>"));
            Assert.That(result, Does.EndWith("</strong>"));

        }
    }
}

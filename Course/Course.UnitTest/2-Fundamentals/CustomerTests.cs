using Course._2_Fundamentals;
using NUnit.Framework;

namespace Course.UnitTests._2_Fundamentals
{
    [TestFixture]
    public class CustomerTests
    {
        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            var controller = new CustomerController();

            var result = controller.GetCustomer(0);

            // NotFound 
            Assert.That(result, Is.TypeOf<NotFound>());

            // NotFound or one of its derivatives 
            Assert.That(result, Is.InstanceOf<NotFound>());
        }

        [Test]
        public void GetCustomer_IdIsNotZero_ReturnOk()
        {

        }
    }
}

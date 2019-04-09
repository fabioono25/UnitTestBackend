using Course._1_FirstDemo;
using NUnit.Framework;
using System;

namespace Course.UnitTest._1_FirstDemo
{
    [TestFixture]
    class ReservationTests
    {
        [Test]
        public void CanBeCancelledBy_UserIdAdmin_ReturnTrue()
        {
            //arrange
            var user = new User
            {
                IsAdmin = true
            };

            var reservation = new Reservation();

            //act
            var result = reservation.CanBeCancelledBy(user);

            //assert
            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void CanBeCancelledBy_MadeBySameUser_ReturnTrue()
        {
            //arrange
            var user = new User();

            var reservation = new Reservation
            {
                MadeBy = user
            };

            //act
            var result = reservation.CanBeCancelledBy(user);

            //assert
            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void CanBeCancelledBy_DefaultPath_ReturnFalse()
        {
            //arrange
            var reservation = new Reservation();

            //act
            var result = reservation.CanBeCancelledBy(new User());

            //assert
            Assert.That(result, Is.EqualTo(false));
        }

        [Test]
        public void CanBeCancelledBy_UserNull_ThrowsNullReferenceException()
        {
            //arrange
            var reservation = new Reservation();

            //act
            //assert
            Assert.That(() => reservation.CanBeCancelledBy(null), Throws.Exception.TypeOf<NullReferenceException>());
        }
    }
}

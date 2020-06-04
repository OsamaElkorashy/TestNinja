using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace Ninja.UnitTest
{
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //Arrange
            Reservation reservation = new Reservation();
            //Act
            bool result = reservation.CanBeCancelledBy(new User { IsAdmin=true});
            //Assert
            Assert.IsTrue(result);
        }
        [Test]
        public void CanBeCancelledBy_UserMadeReservation_ReturnsTrue()
        {
            User user = new User();
            Reservation reservation = new Reservation { MadeBy=user};
            
            bool result = reservation.CanBeCancelledBy(user);
            
            Assert.IsTrue(result);
        }
        [Test]
        public void CanBeCancelledBy_DifferentUser_ReturnsFalse()
        {
            Reservation reservation = new Reservation();
            
            bool result = reservation.CanBeCancelledBy(new User());
            
            Assert.IsTrue(!result);
        }
    }
}

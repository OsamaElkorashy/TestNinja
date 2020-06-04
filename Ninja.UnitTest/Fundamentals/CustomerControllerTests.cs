using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace Ninja.UnitTest
{
    [TestFixture]
    class CustomerControllerTests
    {
        private CustomerController _customerController;
        [SetUp]
        public void SetUp() 
        {
            _customerController = new CustomerController();
        }
        [Test]
        public void GetCustomer_IDIsZero_returnsNotFoound()
        {
            var result = _customerController.GetCustomer(0);

            Assert.That(result,Is.TypeOf<NotFound>());
        }
        [Test]
        public void GetCustomer_IDIsNotZero_returnsOK()
        {
            var result = _customerController.GetCustomer(1);

            //TypeOf Gets the exact type
            Assert.That(result, Is.TypeOf<Ok>());
            //InstanceOf Gets the type or any of it's children
            Assert.That(result, Is.InstanceOf<Ok>());
        }
    }
}

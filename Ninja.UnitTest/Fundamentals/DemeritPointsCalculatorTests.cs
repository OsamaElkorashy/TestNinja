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
    class DemeritPointsCalculatorTests
    {
        [TestCase(0, 0)]
        [TestCase(40,0)]
        [TestCase(65,0)]
        [TestCase(66, 0)]
        [TestCase(70, 1)]
        [TestCase(75, 2)]
        public void CalculateDemeritPoints_CalledWithValidParameters_ReturnsDeMeritPoints(int speed,int expectedValue)
        {
            DemeritPointsCalculator demeritPointsCalculator = new DemeritPointsCalculator();

            int result = demeritPointsCalculator.CalculateDemeritPoints(speed);

            Assert.That(result, Is.EqualTo(expectedValue));
        }
        [TestCase(-1)]
        [TestCase(301)]
        public void CalculateDemeritPoints_OutOfRangeSpeed_ReturnsError(int speed)
        {
            DemeritPointsCalculator demeritPointsCalculator = new DemeritPointsCalculator();

            Assert.That(()=> demeritPointsCalculator.CalculateDemeritPoints(speed), Throws.TypeOf<ArgumentOutOfRangeException>());
        }
    }
}

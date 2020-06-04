using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace Ninja.UnitTest
{
    [TestFixture]
    class Math_Tests
    {
        private Math _math;
        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }
        [Test]
        [Ignore("Activate Later")]/*Ignores the test but shows the message inn test explorer*/
        public void Add_Called_returnsTheSum()
        {
            int result  = _math.Add(1,2);

            Assert.That(result,Is.EqualTo(3));
        }
        [Test]
        [TestCase(1,2,2)]
        [TestCase(2,1,2)]
        [TestCase(1,1,1)]
        public void Max_Called_ReturnsTheGreaterParameter(int a,int b,int expectedRescult)
        {
            int result = _math.Max(a,b);

            Assert.That(result,Is.EqualTo(expectedRescult));
        }
        [Test]
        public void GetOddNumbers_CalledWithPositiveArgument_returnsOddNumberFromZeroToArgument()
        {
            var result = _math.GetOddNumbers(5);

            Assert.That(result, Is.EqualTo(new[] { 1,3,5}));
        }
        [Test]
        public void GetOddNumbers_CalledWithNegativeArgument_returnsEmpty()
        {
            var result = _math.GetOddNumbers(-5);

            Assert.That(result, Is.Empty);
        }
        [Test]
        public void GetOddNumbers_CalledWithZero_returnsEmpty()
        {
            var result = _math.GetOddNumbers(0);

            Assert.That(result, Is.Empty);
        }
    }
}

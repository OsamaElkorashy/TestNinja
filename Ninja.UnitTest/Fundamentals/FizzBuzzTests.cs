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
    class FizzBuzzTests
    {
        [TestCase(15,"FizzBuzz")]
        [TestCase(5,"Buzz")]
        [TestCase(3,"Fizz")]
        [TestCase(1,"1")]
        public void GetOutput_Called(int a,string expectedResult)
        {
            string result = FizzBuzz.GetOutput(a);

            Assert.That(result,Is.EqualTo(expectedResult));
        }
    }
}

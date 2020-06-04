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
    class ErrorLoggerTests
    {
        private ErrorLogger _errorLogger;
        /*instantiates this parameter with each case*/
        [SetUp]
        public void SetUp()
        {
            _errorLogger = new ErrorLogger();
        }
        [Test]
        public void Log_ValidError_SetLastErrorProberty()
        {
            _errorLogger.Log("a");

            Assert.That(_errorLogger.LastError, Is.EqualTo("a"));
        }
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_InvalidError_SetLastErrorProberty(string a)
        {
            Assert.That(()=> _errorLogger.Log(a), Throws.ArgumentNullException);
        }
        [Test]
        public void Log_ValidError_RaisesEvent()
        {
            var id = Guid.Empty;
            _errorLogger.ErrorLogged += (sender,args) => {
                id = args;
            };
            _errorLogger.Log("a");

            Assert.That(id, Is.Not.EqualTo(Guid.Empty));
        }
    }
}

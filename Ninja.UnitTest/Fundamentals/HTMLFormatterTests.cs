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
    class HTMLFormatterTests
    {
        [Test]
        public void FormatAsBold_Called_ReturnsStringEnclosedWithStrongTag()
        {
            HtmlFormatter htmlFormatter = new HtmlFormatter();

            var result = htmlFormatter.FormatAsBold("a");

            Assert.That(result,Is.EqualTo("<strong>A</strong>").IgnoreCase/*Ignores Case Sensetivity*/);
        }
    }
}

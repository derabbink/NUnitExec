using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace SomeLib.Test
{
    [TestFixture]
    public class OperationsTest
    {
        [Test]
        public void Increase5()
        {
            int inp = 5;
            int expected = 5 + 1;
            int actual = Operations.Increase(inp);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}

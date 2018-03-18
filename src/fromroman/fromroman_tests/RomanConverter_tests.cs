using System;
using fromroman;
using NUnit.Framework;

namespace fromroman_tests
{
    [TestFixture]
    public class RomanConverter_tests
    {
        [Test]
        public void Check_test()
        {
            RomanConverter.Convert("x");
        }
    }
}
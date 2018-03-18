using System;
using fromroman;
using NUnit.Framework;

namespace fromroman_tests
{
    [TestFixture]
    public class RomanConverter_tests
    {
        [TestCase("MCMLXXXIV", 1984)]
        [TestCase("MCDXCII", 1492)]
        public void Akzeptanztests(string roman, int translation) {
            Assert.AreEqual(translation, RomanConverter.Convert(roman));
        }
    }
}
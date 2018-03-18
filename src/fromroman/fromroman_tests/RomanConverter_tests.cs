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
        [TestCase("XVI", 16)] // nur Addition von Ziffernwerten
        [TestCase("M", 1000)] // nur 1 röm. Ziffer
        public void Akzeptanztests(string roman, int translation) {
            Assert.AreEqual(translation, RomanConverter.Convert(roman));
        }
    }
}
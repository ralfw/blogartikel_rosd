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


        [Test]
        public void Parse_with_all_digits()
        {
            Assert.AreEqual(new[]{1,100,5,10,1000,50,500}, RomanConverter.Parse("iCvXmLD"));
        }
        
        [Test]
        public void Parse_with_invalid_digit()
        {
            Assert.Throws<InvalidOperationException>(() => RomanConverter.Parse("a"));
        }
    }
}
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


        [TestCase(new[] {10, 5, 1}, new[] {10, 5, 1})]
        [TestCase(new[] {1, 5, 10}, new[] {-1, -5, 10})]
        public void Subtraktionsregel_anwenden(int[] values, int[] transformed)
        {
            Assert.AreEqual(transformed, RomanConverter.Subtract(values));            
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
using Xunit;

namespace RomanNumeralsCodingKata
{
    public class RomanNumeralsTest
    {


        [Fact]
        public void GivenArabicNumber1ReturnRomanNumeralI()
        {
            var items = 1;
            var expected = "I";
            
            Assert.Equal(expected,new RomanNumerals().ConvertArabicToRoman(items);
        }
    }
}
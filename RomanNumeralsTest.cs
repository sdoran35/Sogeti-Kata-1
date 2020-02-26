using System;
using Xunit;

namespace RomanNumeralsCodingKata
{
    public class RomanNumeralsTest
    {


        [Fact]
        public void GivenArabicNumber1ReturnRomanNumeralI()
        {
            1.ArabicToRoman("I");
        }

        [Fact]
        public void GivenArabicNumber3ReturnRomanNumeralIII()
        {
            3.ArabicToRoman("III");
        }

        


        [Fact]
        public void GivenArabicNumber9ReturnRomanNumeralIX()
        {
            9.ArabicToRoman("IX");
        }

        [Fact]
        public void GivenArabicNumer1066ReturnRomanNumeralMLXVI()
        {
           1066.ArabicToRoman("MLXVI");
            
        }

        [Fact]
        public void GivenArabicNumber1989ReturnRomanNumeralMCMLXXXIX()
        {
            1989.ArabicToRoman("MCMLXXXIX");
        }


        [Fact]
        public void GivenRomanIReturn1()
        {
            "I".RomanToArabic(1);
        }

        [Fact]
        public void GivenRomanIIIReturn3()
        {
            "III".RomanToArabic(3);
        }

        [Fact]
        public void GivenRomanIXReturn9()
        {
            "IX".RomanToArabic(9);
        }

        [Fact]
        public void GivenRomanMLXVIReturn1066()
        {
            "MLXVI".RomanToArabic(1066);
        }

        [Fact]
        public void GivenRomanMCMLXXXIXReturn1989()
        {
            "MCMLXXXIX".RomanToArabic(1989);
        }

    }
    
    internal static class TestHelper
    {
        public static void ArabicToRoman(this int input, string expected)
        {
            var item = new RomanNumerals();
            Assert.Equal(expected,RomanNumerals.ArabicToRoman(input));
            
        }

        public static void RomanToArabic(this string input, int expected)
        {
            var item = new RomanNumerals();
            Assert.Equal(expected,RomanNumerals.RomanToArabic(input));
        }
    }
}
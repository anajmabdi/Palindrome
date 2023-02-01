using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;
using System;

namespace Palindrome.Test
{
    [TestClass]
    public class ReverseMethodTests
    {
        [TestMethod]
        public void ReverseMethod_TakesInString_True()
        {
            ReverseMethod testPalindrome = new ReverseMethod();
            Assert.AreEqual(true, testPalindrome.IsPalindrome("word"));
        }
        [TestMethod]
        public void ReverseMethod_ReverseString_True()
        {
          ReverseMethod testPalindrome = new ReverseMethod();
          Assert.AreEqual(true, testPalindrome.IsPalindrome("level"));
        }
    }
}
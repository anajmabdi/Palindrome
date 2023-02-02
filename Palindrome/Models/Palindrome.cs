using System;
using System.Linq;

namespace Palindrome.Models
{
  public class ReverseMethod
  {
    public bool IsPalindrome(string word)
    {
      char[] reversed = word.ToCharArray(); 
      Array.Reverse(reversed);
      return word.SequenceEqual(reversed);
    }
  }
}
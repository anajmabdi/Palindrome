using System;
using System.Linq;

namespace Palindrome
{
  public class ReverseMethod
  {
    public bool IsPalindrome(string word)
    {
      string reversed = String.Split((string)word.Clone());  
      Array.Reverse(reversed);
      return word.SequenceEqual(reversed);
    }
  }
}

//bool IsReversed(int[] arr) {
  //int[] reversed = (int[])arr.Clone();
  //Array.Reverse(reversed);
  //return arr.SequenceEqual(reversed);
//} 
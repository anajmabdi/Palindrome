using System;
using Palindrome.Models;

namespace Palindrome
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter a word:");
      string userInput = Console.ReadLine();
      ReverseMethod input = new ReverseMethod();
      input.IsPalindrome(userInput);

      if (input.IsPalindrome(userInput) == false)
      {
        Console.WriteLine("Not a Palindrome");
      }
      else 
      {
        Console.WriteLine("Palindrome");
      }
    }
  }
}
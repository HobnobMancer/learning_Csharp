using System;

/* this is a multi-line comment, which continues over
multiple
lines */
namespace GettingInput
// this is a single line comment
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("How old are you?");
      string input = Console.ReadLine();
      Console.WriteLine($"You are {input} years old!");
    }
  }
}

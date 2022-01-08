using System;

namespace Review
{
  class Program
  {
    static void Main(string[] args)
    {
      /* use this space to write your own short program! 
      Here's what you learned:

      DATA TYPES: int, double, char, string, bool
      VARIABLES: datatype variableName = value;
      COMMON ERRORS: wrong type, wrong value, no semicolon
      DATA TYPE CONVERSION: implicit, explicit, methods

      Good luck! */
      Console.Write("What is your name:");
      string name = Console.ReadLine();

      Console.Write("How old are you:");

      int age = Convert.ToInt32(Console.ReadLine());
      int year = 2022;
      int dob_number = year - age;
      string dob = Convert.ToString(dob_number);

      Console.Write("Your name is ", name, "and you are were born", dob);
    }
  }
}

using System;

namespace fizzbuzz
{
  class Program
  {
    static void Main(string[] args)
    {
      string outstring = string.Empty;

      for (int i = 1; i < 101; i++)
      {

        if (i % 3.0 == 0) outstring = "Fizz";
        if (i % 5.0 == 0) outstring = outstring + "Buzz";

        if (outstring.Length == 0) Console.WriteLine(i);
        else Console.WriteLine(outstring);
        outstring = "";
      }
      Console.ReadLine();
    }
  }
}

using System;

namespace helloworld
{
  class Program
  {
    static void Main(string[] args)
    {
      // Hello World
      HighlightedTitle("Hello World");
      Console.WriteLine("Hello, World!");
      Console.WriteLine();
    }

    static void HighlightedTitle(string x)
    {
      Console.ForegroundColor = ConsoleColor.DarkBlue;
      Console.WriteLine($"[ {x.ToUpper()} ]");
      Console.ForegroundColor = ConsoleColor.White;
    }
  }
}
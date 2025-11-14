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
      Next();
      Console.WriteLine("Okay, this works. Sick.");
    }

    static void HighlightedTitle(string x)
    {
      Console.ForegroundColor = ConsoleColor.DarkBlue;
      Console.WriteLine($"[ {x.ToUpper()} ]");
      Console.ForegroundColor = ConsoleColor.White;
    }

    static void Next()
    {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("Press ENTER to continue...");
      Console.ForegroundColor = ConsoleColor.White;
      Console.ReadLine();
      Console.Clear();
    }
  }
}
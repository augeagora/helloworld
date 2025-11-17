using System;

namespace helloworld
{
  class Program
  {
    static void Main(string[] args)
    {
      // Hello World
      HighlightedTitle("Hello World");
      HelloWorld();
      Next();

      // Strings
      HighlightedTitle("Strings");
      Strings();
      Next();

      // This is just for testing
      Console.WriteLine("Reached the end for now...");
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

    static void HelloWorld()
    {
      Console.WriteLine("Hello, World!");
      Console.WriteLine();
    }

    static void Strings()
    {
      string firstFriend = "Erick";
      string secondFriend = "Antoine";
      string friends = $"My friends are {firstFriend} and {secondFriend}.";
      Console.WriteLine(friends);
      Console.WriteLine();
    }
  }
}
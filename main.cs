using System;

class Program {
  public static void Main (string[] args) {
    
    // Twitter's Starting Message
    
    Console.WriteLine("What\'s Happening?");
    
    // Skiping a line for better vizualiation
    Console.WriteLine("");

    // User Input
    string txt = Console.ReadLine();

    // Skiping a line for better vizualiation
    Console.WriteLine("");

    // If else statements
    
    if (txt.Length <= 140)
    {
      Console.WriteLine("Posted");
    }
    else
    {
      Console.WriteLine("Rejected");
    }
    
  }
}
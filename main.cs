using System;

class Program {
  public static void Main (string[] args) {
    var unitTestOne = string.Join(
      Environment.NewLine,
      "Oh, well imagine /",
       "As I'm pacing the pews in a church corridor /",
       "And I can't help but to hear /",
       "No, I can't help but to hear an exchanging of words...");
    //Console.WriteLine (unitTestOne);
    
    var unitTestTwo = string.Join(
      Environment.NewLine,
       "Oh-oh-oh-oh-oh,",
       "oh-oh-oh-oh,",
       "oh-oh-oh /",
       "Caught in a bad romance...");
    //Console.WriteLine (unitTestTwo);
    
    var unitTestThree = string.Join(
      Environment.NewLine,
       "Coming out of my cage",
       "And I've been doing just fine",
       "Gotta gotta be down",
       "Because I want it all");
    //Console.WriteLine (unitTestThree);
    
    var unitTestFour = string.Join(
      Environment.NewLine,
       "Now, this is a story all about how",
       "My life got flipped-turned upside down",
       "And I'd like to take a minute",
       "Just sit right there",
       "I'll tell you how I became the prince of a town called Bel-Air");
    Console.WriteLine (unitTestFour);
  }
}
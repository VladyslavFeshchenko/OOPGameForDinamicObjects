using NConsoleGraphics;
using System;

namespace OOPGame {

  public class Program {

    static void Main(string[] args) {

      Console.WindowWidth = Console.WindowWidth;
      Console.WindowHeight = Console.WindowHeight;
      Console.SetBufferSize(Console.WindowWidth, Console.WindowHeight);
      Console.BackgroundColor = ConsoleColor.White;
      Console.CursorVisible = false;
      Console.Clear();

      ConsoleGraphics graphics = new ConsoleGraphics();

      GameEngine engine = new SampleGameEngine(graphics);
      engine.Start();
    }
  }
}

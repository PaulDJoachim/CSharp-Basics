using System;
using SadConsole;
using Microsoft.Xna.Framework;
using Console = SadConsole.Console;

namespace SadConsoleGame
{
  class Game
  {
    static void Main()
    {

      // Setup the engine and create the main window.
      SadConsole.Game.Create(80, 25);

      // Hook the start event so we can add consoles to the system.
      SadConsole.Game.OnInitialize = Init;

      // Start the game.
      SadConsole.Game.Instance.Run();
      SadConsole.Game.Instance.Dispose();
    }

    static void Init()
    {
      var console = new Console(80, 25);

      // New code starts here
      console.SetBackground(2, 2, Color.DarkGray);
      console.SetGlyph(2, 2, 1);
      console.SetForeground(2, 2, Color.DarkBlue);
      console.SetMirror(2, 2, Microsoft.Xna.Framework.Graphics.SpriteEffects.FlipVertically);

      console.DrawLine(new Point(2, 4), new Point(20, 6), Color.BlueViolet, Color.White, 4);
      console.DrawCircle(new Rectangle(20, 10, 16, 16), new Cell(Color.BlueViolet, Color.White, 4));


      SadConsole.Global.CurrentScreen = console;
    }
  }
}
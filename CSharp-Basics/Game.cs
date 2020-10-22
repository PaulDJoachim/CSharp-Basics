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
      SadConsole.Game.Create("../fonts/terminal8x8.font", 120, 75);

      // Hook the start event so we can add consoles to the system.
      SadConsole.Game.OnInitialize = Init;

      // Start the game.
      SadConsole.Game.Instance.Run();
      SadConsole.Game.Instance.Dispose();
    }

    static void Init()
    {
      var blister = new MapScreen();
      Global.CurrentScreen = blister.MapConsole;
      blister.MapConsole.Cursor.Position = new Point(0, 2);
      SadConsole.Global.FocusedConsoles.Set(blister.MapConsole);
    }
  }
}
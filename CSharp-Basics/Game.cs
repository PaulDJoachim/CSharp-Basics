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
      Global.CurrentScreen = new MapScreen();
      // set the currect screen to be "Focused" so keyboard input will be sent to it.
      Global.CurrentScreen.IsFocused = true;

      var biggy = new WorldGen();

    }
  }
}
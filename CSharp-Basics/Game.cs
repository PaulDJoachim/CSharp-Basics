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
      // font setup
      var fontMaster = SadConsole.Global.LoadFont("../fonts/terminal8x8.font");
      var normalSizedFont = fontMaster.GetFont(SadConsole.Font.FontSizes.One);

      var console = new Console(80, 50, normalSizedFont);
      Global.CurrentScreen = new MapScreen();

    }
  }
}
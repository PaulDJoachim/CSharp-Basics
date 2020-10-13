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
      var fontMaster = SadConsole.Global.LoadFont("../fonts/qbicfeet_10x10.font");
      var normalSizedFont = fontMaster.GetFont(SadConsole.Font.FontSizes.Two);

      var console = new Console(80, 25, normalSizedFont);
      console.IsFocused = true;
      console.Cursor.IsVisible = true;
      console.Components.Add(new MyKeyboardComponent());

      SadConsole.Global.CurrentScreen = console;
    }
  }
}
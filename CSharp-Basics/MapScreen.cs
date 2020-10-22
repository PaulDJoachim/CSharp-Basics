using System;
using System.Collections.Generic;
using SadConsole;
using Microsoft.Xna.Framework;

// because there is also a console class within the "System" namespace, we define Console to default with the SadConsole namespace
using Console = SadConsole.Console;

// namespace is used for organization. Namspaces hold classes and are made available with the "using" statement
namespace SadConsoleGame
{
  // The colon after the class name designates inheritance from ContainerConsole
  class MapScreen : ContainerConsole
  {
    // This is a get-only automatic property
    public Console MapConsole { get; }

    // This is another automatic property
    public Cell PlayerGlyph { get; set; }

    // This is a 2-dimensional private point field
    private Point _playerPosition;

    // This is the public point property
    public Point PlayerPosition
    {
      get => _playerPosition;
      // when the player position is set we want to clear content at the old position and copy the player glyph to the new position
      private set
      {
        MapConsole.Clear(_playerPosition.X, _playerPosition.Y);
        _playerPosition = value;
        PlayerGlyph.CopyAppearanceTo(MapConsole[_playerPosition.X, _playerPosition.Y]);
      }
    }

    // This is a custom constructor
    public MapScreen()
    {
      // font setup
      var fontMaster = SadConsole.Global.LoadFont("../fonts/terminal8x8.font");
      var normalSizedFont = fontMaster.GetFont(SadConsole.Font.FontSizes.One);


      var mapConsoleWidth = (int)((Global.RenderWidth / normalSizedFont.Size.X) * 1.0);
      var mapConsoleHeight = (int)((Global.RenderHeight / normalSizedFont.Size.Y) * 1.0);

      System.Console.WriteLine(Global.RenderWidth);
      System.Console.WriteLine(Global.RenderHeight);

      // Setup map
      MapConsole = new Console(mapConsoleWidth, mapConsoleHeight, normalSizedFont);
      MapConsole.DrawBox(new Microsoft.Xna.Framework.Rectangle(0, 0, MapConsole.Width, MapConsole.Height), new Cell(Color.White, Color.DarkGray, 0));
      MapConsole.Parent = this;

      // Setup player
      PlayerGlyph = new Cell(Color.White, Color.Black, 1);
      _playerPosition = new Point(4, 4);
      PlayerGlyph.CopyAppearanceTo(MapConsole[_playerPosition.X, _playerPosition.Y]);


      MapConsole.Parent = this;
    }
  }
}
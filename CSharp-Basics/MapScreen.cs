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
    // This is an automatic property that allows us 
    public Console MapConsole { get; }

    public Cell PlayerGlyph { get; set; }

    private Point _playerPosition;
    public Point PlayerPosition
    {
      get => _playerPosition;
      private set
      {
        MapConsole.Clear(_playerPosition.X, _playerPosition.Y);
        _playerPosition = value;
        PlayerGlyph.CopyAppearanceTo(MapConsole[_playerPosition.X, _playerPosition.Y]);
      }
    }

    public MapScreen()
    {
      // font setup
      var fontMaster = SadConsole.Global.LoadFont("../fonts/terminal8x8.font");
      var normalSizedFont = fontMaster.GetFont(SadConsole.Font.FontSizes.One);

      var mapConsoleWidth = (int)((Global.RenderWidth / Global.FontDefault.Size.X) * 1.0);
      var mapConsoleHeight = (int)((Global.RenderHeight / Global.FontDefault.Size.Y) * 1.0);

      // Setup map
      MapConsole = new Console(mapConsoleWidth, mapConsoleHeight);
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
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using SadConsole;
using Console = SadConsole.Console;

namespace SadConsoleGame
{
  class WorldGen
  {

    // This is a get-only automatic property
    public Console WorldMap { get; }
    public WorldGen()
    {
      var worldWidth = 1000;
      var worldHeight = 1000;

      WorldMap = new Console(worldWidth, worldHeight);

      for (int i = 0; i <= WorldMap.Height; i++)
      {
        for (int j = 0; j <= WorldMap.Width; j++)
        {
          if (i % 8 == 0 && i > 0 && j % 8 == 0 && j > 0)
          {
            WorldMap.DrawBox(new Microsoft.Xna.Framework.Rectangle(j, i, 5, 5), new Cell(Color.White, Color.DarkGray, 0));
          }
        }
      }
      System.Console.WriteLine(WorldMap.GetCells(new Microsoft.Xna.Framework.Rectangle(1,1,20,20)));
    }
  }
}

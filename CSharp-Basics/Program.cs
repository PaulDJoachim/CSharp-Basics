using System;

namespace CSharp_Basics
{
  class Program
  {
    static void Main(string[] args)
    {

      // Settings
      Console.SetWindowSize(150,50);
      Console.BufferWidth = 151;
      Console.BufferHeight = 51;

      //Ints:
      int Gameover = 0;
      int width = Console.WindowWidth;

      // Randoms:
      Random Random = new Random();

      //Strings:
      string Draw_Char = "X";
      string[,] Draw_Game_Map = new string[239, 77];

      //Game Array
      var displayArray = new string[Console.WindowWidth, Console.WindowHeight];

      //Program:
      do
      {

        for (int y=0; y < Console.WindowHeight; y++)
        {
          for (int x=0; x < Console.WindowWidth; x++)
          {
          displayArray[x,y] = ".";
          }
        }

        displayArray[5, 5] = "@";

        for (int y=0; y < displayArray.GetLength(1); y++)
        {
          for (int x=0; x < displayArray.GetLength(0); x++)
          {
            Console.Write(displayArray[x, y]);
          }
          Console.WriteLine();
        }


        Console.ReadLine();
      } while (Gameover == 0);

    }
  }
}

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

      //Program:
      do
      {
        //Console.Clear();
        for (int i=0; i < Console.WindowHeight; i++)
        {
          for (int j=0; j < Console.WindowWidth; j++)
          {
          Console.Write(".");
          }
          Console.WriteLine();
        }
        Console.ReadLine();
      } while (Gameover == 0);

    }
  }
}

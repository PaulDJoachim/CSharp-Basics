using System;

namespace CSharp_Basics
{
  class Program
  {
    static void Main(string[] args)
    {

      // Settings
      Console.BufferHeight = 400;
      Console.BufferWidth = 400;
      Console.SetWindowSize(150,50);

      //Ints:
      int Char_Health_Full = 100;
      int Char_Health_Current = 100;
      int score = 0;
      int Gameover = 0;

      // Randoms:
      Random Random = new Random();


      //Strings:
      string Draw_Char = "X";
      string[,] Draw_Game_Map = new string[239, 77];

      //Program:
      do
      {
        //Console.Clear();
        Console.Write('t');
      } while (Gameover == 0);

    }
  }
}

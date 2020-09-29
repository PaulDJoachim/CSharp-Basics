using System;

namespace CSharp_Basics
{
  class Program
  {
    static void Main(string[] args)
    {
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
        Console.Clear();  
        int Spawn_Point_Generator_X = Random.Next (0, 230);
        int Spawn_Point_Generator_Y = Random.Next (0, 77);
        int Spawn_Point_Height = Random.Next(5, 8);
        int Spawn_Point_Width = Random.Next(7, 10);

        for (int x = 0; x <= Spawn_Point_Height; x++)
        {
          for (int y = 0; y <= Spawn_Point_Width; y++)
          {
            if(y == 0 || y == Spawn_Point_Height-1)
            {
              Draw_Game_Map[Spawn_Point_Generator_X+x, Spawn_Point_Generator_Y+y] = "_";
            }
            else
            {
              if(x == 0 || x == Spawn_Point_Width)
              {
                Draw_Game_Map[Spawn_Point_Generator_X + x, Spawn_Point_Generator_Y + y] = "|";
              }
            }
          }
        }
        for (int x_Draw = 0; x_Draw <= 229; x_Draw++)
        {
          for (int y_Draw = 0; y_Draw <= 76; y_Draw++)
          {
            Console.Write(Draw_Game_Map[x_Draw, y_Draw]);
          }
        }
        Console.ReadLine();
      } while (Gameover == 0);

    }
  }
}

﻿using System;
using System.Collections.Generic;
using System.Text;
using SadConsole.Components;
using SadConsole.Input;
using Microsoft.Xna.Framework;

namespace SadConsoleGame
{
  class MyKeyboardComponent: KeyboardConsoleComponent
  {
    public override void ProcessKeyboard(SadConsole.Console console, Keyboard info, out bool handled)
    {
      if (info.IsKeyPressed(Microsoft.Xna.Framework.Input.Keys.Space))
      {
        console.DefaultBackground = Color.White.GetRandomColor(SadConsole.Global.Random);
        console.Clear();
      }
      handled = false;
    }
  }
}

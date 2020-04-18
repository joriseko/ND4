using System;
using System.Collections.Generic;
using System.Text;

namespace ND4.Show
{
    class Frame : GuiObject
    {

        PlayerSelectionMenu playerSelectionMenu = new PlayerSelectionMenu();
       

        public Frame(int x, int y, int px, int py) : base(x, y, px, py)
        {

        }

        public void Render()
        {
            Console.SetCursorPosition(X, Y);
         
        }


    }
}

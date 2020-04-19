using System;
using System.Collections.Generic;
using System.Text;

namespace ND4.Show
{
    abstract class GuiObject
    {

        public int X { get; set; }
        public int Y { get; set; }
        public int PX { get; set; } //player X
        public int PY { get; set; } //player Y

        public GuiObject(int x, int y, int px, int py)
        {
            X = x;
            Y = y;
            PX = px;
            PY = py;
        }
        abstract public void Render();

    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace ND4.Show
{
    class Frame
    {
        public bool IsActive { get; private set; } = false;
        private int x;
        private int y;
        public int Pls;

        

        public Frame(int x, int y, int Pls)
        {
            this.x = x;
            this.y = y;
            this.Pls = Pls;
            

        }



        public void Render()
        {
            if (IsActive)
            {
                Console.SetCursorPosition(x - 1, y);
                Console.Write('>');
                Console.Write(Pls);
            }
            else
            {
                Console.SetCursorPosition(x, y);
                Console.Write(Pls);

            }


        }

        public void SetActive()
        {
            IsActive = true;
        }
        public void SetInactive()
        {
            IsActive = false;
        }

    }
}

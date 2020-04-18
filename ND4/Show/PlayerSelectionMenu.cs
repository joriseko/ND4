using System;
using System.Collections.Generic;
using System.Text;

namespace ND4.Show
{
    class PlayerSelectionMenu : GuiObject
    {
        private int[,] arrPlayer;

        private Frame activePlayer;

        public PlayerSelectionMenu() : base(0, 0, 0, 0)
        {


         //   activePlayer = new Frame(10, 0, 0, 1);

            arrPlayer = new int[2, 3]
        { {2, 3, 4},
          {5, 6, 7}};

        }

        public void Players()
        {
            for (int i = 0; i < 3; i++)
            {
                int y = i + 5;
                Console.SetCursorPosition(y + 5, 0);
                Console.WriteLine(arrPlayer[0, 0]);
                Console.SetCursorPosition(y + 5, 1);
                Console.WriteLine(arrPlayer[1, 0]);
            }
        }




        public void P()
        {
            activePlayer.Render();
            Console.WriteLine(arrPlayer[0, 0]);
        }





    }
}

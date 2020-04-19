using System;
using System.Collections.Generic;
using System.Text;

namespace ND4.Show
{
    class PlayerSelectionMenu
    {
        private Frame frame;
        
        private int[,] arrPlayer;

        private Frame activePlayer1;
        private Frame activePlayer2;
        private Frame activePlayer3;
        private Frame activePlayer4;
        private Frame activePlayer5;
        private Frame activePlayer6;

        private List<Frame> frames = new List<Frame>();

        public PlayerSelectionMenu()
        {
           
            arrPlayer = new int[2, 3]
          { {2, 3, 4},
           {5, 6, 7}};

            frames.Add(new Frame(10, 0, 2));
            frames.Add(new Frame(20, 0, 3));
            frames.Add(new Frame(30, 0, 4));
            frames.Add(new Frame(10, 1, 5));
            frames.Add(new Frame(20, 1, 6));
            frames.Add(new Frame(30, 1, 7));

        }


        public void P()
        {
            frames[0].Render();    
            frames[1].SetActive();
            frames[1].Render();
            frames[2].Render();
            frames[3].Render();
            frames[4].Render();
            frames[5].Render();
    
        }

        public void any()
        { Console.WriteLine(frames[0].Pls); }



    }
}

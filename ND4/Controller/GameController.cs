using ND4.Dice_Player;
using ND4.Show;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ND4.Controller
{
    class GameController
    {
        Dice dice;
        GameOverMenu gameOverMenu = new GameOverMenu();

        private int players;
        private int dices;
        private int count=1;
        private int maxSum;
        private int whichPlayerWon;

        public GameController(int players, int dices)
        {
            this.players = players;
            this.dices = dices;
        }

        

        public void StartPlay()
        {
            bool needToThrowAgain;
            do
            {
                needToThrowAgain = false;
                dice = new Dice(dices);
                for (int i = 1; i <= players; i++)
                {
                    Console.Write("Player" + i + " thrown dice --- ");
                    dice.playersThrowDice();
                }

                for (int i = 0; i < dice.dices.Count; i++)
                {
                    for (int j = i + 1; j < dice.dices.Count; j++)
                    {
                        if (dice.dices[i] == dice.dices[j])
                        {
                            count++;
                            Console.WriteLine();
                            Console.WriteLine("Roll dice till winner is clear!!!");
                            System.Threading.Thread.Sleep(200);
                            needToThrowAgain = true;
                            Console.Clear();
                            
                        }
                    }
                }
                maxSum = dice.dices.Max();
                whichPlayerWon = dice.dices.IndexOf(maxSum)+1;
                
                

            } while (needToThrowAgain);

            gameOverMenu.StartEndMenu(count, whichPlayerWon);

        }





    }
}

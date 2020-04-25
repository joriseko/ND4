using ND4.Show;
using System;
using System.Collections.Generic;
using System.Text;

namespace ND4.Dice_Player
{
    class Dice
    {

        public List<int> dices = new List<int>();

        private int dice;
        public Dice(int dice)
        {
            this.dice = dice;

        }

        public void showdice()
        { Console.WriteLine(dice); }



        public void playersThrowDice()
        {
            int playersDiceSum = 0;
            for (int i = 1; i <= dice; i++)
            {
                Random rnd = new Random();
                int eyesRolled = rnd.Next(1, 7);
                playersDiceSum += eyesRolled;
                Console.Write($"{eyesRolled} ");
                System.Threading.Thread.Sleep(1000);
            }
            Console.Write($"--- sum {playersDiceSum}");
            Console.WriteLine();
            dices.Add(playersDiceSum);
        }

    }
}

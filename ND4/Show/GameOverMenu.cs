using ND4.Controller;
using System;
using System.Collections.Generic;
using System.Text;

namespace ND4.Show
{
    class GameOverMenu
    {

        private GameController gameController;
        private Menu menu= new Menu();
        private PlayerSelectionMenu playerSelectionMenu = new PlayerSelectionMenu();

        private int player;
        private int dice;


        public GameOverMenu()
        {
           // this.player = player;
           // this.dice = dice;


        }


        public void StartEndMenu(int count, int whichWon)
        {
            
            bool needToRender = true;
            Console.WriteLine();
            Console.WriteLine($"The winner is Player{whichWon} after {count} round/s!!!");
            Console.WriteLine();
            Console.WriteLine("R-replay \nM-go to menu \nQ-quit");
            do
            {

                while (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedChar = Console.ReadKey(true);
                    int hashCode = pressedChar.Key.GetHashCode();


                    switch (pressedChar.Key)
                    {
                        case ConsoleKey.R:
                            Console.Clear();
                           // gameController = new GameController(player, dice);
                           // gameController.StartPlay();
                            playerSelectionMenu.PlayerStart();
                            needToRender = false;
                            break;
                        case ConsoleKey.M:
                            Console.Clear();
                            menu.ShowMenu();
                            needToRender = false;
                            break;
                        case ConsoleKey.Q:
                            Environment.Exit(1);
                            break;
                    }
                }
            } while (needToRender);
        }



    }
}

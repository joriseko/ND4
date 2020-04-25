using ND4.Controller;
using ND4.Dice_Player;
using System;
using System.Collections.Generic;
using System.Text;

namespace ND4.Show
{
    class DiceSelectionMenu
    {

        Dice dice;
        Player player;
        GameOverMenu gameOverMenu;


        public DiceSelectionMenu()
        {

        }


        public void StartDiceMenuLoop(int P)
        {
            Console.CursorVisible = false;
            int D = 3;
            bool needToRender = true;
            void Plus()
            {
                D++;
            }

            void Minus()
            {
                D--;
            }

            Console.WriteLine($"Players will have {D} dice (+/-).");
            do
            {

                while (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedChar = Console.ReadKey(true);
                    int hashCode = pressedChar.Key.GetHashCode();


                    switch (pressedChar.Key)
                    {
                        case ConsoleKey.OemPlus:
                            Plus();
                            Console.Clear();
                            Console.WriteLine($"Players will have {D} dice (+/-).");
                            break;
                        case ConsoleKey.OemMinus:
                            Minus();
                            if (D > 0)
                            {
                                Console.Clear();
                                Console.WriteLine($"Players will have {D} dice (+/-).");
                            }
                            else
                            {
                                Console.Clear();
                                D = 1;
                                Console.WriteLine($"Players will have {D} dice (+/-).");
                            }

                            break;
                        case ConsoleKey.Enter:
                            Console.Clear();
                            needToRender = false;
                            GameController gameController = new GameController(P, D);
                           // GameOverMenu gameOverMenu = new GameOverMenu(P, D);
                            gameController.StartPlay();
                            break;
                    }
                }
            } while (needToRender);





        }
    }
}

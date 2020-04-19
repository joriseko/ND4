using System;
using System.Collections.Generic;
using System.Text;

namespace ND4.Show
{
    class Menu
    {

        private DiceSelectionMenu diceSelectionMenu;
        private PlayerSelectionMenu playerSelectionMenu;


        public Menu()
        {
            playerSelectionMenu = new PlayerSelectionMenu();
            diceSelectionMenu = new DiceSelectionMenu();

        }

        public void ShowMenu()
        {
            Console.CursorVisible = false;
            StartMenuLoop();
        }

        private void StartMenuLoop()
        {
            char mMenuChar;
            bool needToRender= true;

            Console.WriteLine("To start the game press P=play, Q=quit");
            do
            {
                
                while (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedChar = Console.ReadKey(true);
                    int hashCode = pressedChar.Key.GetHashCode();


                    switch (pressedChar.Key)
                    {
                        case ConsoleKey.P:
                            mMenuChar = 'P';
                            Console.Clear();
                          //  Console.WriteLine(mMenuChar);
                            playerSelectionMenu.P();
                            playerSelectionMenu.any();
                            needToRender = false;
                            break;
                        case ConsoleKey.Q:
                            mMenuChar = 'Q';
                            Console.Clear();
                            Console.WriteLine(mMenuChar);
                            Environment.Exit(1);
                            break;
                        case ConsoleKey.T:
                            mMenuChar = 'T';
                            Console.Clear();
                            Console.WriteLine(mMenuChar);
                            diceSelectionMenu.ShowDiceMenu();
                            break;
                    }
                }
            } while (needToRender);

          

        }





    }
}

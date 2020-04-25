using System;
using System.Collections.Generic;
using System.Text;

namespace ND4.Show
{
    class Menu
    {

 
        private PlayerSelectionMenu playerSelectionMenu;



        public Menu()
        {
            playerSelectionMenu = new PlayerSelectionMenu();

        }

        public void ShowMenu()
        {
            Console.CursorVisible = false;
            StartMenuLoop();
        }

        private void StartMenuLoop()
        {
            bool needToRender = true;
            Console.WriteLine();
            Console.WriteLine("To start the game press P-play, Q-quit");
            do
            {

                while (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedChar = Console.ReadKey(true);
                    int hashCode = pressedChar.Key.GetHashCode();


                    switch (pressedChar.Key)
                    {
                        case ConsoleKey.P:
                            Console.Clear();
                            playerSelectionMenu.PlayerStart();
                            needToRender = false;
                            break;
                        case ConsoleKey.Q:
                            Console.Clear();
                            Environment.Exit(1);
                            break;
                    }
                }
            } while (needToRender);



        }





    }
}

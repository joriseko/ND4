using ND4.Controller;
using System;
using System.Collections.Generic;
using System.Text;

namespace ND4.Show
{
    class PlayerSelectionMenu
    {


        //private List<MenuController> menuControllers = new List<MenuController>();
        private List<MenuController> menuControllers = new List<MenuController>();
        private DiceSelectionMenu diceSelectionMenu = new DiceSelectionMenu();

        public PlayerSelectionMenu()
        {

            menuControllers.Add(new MenuController(10, 1, 2));
            menuControllers.Add(new MenuController(20, 1, 3));
            menuControllers.Add(new MenuController(30, 1, 4));
            menuControllers.Add(new MenuController(10, 2, 5));
            menuControllers.Add(new MenuController(20, 2, 6));
            menuControllers.Add(new MenuController(30, 2, 7));

        }

        public void PlayerStart()
        {
            Console.WriteLine("Choose how many players to have (arrows up/down/left/right): ");
            Players();
            StartPlayerMenuLoop();
        }


        public void Players()
        {
            menuControllers[0].SetActive();
            menuControllers[0].Render();
            menuControllers[1].Render();
            menuControllers[2].Render();
            menuControllers[3].Render();
            menuControllers[4].Render();
            menuControllers[5].Render();
        }

        private void StartPlayerMenuLoop()
        {
            
            int P = 0;
            void MoveRight()
            {
                P++;
            }
            void MoveLeft()
            {
                P--;
            }
            void MoveDown()
            {
                P += 3;
            }
            void MoveUp()
            {
                P -= 3;
            }

            bool needToRender = true;

            do
            {
                while (Console.KeyAvailable || needToRender)
                {
                    
                    ConsoleKeyInfo pressedChar = Console.ReadKey(true);
                    int hashCode = pressedChar.Key.GetHashCode();
                   
                    switch (pressedChar.Key)
                    {

                        case ConsoleKey.RightArrow:
                            MoveRight();
                            if (P <= 5)
                            {
                                OldInactive(P - 1);
                                NewActive(P);
                            }
                            else
                            {
                                OldInactive(P - 1);
                                NewActive(0);
                                P = 0;
                            }
                            break;
                        case ConsoleKey.LeftArrow:
                            MoveLeft();
                            if (P >= 0)
                            {
                                OldInactive(P + 1);
                                NewActive(P);
                            }
                            else
                            {
                                OldInactive(0);
                                NewActive(5);
                                P = 5;
                            }
                            break;
                        case ConsoleKey.DownArrow:
                            MoveDown();
                            if (P > 2 && P < 6)
                            {
                                OldInactive(P - 3);
                                NewActive(P);
                            }
                            else
                            {
                                NewActive(P - 3);
                                P = P - 3;
                            }
                            break;
                        case ConsoleKey.UpArrow:
                            MoveUp();
                            if (P >= 0 && P < 3)
                            {
                                OldInactive(P + 3);
                                NewActive(P);
                            }
                            else
                            {
                                NewActive(P + 3);
                                P = P + 3;
                            }
                            break;
                        case ConsoleKey.Enter:
                            Console.Clear();
                            diceSelectionMenu.StartDiceMenuLoop(menuControllers[P].Pls);
                            needToRender = false;
                            break;
                    } 
                }
            } while (needToRender);



            void NewActive(int y)
            {
                menuControllers[y].SetActive();
                menuControllers[y].Render();
            }

            void OldInactive(int y)
            {
                menuControllers[y].SetInactive();
                menuControllers[y].Render();
            }




        }
    }
}

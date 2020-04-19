using System;
using System.Collections.Generic;
using System.Text;

namespace ND4.Show
{
    class PlayerSelectionMenu
    {
        private Frame frame;

        //private int[,] arrPlayer;


        private List<Frame> frames = new List<Frame>();

        public PlayerSelectionMenu()
        {

            //   arrPlayer = new int[2, 3]
            // { {2, 3, 4},
            // {5, 6, 7}};

            frames.Add(new Frame(10, 0, 2));
            frames.Add(new Frame(20, 0, 3));
            frames.Add(new Frame(30, 0, 4));
            frames.Add(new Frame(10, 1, 5));
            frames.Add(new Frame(20, 1, 6));
            frames.Add(new Frame(30, 1, 7));

        }

        public void PlayerStart()
        {
            P();
            StartPlayerMenuLoop();
        }


        public void P()
        {
            frames[0].SetActive();
            frames[0].Render();
            frames[1].Render();
            frames[2].Render();
            frames[3].Render();
            frames[4].Render();
            frames[5].Render();
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
                    } 
                }
            } while (needToRender);



            void NewActive(int y)
            {
                frames[y].SetActive();
                frames[y].Render();
            }

            void OldInactive(int y)
            {
                frames[y].SetInactive();
                frames[y].Render();
            }




        }
    }
}

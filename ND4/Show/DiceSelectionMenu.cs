using System;
using System.Collections.Generic;
using System.Text;

namespace ND4.Show
{
    class DiceSelectionMenu
    {



        public DiceSelectionMenu()
        {



        }

        public void ShowDiceMenu()
        {
            Console.CursorVisible = false;
            StartDiceMenuLoop();
        }

        private void StartDiceMenuLoop()
        {
            int D = 1;
            bool needToRender = true;
            void Plus()
            {
                D++;
            }

            void Minus()
            {
                D--;
            }

            Console.WriteLine($"Choose how many dice to throw: {D}");
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
                            Console.WriteLine($"Choose how many dice to throw: {D}");
                            break;
                        case ConsoleKey.OemMinus:
                            Minus();
                            if (D > 0)
                            {
                                Console.Clear();
                                Console.WriteLine($"Choose how many dice to throw: {D}");
                            }
                            else
                            {
                                Console.Clear();
                                D = 1;
                                Console.WriteLine($"Choose how many dice to throw: {D}");
                            }

                            break;
                    }
                }
            } while (needToRender);





        }
    }
}

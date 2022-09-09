using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keyboard_Controlled_Menu
{
    class Menu
    {
        private int selectedChoice;
        private string[] MenuOptions;
        private string Prompt;

        public Menu(string[] menuOptions, string prompt)
        {
            Prompt = prompt;
            MenuOptions = menuOptions;
            selectedChoice = 0;
        }

        private void DisplayOptions()
        {
            Console.WriteLine(Prompt);
            for (int i = 0; i < MenuOptions.Length; i++)
            {
                string option = MenuOptions[i];
                string prefix;
                if (i == selectedChoice)
                {
                    prefix = "*";
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;

                }
                else
                {
                    prefix = " ";
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.WriteLine($"{prefix} >>> {option} <<<");
            }
            Console.ResetColor();
        }

        public int Run()
        {
            ConsoleKey keyPressed;

            do
            {
                Console.Clear();
                DisplayOptions();

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                keyPressed = keyInfo.Key;

                //Update Selected Index based upon arrow keys
                if (keyPressed == ConsoleKey.UpArrow)
                {
                    selectedChoice--;
                    if (selectedChoice == -1)
                    {
                        selectedChoice = MenuOptions.Length - 1;
                    }
                }
                else if (keyPressed == ConsoleKey.DownArrow)
                {
                    selectedChoice++;
                    if (selectedChoice == MenuOptions.Length)
                    {
                        selectedChoice = 0;
                    }
                }


            } while (keyPressed != ConsoleKey.Enter);

            return selectedChoice;
        }
    }
}

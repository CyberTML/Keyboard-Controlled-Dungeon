using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keyboard_Controlled_Menu
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(150, 65);          
            Console.WriteLine(Console.WindowWidth);
            Console.WriteLine(Console.WindowHeight);
            Game game = new Game();
            game.Start();

        }
    }


}

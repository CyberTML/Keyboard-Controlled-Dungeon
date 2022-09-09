using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GLibrary;


/// MICHAEL HADLEY -- YOUTUBE :: INTRO TO C#
namespace Keyboard_Controlled_Menu
{
    class Game
    {


        public void Start()
        {
            Console.Title = "Game";
            RunMainMenu();




        }

        private void RunMainMenu()
        {
            string Prompt = @"

███████ ██   ██ ███████ ██      ███████ ████████  ██████  ███    ██     ███    ███  █████  ███    ██ ██  █████  
██      ██  ██  ██      ██      ██         ██    ██    ██ ████   ██     ████  ████ ██   ██ ████   ██ ██ ██   ██ 
███████ █████   █████   ██      █████      ██    ██    ██ ██ ██  ██     ██ ████ ██ ███████ ██ ██  ██ ██ ███████ 
     ██ ██  ██  ██      ██      ██         ██    ██    ██ ██  ██ ██     ██  ██  ██ ██   ██ ██  ██ ██ ██ ██   ██ 
███████ ██   ██ ███████ ███████ ███████    ██     ██████  ██   ████     ██      ██ ██   ██ ██   ████ ██ ██   ██ 
                                                                                                                                                                                                                                
      
      Welcome to Skeleton Mania!
(Use The Arrow Keys to select an option)
";
            string[] menuOptions = { "Play", "About", "Exit" };
            Menu mainMenu = new Menu(menuOptions, Prompt);
            int selectedChoice = mainMenu.Run();

            switch (selectedChoice)
            {
                case 0:
                    Play();
                    break;
                case 1:
                    DisplayAboutInfo();
                    break;
                case 2:
                    ExitGame();
                    break;
            }
        }

        private void ExitGame()
        {

            Console.WriteLine("\n\n\nPress any key to exit the application...");
            Console.ReadKey(true);
            Environment.Exit(0);

        }
        private void DisplayAboutInfo()
        {
            Console.Clear();
            Console.WriteLine("Created By Yours Truly\n");
            Console.WriteLine("Sources/Assets Used Here\n");
            Console.WriteLine("This is a Dungeon Application Created for Pure Enjoyment");
            Console.WriteLine("\nPress Any Key To Return To Main Menu");
            Console.ReadKey(true);
            RunMainMenu();
        }
        private void Play()
        {
            PlayerStart user = new PlayerStart();
            Console.WriteLine("\nPlease Enter Player Name...");
            user.Name = Console.ReadLine();            
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"\tBlonde, greasy hair almost fully covers a strong, charming face.\n\n\tDarting blue eyes, set wickedly within their sockets, watch thoughtfully\n\tover the mountains they've shown mercy on for so long.\n\n\tFallen debry left a mark reaching from the right side of the forehead, running towards\n\tthe tip of the nose and ending on his chin leaves a tormenting burden of his unfortunate upbringing.\n\n\tThis is the face of {user.Name}, a true warden among humans.\n\tHe stands tall among others, despite his subtle frame.");
            string media = @"
  / \
  | |
  |.|
  |.|
  |:|      __
,_|:|_,   /  )
  (Oo    / _I_
   +\ \  || __|
      \ \||___|
        \ /.:.\-\
         |.:. /-----\
         |___|::oOo::|
         /   |:<_T_>:|
        |_____\ ::: /
         | |  \ \:/
         | |   | |
         \ /   | \___
         / |   \_____\
         `-'";
            Console.WriteLine(media);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"\n{user.Name} hears the hissing of fire that fills the air as he enters a mammoth room with fractured timber walls.\nDead insects cover the floor. Light seems to be eminating from glowing orbs along the wall.\n\nAs {user.Name} plunders through the room a faint noise is heard coming closer.");
            Console.ReadKey();
            Console.WriteLine("\n\nSuddenly, a skeleton appears!!\n\n");
            string Prompt1 = @" 
      .-.
     (o.o)
      |=|
     __|__
   //.=|=.\\
  // .=|=. \\
  \\ .=|=. //
   \\(_=_)//
    (:| |:)
     || ||
     () ()
     || ||
     || ||
l42 ==' '==";           
            Console.WriteLine(Prompt1);
            Console.ReadLine();

            void BattleOne()
            {
                Console.WriteLine($"{user.Name} charges towards the skeleton!");
            }

            BattleOne(); // <--  BATTLE ONE HERE

            ExitGame();
        }

    }
}
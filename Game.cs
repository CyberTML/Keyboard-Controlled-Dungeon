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
            Console.WriteLine("Created By Yours Truly");
            Console.WriteLine("Sources/Assets Used Here");
            Console.WriteLine("Just a demo");
            Console.WriteLine("Press Any Key To Return To Main Menu");
            Console.ReadKey(true);
            RunMainMenu();
        }
        private void Play()
        {
            PlayerStart user = new PlayerStart();
            Console.WriteLine("\nPlease Enter Player Name...");
            user.Name = Console.ReadLine();
            PlayerStart user = new PlayerStart();
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"\nBlonde, greasy hair almost fully covers a strong, charming face.\n\nDarting blue eyes, set wickedly within their sockets, watch thoughtfully\nover the mountains they've shown mercy on for so long.\n\nFallen debry left a mark reaching from the right side of the forehead, running towards\nthe tip of the nose and ending on his chin leaves a tormenting burden of his unfortunate upbringing.\n\nThis is the face of {user.Name}, a true warden among humans.\nHe stands tall among others, despite his subtle frame.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"\n{user.Name} hears the hissing of fire that fills the air as he enters a mammoth room with fractured timber walls.\nDead insects cover the floor. Light seems to be eminating from glowing orbs along the wall.\n\nAs {user.Name} plunders through the room a faint noise is heard coming closer.\n\nSuddenly, a skeleton appears!!\n\n");

            Random attack = new Random();
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
            Skeleton skeleton = new Skeleton(2, 30, attack.Next(1, 10), Prompt1);
            Console.WriteLine(Prompt1);

            // BATTLE ONE HERE
            ExitGame();
        }
    }
}
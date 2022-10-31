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
        //TODO Block(s)
        //TODO Enemy Attack Skills -- Different For Each

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
            Console.WriteLine("\nPlease Enter Character Name...");
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
            Console.WriteLine($"\n\t{user.Name} hears the hissing of fire that fills the air as he enters a mammoth room with fractured timber walls.\n\tDead insects cover the floor. Light seems to be eminating from glowing orbs along the wall.\n\n\tAs {user.Name} plunders through the room a faint noise is heard coming closer.");           
            Console.ReadKey();
            Console.WriteLine("\n\n\tSuddenly, a skeleton appears!!\n\n");
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
            Console.Clear();

// BATTLE ONE
            #region Battle One
            void BattleOne()
            {
                Console.WriteLine($"\t{user.Name} charges towards the skeleton!");
                Console.ReadLine();
                Console.Clear();
                string Prompt1 = @"

      _,.
    ,` -.)
   ( _/-\\-._
  /,|`--._,-^|            ,
  \_| |`-._/||          ,'|
    |  `-, / |         /  /
    |     || |        /  /
     `r-._||/   __   /  /
 __,-<_     )`-/  `./  /
'  \   `---'   \   /  /
    |           |./  /
    /           //  /
\_/' \         |/  /
 |    |   _,^-'/  /
 |    , ``  (\/  /_
  \,.->._    \X-=/^
  (  /   `-._//^`
   `Y-.____(__}
    |     {__)
          ()";

             
                do
                {
                    Skeleton skeleton = new Skeleton(2, 30, 10, Prompt1);
                    string[] menuOptions = { "Attack", "Block", "Flee", "HP Potion" };
                    AttackMenu attackMenu = new AttackMenu(menuOptions, Prompt1);
                    int selectedChoice = attackMenu.Run();

                    switch (selectedChoice)
                    {
                        case 0:
                            Attack();
                            break;
                        case 1:
                            Block();
                            break;
                        case 2:
                            Flee();
                            break;
                        case 3:
                            HPPotion();
                            break;
                    }

                    
                   
                    void Attack()
                    {
                        void AttackStart()
                        {                            
                            Skeleton skeleton = new Skeleton(2, 30, 10, Prompt1);
                            
                            string[] menuOptions = { "Stab", "Slash", "Kick" };
                            Console.WriteLine("\nPlayer Max Potential Damage: " +
                                "Stab: 10\n",
                                "Slash: 20\n",
                                "Kick: 15");
                            AttackMenu attackMenu = new AttackMenu(menuOptions, Prompt1);
                            int selectedChoice = attackMenu.Run();
                            Console.WriteLine($"\nEnemy -- Skeleton:\n-----------------\nLevel: {skeleton.Level} || HP: {skeleton.HP}\nMax Damage: {skeleton.Damage}\n\n");
                            Console.WriteLine($"Player -- {user.Name}:\n-----------------\nLevel: {user.Level} || HP: {user.HP}\nAmour Value: {user.Armour} || Potions: {user.Potions}");
                            Console.ReadLine();
                            //TODO Skeleton HP not changing when fighting ^^^ LINE 200
                        }
                        AttackStart();
                        
                        switch (selectedChoice)
                        {
                            case 0:
                                Random Stab = new Random();
                                int stabAttack = Stab.Next(11);
                                Console.WriteLine($"\n\nYour Attack dealt {stabAttack} to the enemy!\nSkeleton HP is now {skeleton.HP - stabAttack}.\n");
                                skeleton.HP = skeleton.HP - stabAttack;                               
                                Console.ReadLine();


                                if (skeleton.HP <= 0)
                                {
                                    Console.WriteLine("The Skeleton has Died...\n");
                                    Console.WriteLine("You gained 146 EXP. You reached Level 2!\n");
                                    user.Level = 2;  // <-- Exp +100 for Levels (100, 200, 300, 400, Etc...)
                                    Console.WriteLine("Health has been restored");
                                    user.HP = 100;
                                    Console.ReadLine();
                                }

                                else if (skeleton.HP > 0)
                                {
                                    Console.WriteLine("\nEnemies Turn...\n");
                                    Console.ReadLine();                                   
                                    Random enemyAtt = new Random();
                                    int enemyAttack = enemyAtt.Next(11);
                                    Console.WriteLine($"\n\nEnemy Deals {enemyAttack} to you!\n{user.Name}'s HP: {user.HP - enemyAttack}");
                                    user.HP = user.HP - enemyAttack;
                                    if (user.HP <= 0)
                                    {
                                        Console.WriteLine($"\nGAME OVER... {user.Name} Has Died...");
                                        Console.WriteLine("Play Again? Y/N");
                                        string key = Console.ReadLine();
                                        if (key == "Y")
                                        {
                                            Console.WriteLine("Returning to Main Menu...");
                                            RunMainMenu();
                                        }
                                        else if (key == "N")
                                        {
                                            ExitGame();
                                        }
                                        Console.ReadLine();
                                        
                                    }
                                    Console.ReadLine();
                                    Console.Clear();


                                    string[] menuOptions = { "Attack", "Block", "Flee", "HP Potion" };
                                    AttackMenu attackMenu = new AttackMenu(menuOptions, Prompt1);
                                    int selectedChoice = attackMenu.Run();

                                    switch (selectedChoice)
                                    {
                                        case 0:
                                            Attack();
                                            break;
                                        case 1:
                                            Block();
                                            break;
                                        case 2:
                                            Flee();
                                            break;
                                        case 3:
                                            HPPotion();
                                            break;
                                    }
                                }

                                break;

                            case 1:
                                Random Slash = new Random();
                                int slashAttack = Slash.Next(21);
                                Console.WriteLine($"\n\nYour Attack dealt {slashAttack} to the enemy!\nSkeleton HP is now {skeleton.HP - slashAttack}.");
                                skeleton.HP = skeleton.HP - slashAttack;                              
                                Console.ReadKey();
                                if (skeleton.HP <= 0)
                                {
                                    Console.WriteLine("The Skeleton has Died...");
                                    Console.WriteLine("You gained 146 EXP. You reached Level 2!");
                                    user.Level = 2;  // <-- Exp +100 for Levels (100, 200, 300, 400, Etc...)
                                    Console.WriteLine("Health has been restored");
                                    user.HP = 100;
                                    Console.ReadLine();
                                }
                                else if (skeleton.HP > 0)
                                {
                                    Console.WriteLine("\nEnemies Turn...\n");
                                    Console.ReadLine();
                                    Random enemyAtt = new Random();
                                    int enemyAttack = enemyAtt.Next(11);
                                    Console.WriteLine($"\n\nEnemy Deals {enemyAttack} to you!\n{user.Name}'s HP: {user.HP - enemyAttack}");                                   
                                    user.HP = user.HP - enemyAttack;
                                    Console.ReadLine();
                                    Console.Clear();
                                    if (user.HP <= 0)
                                    {
                                        Console.WriteLine($"\nGAME OVER... {user.Name} Has Died...");
                                        Console.WriteLine("Play Again? Y/N");
                                        string key = Console.ReadLine();
                                        if (key == "Y")
                                        {
                                            Console.WriteLine("Returning to Main Menu...");
                                            RunMainMenu();
                                        }
                                        else if (key == "N")
                                        {
                                            ExitGame();
                                        }
                                        Console.ReadLine();
                                        
                                    }


                                    string[] menuOptions = { "Attack", "Block", "Flee", "HP Potion" };
                                    AttackMenu attackMenu = new AttackMenu(menuOptions, Prompt1);
                                    int selectedChoice = attackMenu.Run();

                                    switch (selectedChoice)
                                    {
                                        case 0:
                                            Attack();
                                            break;
                                        case 1:
                                            Block();
                                            break;
                                        case 2:
                                            Flee();
                                            break;
                                        case 3:
                                            HPPotion();
                                            break;
                                    }
                                }
                                break;
                            case 2:
                                
                                Random Kick = new Random();
                                int kickAttack = Kick.Next(16);
                                Console.WriteLine($"\n\nYour Attack dealt {kickAttack} to the enemy!\nSkeleton HP is now {skeleton.HP - kickAttack}.");
                                skeleton.HP = skeleton.HP - kickAttack;                               
                                Console.ReadKey();
                                if (skeleton.HP <= 0)
                                {
                                    Console.WriteLine("The Skeleton has Died...");
                                    Console.WriteLine("You gained 146 EXP. You reached Level 2!");
                                    user.Level = 2;  // <-- Exp +100 for Levels (100, 200, 300, 400, Etc...)
                                    Console.WriteLine("Health has been restored");
                                    user.HP = 100;
                                    Console.ReadLine();
                                }
                                else if (skeleton.HP > 0)
                                {
                                    Console.WriteLine("\nEnemies Turn...\n");
                                    Console.ReadLine();                                   
                                    Random enemyAtt = new Random();
                                    int enemyAttack = enemyAtt.Next(11);
                                    Console.WriteLine($"\n\nEnemy Deals {enemyAttack} to you!\n{user.Name}'s HP: {user.HP - enemyAttack}");
                                    user.HP = user.HP - enemyAttack;
                                    if (user.HP <= 0)
                                    {
                                        Console.WriteLine($"\nGAME OVER... {user.Name} Has Died...");
                                        Console.WriteLine("Play Again? Y/N");
                                        string key = Console.ReadLine();
                                        if (key == "Y")
                                        {
                                            Console.WriteLine("Returning to Main Menu...");
                                            RunMainMenu();
                                        }
                                        else if (key == "N")
                                        {
                                            ExitGame();
                                        }
                                        Console.ReadLine();
                                        
                                    }
                                    Console.ReadLine();
                                    Console.Clear();


                                    string[] menuOptions = { "Attack", "Block", "Flee", "HP Potion" };
                                    AttackMenu attackMenu = new AttackMenu(menuOptions, Prompt1);
                                    int selectedChoice = attackMenu.Run();

                                    switch (selectedChoice)
                                    {
                                        case 0:
                                            Attack();
                                            break;
                                        case 1:
                                            Block();
                                            break;
                                        case 2:                                                                                                                               
                                            Flee();
                                            break;
                                        case 3:
                                            HPPotion();                                                                             
                                            break;
                                    }
                                }
                                break;
                        }
                      
                    }

                    void Block()
                    {
                        string[] menuOptions = { "Attack", "Block", "Flee", "HP Potion" };
                        AttackMenu attackMenu = new AttackMenu(menuOptions, Prompt1);
                        int selectedChoice = attackMenu.Run();

                        switch (selectedChoice)
                        {
                            case 0:
                                Attack();
                                break;
                            case 1:
                                Block();
                                break;
                            case 2:
                                Flee();
                                break;
                            case 3:
                                HPPotion();
                                break;
                        }
                    }

                    void Flee()
                    {
                        Random enemyAtt = new Random();
                        int enemyAttack = enemyAtt.Next(11);
                        Console.WriteLine($"\nRun Attempt Failed!\n");
                        Console.WriteLine($"\n\nEnemy Deals {enemyAttack} to you!\n{user.Name}'s HP: {user.HP - enemyAttack}");
                        user.HP = user.HP - enemyAttack;
                        Console.ReadLine();
                        Console.Clear();

                        string[] menuOptions = { "Attack", "Block", "Flee", "HP Potion" };
                        AttackMenu attackMenu = new AttackMenu(menuOptions, Prompt1);
                        int selectedChoice = attackMenu.Run();

                        switch (selectedChoice)
                        {
                            case 0:
                                Attack();
                                break;
                            case 1:
                                Block();
                                break;
                            case 2:
                                Flee();
                                break;
                            case 3:
                                HPPotion();
                                break;
                        }
                    }

                    void HPPotion()
                    {
                        if (user.Potions > 0)
                        {
                            int HPPotion = 30;
                            Console.WriteLine($"{user.Name} grabs a potion and gulps it down.");

                            if (user.HP <= 100)
                            {
                                user.HP = user.HP + HPPotion;

                                user.Potions--;

                                if (user.HP >= 100)
                                {
                                    user.HP = 100;
                                    Console.WriteLine("Health is Full\n");
                                }

                                Console.WriteLine($"{user.Name}'s HP: {user.HP}");
                            }
                            else if (user.HP == 100)
                            {
                                Console.WriteLine("Already at Max HP");
                            }
                            user.Potions--;
                        }
                        else if (user.Potions == 0)
                        {
                            Console.WriteLine("Oops... No HP Potions Left... Good Luck!");
                            Console.ReadKey();
                        }
                        Console.ReadKey();
                        string[] menuOptions = { "Attack", "Block", "Flee", "HP Potion" };
                        AttackMenu attackMenu = new AttackMenu(menuOptions, Prompt1);
                        int selectedChoice = attackMenu.Run();

                        switch (selectedChoice)
                        {
                            case 0:
                                Attack();
                                break;
                            case 1:
                                Block();
                                break;
                            case 2:
                                Flee();
                                break;
                            case 3:
                                HPPotion();
                                break;
                        }

                    }



                } while(user.HP < 0);

                
            }          
            BattleOne(); // <--  BATTLE ONE HERE
            #endregion

            Console.Clear();
            Console.WriteLine($"\n\tThe Skeleton is defeated, and {user.Name} is victorious.\n\n\tBeyond a pair of granite doors lies a scanty, shady room.\n\tIt's covered in crawling insects, moss and remains. \n\n\tYour torch allows you to see remnants of what was once a decorated room with a now unknown purpose, aged and defaced by time itself.\n\tYou continue onwards, deeper into the dungeon's secret passages.\n\tYou pass countless passages, some of them have collapsed, others seem to go on forever.\n\tYou eventually make it to the second room.\n\n\tA thick granite door blocks your path.\n\tMessages in strange languages are all over it, somehow untouched by time and the elements.\n\tYou step closer to inspect it and.. wait.. you hear the blustering sound of footsteps behind you.");           
            Console.WriteLine($"\n\t{user.Name} turns to see a Giant Skeleton.");
            Console.WriteLine($"\n\tThe battle is in nobody's favor. The dead and people who came before are scattered across the room.\n\tThe faces of the soldiers before are torn apart.\n\t{user.Name} courageously battles on.\n");
            Console.ReadLine();

// BATTLE TWO
            #region BattleTwo
            void BattleTwo()
            {
                Console.WriteLine($"\t{user.Name} leaps towards the Giant Skeleton!");
                Console.ReadLine();
                Console.Clear();
                string Prompt1 = @"
      _,.
    ,` -.)
   ( _/-\\-._
  /,|`--._,-^|            ,
  \_| |`-._/||          ,'|
    |  `-, / |         /  /
    |     || |        /  /
     `r-._||/   __   /  /
 __,-<_     )`-/  `./  /
'  \   `---'   \   /  /
    |           |./  /
    /           //  /
\_/' \         |/  /
 |    |   _,^-'/  /
 |    , ``  (\/  /_
  \,.->._    \X-=/^
  (  /   `-._//^`
   `Y-.____(__}
    |     {__)
          ()";


                do
                {
                    GiantSkeleton skeleton1 = new GiantSkeleton(3, 50, 20, Prompt1);
                    string[] menuOptions = { "Attack", "Block", "Flee", "HP Potion" };
                    Console.WriteLine("\nPlayer Max Potential Damage: " +
                                "Stab: 15\n",
                                "Slash: 25\n",
                                "Kick: 20");
                    AttackMenu attackMenu = new AttackMenu(menuOptions, Prompt1);
                    int selectedChoice = attackMenu.Run();

                    switch (selectedChoice)
                    {
                        case 0:
                            Attack();
                            break;
                        case 1:
                            Block();
                            break;
                        case 2:
                            Flee();
                            break;
                        case 3:
                            HPPotion();
                            break;
                    }



                    void Attack()
                    {
                        void AttackStart()
                        {

                            GiantSkeleton skeleton1 = new GiantSkeleton(3, 50, 20, Prompt1);
                            string[] menuOptions = { "Stab", "Slash", "Kick" };
                            AttackMenu attackMenu = new AttackMenu(menuOptions, Prompt1);
                            int selectedChoice = attackMenu.Run();
                            Console.WriteLine($"\nEnemy -- Giant Skeleton:\nLevel: {skeleton1.Level} || HP: {skeleton1.HP}\nMax Damage: {skeleton1.Damage}\n");
                            Console.WriteLine($"Player -- {user.Name}:\nLevel: {user.Level} || HP: {user.HP}\nAmour Value: {user.Armour} || Potions: {user.Potions}");
                            Console.ReadLine();
                        }
                        AttackStart();

                        switch (selectedChoice)
                        {
                            case 0:
                                Random Stab = new Random();
                                int stabAttack = Stab.Next(16);
                                Console.WriteLine($"\n\nYour Attack dealt {stabAttack} to the enemy!\nSkeleton HP is now {skeleton1.HP - stabAttack}.\n");
                                skeleton1.HP = skeleton1.HP - stabAttack;
                                Console.ReadLine();


                                if (skeleton1.HP <= 0)
                                {
                                    skeleton1.HP = 0;
                                    Console.WriteLine("The Skeleton has Died...");
                                    Console.WriteLine("You gained 125 EXP. You reached Level 3!");
                                    user.Level = 3;  // <-- Exp +100 for Levels (100, 200, 300, 400, Etc...) (xp after lvl 1 146 == 64 until 3) - 61 = ***39 for lvl 4***
                                    Console.WriteLine("Health has been restored");
                                    user.HP = 100;
                                    Console.ReadLine();
                                }

                                else if (skeleton1.HP > 0)
                                {
                                    Console.WriteLine("\nEnemies Turn...\n");
                                    Console.ReadLine();
                                    Random enemyAtt = new Random();
                                    int enemyAttack = enemyAtt.Next(21);
                                    Console.WriteLine($"\n\nEnemy Deals {enemyAttack} to you!\n{user.Name}'s HP: {user.HP - enemyAttack}");
                                    user.HP = user.HP - enemyAttack;
                                    if (user.HP <= 0)
                                    {
                                        Console.WriteLine($"\nGAME OVER... {user.Name} Has Died...");
                                        Console.WriteLine("Play Again? Y/N");
                                        string key = Console.ReadLine();
                                        if (key == "Y")
                                        {
                                            Console.WriteLine("Returning to Main Menu...");
                                            RunMainMenu();
                                        }
                                        else if (key == "N")
                                        {
                                            ExitGame();
                                        }
                                        Console.ReadLine();
                                        
                                    }
                                    Console.ReadLine();                                   
                                    Console.Clear();


                                    string[] menuOptions = { "Attack", "Block", "Flee", "HP Potion" };
                                    AttackMenu attackMenu = new AttackMenu(menuOptions, Prompt1);
                                    int selectedChoice = attackMenu.Run();

                                    switch (selectedChoice)
                                    {
                                        case 0:
                                            Attack();
                                            break;
                                        case 1:
                                            Block();
                                            break;
                                        case 2:
                                            Flee();
                                            break;
                                        case 3:
                                            HPPotion();
                                            break;
                                    }
                                }

                                break;

                            case 1:
                                Random Slash = new Random();
                                int slashAttack = Slash.Next(26);
                                Console.WriteLine($"\n\nYour Attack dealt {slashAttack} to the enemy!\nSkeleton HP is now {skeleton1.HP - slashAttack}.");
                                skeleton1.HP = skeleton1.HP - slashAttack;
                                Console.ReadKey();
                                if (skeleton1.HP <= 0)
                                {
                                    skeleton1.HP = 0;
                                    Console.WriteLine("The Skeleton has Died...");
                                    Console.WriteLine("You gained 125 EXP. You reached Level 3!");
                                    user.Level = 3;  // <-- Exp +100 for Levels (100, 200, 300, 400, Etc...) (xp after lvl 1 146 == 64 until 3) - 61 = ***39 for lvl 4***
                                    Console.WriteLine("Health has been restored");
                                    user.HP = 100;
                                    Console.ReadLine();
                                }
                                else if (skeleton1.HP > 0)
                                {
                                    Console.WriteLine("\nEnemies Turn...\n");
                                    Console.ReadLine();
                                    Random enemyAtt = new Random();
                                    int enemyAttack = enemyAtt.Next(21);
                                    Console.WriteLine($"\n\nEnemy Deals {enemyAttack} to you!\n{user.Name}'s HP: {user.HP - enemyAttack}");
                                    user.HP = user.HP - enemyAttack;
                                    if (user.HP <= 0)
                                    {
                                        Console.WriteLine($"\nGAME OVER... {user.Name} Has Died...");
                                        Console.WriteLine("Play Again? Y/N");
                                        string key = Console.ReadLine();
                                        if (key == "Y")
                                        {
                                            Console.WriteLine("Returning to Main Menu...");
                                            RunMainMenu();
                                        }
                                        else if (key == "N")
                                        {
                                            ExitGame();
                                        }
                                        Console.ReadLine();
                                        
                                    }
                                    Console.ReadLine();
                                    Console.Clear();


                                    string[] menuOptions = { "Attack", "Block", "Flee", "HP Potion" };
                                    AttackMenu attackMenu = new AttackMenu(menuOptions, Prompt1);
                                    int selectedChoice = attackMenu.Run();

                                    switch (selectedChoice)
                                    {
                                        case 0:
                                            Attack();
                                            break;
                                        case 1:
                                            Block();
                                            break;
                                        case 2:
                                            Flee();
                                            break;
                                        case 3:
                                            HPPotion();
                                            break;
                                    }
                                }
                                break;
                            case 2:

                                Random Kick = new Random();
                                int kickAttack = Kick.Next(21);
                                Console.WriteLine($"\n\nYour Attack dealt {kickAttack} to the enemy!\nSkeleton HP is now {skeleton1.HP - kickAttack}.");
                                skeleton1.HP = skeleton1.HP - kickAttack;
                                Console.ReadKey();
                                if (skeleton1.HP <= 0)
                                {
                                    skeleton1.HP = 0;
                                    Console.WriteLine("The Skeleton has Died...");
                                    Console.WriteLine("You gained 125 EXP. You reached Level 3!");
                                    user.Level = 3;  // <-- Exp +100 for Levels (100, 200, 300, 400, Etc...) (xp after lvl 1 146 == 64 until 3) - 61 = ***39 for lvl 4***
                                    Console.WriteLine("Health has been restored");
                                    user.HP = 100;
                                    Console.ReadLine();
                                }
                                else if (skeleton1.HP > 0)
                                {
                                    Console.WriteLine("\nEnemies Turn...\n");
                                    Console.ReadLine();
                                    Random enemyAtt = new Random();
                                    int enemyAttack = enemyAtt.Next(21);
                                    Console.WriteLine($"\n\nEnemy Deals {enemyAttack} to you!\n{user.Name}'s HP: {user.HP - enemyAttack}");
                                    user.HP = user.HP - enemyAttack;
                                    if (user.HP <= 0)
                                    {
                                        Console.WriteLine($"\nGAME OVER... {user.Name} Has Died...");
                                        Console.WriteLine("Play Again? Y/N");
                                        string key = Console.ReadLine();
                                        if (key == "Y")
                                        {
                                            Console.WriteLine("Returning to Main Menu...");
                                            RunMainMenu();
                                        }
                                        else if (key == "N")
                                        {
                                            ExitGame();
                                        }
                                        Console.ReadLine();
                                       
                                    }
                                    Console.ReadLine();
                                    Console.Clear();


                                    string[] menuOptions = { "Attack", "Block", "Flee", "HP Potion" };
                                    AttackMenu attackMenu = new AttackMenu(menuOptions, Prompt1);
                                    int selectedChoice = attackMenu.Run();

                                    switch (selectedChoice)
                                    {
                                        case 0:
                                            Attack();
                                            break;
                                        case 1:
                                            Block();
                                            break;
                                        case 2:
                                            Flee();
                                            break;
                                        case 3:
                                            HPPotion();
                                            break;
                                    }
                                }
                                break;
                        }

                    }

                    void Block()
                    {
                        string[] menuOptions = { "Attack", "Block", "Flee", "HP Potion" };
                        AttackMenu attackMenu = new AttackMenu(menuOptions, Prompt1);
                        int selectedChoice = attackMenu.Run();

                        switch (selectedChoice)
                        {
                            case 0:
                                Attack();
                                break;
                            case 1:
                                Block();
                                break;
                            case 2:
                                Flee();
                                break;
                            case 3:
                                HPPotion();
                                break;
                        }
                    }

                    void Flee()
                    {
                        Random enemyAtt = new Random();
                        int enemyAttack = enemyAtt.Next(11);
                        Console.WriteLine($"\nRun Attempt Failed!\n");
                        Console.WriteLine($"\n\nEnemy Deals {enemyAttack} to you!\n{user.Name}'s HP: {user.HP - enemyAttack}");
                        user.HP = user.HP - enemyAttack;
                        Console.ReadLine();
                        Console.Clear();

                        string[] menuOptions = { "Attack", "Block", "Flee", "HP Potion" };
                        AttackMenu attackMenu = new AttackMenu(menuOptions, Prompt1);
                        int selectedChoice = attackMenu.Run();

                        switch (selectedChoice)
                        {
                            case 0:
                                Attack();
                                break;
                            case 1:
                                Block();
                                break;
                            case 2:
                                Flee();
                                break;
                            case 3:
                                HPPotion();
                                break;
                        }
                    }

                    void HPPotion()
                    {
                        if (user.Potions > 0)
                        {
                            int HPPotion = 30;
                            Console.WriteLine($"{user.Name} grabs a potion and gulps it down.");

                            if (user.HP <= 100)
                            {
                                user.HP = user.HP + HPPotion;

                                user.Potions--;

                                if (user.HP >= 100)
                                {
                                    user.HP = 100;
                                    Console.WriteLine("Health is Full\n");
                                }

                                Console.WriteLine($"{user.Name}'s HP: {user.HP}");
                            }
                            else if (user.HP == 100)
                            {
                                Console.WriteLine("Already at Max HP");
                            }                           
                        }
                        else if (user.Potions <= 0)
                        {
                            user.Potions = 0;
                            Console.WriteLine("Oops... No HP Potions Left... Good Luck!");
                        }
                        Console.ReadKey();
                        string[] menuOptions = { "Attack", "Block", "Flee", "HP Potion" };
                        AttackMenu attackMenu = new AttackMenu(menuOptions, Prompt1);
                        int selectedChoice = attackMenu.Run();

                        switch (selectedChoice)
                        {
                            case 0:
                                Attack();
                                break;
                            case 1:
                                Block();
                                break;
                            case 2:
                                Flee();
                                break;
                            case 3:
                                HPPotion();
                                break;
                        }

                    }

                } while (user.HP < 0);


            }
            BattleTwo();
            #endregion

            Console.Clear();
            Console.WriteLine($"\n\t{user.Name} takes the next passage they see, and follow it to the end.\n\tUpon reaching close the end there is a light coming from the distance. The passage led {user.Name} to a town. ");

// BATTLE THREE
            #region Battle Three
            void BattleThree()
            {
                Console.WriteLine($"\t{user.Name} sees the Arcane Skeleton in the distance. It begins casting a spell!\n\t{user.Name} is too far away. A bow is found in a wooden chest with some arrows next to it.\n\n\tThe town is littered with weapons, suits and destruction. Red, black and silver are the new colors of what was once a serene,\n\thard working town, which has now become the stage wreckage.\n\tThe air which would normally be filled with the scent of freshly baked bread and the sound of people is now a \n\thellish symphony of death and despair.");
                Console.ReadLine();
                Console.Clear();
                string Prompt1 = @"
      _,.
    ,` -.)
   ( _/-\\-._
  /,|`--._,-^|            ,
  \_| |`-._/||          ,'|
    |  `-, / |         /  /
    |     || |        /  /
     `r-._||/   __   /  /
 __,-<_     )`-/  `./  /
'  \   `---'   \   /  /
    |           |./  /
    /           //  /
\_/' \         |/  /
 |    |   _,^-'/  /
 |    , ``  (\/  /_
  \,.->._    \X-=/^
  (  /   `-._//^`
   `Y-.____(__}
    |     {__)
          ()";


                do
                {
                    ArcaneSkeleton skeleton2 = new ArcaneSkeleton(4, 80, 30, Prompt1);
                    string[] menuOptions = { "Attack", "Block", "Flee", "HP Potion" };
                    Console.WriteLine("\nPlayer Max Potential Damage: " +
                                "Shoot: 20\n",
                                "Triple Shot: 50\n",
                                "Kick: 25");
                    AttackMenu attackMenu = new AttackMenu(menuOptions, Prompt1);
                    int selectedChoice = attackMenu.Run();

                    switch (selectedChoice)
                    {
                        case 0:
                            Attack();
                            break;
                        case 1:
                            Block();
                            break;
                        case 2:
                            Flee();
                            break;
                        case 3:
                            HPPotion();
                            break;
                    }



                    void Attack()
                    {
                        void AttackStart()
                        {

                            ArcaneSkeleton skeleton2 = new ArcaneSkeleton(4, 80, 30, Prompt1);
                            string[] menuOptions = { "Shoot", "Triple Shot", "Aimed Shot" };
                            AttackMenu attackMenu = new AttackMenu(menuOptions, Prompt1);
                            int selectedChoice = attackMenu.Run();
                            Console.WriteLine($"\nEnemy -- Arcane Skeleton:\nLevel: {skeleton2.Level} || HP: {skeleton2.HP}\nMax Damage: {skeleton2.Damage}");
                            Console.WriteLine($"\nPlayer -- {user.Name}:\nLevel: {user.Level} || HP: {user.HP}\nAmour Value: {user.Armour} || Potions: {user.Potions}");
                            Console.ReadLine();
                        }
                        AttackStart();

                        switch (selectedChoice)
                        {
                            case 0:
                                Random Shoot = new Random();
                                int shootAttack = Shoot.Next(5, 20);
                                Console.WriteLine($"\n\nYour Attack dealt {shootAttack} to the enemy!\nSkeleton HP is now {skeleton2.HP - shootAttack}.\n");
                                skeleton2.HP = skeleton2.HP - shootAttack;
                                Console.ReadLine();


                                if (skeleton2.HP <= 0)
                                {
                                    skeleton2.HP = 0;
                                    Console.WriteLine("The Skeleton has Died...");
                                    Console.WriteLine("You gained 98 EXP. You reached Level 4!");
                                    user.Level = 4;  // <-- Exp +100 for Levels (100, 200, 300, 400, Etc...) (xp after lvl 1 146 == 64 until 3) - 61 = ***39 for lvl 4*** ***59 Until 5***
                                    Console.WriteLine("Health has been restored");
                                    user.HP = 100;
                                    Console.ReadLine();
                                }

                                else if (skeleton2.HP > 0)
                                {
                                    Console.WriteLine("\nEnemies Turn...\n");
                                    Console.ReadLine();
                                    Random enemyAtt = new Random();
                                    int enemyAttack = enemyAtt.Next(31);
                                    Console.WriteLine($"\n\nEnemy Deals {enemyAttack} to you!\n{user.Name}'s HP: {user.HP - enemyAttack}");
                                    user.HP = user.HP - enemyAttack;
                                    if (user.HP <= 0)
                                    {
                                        Console.WriteLine($"\nGAME OVER... {user.Name} Has Died...");
                                        Console.WriteLine("Play Again? Y/N");
                                        string key = Console.ReadLine();
                                        if (key == "Y")
                                        {
                                            Console.WriteLine("Returning to Main Menu...");
                                            RunMainMenu();
                                        }
                                        else if (key == "N")
                                        {
                                            ExitGame();
                                        }
                                        Console.ReadLine();                                       
                                    }
                                    Console.ReadLine();
                                    Console.Clear();


                                    string[] menuOptions = { "Attack", "Block", "Flee", "HP Potion" };
                                    AttackMenu attackMenu = new AttackMenu(menuOptions, Prompt1);
                                    int selectedChoice = attackMenu.Run();

                                    switch (selectedChoice)
                                    {
                                        case 0:
                                            Attack();
                                            break;
                                        case 1:
                                            Block();
                                            break;
                                        case 2:
                                            Flee();
                                            break;
                                        case 3:
                                            HPPotion();
                                            break;
                                    }
                                }

                                break;

                            case 1:
                                Random Triple = new Random();
                                int tripleAttack = Triple.Next(20, 50);  // <--TODO Only be used 2 times FIX
                                Console.WriteLine($"\n\nYour Attack dealt {tripleAttack} to the enemy!\nSkeleton HP is now {skeleton2.HP - tripleAttack}.");
                                skeleton2.HP = skeleton2.HP - tripleAttack;
                                Console.ReadKey();
                                if (skeleton2.HP <= 0)
                                {
                                    skeleton2.HP = 0;
                                    Console.WriteLine("The Skeleton has Died...");
                                    Console.WriteLine("You gained 98 EXP. You reached Level 4!");
                                    user.Level = 4;  // <-- Exp +100 for Levels (100, 200, 300, 400, Etc...) (xp after lvl 1 146 == 64 until 3) - 61 = ***39 for lvl 4*** ***59 Until 5***
                                    Console.WriteLine("Health has been restored");
                                    user.HP = 100;
                                    Console.ReadLine();
                                }
                                else if (skeleton2.HP > 0)
                                {
                                    Console.WriteLine("\nEnemies Turn...\n");
                                    Console.ReadLine();
                                    Random enemyAtt = new Random();
                                    int enemyAttack = enemyAtt.Next(31);
                                    Console.WriteLine($"\n\nEnemy Deals {enemyAttack} to you!\n{user.Name}'s HP: {user.HP - enemyAttack}");
                                    user.HP = user.HP - enemyAttack;
                                    if (user.HP <= 0)
                                    {
                                        Console.WriteLine($"\nGAME OVER... {user.Name} Has Died...");

                                        Console.WriteLine("Play Again? Y/N");
                                        string key = Console.ReadLine();
                                        if (key == "Y")
                                        {
                                            Console.WriteLine("Returning to Main Menu...");
                                            RunMainMenu();
                                        }
                                        else if (key == "N")
                                        {
                                            ExitGame();
                                        }

                                        Console.ReadLine();
                                        RunMainMenu();
                                    }
                                    Console.ReadLine();
                                    Console.Clear();


                                    string[] menuOptions = { "Attack", "Block", "Flee", "HP Potion" };
                                    AttackMenu attackMenu = new AttackMenu(menuOptions, Prompt1);
                                    int selectedChoice = attackMenu.Run();

                                    switch (selectedChoice)
                                    {
                                        case 0:
                                            Attack();
                                            break;
                                        case 1:
                                            Block();
                                            break;
                                        case 2:
                                            Flee();
                                            break;
                                        case 3:
                                            HPPotion();
                                            break;
                                    }
                                }
                                break;
                            case 2:

                                Random Aimed = new Random();
                                int aimedAttack = Aimed.Next(5, 25);
                                Console.WriteLine($"\n\nYour Attack dealt {aimedAttack} to the enemy!\nSkeleton HP is now {skeleton2.HP - aimedAttack}.");
                                skeleton2.HP = skeleton2.HP - aimedAttack;
                                Console.ReadKey();
                                if (skeleton2.HP <= 0)
                                {
                                    skeleton2.HP = 0;
                                    Console.WriteLine("The Skeleton has Died...");
                                    Console.WriteLine("You gained 98 EXP. You reached Level 4!");
                                    user.Level = 4;  // <-- Exp +100 for Levels (100, 200, 300, 400, Etc...) (xp after lvl 1 146 == 64 until 3) - 61 = ***39 for lvl 4*** ***59 Until 5***
                                    Console.WriteLine("Health has been restored");
                                    user.HP = 100;
                                    Console.ReadLine();
                                }
                                else if (skeleton2.HP > 0)
                                {
                                    Console.WriteLine("\nEnemies Turn...\n");
                                    Console.ReadLine();
                                    Random enemyAtt = new Random();
                                    int enemyAttack = enemyAtt.Next(31);
                                    Console.WriteLine($"\n\nEnemy Deals {enemyAttack} to you!\n{user.Name}'s HP: {user.HP - enemyAttack}");
                                    user.HP = user.HP - enemyAttack;
                                    if (user.HP <= 0)
                                    {
                                        Console.WriteLine($"\nGAME OVER... {user.Name} Has Died...");
                                        Console.WriteLine("Play Again? Y/N");
                                        string key = Console.ReadLine();
                                        if (key == "Y")
                                        {
                                            Console.WriteLine("Returning to Main Menu...");
                                            RunMainMenu();
                                        }
                                        else if (key == "N")
                                        {
                                            ExitGame();
                                        }
                                        Console.ReadLine();
                                        
                                    }
                                    Console.ReadLine();
                                    Console.Clear();


                                    string[] menuOptions = { "Attack", "Block", "Flee", "HP Potion" };
                                    AttackMenu attackMenu = new AttackMenu(menuOptions, Prompt1);
                                    int selectedChoice = attackMenu.Run();

                                    switch (selectedChoice)
                                    {
                                        case 0:
                                            Attack();
                                            break;
                                        case 1:
                                            Block();
                                            break;
                                        case 2:
                                            Flee();
                                            break;
                                        case 3:
                                            HPPotion();
                                            break;
                                    }
                                }
                                break;
                        }

                    }

                    void Block()
                    {
                        string[] menuOptions = { "Attack", "Block", "Flee", "HP Potion" };
                        AttackMenu attackMenu = new AttackMenu(menuOptions, Prompt1);
                        int selectedChoice = attackMenu.Run();

                        switch (selectedChoice)
                        {
                            case 0:
                                Attack();
                                break;
                            case 1:
                                Block();
                                break;
                            case 2:
                                Flee();
                                break;
                            case 3:
                                HPPotion();
                                break;
                        }
                    }

                    void Flee()
                    {
                        Random enemyAtt = new Random();
                        int enemyAttack = enemyAtt.Next(11);
                        Console.WriteLine($"\nRun Attempt Failed!\n");
                        Console.WriteLine($"\n\nEnemy Deals {enemyAttack} to you!\n{user.Name}'s HP: {user.HP - enemyAttack}");
                        user.HP = user.HP - enemyAttack;
                        Console.ReadLine();
                        Console.Clear();

                        string[] menuOptions = { "Attack", "Block", "Flee", "HP Potion" };
                        AttackMenu attackMenu = new AttackMenu(menuOptions, Prompt1);
                        int selectedChoice = attackMenu.Run();

                        switch (selectedChoice)
                        {
                            case 0:
                                Attack();
                                break;
                            case 1:
                                Block();
                                break;
                            case 2:
                                Flee();
                                break;
                            case 3:
                                HPPotion();
                                break;
                        }
                    }

                    void HPPotion()
                    {
                        if (user.Potions > 0)
                        {
                            int HPPotion = 30;
                            Console.WriteLine($"{user.Name} grabs a potion and gulps it down.");

                            if (user.HP <= 100)
                            {
                                user.HP = user.HP + HPPotion;

                                user.Potions--;

                                if (user.HP >= 100)
                                {
                                    user.HP = 100;
                                    Console.WriteLine("Health is Full\n");
                                }

                                Console.WriteLine($"{user.Name}'s HP: {user.HP}");
                            }
                            else if (user.HP == 100)
                            {
                                Console.WriteLine("Already at Max HP");
                            }
                        }
                        else if (user.Potions <= 0)
                        {
                            user.Potions = 0;
                            Console.WriteLine("Oops... No HP Potions Left... Good Luck!");
                        }
                        Console.ReadKey();
                        string[] menuOptions = { "Attack", "Block", "Flee", "HP Potion" };
                        AttackMenu attackMenu = new AttackMenu(menuOptions, Prompt1);
                        int selectedChoice = attackMenu.Run();

                        switch (selectedChoice)
                        {
                            case 0:
                                Attack();
                                break;
                            case 1:
                                Block();
                                break;
                            case 2:
                                Flee();
                                break;
                            case 3:
                                HPPotion();
                                break;
                        }

                    }

                } while (user.HP < 0);


            }
            BattleThree();
            #endregion

            Console.Clear();
            Console.WriteLine($"\n\t{user.Name} sees a grand temple over the horizon. They take the path leading to the temple and come across what seems to be a murky lake.\n\tUpon walking closer they realize it is a lake of blood. A Blood Skeleton then rises from the lake, and begins levitating towards them.");

// Battle Four
            #region Battle Four
            void BattleFour()
            {
                Console.WriteLine($"\n\tA mighty staff is seen sitting up against a tree close by {user.Name}. It appears to have fire and water elements bottled within.\n\tThe staff is held in {user.Name}'s hand. As the Blood Skeleton approaches, {user.Name} readies for battle.");
                Console.ReadLine();
                Console.Clear();

                string Prompt1 = @"

      _,.
    ,` -.)
   ( _/-\\-._
  /,|`--._,-^|            ,
  \_| |`-._/||          ,'|
    |  `-, / |         /  /
    |     || |        /  /
     `r-._||/   __   /  /
 __,-<_     )`-/  `./  /
'  \   `---'   \   /  /
    |           |./  /
    /           //  /
\_/' \         |/  /
 |    |   _,^-'/  /
 |    , ``  (\/  /_
  \,.->._    \X-=/^
  (  /   `-._//^`
   `Y-.____(__}
    |     {__)
          ()";


                do
                {
                    Skeleton skeleton = new Skeleton(2, 30, 10, Prompt1);
                    string[] menuOptions = { "Attack", "Block", "Flee", "HP Potion" };
                    AttackMenu attackMenu = new AttackMenu(menuOptions, Prompt1);
                    int selectedChoice = attackMenu.Run();

                    switch (selectedChoice)
                    {
                        case 0:
                            Attack();
                            break;
                        case 1:
                            Block();
                            break;
                        case 2:
                            Flee();
                            break;
                        case 3:
                            HPPotion();
                            break;
                    }



                    void Attack()
                    {
                        void AttackStart()
                        {
                            
                            BloodSkeleton skeleton = new BloodSkeleton(6, 30, 10, Prompt1);

                            string[] menuOptions = { "Fire Spell", "Water Spell", "Staff Swing" };
                            Console.WriteLine("\nPlayer Max Potential Damage: " +
                                "Fire Spell: 25\n",
                                "Water Spell: 35\n",
                                "Staff Swing: 30");
                            AttackMenu attackMenu = new AttackMenu(menuOptions, Prompt1);
                            int selectedChoice = attackMenu.Run();
                            Console.WriteLine($"\nEnemy -- Blood Skeleton:\n-----------------\nLevel: {skeleton.Level} || HP: {skeleton.HP}\nMax Damage: {skeleton.Damage}\n\n");
                            Console.WriteLine($"Player -- {user.Name}:\n-----------------\nLevel: {user.Level} || HP: {user.HP}\nAmour Value: {user.Armour} || Potions: {user.Potions}");
                            Console.ReadLine();
                            //TODO Skeleton HP not changing when fighting ^^^ LINE 200
                        }
                        AttackStart();

                        switch (selectedChoice)
                        {
                            case 0:
                                Random Stab = new Random();
                                int stabAttack = Stab.Next(26);
                                Console.WriteLine($"\n\nYour Attack dealt {stabAttack} to the enemy!\nSkeleton HP is now {skeleton.HP - stabAttack}.\n");
                                skeleton.HP = skeleton.HP - stabAttack;
                                Console.ReadLine();


                                if (skeleton.HP <= 0)
                                {
                                    Console.WriteLine("The Skeleton has Died...\n");
                                    Console.WriteLine("You gained 59 EXP. You reached Level 5!");
                                    user.Level = 5;  // <-- Exp +100 for Levels (100, 200, 300, 400, Etc...) (xp after lvl 1 146 == 64 until 3) - 61 = ***39 for lvl 4*** ***59 Until 5***
                                    Console.WriteLine("Health has been restored. You have reached MAX LEVEL.");
                                    user.HP = 100;
                                    Console.ReadLine();
                                }

                                else if (skeleton.HP > 0)
                                {
                                    Console.WriteLine("\nEnemies Turn...\n");
                                    Console.ReadLine();
                                    Random enemyAtt = new Random();
                                    int enemyAttack = enemyAtt.Next(11);
                                    Console.WriteLine($"\n\nEnemy Deals {enemyAttack} to you!\n{user.Name}'s HP: {user.HP - enemyAttack}");
                                    user.HP = user.HP - enemyAttack;
                                    if (user.HP <= 0)
                                    {
                                        Console.WriteLine($"\nGAME OVER... {user.Name} Has Died...");
                                        Console.WriteLine("Play Again? Y/N");
                                        string key = Console.ReadLine();
                                        if (key == "Y")
                                    {
                                    Console.WriteLine("Returning to Main Menu...");
                                    RunMainMenu();
                                    }
                                        else if (key == "N")
                                        {
                                            ExitGame();
                                        }
                                        Console.ReadLine();

                                    }
                                    Console.ReadLine();
                                    Console.Clear();


                                    string[] menuOptions = { "Attack", "Block", "Flee", "HP Potion" };
                                    AttackMenu attackMenu = new AttackMenu(menuOptions, Prompt1);
                                    int selectedChoice = attackMenu.Run();

                                    switch (selectedChoice)
                                    {
                                        case 0:
                                            Attack();
                                            break;
                                        case 1:
                                            Block();
                                            break;
                                        case 2:
                                            Flee();
                                            break;
                                        case 3:
                                            HPPotion();
                                            break;
                                    }
                                }

                                break;

                            case 1:
                                Random Slash = new Random();
                                int slashAttack = Slash.Next(36);
                                Console.WriteLine($"\n\nYour Attack dealt {slashAttack} to the enemy!\nSkeleton HP is now {skeleton.HP - slashAttack}.");
                                skeleton.HP = skeleton.HP - slashAttack;
                                Console.ReadKey();
                                if (skeleton.HP <= 0)
                                {
                                    Console.WriteLine("The Skeleton has Died...");
                                    Console.WriteLine("You gained 59 EXP. You reached Level 5!");
                                    user.Level = 5;  // <-- Exp +100 for Levels (100, 200, 300, 400, Etc...) (xp after lvl 1 146 == 64 until 3) - 61 = ***39 for lvl 4*** ***59 Until 5***
                                    Console.WriteLine("Health has been restored. You have reached MAX LEVEL.");
                                    user.HP = 100;
                                    Console.ReadLine();
                                }
                                else if (skeleton.HP > 0)
                                {
                                    Console.WriteLine("\nEnemies Turn...\n");
                                    Console.ReadLine();
                                    Random enemyAtt = new Random();
                                    int enemyAttack = enemyAtt.Next(11);
                                    Console.WriteLine($"\n\nEnemy Deals {enemyAttack} to you!\n{user.Name}'s HP: {user.HP - enemyAttack}");
                                    user.HP = user.HP - enemyAttack;
                                    Console.ReadLine();
                                    Console.Clear();
                                    if (user.HP <= 0)
                                    {
                                        Console.WriteLine($"\nGAME OVER... {user.Name} Has Died...");
                                        Console.WriteLine("Play Again? Y/N");
                                        string key = Console.ReadLine();
                                        if (key == "Y")
                                        {
                                            Console.WriteLine("Returning to Main Menu...");
                                            RunMainMenu();
                                        }
                                        else if (key == "N")
                                        {
                                            ExitGame();
                                        }
                                        Console.ReadLine();

                                    }


                                    string[] menuOptions = { "Attack", "Block", "Flee", "HP Potion" };
                                    AttackMenu attackMenu = new AttackMenu(menuOptions, Prompt1);
                                    int selectedChoice = attackMenu.Run();

                                    switch (selectedChoice)
                                    {
                                        case 0:
                                            Attack();
                                            break;
                                        case 1:
                                            Block();
                                            break;
                                        case 2:
                                            Flee();
                                            break;
                                        case 3:
                                            HPPotion();
                                            break;
                                    }
                                }
                                break;
                            case 2:

                                Random Kick = new Random();
                                int kickAttack = Kick.Next(31);
                                Console.WriteLine($"\n\nYour Attack dealt {kickAttack} to the enemy!\nSkeleton HP is now {skeleton.HP - kickAttack}.");
                                skeleton.HP = skeleton.HP - kickAttack;
                                Console.ReadKey();
                                if (skeleton.HP <= 0)
                                {
                                    Console.WriteLine("The Skeleton has Died...");
                                    Console.WriteLine("You gained 59 EXP. You reached Level 5!");
                                    user.Level = 5;  // <-- Exp +100 for Levels (100, 200, 300, 400, Etc...) (xp after lvl 1 146 == 64 until 3) - 61 = ***39 for lvl 4*** ***59 Until 5***
                                    Console.WriteLine("Health has been restored. You have reached MAX LEVEL.");
                                    user.HP = 100;
                                    Console.ReadLine();
                                }
                                else if (skeleton.HP > 0)
                                {
                                    Console.WriteLine("\nEnemies Turn...\n");
                                    Console.ReadLine();
                                    Random enemyAtt = new Random();
                                    int enemyAttack = enemyAtt.Next(11);
                                    Console.WriteLine($"\n\nEnemy Deals {enemyAttack} to you!\n{user.Name}'s HP: {user.HP - enemyAttack}");
                                    user.HP = user.HP - enemyAttack;
                                    if (user.HP <= 0)
                                {
                                        Console.WriteLine($"\nGAME OVER... {user.Name} Has Died...");
                                        Console.WriteLine("Play Again? Y/N");
                                        string key = Console.ReadLine();
                                        if (key == "Y")
                                        {
                                            Console.WriteLine("Returning to Main Menu...");
                                            RunMainMenu();
                                        }
                                        else if (key == "N")
                                        {
                                            ExitGame();
                                        }
                                        Console.ReadLine();

                                    }
                                    Console.ReadLine();
                                    Console.Clear();


                                    string[] menuOptions = { "Attack", "Block", "Flee", "HP Potion" };
                                    AttackMenu attackMenu = new AttackMenu(menuOptions, Prompt1);
                                    int selectedChoice = attackMenu.Run();

                                    switch (selectedChoice)
                                    {
                                        case 0:
                                            Attack();
                                            break;
                                        case 1:
                                            Block();
                                            break;
                                        case 2:
                                            Flee();
                                            break;
                                        case 3:
                                            HPPotion();
                                            break;
                                    }
                                }
                                break;
                        }

                    }

                    void Block()
                    {
                        string[] menuOptions = { "Attack", "Block", "Flee", "HP Potion" };
                        AttackMenu attackMenu = new AttackMenu(menuOptions, Prompt1);
                        int selectedChoice = attackMenu.Run();

                        switch (selectedChoice)
                        {
                            case 0:
                                Attack();
                                break;
                            case 1:
                                Block();
                                break;
                            case 2:
                                Flee();
                                break;
                            case 3:
                                HPPotion();
                                break;
                        }
                    }

                    void Flee()
                    {
                        Random enemyAtt = new Random();
                        int enemyAttack = enemyAtt.Next(11);
                        Console.WriteLine($"\nRun Attempt Failed!\n");
                        Console.WriteLine($"\n\nEnemy Deals {enemyAttack} to you!\n{user.Name}'s HP: {user.HP - enemyAttack}");
                        user.HP = user.HP - enemyAttack;
                        Console.ReadLine();
                        Console.Clear();

                        string[] menuOptions = { "Attack", "Block", "Flee", "HP Potion" };
                        AttackMenu attackMenu = new AttackMenu(menuOptions, Prompt1);
                        int selectedChoice = attackMenu.Run();

                        switch (selectedChoice)
                        {
                            case 0:
                                Attack();
                                break;
                            case 1:
                                Block();
                                break;
                            case 2:
                                Flee();
                                break;
                            case 3:
                                HPPotion();
                                break;
                        }
                    }

                    void HPPotion()
                    {
                        if (user.Potions > 0)
                        {
                            int HPPotion = 30;
                            Console.WriteLine($"{user.Name} grabs a potion and gulps it down.");

                            if (user.HP <= 100)
                            {
                                user.HP = user.HP + HPPotion;

                                user.Potions--;

                                if (user.HP >= 100)
                                {
                                    user.HP = 100;
                                    Console.WriteLine("Health is Full\n");
                                }

                                Console.WriteLine($"{user.Name}'s HP: {user.HP}");
                            }
                            else if (user.HP == 100)
                            {
                                Console.WriteLine("Already at Max HP");
                            }
                            user.Potions--;
                        }
                        else if (user.Potions == 0)
                        {
                            Console.WriteLine("Oops... No HP Potions Left... Good Luck!");
                            Console.ReadKey();
                        }
                        Console.ReadKey();
                        string[] menuOptions = { "Attack", "Block", "Flee", "HP Potion" };
                        AttackMenu attackMenu = new AttackMenu(menuOptions, Prompt1);
                        int selectedChoice = attackMenu.Run();

                        switch (selectedChoice)
                        {
                            case 0:
                                Attack();
                                break;
                            case 1:
                                Block();
                                break;
                            case 2:
                                Flee();
                                break;
                            case 3:
                                HPPotion();
                                break;
                        }

                    }

                } while (user.HP < 0);


            }

            BattleFour();
            #endregion

            Console.Clear();

            Console.WriteLine($"\n\tBeyond the broken temple lies a grand, dusty room. It's covered in crawling insects, broken stone and rubble.\n\tYour torch allows you to see broken cages and torture devices, destroyed and mutilated by time itself. A trap door is seen in the room.\n\t{user.Name} opens the latch and travels down the unsteady ladder leading to a dungeon.");


// Final Battle
            #region Final Battle


            // Elder Skeleton appears in the battlefield. Hp Potions restored Spawns a Skeleton, Giant Skeleton, and Arcane Skeleton. PLAYER battles 1,2,3
            // Then, Elder Skeleton appears after defeating all 3, player then fights it.
            
            
           

       
            void BattleFinal()  // SWORD / BOW / STAFF  --  BOSS (3 Phases -- Conjures 3 of 4 Skeletons -- Then Final Boss Takes Damage)
            {
                user.Potions = 3;

                Console.WriteLine($"\t{user.Name} begins walking in a giant room filled with smoke and dead soldiers from before. The Elder Skeleton, the beast from within the dungeon, lurks behind {user.Name} within the shadows. {user.Name} senses a figure coming through the massive gates at the dungeons entrance. The Elder Skleton prepares for battle.\n");
                Console.WriteLine($"\tA spawn of the Skeleton seen at the start of {user.Name}'s adventure begins to rise, and -------");
                Console.ReadLine();
                Console.Clear();
                string Prompt1 = @"
      _,.
    ,` -.)
   ( _/-\\-._
  /,|`--._,-^|            ,
  \_| |`-._/||          ,'|
    |  `-, / |         /  /
    |     || |        /  /
     `r-._||/   __   /  /
 __,-<_     )`-/  `./  /
'  \   `---'   \   /  /
    |           |./  /
    /           //  /
\_/' \         |/  /
 |    |   _,^-'/  /
 |    , ``  (\/  /_
  \,.->._    \X-=/^
  (  /   `-._//^`
   `Y-.____(__}
    |     {__)
          ()";


                do
                {
                    SkeletonSpawn skeleton2 = new SkeletonSpawn(4, 80, 30, Prompt1);
                    string[] menuOptions = { "Attack", "Block", "Flee", "HP Potion" };
                    Console.WriteLine("\nPlayer Max Potential Damage: " +
                                "Shoot: 20\n",
                                "Triple Shot: 50\n",
                                "Kick: 25");
                    AttackMenu attackMenu = new AttackMenu(menuOptions, Prompt1);
                    int selectedChoice = attackMenu.Run();

                    switch (selectedChoice)
                    {
                        case 0:
                            AttackFinal();
                            break;
                        case 1:
                            Block();
                            break;
                        case 2:
                            Flee();
                            break;
                        case 3:
                            HPPotion();
                            break;
                    }



                    void AttackFinal()
                    {
                        void AttackStart()
                        {

                            GiantSkeletonSpawn skeleton = new GiantSkeletonSpawn(4, 80, 30, Prompt1);
                            string[] menuOptions = { "Shoot", "Triple Shot", "Aimed Shot" };
                            AttackMenu attackMenu = new AttackMenu(menuOptions, Prompt1);
                            int selectedChoice = attackMenu.Run();
                            Console.WriteLine($"\nEnemy -- Elder Skeleton (Giant Skeleton):\nLevel: {skeleton.Level} || HP: {skeleton.HP}\nMax Damage: {skeleton.Damage}");
                            Console.WriteLine($"\nPlayer -- {user.Name}:\nLevel: {user.Level} || HP: {user.HP}\nAmour Value: {user.Armour} || Potions: {user.Potions}");
                            Console.ReadLine();
                        }
                        AttackStart();

                        switch (selectedChoice)
                        {
                            case 0:
                                Random Shoot = new Random();
                                int shootAttack = Shoot.Next(5, 20);
                                Console.WriteLine($"\n\nYour Attack dealt {shootAttack} to the enemy!\nSkeleton HP is now {skeleton2.HP - shootAttack}.\n");
                                skeleton2.HP = skeleton2.HP - shootAttack;
                                Console.ReadLine();


                                if (skeleton2.HP <= 0)
                                {
                                    skeleton2.HP = 0;
                                    Console.WriteLine("The Skeleton has Died...");
                                    Console.WriteLine("You gained 98 EXP. You reached Level 4!");
                                    user.Level = 4;  // <-- Exp +100 for Levels (100, 200, 300, 400, Etc...) (xp after lvl 1 146 == 64 until 3) - 61 = ***39 for lvl 4*** ***59 Until 5***
                                    Console.WriteLine("Health has been restored");
                                    user.HP = 100;
                                    Console.ReadLine();
                                }

                                else if (skeleton2.HP > 0)
                                {
                                    Console.WriteLine("\nEnemies Turn...\n");
                                    Console.ReadLine();
                                    Random enemyAtt = new Random();
                                    int enemyAttack = enemyAtt.Next(31);
                                    Console.WriteLine($"\n\nEnemy Deals {enemyAttack} to you!\n{user.Name}'s HP: {user.HP - enemyAttack}");
                                    user.HP = user.HP - enemyAttack;
                                    if (user.HP <= 0)
                                    {
                                        Console.WriteLine($"\nGAME OVER... {user.Name} Has Died...");
                                        Console.WriteLine("Play Again? Y/N");
                                        string key = Console.ReadLine();
                                        if (key == "Y")
                                        {
                                            Console.WriteLine("Returning to Main Menu...");
                                            RunMainMenu();
                                        }
                                        else if (key == "N")
                                        {
                                            ExitGame();
                                        }
                                        Console.ReadLine();
                                    }
                                    Console.ReadLine();
                                    Console.Clear();


                                    string[] menuOptions = { "Attack", "Block", "Flee", "HP Potion" };
                                    AttackMenu attackMenu = new AttackMenu(menuOptions, Prompt1);
                                    int selectedChoice = attackMenu.Run();

                                    switch (selectedChoice)
                                    {
                                        case 0:
                                            AttackFinal();
                                            break;
                                        case 1:
                                            Block();
                                            break;
                                        case 2:
                                            Flee();
                                            break;
                                        case 3:
                                            HPPotion();
                                            break;
                                    }
                                }

                                break;

                            case 1:
                                Random Triple = new Random();
                                int tripleAttack = Triple.Next(20, 50);  // <--TODO Only be used 2 times FIX
                                Console.WriteLine($"\n\nYour Attack dealt {tripleAttack} to the enemy!\nSkeleton HP is now {skeleton2.HP - tripleAttack}.");
                                skeleton2.HP = skeleton2.HP - tripleAttack;
                                Console.ReadKey();
                                if (skeleton2.HP <= 0)
                                {
                                    skeleton2.HP = 0;
                                    Console.WriteLine("The Skeleton has Died...");
                                    Console.WriteLine("You gained 98 EXP. You reached Level 4!");
                                    user.Level = 4;  // <-- Exp +100 for Levels (100, 200, 300, 400, Etc...) (xp after lvl 1 146 == 64 until 3) - 61 = ***39 for lvl 4*** ***59 Until 5***
                                    Console.WriteLine("Health has been restored");
                                    user.HP = 100;
                                    Console.ReadLine();
                                }
                                else if (skeleton2.HP > 0)
                                {
                                    Console.WriteLine("\nEnemies Turn...\n");
                                    Console.ReadLine();
                                    Random enemyAtt = new Random();
                                    int enemyAttack = enemyAtt.Next(31);
                                    Console.WriteLine($"\n\nEnemy Deals {enemyAttack} to you!\n{user.Name}'s HP: {user.HP - enemyAttack}");
                                    user.HP = user.HP - enemyAttack;
                                    if (user.HP <= 0)
                                    {
                                        Console.WriteLine($"\nGAME OVER... {user.Name} Has Died...");

                                        Console.WriteLine("Play Again? Y/N");
                                        string key = Console.ReadLine();
                                        if (key == "Y")
                                        {
                                            Console.WriteLine("Returning to Main Menu...");
                                            RunMainMenu();
                                        }
                                        else if (key == "N")
                                        {
                                            ExitGame();
                                        }

                                        Console.ReadLine();
                                        RunMainMenu();
                                    }
                                    Console.ReadLine();
                                    Console.Clear();


                                    string[] menuOptions = { "Attack", "Block", "Flee", "HP Potion" };
                                    AttackMenu attackMenu = new AttackMenu(menuOptions, Prompt1);
                                    int selectedChoice = attackMenu.Run();

                                    switch (selectedChoice)
                                    {
                                        case 0:
                                            AttackFinal();
                                            break;
                                        case 1:
                                            Block();
                                            break;
                                        case 2:
                                            Flee();
                                            break;
                                        case 3:
                                            HPPotion();
                                            break;
                                    }
                                }
                                break;
                            case 2:

                                Random Aimed = new Random();
                                int aimedAttack = Aimed.Next(5, 25);
                                Console.WriteLine($"\n\nYour Attack dealt {aimedAttack} to the enemy!\nSkeleton HP is now {skeleton2.HP - aimedAttack}.");
                                skeleton2.HP = skeleton2.HP - aimedAttack;
                                Console.ReadKey();
                                if (skeleton2.HP <= 0)
                                {
                                    skeleton2.HP = 0;
                                    Console.WriteLine("The Skeleton has Died...");
                                    Console.WriteLine("You gained 98 EXP. You reached Level 4!");
                                    user.Level = 4;  // <-- Exp +100 for Levels (100, 200, 300, 400, Etc...) (xp after lvl 1 146 == 64 until 3) - 61 = ***39 for lvl 4*** ***59 Until 5***
                                    Console.WriteLine("Health has been restored");
                                    user.HP = 100;
                                    Console.ReadLine();
                                }
                                else if (skeleton2.HP > 0)
                                {
                                    Console.WriteLine("\nEnemies Turn...\n");
                                    Console.ReadLine();
                                    Random enemyAtt = new Random();
                                    int enemyAttack = enemyAtt.Next(31);
                                    Console.WriteLine($"\n\nEnemy Deals {enemyAttack} to you!\n{user.Name}'s HP: {user.HP - enemyAttack}");
                                    user.HP = user.HP - enemyAttack;
                                    if (user.HP <= 0)
                                    {
                                        Console.WriteLine($"\nGAME OVER... {user.Name} Has Died...");
                                        Console.WriteLine("Play Again? Y/N");
                                        string key = Console.ReadLine();
                                        if (key == "Y")
                                        {
                                            Console.WriteLine("Returning to Main Menu...");
                                            RunMainMenu();
                                        }
                                        else if (key == "N")
                                        {
                                            ExitGame();
                                        }
                                        Console.ReadLine();

                                    }
                                    Console.ReadLine();
                                    Console.Clear();


                                    string[] menuOptions = { "Attack", "Block", "Flee", "HP Potion" };
                                    AttackMenu attackMenu = new AttackMenu(menuOptions, Prompt1);
                                    int selectedChoice = attackMenu.Run();

                                    switch (selectedChoice)
                                    {
                                        case 0:
                                            AttackFinal();
                                            break;
                                        case 1:
                                            Block();
                                            break;
                                        case 2:
                                            Flee();
                                            break;
                                        case 3:
                                            HPPotion();
                                            break;
                                    }
                                }
                                break;
                        }

                    }      // Giant Skeleton [  ]

                    void AttackFinal1()
                    {
                        void AttackStart()
                        {

                            ArcaneSkeleton skeleton2 = new ArcaneSkeleton(4, 80, 30, Prompt1);
                            string[] menuOptions = { "Shoot", "Triple Shot", "Aimed Shot" };
                            AttackMenu attackMenu = new AttackMenu(menuOptions, Prompt1);
                            int selectedChoice = attackMenu.Run();
                            Console.WriteLine($"\nEnemy -- Arcane Skeleton:\nLevel: {skeleton2.Level} || HP: {skeleton2.HP}\nMax Damage: {skeleton2.Damage}");
                            Console.WriteLine($"\nPlayer -- {user.Name}:\nLevel: {user.Level} || HP: {user.HP}\nAmour Value: {user.Armour} || Potions: {user.Potions}");
                            Console.ReadLine();
                        }
                        AttackStart();

                        switch (selectedChoice)
                        {
                            case 0:
                                Random Shoot = new Random();
                                int shootAttack = Shoot.Next(5, 20);
                                Console.WriteLine($"\n\nYour Attack dealt {shootAttack} to the enemy!\nSkeleton HP is now {skeleton2.HP - shootAttack}.\n");
                                skeleton2.HP = skeleton2.HP - shootAttack;
                                Console.ReadLine();


                                if (skeleton2.HP <= 0)
                                {
                                    skeleton2.HP = 0;
                                    Console.WriteLine("The Skeleton has Died...");
                                    Console.WriteLine("You gained 98 EXP. You reached Level 4!");
                                    user.Level = 4;  // <-- Exp +100 for Levels (100, 200, 300, 400, Etc...) (xp after lvl 1 146 == 64 until 3) - 61 = ***39 for lvl 4*** ***59 Until 5***
                                    Console.WriteLine("Health has been restored");
                                    user.HP = 100;
                                    Console.ReadLine();
                                }

                                else if (skeleton2.HP > 0)
                                {
                                    Console.WriteLine("\nEnemies Turn...\n");
                                    Console.ReadLine();
                                    Random enemyAtt = new Random();
                                    int enemyAttack = enemyAtt.Next(31);
                                    Console.WriteLine($"\n\nEnemy Deals {enemyAttack} to you!\n{user.Name}'s HP: {user.HP - enemyAttack}");
                                    user.HP = user.HP - enemyAttack;
                                    if (user.HP <= 0)
                                    {
                                        Console.WriteLine($"\nGAME OVER... {user.Name} Has Died...");
                                        Console.WriteLine("Play Again? Y/N");
                                        string key = Console.ReadLine();
                                        if (key == "Y")
                                        {
                                            Console.WriteLine("Returning to Main Menu...");
                                            RunMainMenu();
                                        }
                                        else if (key == "N")
                                        {
                                            ExitGame();
                                        }
                                        Console.ReadLine();
                                    }
                                    Console.ReadLine();
                                    Console.Clear();


                                    string[] menuOptions = { "Attack", "Block", "Flee", "HP Potion" };
                                    AttackMenu attackMenu = new AttackMenu(menuOptions, Prompt1);
                                    int selectedChoice = attackMenu.Run();

                                    switch (selectedChoice)
                                    {
                                        case 0:
                                            AttackFinal1();
                                            break;
                                        case 1:
                                            Block();
                                            break;
                                        case 2:
                                            Flee();
                                            break;
                                        case 3:
                                            HPPotion();
                                            break;
                                    }
                                }

                                break;

                            case 1:
                                Random Triple = new Random();
                                int tripleAttack = Triple.Next(20, 50);  // <--TODO Only be used 2 times FIX
                                Console.WriteLine($"\n\nYour Attack dealt {tripleAttack} to the enemy!\nSkeleton HP is now {skeleton2.HP - tripleAttack}.");
                                skeleton2.HP = skeleton2.HP - tripleAttack;
                                Console.ReadKey();
                                if (skeleton2.HP <= 0)
                                {
                                    skeleton2.HP = 0;
                                    Console.WriteLine("The Skeleton has Died...");
                                    Console.WriteLine("You gained 98 EXP. You reached Level 4!");
                                    user.Level = 4;  // <-- Exp +100 for Levels (100, 200, 300, 400, Etc...) (xp after lvl 1 146 == 64 until 3) - 61 = ***39 for lvl 4*** ***59 Until 5***
                                    Console.WriteLine("Health has been restored");
                                    user.HP = 100;
                                    Console.ReadLine();
                                }
                                else if (skeleton2.HP > 0)
                                {
                                    Console.WriteLine("\nEnemies Turn...\n");
                                    Console.ReadLine();
                                    Random enemyAtt = new Random();
                                    int enemyAttack = enemyAtt.Next(31);
                                    Console.WriteLine($"\n\nEnemy Deals {enemyAttack} to you!\n{user.Name}'s HP: {user.HP - enemyAttack}");
                                    user.HP = user.HP - enemyAttack;
                                    if (user.HP <= 0)
                                    {
                                        Console.WriteLine($"\nGAME OVER... {user.Name} Has Died...");

                                        Console.WriteLine("Play Again? Y/N");
                                        string key = Console.ReadLine();
                                        if (key == "Y")
                                        {
                                            Console.WriteLine("Returning to Main Menu...");
                                            RunMainMenu();
                                        }
                                        else if (key == "N")
                                        {
                                            ExitGame();
                                        }

                                        Console.ReadLine();
                                        RunMainMenu();
                                    }
                                    Console.ReadLine();
                                    Console.Clear();


                                    string[] menuOptions = { "Attack", "Block", "Flee", "HP Potion" };
                                    AttackMenu attackMenu = new AttackMenu(menuOptions, Prompt1);
                                    int selectedChoice = attackMenu.Run();

                                    switch (selectedChoice)
                                    {
                                        case 0:
                                            AttackFinal1();
                                            break;
                                        case 1:
                                            Block();
                                            break;
                                        case 2:
                                            Flee();
                                            break;
                                        case 3:
                                            HPPotion();
                                            break;
                                    }
                                }
                                break;
                            case 2:

                                Random Aimed = new Random();
                                int aimedAttack = Aimed.Next(5, 25);
                                Console.WriteLine($"\n\nYour Attack dealt {aimedAttack} to the enemy!\nSkeleton HP is now {skeleton2.HP - aimedAttack}.");
                                skeleton2.HP = skeleton2.HP - aimedAttack;
                                Console.ReadKey();
                                if (skeleton2.HP <= 0)
                                {
                                    skeleton2.HP = 0;
                                    Console.WriteLine("The Skeleton has Died...");
                                    Console.WriteLine("You gained 98 EXP. You reached Level 4!");
                                    user.Level = 4;  // <-- Exp +100 for Levels (100, 200, 300, 400, Etc...) (xp after lvl 1 146 == 64 until 3) - 61 = ***39 for lvl 4*** ***59 Until 5***
                                    Console.WriteLine("Health has been restored");
                                    user.HP = 100;
                                    Console.ReadLine();
                                }
                                else if (skeleton2.HP > 0)
                                {
                                    Console.WriteLine("\nEnemies Turn...\n");
                                    Console.ReadLine();
                                    Random enemyAtt = new Random();
                                    int enemyAttack = enemyAtt.Next(31);
                                    Console.WriteLine($"\n\nEnemy Deals {enemyAttack} to you!\n{user.Name}'s HP: {user.HP - enemyAttack}");
                                    user.HP = user.HP - enemyAttack;
                                    if (user.HP <= 0)
                                    {
                                        Console.WriteLine($"\nGAME OVER... {user.Name} Has Died...");
                                        Console.WriteLine("Play Again? Y/N");
                                        string key = Console.ReadLine();
                                        if (key == "Y")
                                        {
                                            Console.WriteLine("Returning to Main Menu...");
                                            RunMainMenu();
                                        }
                                        else if (key == "N")
                                        {
                                            ExitGame();
                                        }
                                        Console.ReadLine();

                                    }
                                    Console.ReadLine();
                                    Console.Clear();


                                    string[] menuOptions = { "Attack", "Block", "Flee", "HP Potion" };
                                    AttackMenu attackMenu = new AttackMenu(menuOptions, Prompt1);
                                    int selectedChoice = attackMenu.Run();

                                    switch (selectedChoice)
                                    {
                                        case 0:
                                            AttackFinal1();
                                            break;
                                        case 1:
                                            Block();
                                            break;
                                        case 2:
                                            Flee();
                                            break;
                                        case 3:
                                            HPPotion();
                                            break;
                                    }
                                }
                                break;
                        }

                    }     // Arcane Skeleton [  ]

                    void AttackFinal2()
                    {
                        void AttackStart()
                        {

                            ArcaneSkeleton skeleton2 = new ArcaneSkeleton(4, 80, 30, Prompt1);
                            string[] menuOptions = { "Shoot", "Triple Shot", "Aimed Shot" };
                            AttackMenu attackMenu = new AttackMenu(menuOptions, Prompt1);
                            int selectedChoice = attackMenu.Run();
                            Console.WriteLine($"\nEnemy -- Arcane Skeleton:\nLevel: {skeleton2.Level} || HP: {skeleton2.HP}\nMax Damage: {skeleton2.Damage}");
                            Console.WriteLine($"\nPlayer -- {user.Name}:\nLevel: {user.Level} || HP: {user.HP}\nAmour Value: {user.Armour} || Potions: {user.Potions}");
                            Console.ReadLine();
                        }
                        AttackStart();

                        switch (selectedChoice)
                        {
                            case 0:
                                Random Shoot = new Random();
                                int shootAttack = Shoot.Next(5, 20);
                                Console.WriteLine($"\n\nYour Attack dealt {shootAttack} to the enemy!\nSkeleton HP is now {skeleton2.HP - shootAttack}.\n");
                                skeleton2.HP = skeleton2.HP - shootAttack;
                                Console.ReadLine();


                                if (skeleton2.HP <= 0)
                                {
                                    skeleton2.HP = 0;
                                    Console.WriteLine("The Skeleton has Died...");
                                    Console.WriteLine("You gained 98 EXP. You reached Level 4!");
                                    user.Level = 4;  // <-- Exp +100 for Levels (100, 200, 300, 400, Etc...) (xp after lvl 1 146 == 64 until 3) - 61 = ***39 for lvl 4*** ***59 Until 5***
                                    Console.WriteLine("Health has been restored");
                                    user.HP = 100;
                                    Console.ReadLine();
                                }

                                else if (skeleton2.HP > 0)
                                {
                                    Console.WriteLine("\nEnemies Turn...\n");
                                    Console.ReadLine();
                                    Random enemyAtt = new Random();
                                    int enemyAttack = enemyAtt.Next(31);
                                    Console.WriteLine($"\n\nEnemy Deals {enemyAttack} to you!\n{user.Name}'s HP: {user.HP - enemyAttack}");
                                    user.HP = user.HP - enemyAttack;
                                    if (user.HP <= 0)
                                    {
                                        Console.WriteLine($"\nGAME OVER... {user.Name} Has Died...");
                                        Console.WriteLine("Play Again? Y/N");
                                        string key = Console.ReadLine();
                                        if (key == "Y")
                                        {
                                            Console.WriteLine("Returning to Main Menu...");
                                            RunMainMenu();
                                        }
                                        else if (key == "N")
                                        {
                                            ExitGame();
                                        }
                                        Console.ReadLine();
                                    }
                                    Console.ReadLine();
                                    Console.Clear();


                                    string[] menuOptions = { "Attack", "Block", "Flee", "HP Potion" };
                                    AttackMenu attackMenu = new AttackMenu(menuOptions, Prompt1);
                                    int selectedChoice = attackMenu.Run();

                                    switch (selectedChoice)
                                    {
                                        case 0:
                                            AttackFinal2();
                                            break;
                                        case 1:
                                            Block();
                                            break;
                                        case 2:
                                            Flee();
                                            break;
                                        case 3:
                                            HPPotion();
                                            break;
                                    }
                                }

                                break;

                            case 1:
                                Random Triple = new Random();
                                int tripleAttack = Triple.Next(20, 50);  // <--TODO Only be used 2 times FIX
                                Console.WriteLine($"\n\nYour Attack dealt {tripleAttack} to the enemy!\nSkeleton HP is now {skeleton2.HP - tripleAttack}.");
                                skeleton2.HP = skeleton2.HP - tripleAttack;
                                Console.ReadKey();
                                if (skeleton2.HP <= 0)
                                {
                                    skeleton2.HP = 0;
                                    Console.WriteLine("The Skeleton has Died...");
                                    Console.WriteLine("You gained 98 EXP. You reached Level 4!");
                                    user.Level = 4;  // <-- Exp +100 for Levels (100, 200, 300, 400, Etc...) (xp after lvl 1 146 == 64 until 3) - 61 = ***39 for lvl 4*** ***59 Until 5***
                                    Console.WriteLine("Health has been restored");
                                    user.HP = 100;
                                    Console.ReadLine();
                                }
                                else if (skeleton2.HP > 0)
                                {
                                    Console.WriteLine("\nEnemies Turn...\n");
                                    Console.ReadLine();
                                    Random enemyAtt = new Random();
                                    int enemyAttack = enemyAtt.Next(31);
                                    Console.WriteLine($"\n\nEnemy Deals {enemyAttack} to you!\n{user.Name}'s HP: {user.HP - enemyAttack}");
                                    user.HP = user.HP - enemyAttack;
                                    if (user.HP <= 0)
                                    {
                                        Console.WriteLine($"\nGAME OVER... {user.Name} Has Died...");

                                        Console.WriteLine("Play Again? Y/N");
                                        string key = Console.ReadLine();
                                        if (key == "Y")
                                        {
                                            Console.WriteLine("Returning to Main Menu...");
                                            RunMainMenu();
                                        }
                                        else if (key == "N")
                                        {
                                            ExitGame();
                                        }

                                        Console.ReadLine();
                                        RunMainMenu();
                                    }
                                    Console.ReadLine();
                                    Console.Clear();


                                    string[] menuOptions = { "Attack", "Block", "Flee", "HP Potion" };
                                    AttackMenu attackMenu = new AttackMenu(menuOptions, Prompt1);
                                    int selectedChoice = attackMenu.Run();

                                    switch (selectedChoice)
                                    {
                                        case 0:
                                            AttackFinal2();
                                            break;
                                        case 1:
                                            Block();
                                            break;
                                        case 2:
                                            Flee();
                                            break;
                                        case 3:
                                            HPPotion();
                                            break;
                                    }
                                }
                                break;
                            case 2:

                                Random Aimed = new Random();
                                int aimedAttack = Aimed.Next(5, 25);
                                Console.WriteLine($"\n\nYour Attack dealt {aimedAttack} to the enemy!\nSkeleton HP is now {skeleton2.HP - aimedAttack}.");
                                skeleton2.HP = skeleton2.HP - aimedAttack;
                                Console.ReadKey();
                                if (skeleton2.HP <= 0)
                                {
                                    skeleton2.HP = 0;
                                    Console.WriteLine("The Skeleton has Died...");
                                    Console.WriteLine("You gained 98 EXP. You reached Level 4!");
                                    user.Level = 4;  // <-- Exp +100 for Levels (100, 200, 300, 400, Etc...) (xp after lvl 1 146 == 64 until 3) - 61 = ***39 for lvl 4*** ***59 Until 5***
                                    Console.WriteLine("Health has been restored");
                                    user.HP = 100;
                                    Console.ReadLine();
                                }
                                else if (skeleton2.HP > 0)
                                {
                                    Console.WriteLine("\nEnemies Turn...\n");
                                    Console.ReadLine();
                                    Random enemyAtt = new Random();
                                    int enemyAttack = enemyAtt.Next(31);
                                    Console.WriteLine($"\n\nEnemy Deals {enemyAttack} to you!\n{user.Name}'s HP: {user.HP - enemyAttack}");
                                    user.HP = user.HP - enemyAttack;
                                    if (user.HP <= 0)
                                    {
                                        Console.WriteLine($"\nGAME OVER... {user.Name} Has Died...");
                                        Console.WriteLine("Play Again? Y/N");
                                        string key = Console.ReadLine();
                                        if (key == "Y")
                                        {
                                            Console.WriteLine("Returning to Main Menu...");
                                            RunMainMenu();
                                        }
                                        else if (key == "N")
                                        {
                                            ExitGame();
                                        }
                                        Console.ReadLine();

                                    }
                                    Console.ReadLine();
                                    Console.Clear();


                                    string[] menuOptions = { "Attack", "Block", "Flee", "HP Potion" };
                                    AttackMenu attackMenu = new AttackMenu(menuOptions, Prompt1);
                                    int selectedChoice = attackMenu.Run();

                                    switch (selectedChoice)
                                    {
                                        case 0:
                                            AttackFinal2();
                                            break;
                                        case 1:
                                            Block();
                                            break;
                                        case 2:
                                            Flee();
                                            break;
                                        case 3:
                                            HPPotion();
                                            break;
                                    }
                                }
                                break;
                        }

                    }     // Blood Skeleton [  ]

                    void AttackFinal3()
                    {
                        void AttackStart()
                        {

                            ArcaneSkeleton skeleton2 = new ArcaneSkeleton(4, 80, 30, Prompt1);
                            string[] menuOptions = { "Shoot", "Triple Shot", "Aimed Shot" };
                            AttackMenu attackMenu = new AttackMenu(menuOptions, Prompt1);
                            int selectedChoice = attackMenu.Run();
                            Console.WriteLine($"\nEnemy -- Arcane Skeleton:\nLevel: {skeleton2.Level} || HP: {skeleton2.HP}\nMax Damage: {skeleton2.Damage}");
                            Console.WriteLine($"\nPlayer -- {user.Name}:\nLevel: {user.Level} || HP: {user.HP}\nAmour Value: {user.Armour} || Potions: {user.Potions}");
                            Console.ReadLine();
                        }
                        AttackStart();

                        switch (selectedChoice)
                        {
                            case 0:
                                Random Shoot = new Random();
                                int shootAttack = Shoot.Next(5, 20);
                                Console.WriteLine($"\n\nYour Attack dealt {shootAttack} to the enemy!\nSkeleton HP is now {skeleton2.HP - shootAttack}.\n");
                                skeleton2.HP = skeleton2.HP - shootAttack;
                                Console.ReadLine();


                                if (skeleton2.HP <= 0)
                                {
                                    skeleton2.HP = 0;
                                    Console.WriteLine("The Skeleton has Died...");
                                    Console.WriteLine("You gained 98 EXP. You reached Level 4!");
                                    user.Level = 4;  // <-- Exp +100 for Levels (100, 200, 300, 400, Etc...) (xp after lvl 1 146 == 64 until 3) - 61 = ***39 for lvl 4*** ***59 Until 5***
                                    Console.WriteLine("Health has been restored");
                                    user.HP = 100;
                                    Console.ReadLine();
                                }

                                else if (skeleton2.HP > 0)
                                {
                                    Console.WriteLine("\nEnemies Turn...\n");
                                    Console.ReadLine();
                                    Random enemyAtt = new Random();
                                    int enemyAttack = enemyAtt.Next(31);
                                    Console.WriteLine($"\n\nEnemy Deals {enemyAttack} to you!\n{user.Name}'s HP: {user.HP - enemyAttack}");
                                    user.HP = user.HP - enemyAttack;
                                    if (user.HP <= 0)
                                    {
                                        Console.WriteLine($"\nGAME OVER... {user.Name} Has Died...");
                                        Console.WriteLine("Play Again? Y/N");
                                        string key = Console.ReadLine();
                                        if (key == "Y")
                                        {
                                            Console.WriteLine("Returning to Main Menu...");
                                            RunMainMenu();
                                        }
                                        else if (key == "N")
                                        {
                                            ExitGame();
                                        }
                                        Console.ReadLine();
                                    }
                                    Console.ReadLine();
                                    Console.Clear();


                                    string[] menuOptions = { "Attack", "Block", "Flee", "HP Potion" };
                                    AttackMenu attackMenu = new AttackMenu(menuOptions, Prompt1);
                                    int selectedChoice = attackMenu.Run();

                                    switch (selectedChoice)
                                    {
                                        case 0:
                                            AttackFinal3();
                                            break;
                                        case 1:
                                            Block();
                                            break;
                                        case 2:
                                            Flee();
                                            break;
                                        case 3:
                                            HPPotion();
                                            break;
                                    }
                                }

                                break;

                            case 1:
                                Random Triple = new Random();
                                int tripleAttack = Triple.Next(20, 50);  // <--TODO Only be used 2 times FIX
                                Console.WriteLine($"\n\nYour Attack dealt {tripleAttack} to the enemy!\nSkeleton HP is now {skeleton2.HP - tripleAttack}.");
                                skeleton2.HP = skeleton2.HP - tripleAttack;
                                Console.ReadKey();
                                if (skeleton2.HP <= 0)
                                {
                                    skeleton2.HP = 0;
                                    Console.WriteLine("The Skeleton has Died...");
                                    Console.WriteLine("You gained 98 EXP. You reached Level 4!");
                                    user.Level = 4;  // <-- Exp +100 for Levels (100, 200, 300, 400, Etc...) (xp after lvl 1 146 == 64 until 3) - 61 = ***39 for lvl 4*** ***59 Until 5***
                                    Console.WriteLine("Health has been restored");
                                    user.HP = 100;
                                    Console.ReadLine();
                                }
                                else if (skeleton2.HP > 0)
                                {
                                    Console.WriteLine("\nEnemies Turn...\n");
                                    Console.ReadLine();
                                    Random enemyAtt = new Random();
                                    int enemyAttack = enemyAtt.Next(31);
                                    Console.WriteLine($"\n\nEnemy Deals {enemyAttack} to you!\n{user.Name}'s HP: {user.HP - enemyAttack}");
                                    user.HP = user.HP - enemyAttack;
                                    if (user.HP <= 0)
                                    {
                                        Console.WriteLine($"\nGAME OVER... {user.Name} Has Died...");

                                        Console.WriteLine("Play Again? Y/N");
                                        string key = Console.ReadLine();
                                        if (key == "Y")
                                        {
                                            Console.WriteLine("Returning to Main Menu...");
                                            RunMainMenu();
                                        }
                                        else if (key == "N")
                                        {
                                            ExitGame();
                                        }

                                        Console.ReadLine();
                                        RunMainMenu();
                                    }
                                    Console.ReadLine();
                                    Console.Clear();


                                    string[] menuOptions = { "Attack", "Block", "Flee", "HP Potion" };
                                    AttackMenu attackMenu = new AttackMenu(menuOptions, Prompt1);
                                    int selectedChoice = attackMenu.Run();

                                    switch (selectedChoice)
                                    {
                                        case 0:
                                            AttackFinal3();
                                            break;
                                        case 1:
                                            Block();
                                            break;
                                        case 2:
                                            Flee();
                                            break;
                                        case 3:
                                            HPPotion();
                                            break;
                                    }
                                }
                                break;
                            case 2:

                                Random Aimed = new Random();
                                int aimedAttack = Aimed.Next(5, 25);
                                Console.WriteLine($"\n\nYour Attack dealt {aimedAttack} to the enemy!\nSkeleton HP is now {skeleton2.HP - aimedAttack}.");
                                skeleton2.HP = skeleton2.HP - aimedAttack;
                                Console.ReadKey();
                                if (skeleton2.HP <= 0)
                                {
                                    skeleton2.HP = 0;
                                    Console.WriteLine("The Skeleton has Died...");
                                    Console.WriteLine("You gained 98 EXP. You reached Level 4!");
                                    user.Level = 4;  // <-- Exp +100 for Levels (100, 200, 300, 400, Etc...) (xp after lvl 1 146 == 64 until 3) - 61 = ***39 for lvl 4*** ***59 Until 5***
                                    Console.WriteLine("Health has been restored");
                                    user.HP = 100;
                                    Console.ReadLine();
                                }
                                else if (skeleton2.HP > 0)
                                {
                                    Console.WriteLine("\nEnemies Turn...\n");
                                    Console.ReadLine();
                                    Random enemyAtt = new Random();
                                    int enemyAttack = enemyAtt.Next(31);
                                    Console.WriteLine($"\n\nEnemy Deals {enemyAttack} to you!\n{user.Name}'s HP: {user.HP - enemyAttack}");
                                    user.HP = user.HP - enemyAttack;
                                    if (user.HP <= 0)
                                    {
                                        Console.WriteLine($"\nGAME OVER... {user.Name} Has Died...");
                                        Console.WriteLine("Play Again? Y/N");
                                        string key = Console.ReadLine();
                                        if (key == "Y")
                                        {
                                            Console.WriteLine("Returning to Main Menu...");
                                            RunMainMenu();
                                        }
                                        else if (key == "N")
                                        {
                                            ExitGame();
                                        }
                                        Console.ReadLine();

                                    }
                                    Console.ReadLine();
                                    Console.Clear();


                                    string[] menuOptions = { "Attack", "Block", "Flee", "HP Potion" };
                                    AttackMenu attackMenu = new AttackMenu(menuOptions, Prompt1);
                                    int selectedChoice = attackMenu.Run();

                                    switch (selectedChoice)
                                    {
                                        case 0:
                                            AttackFinal3();
                                            break;
                                        case 1:
                                            Block();
                                            break;
                                        case 2:
                                            Flee();
                                            break;
                                        case 3:
                                            HPPotion();
                                            break;
                                    }
                                }
                                break;
                        }

                    }     // Final :: Elder Skeleton [  ]

                    void Block()
                    {
                        string[] menuOptions = { "Attack", "Block", "Flee", "HP Potion" };
                        AttackMenu attackMenu = new AttackMenu(menuOptions, Prompt1);
                        int selectedChoice = attackMenu.Run();

                        switch (selectedChoice)
                        {
                            case 0:
                                AttackFinal3();
                                break;
                            case 1:
                                Block();
                                break;
                            case 2:
                                Flee();
                                break;
                            case 3:
                                HPPotion();
                                break;
                        }
                    }

                    void Flee()
                    {
                        Random enemyAtt = new Random();
                        int enemyAttack = enemyAtt.Next(11);
                        Console.WriteLine($"\nRun Attempt Failed!\n");
                        Console.WriteLine($"\n\nEnemy Deals {enemyAttack} to you!\n{user.Name}'s HP: {user.HP - enemyAttack}");
                        user.HP = user.HP - enemyAttack;
                        Console.ReadLine();
                        Console.Clear();

                        string[] menuOptions = { "Attack", "Block", "Flee", "HP Potion" };
                        AttackMenu attackMenu = new AttackMenu(menuOptions, Prompt1);
                        int selectedChoice = attackMenu.Run();

                        switch (selectedChoice)
                        {
                            case 0:
                                AttackFinal3();
                                break;
                            case 1:
                                Block();
                                break;
                            case 2:
                                Flee();
                                break;
                            case 3:
                                HPPotion();
                                break;
                        }
                    }

                    void HPPotion()
                    {
                        if (user.Potions > 0)
                        {
                            int HPPotion = 30;
                            Console.WriteLine($"{user.Name} grabs a potion and gulps it down.");

                            if (user.HP <= 100)
                            {
                                user.HP = user.HP + HPPotion;

                                user.Potions--;

                                if (user.HP >= 100)
                                {
                                    user.HP = 100;
                                    Console.WriteLine("Health is Full\n");
                                }

                                Console.WriteLine($"{user.Name}'s HP: {user.HP}");
                            }
                            else if (user.HP == 100)
                            {
                                Console.WriteLine("Already at Max HP");
                            }
                        }
                        else if (user.Potions <= 0)
                        {
                            user.Potions = 0;
                            Console.WriteLine("Oops... No HP Potions Left... Good Luck!");
                        }
                        Console.ReadKey();
                        string[] menuOptions = { "Attack", "Block", "Flee", "HP Potion" };
                        AttackMenu attackMenu = new AttackMenu(menuOptions, Prompt1);
                        int selectedChoice = attackMenu.Run();

                        switch (selectedChoice)
                        {
                            case 0:
                                AttackFinal3();
                                break;
                            case 1:
                                Block();
                                break;
                            case 2:
                                Flee();
                                break;
                            case 3:
                                HPPotion();
                                break;
                        }

                    }

                } while (user.HP < 0);

                BattleFinal();
            }

            #endregion

            ExitGame();

            
        }
    }
}


///TODO BLOCK () 
///TODO FINAL BATTLE COMPLETED
///TODO MAKE ATTACK MENU ART DIFFERENT FOR EACH BATTLE
///TODO ADD DESCRIPTIONS TO EACH ATTACK

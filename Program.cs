using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace textAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            gameTitle();
            first();

        }
        //writing to the console
        public static void gameTitle()
        {
            Console.WriteLine("The Hurt from Within.");
            Console.WriteLine("Press 'Enter' to begin.");
            Console.ReadLine();
            Console.Clear();
            first();

        }
        // switches
        public static void first()
        {
            string choice;

            Console.WriteLine("You wakeup from a nap and your stomach is making a loud noise");
            Console.WriteLine("What do you do?");
            Console.WriteLine("1. go to the kitchen to look for something to eat");
            Console.WriteLine("2. run to the bathroom");
            Console.WriteLine("3. roll back over and go back to sleep");
            Console.Write("Choice: ");
            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "1":
                case "seek food":
                case "food":
                    {
                        Console.WriteLine("you open the fridge and see a pizza box.");
                        Console.WriteLine("you open the box and there is only crust leftover ,Just great.");
                        Console.WriteLine("you close the box and open the cabinets, you find a can of beans that expire 3 year ago.");
                        Console.WriteLine("you YELL there is never any food in this house ");
                        Console.WriteLine("Then you found a can of soup, well something is better then nothing.");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        gameOver();
                        break;
                    }
                case "2":
                case "Run to Bathroom":
                    {
                        Console.WriteLine("you go to the bathroom as your about to sit down, you notice you don't see any tissue.");
                        Console.WriteLine("you run to find some in the house but your out of luck");
                        Console.WriteLine("there has to be some tissue somewhere! ");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        second();
                        break;
                    }
                case "3":
                case "bed":
                case "back to bed":
                    {
                        Console.WriteLine("You gather up all your blankets and turn right back over");
                        Console.WriteLine("thinking to yourself it nothing but gas.");
                        Console.WriteLine("I should feel better after my nap.");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ReadLine();
                        Console.Clear();
                        gameTitle();
                        break;
                    }
                default:
                    {

                        Console.WriteLine("Command is invalid...");
                        Console.WriteLine("Press 'Enter' to restart.");
                        Console.ReadLine();
                        first();
                        second();
                        third();
                        break;
                    }
            }
        }
        //  using random number generator and allowing player to enter text response 
        public static void second()
        {
            Random rnd = new Random();
            string[] secondOptions = { "Your stomach begins to growl, Should you go to the store to buy some tissue?" };
            int randomNumber = rnd.Next(0, 1);
            string secText = secondOptions[randomNumber];

            string secChoice;

            Console.WriteLine(secText);
            Console.Write("Choice: ");
            secChoice = Console.ReadLine().ToLower();

            if (secChoice == "yes" || secChoice == "y")

            {

                third();
                Console.Clear();


            }
            else if (secChoice == "no" || secChoice == "n")
            {
                Console.WriteLine("You stand idle and start feeling something cribing down your legs");
                Console.WriteLine("Well i guess the shower is for me.");
                Console.ReadLine();
                Console.Clear();
                gameTitle();

            }
            else
            {
                Console.WriteLine("You must reply Yes or no.");
                Console.WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                second();
            }

        }

        //using loops

        public static void third()

        {
            int Decision;
            Console.WriteLine(" they have no tissue just 3 sheets of paper towels ");
            Console.WriteLine("your stomach start bubbling and your eyes go wide as you scan the store but nothing can be found");
            Console.WriteLine("Will you take the sheets  or just go back home? Type 1 or 2.");
            Console.Write("Decision: ");
            int.TryParse(Console.ReadLine(), out Decision);
            int loop = 0;
            bool walk = false;
            while (Decision != 1 && walk == false)
            {
                if (loop <= 0)
                {
                    Console.WriteLine("You are moving to slow, your going to have an accident on your self.");
                    Console.WriteLine("Now what are you going to do?");
                    //Console.Write("Decision: ");
                    Console.WriteLine("Press 'Enter' to continue.");
                    int.TryParse(Console.ReadLine(), out Decision);
                    loop++;
                }
                else if (loop >= 1)
                {
                    Console.WriteLine("you grab your pants and scream Lord help me to get home in time.");
                    Console.WriteLine("Fear and adrenaline surge within. Do you run or walk? 1 or 2? ");

                    int.TryParse(Console.ReadLine(), out Decision);
                    walk = true;
                }

            }
            if (walk == true)
            {
                Console.WriteLine("your booty cheeks are squeezed tightly has can be, your arms are shaking and your legs are wobbling");
                Console.ReadLine();
                Console.Clear();
                youWin();
            }
            else

            {
                Console.WriteLine("You grab the sheets and start back to the house.");
                Console.ReadLine();
                youWin();
            }
        }


        public static void gameOver()
        {
            Console.Clear();
            Console.WriteLine("You found something to eat, the loud noise has stopped.");
            Console.WriteLine("stomach is feeling better, you can go back to bed.");
            Console.WriteLine("The End?");
            Console.ReadLine();
            Console.Clear();
            gameTitle();
        }

        public static void youWin()
        {
            Console.Clear();
            Console.WriteLine("You made it back home just in time.");
            Console.WriteLine("but your still getting in the shower.");
            Console.ReadLine();
            Console.Clear();
            gameTitle();
        }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        // 1/14/24
        {
            Console.WindowWidth = 60;
            Console.Title = "Marta's the most beautiful women on earth. <3";

            Console.ForegroundColor = ConsoleColor.Yellow;  // This global manages color.
            Console.WriteLine("Welcome to a Text-Based RPG Game!");
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();

            Console.WriteLine("Hello!");
            Console.WriteLine("What's your name?");

            Console.ForegroundColor = ConsoleColor.White;

            // Grabs the user's name
            string userName = Console.ReadLine();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome " + userName + "!");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Which Race are you?");

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("1. Human");
            Console.WriteLine("2. Animal");
            Console.WriteLine("3. Cat Girl");
            /* Console.WriteLine("4. Ogre"); */
            // anime girl with cat ears and orge [DONE]

            // This is done to make it easier to see
            Console.ForegroundColor = ConsoleColor.White;


            // Grabs the user's race
            int userRace = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            // Goes back to global text color
            Console.ForegroundColor = ConsoleColor.Green;

            if (userRace == 1) {
                Console.WriteLine("You're a Human!");
            }
            if (userRace == 2)
            {
                Console.WriteLine("You're an Animal!");
            }
            if (userRace == 3)
            {
                Console.WriteLine("You're a Cat girl!!");
            }
            else {
                Console.WriteLine("You're an Ogre!");
            }


            // Resets global text color
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Which class are you?");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("WARNING: Your class WILL affect gameplay down the line!!!");
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("1. Mage");
            Console.WriteLine("2. Knight");
            Console.WriteLine("3. Healer");

            Console.ForegroundColor = ConsoleColor.White;


            // Grabs the user's class
            int userClass = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.Green;
            if (userClass == 1)
            {
                Console.WriteLine("You're a Mage!");
            }
            if (userClass == 2)
            {
                Console.WriteLine("You're a Knight!");
            }
            else {
                Console.WriteLine("You're a healer!");
            }

            // Intro sequence
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to the world of Darkroth!");

            /*
            Console.WriteLine("+----------------------+");
            Console.WriteLine("|                      |");
            Console.WriteLine("|                      |");
            Console.WriteLine("|                      |");
            Console.WriteLine("|                      |");
            Console.WriteLine("+----------------------+");
            */

            Console.WriteLine("+----------------------+");
            Console.WriteLine("|   Your Information:  |");
            Console.WriteLine("+----------------------+");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(userName);
            // User Race
            if (userRace == 1)
            {
                Console.WriteLine("You're a Human!");
            }
            if (userRace == 2)
            {
                Console.WriteLine("You're an Animal!");
            }
            else
            {
                Console.WriteLine("You're a Cat girl!!");
            }
            /*  broke game code
            else
            {
                Console.WriteLine("You're an Ogre!");
            } */

            // User Class
            if (userClass == 1)
            {
                Console.WriteLine("You're a Mage!");
            }
            if (userClass == 2)
            {
                Console.WriteLine("You're a Knight!");
            }
            else
            {
                Console.WriteLine("You're a healer!");
            }

            // Starter statistics
            int userMoney = 100;
            int userMage = 20;

            /*
            if (userClass == 1)
            {
                userMage + 80;
            }
            else
            {
                userMage + 0;
            }

            if (y == true)
            {

            }
            */

            // Euro Jank
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("+----------------------+");
            Console.WriteLine("|   Your Information:  |");
            Console.WriteLine("+----------------------+");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(userMoney + " Dollars");
            Console.WriteLine(userMage + " Mana");
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("");
            Console.WriteLine("DARKROTH");
            System.Threading.Thread.Sleep(3500);    // Dramatic
            Console.WriteLine("You spawned on a boat");

            Console.ReadKey();
        }
    }
}

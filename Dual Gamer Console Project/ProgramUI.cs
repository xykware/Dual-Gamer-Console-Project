using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_Startup;

namespace Dual_Gamer_Console_Project
{
    public class ProgramUI
    {
        public void Run()
        {
            StartMenu();
        }

        private void StartMenu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.Clear();
                Console.WriteLine("             Hello.  Welcome to the 1150 Student Simulator 1.0.\n" +
                                  "************************************************************************************\n" +
                                  "         You are about to begin the exciting journey to being a Developer!\n");

                Console.WriteLine("Please Login to Get Started!");
                Console.WriteLine("Select a menu option\n" +
                                  "1. New Game\n" +
                                  "2. Load Game\n" +
                                  "0. Exit");
                string inputA = Console.ReadLine();

                switch (inputA)
                {
                    case "1":
                        // NewGame
                        NewGame();
                        break;
                    case "2":
                        // LoadGame
                        LoadGame();
                        break;
                    case "0":
                        // Exit
                        Console.Clear();
                        Console.WriteLine("Goodbye!");
                        Console.WriteLine("Please press any key to continue...");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number.");
                        break;
                }

                Console.WriteLine("Please press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        // Start a New Game
        private void NewGame()
        {
            Console.Clear();
            Console.WriteLine("Choose a Name for your new self!");
            Console.WriteLine("Name");
            string newName = Console.ReadLine();

            Console.WriteLine("You are born without skills or knowledge.");
            
            // Content here for being able to choose type of character
            
            // Make a New Game
            GameState gameOne = new GameState(newName, 0, 0, 0, 0, 0);
            // Run Game M
        }

        // Load a Saved Game - (P)
        private void LoadGame()
        {
            Console.Clear();
            // Display All Saves M
            Console.WriteLine("Which Save File would you like to continue?");
            string oldGameNumber = Console.ReadLine();
            int oldGameNumberParsed = int.Parse(oldGameNumber);
            // Load Save Game M
            // Run Game M
        }

    }
}
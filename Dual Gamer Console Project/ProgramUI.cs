using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_Startup;
using _04_EventObjectandRepo;
using _05_DataHandlingLib;
using GameUI;

namespace Dual_Gamer_Console_Project
{
    public class ProgramUI
    {
        public GameStateRepo seedRepo = new GameStateRepo();

        public void Run()
        {
            //Seed Here Please
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

            Console.WriteLine("You are born without skills or knowledge.\n");

            // Content here for being able to choose type of character

            Console.WriteLine("Which Saved Game slot would you like to use?");
            string chosenSlot = Console.ReadLine();

            //seedRepo.MakeANewGame();

            // Save Game M (P)
            // GameState gameOne = new GameState(newName, 0, 0, 0, 0, 0); (V)

            //StartTheGUI();
        }

        // Load a Saved Game - (P)
        private void LoadGame()
        {
            Console.Clear();
            // Display All Saves M
            Console.WriteLine("Which Save File would you like to continue?");
            string oldGameNumber = Console.ReadLine();
            int oldGameNumberParsed = int.Parse(oldGameNumber);

            //LoadAnOldgame();

            //StartTheGUI();
        }

        private void StartTheGUI(GameState game)
        {
            //pass gamestate

            //instance eventcontent
            EventContent gameOneEvents = new EventContent();

            //create intital GUI

            //populate intial GUI state - load "intro" event
            BordersLayout gamePlay = new BordersLayout();
            //gamePlay.RunGame(game);

        }

        // Save the Game

        private void SaveGame()
        {
            Console.Clear();
            //Save Game M

            //Exit to Start Menu
            StartMenu();
        }
    }
}
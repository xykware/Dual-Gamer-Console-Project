using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_Startup;
using _03_Session;
using _04_EventObjectandRepo;
using _05_DataHandlingLib;
using GameUI;

namespace Dual_Gamer_Console_Project
{
    public class ProgramUI
    {
        public GameStateRepo seedRepo = new GameStateRepo();
        EventContentRepo eventRepo = new EventContentRepo();

        public void Run()
        {
            SeedData();
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

            GameState newGame = seedRepo.MakeANewGame(newName);

            // Save Game M (P)
            // GameState gameOne = new GameState(newName, 0, 0, 0, 0, 0); (V)

            StartTheGUI(newGame);
        }

        // Load a Saved Game - (P)
        private void LoadGame()
        {
            Console.Clear();
            // Display All Saves M
            Console.WriteLine("Which Save File would you like to continue?");
            string oldGameNumber = Console.ReadLine();
            int oldGameNumberParsed = int.Parse(oldGameNumber);

            GameState loadGame = seedRepo.LoadAnOldgame();

            StartTheGUI(loadGame);
        }

        private void StartTheGUI(GameState game)
        {
            //pass gamestate

            //instance eventcontent
            EventContent gameOneEvents = new EventContent();

            //create intital GUI

            //populate intial GUI state - load "intro" event
            BordersLayout gamePlay = new BordersLayout();

            int eventNumber = 0;

            bool keepGUIRunning = true;

            while (keepGUIRunning)
            {
                int newEventNumber = gamePlay.RunGUI(game, (eventRepo._list[eventNumber]));
                if (newEventNumber < 0)
                {
                    keepGUIRunning = false;
                    //Add save and exit method
                }
                else if (newEventNumber <= eventRepo._list.Count)
                {
                    eventNumber = newEventNumber;
                }
                else
                {
                    keepGUIRunning = false;
                }
            }
        }

        private void SaveGame()
        {
            Console.Clear();
            //Save Game M

            //Exit to Start Menu
            StartMenu();

        }

        public void SeedData()
        {
            EventContent testContent = new EventContent();
            EventContent testContent2 = new EventContent();
            

            testContent.EventNumber = 0;
            testContent.EventText = "Hello World XD";
            testContent.OptionOneText = "If you can read this type 1";
            testContent.OptionOneParams = new int[] { 24, -1, -5, 1 };
            testContent.OptionOneGotoEvent = 1;

            testContent2.EventNumber = 1;
            testContent2.EventText = "Good morning.";
            testContent2.OptionOneText = "If you can read this type 1";
            testContent2.OptionOneParams = new int[] { 0, 0, 0, 1 };
            testContent2.OptionOneGotoEvent = 0;

            eventRepo._list.Add(testContent);
            eventRepo._list.Add(testContent2);
        }
    }
}
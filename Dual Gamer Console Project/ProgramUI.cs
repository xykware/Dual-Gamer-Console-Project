using System;
using System.Collections.Generic;
using System.IO;
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
        public GameStateRepo gameStateRepo = new GameStateRepo();
        EventContentRepo eventRepo = new EventContentRepo();

        public void Run()
        {
            System.Console.Title = "Eleven Fifty: Student Simulator";

            InitEvents("events.txt");
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

            GameState newGame = gameStateRepo.MakeANewGame(newName);

            // Save Game M (P)
            // GameState gameOne = new GameState(newName, 0, 0, 0, 0, 0); (V)

            StartTheGUI(newGame, int.Parse(chosenSlot));
        }

        // Load a Saved Game - (P)
        private void LoadGame()
        {
            Console.Clear();
            // Display All Saves M
            Console.WriteLine("Which Save File would you like to continue?");
            string oldGameNumber = Console.ReadLine();
            int oldGameNumberParsed = int.Parse(oldGameNumber);

            GameState loadGame = gameStateRepo.LoadOldgame(oldGameNumberParsed);

            StartTheGUI(loadGame, oldGameNumberParsed);
        }

        private void StartTheGUI(GameState game, int slot)
        {
            //pass gamestate

            //instance eventcontent
            EventContent gameOneEvents = new EventContent();

            //create intital GUI

            //populate intial GUI state - load "intro" event
            BordersLayout gamePlay = new BordersLayout();

            bool keepGUIRunning = true;

            while (keepGUIRunning)
            {
                int newTurn = gamePlay.RunGUI(game, (eventRepo._list[game.Turn]));
                if (newTurn < 0)
                {
                    keepGUIRunning = false;
                    SaveGame(slot, game);
                }
                else if (newTurn <= eventRepo._list.Count)
                {
                    game.Turn = newTurn;
                }
                else
                {
                    keepGUIRunning = false;
                }
            }
        }

        public void SaveGame(int saveSlot, GameState saveGame)
        {
            Console.Clear();

            //Save Game M
            gameStateRepo.SaveNewGame(saveSlot, saveGame);

            Console.WriteLine($"Game saved to: save_{saveSlot}.txt\n\n");
        }

        public void InitEvents(string filePath)
        {
            if (File.Exists(filePath))
            {
                string[] eventsFile = File.ReadAllLines(@filePath);
                int i = -1;

                EventContent eventContent = new EventContent();

                foreach (string eventsData in eventsFile)
                {
                    i++;
                    if (eventsData == "|")
                    {
                        eventRepo._list.Add(eventContent);
                        eventContent = new EventContent();
                        i = -1;
                    }

                    if (i == 0)
                    {
                        eventContent.EventNumber = int.Parse(eventsData);
                    }
                    else if (i == 1)
                    {
                        eventContent.EventText = eventsData;
                    }
                    else if (i == 2)
                    {
                        eventContent.OptionOneText = eventsData;
                    }
                    else if (i == 3)
                    {
                        string[] optionParamsStringArray = eventsData.Split(',');
                        int[] optionParams = new int[4];
                        int iParam = 0;
                        foreach(string optionParamString in optionParamsStringArray)
                        {
                            optionParams[iParam] = int.Parse(optionParamString);
                            iParam++;
                        }
                        eventContent.OptionOneParams = optionParams;
                    }
                    else if (i == 4)
                    {
                        eventContent.OptionOneGotoEvent = int.Parse(eventsData);
                    }
                    else if (i == 5)
                    {
                        eventContent.OptionTwoText = eventsData;
                    }
                    else if (i == 6)
                    {
                        string[] optionParamsStringArray = eventsData.Split(',');
                        int[] optionParams = new int[4];
                        int iParam = 0;
                        foreach (string optionParamString in optionParamsStringArray)
                        {
                            optionParams[iParam] = int.Parse(optionParamString);
                            iParam++;
                        }
                        eventContent.OptionTwoParams = optionParams;
                    }
                    else if (i == 7)
                    {
                        eventContent.OptionTwoGotoEvent = int.Parse(eventsData);
                    }
                    else if (i == 8)
                    {
                        eventContent.OptionThreeText = eventsData;
                    }
                    else if (i == 9)
                    {
                        string[] optionParamsStringArray = eventsData.Split(',');
                        int[] optionParams = new int[4];
                        int iParam = 0;
                        foreach (string optionParamString in optionParamsStringArray)
                        {
                            optionParams[iParam] = int.Parse(optionParamString);
                            iParam++;
                        }
                        eventContent.OptionThreeParams = optionParams;
                    }
                    else if (i == 10)
                    {
                        eventContent.OptionThreeGotoEvent = int.Parse(eventsData);
                    }
                    else if (i == 11)
                    {
                        eventContent.OptionFourText = eventsData;
                    }
                    else if (i == 12)
                    {
                        string[] optionParamsStringArray = eventsData.Split(',');
                        int[] optionParams = new int[4];
                        int iParam = 0;
                        foreach (string optionParamString in optionParamsStringArray)
                        {
                            optionParams[iParam] = int.Parse(optionParamString);
                            iParam++;
                        }
                        eventContent.OptionFourParams = optionParams;
                    }
                    else if (i == 13)
                    {
                        eventContent.OptionFourGotoEvent = int.Parse(eventsData);
                    }
                    else if (i == 14)
                    {
                        eventContent.OptionFiveText = eventsData;
                    }
                    else if (i == 15)
                    {
                        string[] optionParamsStringArray = eventsData.Split(',');
                        int[] optionParams = new int[4];
                        int iParam = 0;
                        foreach (string optionParamString in optionParamsStringArray)
                        {
                            optionParams[iParam] = int.Parse(optionParamString);
                            iParam++;
                        }
                        eventContent.OptionFiveParams = optionParams;
                    }
                    else if (i == 16)
                    {
                        eventContent.OptionFiveGotoEvent = int.Parse(eventsData);
                    }
                }
            }
        }

        /*public void SeedData()
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
        }*/
    }
}
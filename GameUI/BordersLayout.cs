using _02_Startup;
using _04_EventObjectandRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameUI
{
    public class BordersLayout
    {
        public int RunGUI(GameState game, EventContent eventContent)
        {
            int[] statsPositions = { 90, 110, 2, 25 };
            int[] timePositions = { 4, 44, 2, 6 };
            int[] messagePositions = { 4, 44, 8, 25 };
            int[] optionsPositions = { 48, 86, 2, 25 };

            System.Console.Title = "Eleven Fifty: Student Simulator";

            Console.Clear();

            CreateBorderBox(statsPositions, "[STATS]"); // Stats box
            CreateBorderBox(timePositions, "[TIME]"); // Time box
            CreateBorderBox(messagePositions, "[MESSAGE]"); // Message box
            CreateBorderBox(optionsPositions, "[OPTIONS]"); // Options box

            WriteInBorder(statsPositions, 2,
                $"Rest: {game.AttRest} ; ; " +
                $"Sanity: {game.AttSanity} ; ; " +
                $"Grade: {game.AttGrade} ; ; " +
                $"Knowledge: {game.AttKnowledge} ; ; ");

            //WriteInBorder(timePositions, 2, "Week 1, Day 1, Morning, 9:00 AM");

            WriteInBorder(messagePositions, 2, eventContent.EventText);

            string optionsString = "";

            if (eventContent.OptionOneText != null)
            {
                optionsString += $"1. {eventContent.OptionOneText} ; ; ";
            }
            if(eventContent.OptionTwoText != null)
            {
                optionsString += $"2. {eventContent.OptionTwoText} ; ; ";
            }

            if (eventContent.OptionThreeText != null)
            {
                optionsString += $"3. {eventContent.OptionThreeText} ; ; ";
            }

            if (eventContent.OptionFourText != null)
            {
                optionsString += $"4. {eventContent.OptionFourText} ; ; ";
            }

            if (eventContent.OptionFiveText != null)
            {
                optionsString += $"5. {eventContent.OptionFiveText} ; ; ";
            }

            optionsString += $"0. Save and Exit ; ; ";

            WriteInBorder(optionsPositions, 3, optionsString);

            while (true)
            {
                System.Console.SetCursorPosition((optionsPositions[0] + 3), (optionsPositions[3] - 3));
                string choice = System.Console.ReadLine();

                Console.SetCursorPosition(0, 0);

                if (choice == "1")
                {
                    if (eventContent.OptionOneParams != null)
                    {
                        game.AttRest += eventContent.OptionOneParams[0];
                        game.AttSanity += eventContent.OptionOneParams[1];
                        game.AttGrade += eventContent.OptionOneParams[2];
                        game.AttKnowledge += eventContent.OptionOneParams[3];
                        return eventContent.OptionOneGotoEvent;
                    }
                    else
                    {
                        Console.SetCursorPosition((optionsPositions[0] + 3), (optionsPositions[3] - 2));
                        Console.Write("Please enter a valid input...");
                        Console.ReadKey();
                        return eventContent.EventNumber;
                    }
                }
                else if (choice == "2")
                {
                    if (eventContent.OptionTwoParams != null)
                    {
                        game.AttRest += eventContent.OptionTwoParams[0];
                        game.AttSanity += eventContent.OptionTwoParams[1];
                        game.AttGrade += eventContent.OptionTwoParams[2];
                        game.AttKnowledge += eventContent.OptionTwoParams[3];
                        return eventContent.OptionTwoGotoEvent;
                    }
                    else
                    {
                        Console.SetCursorPosition((optionsPositions[0] + 3), (optionsPositions[3] - 2));
                        Console.Write("Please enter a valid input...");
                        Console.ReadKey();
                        return eventContent.EventNumber;
                    }
                }
                else if (choice == "3")
                {
                    if (eventContent.OptionThreeParams != null)
                    {
                        game.AttRest += eventContent.OptionThreeParams[0];
                        game.AttSanity += eventContent.OptionThreeParams[1];
                        game.AttGrade += eventContent.OptionThreeParams[2];
                        game.AttKnowledge += eventContent.OptionThreeParams[3];
                        return eventContent.OptionThreeGotoEvent;
                    }
                    else
                    {
                        Console.SetCursorPosition((optionsPositions[0] + 3), (optionsPositions[3] - 2));
                        Console.Write("Please enter a valid input...");
                        Console.ReadKey();
                        return eventContent.EventNumber;
                    }
                }
                else if (choice == "4")
                {
                    if (eventContent.OptionFourParams != null)
                    {
                        game.AttRest += eventContent.OptionFourParams[0];
                        game.AttSanity += eventContent.OptionFourParams[1];
                        game.AttGrade += eventContent.OptionFourParams[2];
                        game.AttKnowledge += eventContent.OptionFourParams[3];
                        return eventContent.OptionFourGotoEvent;
                    }
                    else
                    {
                        Console.SetCursorPosition((optionsPositions[0] + 3), (optionsPositions[3] - 2));
                        Console.Write("Please enter a valid input...");
                        Console.ReadKey();
                        return eventContent.EventNumber;
                    }
                }
                else if (choice == "5")
                {
                    if (eventContent.OptionFiveParams != null)
                    {
                        game.AttRest += eventContent.OptionFiveParams[0];
                        game.AttSanity += eventContent.OptionFiveParams[1];
                        game.AttGrade += eventContent.OptionFiveParams[2];
                        game.AttKnowledge += eventContent.OptionFiveParams[3];
                        return eventContent.OptionFiveGotoEvent;
                    }
                    else
                    {
                        Console.SetCursorPosition((optionsPositions[0] + 3), (optionsPositions[3] - 2));
                        Console.Write("Please enter a valid input...");
                        Console.ReadKey();
                        return eventContent.EventNumber;
                    }
                }
                else if (choice == "0")
                {
                    return -1;
                }
                else
                {
                    Console.SetCursorPosition((optionsPositions[0] + 3), (optionsPositions[3] - 2));
                    Console.Write("Please enter a valid input...");
                    Console.ReadKey();
                    return eventContent.EventNumber;
                }
            }
        }

        public void WriteInBorder(int[] positions, int padding, string text)
        {
            string[] words = text.Split(' ');

            System.Console.SetCursorPosition((positions[0] + padding), (positions[2] + padding));

            foreach (string word in words)
            {
                if (word == ";")
                {
                    positions[2] += 1;
                    System.Console.SetCursorPosition((positions[0] + padding), (positions[2] + padding));
                }
                else if ((System.Console.CursorLeft + word.Length - 1) <= (positions[1] - padding))
                {
                    System.Console.Write($"{word} ");
                }
                else
                {
                    positions[2] += 1;
                    System.Console.SetCursorPosition((positions[0] + padding), (positions[2] + padding));
                    System.Console.Write($"{word} ");
                }
            }
        }

        public void CreateBorderBox(int[] positions)
        {
            for (int i = positions[2]; i <= positions[3]; i++)
            {
                System.Console.SetCursorPosition(positions[0], i);
                System.Console.Write("█");
                System.Console.SetCursorPosition(positions[1], i);
                System.Console.Write("█");
            }

            for (int i = positions[0]; i <= positions[1]; i++)
            {
                System.Console.SetCursorPosition(i, positions[2]);
                System.Console.Write("█");
                System.Console.SetCursorPosition(i, positions[3]);
                System.Console.Write("█");
            }
        }

        public void CreateBorderBox(int[] positions, string title)
        {
            CreateBorderBox(positions);
            int middle = (positions[1] - positions[0]) / 2 + positions[0] - (title.Length / 2);
            System.Console.SetCursorPosition(middle, positions[2]);
            System.Console.Write(title);
        }
    }
}

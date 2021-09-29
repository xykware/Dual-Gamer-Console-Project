using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EthanLibrary
{
    public class BorderStuff
    {
        int[] _statsPositions = { 90, 110, 2, 25 };
        int[] _timePositions = { 4, 44, 2, 6 };
        int[] _messagePositions = { 4, 44, 8, 25 };
        int[] _optionsPositions = { 48, 86, 2, 25 };

        public void Run()
        {
            System.Console.Title = "Eleven Fifty: Student Simulator";

            CreateBorderBox(_statsPositions, "[STATS]"); // Stats box
            CreateBorderBox(_timePositions, "[TIME]"); // Time box
            CreateBorderBox(_messagePositions, "[MESSAGE]"); // Message box
            CreateBorderBox(_optionsPositions, "[OPTIONS]"); // Options box

            WriteInBorder(_statsPositions, 2,
                "Rest: 12 ; ; " +
                "Sanity: 9 ; ; " +
                "Grade: 97 ; ; " +
                "Knowledge: 76 ; ; ");

            WriteInBorder(_timePositions, 2, "Week 3, Day 3, Morning, 10:30 AM");

            WriteInBorder(_messagePositions, 2,
                "Good morning, today we're gonna learn about X Y and Z... ; ; " +
                "Also, we have some morning announcements we need to share before we get started ; ; ");

            WriteInBorder(_optionsPositions, 3,
                "1. Sit patiently and listen to the lecture ; ; " +
                "2. Ignore the lecture and look the answers up online ; ;");

            System.Console.SetCursorPosition((_optionsPositions[0] + 3), (_optionsPositions[3] - 3));
            System.Console.ReadLine();
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

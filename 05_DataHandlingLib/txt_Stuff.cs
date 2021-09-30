using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02_Startup;



namespace _05_DataHandlingLib
{
    // Methods to Save GameStates as txt and load them back from txt as GameStates
    public class txt_Stuff
    {
        string GameStateSave1FilePath; // ie c:\FolderName\GameStateSaveData1.txt"

        GameState _newGame = new GameState("YourName", 0, 0, 0, 0, 0);

        public void SaveGameStateAstxt(string filepath)
        {
            // parse GameState to string[]
            MakeGameStateIntoStringArray(_newGame); //????
            // save as txt file
            public static void WriteAllLines(string path, System.Collections.Generic.IEnumerable<string> contents);
        }


        public void LoadGameStateFromtxt(string filepath)
        {
            // load txt file as string[]
            public static string[] ReadAllLines(string path);
            // parse to format of GameState
            MakeStringArrayIntoGameState(newStingArray); //????
            // instance above GameState
        }

        public string[] MakeGameStateIntoStringArray(GameState newGameState)
        {
            // parse from list into String[]
            throw new NotImplementedException();

            //return gameStateAsStringArray;
        }

        public GameState MakeStringArrayIntoGameState(string[] inputString)
        {
            // parse from String[] into list
            throw new NotImplementedException();

            //return GameState stringArrayAsGameState;
        }
    }
}
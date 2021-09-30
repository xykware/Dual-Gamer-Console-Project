using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Startup
{
    public class GameStateRepo
    {
        public List<GameState> _gameState = new List<GameState>();

        // C Make a New Game
        public GameState MakeANewGame(string userName)
        {
            GameState newGame = new GameState(userName, 0, 0, 0, 0, 0);

            return newGame;
        }

        // R List all Saved Games

        // U Update a New Game

        // D Delete a Game

        // Load A GameState

        public GameState LoadOldgame(int loadSlot)
        {
            string loadDataFile = File.ReadAllText($@"save_{loadSlot}.txt");

            string[] loadData = loadDataFile.Split(',');

            string dataName = loadData[1];
            int dataTurn = int.Parse(loadData[0]);
            int dataKnowledge = int.Parse(loadData[5]);
            int dataRest = int.Parse(loadData[2]);
            int dataSanity = int.Parse(loadData[3]);
            int dataGrade = int.Parse(loadData[4]);

            GameState loadGame = new GameState(dataName, dataTurn, dataKnowledge, dataRest, dataSanity, dataGrade);

            return loadGame;
        }

        public void SaveNewGame(int saveSlot, GameState saveGame)
        {
            using (StreamWriter writer = new StreamWriter($"save_{saveSlot}.txt", false))
            {
                string saveData = $"{saveGame.Turn},{saveGame.PlayerName},{saveGame.AttRest},{saveGame.AttSanity},{saveGame.AttGrade},{saveGame.AttKnowledge}";
                writer.Write(saveData);
            }
        }
    }


}

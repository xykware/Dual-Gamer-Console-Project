using System;
using System.Collections.Generic;
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

        public GameState LoadAnOldgame()
        {
            return null;
        }

    }


}

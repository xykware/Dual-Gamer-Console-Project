using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Startup
{
    // Create Gamestate - (V: SessionId)
    public class GameState 
    {
        //public int SessionId { get; set; }
        public string PlayerName { get; set; }
        public int Turn { get; set; }
        public int AttKnowledge { get; set; }
        public int AttRest { get; set; }
        public int AttSanity { get; set; }
        public int AttGrade { get; set; }

        public GameState() { }

        public GameState(/*int sessionId, */string playerName, int turn, int attKnowledge, int attRest, int attSanity, int attGrade)
        {
            //SessionId = sessionId;
            PlayerName = playerName;
            Turn = turn;
            AttKnowledge = attKnowledge;
            AttRest = attRest;
            AttSanity = attSanity;
            AttGrade = attGrade;
        }
    }
}

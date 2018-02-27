using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class Chess : Game
    {
        public Chess() : base(2)
        {
        }
        private int maxTurns = 10;
        private int turn = 1;

        protected override int WinningPlayer => currentPlayer;
        protected override bool HaveWinner => turn == maxTurns;
        protected override void Start()
        {
            Console.WriteLine($"Starting a game of chess with {numberOfPlayers} players.");
        }

        protected override void TakeTurn()
        {
            Console.WriteLine($"Turn {turn++} taken by player {currentPlayer}.");
            currentPlayer = (currentPlayer + 1) % numberOfPlayers;
        }       
    }
}

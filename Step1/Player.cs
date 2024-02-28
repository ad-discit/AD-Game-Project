using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Awalé
{
    public class Player : Person
    {
        public int PlayerNumber { get; set; }
        public Score PlayerScore { get; set; }

        public Player(string name, int playerNumber) : base(name)
        {
            PlayerNumber = playerNumber;
            PlayerScore = new Score();
        }

        // Example Method
        public void UpdateScore(int points)
        {
            PlayerScore.Total += points;
        }

        public int GetScore()
        {
            return PlayerScore.Total;
        }
    }

}

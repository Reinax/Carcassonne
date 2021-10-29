using System;
using System.Collections.Generic;
using System.Text;

namespace projectCarcassonne
{
    public class Player
    {
        public int PlayerOneScore { get; set; }

        public int PlayerTwoScore { get; set; }

        public int Meeples { get; set; }

        public Player(int PlayerOneScore, int PlayerTwoScore, int Meeples)
        {
            this.PlayerOneScore = PlayerOneScore;
            this.PlayerTwoScore = PlayerTwoScore;
            this.Meeples = Meeples;
        }

    }
}

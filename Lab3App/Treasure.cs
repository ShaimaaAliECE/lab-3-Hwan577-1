using System;
using System.Collections.Generic;

namespace Lab3App
{
    internal class Treasure : Collectable
    {
        private int score;

        public int Score {
            get { return score; }
            set { score = value; } 
        }

        public Treasure(string description, int score) : base(description)
        {
            Score = score;
        }

        public void UpdateTotalScore()
        {
            Board.TotalScore += Score;
            Console.WriteLine($"Total Score is updated to: {Board.TotalScore}");
        }

        public override void AddMe(List<Collectable> collection)
        {
            base.AddMe(collection);
            UpdateTotalScore();
        }
    }
}

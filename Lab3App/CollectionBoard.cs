using System;

namespace Lab3App
{
    internal class CollectionBoard
    {
        private int totScore;
        private int totValue;

        public int TotalScore
        {
            get { return totScore; }
            set { totScore = value; }
        }

        public int TotalValue
        {
            get { return totValue; }
            set { totValue = value; }
        }
    }
}

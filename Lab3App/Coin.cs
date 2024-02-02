﻿using System;
using System.Collections.Generic;

namespace Lab3App
{
    internal class Coin : Treasure
    {
        private int val;

        public int Value { 
            get { return val; } 
            set { val = value;  }
        }

        public Coin(string description, int score, int value) : base(description, score)
        {
            Value = value;
        }

        public void UpdateTotalValue()
        {
            Board.TotalValue += Value;
            Console.WriteLine($"Total Value is updated to: {Board.TotalValue}");
        }

        public override void Display()
        {
            Console.WriteLine($"Coin {Description} is displayed");
        }

        public override void AddMe(List<Collectable> collection)
        {
            base.AddMe(collection);
            UpdateTotalValue();
        }
    }
}
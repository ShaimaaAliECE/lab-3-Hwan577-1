using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace Lab3App
{
    internal class Collectable : Displayable
    {
        private string description;
        private CollectionBoard board;

        public string Description
        {
            get { return description; }
            set { this.description = value; }
        }

        public CollectionBoard Board
        {
            get { return board; }
            set { this.board = value; }
        }

        public Collectable(string description)
        {
            this.Description = description;
        }

        public virtual void AddMe(List<Collectable> collection)
        {
            Console.WriteLine($"{Description} Collected, Congrats!!!!");
            collection.Add(this);
        }

        public virtual void Display()
        {
            Console.WriteLine($"Collectable {Description} is displayed");
        } 
    }
}

using System;
using System.Collections.Generic;

namespace Lab3App
{
    internal class Tool : Collectable
    {
        public Tool(string description) : base(description)
        {
        }

        public virtual void DoAction()
        {
            Console.WriteLine("Tool is used");
        }

        public override void AddMe(List<Collectable> collection)
        {
            base.AddMe(collection);
            DoAction();
        }

    }
}


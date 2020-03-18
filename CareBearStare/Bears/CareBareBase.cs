using System;
using System.Collections.Generic;
using System.Text;

namespace CareBearStare.Bears
{
    abstract class CareBearBase
    {
        public string Name { get; protected set; } // protected: only classes who inherit from this class and this class can set this property
        public BearColor BearColor { get; protected set; }
        public string BellyBadge { get; protected set; }

        public abstract void Stare();

        public void Care(string humanToCareFor)
        {
            Console.WriteLine($"{Name} cares deeply for {humanToCareFor}.");
        }

        public virtual void Hug(CareBearBase careBearToHug)
        {
            Console.WriteLine($"{Name} runs over to {careBearToHug.Name} and hugs them.");
        }

    }
}

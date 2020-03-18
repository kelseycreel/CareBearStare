using System;
using System.Collections.Generic;
using System.Text;

namespace CareBearStare.Bears
{
    class GrumpyBear : CareBearBase
    {
        // constructor
        public GrumpyBear()
        {
            BellyBadge = "Rain Cloud";
            BearColor = BearColor.Blue;
            Name = "Grumpy Bear";
        }
        public override void Stare()
        {
            Console.WriteLine($"{Name} stares grumpily into the void while shooting a beam from his belly.");
        }

        public override void Hug(CareBearBase careBearToHug)
        {
            Console.WriteLine($"{Name} hates hugs and shuns {careBearToHug.Name}");
        }
    }
}

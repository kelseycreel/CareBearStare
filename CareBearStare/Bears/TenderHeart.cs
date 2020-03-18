using System;
using System.Collections.Generic;
using System.Text;

namespace CareBearStare.Bears
{
    class TenderHeart : CareBearBase
    {
        public TenderHeart()
        {
            Name = "Tender Heart";
            BellyBadge = "Heart";
            BearColor = BearColor.Brown;
        }
        public override void Stare()
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{Name} shoots hearts from his belly.");
            Console.ResetColor();
        }
    }
}

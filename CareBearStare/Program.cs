using System;
using System.Collections.Generic;
using System.Linq;
using CareBearStare.Bears;

namespace CareBearStare
{
    class Program
    {
        static void Main(string[] args)
        {
            var grumpyBear = new GrumpyBear();
            var tenderHeart = new TenderHeart();
            var tinderHeart = new TinderHeart();

            var careBears = new List<CareBearBase> { grumpyBear, tenderHeart, tinderHeart };

            foreach (var bear in careBears)
            {
                bear.Care("Kelsey");
                bear.Stare();
            }

            //Linq stuff
            var namesThatStartWithT = careBears.Where(bear => bear.Name.StartsWith('T'));
            var careBearNames = careBears.Select(bear => bear.Name);

            var careBearNamesThatStartWithT = careBears
                .Where(bear => bear.Name.StartsWith('T'))
                .Select(bear => bear.Name);

            var anyTinderHearts = careBears.Any(bear => bear is TinderHeart); // returns true or false
            var allTinderHearts = careBears.All(bear => bear is TinderHeart); // exits as soon as it finds a beart that is not a TinderHeart

        }
    }
}

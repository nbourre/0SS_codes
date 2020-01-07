using System;
using System.Collections.Generic;
using System.Linq;

namespace rappel_heritage
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Code en version classique
             ** 
            
            List<Cake> cakes;

            cakes = new List<Cake>();

            cakes.Add(new WeddingCake("Chocolate"));
            cakes.Add(new Cake("Vanilla"));
            cakes.Add(new BirthdayCake("Marbled"));

            foreach (Cake c in cakes)
            {
                c.ShowType();
                c.Bake();
                c.Frost();
            }
             */

            /// Type inféré
            var cakes = new List<Cake>
            {
                /// Initialisation
                new WeddingCake("Chocolate"),
                new Cake("Vanilla"),
                new BirthdayCake("Marbled")
            };

            // Boucle en expression Lambda
            cakes.ForEach(c => {
                c.ShowType();
                c.Bake();
                c.Frost();                
            });
        }
    }
}

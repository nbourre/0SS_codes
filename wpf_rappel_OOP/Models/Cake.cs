using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace wpf_rappel_OOP.Models
{
    public class Cake
    {
        protected string Flavor { get; set; }

        public Cake(string flavor)
        {
            Flavor = flavor;
        }

        public void Bake()
        {
            Debug.WriteLine($"The cake is baking and it is {Flavor}");
        }

        public void Frost()
        {
            Debug.WriteLine("The cake has now frosting");
        }
    }

    public class BirthdayCake : Cake
    {
        public BirthdayCake(string flavor) : base(flavor) { }

        public void PutCandlesOnCake (int numberOfCandles)
        {
            Debug.WriteLine($"Putting {numberOfCandles} on the cake.");
        }
    }

    public class WeddingCake : Cake
    {
        public WeddingCake(string flavor) : base (flavor){}

        public void MakeCakeTiers(int numberOfTiers)
        {
            Debug.WriteLine($"This wedding cake has {numberOfTiers} tiers.");
        }
    }

}

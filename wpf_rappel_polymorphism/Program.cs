using System;

namespace wpf_rappel_polymorphism
{
    class Program
    {
        static void LetsHear (Animal a)
        {
            Console.WriteLine(a.Talk());
        }
        static void Main(string[] args)
        {
            LetsHear(new Cat());
            LetsHear(new Dog());
        }
    }
}

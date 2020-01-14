using System;

namespace wpf_rappel_polymorphism
{
    class Program
    {
        static void LetsHear (Animal a)
        {
            Console.WriteLine(a.Talk());
        }

        static void LetsMove(Animal a)
        {
            Console.WriteLine(a.Move());
        }
        static void Main(string[] args)
        {
            var cat = new Cat();
            var dog = new Dog();

            LetsHear(cat);
            LetsHear(dog);

            LetsMove(cat);
            LetsMove(dog);


        }
    }
}

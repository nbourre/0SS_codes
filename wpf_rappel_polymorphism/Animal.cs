using System;
using System.Collections.Generic;
using System.Text;

namespace wpf_rappel_polymorphism
{
    abstract class Animal
    {
        public abstract string Talk();
        public virtual string Move() => $"The animal is moving!";
    }

    class Cat : Animal
    {
        public override string Talk() => "Meow!";
        public override string Move() => $"The cat is moving";

        public string Meow() => "The cat is meowing!";
    }

    class Dog : Animal
    {
        public override string Talk() => "Woof!";
    }
}

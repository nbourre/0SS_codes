using System;
using System.Collections.Generic;
using System.Text;

namespace wpf_rappel_polymorphism
{
abstract class Animal
{
    public abstract string Talk();
}

class Cat : Animal
{
    public override string Talk() => "Meow!";
}

class Dog : Animal
{
    public override string Talk() => "Woof!";
}
}

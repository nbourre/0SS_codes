using System;
using System.Collections.Generic;

namespace rappel_interface
{
    /// <summary>
    /// Exemple d'utilisation de l'interface
    /// </summary>
    class Program
    {
        interface IFireArm
        {
            public string GetName();
            public string Shoot();
        }

        class AK47 : IFireArm
        {
            public string GetName() => "AK-47";
            public string Shoot() => "Tra-Tra-Tra";
        }

        class ShotGun : IFireArm
        {
            public string GetName() => "Shotgun";
            public string Shoot() => "Bang!";
        }

        class Colt : IFireArm
        {
            public string GetName() => "Colt";
            public string Shoot() => "Pow! Pow!";
        }

        static void Main(string[] args)
        {
            List<IFireArm> firearms = new List<IFireArm>();
            firearms.Add(new AK47());
            firearms.Add(new ShotGun());
            firearms.Add(new Colt());

            foreach (IFireArm f in firearms)
            {
                Console.WriteLine($"Fireing the {f.GetName()} : {f.Shoot()}");
            }
        }
    }
}

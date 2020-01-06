using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace wpf_rappel_OOP
{
    class Car
    {
        static int nextId;

        public int CarId { get; private set; }

        public string Brand { get; set; }
        public string Model { get; set; }

        public int Year { get; set; }

        public Car()
        {
            CarId = Interlocked.Increment(ref nextId);
        }
    }
}

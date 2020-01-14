using System;
using System.Collections.Generic;
using System.Text;

namespace rappel_polymorphism
{
    interface IStorable
    {
        void SetData(byte[] data);
        public byte[] Data { get; set; }
    }
}

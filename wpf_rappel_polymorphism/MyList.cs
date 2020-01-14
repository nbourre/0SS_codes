using System;
using System.Collections.Generic;
using System.Text;

namespace rappel_polymorphism
{
    class MyList<T>
    {
        List<T> _list;

        public MyList()
        {
            _list = new List<T>();
        }
    }
}

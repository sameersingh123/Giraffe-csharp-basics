using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe1
{
     class ParameterizedConstructor
    {
        int x;
        public ParameterizedConstructor(int i)
        {
            x = i;
            Console.WriteLine("Parameterized Constructor called "+i);
        }

        public void Print()
        {
            Console.WriteLine("Value of x is "+x);
        }

    }
}

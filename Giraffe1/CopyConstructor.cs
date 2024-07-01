using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe1
{
     class CopyConstructor
    {
        int x;

        public CopyConstructor(int i)                   //Paramerterized Constructor
        {
            x = i;
        }

        public CopyConstructor(CopyConstructor c)       //Copy Constructor
        {
            x = c.x;
        }

        public void Display()
        {
            Console.WriteLine("Value of x is "+x);
        }
    }
}

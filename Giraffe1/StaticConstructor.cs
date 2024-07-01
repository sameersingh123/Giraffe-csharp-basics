using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe1
{
     class StaticConstructor
    {
        public static int x;
        public int y;
        static StaticConstructor()                                 // Static Constructor
        {
            Console.WriteLine("Static Constructor called");
        }

        public StaticConstructor()                                  // Non Static Constructor
        {
            Console.WriteLine("Non Static Constructor called");
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe1
{
     class IndianChef: Chef
    {
        public void MakeBiryani()
        {
            Console.WriteLine("The chef makes Biryani");
        }
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes Special Indian Dish");
        }
    }
}

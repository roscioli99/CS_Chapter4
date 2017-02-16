using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenNums
{
    class EvenNums
    {
        static void Main(string[] args)
        {
            int even = 100;
            for (int x = 2; x <= even; x+=2)
            {
                Console.WriteLine(x);
            }
        }
    }
}

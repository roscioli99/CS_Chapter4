using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    class Sum
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            while (number != 999)
            {
                Console.Write("Enter a number: ");
                number = Convert.ToInt32(Console.ReadLine());

                sum = sum + number;
            }
            Console.WriteLine(sum);
        }
    }
}

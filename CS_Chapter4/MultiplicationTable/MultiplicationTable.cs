using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    class MultiplicationTable
    {
        static void Main(string[] args)
        {
            Console.Write("     |");
            for (int i = 1; i <= 10; i++)
                Console.Write((i).ToString().PadLeft(5) + "|");

            Console.WriteLine();

            for (int i = 1; i <= 11; i++)
                Console.Write("-----+");

            Console.WriteLine();

            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i.ToString().PadLeft(5) + "|");

                for (int j = 1; j <= 10; j++)
                    Console.Write((i * j).ToString().PadLeft(5) + "|");

                Console.WriteLine();
                for (int z = 1; z<= 11; z++)
                    Console.Write("-----+");
                Console.WriteLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetVowel
{
    class GetVowel
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a vowel: ");
            String input = Console.ReadLine();

            while (input != "!")
            {
                if ("aeiouAEIOU".Contains(input))
                {
                    Console.WriteLine("OK");
                }

                else
                {
                    Console.WriteLine("ERROR");
                    Console.Write("Enter a vowl: ");
                    String input3 = Console.ReadLine();
                }

                Console.Write("Enter a vowel: ");
                String input2 = Console.ReadLine();
            }


        }
    }
}

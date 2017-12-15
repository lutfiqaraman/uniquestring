using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsStringUnique
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write your word");

            string word = Console.ReadLine();
            string newstring = string.Join("", word.Distinct());

            if (word.Length == newstring.Length)
                Console.WriteLine("String contains unique characters");
            else
                Console.WriteLine("String does not contain unique characters");

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter plaintext: ");
            string get = Console.ReadLine();

            //Enter hashing algorithm here: E.G Hashing.Sha512(get) <-- Plaintext
            Hashing.Sha512(get);

            Console.Write("Press enter to continue..");
            Console.ReadLine();
        }
    }
}

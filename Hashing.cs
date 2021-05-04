using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Sha512
{
    class Hashing
    {

        public static void Sha512(string get)
        {
            Console.WriteLine("Prehashed Value: " + get);

            using (SHA512 sha512hash = SHA512.Create())
            {
                byte[] textBytes = Encoding.UTF8.GetBytes(get);
                byte[] hashBytes = sha512hash.ComputeHash(textBytes);

                get = BitConverter.ToString(hashBytes).Replace("-", String.Empty);
            }

            Console.WriteLine("Hashed Value: " + get);
        }
        
        
        //More algorithms being added soon, currently studying for an exam.

    }
}

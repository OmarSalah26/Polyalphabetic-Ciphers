using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polyalphabetic_Ciphers
{
    class Program
    {
        static void Main(string[] args)
        {


            string name = "omar salah mohamed";
            Console.Write("Real Name  : ");
            Console.WriteLine(name);
            //  to encrept 
            Console.Write("Encrepted Name  : ");
            Console.WriteLine(Encrept_Polyalphabetic_Ciphers("omarsalahmohamed", "TOLASOLA"));
           

        }


        static string Encrept_Polyalphabetic_Ciphers(string str, string key) {
            string alpha = "abcdefghijklmnopqrstuvwxyz";
            string _key = string.Empty;
            string Result= string.Empty;
            
            for (int i = 0; i < str.Length; i++)
            {

                _key += key[i % key.Length];

            }
            _key = _key.ToLower();
            for (int i = 0; i < str.Length; i++)
            {

                Result += alpha[(alpha.IndexOf(str[i]) + alpha.IndexOf(_key[i])) % 26];
            }


            return Result;
        }

    }
}

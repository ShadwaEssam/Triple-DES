using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tripleDES
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public string Decrypt(string cipherText, List<string> key)
        {
            throw new NotImplementedException();
        }

        public string Encrypt(string plainText, List<string> key)
        {
            throw new NotImplementedException();
            //we have 3 keys
            //encrypt with 1st
            //decrypt with 2nd
            //encrypt with 3rd 
        }

        public List<string> Analyse(string plainText, string cipherText)
        {
            throw new NotSupportedException();
        }


    }
}





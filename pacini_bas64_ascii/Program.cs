using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pacini_bas64_ascii
{
    class Program
    {
        static void Main(string[] args)
        {
            string plainText;
            string base64EncodedData;
            Console.WriteLine("INserisci il testo da convertire");
            plainText = Console.ReadLine();

            byte[] plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            for (int i = 0; i < plainTextBytes.Length; i++)
            {
                Console.WriteLine(plainTextBytes[i]);
                Console.WriteLine(Convert.ToString(plainTextBytes[i], 2));
            }

            base64EncodedData = Convert.ToBase64String(plainTextBytes);
            Console.WriteLine("la codifica in base 64 della parola"+plainText+"è"+base64EncodedData);

            byte[] base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            plainText = System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
            Console.WriteLine(plainText);

            int value;
            Console.WriteLine("Inserisci il numero di cui voi sapere la corrispondenza in ascii");
            value = Convert.ToInt32(Console.ReadLine());
            char c = Convert.ToChar(value);
            string d = c.ToString();
            Console.WriteLine($"Il valore {value} corrisponde a {d}");
         
            Console.ReadLine();
        }
    }
}

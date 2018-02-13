using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase1 = "";
            string frase2 = "";
            Console.WriteLine("Escribir la frase para invertir: ");
            frase1 = Console.ReadLine();
            for (int i = frase1.Length - 1; i >= 0; i--)
            {
                frase2 += frase1[i];
            }
            Console.WriteLine("Frase Invertida: "+ frase2);
            Console.ReadKey();
        }
    }
}

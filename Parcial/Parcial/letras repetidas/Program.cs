using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace letras_repetidas
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra = "holaamigo";
            char[] palabraArray = palabra.ToCharArray();
            int arrayLength = palabra.Length;

            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = i + 1; j < arrayLength; j++)
                {
                    if (palabraArray[i] == palabraArray[j])
                    {
                        var lista = palabraArray.ToList();
                        lista.RemoveAt(j);
                        palabraArray = lista.ToArray();
                        arrayLength = palabraArray.Length;
                    }
                }
            }

            for (int i = 0; i < palabraArray.Length; i++)
            {
                Console.Write(palabraArray[i]);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}

   

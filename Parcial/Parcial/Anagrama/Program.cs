using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrama
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string palabra1;
                string palabra2;
                Console.Write("Ingrese una palabra : ");
                palabra1 = Console.ReadLine();
                if (palabra1.Length == 0)
                    break;
                else
                {
                    Console.Write("Ingrese otra palabra : ");
                    palabra2 = Console.ReadLine();
                    if (SonAnagramas(palabra1, palabra2) == false)
                    {
                        Console.Write("No son anagramas.");
                        break;

                    }
                    else
                    {
                        Console.Write("Son anagramas.");
                        break;
                    }
                    
                }
            }
            Console.ReadLine();
        }

        public static bool SonAnagramas(string a, string b)
        {
            int count1, count2;
            if (a.Length == b.Length)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    count1 = 0;
                    count2 = 0;
                    for (int j = 0; j < b.Length; j++)
                    {
                        if (a[i] == b[j])
                            count1++;
                        if (a[i] == a[j])
                            count2++;
                    }
                    if (count1 != count2)
                        return false;
                }
                return true;
            }
            else
                return false;
        }
        
    }
}
    


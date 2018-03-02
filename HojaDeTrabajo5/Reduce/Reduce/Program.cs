using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reduce
{
    public class Program
    {

        public static int ReduceInt(int[] valores, int accumulador, Func<int, int, int> reduccion)
        {
            for (int i = 0; i < valores.Length; i++)
            {
                accumulador = reduccion(accumulador, valores[i]);
            }

            return accumulador;
        }

        public static A Reduce<T, A>(T[] valores, A accumulador, Func<A, T, A> reduccion)
        {
            for (int i = 0; i < valores.Length; i++)
            {
                accumulador = reduccion(accumulador, valores[i]);
            }

            return accumulador;
        }
        static void Main(string[] args)
        {

        }

    }
}

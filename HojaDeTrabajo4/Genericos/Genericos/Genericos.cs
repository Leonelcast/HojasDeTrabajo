using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos
{
    class Genericos
    {
         public Genericos(){}

            public T Head<T>(T[] list){
                return list[0];
            }


            public T[] Tail<T>(T[] list){
                T[] datosN = new T[list.Length - 1];
                int excepcion = 0;
                for (int i = 1; i < list.Length; i++)
                {
                    datosN[excepcion] = list[i];
                    excepcion += 1;
                }
                return datosN;
            }
            

    public class Tupla<T1, T2>
    {
        public T1 Primero { get; }
        public T2 Segundo { get; }
        public Tupla(T1 primero, T2 segundo)
        {
            this.Primero = primero;
            this.Segundo = segundo;
        }
    }


            public Tupla<T1,T2>[] Zip<T1, T2>(T1[] list_A, T2[] List_B){
            Tupla<T1, T2>[] array = new Tupla<T1, T2>[Tamaño<T1,T2>(list_A, List_B)];            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Tupla<T1,T2>(list_A[i], List_B[i]);
            }
            return array;            
            }
            

            private int Tamaño<T1, T2>(T1[] var_A, T2[] var_B)
            {
            int Tamaño = 0;
            if (var_A.Length == var_B.Length)
            {
                Tamaño = var_A.Length;
            }
            else if (var_A.Length > var_B.Length)
            {
                Tamaño = var_B.Length;
            }
            else if (var_A.Length < var_B.Length)
            {
                Tamaño = var_A.Length;
            }
            return Tamaño;
            }   
    }
}
 
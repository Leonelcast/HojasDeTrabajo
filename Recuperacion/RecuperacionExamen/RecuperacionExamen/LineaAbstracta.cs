using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuperacionExamen
{
    public abstract class LineaAbstracta<T> : ILinea<T>
    {
        public abstract T[] Puntos { get; }

        public double Longitud()
        {
            if (Puntos.Length == 0)
                return 0;

            double longitud = 0;
            for (int i = 0; i < Puntos.Length - 1; i++)
            {
                longitud += Distancia(Puntos[i], Puntos[i + 1]);
            }
            return longitud;
        }

        public T PuntoMasCercano(T punto)
        {
            T cerca = Puntos[0];

            for (int i = 0; i < Puntos.Length; i++)
            {
                if (Distancia(punto, Puntos[i]) < Distancia(punto, cerca))
                    cerca = Puntos[i];
            }
            return cerca;
        }

        public abstract double Distancia(T var1, T var2);
    }
}

using System;

namespace RecuperacionExamen
{
    public class Linea3D : LineaAbstracta<Punto3D>
    {
        public override Punto3D[] Puntos { get; }

        public Linea3D(Punto3D[] puntos)
        {
            Puntos = puntos;
        }

        public override double Distancia(Punto3D var1, Punto3D var2)
        {
            double X2 = Math.Pow(var2.X - var1.X, 2);
            double Y2 = Math.Pow(var2.Y - var1.Y, 2);
            double Z2 = Math.Pow(var2.Z - var1.Z, 2);
            double distancia = Math.Sqrt(X2 + Y2 + Z2);

            return distancia;
        }
    }
}


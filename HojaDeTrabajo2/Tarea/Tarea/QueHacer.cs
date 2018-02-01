using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    public enum Estado
    {
        EnProgreso,
        Terminado
    }

    public class QueHacer
    {
        public string Lugar { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public Estado estado { get; private set; }

        public void Completar()
        {
            estado = Estado.Terminado;
        }

        public QueHacer(string lugar, string titulo, string descripcion)
        {
            Lugar = lugar;
            Titulo = titulo;
            Descripcion = descripcion;
            estado = Estado.EnProgreso;
        }
    }
}

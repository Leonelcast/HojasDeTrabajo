using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    public class Persona
    {

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public QueHaceres Tareas { get; set; }

        public Persona()
        {
            Tareas = new QueHaceres();
        }

        public Persona(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
            Tareas = new QueHaceres();
        }
        public void AgregarQueHacer(QueHacer queHacer)
        {
            Tareas.AgregarTarea(queHacer);
        }

        public void CompletarQueHacer()
        {
            Tareas.CompletarQueHacer();
        }

        public bool EstaDisponible()
        {
            if (Tareas.Disponible())
            {
                return true;
            }
            return false;
        }

   
    }
}
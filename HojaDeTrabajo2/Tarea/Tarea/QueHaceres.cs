using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    public class QueHaceres
    {

        public List<QueHacer> Lista { get; set; }

        public QueHaceres()
        {
            Lista = new List<QueHacer>();
        }

        public void AgregarTarea(QueHacer QueHacer)
        {
            Lista.Add(QueHacer);
        }

        public bool Disponible()
        {
            for (int i = 0; i < Lista.Count; i++)
            {
                if (Lista[i].estado == Estado.EnProgreso)
                {
                    return false;
                }
            }
            return true;
        }

        public void CompletarQueHacer()
        {
            for (int i = Lista.Count - 1; i >= 0; i--)
            {
                if (Lista[i].estado == Estado.EnProgreso)
                {
                    Lista[i].Completar();
                    break;
                }
            }
        }
    }
}

            

            
            
        
    


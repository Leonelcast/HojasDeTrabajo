using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Persona P1 = new Persona();
                Persona P2 = new Persona();

                QueHacer queHacer1 = new QueHacer("Casa", "Almuerzo",  "Hacer el almuerzo en la casa");
                QueHacer queHacer2 = new QueHacer("Colonia","Pasear perro", "Pasear a mi perro en la colonia");
                QueHacer queHacer3 = new QueHacer("Gimnasio","Ejercicio", "Hacer ejercicio en el gimansio");
                QueHacer queHacer4 = new QueHacer("Condominio","Lavar carro", "Lavar el carro en el condominio");
                QueHacer queHacer5 = new QueHacer("Casa","Platos", "Lavar los platos de la casa");
                QueHacer queHacer6 = new QueHacer("Casa","Tarea", "Hacer la tarea de calculo en la casa");

                P1.AgregarQueHacer(queHacer1);
                P1.AgregarQueHacer(queHacer2);
                P1.AgregarQueHacer(queHacer3);

                P2.AgregarQueHacer(queHacer4);
                P2.AgregarQueHacer(queHacer5);
                P2.AgregarQueHacer(queHacer6);

                P1.CompletarQueHacer();

                P2.CompletarQueHacer();
                P2.CompletarQueHacer();
                P2.CompletarQueHacer();

                Console.WriteLine("Persona 1 esta disponible? " + P1.EstaDisponible());
                Console.WriteLine("Persona 2 esta disponible?" + P2.EstaDisponible());
                Console.ReadLine();
            }
        }
    }



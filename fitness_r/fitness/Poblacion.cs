using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitness
{
    class Poblacion
    {

        // ------------------------------------------------------
        // Atributos
        // ------------------------------------------------------

        public Organismo[] Organismos { get; set; }


        // ------------------------------------------------------
        // Métodos
        // ------------------------------------------------------

        public Poblacion (int tamaño, float porcentajeA)
        {
            Organismos = new Organismo[tamaño];

            int cantidadDeA = (int)(tamaño * porcentajeA);

            Console.WriteLine("As: " + tamaño * porcentajeA);
            for (int i = 0; i < tamaño; i++)
            {
                if (i < cantidadDeA)
                    Organismos[i] = new Organismo(Organismo.Rasgo.A);
                else
                    Organismos[i] = new Organismo(Organismo.Rasgo.B);
            }
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nuevoTamaño"></param>
        public void Reproducir(int nuevoTamaño)
        {
            Organismo[] nuevaPoblacion = new Organismo[nuevoTamaño];
            Random rng = new Random();

            for (int i = 0; i < nuevoTamaño;)
            {
                while (nuevaPoblacion[i] == null)
                {
                    int index = rng.Next(0, Organismos.Length -1); // Selecciona un organismo al azar.
                    float fitness = Organismos[index].DarFitness();
                    float random = rng.Next(0, 100) /100f ;         
                    if (random <= fitness)
                    {
                        //Console.WriteLine("Rasgo: " + Organismos[index].rasgo + " rand:" + random);
                        nuevaPoblacion[i] = new Organismo(Organismos[index].rasgo);                 
                        i++;
                        break; // Termina el while, no el for.
                    }                    
                }
            }

            Organismos = nuevaPoblacion;

        }





    }


}

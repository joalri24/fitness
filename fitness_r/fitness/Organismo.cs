using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitness
{
    class Organismo
    {
        // ------------------------------------------------------
        // Constantes
        // ------------------------------------------------------

        public enum Rasgo
        {
            A,
            B
        }

        // ------------------------------------------------------
        // Atributos
        // ------------------------------------------------------

        public Rasgo rasgo { get; set; }

        public static float FitnessA;


        // ------------------------------------------------------
        // Métodos
        // ------------------------------------------------------

        public Organismo(Rasgo rasgoP)
        {
            rasgo = rasgoP;
        }

        
        public float DarFitness()
        {
            float resp = (rasgo == Rasgo.A)? FitnessA: 1- FitnessA;
            return resp;
        }




    }
}

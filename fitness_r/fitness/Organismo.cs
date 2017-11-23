using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitness
{
    class Organism
    {
        // ------------------------------------------------------
        // Constants
        // ------------------------------------------------------

        public enum Trait
        {
            A,
            B
        }

        // ------------------------------------------------------
        // Attributes
        // ------------------------------------------------------

        public Trait trait { get; set; }

        public static float FitnessA;


        // ------------------------------------------------------
        // Methods
        // ------------------------------------------------------

        public Organism(Trait traitP)
        {
            trait = traitP;
        }

        /// <summary>
        /// The fitness for the A trait is given by the user.
        /// The fitness for the B trait is 1 - fitness A.
        /// </summary>
        /// <returns></returns>
        public float GetFitness()
        {
            float resp = (trait == Trait.A)? FitnessA: 1- FitnessA;
            return resp;
        }

    }
}

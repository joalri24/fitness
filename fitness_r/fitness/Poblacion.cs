using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fitness
{
    class Population
    {

        // ------------------------------------------------------
        // Attributes
        // ------------------------------------------------------

        public Organism[] Organisms { get; set; }


        // ------------------------------------------------------
        // Métodos
        // ------------------------------------------------------
        /// <summary>
        /// Creates a new population 
        /// </summary>
        /// <param name="size">population's initial size</param>
        /// <param name="aPercentage">% of organism with the A trait</param>
        public Population (int size, float aPercentage)
        {
            Organisms = new Organism[size];
            int amountOfA = (int)(size * aPercentage);
            //Console.WriteLine("As: " + size * aPercentage);

            for (int i = 0; i < size; i++)
            {
                if (i < amountOfA)
                    Organisms[i] = new Organism(Organism.Trait.A);
                else
                    Organisms[i] = new Organism(Organism.Trait.B);
            }        
        }

        /// <summary>
        /// Simulates the change of generation in the population.
        /// </summary>
        /// <param name="newSize"></param>
        public void Reproduce(int newSize)
        {
            Organism[] newPopulation = new Organism[newSize];
            Random rng = new Random();

            for (int i = 0; i < newSize;) 
            {
                while (newPopulation[i] == null)
                {
                    int index = rng.Next(0, Organisms.Length -1); // Select a random organism.
                    float fitness = Organisms[index].GetFitness();
                    float random = rng.Next(0, 100) /100f ;         
                    if (random <= fitness) // if the organism was able to reproduce
                    {
                        newPopulation[i] = new Organism(Organisms[index].trait);                 
                        i++;
                        break; // breaks the 'while', not the 'for'.
                    }                    
                }
            }
            Organisms = newPopulation;
        }

    }
}

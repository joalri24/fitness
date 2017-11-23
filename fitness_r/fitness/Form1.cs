using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fitness
{
    /// <summary>
    /// <Author> Jose Riaño, César Aponte -  2017 </Author>
    /// </summary>
    public partial class Fitness : Form
    {

        // ------------------------------------------------------
        // Attributes
        // ------------------------------------------------------


        // ------------------------------------------------------
        // Methods
        // ------------------------------------------------------

        public Fitness()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Executed when button1 is clicked.
        /// Creates a population and starts the simulation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            /*for (int j = 0; j < replicas.Value; j++)
            {*/
            //Console.WriteLine("------------------------------ Replica "+ (j+1) +" ------------------------------");
            //fileLines.Add(">Replica " + (j + 1));
            /*}*/

            //System.IO.File.WriteAllLines("Resultados.txt", fileLines.ToArray());
            Organism.FitnessA = (float)fitnessA.Value;
            Parallel.For(0, (int)replicas.Value, (replica) => RunSimulation(replica));
            Console.WriteLine("------------------------------ *FIN* ------------------------------ ");

        }

        private void RunSimulation(int replicaId)
        {
            List<string> fileLines = new List<string>();
            fileLines.Add(">Replica " + replicaId);
            fileLines.Add("generation, %A, %B, individuals"); // Header line       
            Population population = new Population((int)initialSize.Value, (float)aPercentaje.Value / 100);

            PrintPopulation(1, population, fileLines); // prints the first generation. Can be done with a Do...while
            bool capReached = false;

            for (int i = 0; i < numCycles.Value && !capReached; i++)
            {
                float multiplier = (1 + (float)(growth.Value / 100));
                float newOrganisms = population.Organisms.Length * multiplier;
                int newSize = (int)newOrganisms;

                // if the growth is less than 1 but not 0, add 1
                newSize = (growth.Value != 0 && newSize == population.Organisms.Length) ? newSize + 1 : newSize; 
                population.Reproduce(newSize);
                capReached = PrintPopulation(i + 2, population, fileLines);
            }
            
            System.IO.File.WriteAllLines("Resultados"+ replicaId + ".txt", fileLines.ToArray());
            Console.WriteLine("------------------------------ FIN ------------------------------ " + replicaId);
        }

        /// <summary>
        /// Prints the current state of the population.
        /// Returns true if the A trait either dissapears or reached a 100% coverage
        /// </summary>
        /// <param name="generation">generation number</param>
        /// <returns>returns true if the A trait either dissapears or reached a 100% coverage</returns>
        private bool PrintPopulation(int generation, Population population, List<string> fileLines)
        {       
            //Console.WriteLine("Generación " + generation + " ------------------------------");
            //Console.WriteLine("individuos: " + population.Organisms.Length);
            int As = 0; // number of organism with the 'A' trait.

            foreach (var organism in population.Organisms)
            {
                if (organism.trait == Organism.Trait.A)
                    As++;
            }

            float aPercentage = (float)As / population.Organisms.Length * 100f;
            bool capReached = (aPercentage == 100f || aPercentage == 0f);
            //Console.WriteLine("%A:  " + aPercentage);
            //Console.WriteLine("%B:  " + (100f - aPercentage));
            fileLines.Add(generation + ";" + aPercentage +";" + (100f - aPercentage) +";"+ population.Organisms.Length);
            return capReached;
        }

    }
}

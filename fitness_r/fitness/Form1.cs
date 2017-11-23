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

        private Population Population { get; set; }
        private List<string> fileLines;


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
            fileLines = new List<string>();
            fileLines.Add("generation, %A, %B, tot. individuals"); // Header line

            for (int j = 0; j < replicas.Value; j++)
            {
                Console.WriteLine("------------------------------ Replica "+ (j+1) +" ------------------------------");
                fileLines.Add(">Replica " + (j + 1));
                Population = new Population((int)initialSize.Value, (float)aPercentaje.Value / 100);
                Organism.FitnessA = (float)fitnessA.Value;
                PrintPopulation(1); // prints the first generation. Can be done with a Do...while
                bool capReached = false;

                for (int i = 0; i < numCycles.Value && !capReached; i++)
                {

                    float multiplicador = (1 + (float)(growth.Value / 100));
                    float adicion = Population.Organisms.Length * multiplicador;
                    int nuevoTamaño = (int)adicion;

                    nuevoTamaño = (growth.Value != 0 && nuevoTamaño == Population.Organisms.Length) ? nuevoTamaño + 1 : nuevoTamaño;
                    Population.Reproduce(nuevoTamaño);
                    capReached = PrintPopulation(i + 2);
                }

                Console.WriteLine("------------------------------ FIN ------------------------------");
            }

            System.IO.File.WriteAllLines("Resultados.txt", fileLines.ToArray());

        }

        /// <summary>
        /// Prints the current state of the population.
        /// Returns true if the A trait either dissapears or reached a 100% coverage
        /// </summary>
        /// <param name="generation">generation number</param>
        /// <returns>returns true if the A trait either dissapears or reached a 100% coverage</returns>
        private bool PrintPopulation(int generation)
        {
            
            Console.WriteLine("Generación " + generation + " ------------------------------");
            Console.WriteLine("individuos: " + Population.Organisms.Length);
            int As = 0; // number of organism with the 'A' trait.

            foreach (var organism in Population.Organisms)
            {
                if (organism.trait == Organism.Trait.A)
                    As++;
            }

            float aPercentage = (float)As / Population.Organisms.Length * 100f;
            bool capReached = (aPercentage == 100f || aPercentage == 0f);
            Console.WriteLine("%A:  " + aPercentage);
            Console.WriteLine("%B:  " + (100f - aPercentage));
            fileLines.Add(generation + ";" + aPercentage +";" + (100f - aPercentage) +";"+ Population.Organisms.Length);
            return capReached;
        }

    }
}

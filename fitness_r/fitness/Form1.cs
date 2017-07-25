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
    /// <Author> Jose Riaño 2017 </Author>
    /// </summary>
    public partial class Fitness : Form
    {

        // ------------------------------------------------------
        // Atributos
        // ------------------------------------------------------

        private Poblacion Poblacion { get; set; }



        // ------------------------------------------------------
        // Métodos
        // ------------------------------------------------------

        public Fitness()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {

            Poblacion = new Poblacion((int)tamañoInicial.Value, (float)porcentajeA.Value / 100);
            Organismo.FitnessA = (float)fitnessA.Value;

            ImprimirPoblacion(1);

            for (int i = 0; i < numCiclos.Value; i++)
            {
                int nuevoTamaño = (int) (Poblacion.Organismos.Length * (1 + (float)(crecimiento.Value / 100)));
                Console.WriteLine("NT: " + nuevoTamaño);
                Poblacion.Reproducir(nuevoTamaño);
                ImprimirPoblacion(i+2);
            }

           
            /*foreach (var org in Poblacion.Organismos)
            {
                Console.WriteLine(org.rasgo + " fit: " + org.DarFitness());
            }*/


        }


        private void ImprimirPoblacion(int generacion)
        {
            Console.WriteLine("Generación " + generacion);
            int As = 0;

            foreach (var organismo in Poblacion.Organismos)
            {
                if (organismo.rasgo == Organismo.Rasgo.A)
                    As++;
                Console.WriteLine(organismo.rasgo);
            }

            Console.WriteLine("%A:  " + (float)As/Poblacion.Organismos.Length * 100f);
            Console.WriteLine("%B:  " + (Poblacion.Organismos.Length - (float)As) / Poblacion.Organismos.Length * 100f);
        }


    }
}

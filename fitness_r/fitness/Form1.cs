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
            bool topeAlcanzado = false;

            for (int i = 0; i < numCiclos.Value && !topeAlcanzado; i++)
            {
                int nuevoTamaño = (int) (Poblacion.Organismos.Length * (1 + (float)(crecimiento.Value / 100)));
                nuevoTamaño = (crecimiento.Value != 0 && nuevoTamaño == Poblacion.Organismos.Length) ? nuevoTamaño + 1 : nuevoTamaño;
                Poblacion.Reproducir(nuevoTamaño);
                topeAlcanzado = ImprimirPoblacion(i+2);
            }


            /*foreach (var org in Poblacion.Organismos)
            {
                Console.WriteLine(org.rasgo + " fit: " + org.DarFitness());
            }*/

            Console.WriteLine("------------------------------ FIN ------------------------------");

        }


        private bool ImprimirPoblacion(int generacion)
        {
            
            Console.WriteLine("Generación " + generacion + " ------------------------------");
            Console.WriteLine("individuos: " + Poblacion.Organismos.Length);
            int As = 0;


            foreach (var organismo in Poblacion.Organismos)
            {
                if (organismo.rasgo == Organismo.Rasgo.A)
                    As++;
                 //Console.WriteLine(organismo.rasgo); // Imprime cada organismo
            }
            float porcentajeA = (float)As / Poblacion.Organismos.Length * 100f;
            bool topeAlcanzado = (porcentajeA == 100f || porcentajeA == 0f);
            Console.WriteLine("%A:  " + porcentajeA);
            Console.WriteLine("%B:  " + (100f - porcentajeA));
            return topeAlcanzado;
        }


    }
}

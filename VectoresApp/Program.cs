using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VectoresApp
{
    class VectoresApp
    {
        private int[] edades;

        public void Cargar()
        {
            edades=new int[5];
            for (int f = 0; f < edades.Length; f++)
            {
                Console.Write("Ingrese edad:");
                string linea = Console.ReadLine();
                edades[f]=int.Parse(linea);
            }
        }

        public void Ordenar()
        {
            for (int k = 0; k < 4; k++)
            {
                for (int f = 0; f < 4 - k; f++)
                {
                    if (edades[f] > edades[f + 1])
                    {
                        int aux;
                        aux = edades[f];
                        edades[f] = edades[f + 1];
                        edades[f + 1] = aux;
                    }
                }
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("Edades ordenadas de menor a mayor.");
            for (int f = 0; f < edades.Length; f++)
            {
                Console.WriteLine(edades[f]);
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            VectoresApp pv = new VectoresApp();
            pv.Cargar();
            pv.Ordenar();
            pv.Imprimir();
        }
    }
}

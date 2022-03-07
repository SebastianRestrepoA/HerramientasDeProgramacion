using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, suma, valor, promedio, n;
            string linea;
            x=1;
            suma=0;
            Console.Write("Ingrese la cantidad de numeros a digitar:");
            linea = Console.ReadLine();
            n=int.Parse(linea);

            if (n<=0)
            {
                Console.Write("ERROR!====> Debes ingresar un numero mayor a cero. Pulsa entender y vuelve a ejecutar");
                Console.ReadKey();
            }
            else
            {
                for (x=1; x<=n; x++)
                {
                    Console.Write(String.Concat("Digite el valor ", x, ": "));
                    linea = Console.ReadLine();
                    valor=int.Parse(linea);
                    suma=suma+valor;
                }
                promedio=suma/n;
                Console.Write("El promedio es: ");
                Console.Write(promedio);
                Console.ReadKey();

            }

        }
    }
}

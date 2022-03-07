using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileApp
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
                while (x<=n)
                {
                    Console.Write(String.Concat("Digite el valor ", x, ": "));
                    linea = Console.ReadLine();
                    valor=int.Parse(linea);
                    suma=suma+valor;
                    x=x+1;
                }
                promedio=suma/n;
                Console.Write("El promedio es: ");
                Console.Write(promedio);
                Console.ReadKey();

            }

        }
    }
}


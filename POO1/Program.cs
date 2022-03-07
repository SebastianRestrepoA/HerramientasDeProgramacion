using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO1
{
    class Cliente
    {
        public string nombre;
        private int monto;

        public Cliente(string nom)
        {
            nombre = nom;
            monto = 0;
        }

        public void Depositar(int m)
        {
            monto = monto + m;
        }

        public void Retirar(int m)
        {
            monto = monto - m;
        }

        public int RetornarMonto()
        {
            return monto;
        }

        public void Imprimir()
        {
            Console.WriteLine(nombre + " tiene depositado la suma de " + monto);
        }
    }

    class Banco
    {
        private Cliente cliente1, cliente2, cliente3;
        public Banco()
        {
            Console.Write("Ingrese nombre del cliente 1: ");
            cliente1 = new Cliente(Console.ReadLine());
            Console.Write("Ingrese nombre del cliente 2: ");
            cliente2 = new Cliente(Console.ReadLine());
            Console.Write("Ingrese nombre del cliente 3: ");
            cliente3 = new Cliente(Console.ReadLine());

        }

        public void Operar(int intEleccion)
        {
            string montoDepositar, montoRetirar, nombreOperar;
            int montoDeposito, montoRetiro;

            Console.Write("Ingresa tu nombre por favor: ");
            nombreOperar = Console.ReadLine();

            if (intEleccion==1)
            {
                Console.Write("Ingresa el monto a depositar: ");
                montoDepositar = Console.ReadLine();
                montoDeposito = int.Parse(montoDepositar);

                if (nombreOperar==cliente1.nombre)
                {
                    cliente1.Depositar(montoDeposito);
                }
                else if (nombreOperar==cliente2.nombre)
                {
                    cliente2.Depositar(montoDeposito);
                }
                else if (nombreOperar==cliente3.nombre)
                {
                    cliente3.Depositar(montoDeposito);
                }
                else
                {
                    Console.Write("Nombre no registrado: ");
                }

            }
            else if (intEleccion==2)
            {

                Console.Write("Ingresa el monto a retirar: ");
                montoRetirar = Console.ReadLine();
                montoRetiro = int.Parse(montoRetirar);

                if (nombreOperar==cliente1.nombre)
                {
                    cliente1.Retirar(montoRetiro);
                }
                else if (nombreOperar==cliente2.nombre)
                {
                    cliente2.Retirar(montoRetiro);
                }
                else if (nombreOperar==cliente3.nombre)
                {
                    cliente3.Retirar(montoRetiro);
                }
                else
                {
                    Console.Write("Nombre no registrado: ");
                }
            }
            else
            {
                Console.Write("Opción no valida");

            }

        }

        public void DepositosTotales()
        {
            int t = cliente1.RetornarMonto() +
                    cliente2.RetornarMonto() +
                    cliente3.RetornarMonto();
            Console.WriteLine("El total de dinero en el banco es:" + t);
            cliente1.Imprimir();
            cliente2.Imprimir();
            cliente3.Imprimir();
        }

        static void Main(string[] args)
        {
            string strEleccion;
            int intEleccion;
            Banco banco1 = new Banco();
            do
            {
                Console.Write("Bienvenido al Banco del estudiante. Si desea depositar marque 1, Si desea retirar marque 2: ");
                Console.Write("Si desea finalizar la jornada del banco marca 0.");
                strEleccion = Console.ReadLine();
                intEleccion = int.Parse(strEleccion);
                if (intEleccion!=0)
                {
                    banco1.Operar(intEleccion);
                }
            } while (intEleccion!=0);            
            banco1.DepositosTotales();
            Console.ReadKey();
        }
    }
}

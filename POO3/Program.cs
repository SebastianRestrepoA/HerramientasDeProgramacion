using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POO2
{
    class Jugador
    {
        private int valor;
        public string nombre;
        private static Random NumeroAleatorio;

        public Jugador(string nom)
        {
            NumeroAleatorio = new Random();
            nombre = nom;
        }

        public void Lanzar()
        {
            valor = NumeroAleatorio.Next(1, 7);
            Console.WriteLine("El valor del dado es:" + valor);
        }

        public int ValorObtenido()
        {
            return valor;
        }
    }

    class JuegoDeDados
    {
        private Jugador jugador1, jugador2;

        public JuegoDeDados()
        {
            Console.Write("Ingrese nombre del jugador 1: ");
            jugador1 = new Jugador(Console.ReadLine());
            Console.Write("Ingrese nombre del jugador 1: ");
            jugador2 = new Jugador(Console.ReadLine());
        }

        public void Jugar()
        {
            jugador1.Lanzar();
            jugador2.Lanzar();
            if (jugador1.ValorObtenido() > jugador2.ValorObtenido()) { 
                Console.WriteLine("Jugador 1 ha ganado");
            }else if (jugador1.ValorObtenido() == jugador2.ValorObtenido())
            {
                Console.WriteLine("Juego Empatado");

            }
            else
            {
                Console.WriteLine("Jugador 2 ha ganado"); ;
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            JuegoDeDados juego = new JuegoDeDados();
            juego.Jugar();
        }
    }
}


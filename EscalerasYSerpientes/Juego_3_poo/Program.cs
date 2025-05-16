using Ejemplo3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_3_poo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese Nombre Jugador 1");
            string jugador1 = Console.ReadLine();
            Console.WriteLine("Ingrese Nombre Jugador 1");
            string jugador2 = Console.ReadLine();

            Tablero tablero = new Tablero(jugador1, jugador2);

            do
            {
                tablero.JugarPartida();

                Console.WriteLine("Jugador 1 - Posición: " + tablero.Jugador1.Posicion);
                Console.WriteLine("Jugador 2 - Posición: " + tablero.Jugador2.Posicion);
            }
            while (tablero.FinJuego == false);

            if (tablero.Ganador != null)
            {
                Console.WriteLine(tablero.Ganador.Nombre);
            }
            else
            {
                Console.WriteLine("No hubo ganador");
            }

            Console.ReadKey();
        }
    }
}

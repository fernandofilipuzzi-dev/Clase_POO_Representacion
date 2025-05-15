using Ejemplo3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese Nombre Jugador 1");
            string jugador1=Console.ReadLine();
            Console.WriteLine("Ingrese Nombre Jugador 1");
            string jugador2 = Console.ReadLine();

            Tablero tablero = new Tablero(jugador1, jugador2);

            do
            {
                tablero.JugarPartida();
            }
            while (tablero.FinJuego == false);

            if(tablero.Ganador!=null)
                Console.WriteLine(tablero.Ganador.Nombre);
            else
                Console.WriteLine("No hubo ganador");

            Console.ReadKey();
        }
    }
}

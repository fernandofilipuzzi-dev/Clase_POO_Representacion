using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
    internal class Program
    {
        static Random azar = new Random();

        static string jugador1;
        static string jugador2;

        static int posicionJugador1 = 0;
        static int posicionJugador2 = 0;

        static int colaSerpiente;
        static int cabezaSerpiente;

        static int pieEscalera1;
        static int cabeceraEscalera1;
        static int pieEscalera2;
        static int cabeceraEscalera2;

        static public int DeterminarPosicionJugador(int posicion)
        {
            int avance = azar.Next(1, 6);
            posicion += avance;

            #region verificar si hay serpiente
            if (posicion == cabezaSerpiente)
            {
                posicion = colaSerpiente;
            }
            #endregion

            #region verificar si escalera
            if (posicion== pieEscalera1)
            {
                posicion = cabeceraEscalera1;
            }
            if (posicion == pieEscalera2)
            {
                posicion = cabeceraEscalera2;
            }
            #endregion

            return posicion;
        }

        static public void IniciarPosicionSerpiente()
        {
            int colaSerpiente = azar.Next(1, 100);
            int cabezaSerpiente = azar.Next(colaSerpiente, 100);            
        }

        static public void IniciarPosicionEscaleras()
        {
            #region iniciar posiciones de las dos escaleras            
            pieEscalera1 = azar.Next(1, 100);
            cabeceraEscalera1 = azar.Next(pieEscalera1, 100);

            pieEscalera2 = azar.Next(1, 100);
            cabeceraEscalera2 = azar.Next(pieEscalera2, 100);
            #endregion
        }

        static void Main(string[] args)
        {
            int avance;

            #region solicitar nombre jugador 1 y 2
            string jugador1;
            Console.WriteLine("Ingrese nombre del jugador 1");
            jugador1 = Console.ReadLine();

            string jugador2;
            Console.WriteLine("Ingrese nombre del jugador 2");
            jugador2 = Console.ReadLine();
            #endregion

            IniciarPosicionEscaleras();

            IniciarPosicionSerpiente();

            do
            {
                posicionJugador1=DeterminarPosicionJugador(posicionJugador1);

                Console.WriteLine("Posicion jugador 1:" + posicionJugador1);

                posicionJugador2 = DeterminarPosicionJugador(posicionJugador2);

                Console.WriteLine("Posicion jugador 2:" + posicionJugador2);

            } while ((posicionJugador1 >= 100 ^ posicionJugador2 >= 100) == false);

            if ((posicionJugador1 >= 100 ^ posicionJugador2 >= 100) == true)
            {
                if (posicionJugador1 >= 100)
                {
                    Console.WriteLine("Gano jugador 1");
                }
                else
                {
                    Console.WriteLine("Gano jugador 2");
                }
            }
            else
            {
                Console.WriteLine("No hubo ganadores");
            }

            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Program
    {
        static Random azar = new Random();

        static void Main(string[] args)
        {
            int avance;

            #region iniciar posicion jugador 1 y 2
            int posicionJugador1 = 0;
            int posicionJugador2 = 0;
            #endregion

            #region solicitar nombre jugador 1 y 2
            string jugador1;
            Console.WriteLine("Ingrese nombre del jugador 1");
            jugador1= Console.ReadLine();

            string jugador2;
            Console.WriteLine("Ingrese nombre del jugador 2");
            jugador2 = Console.ReadLine();
            #endregion

            #region iniciar posiciones de las dos escaleras            
            int pieEscalera1=azar.Next(1,100);
            int cabeceraEscalera1 = azar.Next(pieEscalera1, 100);

            int pieEscalera2 = azar.Next(1, 100);
            int cabeceraEscalera2 = azar.Next(pieEscalera2, 100);
            #endregion

            #region iniciar posición de la serpiente
            int colaSerpiente = azar.Next(1, 100);
            int cabezaSerpiente = azar.Next(colaSerpiente, 100);
            #endregion

            do
            {
                #region determinar avance jugador 1
                avance = azar.Next(1, 6);
                posicionJugador1 += avance;

                #region verificar si hay serpiente
                if (posicionJugador1 == cabezaSerpiente)
                {
                    posicionJugador1 = colaSerpiente;
                }
                #endregion

                #region verificar si escalera
                if (posicionJugador1 == pieEscalera1)
                {
                    posicionJugador1 = cabeceraEscalera1;
                }
                if (posicionJugador1 == pieEscalera2)
                {
                    posicionJugador1 = cabeceraEscalera2;
                }
                #endregion

                #endregion

                #region informar posición jugador 1
                Console.WriteLine("Posicion jugador 1:" + posicionJugador1);
                #endregion 

                #region determinar avance jugador 2
                avance = azar.Next(1, 6);
                posicionJugador2 += avance;

                #region verificar si hay serpiente
                if (posicionJugador2 == cabezaSerpiente)
                {
                    posicionJugador2 = colaSerpiente;
                }
                #endregion

                #region verificar si escalera
                if (posicionJugador2 == pieEscalera1)
                {
                    posicionJugador2 = cabeceraEscalera1;
                }
                if (posicionJugador2 == pieEscalera2)
                {
                    posicionJugador2 = cabeceraEscalera2;
                }
                #endregion

                #endregion

                #region informar posición jugador 2
                Console.WriteLine("Posicion jugador 2:" + posicionJugador2);
                #endregion 

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

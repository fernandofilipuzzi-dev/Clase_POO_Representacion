using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_2_op_funciones
{
    internal class Program
    {
        static Random azar = new Random();
        static int posicion1, posicion2;
        static string nombre1, nombre2;
        static int pie1, pie2, cabecera1, cabecera2;
        static int cola, cabeza;
        static bool finJuego = false;
        static  int dado;

        static void InicializarEscaleras()
        {
            #region inicializar posiciones de las dos escaleras
            pie1 = azar.Next(1, 100);
            cabecera1 = azar.Next(pie1, 100);

            pie2 = azar.Next(1, 100);
            cabecera2 = azar.Next(pie2, 100);
            #endregion

            #region inicializar posicion de la serpiente
            cola = azar.Next(1, 100);
            cabeza = azar.Next(cola, 100);
            #endregion
        }
        static int DeterminarAvanceJugador(int posicion)
        {
            dado = azar.Next(1, 7);
            posicion += dado;

            if (cabeza == posicion)
            {
                posicion = cola;
            }

            if (pie1 == posicion)
            {
                posicion = cabecera1;
            }

            if (pie2 == posicion)
            {
                posicion = cabecera2;
            }

            Console.WriteLine("Jugador 1 - Posición: " + posicion);

            return posicion;
        }

        static void Main(string[] args)
        {
         

            #region Iniciar posicion jugador 1 y 2
            posicion1 = 1;
            posicion2 = 1;
            #endregion

            #region solicitar nombre jugador 1 y 2
            Console.WriteLine("Ingrese el nombre del jugador 1");
            nombre1 = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del jugador 2");
            nombre2 = Console.ReadLine();
            #endregion

            InicializarEscaleras();

            #region iterar jugadas
            do
            {
                posicion1 = DeterminarAvanceJugador(posicion1);

                posicion2 = DeterminarAvanceJugador(posicion2);

                finJuego = posicion1 >= 100 || posicion2 >= 100;
            } while (!finJuego);//mientras no haya fin de juego
            #endregion

            #region verificar ganador 
            //false   false     false     que no llego al final ninguno - sigue el jueg
            //true     false    true     que uno llego y el juego termino
            //false    true      true     idems anterior
            //true     true     false     no hay ganador - juego terminado

            if (posicion1 >= 100 ^ posicion2 >= 100)
            {
                if (posicion1 >= 100)
                {
                    Console.WriteLine("El ganador es " + nombre1);
                }
                else
                {
                    Console.WriteLine("El ganador es " + nombre2);
                }
            }
            else
            {
                Console.WriteLine("No hay ganador");
            }
            #endregion


            Console.ReadKey();
        }
    }
}

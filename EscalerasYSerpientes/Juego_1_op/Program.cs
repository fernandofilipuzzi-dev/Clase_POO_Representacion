using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Juego_1_op
{
    internal class Program
    {
        static Random azar=new Random();

        static void Main(string[] args)
        {
            #region declarar variables
            int posicion1, posicion2;
            string nombre1, nombre2;
            int pie1, pie2, cabecera1, cabecera2;
            int cola, cabeza;
            bool finJuego = false;
            int dado;
            #endregion

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

            #region iterar jugadas
            do 
            {
                #region determinar avance jugador 1
                dado = azar.Next(1, 7);
                posicion1 += dado;

                if (cabeza == posicion1)
                { 
                    posicion1 = cola;
                }

                if (pie1 == posicion1)
                {
                    posicion1 = cabecera1;
                }

                if (pie2 == posicion1)
                {
                    posicion1 = cabecera2;
                }
                #endregion

                Console.WriteLine("Jugador 1 - Posición: " + posicion1);

                #region determinar avance jugador 2
                dado = azar.Next(1, 7);
                posicion2 += dado;

                if (cabeza == posicion2)
                {
                    posicion2 = cola;
                }

                if (pie1 == posicion2)
                {
                    posicion1 = cabecera1;
                }

                if (pie2 == posicion1)
                {
                    posicion2 = cabecera2;
                }
                #endregion

                Console.WriteLine("Jugador 2 - Posición: " + posicion2);

                finJuego = posicion1>=100 || posicion2>=100;
            } while (!finJuego);//mientras no haya fin de juego
            #endregion

            #region verificar ganador 
            //false   false     false     que no llego al final ninguno - sigue el jueg
            //true     false    true     que uno llego y el juego termino
            //false    true      true     idems anterior
            //true     true     false     no hay ganador - juego terminado

            if ( posicion1 >= 100 ^ posicion2 >= 100)
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

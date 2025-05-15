using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo3.Models
{
    internal class Tablero
    {
        public bool FinJuego;
        public Jugador Ganador;

        public Jugador Jugador1;
        public Jugador Jugador2;
        public Serpiente Serpiente1;
        public Escalera Escalera1;
        public Escalera Escalera2;

        public Tablero(string nombre1, string nombre2)
        {
            Jugador1 = new Jugador(nombre1);
            Jugador2 = new Jugador(nombre2);

            Serpiente1 = new Serpiente();
            Escalera1 = new Escalera();
            Escalera2 = new Escalera();
        }

        public void JugarPartida()
        {
            if (FinJuego == false)
            {
                #region turno jugador 1
                Jugador1.Avanza();
                Serpiente1.Mover(Jugador1);
                Escalera1.Mover(Jugador1);
                Escalera2.Mover(Jugador2);
                #endregion

                #region turno jugador 2
                Jugador2.Avanza();
                Serpiente1.Mover(Jugador2);
                Escalera1.Mover(Jugador2);
                Escalera2.Mover(Jugador2);
                #endregion

                FinJuego = Jugador1.Posicion >= 100 || Jugador1.Posicion >= 100;

                if (Jugador1.Posicion >= 100 ^ Jugador1.Posicion >= 100)
                {
                    if (Jugador1.Posicion >= 100)
                        Ganador = Jugador1;
                    else
                        Ganador = Jugador2;
                }
            }
        }
    }
}

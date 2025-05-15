using System;

namespace Ejemplo3.Models
{
    internal class Escalera
    {
        static Random azar = new Random();

        public int Cabecera;
        public int Pie;

        public Escalera()
        {
            Pie=azar.Next(1,100);
            Cabecera=azar.Next(Pie,100);
        }

        public void Mover(Jugador jugador)
        {
            if (jugador.Posicion == Pie)
            {
                jugador.Posicion = Cabecera;
            }
        }
    }
}

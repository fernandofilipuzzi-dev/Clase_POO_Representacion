using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo3.Models
{
    internal class Serpiente
    {
        static Random azar = new Random();

        public int Cabeza;
        public int Cola;

        public Serpiente()
        {
            Cola = azar.Next(1, 100);
            Cabeza = azar.Next(Cola, 100);
        }

        public void Mover(Jugador jugador)
        {
            if (jugador.Posicion == Cabeza)
            {
                jugador.Posicion = Cola;
            }
        }
    }
}

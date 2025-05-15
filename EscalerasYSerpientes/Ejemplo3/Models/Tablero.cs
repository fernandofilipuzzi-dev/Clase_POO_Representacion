using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo3.Models
{
    internal class Tablero
    {
        public Jugador Jugador1;
        public Jugador Jugador2;

        public Tablero(string nombre1, string nombre2)
        {
            Jugador1 = new Jugador(nombre1);
            Jugador2 = new Jugador(nombre2);
        }

        public void Jugar()
        { 

        }
    }
}

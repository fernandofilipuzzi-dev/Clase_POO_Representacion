using System;

namespace Ejemplo3.Models
{
    internal class Jugador
    {
        static Random azar = new Random();

        public string Nombre;
        public int Posicion;

        public Jugador(string nombre)
        {
            Nombre = nombre;
            Posicion = 0;
        }

        public void Tirar()
        { 
            Posicion+=azar.Next(1,6);
        }
    }
}

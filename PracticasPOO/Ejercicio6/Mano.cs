using System;
using System.Collections.Generic;

namespace Ejercicio6
{
    public class Mano
    {
        private List<Carta> cartasEnMano;

        public Mano()
        {
            cartasEnMano = new List<Carta>();
        }

        public void RecibirCarta(Carta carta)
        {
            if (carta != null)
            {
                cartasEnMano.Add(carta);
            }
        }

        public void MostrarMano()
        {
            Console.WriteLine("Cartas en la mano:");
            foreach (Carta carta in cartasEnMano)
            {
                Console.WriteLine($"- {carta.ToString()}"); // Acá usa el truquito del ToString que hicimos antes
            }
        }

        public int CantidadDeCartas()
        {
            return cartasEnMano.Count;
        }
    }
}
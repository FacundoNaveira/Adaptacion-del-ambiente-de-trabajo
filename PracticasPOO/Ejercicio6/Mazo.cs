using System;
using System.Collections.Generic;

namespace Ejercicio6
{
    public class Mazo
    {
        // La lista privada que guarda las cartas
        private List<Carta> cartas;

        public Mazo()
        {
            cartas = new List<Carta>();
            string[] palos = { "Espadas", "Bastos", "Oros", "Copas" };

            // Llenamos el mazo con las 48 cartas clásicas (1 al 12 por cada palo)
            foreach (string palo in palos)
            {
                for (int i = 1; i <= 12; i++)
                {
                    cartas.Add(new Carta(palo, i));
                }
            }
        }

        public void Barajar()
        {
            Random generadorAleatorio = new Random();
            int n = cartas.Count;

            // Algoritmo para mezclar la lista intercambiando posiciones al azar
            while (n > 1)
            {
                n--;
                int k = generadorAleatorio.Next(n + 1);
                Carta cartaTemporal = cartas[k];
                cartas[k] = cartas[n];
                cartas[n] = cartaTemporal;
            }
            Console.WriteLine("[Mazo] Las cartas han sido barajadas.");
        }

        public Carta RobarCarta()
        {
            if (cartas.Count == 0)
            {
                Console.WriteLine("[Error] No quedan más cartas en el mazo.");
                return null; // Devolvemos nulo porque no hay carta para dar
            }

            // Sacamos la carta de la posición 0 (el tope del mazo)
            Carta cartaRobada = cartas[0];
            cartas.RemoveAt(0); // La borramos del mazo

            return cartaRobada;
        }

        public int CuantasCartasQuedan()
        {
            return cartas.Count;
        }
    }
}
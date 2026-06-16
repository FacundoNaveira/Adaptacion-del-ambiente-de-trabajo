using System;

namespace Ejercicio6
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== INICIANDO PARTIDA ===");

            Mazo mazo = new Mazo();
            mazo.Barajar();

            Mano jugador1 = new Mano();
            Mano jugador2 = new Mano();

            Console.WriteLine("\nRepartiendo cartas...");
            // Repartir 3 cartas a cada jugador
            for (int i = 0; i < 3; i++)
            {
                jugador1.RecibirCarta(mazo.RobarCarta());
                jugador2.RecibirCarta(mazo.RobarCarta());
            }

            Console.WriteLine("\n--- JUGADOR 1 ---");
            jugador1.MostrarMano();

            Console.WriteLine("\n--- JUGADOR 2 ---");
            jugador2.MostrarMano();

            Console.WriteLine($"\nCartas restantes en el mazo: {mazo.CuantasCartasQuedan()}");

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
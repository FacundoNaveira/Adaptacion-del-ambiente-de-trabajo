using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main()
        {
            // 1. Código de prueba original del PDF 
            Console.WriteLine("--- Prueba individual de la Bicicleta ---");
            Auto fiat = new Auto(45); // Un auto más rápido que el default [cite: 80, 78]
            Bicicleta bici = new Bicicleta();
            Camion camion = new Camion();

            bici.Mover(20);
            Console.WriteLine($"Posición bici después de 20s: {bici.Posicion()} metros");
            bici.Mover(10);
            Console.WriteLine($"Posición bici sumando 10s más: {bici.Posicion()} metros\n");

            // 2. Probamos nuestra clase Carrera [cite: 90]
            Carrera pistaDeCarreras = new Carrera();

            Console.WriteLine("--- CARRERA 1: Fiat (45 m/s) vs Camión (30 m/s) ---");
            pistaDeCarreras.IniciarCarrera(fiat, camion, 10); // Corren por 10 segundos

            Console.WriteLine("\n--- CARRERA 2: Camión (30 m/s) vs Bici (10 m/s) ---");
            pistaDeCarreras.IniciarCarrera(camion, bici, 15); // Corren por 15 segundos

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
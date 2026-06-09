using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main()
        {
            // Instanciamos (creamos) un nuevo objeto semáforo en color Verde
            Semaforo miSemaforo = new Semaforo("Verde");

            // Comprobamos el color inicial
            miSemaforo.MostrarColor();

            // Hacemos avanzar el tiempo 20 segundos (justo el tiempo que dura el verde)
            Console.WriteLine("\n--- Pasan 20 segundos ---");
            miSemaforo.PasoDelTiempo(20);
            miSemaforo.MostrarColor(); // Debería mostrar Amarillo

            // Pasan 3 segundos más (1 segundo sobra del amarillo, pasa a rojo)
            Console.WriteLine("\n--- Pasan 3 segundos ---");
            miSemaforo.PasoDelTiempo(3);
            miSemaforo.MostrarColor(); // Debería mostrar Rojo

            // Probamos el intermitente
            Console.WriteLine("\n--- Modo Intermitente activado por 4 segundos ---");
            miSemaforo.PonerEnIntermitente();
            miSemaforo.PasoDelTiempo(1);
            miSemaforo.MostrarColor(); // Apagado
            miSemaforo.PasoDelTiempo(1);
            miSemaforo.MostrarColor(); // Amarillo

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main()
        {
            // Creamos el objeto
            Cronometro cronometro = new Cronometro();

            // Ciclo de prueba: hace avanzar el cronómetro 5000 veces
            for (int i = 0; i < 5000; i++)
            {
                cronometro.IncrementarTiempo();
            }

            // Muestra el resultado final en la consola
            Console.WriteLine(cronometro.MostrarTiempo());

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
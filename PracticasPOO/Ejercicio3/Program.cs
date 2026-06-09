using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main()
        {
            // Creamos un jugador de cada tipo usando la interfaz
            IJugador pibeDeBarrio = new Amateur();
            IJugador messi = new Profesional();

            Console.WriteLine("--- Prueba: Correr 30 minutos ---");

            // El Amateur se rinde a los 20 
            bool resultadoAmateur = pibeDeBarrio.Correr(30);
            Console.WriteLine($"¿El Amateur pudo correr 30 min enteros? {resultadoAmateur}");
            Console.WriteLine($"¿El Amateur terminó cansado? {pibeDeBarrio.Cansado()}");

            Console.WriteLine();

            // El Profesional aguanta hasta 40, así que 30 los hace bien 
            bool resultadoProfesional = messi.Correr(30);
            Console.WriteLine($"¿El Profesional pudo correr 30 min enteros? {resultadoProfesional}");
            Console.WriteLine($"¿El Profesional terminó cansado? {messi.Cansado()}");

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    public class Carrera
    {
        // Pide dos vehículos genéricos y el tiempo a correr
        public void IniciarCarrera(IVehiculo vehiculo1, IVehiculo vehiculo2, int segundosDeCarrera)
        {
            // Primero, nos aseguramos que ambos arranquen en cero
            vehiculo1.ReiniciarPosicion();
            vehiculo2.ReiniciarPosicion();

            // Los hacemos correr el tiempo indicado
            vehiculo1.Mover(segundosDeCarrera);
            vehiculo2.Mover(segundosDeCarrera);
            
            // Mostramos los resultados finales
            int posicion1 = vehiculo1.Posicion();
            int posicion2 = vehiculo2.Posicion();

            Console.WriteLine($"El Vehículo 1 llegó a los {posicion1} metros.");
            Console.WriteLine($"El Vehículo 2 llegó a los {posicion2} metros.");

            // Determinamos al ganador 
            if (posicion1 > posicion2)
            {
                Console.WriteLine("¡GANÓ EL VEHÍCULO 1!");
            }
            else if (posicion2 > posicion1)
            {
                Console.WriteLine("¡GANÓ EL VEHÍCULO 2!");
            }
            else
            {
                Console.WriteLine("¡FUE UN EMPATE!");
            }
        }
    }
}

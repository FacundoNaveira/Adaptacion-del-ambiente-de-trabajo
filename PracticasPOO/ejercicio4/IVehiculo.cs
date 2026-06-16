using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    // El contrato que deben cumplir todos los vehículos 
    public interface IVehiculo
    {
        void Mover(int segundos); // Actualiza la posición 
        int Posicion();           // Devuelve los metros recorridos 
        void ReiniciarPosicion(); // Vuelve el contador a cero 
    }
}

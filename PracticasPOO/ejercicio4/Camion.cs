using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    public class Camion : IVehiculo
    {
        private int posicionActual = 0;
        private int velocidadMaxima = 30; // Fija 

        public void Mover(int segundos)
        {
            posicionActual += velocidadMaxima * segundos;
        }

        public int Posicion()
        {
            return posicionActual;
        }

        public void ReiniciarPosicion()
        {
            posicionActual = 0;
        }
    }
}
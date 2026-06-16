using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    public class Auto : IVehiculo
    {
        private int posicionActual = 0;
        private int velocidadMaxima;

        // Constructor 1: Si lo creás sin pasarle nada, asume 40 m/s 
        public Auto()
        {
            velocidadMaxima = 40;
        }

        // Constructor 2: Si le pasás un número entre paréntesis, usa ese 
        public Auto(int velocidadPersonalizada)
        {
            velocidadMaxima = velocidadPersonalizada;
        }

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
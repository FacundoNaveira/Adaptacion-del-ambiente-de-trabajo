using System;

namespace Ejercicio3
{
    public class Profesional : IJugador
    {
        private int minutosCorridos = 0;
        private bool estaCansado = false;

        public bool Correr(int minutos)
        {
            if (estaCansado) return false; // Un jugador cansado no puede correr 

            minutosCorridos += minutos;

            // Si supera los 40 minutos, se cansa 
            if (minutosCorridos > 40)
            {
                estaCansado = true;
                return false; // No pudo completarlos 
            }

            return true;
        }

        public bool Cansado()
        {
            return estaCansado;
        }

        public void Descansar(int minutos)
        {
            estaCansado = false;
            minutosCorridos = 0; // Se recupera 
        }
    }
}
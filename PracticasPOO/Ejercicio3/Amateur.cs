using System;

namespace Ejercicio3
{
    // Los dos puntos indican que "Amateur" firma el contrato "IJugador"
    public class Amateur : IJugador
    {
        private int minutosCorridos = 0;
        private bool estaCansado = false;

        public bool Correr(int minutos)
        {
            if (estaCansado)
            {
                return false; // Un jugador cansado no puede correr 
            }

            minutosCorridos += minutos;

            // Si supera los 20 minutos en total, se cansa 
            if (minutosCorridos > 20)
            {
                estaCansado = true;
                return false; // No pudo completarlos sin cansarse 
            }

            return true; // Corrió sin problemas 
        }

        public bool Cansado()
        {
            return estaCansado;
        }

        public void Descansar(int minutos)
        {
            estaCansado = false;
            minutosCorridos = 0; // Se recupera completamente 
        }
    }
}
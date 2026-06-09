using System;

namespace Ejercicio1
{
    // 1. EL MOLDE (La Clase)
    public class Semaforo
    {
        // 2. EL ESTADO (Atributos privados - Encapsulamiento)
        private string colorActual;
        private int tiempoEnColorActual;
        private bool modoIntermitente;

        // 3. LA INICIALIZACIÓN (El Constructor)
        public Semaforo(string colorInicial)
        {
            this.colorActual = colorInicial;
            this.tiempoEnColorActual = 0;
            this.modoIntermitente = false;
        }

        // 4. EL COMPORTAMIENTO (Métodos públicos)
        public void MostrarColor()
        {
            if (modoIntermitente)
            {
                if (tiempoEnColorActual % 2 == 0)
                    Console.WriteLine("Intermitente: Amarillo");
                else
                    Console.WriteLine("Intermitente: Apagado");
            }
            else
            {
                Console.WriteLine($"El semáforo está en: {colorActual} (Lleva {tiempoEnColorActual} segundos en este color)");
            }
        }

        public void PonerEnIntermitente()
        {
            modoIntermitente = true;
            tiempoEnColorActual = 0;
        }

        public void SacarDeIntermitente()
        {
            modoIntermitente = false;
            tiempoEnColorActual = 0;
        }

        public void PasoDelTiempo(int segundosQuePasaron)
        {
            for (int i = 0; i < segundosQuePasaron; i++)
            {
                tiempoEnColorActual++;

                if (!modoIntermitente)
                {
                    VerificarSecuencia();
                }
            }
        }

        // 5. MÉTODOS PRIVADOS (Abstracción)
        private void VerificarSecuencia()
        {
            if (colorActual == "Rojo" && tiempoEnColorActual >= 30)
            {
                colorActual = "Rojo + Amarillo";
                tiempoEnColorActual = 0;
            }
            else if (colorActual == "Rojo + Amarillo" && tiempoEnColorActual >= 2)
            {
                colorActual = "Verde";
                tiempoEnColorActual = 0;
            }
            else if (colorActual == "Verde" && tiempoEnColorActual >= 20)
            {
                colorActual = "Amarillo";
                tiempoEnColorActual = 0;
            }
            else if (colorActual == "Amarillo" && tiempoEnColorActual >= 2)
            {
                colorActual = "Rojo";
                tiempoEnColorActual = 0;
            }
        }
    }
}
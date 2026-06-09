using System;

namespace Ejercicio2
{
    public class Cronometro
    {
        // Atributos privados (Encapsulamiento). Nadie desde afuera puede modificarlos directamente.
        private int segundos;
        private int minutos;

        // Constructor: Al crear el objeto, arranca en 0.
        public Cronometro()
        {
            segundos = 0;
            minutos = 0;
        }

        // Método para avanzar 1 segundo.
        public void IncrementarTiempo()
        {
            segundos++;

            // Lógica interna: Si pasa de 59 segundos, suma 1 minuto y reinicia segundos.
            if (segundos > 59)
            {
                minutos++;
                segundos = 0;
            }
        }

        // Método para reiniciar el reloj a cero.
        public void Reiniciar()
        {
            segundos = 0;
            minutos = 0;
        }

        // Método para devolver el texto con el formato pedido.
        public string MostrarTiempo()
        {
            return $"{minutos} minutos, {segundos} segundos";
        }
    }
}
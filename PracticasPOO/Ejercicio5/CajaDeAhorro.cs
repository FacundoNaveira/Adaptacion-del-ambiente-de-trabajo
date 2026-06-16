using System;

namespace Ejercicio5
{
    // Los dos puntos significan que hereda de CuentaBancaria
    public class CajaDeAhorro : CuentaBancaria
    {
        public void Extraer(decimal monto)
        {
            if (monto > saldo)
            {
                Console.WriteLine($"[Error] Fondos insuficientes. Intentaste extraer ${monto} pero solo tenés ${saldo}.");
            }
            else
            {
                saldo -= monto;
                Console.WriteLine($"[Extracción] Sacaste ${monto} de tu Caja de Ahorro.");
            }
        }
    }
}
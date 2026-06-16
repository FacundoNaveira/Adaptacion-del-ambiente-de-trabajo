using System;

namespace Ejercicio5
{
    public class CuentaCorriente : CuentaBancaria
    {
        public void Extraer(decimal monto)
        {
            // A la cuenta corriente no le importa si el saldo queda en menos cero
            saldo -= monto;
            Console.WriteLine($"[Extracción] Sacaste ${monto} de tu Cuenta Corriente. (Permite descubierto)");
        }
    }
}
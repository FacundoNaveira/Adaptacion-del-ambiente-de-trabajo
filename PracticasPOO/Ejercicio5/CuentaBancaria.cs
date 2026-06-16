using System;

namespace Ejercicio5
{
    public class CuentaBancaria
    {
        // Usamos 'protected' en lugar de 'private'. 
        // Esto significa: "Nadie de afuera puede tocar el saldo, EXCEPTO mis clases hijas".
        protected decimal saldo;

        public CuentaBancaria()
        {
            saldo = 0;
        }

        public void Depositar(decimal monto)
        {
            if (monto > 0)
            {
                saldo += monto;
                Console.WriteLine($"[Depósito] Se ingresaron ${monto}.");
            }
        }

        public void MostrarSaldo()
        {
            Console.WriteLine($"[Saldo] Tu saldo actual es: ${saldo}");
        }
    }
}
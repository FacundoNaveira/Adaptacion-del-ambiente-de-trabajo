using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== BANCO: PRUEBA DE CAJA DE AHORRO ===");
            CajaDeAhorro miCaja = new CajaDeAhorro();

            // Fíjate que usamos Depositar y MostrarSaldo, aunque no los escribimos en CajaDeAhorro
            miCaja.Depositar(5000);
            miCaja.MostrarSaldo();

            miCaja.Extraer(2000); // Esto funciona
            miCaja.MostrarSaldo();

            miCaja.Extraer(10000); // Esto va a tirar error de fondos
            miCaja.MostrarSaldo();

            Console.WriteLine("\n=== BANCO: PRUEBA DE CUENTA CORRIENTE ===");
            CuentaCorriente miCuentaCorriente = new CuentaCorriente();

            miCuentaCorriente.Depositar(5000);
            miCuentaCorriente.MostrarSaldo();

            miCuentaCorriente.Extraer(8000); // Esto funciona y deja el saldo en negativo (-3000)
            miCuentaCorriente.MostrarSaldo();

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
namespace Ejercicio6
{
    public class Carta
    {
        // Solo tienen "get", esto las hace inmodificables desde afuera
        public string Palo { get; }
        public int Numero { get; }

        // El constructor asigna los valores por única vez al nacer la carta
        public Carta(string palo, int numero)
        {
            Palo = palo;
            Numero = numero;
        }

        // Un pequeño truco para que al imprimir la carta se lea lindo (ej: "4 de Copas")
        public override string ToString()
        {
            return $"{Numero} de {Palo}";
        }
    }
}
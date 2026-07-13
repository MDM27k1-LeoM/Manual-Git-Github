namespace Calculadora
{
    public class Calculadora
    {
        //  Suma
        public int Sumar(int a, int b) => a + b;

        //  Resta
        public int Restar(int a, int b) => a - b;

        //  Multiplicación
        public int Multiplicar(int a, int b) => a * b;

        //  División
        public double Dividir(int a, int b)
        {
            if (b == 0)
                throw new System.DivideByZeroException("No se puede dividir por cero");
            return (double)a / b;
        }

        // Potencia
        public int Potencia(int baseNum, int exponente)
        {
            if (exponente < 0)
                throw new System.ArgumentException("El exponente no puede ser negativo");
            return (int)System.Math.Pow(baseNum, exponente);
        }

        // Verificar si es par
        public bool EsPar(int numero) => numero % 2 == 0;

        // Factorial
        public int Factorial(int n)
        {
            if (n < 0)
                throw new System.ArgumentException("El número no puede ser negativo");
            if (n == 0 || n == 1) return 1;
            return n * Factorial(n - 1);
        }
    }
}

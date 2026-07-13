using Xunit;

namespace Calculadora.Tests
{
    public class CalculadoraTests
    {
        private readonly Calculadora _calc = new();

        // ========== PRUEBAS DE SUMA ==========
        [Fact]
        public void Sumar_DosNumeros_RetornaSumaCorrecta()
        {
            var resultado = _calc.Sumar(5, 3);
            Assert.Equal(8, resultado);
        }

        // ========== PRUEBAS DE RESTA ==========
        [Theory]
        [InlineData(10, 4, 6)]
        [InlineData(15, 5, 10)]
        [InlineData(0, 0, 0)]
        public void Restar_DiferentesNumeros_RetornaRestaCorrecta(
            int a, int b, int expected)
        {
            var resultado = _calc.Restar(a, b);
            Assert.Equal(expected, resultado);
        }

        // ========== PRUEBAS DE MULTIPLICACIÓN ==========
        [Theory]
        [InlineData(2, 3, 6)]
        [InlineData(4, 5, 20)]
        [InlineData(0, 5, 0)]
        public void Multiplicar_DiferentesNumeros_RetornaMultiplicacionCorrecta(
            int a, int b, int expected)
        {
            var resultado = _calc.Multiplicar(a, b);
            Assert.Equal(expected, resultado);
        }

        // ========== PRUEBAS DE DIVISIÓN ==========
        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(15, 3, 5)]
        [InlineData(7, 2, 3.5)]
        public void Dividir_NumerosValidos_RetornaDivisionCorrecta(
            int a, int b, double expected)
        {
            var resultado = _calc.Dividir(a, b);
            Assert.Equal(expected, resultado, 2);
        }

        [Fact]
        public void Dividir_PorCero_LanzaExcepcion()
        {
            Assert.Throws<System.DivideByZeroException>(
                () => _calc.Dividir(10, 0)
            );
        }

        // ========== PRUEBAS DE POTENCIA ==========
        [Theory]
        [InlineData(2, 3, 8)]
        [InlineData(5, 2, 25)]
        [InlineData(3, 4, 81)]
        public void Potencia_NumerosValidos_RetornaPotenciaCorrecta(
            int baseNum, int exponente, int expected)
        {
            var resultado = _calc.Potencia(baseNum, exponente);
            Assert.Equal(expected, resultado);
        }

        [Fact]
        public void Potencia_ExponenteNegativo_LanzaExcepcion()
        {
            Assert.Throws<System.ArgumentException>(
                () => _calc.Potencia(2, -1)
            );
        }

        // ========== PRUEBAS DE NÚMEROS PARES ==========
        [Theory]
        [InlineData(2, true)]
        [InlineData(3, false)]
        [InlineData(0, true)]
        public void EsPar_DiferentesNumeros_RetornaCorrecto(
            int numero, bool expected)
        {
            var resultado = _calc.EsPar(numero);
            Assert.Equal(expected, resultado);
        }

        // ========== PRUEBAS DE FACTORIAL ==========
        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 1)]
        [InlineData(3, 6)]
        [InlineData(5, 120)]
        public void Factorial_NumerosValidos_RetornaFactorialCorrecto(
            int n, int expected)
        {
            var resultado = _calc.Factorial(n);
            Assert.Equal(expected, resultado);
        }

        [Fact]
        public void Factorial_NumeroNegativo_LanzaExcepcion()
        {
            Assert.Throws<System.ArgumentException>(
                () => _calc.Factorial(-1)
            );
        }
    }
}

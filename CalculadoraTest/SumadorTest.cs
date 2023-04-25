using Calculadora;
using System;
using Xunit;

namespace CalculadoraTest
{
    public class SumadorTest
    {
        [Fact]
        public void Suamdor_ConValoresValidos_ConResultadoValidos()
        {
            // Arrange
            Sumador sumador = new Sumador();
            int resultadoEsperado = 9;

            //Act
            int resultadoReal = sumador.Sumar(5, 4);

            //Assert
            Assert.Equal(resultadoReal, resultadoEsperado);
        }

        [Fact]
        public void Suamdor_ConValoresInvalidos_ConResultadosInvalidos()
        {
            // Arrange
            Sumador sumador = new Sumador();
            int resultadoEsperado = 8;

            //Act
            int resultadoReal = sumador.Sumar(5, 4);

            //Assert
            Assert.Equal(resultadoReal, resultadoEsperado);
        }

        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]
        [InlineData(2, 3, 5)]

        public void Sumador_ConMultiplesValoresValidos_DevuelveSuma(int a, int b, int resultadoEsperado)
        {
            //Arrange
            Sumador sumador = new Sumador();

            //Act
            int resultadoReal = sumador.Sumar(a, b);

            //Assert
            Assert.Equal(resultadoEsperado, resultadoReal);
        }
    }
}

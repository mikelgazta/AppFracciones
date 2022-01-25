using System;
using Xunit;
using AppFracciones;

namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void sumar_un_medio_y_dos_tercios()
        {
            var f1 = new Fraccion(1, 2);
            var f2 = new Fraccion(2, 3);

            var esperado = "7/6";
            var resultado = f1 + f2;

            Assert.Equal(esperado, resultado.ToString());
        }
        [Fact]
        public void multiplicacion()
        {
            // Given
            var f1 = new Fraccion(1, 2);
            var f2 = new Fraccion(2, 4);
            // When
            var esperado = "2/8";
            var resultado = f1 * f2;
            // Then
            Assert.Equal(esperado, resultado.ToString());
        }
        [Fact]
        public void resto()
        {
            // Given
            var f1 = new Fraccion(4, 5);
            var f2 = new Fraccion(2, 3);
            // When
            var esperado = "2/15";
            var resultado = f1 - f2;
            // Then
            Assert.Equal(esperado, resultado.ToString());
        }
        [Fact]
        public void resto_y_resultado_negativo()
        {
            // Given
            var f1 = new Fraccion(3, 5);
            var f2 = new Fraccion(5, 3);
            // When
            var esperado = "-16/15";
            var resultado = f1 - f2;
            // Then
            Assert.Equal(esperado, resultado.ToString());
        }


    }

}

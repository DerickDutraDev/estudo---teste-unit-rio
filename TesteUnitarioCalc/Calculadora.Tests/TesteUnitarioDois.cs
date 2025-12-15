using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Tests
{
    public class TesteUnitarioDois
    {
        [Theory]
        [InlineData(7, 2, 9)]
        [InlineData(-5, 3, -2)]
        [InlineData(0, 0, 0)]
        [InlineData(-10, -5, -15)]

        public void Teste_DeSoma_Com_Varios_Valores(int numA, int numB, int resultadoEsperado)
        {
            //Arrange
            var calculadora = new Calculadora.Core.CalculadoraService();
            
            //Act
            int resultadoAtual = calculadora.Somar(numA, numB);
            
            //Assert
            Assert.Equal(resultadoEsperado, resultadoAtual);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Moq;
using Calculadora.Core;

namespace Calculadora.Tests
{
    public class CalculadoraAvancadaTests
    {
        [Fact]
        public void AplicarTaxa_DeveRetornarValorComTaxaAplicada()
        {
            
            var mockConfiguracaoRepository = new Mock<Calculadora.Core.IConfiguracaoRepository>();
            mockConfiguracaoRepository.Setup(repo => repo.ObterTaxaPadrao()).Returns(15); 
            var calculadoraAvancada = new Calculadora.Core.CalculadoraAvancada(mockConfiguracaoRepository.Object);
            decimal valorOriginal = 100m;
            decimal valorEsperado = 115m; 
           
            decimal valorComTaxa = calculadoraAvancada.AplicarTaxa(valorOriginal);
            
            Assert.Equal(valorEsperado, valorComTaxa);
        }   
    }
}

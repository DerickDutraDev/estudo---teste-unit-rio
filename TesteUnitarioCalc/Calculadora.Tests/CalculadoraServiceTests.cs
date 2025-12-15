using Calculadora.Core;
using static Calculadora.Core.CalculadoraService;

namespace Calculadora.Tests;

public class CalculadoraServiceTests
{
    [Fact]
    public void Teste_DeSomaValores_Numa_NumB()
    {
        //Arrange
        var calculadora = new CalculadoraService();
        int numA = 5;
        int numB = 3;
        int resultadoEsperado = 8;

        //Act
        int resultadoAtual = calculadora.Somar(numA, numB);

        //Assert
        Assert.Equal(resultadoEsperado, resultadoAtual);
    }

    [Fact]
    public void Teste_DeSubtracaoValores_NumA_NumB()
    {
        //Arrange
        var calculadora = new CalculadoraService();
        int numA = 10;
        int numB = 4;
        int resultadoEsperado = 6;
        
        //Act
        int resultadoAtual = calculadora.Subtrair(numA, numB);

        //Assert
        Assert.Equal(resultadoEsperado, resultadoAtual);
    }

    [Fact]
    public void Dividir_PorZero_DeveLancarDivideByZeroException()
    {
        //Arrange
        var calculadora = new CalculadoraService();
        int num = 20;
        int divisor = 0;

        //Act
        var excecao = Assert.Throws<System.DivideByZeroException>(() =>
        {
            calculadora.Dividir(num, divisor);
        });

        //Assert
        Assert.Contains("Não é possível dividir por zero.", excecao.Message);
    }

    [Theory]
    // Cenário 1
    [InlineData(-5, 10, "O primeiro número não pode ser negativo.")]
    // Cenário 2
    [InlineData(10, -5, "O segundo número não pode ser negativo.")]
    public void MultiplicarApenasPositivos_ComNumeroNegativo_DeveLancarNumeroNegativoException(
    int a,
    int b,
    string mensagemEsperada)
    {
        // 1. Arrange
        var calculadora = new CalculadoraService();

        // 2. Act  
        var excecao = Assert.Throws<NumeroNegativoException>(() =>
        {
           
            calculadora.MultiplicarApenasPositivos(a, b);
        });

        //3.Assert
        Assert.Equal(mensagemEsperada, excecao.Message);
    }
}

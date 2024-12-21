using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTests
{
    private CalculadoraImp _cal;
    public CalculadoraTests()
    {
        _cal = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomar5Com10ERetorna15()
    {
        //Arrange
        int num1 = 5;
        int num2 = 10;

        //Act
        int resultado = _cal.Somar(num1, num2);

        //Assert
        Assert.Equal(15, resultado);
    }

    [Fact]
    public void DeveSomar10Com10ERetorna20()
    {
        //Arrange
        int num1 = 10;
        int num2 = 10;

        //Act
        int resultado = _cal.Somar(num1, num2);

        // Assert
        Assert.Equal(20, resultado);
    }

    [Fact]
    public void DeveVerificarSe4EhParERetornarVerdadeiro()
    {
        //Arrange
        int numero = 4;

        //Act
        bool resultado = _cal.EhPar(numero);

        //Assert
        Assert.True(resultado);
    }

    // [Theory]
    // [InlineData(2)]
    // [InlineData(4)]
    // [InlineData(6)]
    // [InlineData(8)]
    // [InlineData(10)]
    // public void DeveVerificarSeNumeroSaoParesERetornarVerdadeiro(int numero)
    // {
    //     //Act
    //     bool resultado = _cal.EhPar(numero);

    //     //Assert
    //     Assert.True(resultado);
    // }

    [Theory]
    [InlineData(new int[] {2, 4})]
    [InlineData(new int [] {6, 8, 10})]
    public void DeveVerificarSeNumeroSaoParesERetornarVerdadeiro(int[] numeros)
    {
        // Act - Assert
        Assert.All(numeros, num => Assert.True(_cal.EhPar(num)));
    }
}
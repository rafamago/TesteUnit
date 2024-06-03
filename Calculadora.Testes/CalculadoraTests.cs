using Calculadora;

namespace Calculadora.Testes;

public class CalculadoraTests
{
    private CalculadoraImp _calc;

    public CalculadoraTests()
    {
        _calc = new CalculadoraImp();
    }


    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        //Arrange - montar o cenario - disponilizar os numeros para somar
        int num1 = 5;
        int num2 = 10;
        //Act - executa a soma
        int resultado = _calc.Somar(num1,num2);
       //Assert  - valida se retornou 15
       //primeiro parametro é o resultado esperado e dps o reusltado que retornoi=u
       Assert.Equal(15, resultado);
    }
    [Fact]
    public void DeveSomar10Com10ERetornar20()
    {
        //Arrange - montar o cenario - disponilizar os numeros para somar
        int num1 = 10;
        int num2 = 10;
        //Act - executa a soma
        int resultado = _calc.Somar(num1,num2);
       //Assert  - valida se retornou 15
       //primeiro parametro é o resultado esperado e dps o reusltado que retornoi=u
       Assert.Equal(20, resultado);
    }
    [Fact]
    public void VerificaSeEParERetornarVerdadeiro()
    {
        //Arrange - montar o cenario - disponilizar os numeros para somar
        int numero = 4;;
        //Act - executa a soma
        bool resultado = _calc.EPar(numero);
       //Assert  - valida se retornou 15
       //primeiro parametro é o resultado esperado e dps o reusltado que retornoi=u
       Assert.true(resultado);
    }
    [Theory]
    //com varios numeros
    [InliteData(2)]
    [InliteData(4)]
    [InliteData(6)]
    [InliteData(8)]
    [InliteData(10)]
    public void VerificaSeSaoParesERetornarVerdadeiro(int numero)
    {
        //Arrange - montar o cenario - disponilizar os numeros para somar
        //Act - executa a soma
        bool resultado = _calc.EPar(numero);
       //Assert  - valida se retornou 15
       //primeiro parametro é o resultado esperado e dps o reusltado que retornoi=u
       Assert.true(resultado);
    }
    [Theory]
    //com array 
    [InliteData(new int[] {2,4})]
    [InliteData(new int[] {6,8,10})]
    public void VerificaSeSaoParesERetornarVerdadeiro(int[] numeros)
    {
       //act/ssert
       //.all valida os elementos da lista, o num represente a variavel que esta percorrendo na lista
       Assert.All(numeros, num => Assert.True(_calc.EPar(num)) )
    }
}
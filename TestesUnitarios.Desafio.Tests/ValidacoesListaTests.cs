using TestesUnitarios.Desafio.Console.Services;
using Xunit; // Adicione este using para o [Fact] funcionar
using System.Collections.Generic; // Adicione este using para o List<>
using System.Linq; // Adicione este using para o .Any() (embora não seja mais necessário, é bom ter)

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesListaTests
{
    private ValidacoesLista _validacoes = new ValidacoesLista();

    [Fact]
    public void DeveRemoverNumerosNegativosDeUmaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var resultadoEsperado = new List<int> { 5, 9 };

        // Act
        var resultado = _validacoes.RemoverNumerosNegativos(lista);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveConterONumero9NaLista()
    {
        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 9;

        // Act
        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterONumero10NaLista()
    {
        // TODO: Implementar método de teste (Resolvido!)

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 10;

        // Act
        // Documentação: Chamamos o método da classe de serviço, assim como no teste "DeveConterONumero9NaLista"
        var resultado = _validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        // Assert
        // Documentação: Afirmamos que o resultado DEVE ser 'false'.
        Assert.False(resultado);
    }

    //TODO: Corrigir a anotação [Fact] (Resolvido!)
    [Fact]
    public void DeveMultiplicarOsElementosDaListaPor2()
    {
        //TODO: Implementar método de teste (Resolvido!)

        // Arrange
        var lista = new List<int> { 5, 7, 8, 9 };
        var resultadoEsperado = new List<int> { 10, 14, 16, 18 };
        
        // Act
        // Documentação: Chamamos o método que multiplica (supus o nome "MultiplicarNumerosLista")
        var resultado = _validacoes.MultiplicarNumerosLista(lista, 2);

        // Assert
        // Documentação: Verificamos se a lista retornada é igual à lista esperada.
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveRetornar9ComoMaiorNumeroDaLista()
    {
        //TODO: Implementar método de teste (Resolvido!)

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };

        // Act
        // Documentação: Chamamos o método que busca o maior número.
        var resultado = _validacoes.RetornarMaiorNumeroLista(lista);

        // Assert
        //TODO: Corrigir o Assert.Equal com base no retorno da chamada ao método (Resolvido!)
        // Documentação: Comparamos o resultado esperado (9) com o resultado obtido.
        Assert.Equal(9, resultado);
    }

    [Fact]
    public void DeveRetornarOitoNegativoComoMenorNumeroDaLista()
    {
        //TODO: Implementar método de teste (Resolvido!)

        // Arrange
        var lista = new List<int> { 5, -1, -8, 9 };

        // Act
        // Documentação: A fase 'Act' já estava correta.
        var resultado = _validacoes.RetornarMenorNumeroLista(lista);

        // Assert
        //TODO: Corrigir o Assert.Equal com base no retorno da chamada ao método (Resolvido!)
        // Documentação: Comparamos o resultado esperado (-8) com o resultado obtido.
        Assert.Equal(-8, resultado);
    }
}
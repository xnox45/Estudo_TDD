using ClassLibrary_TDD;
using System;
using Xunit;
using Xunit.Abstractions;

namespace Estudo_TDD.Tests
{
    public class UnitTest_1
    {
        ITestOutputHelper _output;

        public UnitTest_1(ITestOutputHelper output)
        {
            _output = output;
        }

        int testNum = 2;

        [Fact(Skip = "Skip no teste AAA")]
        public void EstruturaAAA()
        {
            //Arrange - Prepara
            
            int num = 1;
            
            bool esperado = true;
            
            //Act - Faz ação
            
            bool result = num < testNum;

            // Assert - verifica se o retorno da ação está correto

            Assert.True(result);

            Assert.Equal<bool>(esperado, result);
        }

        [Fact]
        public void MaiorDeIdadeSucesso()
        {
            //
            var esperado = true;

            Usuario usuario = new Usuario("Frederick", 20);
            
            //
            bool result = usuario.MaiordeIdade();

            _output.WriteLine("Ouput: "+result.ToString());
           
            //
            Assert.True(result);

            Assert.Equal(esperado, result);
        }
        
        [Fact]
        public void MaiorDeIdadeErro()
        {
            //
            var esperado = false;

            Usuario usuario = new Usuario("Fredinho", 17);
            
            //
            bool result = usuario.MaiordeIdade();
            
            //
            Assert.False(result);

            Assert.Equal(esperado, result);
        }

        [Fact]
        [Trait("Category","Soma")]
        public void TestSums()
        {
            //
            var num1 = 10;
            
            var num2 = 10;

            var expect = 20;
            
            //
            int resultado = num1 + num2;

            //
            Assert.Equal<int>(expect, resultado);
        }

        [Trait("Category", "Soma")]
        [Theory(DisplayName = "Teoria de soma")]//usado para realizar varias teorias de uma vez
        [InlineData(1,1,2)]
        [InlineData(3,4,7)]//Moca um tipo de dado para realizar o teste
        [InlineData(10,4,15)]
        public void InlineTestSoma(int num1, int num2, int expect)
        {
            //
            //
            int result = num1 + num2;

            //
            _output.WriteLine($"N1: {num1}, N2: {num2}, Expect: {expect}");

            Assert.Equal(expect, result);
        }
    }
}

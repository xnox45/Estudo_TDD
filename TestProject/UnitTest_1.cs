using ClassLibrary_TDD;
using System;
using Xunit;

namespace Estudo_TDD.Tests
{
    public class UnitTest_1
    {
        int testNum = 2;

        [Fact]
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
    }
}

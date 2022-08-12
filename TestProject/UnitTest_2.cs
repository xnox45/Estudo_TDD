using ClassLibrary_TDD;
using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;

namespace TestProject
{
    public class UnitTest_2
    {
        ITestOutputHelper _output;

        public UnitTest_2(ITestOutputHelper output)
        {
            _output = output;
        }

        public static IEnumerable<object[]> listaUsuario => new[] {
            new[] {new Usuario {Id = 1, Email = "admin@gmail.com", UserName = "Admin"}},
            new[] {new Usuario {Id = 2, Email = "user1@gmail.com", UserName = "user1"}},
            new[] {new Usuario {Id = 3, Email = "user2@gmail.com", UserName = "user2" } },
            new[] {new Usuario {Id = 4, Email = "user3@gmail.com", UserName = "user3" } },
        };

        [Theory(DisplayName = "campos de usuário são preenchidos")]
        [MemberData(nameof(listaUsuario))]//verificação de listas(Enumerables)
        public void VerificandoUsuarios(Usuario usuario)
        {
            Assert.NotEmpty(usuario.UserName);
 
            Assert.NotEmpty(usuario.Email);

            Assert.IsType<Usuario>(usuario);
        }
    }
}

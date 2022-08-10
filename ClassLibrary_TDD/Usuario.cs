using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_TDD
{
    public class Usuario
    {
        public string Nome { get; set; }

        public int Idade { get; set; }

        public string CPF { get; set; }

        public Usuario()
        {

        }

        public Usuario(string nome, int idade)
        {
            Nome = nome;

            Idade = idade;
        }

        public bool MaiordeIdade()
        {
            return Idade >= 18;
        }
    }
}

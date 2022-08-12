using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_TDD
{
    public class Usuario
    {
        public int Id { get; set; } 
     
        public string Nome { get; set; }
        
        public string UserName { get; set; }
        
        public string Email { get; set; }

        public int Idade { get; set; }

        public string CPF { get; set; }

        public Usuario()
        {

        }

        public Usuario(string nome, int idade, string username = "", string email = "")
        {
            Nome = nome;

            Idade = idade;
            
            UserName = username;

            Email = email;
        }

        public bool MaiordeIdade()
        {
            return Idade >= 18;
        }
    }
}

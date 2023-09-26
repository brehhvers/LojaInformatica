using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaInformatica
{
    internal class Pessoa
    {
        // Encapsulamento
        private string nome;
        private int idade;
        private string cpf;
        private string email;
        



        public string Nome {set{ nome = value; } get { return nome; } }
        public int Idade { set { idade = value; } get { return idade; } }
        public string Cpf { set { cpf = value; } get { return cpf; } }
        public string Email { set { email = value; }get { return email; } }

     
    }
}
    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaInformatica
{
    internal class Colaboradores : Pessoa
    {
        private int idColaborador;
        private string telefone;
        private string endereco;
        private string cargo;
        private double salario;

        public string Telefone { set { telefone = value; } get { return telefone; } }
        public string Endereco { set { endereco = value; } get { return endereco; } }
        public string Cargo { set { cargo = value; } get { return cargo; } }
        public double Salario { set { salario = value; } get { return salario; } }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaInformatica
{
    internal class Fornecedores
    {
        private int idFornecedor;
        private string razao_social;
        private string endereco;
        private string email;
        private string telefone;
        private string cnpj;
        private string inscEstadual;

        public string Razao_social { set { razao_social = value; } get { return razao_social; } }
        public string Endereco { set { endereco = value; } get { return endereco; } }
        public string Email { set { email = value; } get { return email; } }
        public string Telefone { set { telefone = value; } get { return telefone; } }
        public string Cnpj { set { cnpj = value; } get{ return cnpj; } }
        public string InscEstadual { set { inscEstadual = value; }get { return inscEstadual; } }
    }
}

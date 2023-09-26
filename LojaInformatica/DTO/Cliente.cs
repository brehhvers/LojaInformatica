using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaInformatica
{
    internal class Cliente : Pessoa
    {
        private int idCliente;
        private string endereco; 
        
        public string Endereco { set { endereco = value; } get { return endereco; } }


    }
}

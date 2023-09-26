using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaInformatica
{
    internal class Pagamentos
    {
        private int idPagamento;
        private string tipo;

        public string Tipo { set { tipo = value; } get { return tipo; } }
    }
}

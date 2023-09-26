using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaInformatica
{
    internal class Pedidos
    {
        private int idPedido;
        private string idProduto;
        private string idFornecedor;
        private DateTime dataPedido;
        private double precoUnitario;
        private int quantidade;
        private double total;
        private string formaPagamento;

        public string IdProduto { set { idProduto = value; } get { return idProduto; } }
        public string IdFornecedor { set { idFornecedor = value;} get { return idFornecedor;} }
        public DateTime DataPedido { set { dataPedido = value;} get { return dataPedido; } }
        public double PrecoUnitario { set { precoUnitario = value; } get { return precoUnitario; } }
        public int Quantidade { set { quantidade = value; } get { return quantidade;} }
        public double Total { set { total = value;} get { return total; } }
        public string FormaPagamento { set { formaPagamento = value; } get { return formaPagamento; } }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaInformatica
{
    internal class Produtos
    {
        private int idProduto;
        private string descricao;
        private string categoria;
        private double precoCompra;
        private double precoVenda;
        private int qtdEstoque;

        public string Descricao { set { descricao = value; } get { return descricao; } }
        public string Categoria { set { categoria = value; } get { return categoria; } }
        public double PrecoCompra { set { precoCompra = value; } get { return precoCompra; } }
        public double PrecoVenda { set { precoVenda = value;} get { return precoVenda; } }
        public int QtdEstoque { set { qtdEstoque = value; } get { return qtdEstoque; } }
        

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaInformatica
{
    public partial class CadastroPedidos : Form
    {
        public CadastroPedidos()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string produto = cmbProduto.Text;
            string fornecedor = cmbFornecedor.Text;
            DateTime data = dtpDataPedido.Value;
            string pagamento = cmbPagamento.Text;
            double precoUnit = double.Parse(txtPrecoUnit.Text);
            int quantidade = int.Parse(txtQuant.Text);
            double total = double.Parse(txtTotal.Text);

            Pedidos pedido = new Pedidos();
            pedido.IdProduto= produto;
            pedido.IdFornecedor= fornecedor;
            pedido.DataPedido= data;
            pedido.FormaPagamento= pagamento;
            pedido.PrecoUnitario= precoUnit;
            pedido.Quantidade= quantidade;
            pedido.Total= total;

            InserirConexao insert = new InserirConexao();
            insert.InsertPedido(pedido);

            MessageBox.Show("Dados inseridos com sucesso!");

        }

        private void clienteToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            CadastroCliente tela = new CadastroCliente();
            tela.Show();
            this.Hide();
        }

        private void fornecedorToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            CadastroFornecedor tela = new CadastroFornecedor();
            tela.Show();
            this.Hide();
        }

        private void colaboradorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CadastroColaboradores tela = new CadastroColaboradores();
            tela.Show();
            this.Hide();
        }

        private void produtosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CadastroProdutos tela = new CadastroProdutos();
            tela.Show();
            this.Hide();
        }

        private void pedidosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CadastroPedidos tela = new CadastroPedidos();
            tela.Show();
            this.Hide();
        }

        private void pagamentosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CadastroPagamentos tela = new CadastroPagamentos();
            tela.Show();
            this.Hide();
        }

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

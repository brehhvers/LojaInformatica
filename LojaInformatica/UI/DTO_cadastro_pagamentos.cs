using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZstdSharp.Unsafe;
using MySql.Data.MySqlClient;

namespace LojaInformatica
{
    public partial class CadastroPagamentos : Form
    {
        public CadastroPagamentos()
        {
            InitializeComponent();
            LerDados();
        }

        private void LerDados()
        {
            var conexao = FabricaConexao.Conectar();
            string sql = "SELECT * FROM pagamento ORDER BY id_pagamento";
            MySqlDataAdapter adap = new MySqlDataAdapter(sql, conexao);
            DataTable tbPagamentos = new DataTable();
            adap.Fill(tbPagamentos);
            dgvPagamento.DataSource = tbPagamentos;
            dgvPagamento.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
            dgvPagamento.AlternatingRowsDefaultCellStyle.ForeColor = Color.Gray;
            dgvPagamento.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string tipo = txtTipo.Text;

            Pagamentos pagamento = new Pagamentos();
            pagamento.Tipo = tipo;

            InserirConexao insert = new InserirConexao();
            insert.InsertPagamento( pagamento );

            MessageBox.Show("Dados inseridos com sucesso!");

            LerDados();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

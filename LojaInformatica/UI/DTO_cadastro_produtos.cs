﻿using System;
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
    public partial class CadastroProdutos : Form
    {
        public CadastroProdutos()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string descricao = txtDescricao.Text;
            double precoCompra = double.Parse(txtPrecoCompra.Text);
            double precoVenda = double.Parse(txtPrecoVenda.Text);
            string categoria = txtCategoria.Text;
            int qtdEstoque = int.Parse(txtQtdEstoque.Text);

            Produtos produto = new Produtos();
            produto.Descricao = descricao;
            produto.PrecoCompra = precoCompra;
            produto.PrecoVenda = precoVenda;
            produto.Categoria= categoria;
            produto.QtdEstoque= qtdEstoque;

            InserirConexao insert = new InserirConexao();
            insert.InsertProduto(produto);

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
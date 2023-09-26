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
    public partial class CadastroColaboradores : Form
    {
        public CadastroColaboradores()
        {
            InitializeComponent();
        }


        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadastroCliente tela = new CadastroCliente();
            tela.Show();
            this.Hide();

        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string cpf = txtCpf.Text;
            string email = txtEmail.Text;
            string endereco = txtEndereco.Text;
            string cargo = txtCargo.Text;
            double salario = double.Parse(txtSalario.Text);
            string telefone = txtTelefone.Text;

            Colaboradores colaborador = new Colaboradores();
            colaborador.Nome = nome;
            colaborador.Cpf = cpf;
            colaborador.Email = email;
            colaborador.Endereco = endereco;
            colaborador.Cargo = cargo;
            colaborador.Salario = salario;
            colaborador.Telefone = telefone;

            InserirConexao insert = new InserirConexao();
            insert.InsertColaborador(colaborador);

            MessageBox.Show("Dados inseridos com sucesso!");
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LojaInformatica
{
    public partial class CadastroFornecedor : Form
    {
        public CadastroFornecedor()
        {
            InitializeComponent();
            LerDados();
        }

        private void LerDados()
        {
            var conexao = FabricaConexao.Conectar();
            string sql = "SELECT * FROM fornecedor ORDER BY id_fornecedor";
            MySqlDataAdapter adap = new MySqlDataAdapter(sql, conexao);
            DataTable tbFornecedores = new DataTable();
            adap.Fill(tbFornecedores);
            dgvFornecedor.DataSource = tbFornecedores;
            dgvFornecedor.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
            dgvFornecedor.AlternatingRowsDefaultCellStyle.ForeColor = Color.Gray;
            dgvFornecedor.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string razao_social = txtRazaoSocial.Text;
            string cnpj = txtCnpj.Text;
            string insc_estadual = txtInscEstadual.Text;
            string telefone = txtTelefone.Text;
            string email = txtEmail.Text;
            string endereco = txtEndereco.Text;

            Fornecedores fornecedor = new Fornecedores();
            fornecedor.Razao_social = razao_social;
            fornecedor.Cnpj = cnpj;
            fornecedor.InscEstadual = insc_estadual;
            fornecedor.Telefone = telefone;
            fornecedor.Email = email;
            fornecedor.Endereco = endereco;

            InserirConexao insert = new InserirConexao();
            insert.InsertFornecedor(fornecedor);

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
    }
}

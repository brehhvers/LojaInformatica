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
    public partial class CadastroColaboradores : Form
    {
        public CadastroColaboradores()
        {
            InitializeComponent();
            LerDados();
        }

        private void LerDados()
        {
            var conexao = FabricaConexao.Conectar();
            string sql = "SELECT * FROM colaborador ORDER BY id_colaborador";
            MySqlDataAdapter adap = new MySqlDataAdapter(sql, conexao);
            DataTable tbColaboradores = new DataTable();
            adap.Fill(tbColaboradores);
            dgvColaborador.DataSource = tbColaboradores;
            dgvColaborador.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
            dgvColaborador.AlternatingRowsDefaultCellStyle.ForeColor = Color.Gray;
            dgvColaborador.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14);
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

            LerDados();
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

        private void dgvColaborador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgr = dgvColaborador.Rows[e.RowIndex];
            lblId.Text = dgr.Cells[0].Value.ToString();
            txtNome.Text = dgr.Cells[1].Value.ToString();
            txtTelefone.Text = dgr.Cells[7].Value.ToString();
            txtCpf.Text = dgr.Cells[2].Value.ToString();
            txtCargo.Text = dgr.Cells[5].Value.ToString();
            txtSalario.Text = dgr.Cells[6].Value.ToString();
            txtEmail.Text = dgr.Cells[3].Value.ToString();
            txtEndereco.Text = dgr.Cells[4].Value.ToString();
        }
    }
}

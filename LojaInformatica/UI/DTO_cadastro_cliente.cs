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
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
            LerDados();

        }

        private void LerDados()
        {
            var conexao = FabricaConexao.Conectar();
            string sql = "SELECT * FROM cliente ORDER BY id_cliente";  
            MySqlDataAdapter adap = new MySqlDataAdapter(sql, conexao);
            DataTable tbClientes = new DataTable();
            adap.Fill(tbClientes);
            dgvCliente.DataSource = tbClientes;
            dgvCliente.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
            dgvCliente.AlternatingRowsDefaultCellStyle.ForeColor = Color.Gray;
            dgvCliente.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string cpf = txtCpf.Text;
            string email = txtEmail.Text;
            string endereco = txtEndereco.Text;

            Cliente cliente = new Cliente();
            cliente.Nome = nome;
            cliente.Cpf = cpf;
            cliente.Email = email;
            cliente.Endereco = endereco;

            InserirConexao insert = new InserirConexao();
            insert.InsertCliente(cliente);

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

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgr = dgvCliente.Rows[e.RowIndex];
            lblId.Text = dgr.Cells[0].Value.ToString();
            txtNome.Text = dgr.Cells[1].Value.ToString();
            txtCpf.Text = dgr.Cells[2].Value.ToString();
            txtEmail.Text = dgr.Cells[3].Value.ToString();
            txtEndereco.Text = dgr.Cells[4].Value.ToString();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();
            
        }
    }
}

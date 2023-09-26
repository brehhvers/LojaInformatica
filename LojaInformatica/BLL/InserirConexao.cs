using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LojaInformatica
{
    internal class InserirConexao
    {
        // INSERSÃO DE PESSOAS
        // CLIENTE
        public void InsertCliente(Cliente Cli) 
        {
            
            try
            {
                var conexao = FabricaConexao.Conectar();
                var comando = conexao.CreateCommand();
                comando.CommandText = "insert into CLIENTE(nome, cpf, email, endereco) values ('"+Cli.Nome+"', '"+Cli.Cpf+"', '"+Cli.Email+ "', '"+Cli.Endereco+"')";

                comando.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw new Exception("Erro de conexão");
            }
            finally
            {
                FabricaConexao.Conectar().Close();
            }

            
        }

        // COLABORADORES   
        public void InsertColaborador(Colaboradores Col)
        {
            try
            {
                var conexao = FabricaConexao.Conectar();
                var comando = conexao.CreateCommand();
                comando.CommandText = "insert into COLABORADOR(nome, cpf, email, endereco, cargo, salario, telefone) values ('" + Col.Nome + "', '" + Col.Cpf + "', '" + Col.Email + "', '" + Col.Endereco + "','" + Col.Cargo + "', '" + Col.Salario + "', '" + Col.Telefone + "')";

                comando.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw new Exception("Erro de conexão");
            }
            finally
            {
                FabricaConexao.Conectar().Close();
            }
        }

        // FORNECEDORES
        public void InsertFornecedor(Fornecedores For)
        {
            try
            {
                var conexao = FabricaConexao.Conectar();
                var comando = conexao.CreateCommand();
                comando.CommandText = "insert into FORNECEDOR(razao_social, endereco, email, telefone, cnpj, insc_estadual) values ('" + For.Razao_social + "', '" + For.Endereco + "', '" + For.Email + "', '" + For.Telefone + "','" + For.Cnpj + "', '" + For.InscEstadual + "')";

                comando.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw new Exception("Erro de conexão");
            }
            finally
            {
                FabricaConexao.Conectar().Close();
            }
        }

        // INSERSÃO PARA VENDAS
        // PRODUTOS
        public void InsertProduto(Produtos Pro)
        {
            try
            {
                var conexao = FabricaConexao.Conectar();
                var comando = conexao.CreateCommand();
                comando.CommandText = "insert into PRODUTO(descricao, categoria, precoCompra, precoVenda, qtdEstoque) values ('" + Pro.Descricao +"', '" + Pro.Categoria + "', '" + Pro.PrecoCompra + "', '" + Pro.PrecoVenda + "','" + Pro.QtdEstoque + "')";

                comando.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw new Exception("Erro de conexão");
            }
            finally
            {
                FabricaConexao.Conectar().Close();
            }
        }

        // PEDIDOS
        public void InsertPedido(Pedidos Ped)
        {
            try
            {
                var conexao = FabricaConexao.Conectar();
                var comando = conexao.CreateCommand();
                comando.CommandText = "insert into PEDIDO(idProduto, idFornecedor, data_pedido, preco_unitario, quantidade, total, forma_pagamento) values ('" + Ped.IdProduto + "', '" + Ped.IdFornecedor + "', '" + Ped.DataPedido + "', '" + Ped.PrecoUnitario + "','" + Ped.Quantidade + "', '" + Ped.Total + "', '" + Ped.FormaPagamento + "')";

                comando.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw new Exception("Erro de conexão");
            }
            finally
            {
                FabricaConexao.Conectar().Close();
            }
        }

        // PAGAMENTOS
        public void InsertPagamento(Pagamentos Pag)
        {
            try
            {
                var conexao = FabricaConexao.Conectar();
                var comando = conexao.CreateCommand();
                comando.CommandText = "insert into PAGAMENTO(tipo) values ('" + Pag.Tipo + "')";

                comando.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw new Exception("Erro de conexão");
            }
            finally
            {
                FabricaConexao.Conectar().Close();
            }
        }

    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaInformatica
{
    internal class FabricaConexao
    {
         static MySqlConnection conexao = null;

        public static MySqlConnection Conectar()
        {
            string sql = @"Persist Security Info = false;
                            server = localhost;
                            database = lojainformatica;
                            uid = root;
                            pwd =";

            try
            {
                conexao = new MySqlConnection(sql);
                conexao.Open();
                Console.WriteLine("Conectado"); 
            }
            catch (MySqlException)
            {
                throw new Exception("Problemas ao conectar no banco");
            }
            /*catch (Exception ex)
            {
                ex.Message.ToString();
            }*/
            return conexao;
        }

    }
}

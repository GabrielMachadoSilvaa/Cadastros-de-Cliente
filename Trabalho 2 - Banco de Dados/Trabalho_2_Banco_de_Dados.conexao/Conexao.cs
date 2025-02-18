using MySql.Data.MySqlClient;
using System;
using System.Configuration;

namespace Trabalho_2___Banco_de_Dados.Trabalho_2_Banco_de_Dados.conexao
{
    public class Conexao
    {
        private string conexaoString;

        public Conexao()
        {
            conexaoString = ConfigurationManager.ConnectionStrings["ExemploDB"]?.ConnectionString;

            if (string.IsNullOrEmpty(conexaoString))
            {
                throw new Exception("Erro: String de conexão não encontrada no App.config.");
            }
        }

        public static string StringConexao { get; internal set; }

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(conexaoString);
        }

        public void TestarConexao()
        {
            try
            {
                using (MySqlConnection conexao = GetConnection())
                {
                    conexao.Open();
                    Console.WriteLine("Conexão bem-sucedida!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao conectar ao banco: " + ex.Message);
            }
        }
    }
}

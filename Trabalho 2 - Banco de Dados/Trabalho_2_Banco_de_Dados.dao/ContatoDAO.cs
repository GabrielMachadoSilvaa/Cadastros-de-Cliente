using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System;
using Trabalho_2___Banco_de_Dados.Trabalho_2_Banco_de_Dados.model;

public class ContatoDAO
{
    private MySqlConnection Conexao;

    public ContatoDAO()
    {
        string conexaoString = "Server=localhost;Database=ExemploDB;User=root;Password=;";
        Conexao = new MySqlConnection(conexaoString);
    }

    internal void CadastrarCliente(Contato obj)
    {
        try
        {
            string sql = "INSERT INTO Usuarios (Nome, Idade) VALUES (@Nome, @Idade)";
            using (MySqlCommand command = new MySqlCommand(sql, Conexao))
            {
                command.Parameters.AddWithValue("@Nome", obj.Nome);
                command.Parameters.AddWithValue("@Idade", obj.Idade);
                Conexao.Open();
                command.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao cadastrar cliente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            FecharConexao();
        }
    }

    internal DataTable ListarClientes()
    {
        DataTable dataTable = new DataTable();
        try
        {
            string sql = "SELECT ID, Nome, Idade FROM Usuarios";
            using (MySqlCommand command = new MySqlCommand(sql, Conexao))
            {
                Conexao.Open();
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    adapter.Fill(dataTable);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao listar clientes: " + ex.Message);
        }
        finally
        {
            FecharConexao();
        }
        return dataTable;
    }

    public bool AtualizarCliente(int id, string nome, int idade)
    {
        try
        {
            string query = "UPDATE Usuarios SET Nome = @Nome, Idade = @Idade WHERE ID = @ID";
            using (MySqlCommand cmd = new MySqlCommand(query, Conexao))
            {
                cmd.Parameters.AddWithValue("@Nome", nome);
                cmd.Parameters.AddWithValue("@Idade", idade);
                cmd.Parameters.AddWithValue("@ID", id);

                Conexao.Open();
                int linhasAfetadas = cmd.ExecuteNonQuery();
                return linhasAfetadas > 0;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao atualizar cliente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        finally
        {
            FecharConexao();
        }
    }

    public void ExcluirCliente(int idCliente)
    {
        try
        {
            string sql = "DELETE FROM Usuarios WHERE ID = @ID";
            using (MySqlCommand command = new MySqlCommand(sql, Conexao))
            {
                command.Parameters.AddWithValue("@ID", idCliente);
                Conexao.Open();
                int linhasAfetadas = command.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Cliente excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Nenhum cliente encontrado com este ID.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao excluir cliente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            FecharConexao();
        }
    }

    private void FecharConexao()
    {
        if (Conexao.State == ConnectionState.Open)
            Conexao.Close();
    }
}

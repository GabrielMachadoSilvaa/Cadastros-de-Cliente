using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Trabalho_2___Banco_de_Dados.Trabalho_2_Banco_de_Dados.conexao;
using Trabalho_2___Banco_de_Dados.Trabalho_2_Banco_de_Dados.model;

namespace Trabalho_2___Banco_de_Dados
{
    public partial class FormCadastrar : Form
    {
        private List<string> clientes = new List<string>();

        public FormCadastrar()
        {
            InitializeComponent();
        }


        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ttb_idade_TextChanged(object sender, EventArgs e)
        {
            ValidarIdade();
        }


        private void btnEnviar_Click(object sender, EventArgs e)
        {
            AdicionarClienteNaLista();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            TestarConexaoBanco();
        }


        private void btn_enviar1_Click(object sender, EventArgs e)
        {
            CadastrarCliente();
        }


        private void ValidarIdade()
        {
            if (!int.TryParse(ttb_idade.Text, out _))
            {
                ttb_idade.BackColor = Color.LightCoral;
            }
            else
            {
                ttb_idade.BackColor = Color.White;
            }
        }


        private void AdicionarClienteNaLista()
        {
            if (string.IsNullOrWhiteSpace(ttb_nome.Text))
            {
                MessageBox.Show("O campo Nome está vazio. Por favor, preencha-o.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(ttb_idade.Text) || !int.TryParse(ttb_idade.Text, out int idade))
            {
                MessageBox.Show("O campo Idade está vazio ou inválido. Por favor, preencha-o com um número.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string cliente = $"Nome: {ttb_nome.Text} - Idade: {idade}";
            clientes.Add(cliente);

            ttb_nome.Clear();
            ttb_idade.Clear();
        }


        private void TestarConexaoBanco()
        {
            try
            {
                Conexao conexao = new Conexao();
                MySqlConnection conn = conexao.GetConnection();
                conn.Open();

                MessageBox.Show("Conectado ao banco de dados com sucesso!");

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
            }
        }


        private void CadastrarCliente()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ttb_nome.Text))
                {
                    MessageBox.Show("O campo Nome está vazio. Por favor, preencha-o.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(ttb_idade.Text) || !int.TryParse(ttb_idade.Text, out int idade))
                {
                    MessageBox.Show("O campo Idade está vazio ou inválido. Por favor, preencha-o com um número.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Contato obj = new Contato
                {
                    Nome = ttb_nome.Text,
                    Idade = idade
                };

                ContatoDAO dao = new ContatoDAO();
                dao.CadastrarCliente(obj);

                MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ttb_nome.Clear();
                ttb_idade.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar cliente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
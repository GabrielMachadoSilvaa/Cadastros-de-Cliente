using System;

namespace Trabalho_2___Banco_de_Dados.Trabalho_2_Banco_de_Dados.view
{
    internal class FormCadastro
    {
        private int id;
        private string nome;
        private int idade;

        public FormCadastro(int id, string nome, int idade)
        {
            this.id = id;
            this.nome = nome;
            this.idade = idade;
        }


        internal void ShowDialog()
        {
            throw new NotImplementedException();
        }
    }
}

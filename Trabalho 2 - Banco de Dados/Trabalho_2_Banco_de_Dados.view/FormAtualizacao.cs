using System;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Trabalho_2___Banco_de_Dados.Trabalho_2_Banco_de_Dados.view
{
    public partial class FormAtualizacao : Form
    {
        private int linhaLiberada = -1;

        public FormAtualizacao()
        {
            InitializeComponent();
            Load += Form4_Load;
            dgv_atualizar_clientes.SelectionChanged += dgv_atualizar_clientes_SelectionChanged;
            dgv_atualizar_clientes.CellEndEdit += dgv_atualizar_clientes_CellEndEdit;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            CarregarDadosNoDataGridView();
            EstilizarDataGridView();
            BloquearEdicaoDataGridView();
            dgv_atualizar_clientes.CellContentClick += dgv_atualizar_clientes_CellContentClick;
        }

        public void CarregarDadosNoDataGridView()
        {
            try
            {
                ContatoDAO dao = new ContatoDAO();
                DataTable dt = dao.ListarClientes();

                if (dt != null && dt.Rows.Count > 0)
                {
                    dgv_atualizar_clientes.DataSource = dt;
                    foreach (DataGridViewColumn column in dgv_atualizar_clientes.Columns)
                    {
                        column.ReadOnly = true;
                        column.HeaderText = column.HeaderText.ToUpper();
                    }
                }
                else
                {
                    MessageBox.Show("Nenhum cliente cadastrado.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgv_atualizar_clientes.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void EstilizarDataGridView()
        {
            dgv_atualizar_clientes.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgv_atualizar_clientes.GridColor = Color.Goldenrod;
            dgv_atualizar_clientes.BackgroundColor = Color.White;
            dgv_atualizar_clientes.EnableHeadersVisualStyles = false;
            dgv_atualizar_clientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv_atualizar_clientes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv_atualizar_clientes.ColumnHeadersDefaultCellStyle.BackColor = Color.Goldenrod;
            dgv_atualizar_clientes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_atualizar_clientes.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dgv_atualizar_clientes.DefaultCellStyle.Font = new Font("Arial", 12);
            dgv_atualizar_clientes.DefaultCellStyle.BackColor = Color.White;
            dgv_atualizar_clientes.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 235, 205);
            dgv_atualizar_clientes.RowTemplate.Height = 30;
        }

        private void BloquearEdicaoDataGridView()
        {
            foreach (DataGridViewRow row in dgv_atualizar_clientes.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.ReadOnly = true;
                }
            }
        }


        private void LiberarLinhaParaEdicao(int rowIndex)
        {
            foreach (DataGridViewCell cell in dgv_atualizar_clientes.Rows[rowIndex].Cells)
            {
                if (dgv_atualizar_clientes.Columns[cell.ColumnIndex] is DataGridViewTextBoxColumn &&
                    !dgv_atualizar_clientes.Columns[cell.ColumnIndex].Name.Equals("ID", StringComparison.OrdinalIgnoreCase))
                {
                    cell.ReadOnly = false;
                }
            }

            linhaLiberada = rowIndex;
        }


        private void dgv_atualizar_clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgv_atualizar_clientes.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                if (linhaLiberada != -1 && linhaLiberada != e.RowIndex)
                {
                    BloquearEdicaoDataGridView();
                }

                if (linhaLiberada != e.RowIndex)
                {
                    LiberarLinhaParaEdicao(e.RowIndex);
                    MessageBox.Show("Modo de edição ativado para esta linha!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void dgv_atualizar_clientes_SelectionChanged(object sender, EventArgs e)
        {
            if (linhaLiberada != -1 && dgv_atualizar_clientes.CurrentRow != null && dgv_atualizar_clientes.CurrentRow.Index != linhaLiberada)
            {
                BloquearEdicaoDataGridView();
                linhaLiberada = -1;
                MessageBox.Show("Modo de edição desativado!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void dgv_atualizar_clientes_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (linhaLiberada != -1)
            {
                DataGridViewRow row = dgv_atualizar_clientes.Rows[linhaLiberada];
                int id = Convert.ToInt32(row.Cells["ID"].Value);
                string nome = row.Cells["NOME"].Value.ToString().Trim();
                string idadeTexto = row.Cells["IDADE"].Value.ToString().Trim();

                if (nome.Length > 50)
                {
                    MessageBox.Show("O nome não pode ter mais de 50 caracteres.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!Regex.IsMatch(idadeTexto, @"^\d{1,13}$"))
                {
                    MessageBox.Show("A idade deve conter apenas números e ter no máximo 13 dígitos.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int idade = Convert.ToInt32(idadeTexto);
                SalvarEdicaoNoBanco(id, nome, idade);
            }
        }


        private void SalvarEdicaoNoBanco(int id, string nome, int idade)
        {
            try
            {
                ContatoDAO dao = new ContatoDAO();
                dao.AtualizarCliente(id, nome, idade);

                MessageBox.Show("Dados atualizados com sucesso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregarDadosNoDataGridView();
                BloquearEdicaoDataGridView();
                linhaLiberada = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar alterações: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnFechar2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_atualizar_clientes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_atualizar_clientes.Columns[e.ColumnIndex].Name == "atualizar")
                dgv_atualizar_clientes.Rows[e.RowIndex].Cells["atualizar"].ToolTipText = "CLIQUE AQUI PARA EDITAR.";
        }
    }
}
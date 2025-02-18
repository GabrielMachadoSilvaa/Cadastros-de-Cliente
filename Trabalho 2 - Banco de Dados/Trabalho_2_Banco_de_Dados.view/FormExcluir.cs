using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Trabalho_2___Banco_de_Dados
{
    public partial class FormExcluir : Form
    {
        public FormExcluir()
        {
            InitializeComponent();
            this.Load += Form5_Load;
        }


        private void Form5_Load(object sender, EventArgs e)
        {
            EstilizarDataGridView(dvg_excluir);
            CarregarDadosNoDataGridView();
        }


        private void EstilizarDataGridView(DataGridView dgv)
        {
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgv.GridColor = Color.Goldenrod;
            dgv.BackgroundColor = Color.White;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Goldenrod;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dgv.DefaultCellStyle.Font = new Font("Arial", 12);
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 235, 205);
            dgv.RowTemplate.Height = 30;
        }


        public void CarregarDadosNoDataGridView()
        {
            try
            {
                ContatoDAO dao = new ContatoDAO();
                DataTable dt = dao.ListarClientes();
                dvg_excluir.DataSource = dt.Rows.Count > 0 ? dt : null;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhum cliente cadastrado.", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    AtualizarCabecalhoColunas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CARREGAR DADOS: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void AtualizarCabecalhoColunas()
        {
            foreach (DataGridViewColumn column in dvg_excluir.Columns)
            {
                column.HeaderText = column.HeaderText.ToUpper();
            }
        }


        private void btnFechar2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnCarregarexcluir_Click(object sender, EventArgs e)
        {
            CarregarDadosNoDataGridView();
        }


        private void btnexcluir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void dvg_excluir_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dvg_excluir.Columns.Contains("excluir") && dvg_excluir.Columns[e.ColumnIndex].Name == "excluir")
            {
                dvg_excluir.Rows[e.RowIndex].Cells["excluir"].ToolTipText = "CLIQUE AQUI PARA EXCLUIR.";
            }
        }


        private void dvg_excluir_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dvg_excluir.Columns.Contains("excluir") && dvg_excluir.Columns[e.ColumnIndex].Name == "excluir" && e.RowIndex >= 0)
            {
                ExcluirCliente(e.RowIndex);
            }
        }


        private void ExcluirCliente(int rowIndex)
        {
            if (dvg_excluir.Rows[rowIndex].Cells["id"].Value != null && int.TryParse(dvg_excluir.Rows[rowIndex].Cells["id"].Value.ToString(), out int idCliente))
            {
                DialogResult confirmacao = MessageBox.Show("Deseja realmente excluir este cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacao == DialogResult.Yes)
                {
                    ContatoDAO dao = new ContatoDAO();
                    dao.ExcluirCliente(idCliente);
                    CarregarDadosNoDataGridView();
                }
            }
            else
            {
                MessageBox.Show("ID do cliente inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

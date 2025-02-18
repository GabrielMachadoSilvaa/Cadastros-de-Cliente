using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Trabalho_2___Banco_de_Dados
{
    public partial class FormCadastros : Form
    {
        public FormCadastros()
        {
            InitializeComponent();
            this.Load += Form3_Load;
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            EstilizarDataGridView(dgvClientes);
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
                dgvClientes.DataSource = dt.Rows.Count > 0 ? dt : null;

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
            foreach (DataGridViewColumn column in dgvClientes.Columns)
            {
                column.HeaderText = column.HeaderText.ToUpper();
            }
        }


        private void btnCarregarClientes_Click(object sender, EventArgs e)
        {
            CarregarDadosNoDataGridView();
        }

        private void btnFechar3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

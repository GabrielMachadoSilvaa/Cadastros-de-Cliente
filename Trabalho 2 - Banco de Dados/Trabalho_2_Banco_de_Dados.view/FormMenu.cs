using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Trabalho_2___Banco_de_Dados.Trabalho_2_Banco_de_Dados.view;

namespace Trabalho_2___Banco_de_Dados
{
    public partial class FormMenu : Form
    {
        public const int WM_NCLBUTTONWM = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


        public FormMenu()
        {
            InitializeComponent();
        }


        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = true;
        }


        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }


        private void panelCabecalho_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONWM, (IntPtr)HT_CAPTION, IntPtr.Zero);
            }
        }


        private void AbrirFormNoPanel<Forms>() where Forms : Form, new()
        {
            Form formulario = panelConteudo.Controls.OfType<Forms>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new Forms();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelConteudo.Controls.Add(formulario);
                panelConteudo.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                if (formulario.WindowState == FormWindowState.Minimized)
                {
                    formulario.WindowState = FormWindowState.Normal;
                }
                formulario.BringToFront();
            }
        }


        private void btnCadastro_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<FormCadastrar>();
        }


        private void btnConsulta_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<FormCadastros>();

            FormCadastros form3 = panelConteudo.Controls.OfType<FormCadastros>().FirstOrDefault();

            if (form3 == null)
            {
                form3 = new FormCadastros();
                form3.TopLevel = false;
                form3.FormBorderStyle = FormBorderStyle.None;
                form3.Dock = DockStyle.Fill;
                panelConteudo.Controls.Add(form3);
                panelConteudo.Tag = form3;
                form3.Show();
                form3.BringToFront();
            }
            else
            {
                form3.BringToFront();
                form3.CarregarDadosNoDataGridView();
            }
        }


        private void bntAtualizar_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<FormAtualizacao>();

            FormAtualizacao form4 = panelConteudo.Controls.OfType<FormAtualizacao>().FirstOrDefault();

            if (form4 == null)
            {
                form4 = new FormAtualizacao();
                form4.TopLevel = false;
                form4.FormBorderStyle = FormBorderStyle.None;
                form4.Dock = DockStyle.Fill;
                panelConteudo.Controls.Add(form4);
                panelConteudo.Tag = form4;
                form4.Show();
                form4.BringToFront();
            }
            else
            {
                form4.BringToFront();
                form4.CarregarDadosNoDataGridView();
            }
        }


        private void bntExcluir_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<FormExcluir>();

            FormExcluir form5 = panelConteudo.Controls.OfType<FormExcluir>().FirstOrDefault();

            if (form5 == null)
            {
                form5 = new FormExcluir();
                form5.TopLevel = false;
                form5.FormBorderStyle = FormBorderStyle.None;
                form5.Dock = DockStyle.Fill;
                panelConteudo.Controls.Add(form5);
                panelConteudo.Tag = form5;
                form5.Show();
                form5.BringToFront();
            }
            else
            {
                form5.BringToFront();
                form5.CarregarDadosNoDataGridView();
            }
        }
    }
}

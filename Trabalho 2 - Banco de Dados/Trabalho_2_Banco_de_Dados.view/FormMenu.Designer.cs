namespace Trabalho_2___Banco_de_Dados
{
    partial class FormMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.lbl_cabecalho = new System.Windows.Forms.Label();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.pnl_botoes = new System.Windows.Forms.Panel();
            this.bntExcluir = new System.Windows.Forms.Button();
            this.bntAtualizar = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.panelConteudo = new System.Windows.Forms.Panel();
            this.panelCabecalho.SuspendLayout();
            this.pnl_botoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.BackColor = System.Drawing.Color.Goldenrod;
            this.panelCabecalho.Controls.Add(this.lbl_cabecalho);
            this.panelCabecalho.Controls.Add(this.btnRestaurar);
            this.panelCabecalho.Controls.Add(this.btnMaximizar);
            this.panelCabecalho.Controls.Add(this.btnFechar);
            this.panelCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecalho.Location = new System.Drawing.Point(0, 0);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(900, 59);
            this.panelCabecalho.TabIndex = 0;
            // 
            // lbl_cabecalho
            // 
            this.lbl_cabecalho.AutoSize = true;
            this.lbl_cabecalho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_cabecalho.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cabecalho.ForeColor = System.Drawing.Color.White;
            this.lbl_cabecalho.Location = new System.Drawing.Point(12, 9);
            this.lbl_cabecalho.Name = "lbl_cabecalho";
            this.lbl_cabecalho.Size = new System.Drawing.Size(337, 39);
            this.lbl_cabecalho.TabIndex = 3;
            this.lbl_cabecalho.Text = "Criação de Cadastros";
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRestaurar.FlatAppearance.BorderSize = 0;
            this.btnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.Image = global::Trabalho_2___Banco_de_Dados.Properties.Resources.minimaxi;
            this.btnRestaurar.Location = new System.Drawing.Point(743, 12);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(43, 43);
            this.btnRestaurar.TabIndex = 2;
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Image = global::Trabalho_2___Banco_de_Dados.Properties.Resources.Fullscreen;
            this.btnMaximizar.Location = new System.Drawing.Point(792, 12);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(50, 43);
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = global::Trabalho_2___Banco_de_Dados.Properties.Resources.close_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            this.btnFechar.Location = new System.Drawing.Point(848, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(43, 43);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // pnl_botoes
            // 
            this.pnl_botoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.pnl_botoes.Controls.Add(this.bntExcluir);
            this.pnl_botoes.Controls.Add(this.bntAtualizar);
            this.pnl_botoes.Controls.Add(this.btnConsulta);
            this.pnl_botoes.Controls.Add(this.btnCadastro);
            this.pnl_botoes.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_botoes.Location = new System.Drawing.Point(0, 59);
            this.pnl_botoes.Name = "pnl_botoes";
            this.pnl_botoes.Size = new System.Drawing.Size(259, 541);
            this.pnl_botoes.TabIndex = 1;
            // 
            // bntExcluir
            // 
            this.bntExcluir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bntExcluir.FlatAppearance.BorderSize = 0;
            this.bntExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bntExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.bntExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntExcluir.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntExcluir.ForeColor = System.Drawing.Color.White;
            this.bntExcluir.Image = global::Trabalho_2___Banco_de_Dados.Properties.Resources.delete;
            this.bntExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntExcluir.Location = new System.Drawing.Point(0, 297);
            this.bntExcluir.Name = "bntExcluir";
            this.bntExcluir.Size = new System.Drawing.Size(256, 44);
            this.bntExcluir.TabIndex = 3;
            this.bntExcluir.Text = "       Excluir Cadastro";
            this.bntExcluir.UseVisualStyleBackColor = true;
            this.bntExcluir.Click += new System.EventHandler(this.bntExcluir_Click);
            // 
            // bntAtualizar
            // 
            this.bntAtualizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bntAtualizar.FlatAppearance.BorderSize = 0;
            this.bntAtualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.bntAtualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.bntAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntAtualizar.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntAtualizar.ForeColor = System.Drawing.Color.White;
            this.bntAtualizar.Image = global::Trabalho_2___Banco_de_Dados.Properties.Resources.updade;
            this.bntAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntAtualizar.Location = new System.Drawing.Point(0, 214);
            this.bntAtualizar.Name = "bntAtualizar";
            this.bntAtualizar.Size = new System.Drawing.Size(259, 50);
            this.bntAtualizar.TabIndex = 2;
            this.bntAtualizar.Text = "          Atualizar Cadastro";
            this.bntAtualizar.UseVisualStyleBackColor = true;
            this.bntAtualizar.Click += new System.EventHandler(this.bntAtualizar_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConsulta.FlatAppearance.BorderSize = 0;
            this.btnConsulta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.ForeColor = System.Drawing.Color.White;
            this.btnConsulta.Image = global::Trabalho_2___Banco_de_Dados.Properties.Resources.OIST;
            this.btnConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta.Location = new System.Drawing.Point(3, 146);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(286, 44);
            this.btnConsulta.TabIndex = 1;
            this.btnConsulta.Text = "      Consulta  Cadastro";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btnCadastro.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastro.FlatAppearance.BorderSize = 0;
            this.btnCadastro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastro.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.btnCadastro.ForeColor = System.Drawing.Color.White;
            this.btnCadastro.Image = global::Trabalho_2___Banco_de_Dados.Properties.Resources.grup;
            this.btnCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastro.Location = new System.Drawing.Point(3, 77);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(256, 44);
            this.btnCadastro.TabIndex = 0;
            this.btnCadastro.Text = "           Cadastro";
            this.btnCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastro.UseVisualStyleBackColor = false;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // panelConteudo
            // 
            this.panelConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConteudo.Location = new System.Drawing.Point(259, 59);
            this.panelConteudo.Name = "panelConteudo";
            this.panelConteudo.Size = new System.Drawing.Size(641, 541);
            this.panelConteudo.TabIndex = 2;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.panelConteudo);
            this.Controls.Add(this.pnl_botoes);
            this.Controls.Add(this.panelCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.panelCabecalho.ResumeLayout(false);
            this.panelCabecalho.PerformLayout();
            this.pnl_botoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCabecalho;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Label lbl_cabecalho;
        private System.Windows.Forms.Panel pnl_botoes;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button bntAtualizar;
        private System.Windows.Forms.Button bntExcluir;
        private System.Windows.Forms.Panel panelConteudo;
    }
}


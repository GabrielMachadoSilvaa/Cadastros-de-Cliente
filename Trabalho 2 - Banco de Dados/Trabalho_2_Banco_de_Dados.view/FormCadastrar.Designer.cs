namespace Trabalho_2___Banco_de_Dados
{
    partial class FormCadastrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnl_cadastro_cliente = new System.Windows.Forms.Panel();
            this.lbl_cabecalho2 = new System.Windows.Forms.Label();
            this.btnFechar2 = new System.Windows.Forms.Button();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.ttb_nome = new System.Windows.Forms.TextBox();
            this.lbl_idade = new System.Windows.Forms.Label();
            this.ttb_idade = new System.Windows.Forms.TextBox();
            this.btn_cadastar = new System.Windows.Forms.Button();
            this.ttp_id = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pnl_cadastro_cliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_cadastro_cliente
            // 
            this.pnl_cadastro_cliente.BackColor = System.Drawing.Color.Goldenrod;
            this.pnl_cadastro_cliente.Controls.Add(this.lbl_cabecalho2);
            this.pnl_cadastro_cliente.Controls.Add(this.btnFechar2);
            this.pnl_cadastro_cliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_cadastro_cliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.pnl_cadastro_cliente.Location = new System.Drawing.Point(0, 0);
            this.pnl_cadastro_cliente.Name = "pnl_cadastro_cliente";
            this.pnl_cadastro_cliente.Size = new System.Drawing.Size(374, 51);
            this.pnl_cadastro_cliente.TabIndex = 0;
            // 
            // lbl_cabecalho2
            // 
            this.lbl_cabecalho2.AutoSize = true;
            this.lbl_cabecalho2.Font = new System.Drawing.Font("Arial", 18.25F, System.Drawing.FontStyle.Bold);
            this.lbl_cabecalho2.ForeColor = System.Drawing.Color.White;
            this.lbl_cabecalho2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_cabecalho2.Location = new System.Drawing.Point(12, 9);
            this.lbl_cabecalho2.Name = "lbl_cabecalho2";
            this.lbl_cabecalho2.Size = new System.Drawing.Size(261, 30);
            this.lbl_cabecalho2.TabIndex = 2;
            this.lbl_cabecalho2.Text = "Cadastro de Clientes";
            this.lbl_cabecalho2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnFechar2
            // 
            this.btnFechar2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFechar2.FlatAppearance.BorderSize = 0;
            this.btnFechar2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFechar2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar2.Image = global::Trabalho_2___Banco_de_Dados.Properties.Resources.close_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            this.btnFechar2.Location = new System.Drawing.Point(323, 5);
            this.btnFechar2.Name = "btnFechar2";
            this.btnFechar2.Size = new System.Drawing.Size(43, 43);
            this.btnFechar2.TabIndex = 1;
            this.btnFechar2.UseVisualStyleBackColor = true;
            this.btnFechar2.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lbl_nome
            // 
            this.lbl_nome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_nome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_nome.Location = new System.Drawing.Point(12, 98);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(67, 20);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome :";
            // 
            // ttb_nome
            // 
            this.ttb_nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ttb_nome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttb_nome.Location = new System.Drawing.Point(86, 97);
            this.ttb_nome.Name = "ttb_nome";
            this.ttb_nome.Size = new System.Drawing.Size(276, 26);
            this.ttb_nome.TabIndex = 1;
            this.ttb_nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_idade
            // 
            this.lbl_idade.AutoSize = true;
            this.lbl_idade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_idade.Location = new System.Drawing.Point(14, 166);
            this.lbl_idade.Name = "lbl_idade";
            this.lbl_idade.Size = new System.Drawing.Size(61, 19);
            this.lbl_idade.TabIndex = 2;
            this.lbl_idade.Text = "Idade :";
            // 
            // ttb_idade
            // 
            this.ttb_idade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ttb_idade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.ttb_idade.Location = new System.Drawing.Point(86, 164);
            this.ttb_idade.Name = "ttb_idade";
            this.ttb_idade.Size = new System.Drawing.Size(276, 26);
            this.ttb_idade.TabIndex = 3;
            this.ttb_idade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ttb_idade.TextChanged += new System.EventHandler(this.ttb_idade_TextChanged);
            // 
            // btn_cadastar
            // 
            this.btn_cadastar.BackColor = System.Drawing.Color.Goldenrod;
            this.btn_cadastar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_cadastar.FlatAppearance.BorderSize = 0;
            this.btn_cadastar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_cadastar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btn_cadastar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastar.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.btn_cadastar.ForeColor = System.Drawing.Color.White;
            this.btn_cadastar.Location = new System.Drawing.Point(164, 256);
            this.btn_cadastar.Name = "btn_cadastar";
            this.btn_cadastar.Size = new System.Drawing.Size(123, 32);
            this.btn_cadastar.TabIndex = 4;
            this.btn_cadastar.Text = "Cadastrar";
            this.btn_cadastar.UseVisualStyleBackColor = false;
            this.btn_cadastar.Click += new System.EventHandler(this.btn_enviar1_Click);
            // 
            // ttp_id
            // 
            this.ttp_id.BackColor = System.Drawing.Color.Goldenrod;
            this.ttp_id.ForeColor = System.Drawing.Color.Ivory;
            this.ttp_id.Tag = "Gere sua id primeiro!";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 450);
            this.Controls.Add(this.btn_cadastar);
            this.Controls.Add(this.ttb_idade);
            this.Controls.Add(this.lbl_idade);
            this.Controls.Add(this.ttb_nome);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.pnl_cadastro_cliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "caca";
            //this.Load += new System.EventHandler(this.Form2_Load_1);
            this.pnl_cadastro_cliente.ResumeLayout(false);
            this.pnl_cadastro_cliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_cadastro_cliente;
        private System.Windows.Forms.Button btnFechar2;
        private System.Windows.Forms.Label lbl_cabecalho2;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox ttb_nome;
        private System.Windows.Forms.Label lbl_idade;
        private System.Windows.Forms.TextBox ttb_idade;
        private System.Windows.Forms.Button btn_cadastar;
        private System.Windows.Forms.ToolTip ttp_id;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
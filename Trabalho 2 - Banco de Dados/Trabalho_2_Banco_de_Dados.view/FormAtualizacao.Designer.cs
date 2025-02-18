namespace Trabalho_2___Banco_de_Dados.Trabalho_2_Banco_de_Dados.view
{
    partial class FormAtualizacao
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
            this.pnl_atualizar_cliente = new System.Windows.Forms.Panel();
            this.lbl_atualizar_cliente = new System.Windows.Forms.Label();
            this.btnFechar2 = new System.Windows.Forms.Button();
            this.dgv_atualizar_clientes = new System.Windows.Forms.DataGridView();
            this.atualizar = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnl_atualizar_cliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_atualizar_clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_atualizar_cliente
            // 
            this.pnl_atualizar_cliente.BackColor = System.Drawing.Color.Goldenrod;
            this.pnl_atualizar_cliente.Controls.Add(this.lbl_atualizar_cliente);
            this.pnl_atualizar_cliente.Controls.Add(this.btnFechar2);
            this.pnl_atualizar_cliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_atualizar_cliente.Location = new System.Drawing.Point(0, 0);
            this.pnl_atualizar_cliente.Name = "pnl_atualizar_cliente";
            this.pnl_atualizar_cliente.Size = new System.Drawing.Size(436, 51);
            this.pnl_atualizar_cliente.TabIndex = 0;
            // 
            // lbl_atualizar_cliente
            // 
            this.lbl_atualizar_cliente.AutoSize = true;
            this.lbl_atualizar_cliente.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_atualizar_cliente.ForeColor = System.Drawing.Color.White;
            this.lbl_atualizar_cliente.Location = new System.Drawing.Point(12, 12);
            this.lbl_atualizar_cliente.Name = "lbl_atualizar_cliente";
            this.lbl_atualizar_cliente.Size = new System.Drawing.Size(236, 26);
            this.lbl_atualizar_cliente.TabIndex = 3;
            this.lbl_atualizar_cliente.Text = "Atualização de Cliente";
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
            this.btnFechar2.Location = new System.Drawing.Point(385, 5);
            this.btnFechar2.Name = "btnFechar2";
            this.btnFechar2.Size = new System.Drawing.Size(43, 43);
            this.btnFechar2.TabIndex = 2;
            this.btnFechar2.UseVisualStyleBackColor = true;
            this.btnFechar2.Click += new System.EventHandler(this.btnFechar2_Click);
            // 
            // dgv_atualizar_clientes
            // 
            this.dgv_atualizar_clientes.AllowUserToAddRows = false;
            this.dgv_atualizar_clientes.AllowUserToDeleteRows = false;
            this.dgv_atualizar_clientes.BackgroundColor = System.Drawing.Color.White;
            this.dgv_atualizar_clientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_atualizar_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_atualizar_clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.atualizar});
            this.dgv_atualizar_clientes.GridColor = System.Drawing.Color.Silver;
            this.dgv_atualizar_clientes.Location = new System.Drawing.Point(15, 57);
            this.dgv_atualizar_clientes.Name = "dgv_atualizar_clientes";
            this.dgv_atualizar_clientes.RowHeadersWidth = 4;
            this.dgv_atualizar_clientes.Size = new System.Drawing.Size(358, 343);
            this.dgv_atualizar_clientes.TabIndex = 1;
            this.dgv_atualizar_clientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_atualizar_clientes_CellContentClick);
            this.dgv_atualizar_clientes.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_atualizar_clientes_CellEndEdit);
            this.dgv_atualizar_clientes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_atualizar_clientes_CellFormatting);
            // 
            // atualizar
            // 
            this.atualizar.HeaderText = "";
            this.atualizar.Image = global::Trabalho_2___Banco_de_Dados.Properties.Resources.editar;
            this.atualizar.Name = "atualizar";
            this.atualizar.ReadOnly = true;
            this.atualizar.ToolTipText = "Clique aqui para atualizar!";
            this.atualizar.Width = 30;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Column1";
            this.dataGridViewImageColumn1.Image = global::Trabalho_2___Banco_de_Dados.Properties.Resources.edit_square_16dp_FFFF55_FILL0_wght400_GRAD0_opsz20;
            this.dataGridViewImageColumn1.MinimumWidth = 100;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ToolTipText = "Clique aqui para atualizar!";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 485);
            this.Controls.Add(this.dgv_atualizar_clientes);
            this.Controls.Add(this.pnl_atualizar_cliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.Text = "Form4";
            this.pnl_atualizar_cliente.ResumeLayout(false);
            this.pnl_atualizar_cliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_atualizar_clientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_atualizar_cliente;
        private System.Windows.Forms.Button btnFechar2;
        private System.Windows.Forms.Label lbl_atualizar_cliente;
        private System.Windows.Forms.DataGridView dgv_atualizar_clientes;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn atualizar;
    }
}
namespace Trabalho_2___Banco_de_Dados
{
    partial class FormExcluir
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
            this.pnlexcluir = new System.Windows.Forms.Panel();
            this.lbl_excluir = new System.Windows.Forms.Label();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.dvg_excluir = new System.Windows.Forms.DataGridView();
            this.excluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlexcluir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_excluir)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlexcluir
            // 
            this.pnlexcluir.BackColor = System.Drawing.Color.Goldenrod;
            this.pnlexcluir.Controls.Add(this.lbl_excluir);
            this.pnlexcluir.Controls.Add(this.btnexcluir);
            this.pnlexcluir.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlexcluir.Location = new System.Drawing.Point(0, 0);
            this.pnlexcluir.Name = "pnlexcluir";
            this.pnlexcluir.Size = new System.Drawing.Size(436, 51);
            this.pnlexcluir.TabIndex = 0;
            // 
            // lbl_excluir
            // 
            this.lbl_excluir.AutoSize = true;
            this.lbl_excluir.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_excluir.ForeColor = System.Drawing.Color.White;
            this.lbl_excluir.Location = new System.Drawing.Point(12, 12);
            this.lbl_excluir.Name = "lbl_excluir";
            this.lbl_excluir.Size = new System.Drawing.Size(181, 26);
            this.lbl_excluir.TabIndex = 4;
            this.lbl_excluir.Text = "Excluir Cadastro";
            // 
            // btnexcluir
            // 
            this.btnexcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnexcluir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnexcluir.FlatAppearance.BorderSize = 0;
            this.btnexcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnexcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnexcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexcluir.Image = global::Trabalho_2___Banco_de_Dados.Properties.Resources.close_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            this.btnexcluir.Location = new System.Drawing.Point(385, 5);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(43, 43);
            this.btnexcluir.TabIndex = 3;
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // dvg_excluir
            // 
            this.dvg_excluir.AllowUserToAddRows = false;
            this.dvg_excluir.BackgroundColor = System.Drawing.Color.White;
            this.dvg_excluir.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvg_excluir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_excluir.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.excluir});
            this.dvg_excluir.GridColor = System.Drawing.Color.Silver;
            this.dvg_excluir.Location = new System.Drawing.Point(15, 57);
            this.dvg_excluir.Name = "dvg_excluir";
            this.dvg_excluir.ReadOnly = true;
            this.dvg_excluir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dvg_excluir.RowHeadersWidth = 4;
            this.dvg_excluir.Size = new System.Drawing.Size(358, 343);
            this.dvg_excluir.TabIndex = 1;
            this.dvg_excluir.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_excluir_CellContentClick);
            this.dvg_excluir.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dvg_excluir_CellFormatting);
            // 
            // excluir
            // 
            this.excluir.Description = "Clique aqui para excluir!";
            this.excluir.HeaderText = "";
            this.excluir.Image = global::Trabalho_2___Banco_de_Dados.Properties.Resources.excluir;
            this.excluir.Name = "excluir";
            this.excluir.ReadOnly = true;
            this.excluir.ToolTipText = "Clique aqui para excluir!";
            this.excluir.Width = 30;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Trabalho_2___Banco_de_Dados.Properties.Resources.excluir;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 30;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 485);
            this.Controls.Add(this.dvg_excluir);
            this.Controls.Add(this.pnlexcluir);
            this.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            //this.Load += new System.EventHandler(this.Form5_Load_1);
            this.pnlexcluir.ResumeLayout(false);
            this.pnlexcluir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_excluir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlexcluir;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Label lbl_excluir;
        private System.Windows.Forms.DataGridView dvg_excluir;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn excluir;
    }
}
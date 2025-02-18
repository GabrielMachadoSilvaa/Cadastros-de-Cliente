namespace Trabalho_2___Banco_de_Dados
{
    partial class FormCadastros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastros));
            this.pnl_consulta = new System.Windows.Forms.Panel();
            this.btnFechar3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.btnCarregarClientes = new System.Windows.Forms.Button();
            this.pnl_consulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_consulta
            // 
            this.pnl_consulta.BackColor = System.Drawing.Color.Goldenrod;
            this.pnl_consulta.Controls.Add(this.btnFechar3);
            this.pnl_consulta.Controls.Add(this.label1);
            resources.ApplyResources(this.pnl_consulta, "pnl_consulta");
            this.pnl_consulta.Name = "pnl_consulta";
            // 
            // btnFechar3
            // 
            resources.ApplyResources(this.btnFechar3, "btnFechar3");
            this.btnFechar3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFechar3.FlatAppearance.BorderSize = 0;
            this.btnFechar3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFechar3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar3.Image = global::Trabalho_2___Banco_de_Dados.Properties.Resources.close_16dp_E8EAED_FILL0_wght400_GRAD0_opsz20;
            this.btnFechar3.Name = "btnFechar3";
            this.btnFechar3.UseVisualStyleBackColor = true;
            this.btnFechar3.Click += new System.EventHandler(this.btnFechar3_Click_1);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToResizeColumns = false;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.White;
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvClientes, "dgvClientes");
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            //this.dgvClientes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvClientes_CellFormatting);
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // btnCarregarClientes
            // 
            this.btnCarregarClientes.BackColor = System.Drawing.Color.White;
            this.btnCarregarClientes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCarregarClientes.FlatAppearance.BorderSize = 0;
            this.btnCarregarClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCarregarClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            resources.ApplyResources(this.btnCarregarClientes, "btnCarregarClientes");
            this.btnCarregarClientes.ForeColor = System.Drawing.Color.White;
            this.btnCarregarClientes.Name = "btnCarregarClientes";
            this.btnCarregarClientes.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCarregarClientes);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.pnl_consulta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.pnl_consulta.ResumeLayout(false);
            this.pnl_consulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_consulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnFechar3;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.Button btnCarregarClientes;
    }
}
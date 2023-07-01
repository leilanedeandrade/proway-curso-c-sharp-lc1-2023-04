﻿namespace WindowsFormsExemplos.Forms.Clientes
{
    partial class ListagemClienteForm
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
            dataGridView1 = new DataGridView();
            ColunmCodigo = new DataGridViewTextBoxColumn();
            ColumnNome = new DataGridViewTextBoxColumn();
            ColumnCPF = new DataGridViewTextBoxColumn();
            Cadastrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColunmCodigo, ColumnNome, ColumnCPF });
            dataGridView1.Location = new Point(12, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(433, 185);
            dataGridView1.TabIndex = 0;
            // 
            // ColunmCodigo
            // 
            ColunmCodigo.HeaderText = "Código";
            ColunmCodigo.MinimumWidth = 6;
            ColunmCodigo.Name = "ColunmCodigo";
            ColunmCodigo.ReadOnly = true;
            ColunmCodigo.Width = 125;
            // 
            // ColumnNome
            // 
            ColumnNome.HeaderText = "Nome";
            ColumnNome.MinimumWidth = 6;
            ColumnNome.Name = "ColumnNome";
            ColumnNome.ReadOnly = true;
            ColumnNome.Width = 125;
            // 
            // ColumnCPF
            // 
            ColumnCPF.HeaderText = "CPF";
            ColumnCPF.MinimumWidth = 6;
            ColumnCPF.Name = "ColumnCPF";
            ColumnCPF.ReadOnly = true;
            ColumnCPF.Width = 125;
            // 
            // Cadastrar
            // 
            Cadastrar.Location = new Point(351, 6);
            Cadastrar.Name = "Cadastrar";
            Cadastrar.Size = new Size(94, 29);
            Cadastrar.TabIndex = 1;
            Cadastrar.Text = "Cadastrar";
            Cadastrar.UseVisualStyleBackColor = true;
            Cadastrar.Click += Cadastrar_Click;
            // 
            // ListagemClienteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 288);
            Controls.Add(Cadastrar);
            Controls.Add(dataGridView1);
            Name = "ListagemClienteForm";
            Text = "ListagemClienteForm";
            Load += ListagemClienteForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColunmCodigo;
        private DataGridViewTextBoxColumn ColumnNome;
        private DataGridViewTextBoxColumn ColumnCPF;
        public Button Cadastrar;
        private Button button1;
    }
}
namespace Elevator
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.INTERNO = new System.Windows.Forms.DataGridView();
            this.COLUNA_INTERNA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ELEVADOR = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SOBE = new System.Windows.Forms.DataGridView();
            this.SOBE_EXTERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCE = new System.Windows.Forms.DataGridView();
            this.DESCE_EXTERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.INTERVALO = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.INTERNO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ELEVADOR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SOBE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DESCE)).BeginInit();
            this.SuspendLayout();
            // 
            // INTERNO
            // 
            this.INTERNO.AllowUserToAddRows = false;
            this.INTERNO.AllowUserToDeleteRows = false;
            this.INTERNO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.INTERNO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COLUNA_INTERNA});
            this.INTERNO.Location = new System.Drawing.Point(45, 115);
            this.INTERNO.Name = "INTERNO";
            this.INTERNO.ReadOnly = true;
            this.INTERNO.RowHeadersVisible = false;
            this.INTERNO.RowHeadersWidth = 40;
            this.INTERNO.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.INTERNO.RowTemplate.Height = 24;
            this.INTERNO.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.INTERNO.Size = new System.Drawing.Size(108, 445);
            this.INTERNO.TabIndex = 0;
            this.INTERNO.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.INTERNO_CellClick);
            // 
            // COLUNA_INTERNA
            // 
            this.COLUNA_INTERNA.HeaderText = "";
            this.COLUNA_INTERNA.MaxInputLength = 1;
            this.COLUNA_INTERNA.Name = "COLUNA_INTERNA";
            this.COLUNA_INTERNA.ReadOnly = true;
            this.COLUNA_INTERNA.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.COLUNA_INTERNA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.COLUNA_INTERNA.Width = 40;
            // 
            // ELEVADOR
            // 
            this.ELEVADOR.AllowUserToAddRows = false;
            this.ELEVADOR.AllowUserToDeleteRows = false;
            this.ELEVADOR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ELEVADOR.ColumnHeadersVisible = false;
            this.ELEVADOR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.ELEVADOR.Location = new System.Drawing.Point(190, 115);
            this.ELEVADOR.Name = "ELEVADOR";
            this.ELEVADOR.ReadOnly = true;
            this.ELEVADOR.RowHeadersVisible = false;
            this.ELEVADOR.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ELEVADOR.Size = new System.Drawing.Size(100, 445);
            this.ELEVADOR.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.NullValue = false;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // SOBE
            // 
            this.SOBE.AllowUserToAddRows = false;
            this.SOBE.AllowUserToDeleteRows = false;
            this.SOBE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SOBE.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SOBE_EXTERNO});
            this.SOBE.Location = new System.Drawing.Point(344, 115);
            this.SOBE.Name = "SOBE";
            this.SOBE.ReadOnly = true;
            this.SOBE.RowHeadersVisible = false;
            this.SOBE.RowHeadersWidth = 40;
            this.SOBE.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.SOBE.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SOBE.Size = new System.Drawing.Size(100, 445);
            this.SOBE.TabIndex = 2;
            this.SOBE.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SOBE_CellClick);
            // 
            // SOBE_EXTERNO
            // 
            this.SOBE_EXTERNO.HeaderText = "";
            this.SOBE_EXTERNO.MaxInputLength = 1;
            this.SOBE_EXTERNO.Name = "SOBE_EXTERNO";
            this.SOBE_EXTERNO.ReadOnly = true;
            this.SOBE_EXTERNO.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SOBE_EXTERNO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SOBE_EXTERNO.Width = 40;
            // 
            // DESCE
            // 
            this.DESCE.AllowUserToAddRows = false;
            this.DESCE.AllowUserToDeleteRows = false;
            this.DESCE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DESCE.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DESCE_EXTERNO});
            this.DESCE.Location = new System.Drawing.Point(501, 115);
            this.DESCE.Name = "DESCE";
            this.DESCE.ReadOnly = true;
            this.DESCE.RowHeadersVisible = false;
            this.DESCE.RowHeadersWidth = 40;
            this.DESCE.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DESCE.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DESCE.Size = new System.Drawing.Size(96, 445);
            this.DESCE.TabIndex = 3;
            this.DESCE.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DESCE_CellClick);
            // 
            // DESCE_EXTERNO
            // 
            this.DESCE_EXTERNO.HeaderText = "";
            this.DESCE_EXTERNO.MaxInputLength = 1;
            this.DESCE_EXTERNO.Name = "DESCE_EXTERNO";
            this.DESCE_EXTERNO.ReadOnly = true;
            this.DESCE_EXTERNO.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DESCE_EXTERNO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DESCE_EXTERNO.Width = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "INTERNO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "ELEVADOR";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "SOBE";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(523, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "DESCE";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // INTERVALO
            // 
            this.INTERVALO.Interval = 500;
            this.INTERVALO.Tick += new System.EventHandler(this.INTERVALO_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 581);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DESCE);
            this.Controls.Add(this.SOBE);
            this.Controls.Add(this.ELEVADOR);
            this.Controls.Add(this.INTERNO);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.INTERNO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ELEVADOR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SOBE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DESCE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView INTERNO;
        private System.Windows.Forms.DataGridView ELEVADOR;
        private System.Windows.Forms.DataGridView SOBE;
        private System.Windows.Forms.DataGridView DESCE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn COLUNA_INTERNA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOBE_EXTERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCE_EXTERNO;
        private System.Windows.Forms.Timer INTERVALO;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
    }
}


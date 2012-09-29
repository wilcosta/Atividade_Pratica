namespace CineC
{
    partial class CineC
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
            this.labelNome = new System.Windows.Forms.Label();
            this.labelGenero = new System.Windows.Forms.Label();
            this.labelLocal = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.comboBoxGen = new System.Windows.Forms.ComboBox();
            this.textBoxLocal = new System.Windows.Forms.TextBox();
            this.dateTimePickerData = new System.Windows.Forms.DateTimePicker();
            this.listViewFilmes = new System.Windows.Forms.ListView();
            this.columnHeaderNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderGen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLocal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonRemover = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(12, 57);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 13);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome";
            // 
            // labelGenero
            // 
            this.labelGenero.AutoSize = true;
            this.labelGenero.Location = new System.Drawing.Point(524, 57);
            this.labelGenero.Name = "labelGenero";
            this.labelGenero.Size = new System.Drawing.Size(42, 13);
            this.labelGenero.TabIndex = 1;
            this.labelGenero.Text = "Gênero";
            // 
            // labelLocal
            // 
            this.labelLocal.AutoSize = true;
            this.labelLocal.Location = new System.Drawing.Point(12, 108);
            this.labelLocal.Name = "labelLocal";
            this.labelLocal.Size = new System.Drawing.Size(112, 13);
            this.labelLocal.TabIndex = 2;
            this.labelLocal.Text = "Local que foi Assistido";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(524, 108);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(30, 13);
            this.labelData.TabIndex = 3;
            this.labelData.Text = "Data";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(15, 73);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(492, 20);
            this.textBoxNome.TabIndex = 4;
            // 
            // comboBoxGen
            // 
            this.comboBoxGen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGen.FormattingEnabled = true;
            this.comboBoxGen.Location = new System.Drawing.Point(527, 73);
            this.comboBoxGen.Name = "comboBoxGen";
            this.comboBoxGen.Size = new System.Drawing.Size(235, 21);
            this.comboBoxGen.TabIndex = 5;
            // 
            // textBoxLocal
            // 
            this.textBoxLocal.Location = new System.Drawing.Point(12, 124);
            this.textBoxLocal.Name = "textBoxLocal";
            this.textBoxLocal.Size = new System.Drawing.Size(495, 20);
            this.textBoxLocal.TabIndex = 6;
            // 
            // dateTimePickerData
            // 
            this.dateTimePickerData.Location = new System.Drawing.Point(527, 124);
            this.dateTimePickerData.Name = "dateTimePickerData";
            this.dateTimePickerData.Size = new System.Drawing.Size(235, 20);
            this.dateTimePickerData.TabIndex = 7;
            // 
            // listViewFilmes
            // 
            this.listViewFilmes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNome,
            this.columnHeaderGen,
            this.columnHeaderLocal,
            this.columnHeaderData});
            this.listViewFilmes.FullRowSelect = true;
            this.listViewFilmes.GridLines = true;
            this.listViewFilmes.Location = new System.Drawing.Point(15, 150);
            this.listViewFilmes.Name = "listViewFilmes";
            this.listViewFilmes.Size = new System.Drawing.Size(747, 271);
            this.listViewFilmes.TabIndex = 8;
            this.listViewFilmes.UseCompatibleStateImageBehavior = false;
            this.listViewFilmes.View = System.Windows.Forms.View.Details;
            this.listViewFilmes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewFilmes_MouseDoubleClick);
            // 
            // columnHeaderNome
            // 
            this.columnHeaderNome.Text = "Nome";
            this.columnHeaderNome.Width = 219;
            // 
            // columnHeaderGen
            // 
            this.columnHeaderGen.Text = "Gênero";
            this.columnHeaderGen.Width = 135;
            // 
            // columnHeaderLocal
            // 
            this.columnHeaderLocal.Text = "Local que foi Assistido";
            this.columnHeaderLocal.Width = 258;
            // 
            // columnHeaderData
            // 
            this.columnHeaderData.Text = "Data";
            this.columnHeaderData.Width = 128;
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(525, 427);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(75, 23);
            this.buttonAdicionar.TabIndex = 9;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(606, 427);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 10;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonRemover
            // 
            this.buttonRemover.Location = new System.Drawing.Point(687, 427);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(75, 23);
            this.buttonRemover.TabIndex = 11;
            this.buttonRemover.Text = "Remover";
            this.buttonRemover.UseVisualStyleBackColor = true;
            this.buttonRemover.Click += new System.EventHandler(this.buttonRemover_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(444, 427);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 12;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Formulário para cadastro de filmes";
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Location = new System.Drawing.Point(15, 428);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(75, 23);
            this.buttonPesquisar.TabIndex = 14;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // CineC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 466);
            this.Controls.Add(this.buttonPesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonRemover);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonAdicionar);
            this.Controls.Add(this.listViewFilmes);
            this.Controls.Add(this.dateTimePickerData);
            this.Controls.Add(this.textBoxLocal);
            this.Controls.Add(this.comboBoxGen);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelLocal);
            this.Controls.Add(this.labelGenero);
            this.Controls.Add(this.labelNome);
            this.Name = "CineC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CineC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelGenero;
        private System.Windows.Forms.Label labelLocal;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.ComboBox comboBoxGen;
        private System.Windows.Forms.TextBox textBoxLocal;
        private System.Windows.Forms.DateTimePicker dateTimePickerData;
        private System.Windows.Forms.ListView listViewFilmes;
        private System.Windows.Forms.ColumnHeader columnHeaderNome;
        private System.Windows.Forms.ColumnHeader columnHeaderGen;
        private System.Windows.Forms.ColumnHeader columnHeaderLocal;
        private System.Windows.Forms.ColumnHeader columnHeaderData;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonRemover;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPesquisar;
    }
}


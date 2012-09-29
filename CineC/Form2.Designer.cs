namespace CineC
{
    partial class Form2
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
            this.columnHeaderGen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLocal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDataI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewFilmesPesq = new System.Windows.Forms.ListView();
            this.dateTimePickerData2 = new System.Windows.Forms.DateTimePicker();
            this.textBoxLocal = new System.Windows.Forms.TextBox();
            this.comboBoxGen = new System.Windows.Forms.ComboBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelData = new System.Windows.Forms.Label();
            this.labelLocal = new System.Windows.Forms.Label();
            this.labelGeneroPesq = new System.Windows.Forms.Label();
            this.labelNomePesq = new System.Windows.Forms.Label();
            this.checkBoxNome = new System.Windows.Forms.CheckBox();
            this.checkBoxGen = new System.Windows.Forms.CheckBox();
            this.checkBoxLocal = new System.Windows.Forms.CheckBox();
            this.checkBoxData = new System.Windows.Forms.CheckBox();
            this.dateTimePickerData1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFiltrar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // columnHeaderGen
            // 
            this.columnHeaderGen.Text = "Gênero";
            this.columnHeaderGen.Width = 143;
            // 
            // columnHeaderLocal
            // 
            this.columnHeaderLocal.Text = "Local que foi Assistido";
            this.columnHeaderLocal.Width = 252;
            // 
            // columnHeaderDataI
            // 
            this.columnHeaderDataI.Text = "Data Inicial";
            this.columnHeaderDataI.Width = 114;
            // 
            // columnHeaderNome
            // 
            this.columnHeaderNome.Text = "Nome";
            this.columnHeaderNome.Width = 232;
            // 
            // listViewFilmesPesq
            // 
            this.listViewFilmesPesq.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNome,
            this.columnHeaderGen,
            this.columnHeaderLocal,
            this.columnHeaderDataI});
            this.listViewFilmesPesq.FullRowSelect = true;
            this.listViewFilmesPesq.GridLines = true;
            this.listViewFilmesPesq.Location = new System.Drawing.Point(15, 150);
            this.listViewFilmesPesq.Name = "listViewFilmesPesq";
            this.listViewFilmesPesq.Size = new System.Drawing.Size(747, 271);
            this.listViewFilmesPesq.TabIndex = 21;
            this.listViewFilmesPesq.UseCompatibleStateImageBehavior = false;
            this.listViewFilmesPesq.View = System.Windows.Forms.View.Details;
            // 
            // dateTimePickerData2
            // 
            this.dateTimePickerData2.Location = new System.Drawing.Point(527, 124);
            this.dateTimePickerData2.Name = "dateTimePickerData2";
            this.dateTimePickerData2.Size = new System.Drawing.Size(235, 20);
            this.dateTimePickerData2.TabIndex = 20;
            // 
            // textBoxLocal
            // 
            this.textBoxLocal.Location = new System.Drawing.Point(12, 124);
            this.textBoxLocal.Name = "textBoxLocal";
            this.textBoxLocal.Size = new System.Drawing.Size(237, 20);
            this.textBoxLocal.TabIndex = 19;
            // 
            // comboBoxGen
            // 
            this.comboBoxGen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGen.FormattingEnabled = true;
            this.comboBoxGen.Items.AddRange(new object[] {
            "Selecione...",
            "Ação",
            "Aventura",
            "Comédia",
            "Terror",
            "Suspense",
            "Documentário",
            "Infantil",
            "Romance",
            "Ficção Científica"});
            this.comboBoxGen.Location = new System.Drawing.Point(527, 73);
            this.comboBoxGen.Name = "comboBoxGen";
            this.comboBoxGen.Size = new System.Drawing.Size(235, 21);
            this.comboBoxGen.TabIndex = 18;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(15, 73);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(492, 20);
            this.textBoxNome.TabIndex = 17;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(524, 108);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(55, 13);
            this.labelData.TabIndex = 16;
            this.labelData.Text = "Data Final";
            // 
            // labelLocal
            // 
            this.labelLocal.AutoSize = true;
            this.labelLocal.Location = new System.Drawing.Point(12, 108);
            this.labelLocal.Name = "labelLocal";
            this.labelLocal.Size = new System.Drawing.Size(36, 13);
            this.labelLocal.TabIndex = 15;
            this.labelLocal.Text = "Local ";
            // 
            // labelGeneroPesq
            // 
            this.labelGeneroPesq.AutoSize = true;
            this.labelGeneroPesq.Location = new System.Drawing.Point(524, 57);
            this.labelGeneroPesq.Name = "labelGeneroPesq";
            this.labelGeneroPesq.Size = new System.Drawing.Size(42, 13);
            this.labelGeneroPesq.TabIndex = 14;
            this.labelGeneroPesq.Text = "Gênero";
            // 
            // labelNomePesq
            // 
            this.labelNomePesq.AutoSize = true;
            this.labelNomePesq.Location = new System.Drawing.Point(12, 57);
            this.labelNomePesq.Name = "labelNomePesq";
            this.labelNomePesq.Size = new System.Drawing.Size(35, 13);
            this.labelNomePesq.TabIndex = 13;
            this.labelNomePesq.Text = "Nome";
            // 
            // checkBoxNome
            // 
            this.checkBoxNome.AutoSize = true;
            this.checkBoxNome.Location = new System.Drawing.Point(527, 27);
            this.checkBoxNome.Name = "checkBoxNome";
            this.checkBoxNome.Size = new System.Drawing.Size(54, 17);
            this.checkBoxNome.TabIndex = 26;
            this.checkBoxNome.Text = "Nome";
            this.checkBoxNome.UseVisualStyleBackColor = true;
            this.checkBoxNome.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxGen
            // 
            this.checkBoxGen.AutoSize = true;
            this.checkBoxGen.Location = new System.Drawing.Point(587, 27);
            this.checkBoxGen.Name = "checkBoxGen";
            this.checkBoxGen.Size = new System.Drawing.Size(61, 17);
            this.checkBoxGen.TabIndex = 27;
            this.checkBoxGen.Text = "Gênero";
            this.checkBoxGen.UseVisualStyleBackColor = true;
            this.checkBoxGen.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxLocal
            // 
            this.checkBoxLocal.AutoSize = true;
            this.checkBoxLocal.Location = new System.Drawing.Point(654, 27);
            this.checkBoxLocal.Name = "checkBoxLocal";
            this.checkBoxLocal.Size = new System.Drawing.Size(52, 17);
            this.checkBoxLocal.TabIndex = 28;
            this.checkBoxLocal.Text = "Local";
            this.checkBoxLocal.UseVisualStyleBackColor = true;
            this.checkBoxLocal.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxData
            // 
            this.checkBoxData.AutoSize = true;
            this.checkBoxData.Location = new System.Drawing.Point(712, 27);
            this.checkBoxData.Name = "checkBoxData";
            this.checkBoxData.Size = new System.Drawing.Size(49, 17);
            this.checkBoxData.TabIndex = 29;
            this.checkBoxData.Text = "Data";
            this.checkBoxData.UseVisualStyleBackColor = true;
            this.checkBoxData.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // dateTimePickerData1
            // 
            this.dateTimePickerData1.Location = new System.Drawing.Point(272, 124);
            this.dateTimePickerData1.Name = "dateTimePickerData1";
            this.dateTimePickerData1.Size = new System.Drawing.Size(235, 20);
            this.dateTimePickerData1.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Data Inicial";
            // 
            // buttonFiltrar
            // 
            this.buttonFiltrar.Location = new System.Drawing.Point(525, 431);
            this.buttonFiltrar.Name = "buttonFiltrar";
            this.buttonFiltrar.Size = new System.Drawing.Size(75, 23);
            this.buttonFiltrar.TabIndex = 32;
            this.buttonFiltrar.Text = "Filtrar";
            this.buttonFiltrar.UseVisualStyleBackColor = true;
            this.buttonFiltrar.Click += new System.EventHandler(this.buttonFiltrar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(687, 431);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 33;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Faça sua escolha entre as opções e digite sua expressão de pesquisa";
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(606, 431);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpar.TabIndex = 35;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 466);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonFiltrar);
            this.Controls.Add(this.dateTimePickerData1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxData);
            this.Controls.Add(this.checkBoxLocal);
            this.Controls.Add(this.checkBoxGen);
            this.Controls.Add(this.checkBoxNome);
            this.Controls.Add(this.listViewFilmesPesq);
            this.Controls.Add(this.dateTimePickerData2);
            this.Controls.Add(this.textBoxLocal);
            this.Controls.Add(this.comboBoxGen);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelLocal);
            this.Controls.Add(this.labelGeneroPesq);
            this.Controls.Add(this.labelNomePesq);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CineC Pesquisa";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeaderGen;
        private System.Windows.Forms.ColumnHeader columnHeaderLocal;
        private System.Windows.Forms.ColumnHeader columnHeaderDataI;
        private System.Windows.Forms.ColumnHeader columnHeaderNome;
        private System.Windows.Forms.ListView listViewFilmesPesq;
        private System.Windows.Forms.DateTimePicker dateTimePickerData2;
        private System.Windows.Forms.TextBox textBoxLocal;
        private System.Windows.Forms.ComboBox comboBoxGen;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelLocal;
        private System.Windows.Forms.Label labelGeneroPesq;
        private System.Windows.Forms.Label labelNomePesq;
        private System.Windows.Forms.CheckBox checkBoxNome;
        private System.Windows.Forms.CheckBox checkBoxGen;
        private System.Windows.Forms.CheckBox checkBoxLocal;
        private System.Windows.Forms.CheckBox checkBoxData;
        private System.Windows.Forms.DateTimePicker dateTimePickerData1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFiltrar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonLimpar;
    }
}
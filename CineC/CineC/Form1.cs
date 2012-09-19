﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CineC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        ListViewItem novoItem = new ListViewItem();

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxGen.SelectedIndex = 0;
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            // Validação dos campos Nome, Local e Gênero
            if (textBoxNome.Text == "" || textBoxLocal.Text == "" || comboBoxGen.SelectedIndex == 0)
                MessageBox.Show("Favor preencher todos os campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else

               // Criação do novo item (primeira coluna) campo Nome do filme
               novoItem = new ListViewItem();
               novoItem.Text = textBoxNome.Text;

               // Criação do primeiro subitem (segunda coluna) campo Gênero do Filme
               ListViewItem.ListViewSubItem SubitemGenero = new ListViewItem.ListViewSubItem();
               SubitemGenero.Text = comboBoxGen.SelectedItem.ToString();

               // Criação do segundo subitem (terceira coluna) campo Local que foi Assistido
               ListViewItem.ListViewSubItem SubitemLocal = new ListViewItem.ListViewSubItem();
               SubitemLocal.Text = textBoxLocal.Text;

               // Criação do terceiro subitem (quarta coluna) campo Data
               ListViewItem.ListViewSubItem SubitemData = new ListViewItem.ListViewSubItem();
               string data = dateTimePickerData.Value.Date.ToString();

               //Adiciona os subitens ao item 
               novoItem.SubItems.Add(SubitemGenero);
               novoItem.SubItems.Add(SubitemLocal);
               novoItem.SubItems.Add(SubitemData);

              
        }

        }

    }

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CineC
{
    public partial class CineC : Form
    {
        public CineC()
        {
            InitializeComponent();
        }
        // Criação do ListView e vetor com os "gêneros do filme", e estes carregados no comboBoxGen
        
        ListViewItem novoItem = new ListViewItem();

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] genero = {"Selecione...","Ação", "Aventura", "Comédia", "Terror", "Suspense", "Documentário", "Infantil", "Romance", "Ficção Científica" };
            
            comboBoxGen.DataSource = genero;
            comboBoxGen.SelectedIndex = 0;
            buttonSalvar.Visible = false;
            buttonPesquisar.Visible = false;
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
        // Validação dos campos Nome, Local e Gênero. Criação do novo item e suitem formando quatro colunas "Nome do filme, Gênero do Filme, Local que foi Assistido e Data", no final são adicionados os subitens ao item e o item ao ListView
           
            if (textBoxNome.Text == "" || textBoxLocal.Text == "" || comboBoxGen.SelectedIndex == 0)
                MessageBox.Show("Favor preencher todos os campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else

            {
                novoItem = new ListViewItem();
                novoItem.Text = textBoxNome.Text;

                ListViewItem.ListViewSubItem SubitemGenero = new ListViewItem.ListViewSubItem();
                SubitemGenero.Text = comboBoxGen.SelectedItem.ToString();

                ListViewItem.ListViewSubItem SubitemLocal = new ListViewItem.ListViewSubItem();
                SubitemLocal.Text = textBoxLocal.Text;

                ListViewItem.ListViewSubItem SubitemData = new ListViewItem.ListViewSubItem();
                SubitemData.Text = dateTimePickerData.Value.Date.ToString("dd/MM/yyyy");

                novoItem.SubItems.Add(SubitemGenero);
                novoItem.SubItems.Add(SubitemLocal);
                novoItem.SubItems.Add(SubitemData);

                listViewFilmes.Items.Add(novoItem);
                ResetForm();
                buttonPesquisar.Visible = true;
            }
        }

        public void ResetForm()
        {
            buttonAdicionar.Enabled = true;
            buttonSalvar.Visible = false;
            textBoxNome.Text = "";
            textBoxLocal.Text = "";
            comboBoxGen.SelectedIndex = 0;
            dateTimePickerData.Value = DateTime.Now;
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            
        // Verifica se o usuário selecionou algum item da lista, apaga o item selecionado se necessário. Cria uma lista onde será adicionado os itens selecionados
        
            if (listViewFilmes.SelectedItems.Count != 0)
            {
                int posicao = listViewFilmes.SelectedItems.Count;

                for (int i = posicao - 1; i >= 0; i--)
                {
                    ListViewItem ItemSelecionado = listViewFilmes.SelectedItems[i];
                    listViewFilmes.Items.Remove(ItemSelecionado);
                    
                    if(listViewFilmes.Items.Count == 0)
                        buttonPesquisar.Visible = false;
                }
            }
            else
            {
                if (listViewFilmes.Items.Count == 0)
                    MessageBox.Show("Impossivel remover!\n Lista vazia", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Selecione primeiramente um item a ser removido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void listViewFilmes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EditItem();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            EditItem();
        }

        public void EditItem()
        {

        // Método para edição dos itens, verifica se foi adicionado algum item do ListView. Serão passados os valores de cada coluna do ListView aos campos compatíveis
            
            if (listViewFilmes.SelectedItems.Count != 0)
            {
                buttonSalvar.Visible = true;
                buttonAdicionar.Enabled = false;
                
                textBoxNome.Text = listViewFilmes.SelectedItems[0].SubItems[0].Text;

                comboBoxGen.Text = listViewFilmes.SelectedItems[0].SubItems[1].Text;

                textBoxLocal.Text = listViewFilmes.SelectedItems[0].SubItems[2].Text;

                dateTimePickerData.Value = DateTime.Parse(listViewFilmes.SelectedItems[0].SubItems[3].Text);
            }  
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            buttonAdicionar.Enabled = false;

        // Validação dos campos, sendo necessário alterará os dados dos itens da lista
            
            if (textBoxNome.Text.Trim() == "" || textBoxLocal.Text.Trim() == "" || comboBoxGen.SelectedIndex == 0)
                MessageBox.Show("Todos os campos devem estar preenchidos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
            else
            {
                listViewFilmes.SelectedItems[0].SubItems[0].Text = textBoxNome.Text;
                listViewFilmes.SelectedItems[0].SubItems[1].Text = comboBoxGen.SelectedItem.ToString();
                listViewFilmes.SelectedItems[0].SubItems[2].Text = textBoxLocal.Text;
                listViewFilmes.SelectedItems[0].SubItems[3].Text = dateTimePickerData.Value.ToString("dd/MM/yyyy");

                ResetForm();

                listViewFilmes.SelectedItems[0].Selected = false;
                buttonPesquisar.Visible = true;
            }
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            Form2 pesquisar = new Form2(listViewFilmes);
            pesquisar.ShowDialog();
        }
    }
}
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
    public partial class Form2 : Form
    {
        ListView Lista;

        public Form2(ListView ListaPesq)
        {
            Lista = ListaPesq; // Recebe a lista que contém os itens do Form1 e passa p/ uma nova lista
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
        
        // Verificação dos campos p/ filtragem a partir do checkbox selecionado, tratamento limpar o campo correspondente caso o usuario habilite e desabilite em seguida um determinado checkBox  

            if (checkBoxNome.Checked == true)
                textBoxNome.Enabled = true;
            else
            {
                textBoxNome.Enabled = false;
                textBoxNome.Text = "";
            }

            if (checkBoxGen.Checked == true)
                comboBoxGen.Enabled = true;
            else
            {
                comboBoxGen.Enabled = false;
                comboBoxGen.SelectedIndex = 0;
            }

            if (checkBoxLocal.Checked == true)
                textBoxLocal.Enabled = true;
            else
            {
                textBoxLocal.Enabled = false;
                textBoxLocal.Text = "";
            }

            if (checkBoxData.Checked == true)
            {
                dateTimePickerData1.Enabled = true;
                dateTimePickerData2.Enabled = true;
            }
            else
            {
                dateTimePickerData1.Enabled = false; dateTimePickerData1.Value = DateTime.Now;
                dateTimePickerData2.Enabled = false; dateTimePickerData2.Value = DateTime.Now;
            }
        }

        public void ResetForm()
        {
            textBoxNome.Enabled = false;
            textBoxNome.Text = "";

            textBoxLocal.Enabled = false;
            textBoxLocal.Text = "";

            comboBoxGen.Enabled = false;
            comboBoxGen.SelectedIndex = 0;

            dateTimePickerData1.Enabled = false;
            dateTimePickerData2.Enabled = false;
            dateTimePickerData1.Value = DateTime.Now;
            dateTimePickerData2.Value = DateTime.Now;
        }

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            int erro = 0;
            List<string> OpcaoPesquisa = new List<string>();
            
            // Validação dos campos para filtragem. É adicionado na Lista a opção escolhida pelo usuário. Se for selecionado um checBox e caso o campo correspondente não seja preenchido é apresentada uma mensagem de "erro"
            if (checkBoxNome.Checked == true)
            {
                if (textBoxNome.Text.Trim() != "")
                {
                    OpcaoPesquisa.Add("Nome");
                }
                else
                    erro++;
            }

            if (checkBoxLocal.Checked == true)
            {
                if (textBoxLocal.Text.Trim() != "")
                {
                    OpcaoPesquisa.Add("Local");
                }
                else
                    erro++;
            }

            if (checkBoxGen.Checked == true)
            {
                if (comboBoxGen.SelectedIndex > 0)
                {
                    OpcaoPesquisa.Add("Genero");
                }
                else
                    erro++;
            }

            if (checkBoxData.Checked == true)
            {
                OpcaoPesquisa.Add("Data");
            }

            if (erro > 0)
                MessageBox.Show("Preencha o(s) campo(s) previamente selecionado(s).");
            else
            {
                // *** Faz a pesquisa com 1 Campo *** // A cada nova pesquisa a Lista será "limpa" e data será atualizada, isso será feito também para filtragem com 2, 3 e 4 campos

                if (OpcaoPesquisa.Count == 1)
                {
                    DateTime dataInicio = dateTimePickerData1.Value;
                    DateTime dataFim = dateTimePickerData2.Value;

                    listViewFilmesPesq.Items.Clear();

                    if (OpcaoPesquisa[0] == "Nome")
                    {
                        // Percorre a lista e verifica se o nome que o usuário informou contém na lista com os filmes cadastrados
                        for (int i = 0; i < Lista.Items.Count; i++)
                        {
                            // Se a pesquisa obteve algum resultado, é chamado o método p/ adicionar esse resultado na lista

                            if (Lista.Items[i].Text.IndexOf(textBoxNome.Text) > -1)
                                AddItem(Lista.Items[i].Text, Lista.Items[i].SubItems[1].Text, Lista.Items[i].SubItems[2].Text, Lista.Items[i].SubItems[3].Text);
                        }
                    }
                    if (OpcaoPesquisa[0] == "Genero")
                    {
                        for (int i = 0; i < Lista.Items.Count; i++)
                        {
                            // o campo "Genero" na lista é o SubItem[1]
                            if (Lista.Items[i].SubItems[1].Text.IndexOf(comboBoxGen.SelectedItem.ToString()) > -1)
                                AddItem(Lista.Items[i].Text, Lista.Items[i].SubItems[1].Text, Lista.Items[i].SubItems[2].Text, Lista.Items[i].SubItems[3].Text);
                        }
                    }
                    if (OpcaoPesquisa[0] == "Local")
                    {
                        // o campo "Local" na lista é o SubItem[2]
                        for (int i = 0; i < Lista.Items.Count; i++)
                        {
                            if (Lista.Items[i].SubItems[2].Text.IndexOf(textBoxLocal.Text) > -1)
                                AddItem(Lista.Items[i].Text, Lista.Items[i].SubItems[1].Text, Lista.Items[i].SubItems[2].Text, Lista.Items[i].SubItems[3].Text);
                        }
                    }
                    if (OpcaoPesquisa[0] == "Data")
                    {
                        // o campo "Data" na lista é o SubItem[3]
                        for (int i = 0; i < Lista.Items.Count; i++)
                        {
                            // Converte a Data que esta em formato string para DateTime
                            DateTime data = DateTime.Parse(Lista.Items[i].SubItems[3].Text);

                            // Verifica se a Data está entre os parâmetros
                            if (data.Date >= dataInicio.Date && data.Date <= dataFim.Date)
                                AddItem(Lista.Items[i].Text, Lista.Items[i].SubItems[1].Text, Lista.Items[i].SubItems[2].Text, Lista.Items[i].SubItems[3].Text);
                        }
                    }
                }

                // *** Faz a Pesquisa com 2 Campos *** //
                if (OpcaoPesquisa.Count == 2)
                {
                    DateTime dataInicio = dateTimePickerData1.Value;
                    DateTime dataFim = dateTimePickerData2.Value;

                    listViewFilmesPesq.Items.Clear();

                    if (OpcaoPesquisa[0] == "Nome" && OpcaoPesquisa[1] == "Genero")
                    {
                        // Faz a Pesquisa com o Nome & Gênero
                        for (int i = 0; i < Lista.Items.Count; i++)
                        {
                            // Verifica se o Nome que o usuário informou contém no listView  
                            if (Lista.Items[i].Text.IndexOf(textBoxNome.Text) > -1)
                            {
                                // Verifica se o Gênero que o usuário informou contém, no resultado da pesquisa
                                // Caso exista o Nome e o Gênero (SubItems[1]), a pesquisa obteve resultado e adiciona no ListView
                                if (Lista.Items[i].SubItems[1].Text.IndexOf(comboBoxGen.SelectedItem.ToString()) > -1)
                                    AddItem(Lista.Items[i].Text, Lista.Items[i].SubItems[1].Text, Lista.Items[i].SubItems[2].Text, Lista.Items[i].SubItems[3].Text);

                            }
                        }
                    }

                    if (OpcaoPesquisa[0] == "Nome" && OpcaoPesquisa[1] == "Local")
                    {
                        // Faz a Pesquisa com o Nome & Local
                        for (int i = 0; i < Lista.Items.Count; i++)
                        {
                            if (Lista.Items[i].Text.IndexOf(textBoxNome.Text) > -1)
                            {
                                // Verifica se o Local que o usuário informou contém, no resultado da pesquisa pelo Nome
                                // Caso tenha o Nome e o Local (SubItems[2]), a pesquisa obteve resultado e adiciona no ListView
                                if (Lista.Items[i].SubItems[2].Text.IndexOf(textBoxLocal.Text) > -1)
                                    AddItem(Lista.Items[i].Text, Lista.Items[i].SubItems[1].Text, Lista.Items[i].SubItems[2].Text, Lista.Items[i].SubItems[3].Text);

                            }
                        }
                    }

                    if (OpcaoPesquisa[0] == "Nome" && OpcaoPesquisa[1] == "Data")
                    {
                        // Faz a pesquisa com o Nome & Data
                        for (int i = 0; i < Lista.Items.Count; i++)
                        {
                            if (Lista.Items[i].Text.IndexOf(textBoxNome.Text) > -1)
                            {
                                // Converte a data (SubItems[3])  do resultado da pesquisa pelo Nome que está em formato string para DateTime
                                DateTime data = DateTime.Parse(Lista.Items[i].SubItems[3].Text);

                                // Verifica se a data está entre os parâmetros
                                if (data.Date >= dataInicio.Date && data.Date <= dataFim.Date)
                                    AddItem(Lista.Items[i].Text, Lista.Items[i].SubItems[1].Text, Lista.Items[i].SubItems[2].Text, Lista.Items[i].SubItems[3].Text);

                            }
                        }
                    }

                    if (OpcaoPesquisa[0] == "Local" && OpcaoPesquisa[1] == "Genero")
                    {
                        // Faz a Pesquisa com o Local & Gênero
                        for (int i = 0; i < Lista.Items.Count; i++)
                        {
                            // Verifica se o Local (SubItems[2]) que o usuário informou contém no ListView
                            if (Lista.Items[i].SubItems[2].Text.IndexOf(textBoxLocal.Text) > -1)
                            {
                                // Verifica se o Gênero que o usuário informou contém no resultado da pesquisa pelo Local. Caso tenha o Local e o Gênero (SubItems[1]), a pesquisa obteve resultado e adiciona no ListView
                                if (Lista.Items[i].SubItems[1].Text.IndexOf(comboBoxGen.SelectedItem.ToString()) > -1)
                                    AddItem(Lista.Items[i].Text, Lista.Items[i].SubItems[1].Text, Lista.Items[i].SubItems[2].Text, Lista.Items[i].SubItems[3].Text);

                            }
                        }
                    }

                    if (OpcaoPesquisa[0] == "Local" && OpcaoPesquisa[1] == "Data")
                    {
                        // Faz a pesquisa com o Local & Data
                        for (int i = 0; i < Lista.Items.Count; i++)
                        {
                            if (Lista.Items[i].SubItems[2].Text.IndexOf(textBoxLocal.Text) > -1)
                            {
                                // Converte a data (SubItems[3])  do resultado da pesquisa pelo Local que está em formato string para DateTime
                                DateTime data = DateTime.Parse(Lista.Items[i].SubItems[3].Text);

                                // Verifica se a data está entre os parâmetros
                                if (data.Date >= dataInicio.Date && data.Date <= dataFim.Date)
                                    AddItem(Lista.Items[i].Text, Lista.Items[i].SubItems[1].Text, Lista.Items[i].SubItems[2].Text, Lista.Items[i].SubItems[3].Text);

                            }
                        }
                    }

                    if (OpcaoPesquisa[0] == "Genero" && OpcaoPesquisa[1] == "Data")
                    {
                        // Faz a pesquisa com o Gênero & Data
                        for (int i = 0; i < Lista.Items.Count; i++)
                        {
                            // Verifica se o Gênero (SubItems[1]) que o usuário informou contém no listView  
                            if (Lista.Items[i].SubItems[1].Text.IndexOf(comboBoxGen.SelectedItem.ToString()) > -1)
                            {
                                DateTime data = DateTime.Parse(Lista.Items[i].SubItems[3].Text);
                                if (data.Date >= dataInicio.Date && data.Date <= dataFim.Date)
                                    AddItem(Lista.Items[i].Text, Lista.Items[i].SubItems[1].Text, Lista.Items[i].SubItems[2].Text, Lista.Items[i].SubItems[3].Text);

                            }
                        }
                    }
                }

                // *** Faz a Pesquisa com 3 Campos *** //
                if (OpcaoPesquisa.Count == 3)
                {
                    DateTime dataInicio = dateTimePickerData1.Value;
                    DateTime dataFim = dateTimePickerData2.Value;

                    listViewFilmesPesq.Items.Clear();

                    if (OpcaoPesquisa[0] == "Nome" && OpcaoPesquisa[1] == "Local" && OpcaoPesquisa[2] == "Genero")
                    {
                        // Faz a Pesquisa com o Nome, Local & Genero
                        for (int i = 0; i < Lista.Items.Count; i++)
                        {
                            // Verifica se o Nome que o usuário informou contém no listView  
                            if (Lista.Items[i].Text.IndexOf(textBoxNome.Text) > -1)
                            {
                                // Verifica se o Local que o usuário informou contém, no resultado da pesquisa pelo Nome
                                if (Lista.Items[i].SubItems[2].Text.IndexOf(textBoxLocal.Text) > -1)
                                {
                                    // Verifica se o Gênero que o usuário informou contém, no resultado da pesquisa pelo Local
                                    if (Lista.Items[i].SubItems[1].Text.IndexOf(comboBoxGen.SelectedItem.ToString()) > -1)
                                        AddItem(Lista.Items[i].Text, Lista.Items[i].SubItems[1].Text, Lista.Items[i].SubItems[2].Text, Lista.Items[i].SubItems[3].Text);
                                }
                            }
                        }
                    }

                    if (OpcaoPesquisa[0] == "Nome" && OpcaoPesquisa[1] == "Local" && OpcaoPesquisa[2] == "Data")
                    {
                        // Faz a Pesquisa com o Nome, Local & Data
                        for (int i = 0; i < Lista.Items.Count; i++)
                        {
                            if (Lista.Items[i].Text.IndexOf(textBoxNome.Text) > -1)
                            {
                                // Verifica se o Local que o usuário informou contém, no resultado da pesquisa pelo Nome
                                if (Lista.Items[i].SubItems[2].Text.IndexOf(textBoxLocal.Text) > -1)
                                {
                                    DateTime data = DateTime.Parse(Lista.Items[i].SubItems[3].Text);

                                    // Verifica se a data que o usuário informou está dentro dos parâmetros, no resultado da pesquisa pelo Local
                                    if (data.Date >= dataInicio.Date && data.Date <= dataFim.Date)
                                        AddItem(Lista.Items[i].Text, Lista.Items[i].SubItems[1].Text, Lista.Items[i].SubItems[2].Text, Lista.Items[i].SubItems[3].Text);
                                }
                            }
                        }
                    }

                    if (OpcaoPesquisa[0] == "Nome" && OpcaoPesquisa[1] == "Genero" && OpcaoPesquisa[2] == "Data")
                    {
                        // Faz a pesquisa com o Nome, Gênero & Data
                        for (int i = 0; i < Lista.Items.Count; i++)
                        {
                            if (Lista.Items[i].Text.IndexOf(textBoxNome.Text) > -1)
                            {
                                // Verifica se o Gênero que o usuário informou contém, no resultado da pesquisa pelo Nome
                                if (Lista.Items[i].SubItems[1].Text.IndexOf(comboBoxGen.SelectedItem.ToString()) > -1)
                                {
                                    DateTime data = DateTime.Parse(Lista.Items[i].SubItems[3].Text);

                                    // Verifica se a data que o usuário informou está dentro dos parâmetros, no resultado da pesquisa pelo Local
                                    if (data.Date >= dataInicio.Date && data.Date <= dataFim.Date)
                                        AddItem(Lista.Items[i].Text, Lista.Items[i].SubItems[1].Text, Lista.Items[i].SubItems[2].Text, Lista.Items[i].SubItems[3].Text);
                                }
                            }
                        }
                    }
                    if (OpcaoPesquisa[0] == "Local" && OpcaoPesquisa[1] == "Genero" && OpcaoPesquisa[2] == "Data")
                    {
                        // Faz a pesquisa com o Local, Gênero & Data
                        for (int i = 0; i < Lista.Items.Count; i++)
                        {
                            if (Lista.Items[i].SubItems[2].Text.IndexOf(textBoxLocal.Text) > -1)
                            {
                                // Verifica se o Gênero que o usuário informou contém, no resultado da pesquisa pelo Local
                                if (Lista.Items[i].SubItems[1].Text.IndexOf(comboBoxGen.SelectedItem.ToString()) > -1)
                                {
                                    DateTime data = DateTime.Parse(Lista.Items[i].SubItems[3].Text);

                                    // Verifica se a data que o usuário informou está dentro dos parâmetros, no resultado da pesquisa pelo Local
                                    if (data.Date >= dataInicio.Date && data.Date <= dataFim.Date)
                                        AddItem(Lista.Items[i].Text, Lista.Items[i].SubItems[1].Text, Lista.Items[i].SubItems[2].Text, Lista.Items[i].SubItems[3].Text);
                                }
                            }
                        }
                    }
                }

                // *** Faz a Pesquisa com 4 Campos *** //
                if (OpcaoPesquisa.Count == 4)
                {
                    DateTime dataInicio = dateTimePickerData1.Value;
                    DateTime dataFim = dateTimePickerData2.Value;

                    listViewFilmesPesq.Items.Clear();

                    if (OpcaoPesquisa[0] == "Nome" && OpcaoPesquisa[1] == "Local" && OpcaoPesquisa[2] == "Genero" && OpcaoPesquisa[3] == "Data")
                    {
                        // Faz a Pesquisa com o Nome, Local, Genero & Data
                        for (int i = 0; i < Lista.Items.Count; i++)
                        {
                            // Verifica se o Nome que o usuário informou contém, no ListView
                            if (Lista.Items[i].Text.IndexOf(textBoxNome.Text) > -1)
                            {
                                // Verifica se o Local que o usuário informou contém, no resultado da pesquisa pelo Nome
                                if (Lista.Items[i].SubItems[2].Text.IndexOf(textBoxLocal.Text) > -1)
                                {
                                    // Verifica se o Gênero que o usuário informou contém, no resultado da pesquisa pelo Local
                                    if (Lista.Items[i].SubItems[1].Text.IndexOf(comboBoxGen.SelectedItem.ToString()) > -1)
                                    {
                                        DateTime data = DateTime.Parse(Lista.Items[i].SubItems[3].Text);

                                        // Verifica se a data que o usuário informou está dentro dos parâmetros, no resultado da pesquisa pelo Gênero
                                        if (data.Date >= dataInicio.Date && data.Date <= dataFim.Date)
                                            AddItem(Lista.Items[i].Text, Lista.Items[i].SubItems[1].Text, Lista.Items[i].SubItems[2].Text, Lista.Items[i].SubItems[3].Text);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public void AddItem(string Nome, string Genero, string Local, string Data)
        {
            // Adiciona o item conforme o resultado da pesquisa

            ListViewItem novoItem = new ListViewItem();
            novoItem.Text = Nome;

            ListViewItem.ListViewSubItem SubitemGenero = new ListViewItem.ListViewSubItem();
            SubitemGenero.Text = Genero;

            ListViewItem.ListViewSubItem SubitemLocal = new ListViewItem.ListViewSubItem();
            SubitemLocal.Text = Local;

            ListViewItem.ListViewSubItem SubitemData = new ListViewItem.ListViewSubItem();
            SubitemData.Text = Data;

            novoItem.SubItems.Add(SubitemGenero);
            novoItem.SubItems.Add(SubitemLocal);
            novoItem.SubItems.Add(SubitemData);
            listViewFilmesPesq.Items.Add(novoItem);
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            listViewFilmesPesq.Items.Clear();
            textBoxNome.Text = "";
            textBoxLocal.Text = "";
            comboBoxGen.SelectedIndex = 0;
            dateTimePickerData1.Value = DateTime.Now;
            dateTimePickerData2.Value = DateTime.Now;
            checkBoxData.Checked = false;
            checkBoxGen.Checked = false;
            checkBoxLocal.Checked = false;
            checkBoxNome.Checked = false;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
  
    }
}

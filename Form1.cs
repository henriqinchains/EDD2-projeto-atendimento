using System;
using System.Windows.Forms;

namespace Atendimento
{
    public partial class Form1 : Form
    {
        private Senhas senhas = new Senhas();
        private Guiches guiches = new Guiches();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            senhas.gerar();
            AtualizarListas();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            int qtd = (int)nudQuantidade.Value;
            for (int i = 0; i < qtd; i++)
            {
                guiches.adicionar(new Guiche(guiches.ListaGuiches.Count + 1));
            }

            int selecionado = cmbGuiche.SelectedIndex;
            cmbGuiche.Items.Clear();
            foreach (Guiche g in guiches.ListaGuiches)
                cmbGuiche.Items.Add(g);
            cmbGuiche.SelectedIndex = selecionado >= 0 ? selecionado : 0;

            AtualizarListas();
        }

        private void btnChamar_Click(object sender, EventArgs e)
        {
            Guiche guiche = cmbGuiche.SelectedItem as Guiche;
            if (guiche == null)
            {
                MessageBox.Show("Cadastre e selecione um guichê.");
                return;
            }

            if (!guiche.chamar(senhas.FilaSenhas))
            {
                MessageBox.Show("Não há senhas aguardando atendimento.");
                return;
            }

            AtualizarListas();
        }

        private void AtualizarListas()
        {
            lstSenhas.Items.Clear();
            foreach (Senha s in senhas.FilaSenhas)
                lstSenhas.Items.Add(s.dadosParciais());

            lstAtendimentos.Items.Clear();
            foreach (Guiche g in guiches.ListaGuiches)
            {
                lstAtendimentos.Items.Add(g.ToString());
                foreach (Senha s in g.Atendimentos)
                    lstAtendimentos.Items.Add("    " + s.dadosCompletos());
            }
        }
    }
}

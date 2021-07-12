using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace GeradorNumerosLoteriaGUI
{
    public partial class Form1 : Form
    {
        private const int MAIORNUMEROMEGASENA = 60;
        private const int MAIORNUMEROQUINA = 80;
        private const int MAIORNUMEROLOTOFACIL = 25;
        private const int MAIORNUMEROLOTOMANIA = 100;

        private const int QUANTIDADEAESCOLHERMEGASENA = 6;
        private const int QUANTIDADEAESCOLHERQUINA = 5;
        private const int QUANTIDADEAESCOLHERLOTOFACIL = 15;
        private const int QUANTIDADEAESCOLHERLOTOMANIA = 20;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(rtxbResultado.Text);
            MessageBox.Show("Conteúdo copiado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            if (rbMegaSena.Checked)
            {
                EscreverResultado(MAIORNUMEROMEGASENA, QUANTIDADEAESCOLHERMEGASENA);
            }
            else if (rbQuina.Checked)
            {
                EscreverResultado(MAIORNUMEROQUINA, QUANTIDADEAESCOLHERQUINA);
            }
            else if (rbLotofacil.Checked)
            {
                EscreverResultado(MAIORNUMEROLOTOFACIL, QUANTIDADEAESCOLHERLOTOFACIL);
            }
            else if (rbLotomania.Checked)
            {
                EscreverResultado(MAIORNUMEROLOTOMANIA, QUANTIDADEAESCOLHERLOTOMANIA);
            }
            else
            {
                MessageBox.Show("Selecione um jogo!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private int GerarNumero(int maximoNumeros)
        {
            Random random = new Random();
            return random.Next(1, maximoNumeros + 1);
        }

        private string FormataExibicao(List<int> numeros)
        {
            string texto = "";
            int contador = 0;
            foreach (int numero in numeros)
            {
                contador += 1;
                if (contador == 7)
                {
                    texto += $"{numero}\n";
                    contador = 0;
                }
                else
                {
                    texto += $"{numero}\t";
                }
            }
            return texto;
        }

        private void EscreverResultado(int maiorNumero, int quantidadeASelecionar)
        {
            List<int> numeros = new List<int>();
            while (numeros.Count != quantidadeASelecionar)
            {
                int numero = GerarNumero(maiorNumero);
                if (numeros.Contains(numero))
                {
                    continue;
                }
                else
                {
                    numeros.Add(numero);
                }
            }
            rtxbResultado.Clear();
            rtxbResultado.Text = FormataExibicao(numeros);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                File.WriteAllText(fileName, rtxbResultado.Text);
                MessageBox.Show("Arquivo salvo com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace prjGenius
{
    public partial class frmJogo2 : Form
    {
        public int[] vetorRodadas;
        public int qtdeJogadas = 0, Tempo = 1000, lngPartidaJogador = 0, lngPontuação = 0, lngControleJogada = 0;
        public bool blnAcende = true;

        private void btnIniciarJogo_Click(object sender, EventArgs e)
        {
            vetorRodadas = new int[15];
            lngControleJogada = 0;
            qtdeJogadas = 0;
            lblPontuacao.Text = "0";
            btnIniciarJogo.Enabled = false;
            btnVoltar.Enabled = false;
            CarregarJogadas();
            desabilitarJogada();
            Jogo();

        }

        public frmJogo2()
        {
            InitializeComponent();
        }
        public void CarregarJogadas()
        {
            Random cor = new Random();
            vetorRodadas[0] = cor.Next(1, 5);

            for (int pos = 0; pos <= (vetorRodadas.Length - 1); pos++)
            {
                int resultado = cor.Next(1, 5);
                if (resultado == 5)
                {
                    vetorRodadas[pos] = 4;
                }
                else
                {
                    vetorRodadas[pos] = resultado;
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Hide();
        }
        public void Jogo()
        {
            if (qtdeJogadas <= (vetorRodadas.Length - 1))
            {
                tmrPcb.Enabled = true;
            }


        }

        private void tmrPcb_Tick(object sender, EventArgs e)
        {
            if (lngControleJogada <= qtdeJogadas)
            {
                if (blnAcende)
                {
                    tmrPcb.Interval = Tempo;
                    if (vetorRodadas[lngControleJogada] == 1)
                    {
                        pcbVerde.Image = Properties.Resources.verdeAceso1;
                    }
                    else if (vetorRodadas[lngControleJogada] == 2)
                    {
                        pcbVermelho.Image = Properties.Resources.vermelhoAceso1;
                    }
                    else if (vetorRodadas[lngControleJogada] == 3)
                    {
                        pcbAzul.Image = Properties.Resources.azulAceso1;
                    }
                    else if (vetorRodadas[lngControleJogada] == 4)
                    {
                        pcbAmarelo.Image = Properties.Resources.amareloAceso1;
                    }
                    blnAcende = false;
                    lngControleJogada++;
                }
                else
                {
                    pcbVerde.Image = Properties.Resources.verde1;
                    pcbVermelho.Image = Properties.Resources.vermelho1;
                    pcbAzul.Image = Properties.Resources.azul1;
                    pcbAmarelo.Image = Properties.Resources.amarelo1;
                    blnAcende = true;
                }

            }
            else
            {
                pcbVerde.Image = Properties.Resources.verde1;
                pcbVermelho.Image = Properties.Resources.vermelho1;
                pcbAzul.Image = Properties.Resources.azul1;
                pcbAmarelo.Image = Properties.Resources.amarelo1;
                tmrPcb.Enabled = false;
                blnAcende = true;
                lngControleJogada = 0;
                habilitarJogada();
            }
        }


        private void pcbVerde_Click(object sender, EventArgs e)
        {
            ValidarJogada(1);
        }

        private void pcbVermelho_Click(object sender, EventArgs e)
        {
            ValidarJogada(2);
        }

        private void pcbAzul_Click(object sender, EventArgs e)
        {
            ValidarJogada(3);
        }

        private void pcbAmarelo_Click(object sender, EventArgs e)
        {
            ValidarJogada(4);
        }

        public void ValidarJogada(int Valor)
        {
          

            if (lngControleJogada <= qtdeJogadas)
            {

                if (vetorRodadas[lngControleJogada] != Valor)
                {
                    desabilitarJogada();
                    gameOver();
                }
                else {
                    lngPontuação += 100;
                    lngControleJogada++;
                  if(qtdeJogadas >vetorRodadas.Length - 1)
                    {
                        MessageBox.Show("Você Ganhou","Genius é da Estrela ! ! !",MessageBoxButtons.OK,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
                    } 
                }
                lblPontuacao.Text = lngPontuação.ToString();

                if (lngControleJogada > qtdeJogadas) {
                    tmrPcb.Interval = Tempo;
                    desabilitarJogada();
                    qtdeJogadas++;
                    lngControleJogada = 0;
                    tmrPcb.Enabled = true;
                    desabilitarJogada();
                }
            } 
        }
        public void habilitarJogada()
        {
            pcbAmarelo.Enabled = true;
            pcbAzul.Enabled = true;
            pcbVerde.Enabled = true;
            pcbVermelho.Enabled = true;
        }
        public void gameOver()
        {
            MessageBox.Show("Você errou a sequencia do GENIUS, clique em iniciar jogo, para uma nova tentativa!!!","Genius é da Estrela",MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            pcbAmarelo.Enabled = false;
            pcbAzul.Enabled = false;
            pcbVermelho.Enabled = false;
            pcbVerde.Enabled = false;
            btnIniciarJogo.Enabled = true;
            btnVoltar.Enabled = true;
        }
        public void desabilitarJogada()
        {
            pcbAmarelo.Enabled = false;
            pcbAzul.Enabled = false;
            pcbVerde.Enabled = false;
            pcbVermelho.Enabled = false;
        }
    }
}

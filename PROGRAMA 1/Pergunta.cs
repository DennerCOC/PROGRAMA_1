using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROGRAMA_1
{
    public partial class Pergunta : Form
    {
        int x = 0;
        public Pergunta()
        {
            InitializeComponent();
        }

        private void Iniciação_Click(object sender, EventArgs e)
        {
            Iniciação.BackColor = Color.Blue;
            Planejamento.Enabled = false;
            Execução.Enabled = false;
            Monitoramento.Enabled = false;
            Finalização.Enabled = false;

            if(label2.Text == "Pergunta 1")
            {
                x = x + 1;
            }
            
        }

        private void Planejamento_Click(object sender, EventArgs e)
        {
            Iniciação.Enabled = false;
            Planejamento.BackColor = Color.Blue;
            Execução.Enabled = false;
            Monitoramento.Enabled = false;
            Finalização.Enabled = false;

            if (label2.Text == "Pergunta 4")
            {
                x = x + 1;
            }
        }

        private void Execução_Click(object sender, EventArgs e)
        {
            Iniciação.Enabled = false;
            Planejamento.Enabled = false;
            Execução.BackColor = Color.Blue;
            Monitoramento.Enabled = false;
            Finalização.Enabled = false;

            if (label2.Text == "Pergunta 2")
            {
                x = x + 1;
            }
        }

        private void Monitoramento_Click(object sender, EventArgs e)
        {
            Iniciação.Enabled = false;
            Planejamento.Enabled = false;
            Execução.Enabled = false;
            Monitoramento.BackColor = Color.Blue;
            Finalização.Enabled = false;

            if (label2.Text == "Pergunta 5")
            {
                x = x + 1;
            }
        }

        private void Finalização_Click(object sender, EventArgs e)
        {
            Iniciação.Enabled = false;
            Planejamento.Enabled = false;
            Execução.Enabled = false;
            Monitoramento.Enabled = false;
            Finalização.BackColor = Color.Blue;

            if (label2.Text == "Pergunta 3")
            {
                x = x + 1;
            }
        }

        private void Questão_Click(object sender, EventArgs e)
        {
            if (Questão.Text == "Refazer o teste")
            {
                var frmForm1 = new Form1();
                frmForm1.Show();
            }

            Iniciação.BackColor = Color.White;
            Planejamento.BackColor = Color.White;
            Execução.BackColor = Color.White;
            Monitoramento.BackColor = Color.White;
            Finalização.BackColor = Color.White;
            Iniciação.Enabled = true;
            Planejamento.Enabled = true;
            Execução.Enabled = true;
            Monitoramento.Enabled = true;
            Finalização.Enabled = true;

            if (label2.Text == "Pergunta 1")
            {
                label2.Text = "Pergunta 2";
                label1.Text = "É constituído por um conjunto de processos\n que desenvolvem o trabalho definido no plano de gerenciamento do projeto\n com o objetivo de obter êxito na satisfação das especificações do mesmo.";
            }
            else if (label2.Text == "Pergunta 2")
            {
                label2.Text = "Pergunta 3";
                label1.Text = "Contém um conjunto de processos que serão executados\n para finalizar todas as atividades de todos os grupos de processos,\n com o objetivo de encerrar formalmente o projeto.";
            }
            else if (label2.Text == "Pergunta 3")
            {
                label2.Text = "Pergunta 4";
                label1.Text = "Engloba um conjunto de processos que realizam o detalhamento\n de tudo aquilo que será realizado através do projeto,\n incluindo escopo, cronogramas, custos, riscos, etc.";
            }
            else if (label2.Text == "Pergunta 4")
            {
                label2.Text = "Pergunta 5";
                label1.Text = "Possui um conjunto de processos utilizados para acompanhar,\n revisar e controlar o progresso e o desempenho do projeto,\n realizando a identificação de todas as áreas afetadas pelas mudanças\n no plano e então iniciar as mudanças se necessário.";
            }
            else if (label2.Text == "Pergunta 5" && Questão.Text != "Refazer o teste")
            {
                if (x == 5)
                {
                    MessageBox.Show("PARABÉNS\n VOCÊ ACERTOU TODAS AS QUESTÕES");
                    Questão.Text = "Refazer o teste";
                }
                else
                    MessageBox.Show("Xii... você errou alguma questão\n Estude um pouco mais e volte a realizar o teste");
                Questão.Text = "Refazer o teste";
            }
            }
    }
    }


﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcIR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Label[] Salario = new Label[] { lbSalario0, lbSalario1, lbSalario2 };
            Label[] Outros = new Label[] { lbOutros0, lbOutros1, lbOutros2 };
            Label[] INSS = new Label[] { lbINSS0, lbINSS1, lbINSS2 };
            Label[] IRFF = new Label[] { lbIRFF0, lbIRFF1, lbIRFF2 };
            Label[] Total = new Label[] { lbTotal0, lbTotal1, lbTotal2 };
            Label[][] tabela = new Label[][] {Salario, Outros, INSS, IRFF, Total};
            string salarioBruto = txtSalarioB.Text;
            string descontos = txtDescontos.Text;
            string dependentes = nmrDependentes.Text;
            Calcular calculo = new Calcular(salarioBruto, descontos, dependentes);
            string[][] dados = new string[][] { calculo.SalarioBruto, calculo.Outros, calculo.INSS, calculo.IRRF, calculo.Totais };
            for (int i = 0; i<tabela.Length; i++)
            {
                for(int j = 0; j < tabela[i].Length; j++)
                {
                    tabela[i][j].Text = dados[i][j];
                }
            }
            lbSalarioLiquido.Text = calculo.SalarioLiquido;

        }
    }
}

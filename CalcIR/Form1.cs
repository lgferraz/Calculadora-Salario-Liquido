using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            Conexao.Conectar();
            string sql = "SELECT * FROM SALARIOS";
            dataResultado.DataSource = Salarios.Selecionar(sql);
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
            string dependentes = nmrcDependentes.Text;
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

        private void button2_Click(object sender, EventArgs e)
        {
            Conexao.Conectar();
            string salarioBruto = txtSalarioB.Text;
            string descontos = txtDescontos.Text;
            string dependentes = nmrcDependentes.Text;
            Calcular calculo = new Calcular(salarioBruto, descontos, dependentes);
            Salarios.Inserir(txtNome.Text, salarioBruto, descontos, dependentes, calculo.INSS[2], calculo.IRRF[2], calculo.SalarioLiquido);
            string sql = "SELECT * FROM SALARIOS";
            dataResultado.DataSource = Salarios.Selecionar(sql);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string valor = txtFiltro.Text;
            string filtro = comboFiltro.Text;
            string query = $"SELECT * FROM SALARIOS WHERE {filtro} = '%{valor}%'";
            Conexao.Conectar();
            dataResultado.DataSource = Salarios.Selecionar(query);

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}

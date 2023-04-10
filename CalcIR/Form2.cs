using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM INSS";
            dataINSS.DataSource = Salarios.Selecionar(sql);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Conexao.Conectar();
            string ano = nmrcAno.Text;
            string faixa = nmrcFaixa.Text;
            string de = txtDe.Text;
            string ate = txtAte.Text;
            string aliquota = txtAliquota.Text;
            string a_deduzir = txtADeduzir.Text;
            INSS.Inserir(faixa, de, ate, aliquota, a_deduzir, ano);
            string sql = "SELECT * FROM INSS";
            dataINSS.DataSource = Salarios.Selecionar(sql);
        }

        private void tabINSS_Click(object sender, EventArgs e)
        {
        }
    }
}

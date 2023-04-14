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

        public void inssGrid()
        {
            Conexao.Conectar();
            string sql = "SELECT * FROM INSS";
            dataINSS.DataSource = Salarios.Selecionar(sql);
        }

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
            ClassINSS.Inserir(faixa, de, ate, aliquota, a_deduzir, ano);
            inssGrid();
        }

        private void tabINSS_Click(object sender, EventArgs e)
        {
        }

        private void dataINSS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nmrcAno.Text = dataINSS.CurrentRow.Cells[5].Value.ToString();
            nmrcFaixa.Text = dataINSS.CurrentRow.Cells[1].Value.ToString();
            txtDe.Text = dataINSS.CurrentRow.Cells[2].Value.ToString();
            txtAte.Text = dataINSS.CurrentRow.Cells[3].Value.ToString();
            txtAliquota.Text = dataINSS.CurrentRow.Cells[4].Value.ToString();
            txtADeduzir.Text = dataINSS.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Conexao.Conectar();
            string id = dataINSS.CurrentRow.Cells[0].Value.ToString();
            string ano = nmrcAno.Text;
            string faixa = nmrcFaixa.Text;
            string de = txtDe.Text;
            string ate = txtAte.Text;
            string aliquota = txtAliquota.Text;
            string a_deduzir = txtADeduzir.Text;
            ClassINSS.Atualizar(id, faixa, de, ate, aliquota, a_deduzir, ano);
            inssGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Conexao.Conectar();
            string id = dataINSS.CurrentRow.Cells[0].Value.ToString();
            ClassINSS.Excluir(id);
            inssGrid();
        }
    }
}

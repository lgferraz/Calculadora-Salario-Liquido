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
    public partial class Home : Form
    {
        Button btnAtual;
        Form formAtual;
        public Home()
        {
            InitializeComponent();
        }
        void abrirForm(Form formSelecionado, Object btnSender)
        {
            if (formAtual != null)
            {
                formAtual.Close();
            }
            ativarBtn(btnSender);
            formAtual = formSelecionado;
            formSelecionado.TopLevel = false;
            formSelecionado.FormBorderStyle = FormBorderStyle.None;
            formSelecionado.Dock = DockStyle.Fill;
            this.pnCentro.Controls.Add(formSelecionado);
            this.pnCentro.Tag = formSelecionado;
            formSelecionado.BringToFront();
            formSelecionado.Show();
            btnFecharForm.Visible = true;
        }
        void desativarBtn()
       {
            foreach (Control btnant in pnMenu.Controls)
            {
                if (btnant.GetType() == typeof(Button))
                {
                    btnant.BackColor = Color.DarkViolet;
                }
            }
        }
        void ativarBtn(Object btnSender)
        {
            if (btnSender != null)
            {
                if (btnAtual != btnSender)
                {
                    desativarBtn();
                    btnAtual = (Button)btnSender;
                    btnAtual.BackColor = Color.MediumVioletRed;
                }
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            abrirForm(new Inicial(), sender);
        }

        private void btnTabelaINSS_Click(object sender, EventArgs e)
        {

        }

        private void btnTabelaIRRF_Click(object sender, EventArgs e)
        {
            abrirForm(new EditorDeTabelas(), sender);
        }

        private void btnCadastrarUsuarios_Click(object sender, EventArgs e)
        {
            ativarBtn(sender);
        }

        private void btnFecharForm_Click(object sender, EventArgs e)
        {
            if(formAtual != null)
            {
                formAtual.Close();
                desativarBtn();
                btnFecharForm.Visible = false;
            }

        }
    }
}

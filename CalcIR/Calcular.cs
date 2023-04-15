using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcIR
{
    
    internal class Calcular
    {
        public string[] SalarioBruto, Outros, INSS, IRRF, Totais;
        public string Ano, SalarioLiquido;

        public Calcular(string ano, string salarioBruto, string descontos, string dependentes)
        {
            this.Ano = ano;
            this.SalarioBruto = new string[] {"00", salarioBruto, "00" };
            this.Outros = new string[] { "00", "00", descontos };
            this.INSS = new string[] {"00", "00", "00" };
            this.IRRF = new string[] { "00", "00", dependentes };
            this.Totais = new string[] { "00", "00", "00" };
            this.Main();
        }
        private void inss()
        {
            Conexao.Conectar();
            string sql = $"SELECT * FROM INSS WHERE ANO = {this.Ano}";
            DataTable dt = ClassINSS.Selecionar(sql);
            double ate_01 = double.Parse(dt.Rows[0]["ATE"].ToString());
            double de_01 = double.Parse(dt.Rows[0]["DE"].ToString());
            double aliquota_01 = double.Parse(dt.Rows[0]["ALIQUOTA"].ToString());
            double ate_02 = double.Parse(dt.Rows[1]["ATE"].ToString());
            double de_02 = double.Parse(dt.Rows[1]["DE"].ToString());
            double aliquota_02 = double.Parse(dt.Rows[1]["ALIQUOTA"].ToString());
            double ate_03 = double.Parse(dt.Rows[2]["ATE"].ToString());
            double de_03 = double.Parse(dt.Rows[2]["DE"].ToString());
            double aliquota_03 = double.Parse(dt.Rows[2]["ALIQUOTA"].ToString());
            double ate_04 = double.Parse(dt.Rows[3]["ATE"].ToString());
            double de_04 = double.Parse(dt.Rows[3]["DE"].ToString());
            double aliquota_04 = double.Parse(dt.Rows[3]["ALIQUOTA"].ToString());

            double slBruto = double.Parse(this.SalarioBruto[1]);
            double vlInss = 0;
            if (slBruto <= ate_01)
            {
                vlInss = (slBruto * aliquota_01 / 100);
            }
            else if (slBruto <= ate_02)
            {
                vlInss = ((slBruto - ate_02) * aliquota_02 / 100) + (ate_01 * aliquota_01 / 100);
            }
            else if (slBruto <= ate_03)
            {
                vlInss = ((slBruto - ate_03) * aliquota_03 / 100) + ((ate_02 - ate_01) * aliquota_02 / 100) + (ate_01 * aliquota_01 / 100);
            }
            else if (slBruto <= ate_04)
            {
                vlInss = ((slBruto - ate_04) * aliquota_04 / 100) + ((ate_03 - ate_02) * aliquota_03 / 100) + ((ate_02 - ate_01) * aliquota_02 / 100) + (ate_01 * aliquota_01 / 100);
            }
            else
            {
                vlInss = ((ate_04 - ate_03) * aliquota_04 / 100) + ((ate_03 - ate_02) * aliquota_03 / 100) + ((ate_02 - ate_01) * aliquota_02 / 100) + (ate_01 * aliquota_01 / 100);
            }

            double salarioL = slBruto - vlInss;
            double porcDesc = vlInss / slBruto * 100;
            this.SalarioLiquido = salarioL.ToString();
            this.INSS[0] = porcDesc.ToString("F") +"%";
            this.INSS[2] = vlInss.ToString("F");
        }

        private void irrf()
        {
            double vIrrf = 0;
            //- (189.59 * int.Parse(this.IRRF[2]) 
            double salarioL = double.Parse(this.SalarioLiquido) - double.Parse(this.Outros[2]);
            double vDependentes = ((189.59 * int.Parse(this.IRRF[2])));
            if (salarioL < 1903.98)
            {
                vIrrf = 0;
                vDependentes = 0;
            }
            else if (salarioL >= 1903.98 && salarioL < 2826.65)
            {
                vIrrf = (salarioL * 7.5 / 100) - 142.8;
                vDependentes = (vDependentes * (7.5 / 100));
            }
            else if (salarioL >= 2826.65 && salarioL < 3751.05)
            {
                vIrrf = (salarioL * 15 / 100) - 354.8;
                vDependentes = (vDependentes * (15 / 100));
            }
            else if (salarioL >= 3751.05 && salarioL < 4664.68)
            {
                vIrrf = (salarioL * (22.5 / 100)) - 636.13;
                vDependentes = (vDependentes * (22.5 / 100));
            }
            else if (salarioL >= 4664.68)
            {
                vIrrf = (salarioL * 27.5 / 100) - 869.36;
                vDependentes = (vDependentes * (27.5 / 100));
            }
            
            vIrrf = vIrrf-vDependentes;
            this.IRRF[0] = (vIrrf / salarioL*100).ToString("F")+"%";
            this.IRRF[2] = vIrrf.ToString("F");
            this.SalarioLiquido = (salarioL - vIrrf).ToString("F");
        }
        public void Main()
        {
            this.inss();
            this.irrf();
            this.Totais[1] = (double.Parse(this.SalarioBruto[1])).ToString("F");
            this.Totais[2] = (double.Parse(this.Outros[2]) + double.Parse(this.INSS[2]) + double.Parse(this.IRRF[2])).ToString("F");
        }
    }
}

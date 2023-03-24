using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcIR
{
    
    internal class Calcular
    {
        public string[] SalarioBruto, Outros, INSS, IRRF, Totais;
        public string SalarioLiquido;

        public Calcular(string salarioBruto, string descontos, string dependentes)
        {
            this.SalarioBruto = new string[] {"00", salarioBruto, "00" };
            this.Outros = new string[] { "00", "00", descontos };
            this.INSS = new string[] {"00", "00", "00" };
            this.IRRF = new string[] { "00", "00", dependentes };
            this.Totais = new string[] { "00", "00", "00" };
            this.main();
        }
        private void inss()
        {
            double slBruto = double.Parse(this.SalarioBruto[1]);
            double vlInss = 0;
            if (slBruto <= 1302.00)
            {
                vlInss = (slBruto * 7.5 / 100);
            }
            else if (slBruto <= 2571.29)
            {
                vlInss = ((slBruto - 1302.00) * 9 / 100) + (1302.00 * 7.5 / 100);
            }
            else if (slBruto <= 3856.94)
            {
                vlInss = ((slBruto - 2571.29) * 12 / 100) + ((2571.29 - 1302.00) * 9 / 100) + (1302.00 * 7.5 / 100);
            }
            else if (slBruto <= 7507.49)
            {
                vlInss = ((slBruto - 3856.94) * 14 / 100) + ((3856.94 - 2571.29) * 12 / 100) + ((2571.29 - 1302.00) * 9 / 100) + (1302.00 * 7.5 / 100);
            }
            else
            {
                vlInss = ((7507.49 - 3856.94) * 14 / 100) + ((3856.94 - 2571.29) * 12 / 100) + ((2571.29 - 1302.00) * 9 / 100) + (1302.00 * 7.5 / 100);
            }

            double salarioL = slBruto - vlInss;
            double porcDesc = vlInss / slBruto * 100;
            this.SalarioLiquido = salarioL.ToString("F");
            this.INSS[0] = porcDesc.ToString("F") +"%";
            this.INSS[2] = vlInss.ToString("F");
        }

        private void irrf()
        {
            double vIrrf = 0;
            //- (189.59 * int.Parse(this.IRRF[2]) 
            double salarioL = double.Parse(this.SalarioLiquido) - double.Parse(this.Outros[2]);
            string aliquota = "00";

            if (salarioL < 1903.98)
            {
                //
            }
            else if (salarioL > 1903.98 && salarioL < 2826.65)
            {
                aliquota = "7.5%";
                vIrrf = (salarioL * 7.5 / 100) - 142.8;
            }
            else if (salarioL > 2826.65 && salarioL < 3751.05)
            {
                aliquota = "15%";
                vIrrf = (salarioL * 15 / 100) - 354.8;
            }
            else if (salarioL > 3751.05 && salarioL < 4664.68)
            {
                aliquota = "22.5%";
                vIrrf = (salarioL * 22.5 / 100) - 636.13;
            }
            else if (salarioL > 4664.68)
            {
                aliquota = "27.5%";
                vIrrf = (salarioL * 27.5 / 100) - 869.36;
            }
            this.IRRF[0] = (vIrrf / salarioL*100).ToString("F")+"%";
            this.IRRF[2] = vIrrf.ToString("F");
            this.SalarioLiquido = (salarioL - vIrrf).ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"));
        }
        public void main()
        {
            this.inss();
            this.irrf();
            this.Totais[1] = (double.Parse(this.SalarioBruto[1])).ToString("F");
            this.Totais[2] = (double.Parse(this.Outros[2]) + double.Parse(this.INSS[2]) + double.Parse(this.IRRF[2])).ToString("F");
        }
    }
}

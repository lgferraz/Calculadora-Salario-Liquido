using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcIR
{
    
    internal class Calcular
    {
        private string[] SalarioBruto, Outros, INSS, IRRF, Totais;

        public Calcular(string salarioBruto, string descontos, string dependentes)
        {
            this.SalarioBruto = new string[] { salarioBruto };
        }
        private string[] inss()
        {
            double slBruto = this.SalarioBruto[0];
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
            string[] r = new string[2] { salarioL.ToString(), porcDesc.ToString() };
            return r;
        }
    }
}

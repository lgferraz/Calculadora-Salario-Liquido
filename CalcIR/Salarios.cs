using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcIR
{
    internal class Salarios
    {
        public static DataTable Selecionar(string query)
        {
            SqlCommand cmd = new SqlCommand(query, Conexao.conn);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
        public static void Inserir(string nome, string salario_bruto, string desconto_outros, string qnt_dependentes, string inss, string irrf, string salario_liquido )
        {
            double sl_bruto = double.Parse(salario_bruto);
            double desconto = double.Parse(desconto_outros);
            int dependentes = int.Parse(qnt_dependentes);
            double inss_ = double.Parse(inss);
            double irrf_ = double.Parse(irrf);
            double sl_liquido = double.Parse(salario_liquido);
            string sql = "INSERT INTO SALARIOS (NOME, SALARIO_BRUTO, DESCONTO_OUTROS, QTD_DEPENDENTES, INSS, IRRF, SALARIO_LIQUIDO) VALUES (@nome, @sl_bruto, @desconto, @dependentes, @inss, @sl_liquido, @irff)";

            SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
            cmd.Parameters.AddWithValue("nome", nome);
            cmd.Parameters.AddWithValue("sl_bruto", sl_bruto);
            cmd.Parameters.AddWithValue("desconto", desconto);
            cmd.Parameters.AddWithValue("dependentes", dependentes);
            cmd.Parameters.AddWithValue("inss", inss_);
            cmd.Parameters.AddWithValue("irff", irrf_);
            cmd.Parameters.AddWithValue("sl_liquido", sl_liquido);
            cmd.ExecuteNonQuery();
        }
    }
}

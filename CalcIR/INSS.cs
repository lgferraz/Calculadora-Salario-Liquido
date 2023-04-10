using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcIR
{
    internal class INSS
    {
        public static DataTable Selecionar(string query)
        {
            SqlCommand cmd = new SqlCommand(query, Conexao.conn);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
        public static void Inserir(string faixa, string de, string ate, string aliquota, string a_deduzir, string ano)
        {
            int id_faixa = int.Parse(faixa);
            double sl_de = double.Parse(de);
            double sl_ate = double.Parse(ate);
            double sl_aliquiota = double.Parse(aliquota);
            double sl_a_deduzir = double.Parse(a_deduzir);
            int inss_ano = int.Parse(ano);
            string sql = "INSERT INTO INSS (ID_FAIXA, DE, ATE, ALIQUOTA, PORC_A_DEDUZIR, ANO) VALUES (@faixa, @de, @ate, @aliquota, @a_deduzir, @ano)";

            SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
            cmd.Parameters.AddWithValue("faixa", id_faixa);
            cmd.Parameters.AddWithValue("de", sl_de);
            cmd.Parameters.AddWithValue("ate", sl_ate);
            cmd.Parameters.AddWithValue("aliquota", sl_aliquiota);
            cmd.Parameters.AddWithValue("a_deduzir", a_deduzir);
            cmd.Parameters.AddWithValue("ano", inss_ano);
            cmd.ExecuteNonQuery();
        }


    }
}

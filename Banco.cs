using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Creche_Maravilha
{
    class Banco
    {
        private static SQLiteConnection conexao;
        private static SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source = "+ Globais.caminhoBanco + Globais.nomeBanco);
            conexao.Open();
            return conexao;
        }

        public static DataTable dql(string sql)
        {
            SQLiteDataAdapter da = null;

            DataTable dt = new DataTable();

            try
            {
                var vcon = ConexaoBanco();

                var cmd = vcon.CreateCommand();

                cmd.CommandText = sql;

                da = new SQLiteDataAdapter(cmd.CommandText,vcon);

                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
                throw ex;
            }
        }

        public static void dml(string sql)
        {
            try
            {
                var vcon = ConexaoBanco();

                var cmd = vcon.CreateCommand();

                cmd.CommandText = sql;

                cmd.ExecuteNonQuery();

                vcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
                return;
            }

        }
    }
    
}

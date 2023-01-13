using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Creche_Maravilha
{
    public partial class Frm_GerirEncarregados : Form
    {
        public Frm_GerirEncarregados()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Frm_GerirEncarregados_Load(object sender, EventArgs e)
        {
            string query = String.Format(@"
                        SELECT 
                                N_IDENCARREGADO as 'Id',
                                T_NOME as 'Nome',
                                T_TELEFONE as 'Telefone',
                                T_EMAIL as 'Email'
                        FROM
                                tb_encarregados
            ");
            dgv_encarregados.DataSource = Banco.dql(query);
            dgv_encarregados.Columns[0].Width = 20;
            dgv_encarregados.Columns[1].Width = 300;
            dgv_encarregados.Columns[2].Width = 200;
            dgv_encarregados.Columns[3].Width = 200;
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            Frm_CadEncarregados frm_CadEncarregados = new Frm_CadEncarregados();
            frm_CadEncarregados.Show();
            this.Close();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            string sql = String.Format(@"
                                            UPDATE
                                                    tb_encarregados
                                            SET
                                                    T_NOME = '{0}',
                                                    T_TELEFONE = '{1}',
                                                    T_EMAIL = '{2}'
                                             WHERE
                                                    N_IDENCARREGADO = {3}
                    
            ", txt_nome.Text, mtxt_telefone.Text, txt_email.Text, txt_id.Text);
            Banco.dml(sql);

            MessageBox.Show("Dados do encarregado actualizado!");
            string query = String.Format(@"
                        SELECT 
                                N_IDENCARREGADO as 'Id',
                                T_NOME as 'Nome',
                                T_TELEFONE as 'Telefone',
                                T_EMAIL as 'Email'
                        FROM
                                tb_encarregados
            ");
            dgv_encarregados.DataSource = Banco.dql(query);
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja apagar registo?", "Continuar?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                String sql = String.Format(@"
                            DELETE FROM
                                        tb_encarregados
                            WHERE
                                        N_IDENCARREGADO ={0}
                ", txt_id.Text);
                Banco.dml(sql);
                MessageBox.Show("Registo apagado!");
                dgv_encarregados.Rows.Remove(dgv_encarregados.CurrentRow);
            }
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {

        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_encarregados_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv.SelectedRows.Count > 0)
            {
                string id = dgv.SelectedRows[0].Cells[0].Value.ToString();

                string sql = String.Format(@"
                            SELECT 
                                    *
                            FROM
                                    tb_encarregados
                            WHERE
                                    N_IDENCARREGADO = {0}
                ", id);

                DataTable dt = new DataTable();

                dt = Banco.dql(sql);

                txt_id.Text = dt.Rows[0].Field<Int64>("N_IDENCARREGADO").ToString();
                txt_nome.Text = dt.Rows[0].Field<string>("T_NOME");
                mtxt_telefone.Text = dt.Rows[0].Field<string>("T_TELEFONE");
                txt_email.Text = dt.Rows[0].Field<string>("T_EMAIL");
            }
        }
    }
}

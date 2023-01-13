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
    public partial class Frm_CadEncarregados : Form
    {
        public Frm_CadEncarregados()
        {
            InitializeComponent();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            txt_nome.Text = "Digite o nome do encarregado";
            txt_email.Text = "Digite o email do encarregado";
            mtxt_telefone.Clear();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {

            if (txt_nome.Text == "" || txt_nome.Text == "Digite o nome do encarregado" || txt_email.Text == "" || txt_email.Text == "Digite o email do encarregado" || mtxt_telefone.Text == "")
            {
                MessageBox.Show("TODOS OS CAMPOS SÃO OBRIGATÓRIOS!");
                return;
            }
            string query = String.Format(@" INSERT 
                                INTO 
                                    tb_encarregados
                                (
                                  T_NOME,
                                   T_TELEFONE,
                                   T_EMAIL
                                )
                            VALUES ('{0}','{1}','{2}')
         ", txt_nome.Text, mtxt_telefone.Text, txt_email.Text);

            Banco.dml(query);
            MessageBox.Show("Encarregado Cadastrado!");
        }

        private void btn_gerir_Click(object sender, EventArgs e)
        {
            Frm_GerirEncarregados frm_GerirEncarregados = new Frm_GerirEncarregados();
            frm_GerirEncarregados.Show();
            this.Close();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

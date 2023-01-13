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
    public partial class Form1 : Form
    {
        Form form2;

        DataTable dt = new DataTable();
        public Form1()
        {
            
            InitializeComponent();
         
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string senha = txt_senha.Text;

            if (username=="" || senha=="")
            {
                MessageBox.Show("Usuário ou senha inválidos!");
                return;
            }
            string sql = "SELECT * FROM tb_usuarios WHERE T_USERNAME = '" + username + "' AND T_SENHA = '" + senha + "'";

            dt = Banco.dql(sql);

            string query = String.Format(@"
                               SELECT
                                   T_USERNAME,
                                   T_SENHA,
                                   T_NOME,
                                   N_NIVEL
                               FROM
                                   tb_usuarios
                       ");
            if (dt.Rows.Count == 1)
            {
                dt = Banco.dql(query);
                Globais.nome = dt.Rows[0].Field<string>("T_NOME");
                Globais.nivel = Convert.ToInt32(dt.Rows[0].Field<Int64>("N_NIVEL"));

                MessageBox.Show("Seja Bem-vindo "+Globais.nome);
                Frm_Menu frm_Menu = new Frm_Menu(this);
                frm_Menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nome de usuário ou senha incorreta!");
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

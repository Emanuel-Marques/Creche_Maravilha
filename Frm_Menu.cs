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
    public partial class Frm_Menu : Form
    {
        Form1 form1;
        public Frm_Menu(Form1 f)
        {
            InitializeComponent();
            form1 = f;
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
            form1.Show();
        }

        private void btn_professores_Click(object sender, EventArgs e)
        {
            Frm_CadProfessor frm_CadProfessor = new Frm_CadProfessor();
            frm_CadProfessor.Show();
        }

        private void btn_encarregados_Click(object sender, EventArgs e)
        {
            Frm_CadEncarregados frm_CadEncarregados = new Frm_CadEncarregados();
            frm_CadEncarregados.Show();
        }

        private void btn_pre_inscricoes_Click(object sender, EventArgs e)
        {
            Frm_Pre_Inscricoes frm_Pre_Inscricoes = new Frm_Pre_Inscricoes();
            frm_Pre_Inscricoes.Show();
        }

        private void btn_matricula_Click(object sender, EventArgs e)
        {
            Frm_matricula frm_Matricula = new Frm_matricula();
            frm_Matricula.Show();
        }

        private void btn_turmas_Click(object sender, EventArgs e)
        {
            Frm_Turmas frm_Turmas = new Frm_Turmas();
            frm_Turmas.Show();
        }

        private void btn_gestao_Click(object sender, EventArgs e)
        {
            Frm_gestaoUtilizadores frm_GestaoUtilizadores = new Frm_gestaoUtilizadores();
            frm_GestaoUtilizadores.Show();
        }
    }
}

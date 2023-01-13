using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Creche_Maravilha
{
    public partial class Frm_CadProfessor : Form
    {
        string origemCompleto = "";
        string foto = "";
        string pastaDestino = Globais.caminhoFotos;
        string destinoCompleto = "";
        public Frm_CadProfessor()
        {
            InitializeComponent();
        }

        private void btn_carregar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                origemCompleto = openFileDialog1.FileName;
                foto = openFileDialog1.SafeFileName;
                destinoCompleto = pastaDestino + Globais.FotosFuncionarios + foto;
            }
            if (File.Exists(destinoCompleto))
            {
                if (MessageBox.Show("Arquivo já existe, deseja sobrescrever?", "Substituir?", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }
            pb_foto.ImageLocation = origemCompleto;
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pb_foto_Click(object sender, EventArgs e)
        {

        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void txt_morada_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (txt_nome.Text == "" || txt_nome.Text == "Digite o nome do professor" || mtxt_data.Text == "" || txt_morada.Text == "" || txt_morada.Text == "Digite o endereço do professor" || mtxt_telefone.Text == "")
            {
                MessageBox.Show("TODOS OS CAMPOS SÃO OBRIGATÓRIOS!");
                return;
            }
            if (destinoCompleto == "")
            {
                if (MessageBox.Show("Sem foto selecionada, deseja continuar ?", "Continuar?", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }
            if (destinoCompleto != "")
            {
                System.IO.File.Copy(origemCompleto, destinoCompleto, true);
                if (File.Exists(destinoCompleto))
                {
                    pb_foto.ImageLocation = destinoCompleto;
                }
                else
                {
                    if (MessageBox.Show("ERRO ao localizar a imagem, deseja continuar ?", "Continuar?", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                }
            }

            string query = String.Format(@" INSERT 
                                INTO 
                                    tb_professores
                                (
                                  T_NOMEPROFESSOR,
                                   T_DATANASCIMENTO,
                                    T_MORADA,
                                    T_TELEFONE,
                                    T_FOTO
                                )
                            VALUES ('{0}','{1}','{2}','{3}','{4}')
         ", txt_nome.Text, mtxt_data.Text, txt_morada.Text, mtxt_telefone.Text, destinoCompleto);

            Banco.dml(query);
            MessageBox.Show("Funcionário Cadastrado!");


        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            txt_nome.Text = "Digite o nome do professor";
            mtxt_data.Clear();
            txt_morada.Text = "Digite o endereço do professor";
            mtxt_telefone.Clear();

        }

        private void btn_gerir_Click(object sender, EventArgs e)
        {
            Frm_Gestao_Professores frm_Gestao_Professores = new Frm_Gestao_Professores();
            frm_Gestao_Professores.Show();
            this.Close();
        }
    }
}

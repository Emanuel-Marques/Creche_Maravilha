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
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Creche_Maravilha
{
    public partial class Frm_Gestao_Professores : Form
    {
        string origemCompleto = "";
        string foto = "";
        string pastaDestino = Globais.caminhoFotos;
        string destinoCompleto = "";
        string imagemAntiga = "";

        public Frm_Gestao_Professores()
        {
            InitializeComponent();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            Frm_CadProfessor frm_CadProfessor = new Frm_CadProfessor();
            frm_CadProfessor.Show();
            this.Close();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Gestao_Professores_Load(object sender, EventArgs e)
        {
            string query = String.Format(@"
                        SELECT 
                                N_IDPROFESSOR as 'Id',
                                T_NOMEPROFESSOR as 'Nome',
                                T_DATANASCIMENTO as 'Data de nascimento',
                                T_MORADA as 'Endereço',
                                T_TELEFONE as 'Telefone',
                                T_GRUPO as 'Grupo'
                        FROM
                                tb_professores
            ");
            dgv_professores.DataSource = Banco.dql(query);
            dgv_professores.Columns[0].Width = 20;
            dgv_professores.Columns[1].Width = 200;
            dgv_professores.Columns[2].Width = 150;
            dgv_professores.Columns[3].Width = 200;
            dgv_professores.Columns[4].Width = 150;
            dgv_professores.Columns[5].Width = 100;
        }

        private void dgv_professores_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv.SelectedRows.Count > 0)
            {
                string id = dgv.SelectedRows[0].Cells[0].Value.ToString();

                string sql = String.Format(@"
                            SELECT 
                                    *
                            FROM
                                    tb_professores
                            WHERE
                                    N_IDPROFESSOR = {0}
                ", id);

                DataTable dt = new DataTable();

                dt = Banco.dql(sql);

                txt_id.Text = dt.Rows[0].Field<Int64>("N_IDPROFESSOR").ToString();
                txt_nome.Text = dt.Rows[0].Field<string>("T_NOMEPROFESSOR");
                mtxt_data.Text = dt.Rows[0].Field<string>("T_DATANASCIMENTO");
                txt_morada.Text = dt.Rows[0].Field<string>("T_MORADA");
                mtxt_telefone.Text = dt.Rows[0].Field<string>("T_TELEFONE");
                txt_grupo.Text = dt.Rows[0].Field<string>("T_GRUPO");
                if (dt.Rows[0].Field<string>("T_FOTO") == "")
                {
                    imagemAntiga = "";
                    MessageBox.Show("Adicione uma foto no professor selecionado!");
                }
                else
                {
                    pb_foto.ImageLocation = dt.Rows[0].Field<string>("T_FOTO");
                    imagemAntiga = dt.Rows[0].Field<string>("T_FOTO");
                }
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja apagar registo?", "Continuar?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                String sql = String.Format(@"
                            DELETE FROM
                                        tb_professores
                            WHERE
                                        N_IDPROFESSOR ={0}
                ", txt_id.Text);
                Banco.dml(sql);
                MessageBox.Show("Registo apagado!");
                dgv_professores.Rows.Remove(dgv_professores.CurrentRow);
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (destinoCompleto != "")
            {
                System.IO.File.Copy(origemCompleto, destinoCompleto, true);
                if (imagemAntiga != destinoCompleto)
                {
                    System.IO.File.Delete(imagemAntiga);
                }

                if (File.Exists(destinoCompleto))
                {
                    pb_foto.ImageLocation = destinoCompleto;
                }
                else
                {
                    if (MessageBox.Show("ERRO ao localizar a imagem, deseja continuar?", "ERRO", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                }
            }
            else
            {
                destinoCompleto = imagemAntiga;
            }

            string sql = String.Format(@"
                                            UPDATE
                                                    tb_professores
                                            SET
                                                    T_NOMEPROFESSOR = '{0}',
                                                    T_DATANASCIMENTO = '{1}',
                                                    T_MORADA = '{2}',
                                                    T_TELEFONE = '{3}',
                                                    T_GRUPO = '{4}',
                                                    T_FOTO = '{5}'
                                             WHERE
                                                    N_IDPROFESSOR = {6}
                    
            ", txt_nome.Text, mtxt_data.Text, txt_morada.Text, mtxt_telefone.Text, txt_grupo.Text, destinoCompleto, txt_id.Text);
            Banco.dml(sql);
            MessageBox.Show("Dados do funcionário actualizado!");
            string query = String.Format(@"
                        SELECT 
                                N_IDPROFESSOR as 'Id',
                                T_NOMEPROFESSOR as 'Nome',
                                T_DATANASCIMENTO as 'Data de nascimento',
                                T_MORADA as 'Endereço',
                                T_TELEFONE as 'Telefone',
                                T_GRUPO as 'Grupo'
                        FROM
                                tb_professores
            ");
            dgv_professores.DataSource = Banco.dql(query);
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                origemCompleto = openFileDialog1.FileName;
                foto = openFileDialog1.SafeFileName;
                destinoCompleto = pastaDestino + Globais.FotosFuncionarios + foto;
            }
            if (File.Exists(destinoCompleto))
            {
                if (MessageBox.Show("Arquivo já existe, deseja sobrepor ?", "Substituir ?", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }

            }
            pb_foto.ImageLocation = origemCompleto;
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string query = String.Format(@"
                                                SELECT 
                                                       *
                                                FROM
                                                        tb_professores
                                                WHERE
                                                        N_IDPROFESSOR = {0}
                ", txt_id.Text);
                DataTable dtFuncionarios = Banco.dql(query);

             
                string nomeArquivo = saveFileDialog1.FileName.ToString();

               
                FileStream arquivoPDF = new FileStream(nomeArquivo, FileMode.Create);

                Document doc = new Document(PageSize.A4);
                PdfWriter escritorPDF = PdfWriter.GetInstance(doc, arquivoPDF);

                doc.Open();
                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(Globais.caminhoFotos + "logo.png");
                logo.ScaleToFit(135f, 103f);
                logo.Alignment = Element.ALIGN_CENTER;
                doc.Add(logo);

                Paragraph paragrafo = new Paragraph();
                paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 16, (int)System.Drawing.FontStyle.Bold);
                paragrafo.Alignment = Element.ALIGN_CENTER;
                paragrafo.Add("Dados do Professor");
                doc.Add(paragrafo);

                iTextSharp.text.Image borda = iTextSharp.text.Image.GetInstance(Globais.caminhoFotos + "Barra_de_Borda.png");
                borda.ScaleToFit(500f, 22f);
                borda.Alignment = Element.ALIGN_CENTER;
                doc.Add(borda);

                iTextSharp.text.Image imagemFuncionario = iTextSharp.text.Image.GetInstance(dtFuncionarios.Rows[0].Field<string>("T_FOTO"));
                imagemFuncionario.ScaleToFit(154f, 158f);
                imagemFuncionario.Alignment = Element.ALIGN_CENTER;
                doc.Add(imagemFuncionario);


                Paragraph paragrafo2 = new Paragraph();
                paragrafo2.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, (int)System.Drawing.FontStyle.Bold);
                paragrafo2.Alignment = Element.ALIGN_JUSTIFIED;
                paragrafo2.Add("                                    Nome: ");
                paragrafo2.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, (int)System.Drawing.FontStyle.Regular);
                paragrafo2.Add(dtFuncionarios.Rows[0].Field<string>("T_NOMEPROFESSOR"));
                doc.Add(paragrafo2);

                Paragraph paragrafo3 = new Paragraph();
                paragrafo3.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, (int)System.Drawing.FontStyle.Bold);
                paragrafo3.Alignment = Element.ALIGN_JUSTIFIED;
                paragrafo3.Add("                                    Data de Nascimento: ");
                paragrafo3.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, (int)System.Drawing.FontStyle.Regular);
                paragrafo3.Add(dtFuncionarios.Rows[0].Field<string>("T_DATANASCIMENTO"));
                doc.Add(paragrafo3);

                Paragraph paragrafo4 = new Paragraph();
                paragrafo4.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, (int)System.Drawing.FontStyle.Bold);
                paragrafo4.Alignment = Element.ALIGN_JUSTIFIED;
                paragrafo4.Add("                                    Endereço: ");
                paragrafo4.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, (int)System.Drawing.FontStyle.Regular);

                paragrafo4.Add(dtFuncionarios.Rows[0].Field<string>("T_MORADA"));
                doc.Add(paragrafo4);

                Paragraph paragrafo6 = new Paragraph();
                paragrafo6.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, (int)System.Drawing.FontStyle.Bold);
                paragrafo6.Alignment = Element.ALIGN_JUSTIFIED;
                paragrafo6.Add("                                    Telefone : ");
                paragrafo6.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, (int)System.Drawing.FontStyle.Regular);

                paragrafo6.Add(dtFuncionarios.Rows[0].Field<string>("T_TELEFONE"));
                paragrafo6.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, (int)System.Drawing.FontStyle.Bold);
                doc.Add(paragrafo6);

                Paragraph paragrafo5 = new Paragraph();
                paragrafo5.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, (int)System.Drawing.FontStyle.Bold);
                paragrafo5.Alignment = Element.ALIGN_JUSTIFIED;
                paragrafo5.Add("                                    Grupo: ");
                paragrafo5.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, (int)System.Drawing.FontStyle.Regular);

                paragrafo5.Add(dtFuncionarios.Rows[0].Field<string>("T_GRUPO"));
                paragrafo5.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, (int)System.Drawing.FontStyle.Bold);
                doc.Add(paragrafo5);

                doc.Add(borda);

                Paragraph paragrafo9 = new Paragraph();
                paragrafo9.Alignment = Element.ALIGN_RIGHT;
                paragrafo9.Add(DateTime.Now.ToString());
                doc.Add(paragrafo9);

                doc.Close();

            }
        }
    }
}

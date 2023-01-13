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
    public partial class Frm_matricula : Form
    {
        string origemCompleto = "";
        string foto = "";
        string pastaDestino = Globais.caminhoFotos;
        string destinoCompleto = "";
        string imagemAntiga = "";
        public Frm_matricula()
        {
            InitializeComponent();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_matricula_Load(object sender, EventArgs e)
        {
            string query = String.Format(@"
                        SELECT 
                                tba.N_IDALUNO as 'Id',
                                tba.T_NOMEALUNO as 'Nome',
                                tba.T_DATANASCIMENTO as 'Data de nascimento',
                                tba.T_MORADA as 'Endereço',
                                tba.T_GENERO as 'Gênero',
                                tbe.T_NOME as 'Nome do Encarregado',
                                tba.T_ESTADO as 'Estado',
                                tba.T_GRUPO as 'Grupo'
                        FROM
                                tb_alunos as tba
                        INNER JOIN 
                                tb_encarregados as tbe on tbe.N_IDENCARREGADO = tbe.N_IDENCARREGADO
                        
            ");
            dgv_alunos.DataSource = Banco.dql(query);
            dgv_alunos.Columns[0].Width = 20;
            dgv_alunos.Columns[1].Width = 200;
            dgv_alunos.Columns[2].Width = 150;
            dgv_alunos.Columns[3].Width = 200;
            dgv_alunos.Columns[4].Width = 150;
            dgv_alunos.Columns[5].Width = 100;
            dgv_alunos.Columns[6].Width = 100;
            dgv_alunos.Columns[7].Width = 100;

            string query2 = @"
                        SELECT 
                                *
                        FROM    
                                tb_encarregados
                        ORDER BY 
                                T_NOME
            ";
            cb_encarregados.Items.Clear();
            cb_encarregados.DataSource = Banco.dql(query2);
            cb_encarregados.DisplayMember = "T_NOME";
            cb_encarregados.ValueMember = "N_IDENCARREGADO";

            Dictionary<string, string> st = new Dictionary<string, string>();
            st.Add("Masculino", "Masculino");
            st.Add("Feminino", "Feminino");
            cb_genero.Items.Clear();
            cb_genero.DataSource = new BindingSource(st, null);
            cb_genero.DisplayMember = "Value";
            cb_genero.ValueMember = "Key";

            Dictionary<string, string> st2 = new Dictionary<string, string>();
            st2.Add("Infantário", "Infantário");
            st2.Add("ATL", "ATL");
            cb_grupo.Items.Clear();
            cb_grupo.DataSource = new BindingSource(st2, null);
            cb_grupo.DisplayMember = "Value";
            cb_grupo.ValueMember = "Key";

            Dictionary<string, string> st3 = new Dictionary<string, string>();
            st3.Add("Lista de Espera", "Lista de Espera");
            st3.Add("Matriculado", "Matriculado");
            cb_estado.Items.Clear();
            cb_estado.DataSource = new BindingSource(st3, null);
            cb_estado.DisplayMember = "Value";
            cb_estado.ValueMember = "Key";
        }

        private void dgv_alunos_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv.SelectedRows.Count > 0)
            {
                string id = dgv.SelectedRows[0].Cells[0].Value.ToString();

                string sql = String.Format(@"
                        SELECT 
                                tba.N_IDALUNO as 'Id',
                                tba.T_NOMEALUNO as 'Nome',
                                tba.T_DATANASCIMENTO as 'Data de nascimento',
                                tba.T_MORADA as 'Endereço',
                                tba.T_GENERO as 'Gênero',
                                tbe.T_NOME as 'Nome do Encarregado',
                                tba.T_ESTADO as 'Estado',
                                tba.T_GRUPO as 'Grupo',
                                tba.T_FOTO
                        FROM
                                tb_alunos as tba
                        INNER JOIN 
                                tb_encarregados as tbe on tbe.N_IDENCARREGADO = tbe.N_IDENCARREGADO
                            WHERE
                                    N_IDALUNO = {0}
                ", id);

                DataTable dt = new DataTable();

                dt = Banco.dql(sql);

                txt_id.Text = dt.Rows[0].Field<Int64>("Id").ToString();
                txt_nome.Text = dt.Rows[0].Field<string>("Nome");
                mtxt_data.Text = dt.Rows[0].Field<string>("Data de nascimento");
                txt_morada.Text = dt.Rows[0].Field<string>("Endereço");
                cb_encarregados.Text = dt.Rows[0].Field<string>("Nome do Encarregado");
                cb_grupo.Text = dt.Rows[0].Field<string>("Grupo");
                cb_genero.Text = dt.Rows[0].Field<string>("Gênero");
                cb_estado.Text = dt.Rows[0].Field<string>("Estado");

                if (dt.Rows[0].Field<string>("T_FOTO") == "")
                {
                    imagemAntiga = "";
                    MessageBox.Show("Adicione uma foto no aluno selecionado!");
                }
                else
                {
                    pb_foto.ImageLocation = dt.Rows[0].Field<string>("T_FOTO");
                    imagemAntiga = dt.Rows[0].Field<string>("T_FOTO");
                }
            }
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            Frm_Pre_Inscricoes frm_Pre_Inscricoes = new Frm_Pre_Inscricoes();
            frm_Pre_Inscricoes.Show();
            this.Close();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (destinoCompleto != "")
            {
                System.IO.File.Copy(origemCompleto, destinoCompleto, true);
                if (imagemAntiga != destinoCompleto)
                {
                    if (imagemAntiga !=null)
                    {
                        System.IO.File.Delete(imagemAntiga);
                    }
                    
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
                                                    tb_alunos
                                            SET
                                                    T_NOMEALUNO = '{0}',
                                                    T_DATANASCIMENTO = '{1}',
                                                    T_MORADA = '{2}',
                                                    T_GENERO = '{3}',
                                                    N_IDENCARREGADO = '{4}',
                                                    T_ESTADO = '{5}',
                                                    T_GRUPO = '{6}',
                                                    T_FOTO = '{7}'
                                             WHERE
                                                    N_IDALUNO = {8}
                    
            ", txt_nome.Text, mtxt_data.Text, txt_morada.Text, cb_genero.SelectedValue,cb_encarregados.SelectedValue, cb_estado.SelectedValue, cb_grupo.SelectedValue, destinoCompleto, txt_id.Text);
            Banco.dml(sql);
            MessageBox.Show("Dados do funcionário actualizado!");

            string query = String.Format(@"
                        SELECT 
                                tba.N_IDALUNO as 'Id',
                                tba.T_NOMEALUNO as 'Nome',
                                tba.T_DATANASCIMENTO as 'Data de nascimento',
                                tba.T_MORADA as 'Endereço',
                                tba.T_GENERO as 'Gênero',
                                tbe.T_NOME as 'Nome do Encarregado',
                                tba.T_ESTADO as 'Estado',
                                tba.T_GRUPO as 'Grupo'
                        FROM
                                tb_alunos as tba
                        INNER JOIN 
                                tb_encarregados as tbe on tbe.N_IDENCARREGADO = tbe.N_IDENCARREGADO
                        
            ");
            dgv_alunos.DataSource = Banco.dql(query);
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja apagar registo?", "Continuar?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                String sql = String.Format(@"
                            DELETE FROM
                                        tb_alunos
                            WHERE
                                        N_IDALUNO ={0}
                ", txt_id.Text);
                Banco.dml(sql);
                MessageBox.Show("Registo apagado!");
                dgv_alunos.Rows.Remove(dgv_alunos.CurrentRow);
            }
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string query = String.Format(@"
                                                SELECT 
                                                        tba.N_IDALUNO,
                                                        tba.T_NOMEALUNO,
                                                        tba.T_DATANASCIMENTO,
                                                        tba.T_MORADA,
                                                        tba.T_GENERO,
                                                        tbe.T_NOME,
                                                        tba.T_ESTADO,
                                                        tba.T_GRUPO,
                                                        tba.T_FOTO
                                                FROM
                                                        tb_alunos as tba
                                                  INNER JOIN 
                                                        tb_encarregados as tbe on tbe.N_IDENCARREGADO = tbe.N_IDENCARREGADO
                                                WHERE
                                                        tba.N_IDALUNO = {0}
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
                paragrafo.Add("Ficha de Matrícula");
                doc.Add(paragrafo);

                iTextSharp.text.Image borda = iTextSharp.text.Image.GetInstance(Globais.caminhoFotos + "Barra_de_Borda.png");
                borda.ScaleToFit(500f, 22f);
                borda.Alignment = Element.ALIGN_CENTER;
                doc.Add(borda);

                iTextSharp.text.Image imagemFuncionario = iTextSharp.text.Image.GetInstance(dtFuncionarios.Rows[0].Field<string>("T_FOTO"));
                imagemFuncionario.ScaleToFit(154f, 158f);
                imagemFuncionario.Alignment = Element.ALIGN_CENTER;
                doc.Add(imagemFuncionario);

                Paragraph paragrafo8 = new Paragraph();
                paragrafo8.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, (int)System.Drawing.FontStyle.Bold);
                paragrafo8.Alignment = Element.ALIGN_JUSTIFIED;
                paragrafo8.Add("                                    Matrícula nº: ");
                paragrafo8.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, (int)System.Drawing.FontStyle.Regular);

                paragrafo8.Add(dtFuncionarios.Rows[0].Field<Int64>("N_IDALUNO").ToString());
                paragrafo8.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, (int)System.Drawing.FontStyle.Bold);
                doc.Add(paragrafo8);

                Paragraph paragrafo2 = new Paragraph();
                paragrafo2.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, (int)System.Drawing.FontStyle.Bold);
                paragrafo2.Alignment = Element.ALIGN_JUSTIFIED;
                paragrafo2.Add("                                    Nome: ");
                paragrafo2.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, (int)System.Drawing.FontStyle.Regular);
                paragrafo2.Add(dtFuncionarios.Rows[0].Field<string>("T_NOMEALUNO"));
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
                paragrafo6.Add("                                    Nome do encarregado : ");
                paragrafo6.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, (int)System.Drawing.FontStyle.Regular);

                paragrafo6.Add(dtFuncionarios.Rows[0].Field<string>("T_NOME"));
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

                Paragraph paragrafo7 = new Paragraph();
                paragrafo7.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, (int)System.Drawing.FontStyle.Bold);
                paragrafo7.Alignment = Element.ALIGN_JUSTIFIED;
                paragrafo7.Add("                                    Estado: ");
                paragrafo7.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, (int)System.Drawing.FontStyle.Regular);

                paragrafo7.Add(dtFuncionarios.Rows[0].Field<string>("T_ESTADO"));
                paragrafo7.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, (int)System.Drawing.FontStyle.Bold);
                doc.Add(paragrafo7);

                doc.Add(borda);

                Paragraph paragrafo9 = new Paragraph();
                paragrafo9.Alignment = Element.ALIGN_RIGHT;
                paragrafo9.Add(DateTime.Now.ToString());
                doc.Add(paragrafo9);

                doc.Close();

            }
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
    }
}

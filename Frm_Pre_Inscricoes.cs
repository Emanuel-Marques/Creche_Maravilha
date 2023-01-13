using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Creche_Maravilha
{
    public partial class Frm_Pre_Inscricoes : Form
    {
        public Frm_Pre_Inscricoes()
        {
            InitializeComponent();
        }

        private void Frm_Pre_Inscricoes_Load(object sender, EventArgs e)
        {
            string query = @"
                        SELECT 
                                *
                        FROM    
                                tb_encarregados
                        ORDER BY 
                                T_NOME
            ";
            cb_encarregados.Items.Clear();
            cb_encarregados.DataSource = Banco.dql(query);
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
            st3.Add("Lista", "Lista de Espera");
            st3.Add("Matriculado", "Matriculado");
            cb_estado.Items.Clear();
            cb_estado.DataSource = new BindingSource(st3, null);
            cb_estado.DisplayMember = "Value";
            cb_estado.ValueMember = "Key";

            cb_encarregados.SelectedIndex = -1;
            cb_estado.SelectedIndex = -1;
            cb_grupo.SelectedIndex = -1;
            cb_genero.SelectedIndex = -1;
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            txt_nome.Clear();
            mtxt_data.Clear();
            txt_morada.Clear();
            cb_encarregados.SelectedIndex = -1;
            cb_estado.SelectedIndex = -1;
            cb_grupo.SelectedIndex = -1;
            cb_genero.SelectedIndex = -1;

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (txt_nome.Text == "" || mtxt_data.Text == "" || txt_morada.Text == "" || cb_encarregados.SelectedIndex == -1 || cb_estado.SelectedIndex == -1 || cb_grupo.SelectedIndex == -1 || cb_genero.SelectedIndex == -1)
            {
                MessageBox.Show("TODOS OS CAMPOS SÃO OBRIGATÓRIOS!");
                return;
            }
            string query = String.Format(@" INSERT 
                                INTO 
                                    tb_alunos
                                (
                                  T_NOMEALUNO,
                                   T_MORADA,
                                   T_DATANASCIMENTO,
                                   T_GENERO,
                                   N_IDENCARREGADO,
                                   T_ESTADO,
                                   T_GRUPO
                                )
                            VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')
         ", txt_nome.Text, txt_morada.Text, mtxt_data.Text, cb_genero.SelectedValue, cb_encarregados.SelectedValue, cb_estado.SelectedValue, cb_grupo.SelectedValue);

            Banco.dml(query);
            DialogResult res = MessageBox.Show("Deseja Imprimir Ficha de Pre-Inscrição?", "Aluno Inscrito", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
            {
                saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {

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
                    paragrafo.Add("Ficha de Pré-Inscrição");
                    doc.Add(paragrafo);

                    iTextSharp.text.Image borda = iTextSharp.text.Image.GetInstance(Globais.caminhoFotos + "Barra_de_Borda.png");
                    borda.ScaleToFit(500f, 22f);
                    borda.Alignment = Element.ALIGN_CENTER;
                    doc.Add(borda);

                    Paragraph paragrafo2 = new Paragraph();
                    paragrafo2.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, (int)System.Drawing.FontStyle.Bold);
                    paragrafo2.Alignment = Element.ALIGN_JUSTIFIED;
                    paragrafo2.Add("                                    Nome: ");
                    paragrafo2.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, (int)System.Drawing.FontStyle.Regular);
                    paragrafo2.Add(txt_nome.Text);
                    doc.Add(paragrafo2);

                    Paragraph paragrafo3 = new Paragraph();
                    paragrafo3.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, (int)System.Drawing.FontStyle.Bold);
                    paragrafo3.Alignment = Element.ALIGN_JUSTIFIED;
                    paragrafo3.Add("                                    Data de Nascimento: ");
                    paragrafo3.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, (int)System.Drawing.FontStyle.Regular);
                    paragrafo3.Add(mtxt_data.Text);
                    doc.Add(paragrafo3);


                    Paragraph paragrafo7 = new Paragraph();
                    paragrafo7.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, (int)System.Drawing.FontStyle.Bold);
                    paragrafo7.Alignment = Element.ALIGN_JUSTIFIED;
                    paragrafo7.Add("                                    Nomde do Encarregado: ");
                    paragrafo7.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, (int)System.Drawing.FontStyle.Regular);

                    paragrafo7.Add(cb_encarregados.SelectedText);
                    paragrafo7.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, (int)System.Drawing.FontStyle.Bold);
                    doc.Add(paragrafo7);

                    Paragraph paragrafo4 = new Paragraph();
                    paragrafo4.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, (int)System.Drawing.FontStyle.Bold);
                    paragrafo4.Alignment = Element.ALIGN_JUSTIFIED;
                    paragrafo4.Add("                                    Endereço: ");
                    paragrafo4.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, (int)System.Drawing.FontStyle.Regular);

                    paragrafo4.Add(txt_morada.Text);
                    doc.Add(paragrafo4);

                    Paragraph paragrafo6 = new Paragraph();
                    paragrafo6.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, (int)System.Drawing.FontStyle.Bold);
                    paragrafo6.Alignment = Element.ALIGN_JUSTIFIED;
                    paragrafo6.Add("                                    Gênero : ");
                    paragrafo6.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, (int)System.Drawing.FontStyle.Regular);

                    paragrafo6.Add(cb_genero.SelectedText);
                    paragrafo6.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, (int)System.Drawing.FontStyle.Bold);
                    doc.Add(paragrafo6);

                    Paragraph paragrafo5 = new Paragraph();
                    paragrafo5.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, (int)System.Drawing.FontStyle.Bold);
                    paragrafo5.Alignment = Element.ALIGN_JUSTIFIED;
                    paragrafo5.Add("                                    Grupo: ");
                    paragrafo5.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, (int)System.Drawing.FontStyle.Regular);

                    paragrafo5.Add(cb_grupo.SelectedText);
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
        private void btn_gerir_Click(object sender, EventArgs e)
        {
            Frm_matricula frm_Matricula = new Frm_matricula();
            frm_Matricula.Show();
            this.Close();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();        
        }
    }
}

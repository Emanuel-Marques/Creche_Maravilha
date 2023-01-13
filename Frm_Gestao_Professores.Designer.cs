
namespace Creche_Maravilha
{
    partial class Frm_Gestao_Professores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pb_foto = new System.Windows.Forms.PictureBox();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.mtxt_data = new System.Windows.Forms.MaskedTextBox();
            this.txt_morada = new System.Windows.Forms.TextBox();
            this.mtxt_telefone = new System.Windows.Forms.MaskedTextBox();
            this.txt_grupo = new System.Windows.Forms.TextBox();
            this.dgv_professores = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_professores)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_foto
            // 
            this.pb_foto.BackColor = System.Drawing.Color.Transparent;
            this.pb_foto.Location = new System.Drawing.Point(776, 164);
            this.pb_foto.Name = "pb_foto";
            this.pb_foto.Size = new System.Drawing.Size(136, 160);
            this.pb_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_foto.TabIndex = 0;
            this.pb_foto.TabStop = false;
            // 
            // btn_alterar
            // 
            this.btn_alterar.BackColor = System.Drawing.Color.Transparent;
            this.btn_alterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_alterar.FlatAppearance.BorderSize = 0;
            this.btn_alterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_alterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alterar.Location = new System.Drawing.Point(776, 337);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(136, 13);
            this.btn_alterar.TabIndex = 1;
            this.btn_alterar.UseVisualStyleBackColor = false;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.BackColor = System.Drawing.Color.Transparent;
            this.btn_novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_novo.FlatAppearance.BorderSize = 0;
            this.btn_novo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_novo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_novo.Location = new System.Drawing.Point(70, 374);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(141, 37);
            this.btn_novo.TabIndex = 2;
            this.btn_novo.UseVisualStyleBackColor = false;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackColor = System.Drawing.Color.Transparent;
            this.btn_excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_excluir.FlatAppearance.BorderSize = 0;
            this.btn_excluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_excluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excluir.Location = new System.Drawing.Point(411, 376);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(166, 34);
            this.btn_excluir.TabIndex = 3;
            this.btn_excluir.UseVisualStyleBackColor = false;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.BackColor = System.Drawing.Color.Transparent;
            this.btn_imprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_imprimir.FlatAppearance.BorderSize = 0;
            this.btn_imprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_imprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_imprimir.Location = new System.Drawing.Point(593, 373);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(165, 38);
            this.btn_imprimir.TabIndex = 4;
            this.btn_imprimir.UseVisualStyleBackColor = false;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.BackColor = System.Drawing.Color.Transparent;
            this.btn_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fechar.FlatAppearance.BorderSize = 0;
            this.btn_fechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_fechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fechar.Location = new System.Drawing.Point(775, 374);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(146, 40);
            this.btn_fechar.TabIndex = 5;
            this.btn_fechar.UseVisualStyleBackColor = false;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.Transparent;
            this.btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvar.FlatAppearance.BorderSize = 0;
            this.btn_salvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_salvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Location = new System.Drawing.Point(231, 375);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(166, 37);
            this.btn_salvar.TabIndex = 6;
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.SystemColors.Window;
            this.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_id.Enabled = false;
            this.txt_id.Font = new System.Drawing.Font("Roboto", 12F);
            this.txt_id.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txt_id.Location = new System.Drawing.Point(65, 214);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(51, 20);
            this.txt_id.TabIndex = 7;
            // 
            // txt_nome
            // 
            this.txt_nome.BackColor = System.Drawing.SystemColors.Window;
            this.txt_nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nome.Font = new System.Drawing.Font("Roboto", 12F);
            this.txt_nome.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txt_nome.Location = new System.Drawing.Point(159, 214);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(283, 20);
            this.txt_nome.TabIndex = 8;
            // 
            // mtxt_data
            // 
            this.mtxt_data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxt_data.Font = new System.Drawing.Font("Roboto", 12F);
            this.mtxt_data.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.mtxt_data.Location = new System.Drawing.Point(478, 214);
            this.mtxt_data.Mask = "00/00/0000";
            this.mtxt_data.Name = "mtxt_data";
            this.mtxt_data.Size = new System.Drawing.Size(181, 20);
            this.mtxt_data.TabIndex = 9;
            this.mtxt_data.ValidatingType = typeof(System.DateTime);
            // 
            // txt_morada
            // 
            this.txt_morada.BackColor = System.Drawing.SystemColors.Window;
            this.txt_morada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_morada.Font = new System.Drawing.Font("Roboto", 12F);
            this.txt_morada.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txt_morada.Location = new System.Drawing.Point(63, 273);
            this.txt_morada.Name = "txt_morada";
            this.txt_morada.Size = new System.Drawing.Size(283, 20);
            this.txt_morada.TabIndex = 10;
            // 
            // mtxt_telefone
            // 
            this.mtxt_telefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxt_telefone.Font = new System.Drawing.Font("Roboto", 12F);
            this.mtxt_telefone.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.mtxt_telefone.Location = new System.Drawing.Point(396, 273);
            this.mtxt_telefone.Mask = "(+999) 000-000-000";
            this.mtxt_telefone.Name = "mtxt_telefone";
            this.mtxt_telefone.Size = new System.Drawing.Size(286, 20);
            this.mtxt_telefone.TabIndex = 11;
            // 
            // txt_grupo
            // 
            this.txt_grupo.BackColor = System.Drawing.SystemColors.Window;
            this.txt_grupo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_grupo.Font = new System.Drawing.Font("Roboto", 12F);
            this.txt_grupo.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txt_grupo.Location = new System.Drawing.Point(64, 330);
            this.txt_grupo.Name = "txt_grupo";
            this.txt_grupo.Size = new System.Drawing.Size(283, 20);
            this.txt_grupo.TabIndex = 12;
            // 
            // dgv_professores
            // 
            this.dgv_professores.AllowUserToAddRows = false;
            this.dgv_professores.AllowUserToDeleteRows = false;
            this.dgv_professores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_professores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_professores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_professores.Location = new System.Drawing.Point(62, 427);
            this.dgv_professores.MultiSelect = false;
            this.dgv_professores.Name = "dgv_professores";
            this.dgv_professores.ReadOnly = true;
            this.dgv_professores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_professores.Size = new System.Drawing.Size(866, 167);
            this.dgv_professores.TabIndex = 13;
            this.dgv_professores.SelectionChanged += new System.EventHandler(this.dgv_professores_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(70, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(156, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Location = new System.Drawing.Point(475, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Data de Nascimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label4.Location = new System.Drawing.Point(70, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Endereço";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.label5.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label5.Location = new System.Drawing.Point(393, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Telefone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.label6.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label6.Location = new System.Drawing.Point(70, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Grupo";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "PDF(*.pdf)|*.pdf";
            this.saveFileDialog1.Title = "Salvar Ficha do Professor";
            // 
            // Frm_Gestao_Professores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Creche_Maravilha.Properties.Resources.Tela_Gestão_de_Professores1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(988, 659);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_professores);
            this.Controls.Add(this.txt_grupo);
            this.Controls.Add(this.mtxt_telefone);
            this.Controls.Add(this.txt_morada);
            this.Controls.Add(this.mtxt_data);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.pb_foto);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Frm_Gestao_Professores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_Gestao_Professores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_professores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_foto;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.MaskedTextBox mtxt_data;
        private System.Windows.Forms.TextBox txt_morada;
        private System.Windows.Forms.MaskedTextBox mtxt_telefone;
        private System.Windows.Forms.TextBox txt_grupo;
        private System.Windows.Forms.DataGridView dgv_professores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
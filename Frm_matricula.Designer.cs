
namespace Creche_Maravilha
{
    partial class Frm_matricula
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_morada = new System.Windows.Forms.TextBox();
            this.mtxt_data = new System.Windows.Forms.MaskedTextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.pb_foto = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_encarregados = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.cb_grupo = new System.Windows.Forms.ComboBox();
            this.cb_genero = new System.Windows.Forms.ComboBox();
            this.dgv_alunos = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alunos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.Transparent;
            this.btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvar.FlatAppearance.BorderSize = 0;
            this.btn_salvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_salvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Location = new System.Drawing.Point(232, 375);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(166, 37);
            this.btn_salvar.TabIndex = 11;
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.BackColor = System.Drawing.Color.Transparent;
            this.btn_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fechar.FlatAppearance.BorderSize = 0;
            this.btn_fechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_fechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fechar.Location = new System.Drawing.Point(776, 374);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(146, 40);
            this.btn_fechar.TabIndex = 10;
            this.btn_fechar.UseVisualStyleBackColor = false;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.BackColor = System.Drawing.Color.Transparent;
            this.btn_imprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_imprimir.FlatAppearance.BorderSize = 0;
            this.btn_imprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_imprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_imprimir.Location = new System.Drawing.Point(594, 373);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(165, 38);
            this.btn_imprimir.TabIndex = 9;
            this.btn_imprimir.UseVisualStyleBackColor = false;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackColor = System.Drawing.Color.Transparent;
            this.btn_excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_excluir.FlatAppearance.BorderSize = 0;
            this.btn_excluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_excluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excluir.Location = new System.Drawing.Point(412, 376);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(166, 34);
            this.btn_excluir.TabIndex = 8;
            this.btn_excluir.UseVisualStyleBackColor = false;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.BackColor = System.Drawing.Color.Transparent;
            this.btn_novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_novo.FlatAppearance.BorderSize = 0;
            this.btn_novo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_novo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_novo.Location = new System.Drawing.Point(71, 374);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(141, 37);
            this.btn_novo.TabIndex = 7;
            this.btn_novo.UseVisualStyleBackColor = false;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "PDF(*.pdf)|*.pdf";
            this.saveFileDialog1.Title = "Salvar ficha de matrícula";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label4.Location = new System.Drawing.Point(476, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Endereço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Location = new System.Drawing.Point(61, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Data de Nascimento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(158, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(61, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "ID";
            // 
            // txt_morada
            // 
            this.txt_morada.BackColor = System.Drawing.SystemColors.Window;
            this.txt_morada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_morada.Font = new System.Drawing.Font("Roboto", 12F);
            this.txt_morada.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txt_morada.Location = new System.Drawing.Point(479, 214);
            this.txt_morada.Name = "txt_morada";
            this.txt_morada.Size = new System.Drawing.Size(272, 20);
            this.txt_morada.TabIndex = 25;
            // 
            // mtxt_data
            // 
            this.mtxt_data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxt_data.Font = new System.Drawing.Font("Roboto", 12F);
            this.mtxt_data.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.mtxt_data.Location = new System.Drawing.Point(64, 271);
            this.mtxt_data.Mask = "00/00/0000";
            this.mtxt_data.Name = "mtxt_data";
            this.mtxt_data.Size = new System.Drawing.Size(169, 20);
            this.mtxt_data.TabIndex = 24;
            this.mtxt_data.ValidatingType = typeof(System.DateTime);
            // 
            // txt_nome
            // 
            this.txt_nome.BackColor = System.Drawing.SystemColors.Window;
            this.txt_nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nome.Font = new System.Drawing.Font("Roboto", 12F);
            this.txt_nome.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txt_nome.Location = new System.Drawing.Point(161, 214);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(283, 20);
            this.txt_nome.TabIndex = 23;
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.SystemColors.Window;
            this.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_id.Enabled = false;
            this.txt_id.Font = new System.Drawing.Font("Roboto", 12F);
            this.txt_id.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txt_id.Location = new System.Drawing.Point(64, 214);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(60, 20);
            this.txt_id.TabIndex = 22;
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
            this.btn_alterar.TabIndex = 21;
            this.btn_alterar.UseVisualStyleBackColor = false;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // pb_foto
            // 
            this.pb_foto.BackColor = System.Drawing.Color.Transparent;
            this.pb_foto.Location = new System.Drawing.Point(777, 165);
            this.pb_foto.Name = "pb_foto";
            this.pb_foto.Size = new System.Drawing.Size(136, 160);
            this.pb_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_foto.TabIndex = 20;
            this.pb_foto.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.label7.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label7.Location = new System.Drawing.Point(425, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Nome do Encarregado";
            // 
            // cb_encarregados
            // 
            this.cb_encarregados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_encarregados.Font = new System.Drawing.Font("Roboto", 12F);
            this.cb_encarregados.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.cb_encarregados.FormattingEnabled = true;
            this.cb_encarregados.Location = new System.Drawing.Point(428, 264);
            this.cb_encarregados.Name = "cb_encarregados";
            this.cb_encarregados.Size = new System.Drawing.Size(323, 27);
            this.cb_encarregados.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.label5.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label5.Location = new System.Drawing.Point(275, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Estado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.label8.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label8.Location = new System.Drawing.Point(63, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "Grupo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.label9.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label9.Location = new System.Drawing.Point(275, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "Genero";
            // 
            // cb_estado
            // 
            this.cb_estado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_estado.Font = new System.Drawing.Font("Roboto", 12F);
            this.cb_estado.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.Location = new System.Drawing.Point(278, 314);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(111, 27);
            this.cb_estado.TabIndex = 43;
            // 
            // cb_grupo
            // 
            this.cb_grupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_grupo.Font = new System.Drawing.Font("Roboto", 12F);
            this.cb_grupo.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.cb_grupo.FormattingEnabled = true;
            this.cb_grupo.Location = new System.Drawing.Point(64, 309);
            this.cb_grupo.Name = "cb_grupo";
            this.cb_grupo.Size = new System.Drawing.Size(113, 27);
            this.cb_grupo.TabIndex = 42;
            // 
            // cb_genero
            // 
            this.cb_genero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_genero.Font = new System.Drawing.Font("Roboto", 12F);
            this.cb_genero.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.cb_genero.FormattingEnabled = true;
            this.cb_genero.Location = new System.Drawing.Point(278, 264);
            this.cb_genero.Name = "cb_genero";
            this.cb_genero.Size = new System.Drawing.Size(111, 27);
            this.cb_genero.TabIndex = 41;
            // 
            // dgv_alunos
            // 
            this.dgv_alunos.AllowUserToAddRows = false;
            this.dgv_alunos.AllowUserToDeleteRows = false;
            this.dgv_alunos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_alunos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_alunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_alunos.Location = new System.Drawing.Point(64, 427);
            this.dgv_alunos.MultiSelect = false;
            this.dgv_alunos.Name = "dgv_alunos";
            this.dgv_alunos.ReadOnly = true;
            this.dgv_alunos.RowHeadersVisible = false;
            this.dgv_alunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_alunos.Size = new System.Drawing.Size(866, 167);
            this.dgv_alunos.TabIndex = 49;
            this.dgv_alunos.SelectionChanged += new System.EventHandler(this.dgv_alunos_SelectionChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Frm_matricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Creche_Maravilha.Properties.Resources.Tela_Matricula;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(988, 659);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_alunos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_encarregados);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cb_estado);
            this.Controls.Add(this.cb_grupo);
            this.Controls.Add(this.cb_genero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_morada);
            this.Controls.Add(this.mtxt_data);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.pb_foto);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_novo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Frm_matricula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_matricula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_morada;
        private System.Windows.Forms.MaskedTextBox mtxt_data;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.PictureBox pb_foto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_encarregados;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_estado;
        private System.Windows.Forms.ComboBox cb_grupo;
        private System.Windows.Forms.ComboBox cb_genero;
        private System.Windows.Forms.DataGridView dgv_alunos;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
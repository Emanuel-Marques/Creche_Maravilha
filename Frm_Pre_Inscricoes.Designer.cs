
namespace Creche_Maravilha
{
    partial class Frm_Pre_Inscricoes
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
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_gerir = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mtxt_data = new System.Windows.Forms.MaskedTextBox();
            this.txt_morada = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.cb_genero = new System.Windows.Forms.ComboBox();
            this.cb_grupo = new System.Windows.Forms.ComboBox();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_encarregados = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btn_fechar
            // 
            this.btn_fechar.BackColor = System.Drawing.Color.Transparent;
            this.btn_fechar.BackgroundImage = global::Creche_Maravilha.Properties.Resources.btn_fechar;
            this.btn_fechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fechar.FlatAppearance.BorderSize = 0;
            this.btn_fechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_fechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fechar.Location = new System.Drawing.Point(719, 488);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(180, 50);
            this.btn_fechar.TabIndex = 7;
            this.btn_fechar.UseVisualStyleBackColor = false;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_gerir
            // 
            this.btn_gerir.BackColor = System.Drawing.Color.Transparent;
            this.btn_gerir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_gerir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_gerir.FlatAppearance.BorderSize = 0;
            this.btn_gerir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_gerir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_gerir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gerir.Location = new System.Drawing.Point(734, 422);
            this.btn_gerir.Name = "btn_gerir";
            this.btn_gerir.Size = new System.Drawing.Size(158, 35);
            this.btn_gerir.TabIndex = 6;
            this.btn_gerir.UseVisualStyleBackColor = false;
            this.btn_gerir.Click += new System.EventHandler(this.btn_gerir_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.Transparent;
            this.btn_salvar.BackgroundImage = global::Creche_Maravilha.Properties.Resources.btn_salvar;
            this.btn_salvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvar.FlatAppearance.BorderSize = 0;
            this.btn_salvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_salvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Location = new System.Drawing.Point(722, 348);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(180, 44);
            this.btn_salvar.TabIndex = 5;
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.BackColor = System.Drawing.Color.Transparent;
            this.btn_novo.BackgroundImage = global::Creche_Maravilha.Properties.Resources.btn_novo;
            this.btn_novo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_novo.FlatAppearance.BorderSize = 0;
            this.btn_novo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_novo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_novo.Location = new System.Drawing.Point(722, 280);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(180, 43);
            this.btn_novo.TabIndex = 4;
            this.btn_novo.UseVisualStyleBackColor = false;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.label5.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label5.Location = new System.Drawing.Point(393, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Data de Nascimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label4.Location = new System.Drawing.Point(78, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Morada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(78, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Nome";
            // 
            // mtxt_data
            // 
            this.mtxt_data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxt_data.Font = new System.Drawing.Font("Roboto", 12F);
            this.mtxt_data.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.mtxt_data.Location = new System.Drawing.Point(396, 314);
            this.mtxt_data.Mask = "00/00/0000";
            this.mtxt_data.Name = "mtxt_data";
            this.mtxt_data.Size = new System.Drawing.Size(234, 20);
            this.mtxt_data.TabIndex = 29;
            this.mtxt_data.ValidatingType = typeof(System.DateTime);
            // 
            // txt_morada
            // 
            this.txt_morada.BackColor = System.Drawing.SystemColors.Window;
            this.txt_morada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_morada.Font = new System.Drawing.Font("Roboto", 12F);
            this.txt_morada.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txt_morada.Location = new System.Drawing.Point(81, 382);
            this.txt_morada.Name = "txt_morada";
            this.txt_morada.Size = new System.Drawing.Size(283, 20);
            this.txt_morada.TabIndex = 28;
            // 
            // txt_nome
            // 
            this.txt_nome.BackColor = System.Drawing.SystemColors.Window;
            this.txt_nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nome.Font = new System.Drawing.Font("Roboto", 12F);
            this.txt_nome.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txt_nome.Location = new System.Drawing.Point(81, 314);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(283, 20);
            this.txt_nome.TabIndex = 27;
            // 
            // cb_genero
            // 
            this.cb_genero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_genero.Font = new System.Drawing.Font("Roboto", 12F);
            this.cb_genero.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.cb_genero.FormattingEnabled = true;
            this.cb_genero.Location = new System.Drawing.Point(80, 442);
            this.cb_genero.Name = "cb_genero";
            this.cb_genero.Size = new System.Drawing.Size(96, 27);
            this.cb_genero.TabIndex = 33;
            // 
            // cb_grupo
            // 
            this.cb_grupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_grupo.Font = new System.Drawing.Font("Roboto", 12F);
            this.cb_grupo.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.cb_grupo.FormattingEnabled = true;
            this.cb_grupo.Location = new System.Drawing.Point(339, 442);
            this.cb_grupo.Name = "cb_grupo";
            this.cb_grupo.Size = new System.Drawing.Size(96, 27);
            this.cb_grupo.TabIndex = 34;
            // 
            // cb_estado
            // 
            this.cb_estado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_estado.Font = new System.Drawing.Font("Roboto", 12F);
            this.cb_estado.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.Location = new System.Drawing.Point(583, 442);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(96, 27);
            this.cb_estado.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(78, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Genero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Location = new System.Drawing.Point(336, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Grupo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.label6.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label6.Location = new System.Drawing.Point(580, 422);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Estado";
            // 
            // cb_encarregados
            // 
            this.cb_encarregados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_encarregados.Font = new System.Drawing.Font("Roboto", 12F);
            this.cb_encarregados.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.cb_encarregados.FormattingEnabled = true;
            this.cb_encarregados.Location = new System.Drawing.Point(396, 375);
            this.cb_encarregados.Name = "cb_encarregados";
            this.cb_encarregados.Size = new System.Drawing.Size(283, 27);
            this.cb_encarregados.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.label7.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label7.Location = new System.Drawing.Point(393, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Nome do Encarregado";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "PDF(*.pdf)|*.pdf";
            this.saveFileDialog1.Title = "Salvar Ficha de Pré-Inscrição";
            // 
            // Frm_Pre_Inscricoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Creche_Maravilha.Properties.Resources.Tela_Pre_inscricao;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(988, 658);
            this.ControlBox = false;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_encarregados);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_estado);
            this.Controls.Add(this.cb_grupo);
            this.Controls.Add(this.cb_genero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtxt_data);
            this.Controls.Add(this.txt_morada);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.btn_gerir);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_novo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Frm_Pre_Inscricoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_Pre_Inscricoes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_gerir;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtxt_data;
        private System.Windows.Forms.TextBox txt_morada;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.ComboBox cb_genero;
        private System.Windows.Forms.ComboBox cb_grupo;
        private System.Windows.Forms.ComboBox cb_estado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_encarregados;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
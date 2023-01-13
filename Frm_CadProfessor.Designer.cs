
namespace Creche_Maravilha
{
    partial class Frm_CadProfessor
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
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_gerir = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_carregar = new System.Windows.Forms.Button();
            this.pb_foto = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.mtxt_data = new System.Windows.Forms.MaskedTextBox();
            this.txt_morada = new System.Windows.Forms.TextBox();
            this.mtxt_telefone = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).BeginInit();
            this.SuspendLayout();
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
            this.btn_novo.Location = new System.Drawing.Point(719, 281);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(180, 43);
            this.btn_novo.TabIndex = 0;
            this.btn_novo.UseVisualStyleBackColor = false;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
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
            this.btn_salvar.Location = new System.Drawing.Point(719, 347);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(180, 44);
            this.btn_salvar.TabIndex = 1;
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_gerir
            // 
            this.btn_gerir.BackColor = System.Drawing.Color.Transparent;
            this.btn_gerir.BackgroundImage = global::Creche_Maravilha.Properties.Resources.btn_gerir;
            this.btn_gerir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_gerir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_gerir.FlatAppearance.BorderSize = 0;
            this.btn_gerir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_gerir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_gerir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gerir.Location = new System.Drawing.Point(719, 417);
            this.btn_gerir.Name = "btn_gerir";
            this.btn_gerir.Size = new System.Drawing.Size(180, 46);
            this.btn_gerir.TabIndex = 2;
            this.btn_gerir.UseVisualStyleBackColor = false;
            this.btn_gerir.Click += new System.EventHandler(this.btn_gerir_Click);
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
            this.btn_fechar.Location = new System.Drawing.Point(721, 490);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(180, 50);
            this.btn_fechar.TabIndex = 3;
            this.btn_fechar.UseVisualStyleBackColor = false;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_carregar
            // 
            this.btn_carregar.BackColor = System.Drawing.Color.Transparent;
            this.btn_carregar.BackgroundImage = global::Creche_Maravilha.Properties.Resources.btn_carregar_foto;
            this.btn_carregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_carregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_carregar.FlatAppearance.BorderSize = 0;
            this.btn_carregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_carregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_carregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_carregar.Location = new System.Drawing.Point(95, 508);
            this.btn_carregar.Name = "btn_carregar";
            this.btn_carregar.Size = new System.Drawing.Size(210, 30);
            this.btn_carregar.TabIndex = 4;
            this.btn_carregar.UseVisualStyleBackColor = false;
            this.btn_carregar.Click += new System.EventHandler(this.btn_carregar_Click);
            // 
            // pb_foto
            // 
            this.pb_foto.BackColor = System.Drawing.Color.Transparent;
            this.pb_foto.Location = new System.Drawing.Point(95, 256);
            this.pb_foto.Name = "pb_foto";
            this.pb_foto.Size = new System.Drawing.Size(210, 241);
            this.pb_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_foto.TabIndex = 5;
            this.pb_foto.TabStop = false;
            this.pb_foto.Click += new System.EventHandler(this.pb_foto_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txt_nome
            // 
            this.txt_nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nome.Font = new System.Drawing.Font("Roboto", 12F);
            this.txt_nome.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txt_nome.Location = new System.Drawing.Point(344, 279);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(281, 20);
            this.txt_nome.TabIndex = 6;
            this.txt_nome.Text = "Digite o nome do professor";
            this.txt_nome.TextChanged += new System.EventHandler(this.txt_nome_TextChanged);
            // 
            // mtxt_data
            // 
            this.mtxt_data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxt_data.Font = new System.Drawing.Font("Roboto", 12F);
            this.mtxt_data.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.mtxt_data.Location = new System.Drawing.Point(345, 364);
            this.mtxt_data.Mask = "00/00/0000";
            this.mtxt_data.Name = "mtxt_data";
            this.mtxt_data.Size = new System.Drawing.Size(281, 20);
            this.mtxt_data.TabIndex = 7;
            this.mtxt_data.ValidatingType = typeof(System.DateTime);
            // 
            // txt_morada
            // 
            this.txt_morada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_morada.Font = new System.Drawing.Font("Roboto", 12F);
            this.txt_morada.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txt_morada.Location = new System.Drawing.Point(345, 432);
            this.txt_morada.Name = "txt_morada";
            this.txt_morada.Size = new System.Drawing.Size(281, 20);
            this.txt_morada.TabIndex = 8;
            this.txt_morada.Text = "Digite o endereço do professor";
            this.txt_morada.TextChanged += new System.EventHandler(this.txt_morada_TextChanged);
            // 
            // mtxt_telefone
            // 
            this.mtxt_telefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxt_telefone.Font = new System.Drawing.Font("Roboto", 12F);
            this.mtxt_telefone.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.mtxt_telefone.Location = new System.Drawing.Point(344, 512);
            this.mtxt_telefone.Mask = "(+999) 000-000-000";
            this.mtxt_telefone.Name = "mtxt_telefone";
            this.mtxt_telefone.Size = new System.Drawing.Size(281, 20);
            this.mtxt_telefone.TabIndex = 9;
            // 
            // Frm_CadProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Creche_Maravilha.Properties.Resources.Tela_Cadastro_de_Professores;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(988, 659);
            this.ControlBox = false;
            this.Controls.Add(this.mtxt_telefone);
            this.Controls.Add(this.txt_morada);
            this.Controls.Add(this.mtxt_data);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.pb_foto);
            this.Controls.Add(this.btn_carregar);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.btn_gerir);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_novo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Frm_CadProfessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_gerir;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_carregar;
        private System.Windows.Forms.PictureBox pb_foto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.MaskedTextBox mtxt_data;
        private System.Windows.Forms.TextBox txt_morada;
        private System.Windows.Forms.MaskedTextBox mtxt_telefone;
    }
}
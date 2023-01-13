
namespace Creche_Maravilha
{
    partial class Frm_CadEncarregados
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
            this.mtxt_telefone = new System.Windows.Forms.MaskedTextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_gerir = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mtxt_telefone
            // 
            this.mtxt_telefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxt_telefone.Font = new System.Drawing.Font("Roboto", 12F);
            this.mtxt_telefone.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.mtxt_telefone.Location = new System.Drawing.Point(87, 384);
            this.mtxt_telefone.Mask = "(+999) 000-000-000";
            this.mtxt_telefone.Name = "mtxt_telefone";
            this.mtxt_telefone.Size = new System.Drawing.Size(281, 20);
            this.mtxt_telefone.TabIndex = 12;
            // 
            // txt_email
            // 
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_email.Font = new System.Drawing.Font("Roboto", 12F);
            this.txt_email.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txt_email.Location = new System.Drawing.Point(87, 492);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(281, 20);
            this.txt_email.TabIndex = 11;
            this.txt_email.Text = "Digite o email do encarregado";
            // 
            // txt_nome
            // 
            this.txt_nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nome.Font = new System.Drawing.Font("Roboto", 12F);
            this.txt_nome.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txt_nome.Location = new System.Drawing.Point(89, 267);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(281, 20);
            this.txt_nome.TabIndex = 10;
            this.txt_nome.Text = "Digite o nome do encarregado";
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
            this.btn_fechar.Location = new System.Drawing.Point(722, 490);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(180, 50);
            this.btn_fechar.TabIndex = 16;
            this.btn_fechar.UseVisualStyleBackColor = false;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
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
            this.btn_gerir.Location = new System.Drawing.Point(720, 417);
            this.btn_gerir.Name = "btn_gerir";
            this.btn_gerir.Size = new System.Drawing.Size(180, 46);
            this.btn_gerir.TabIndex = 15;
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
            this.btn_salvar.Location = new System.Drawing.Point(720, 347);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(180, 44);
            this.btn_salvar.TabIndex = 14;
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
            this.btn_novo.Location = new System.Drawing.Point(720, 281);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(180, 43);
            this.btn_novo.TabIndex = 13;
            this.btn_novo.UseVisualStyleBackColor = false;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // Frm_CadEncarregados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Creche_Maravilha.Properties.Resources.Tela_Cadastro_de_Encarregados;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(988, 659);
            this.ControlBox = false;
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.btn_gerir);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.mtxt_telefone);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_nome);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Frm_CadEncarregados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtxt_telefone;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_gerir;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_novo;
    }
}
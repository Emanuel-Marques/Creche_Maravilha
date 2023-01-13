
namespace Creche_Maravilha
{
    partial class Frm_GerirEncarregados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mtxt_telefone = new System.Windows.Forms.MaskedTextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.dgv_encarregados = new System.Windows.Forms.DataGridView();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_encarregados)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.label5.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label5.Location = new System.Drawing.Point(476, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label4.Location = new System.Drawing.Point(674, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Email";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(156, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(60, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "ID";
            // 
            // mtxt_telefone
            // 
            this.mtxt_telefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxt_telefone.Font = new System.Drawing.Font("Roboto", 12F);
            this.mtxt_telefone.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.mtxt_telefone.Location = new System.Drawing.Point(479, 229);
            this.mtxt_telefone.Mask = "(+999) 000-000-000";
            this.mtxt_telefone.Name = "mtxt_telefone";
            this.mtxt_telefone.Size = new System.Drawing.Size(178, 20);
            this.mtxt_telefone.TabIndex = 22;
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.SystemColors.Window;
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_email.Font = new System.Drawing.Font("Roboto", 12F);
            this.txt_email.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txt_email.Location = new System.Drawing.Point(677, 229);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(249, 20);
            this.txt_email.TabIndex = 21;
            // 
            // txt_nome
            // 
            this.txt_nome.BackColor = System.Drawing.SystemColors.Window;
            this.txt_nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nome.Font = new System.Drawing.Font("Roboto", 12F);
            this.txt_nome.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txt_nome.Location = new System.Drawing.Point(159, 227);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(283, 20);
            this.txt_nome.TabIndex = 20;
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.SystemColors.Window;
            this.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_id.Enabled = false;
            this.txt_id.Font = new System.Drawing.Font("Roboto", 12F);
            this.txt_id.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txt_id.Location = new System.Drawing.Point(63, 229);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(60, 20);
            this.txt_id.TabIndex = 19;
            // 
            // dgv_encarregados
            // 
            this.dgv_encarregados.AllowUserToAddRows = false;
            this.dgv_encarregados.AllowUserToDeleteRows = false;
            this.dgv_encarregados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_encarregados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_encarregados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_encarregados.Location = new System.Drawing.Point(63, 348);
            this.dgv_encarregados.MultiSelect = false;
            this.dgv_encarregados.Name = "dgv_encarregados";
            this.dgv_encarregados.ReadOnly = true;
            this.dgv_encarregados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_encarregados.Size = new System.Drawing.Size(866, 252);
            this.dgv_encarregados.TabIndex = 27;
            this.dgv_encarregados.SelectionChanged += new System.EventHandler(this.dgv_encarregados_SelectionChanged);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.Transparent;
            this.btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvar.FlatAppearance.BorderSize = 0;
            this.btn_salvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_salvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Location = new System.Drawing.Point(230, 296);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(166, 37);
            this.btn_salvar.TabIndex = 32;
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
            this.btn_fechar.Location = new System.Drawing.Point(774, 295);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(146, 40);
            this.btn_fechar.TabIndex = 31;
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
            this.btn_imprimir.Location = new System.Drawing.Point(592, 294);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(165, 38);
            this.btn_imprimir.TabIndex = 30;
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
            this.btn_excluir.Location = new System.Drawing.Point(410, 297);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(166, 34);
            this.btn_excluir.TabIndex = 29;
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
            this.btn_novo.Location = new System.Drawing.Point(69, 295);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(141, 37);
            this.btn_novo.TabIndex = 28;
            this.btn_novo.UseVisualStyleBackColor = false;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // Frm_GerirEncarregados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Creche_Maravilha.Properties.Resources.Tela_Gestão_de_Encarregados;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(988, 659);
            this.ControlBox = false;
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.dgv_encarregados);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtxt_telefone);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.txt_id);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Frm_GerirEncarregados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_GerirEncarregados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_encarregados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtxt_telefone;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.DataGridView dgv_encarregados;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_novo;
    }
}
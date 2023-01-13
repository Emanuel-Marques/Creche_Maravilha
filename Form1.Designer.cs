
namespace Creche_Maravilha
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_username
            // 
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_username.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txt_username.Location = new System.Drawing.Point(529, 238);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(188, 20);
            this.txt_username.TabIndex = 1;
            this.txt_username.Text = "Nome de usuário";
            // 
            // txt_senha
            // 
            this.txt_senha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_senha.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senha.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txt_senha.Location = new System.Drawing.Point(529, 304);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(188, 20);
            this.txt_senha.TabIndex = 3;
            this.txt_senha.Text = "ffff";
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_login.BackgroundImage = global::Creche_Maravilha.Properties.Resources.botao;
            this.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Location = new System.Drawing.Point(563, 355);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(120, 49);
            this.btn_login.TabIndex = 4;
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.BackColor = System.Drawing.Color.Transparent;
            this.btn_fechar.BackgroundImage = global::Creche_Maravilha.Properties.Resources.sair_da_tela_cheia;
            this.btn_fechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fechar.FlatAppearance.BorderSize = 0;
            this.btn_fechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_fechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fechar.Location = new System.Drawing.Point(747, 12);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(67, 49);
            this.btn_fechar.TabIndex = 6;
            this.btn_fechar.UseVisualStyleBackColor = false;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Creche_Maravilha.Properties.Resources.Tela_Login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(826, 522);
            this.ControlBox = false;
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.txt_username);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_fechar;
    }
}


namespace tcc_sudoku_pedroo
{
    partial class tela_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tela_login));
            this.txtbox_gmail = new System.Windows.Forms.TextBox();
            this.txtbox_senha = new System.Windows.Forms.TextBox();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.btn_candastrar = new System.Windows.Forms.Button();
            this.gpbox_login = new System.Windows.Forms.GroupBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txtbox_nome = new System.Windows.Forms.TextBox();
            this.lbl_gmail = new System.Windows.Forms.Label();
            this.btn_Entrar = new System.Windows.Forms.Button();
            this.lbl_sudoku = new System.Windows.Forms.Label();
            this.gpbox_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbox_gmail
            // 
            this.txtbox_gmail.Location = new System.Drawing.Point(26, 82);
            this.txtbox_gmail.Name = "txtbox_gmail";
            this.txtbox_gmail.Size = new System.Drawing.Size(154, 20);
            this.txtbox_gmail.TabIndex = 1;
            // 
            // txtbox_senha
            // 
            this.txtbox_senha.Location = new System.Drawing.Point(26, 137);
            this.txtbox_senha.Name = "txtbox_senha";
            this.txtbox_senha.Size = new System.Drawing.Size(154, 20);
            this.txtbox_senha.TabIndex = 2;
            this.txtbox_senha.UseSystemPasswordChar = true;
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Location = new System.Drawing.Point(23, 121);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(38, 13);
            this.lbl_senha.TabIndex = 4;
            this.lbl_senha.Text = "Senha";
            // 
            // btn_candastrar
            // 
            this.btn_candastrar.Location = new System.Drawing.Point(26, 175);
            this.btn_candastrar.Name = "btn_candastrar";
            this.btn_candastrar.Size = new System.Drawing.Size(74, 33);
            this.btn_candastrar.TabIndex = 3;
            this.btn_candastrar.Text = "Cadastrar";
            this.btn_candastrar.UseVisualStyleBackColor = true;
            this.btn_candastrar.Click += new System.EventHandler(this.btn_candastrar_Click);
            // 
            // gpbox_login
            // 
            this.gpbox_login.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gpbox_login.Controls.Add(this.lbl_nome);
            this.gpbox_login.Controls.Add(this.txtbox_nome);
            this.gpbox_login.Controls.Add(this.lbl_gmail);
            this.gpbox_login.Controls.Add(this.btn_Entrar);
            this.gpbox_login.Controls.Add(this.txtbox_gmail);
            this.gpbox_login.Controls.Add(this.btn_candastrar);
            this.gpbox_login.Controls.Add(this.lbl_senha);
            this.gpbox_login.Controls.Add(this.txtbox_senha);
            this.gpbox_login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gpbox_login.Location = new System.Drawing.Point(290, 108);
            this.gpbox_login.Name = "gpbox_login";
            this.gpbox_login.Size = new System.Drawing.Size(211, 222);
            this.gpbox_login.TabIndex = 6;
            this.gpbox_login.TabStop = false;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(23, 16);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(95, 13);
            this.lbl_nome.TabIndex = 9;
            this.lbl_nome.Text = "Nome com 3 letras";
            // 
            // txtbox_nome
            // 
            this.txtbox_nome.Location = new System.Drawing.Point(26, 34);
            this.txtbox_nome.Name = "txtbox_nome";
            this.txtbox_nome.Size = new System.Drawing.Size(154, 20);
            this.txtbox_nome.TabIndex = 0;
            this.txtbox_nome.TextChanged += new System.EventHandler(this.txtbox_nome_TextChanged);
            this.txtbox_nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_nome_KeyPress);
            // 
            // lbl_gmail
            // 
            this.lbl_gmail.AutoSize = true;
            this.lbl_gmail.Location = new System.Drawing.Point(23, 66);
            this.lbl_gmail.Name = "lbl_gmail";
            this.lbl_gmail.Size = new System.Drawing.Size(33, 13);
            this.lbl_gmail.TabIndex = 8;
            this.lbl_gmail.Text = "Gmail";
            // 
            // btn_Entrar
            // 
            this.btn_Entrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Entrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Entrar.Location = new System.Drawing.Point(106, 175);
            this.btn_Entrar.Name = "btn_Entrar";
            this.btn_Entrar.Size = new System.Drawing.Size(74, 33);
            this.btn_Entrar.TabIndex = 4;
            this.btn_Entrar.Text = "Entrar";
            this.btn_Entrar.UseVisualStyleBackColor = false;
            this.btn_Entrar.Click += new System.EventHandler(this.btn_Entrar_Click);
            // 
            // lbl_sudoku
            // 
            this.lbl_sudoku.AutoSize = true;
            this.lbl_sudoku.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_sudoku.Font = new System.Drawing.Font("Microsoft Uighur", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sudoku.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbl_sudoku.Location = new System.Drawing.Point(349, 86);
            this.lbl_sudoku.Name = "lbl_sudoku";
            this.lbl_sudoku.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_sudoku.Size = new System.Drawing.Size(79, 38);
            this.lbl_sudoku.TabIndex = 7;
            this.lbl_sudoku.Text = "Sudoku";
            // 
            // tela_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 477);
            this.Controls.Add(this.lbl_sudoku);
            this.Controls.Add(this.gpbox_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tela_login";
            this.Text = "login";
            this.Load += new System.EventHandler(this.tela_login_Load);
            this.gpbox_login.ResumeLayout(false);
            this.gpbox_login.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtbox_gmail;
        private System.Windows.Forms.TextBox txtbox_senha;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.Button btn_candastrar;
        private System.Windows.Forms.GroupBox gpbox_login;
        private System.Windows.Forms.Button btn_Entrar;
        private System.Windows.Forms.Label lbl_sudoku;
        private System.Windows.Forms.Label lbl_gmail;
        private System.Windows.Forms.TextBox txtbox_nome;
        private System.Windows.Forms.Label lbl_nome;
    }
}


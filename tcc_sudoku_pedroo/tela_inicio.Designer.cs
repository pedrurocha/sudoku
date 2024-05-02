namespace tcc_sudoku_pedroo
{
    partial class tela_inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tela_inicio));
            this.rdbtn_facil = new System.Windows.Forms.RadioButton();
            this.rdbtn_dificil = new System.Windows.Forms.RadioButton();
            this.rdbtn_normal = new System.Windows.Forms.RadioButton();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_jogar = new System.Windows.Forms.Button();
            this.lbl_sudoku = new System.Windows.Forms.Label();
            this.dtgridv_pessoas = new System.Windows.Forms.DataGridView();
            this.lbl_rankingg = new System.Windows.Forms.Label();
            this.btn_conta = new System.Windows.Forms.Button();
            this.gpbox_visao = new System.Windows.Forms.GroupBox();
            this.rdbtn_visual = new System.Windows.Forms.RadioButton();
            this.rdbtn_nvisual = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridv_pessoas)).BeginInit();
            this.gpbox_visao.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbtn_facil
            // 
            this.rdbtn_facil.AutoSize = true;
            this.rdbtn_facil.Location = new System.Drawing.Point(408, 390);
            this.rdbtn_facil.Name = "rdbtn_facil";
            this.rdbtn_facil.Size = new System.Drawing.Size(47, 17);
            this.rdbtn_facil.TabIndex = 1;
            this.rdbtn_facil.TabStop = true;
            this.rdbtn_facil.Text = "Facil";
            this.rdbtn_facil.UseVisualStyleBackColor = true;
            // 
            // rdbtn_dificil
            // 
            this.rdbtn_dificil.AutoSize = true;
            this.rdbtn_dificil.BackColor = System.Drawing.SystemColors.Control;
            this.rdbtn_dificil.Location = new System.Drawing.Point(552, 390);
            this.rdbtn_dificil.Name = "rdbtn_dificil";
            this.rdbtn_dificil.Size = new System.Drawing.Size(50, 17);
            this.rdbtn_dificil.TabIndex = 3;
            this.rdbtn_dificil.TabStop = true;
            this.rdbtn_dificil.Text = "Dificil";
            this.rdbtn_dificil.UseVisualStyleBackColor = false;
            // 
            // rdbtn_normal
            // 
            this.rdbtn_normal.AutoSize = true;
            this.rdbtn_normal.Location = new System.Drawing.Point(473, 390);
            this.rdbtn_normal.Name = "rdbtn_normal";
            this.rdbtn_normal.Size = new System.Drawing.Size(58, 17);
            this.rdbtn_normal.TabIndex = 2;
            this.rdbtn_normal.TabStop = true;
            this.rdbtn_normal.Text = "Normal";
            this.rdbtn_normal.UseVisualStyleBackColor = true;
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_sair.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_sair.Location = new System.Drawing.Point(608, 34);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(106, 35);
            this.btn_sair.TabIndex = 0;
            this.btn_sair.Text = "Sair";
            this.btn_sair.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_jogar
            // 
            this.btn_jogar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_jogar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_jogar.Location = new System.Drawing.Point(608, 378);
            this.btn_jogar.Name = "btn_jogar";
            this.btn_jogar.Size = new System.Drawing.Size(106, 40);
            this.btn_jogar.TabIndex = 4;
            this.btn_jogar.Text = "Jogar";
            this.btn_jogar.UseVisualStyleBackColor = false;
            this.btn_jogar.Click += new System.EventHandler(this.btn_jogar_Click);
            // 
            // lbl_sudoku
            // 
            this.lbl_sudoku.AutoSize = true;
            this.lbl_sudoku.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_sudoku.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sudoku.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbl_sudoku.Location = new System.Drawing.Point(43, 49);
            this.lbl_sudoku.Name = "lbl_sudoku";
            this.lbl_sudoku.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_sudoku.Size = new System.Drawing.Size(122, 33);
            this.lbl_sudoku.TabIndex = 11;
            this.lbl_sudoku.Text = "Ranking";
            // 
            // dtgridv_pessoas
            // 
            this.dtgridv_pessoas.AllowUserToAddRows = false;
            this.dtgridv_pessoas.AllowUserToDeleteRows = false;
            this.dtgridv_pessoas.AllowUserToResizeColumns = false;
            this.dtgridv_pessoas.AllowUserToResizeRows = false;
            this.dtgridv_pessoas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgridv_pessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridv_pessoas.GridColor = System.Drawing.Color.MediumAquamarine;
            this.dtgridv_pessoas.Location = new System.Drawing.Point(50, 90);
            this.dtgridv_pessoas.Name = "dtgridv_pessoas";
            this.dtgridv_pessoas.Size = new System.Drawing.Size(664, 282);
            this.dtgridv_pessoas.TabIndex = 14;
            this.dtgridv_pessoas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgridv_pessoas_CellContentClick_1);
            this.dtgridv_pessoas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtgridv_pessoas_KeyPress);
            // 
            // lbl_rankingg
            // 
            this.lbl_rankingg.AutoSize = true;
            this.lbl_rankingg.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_rankingg.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rankingg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbl_rankingg.Location = new System.Drawing.Point(171, 49);
            this.lbl_rankingg.Name = "lbl_rankingg";
            this.lbl_rankingg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_rankingg.Size = new System.Drawing.Size(31, 33);
            this.lbl_rankingg.TabIndex = 15;
            this.lbl_rankingg.Text = "a";
            this.lbl_rankingg.Click += new System.EventHandler(this.lbl_rankingg_Click);
            // 
            // btn_conta
            // 
            this.btn_conta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_conta.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_conta.Location = new System.Drawing.Point(496, 35);
            this.btn_conta.Name = "btn_conta";
            this.btn_conta.Size = new System.Drawing.Size(106, 35);
            this.btn_conta.TabIndex = 16;
            this.btn_conta.Text = "Conta";
            this.btn_conta.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_conta.UseVisualStyleBackColor = false;
            this.btn_conta.Click += new System.EventHandler(this.btn_conta_Click);
            // 
            // gpbox_visao
            // 
            this.gpbox_visao.Controls.Add(this.rdbtn_nvisual);
            this.gpbox_visao.Controls.Add(this.rdbtn_visual);
            this.gpbox_visao.Location = new System.Drawing.Point(228, 378);
            this.gpbox_visao.Name = "gpbox_visao";
            this.gpbox_visao.Size = new System.Drawing.Size(140, 83);
            this.gpbox_visao.TabIndex = 17;
            this.gpbox_visao.TabStop = false;
            this.gpbox_visao.Text = "ajudas visuais";
            // 
            // rdbtn_visual
            // 
            this.rdbtn_visual.AutoSize = true;
            this.rdbtn_visual.Location = new System.Drawing.Point(6, 19);
            this.rdbtn_visual.Name = "rdbtn_visual";
            this.rdbtn_visual.Size = new System.Drawing.Size(91, 17);
            this.rdbtn_visual.TabIndex = 0;
            this.rdbtn_visual.TabStop = true;
            this.rdbtn_visual.Text = "ajudas visuais";
            this.rdbtn_visual.UseVisualStyleBackColor = true;
            this.rdbtn_visual.CheckedChanged += new System.EventHandler(this.rdbtn_visual_CheckedChanged);
            // 
            // rdbtn_nvisual
            // 
            this.rdbtn_nvisual.AutoSize = true;
            this.rdbtn_nvisual.Location = new System.Drawing.Point(6, 42);
            this.rdbtn_nvisual.Name = "rdbtn_nvisual";
            this.rdbtn_nvisual.Size = new System.Drawing.Size(113, 17);
            this.rdbtn_nvisual.TabIndex = 18;
            this.rdbtn_nvisual.TabStop = true;
            this.rdbtn_nvisual.Text = "sem ajudas visuais";
            this.rdbtn_nvisual.UseVisualStyleBackColor = true;
            this.rdbtn_nvisual.CheckedChanged += new System.EventHandler(this.rdbtn_nvisual_CheckedChanged);
            // 
            // tela_inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 473);
            this.Controls.Add(this.gpbox_visao);
            this.Controls.Add(this.btn_conta);
            this.Controls.Add(this.lbl_rankingg);
            this.Controls.Add(this.dtgridv_pessoas);
            this.Controls.Add(this.lbl_sudoku);
            this.Controls.Add(this.btn_jogar);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.rdbtn_normal);
            this.Controls.Add(this.rdbtn_dificil);
            this.Controls.Add(this.rdbtn_facil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tela_inicio";
            this.Text = "tela_inicio";
            this.Load += new System.EventHandler(this.tela_inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgridv_pessoas)).EndInit();
            this.gpbox_visao.ResumeLayout(false);
            this.gpbox_visao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rdbtn_facil;
        private System.Windows.Forms.RadioButton rdbtn_dificil;
        private System.Windows.Forms.RadioButton rdbtn_normal;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_jogar;
        private System.Windows.Forms.Label lbl_sudoku;
        private System.Windows.Forms.DataGridView dtgridv_pessoas;
        private System.Windows.Forms.Label lbl_rankingg;
        private System.Windows.Forms.Button btn_conta;
        private System.Windows.Forms.GroupBox gpbox_visao;
        private System.Windows.Forms.RadioButton rdbtn_nvisual;
        private System.Windows.Forms.RadioButton rdbtn_visual;
    }
}
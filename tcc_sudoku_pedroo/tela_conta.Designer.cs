namespace tcc_sudoku_pedroo
{
    partial class tela_conta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tela_conta));
            this.btn_voltar = new System.Windows.Forms.Button();
            this.rdbtn_facil = new System.Windows.Forms.RadioButton();
            this.lbl_melhor = new System.Windows.Forms.Label();
            this.rdbtn_dificil = new System.Windows.Forms.RadioButton();
            this.rdbtn_normal = new System.Windows.Forms.RadioButton();
            this.dtgridv_pessoas = new System.Windows.Forms.DataGridView();
            this.lbl_tempo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridv_pessoas)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_voltar.Location = new System.Drawing.Point(663, 40);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(89, 37);
            this.btn_voltar.TabIndex = 286;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // rdbtn_facil
            // 
            this.rdbtn_facil.AutoSize = true;
            this.rdbtn_facil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_facil.Location = new System.Drawing.Point(280, 374);
            this.rdbtn_facil.Name = "rdbtn_facil";
            this.rdbtn_facil.Size = new System.Drawing.Size(60, 24);
            this.rdbtn_facil.TabIndex = 287;
            this.rdbtn_facil.TabStop = true;
            this.rdbtn_facil.Text = "Facil";
            this.rdbtn_facil.UseVisualStyleBackColor = true;
            this.rdbtn_facil.CheckedChanged += new System.EventHandler(this.rdbtn_facil_CheckedChanged);
            // 
            // lbl_melhor
            // 
            this.lbl_melhor.AutoSize = true;
            this.lbl_melhor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_melhor.Location = new System.Drawing.Point(1, 40);
            this.lbl_melhor.Name = "lbl_melhor";
            this.lbl_melhor.Size = new System.Drawing.Size(162, 29);
            this.lbl_melhor.TabIndex = 289;
            this.lbl_melhor.Text = "melhor tempo";
            // 
            // rdbtn_dificil
            // 
            this.rdbtn_dificil.AutoSize = true;
            this.rdbtn_dificil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_dificil.Location = new System.Drawing.Point(459, 374);
            this.rdbtn_dificil.Name = "rdbtn_dificil";
            this.rdbtn_dificil.Size = new System.Drawing.Size(64, 24);
            this.rdbtn_dificil.TabIndex = 290;
            this.rdbtn_dificil.TabStop = true;
            this.rdbtn_dificil.Text = "Dificil";
            this.rdbtn_dificil.UseVisualStyleBackColor = true;
            this.rdbtn_dificil.CheckedChanged += new System.EventHandler(this.rdbtn_dificil_CheckedChanged);
            // 
            // rdbtn_normal
            // 
            this.rdbtn_normal.AutoSize = true;
            this.rdbtn_normal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_normal.Location = new System.Drawing.Point(363, 374);
            this.rdbtn_normal.Name = "rdbtn_normal";
            this.rdbtn_normal.Size = new System.Drawing.Size(77, 24);
            this.rdbtn_normal.TabIndex = 291;
            this.rdbtn_normal.TabStop = true;
            this.rdbtn_normal.Text = "Normal";
            this.rdbtn_normal.UseVisualStyleBackColor = true;
            this.rdbtn_normal.CheckedChanged += new System.EventHandler(this.rdbtn_normal_CheckedChanged);
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
            this.dtgridv_pessoas.Location = new System.Drawing.Point(88, 86);
            this.dtgridv_pessoas.Name = "dtgridv_pessoas";
            this.dtgridv_pessoas.Size = new System.Drawing.Size(664, 282);
            this.dtgridv_pessoas.TabIndex = 292;
            this.dtgridv_pessoas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgridv_pessoas_CellContentClick);
            // 
            // lbl_tempo
            // 
            this.lbl_tempo.AutoSize = true;
            this.lbl_tempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tempo.Location = new System.Drawing.Point(182, 40);
            this.lbl_tempo.Name = "lbl_tempo";
            this.lbl_tempo.Size = new System.Drawing.Size(0, 29);
            this.lbl_tempo.TabIndex = 293;
            this.lbl_tempo.Click += new System.EventHandler(this.lbl_tempo_Click);
            // 
            // tela_conta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 471);
            this.Controls.Add(this.lbl_tempo);
            this.Controls.Add(this.dtgridv_pessoas);
            this.Controls.Add(this.rdbtn_normal);
            this.Controls.Add(this.rdbtn_dificil);
            this.Controls.Add(this.lbl_melhor);
            this.Controls.Add(this.rdbtn_facil);
            this.Controls.Add(this.btn_voltar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tela_conta";
            this.Text = "tela_conta";
            this.Load += new System.EventHandler(this.tela_conta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgridv_pessoas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.RadioButton rdbtn_facil;
        private System.Windows.Forms.Label lbl_melhor;
        private System.Windows.Forms.RadioButton rdbtn_dificil;
        private System.Windows.Forms.RadioButton rdbtn_normal;
        private System.Windows.Forms.DataGridView dtgridv_pessoas;
        private System.Windows.Forms.Label lbl_tempo;
    }
}
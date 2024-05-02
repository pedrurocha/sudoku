namespace tcc_sudoku_pedroo
{
    partial class tela_adm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tela_adm));
            this.btn_sair = new System.Windows.Forms.Button();
            this.lbl_total = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_partidas = new System.Windows.Forms.Button();
            this.lbl_umx = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_sair.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_sair.Location = new System.Drawing.Point(630, 55);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(106, 35);
            this.btn_sair.TabIndex = 5;
            this.btn_sair.Text = "Sair";
            this.btn_sair.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(377, 70);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(18, 20);
            this.lbl_total.TabIndex = 6;
            this.lbl_total.Text = "a";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Total de pessoas logadas no sudoku :";
            // 
            // btn_partidas
            // 
            this.btn_partidas.Location = new System.Drawing.Point(516, 333);
            this.btn_partidas.Name = "btn_partidas";
            this.btn_partidas.Size = new System.Drawing.Size(146, 54);
            this.btn_partidas.TabIndex = 12;
            this.btn_partidas.Text = "novo ranking";
            this.btn_partidas.UseVisualStyleBackColor = true;
            this.btn_partidas.Click += new System.EventHandler(this.btn_partidas_Click);
            // 
            // lbl_umx
            // 
            this.lbl_umx.AutoSize = true;
            this.lbl_umx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_umx.Location = new System.Drawing.Point(600, 296);
            this.lbl_umx.Name = "lbl_umx";
            this.lbl_umx.Size = new System.Drawing.Size(25, 20);
            this.lbl_umx.TabIndex = 20;
            this.lbl_umx.Text = "1x";
            this.lbl_umx.Click += new System.EventHandler(this.lbl_umx_Click);
            // 
            // tela_adm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 478);
            this.Controls.Add(this.lbl_umx);
            this.Controls.Add(this.btn_partidas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.btn_sair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tela_adm";
            this.Text = "tela_adm";
            this.Load += new System.EventHandler(this.tela_adm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_partidas;
        private System.Windows.Forms.Label lbl_umx;
    }
}
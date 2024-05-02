using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace tcc_sudoku_pedroo
{
    public partial class tela_inicio : Form
    {
        string rdbtn = "";
      
        public tela_inicio()
        {
            InitializeComponent();
           
        }

        private void tela_inicio_Load(object sender, EventArgs e)
        {
            dtgridv_pessoas.Columns.Add("Nome", "Nome");
            dtgridv_pessoas.Columns.Add("Partidas", "Partidas");
            dtgridv_pessoas.Columns.Add("Pontos", "Pontos");
            dtgridv_pessoas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

          
           
            string Ranking = Usuario.Ranking;
            lbl_rankingg.Text = Usuario.Ranking;
              try
               {  

            {

                 
                    using (SqlConnection conexao = sudoku.ObterConexao())
                    {
                       

                        string consulta = "SELECT * FROM Login WHERE Ranking = @Ranking ORDER BY Pontos DESC, Partidas ASC;";
                        SqlCommand command = new SqlCommand(consulta, conexao);
                        command.Parameters.AddWithValue("@Ranking",Ranking);


                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            // Adicione os dados à DataGridView
                            dtgridv_pessoas.Rows.Add(reader["Nome"], reader["Partidas"], reader["Pontos"]);
                          
                        }
                    }  
                        conexao.Close();
                    }
                }
                    
              }
            catch 
            {
                MessageBox.Show("Erro ao imprimir todos as pessoas desta Ranking");
            }

          
        
            dtgridv_pessoas.ReadOnly = true;   
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            tela_login tela_Entrar = new tela_login();
            tela_Entrar.Show();
            this.Hide(); 
           
        }

        private void btn_jogar_Click(object sender, EventArgs e)
        {

            string rdbtnn = rdbtn;
            if (rdbtnn == "visual")
            {
                if (rdbtn_facil.Checked)
                {
                    sudoku.Nivel = 40;
                    sudoku.Tempo = 10;
                    sudoku.Variavel = 10;
                    sudoku.Nivell = "Facil";
                    sudoku.visual = "1";
                    sudoku.ponto = 0;

                    tela_sudoku tela_Entrar = new tela_sudoku();
                    tela_Entrar.Show();
                    this.Hide();
                }

                if (rdbtn_normal.Checked)
                {
                    sudoku.Nivel = 32;
                    sudoku.Tempo = 15;
                    sudoku.Variavel = 12;
                    sudoku.Nivell = "Normal";
                    sudoku.visual = "1";
                    sudoku.ponto = 0;

                    tela_sudoku tela_Entrar = new tela_sudoku();
                    tela_Entrar.Show();
                    this.Hide();
                }
                if (rdbtn_dificil.Checked)
                {
                    sudoku.Nivel = 28;
                    sudoku.Tempo = 20;
                    sudoku.Variavel = 12;
                    sudoku.Nivell = "Dificil";
                    sudoku.visual = "1";
                    sudoku.ponto = 0;

                    tela_sudoku tela_Entrar = new tela_sudoku();
                    tela_Entrar.Show();
                    this.Hide();
                }
            }

            if (rdbtnn == "não visual")
            {
                if (rdbtn_facil.Checked)
                {
                    sudoku.Nivel = 40;
                    sudoku.Tempo = 10;
                    sudoku.Variavel = 10;
                    sudoku.Nivell = "Facil";
                    sudoku.visual = "2";
                    sudoku.ponto = 3;

                    tela_sudoku tela_Entrar = new tela_sudoku();
                    tela_Entrar.Show();
                    this.Hide();
                }

                if (rdbtn_normal.Checked)
                {
                    sudoku.Nivel = 32;
                    sudoku.Tempo = 15;
                    sudoku.Variavel = 12;
                    sudoku.Nivell = "Normal";
                    sudoku.visual = "2";
                    sudoku.ponto = 3;

                    tela_sudoku tela_Entrar = new tela_sudoku();
                    tela_Entrar.Show();
                    this.Hide();
                }
                if (rdbtn_dificil.Checked)
                {
                    sudoku.Nivel = 80;
                    sudoku.Tempo = 20;
                    sudoku.Variavel = 5;
                    sudoku.Nivell = "Dificil";
                    sudoku.visual = "2";
                    sudoku.ponto = 3;

                    tela_sudoku tela_Entrar = new tela_sudoku();
                    tela_Entrar.Show();
                    this.Hide();
                }
            }


        }

        

        private void gpbox_pessoas_Enter(object sender, EventArgs e)
        {

        }

        private void dtgridv_pessoas_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dtgridv_pessoas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar)) //Este trecho de código verifica se o caractere pressionado
            {
                e.Handled = true; // Impede que o caractere seja inserido na TextBox.
            }

             if (!char.IsLetterOrDigit(e.KeyChar)) //Este trecho de código verifica se o caractere pressionado
            {
                e.Handled = true; // Impede que o caractere seja inserido na TextBox.
            }
        }

        private void btn_conta_Click(object sender, EventArgs e)
        {
            tela_conta tela_Entrar = new tela_conta();
            tela_Entrar.Show();
            this.Hide();
        }

        private void lbl_rankingg_Click(object sender, EventArgs e)
        {

        }

        private void rdbtn_visual_CheckedChanged(object sender, EventArgs e)
        {
            rdbtn = "visual";
        }

        private void rdbtn_nvisual_CheckedChanged(object sender, EventArgs e)
        {
            rdbtn = "não visual";
        }
    }
}

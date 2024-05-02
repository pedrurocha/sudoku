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

namespace tcc_sudoku_pedroo
{
    public partial class tela_adm : Form
    {
        public tela_adm()
        {
            InitializeComponent();
        } 

     

        private void tela_adm_Load(object sender, EventArgs e)
        {
          

            using (SqlConnection conexao = sudoku.ObterConexao())
            {
                
                string consulta = "SELECT count(Nome) AS total FROM Login";
                SqlCommand command = new SqlCommand(consulta, conexao);

               
                using (SqlDataReader ler = command.ExecuteReader())
                {

                    while (ler.Read())
                    {
                        lbl_total.Text = ler["total"].ToString();
                    }
                }
                conexao.Close();
            }
        }


        private void btn_sair_Click(object sender, EventArgs e)
        {
            tela_login tela_Entrar = new tela_login();
            tela_Entrar.Show();
            this.Hide();
        }

        private void btn_partidas_Click(object sender, EventArgs e)
        {


            ouro();

            for (int i = 0; i < 3; i++)
            {
                prata();
            }

            for (int i = 0; i < 3; i++)
            {
                bronze();         
            }

            partida();
            pontos();
            MessageBox.Show("deu certo a alteração!");
        }

   public void partida()
        {
            try
            {
                string conexaoSql = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\tcc_sudoku_pedro\tcc_sudoku_pedroo\tcc_sudoku_pedroo\bd_login.mdf;Integrated Security=True";

                using (SqlConnection conexao = new SqlConnection(conexaoSql))
                {
                    conexao.Open();


                    string consultaOuroParaDiamante = "UPDATE Login SET Partidas = 0";
                    SqlCommand commandOuroParaDiamante = new SqlCommand(consultaOuroParaDiamante, conexao);
                    commandOuroParaDiamante.ExecuteNonQuery();
                    conexao.Close();
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar rankings: " + ex.Message);
            }
        }

        public void pontos()
        {
            try
            {
                string conexaoSql = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\tcc_sudoku_pedro\tcc_sudoku_pedroo\tcc_sudoku_pedroo\bd_login.mdf;Integrated Security=True";

                using (SqlConnection conexao = new SqlConnection(conexaoSql))
                {
                    conexao.Open();


                    string consultaOuroParaDiamante = "UPDATE Login SET Pontos = 0";
                    SqlCommand commandOuroParaDiamante = new SqlCommand(consultaOuroParaDiamante, conexao);
                    commandOuroParaDiamante.ExecuteNonQuery();
                    conexao.Close();
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar rankings: " + ex.Message);
            }
        }

        public void bronze()
        {
            try
            {
                string conexaoSql = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\tcc_sudoku_pedro\tcc_sudoku_pedroo\tcc_sudoku_pedroo\bd_login.mdf;Integrated Security=True";

                using (SqlConnection conexao = new SqlConnection(conexaoSql))
                {
                    conexao.Open();


                    string consultaBronzeParaPrata = "UPDATE Login SET Ranking = 'Prata' WHERE Ranking = 'Bronze' AND Pontos = (SELECT MAX(Pontos) FROM Login WHERE Ranking = 'Bronze')";
                    SqlCommand commandBronzeParaPrata = new SqlCommand(consultaBronzeParaPrata, conexao);
                    commandBronzeParaPrata.ExecuteNonQuery();
                    conexao.Close();
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar rankings: " + ex.Message);
            }
        }

        public void prata()
        {
            try
            {
                string conexaoSql = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\tcc_sudoku_pedro\tcc_sudoku_pedroo\tcc_sudoku_pedroo\bd_login.mdf;Integrated Security=True";

                using (SqlConnection conexao = new SqlConnection(conexaoSql))
                {
                    conexao.Open();


                    string consultaPrataParaOuro = "UPDATE Login SET Ranking = 'Ouro' WHERE Ranking = 'Prata' AND Pontos = (SELECT MAX(Pontos) FROM Login WHERE Ranking = 'Prata')";
                    SqlCommand commandPrataParaOuro = new SqlCommand(consultaPrataParaOuro, conexao);
                    commandPrataParaOuro.ExecuteNonQuery();
                    conexao.Close();
                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar rankings: " + ex.Message);
            }
        }

        public void ouro()
        {
            try
            {
                string conexaoSql = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\tcc_sudoku_pedro\tcc_sudoku_pedroo\tcc_sudoku_pedroo\bd_login.mdf;Integrated Security=True";

                using (SqlConnection conexao = new SqlConnection(conexaoSql))
                {
                    conexao.Open();


                    string consultaOuroParaDiamante = "UPDATE Login SET Ranking = 'Diamante' WHERE Ranking = 'Ouro' AND Pontos = (SELECT MAX(Pontos) FROM Login WHERE Ranking = 'Ouro')";
                    SqlCommand commandOuroParaDiamante = new SqlCommand(consultaOuroParaDiamante, conexao);
                    commandOuroParaDiamante.ExecuteNonQuery();
                    conexao.Close();
                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar rankings: " + ex.Message);
            }
        }

        private void lbl_umx_Click(object sender, EventArgs e)
        {

        }
    }
    }

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
    public partial class tela_conta : Form
    {

      
        public tela_conta()
        {
            InitializeComponent();
        }


        private void btn_voltar_Click(object sender, EventArgs e)
        {
            tela_inicio tela_Entrar = new tela_inicio();
            tela_Entrar.Show();
            this.Hide();
        }

        private void tela_conta_Load(object sender, EventArgs e)
        {
            dtgridv_pessoas.Columns.Add("Tempo", "Tempo");
            dtgridv_pessoas.Columns.Add("Nivel", "Nivel");
            dtgridv_pessoas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void rdbtn_facil_CheckedChanged(object sender, EventArgs e)
        {
           dtgridv_pessoas.Rows.Clear();

            string Nivel = "Facil";
            string Email = Usuario.Gmail;
           

            try
            {

                {

                   
                    using (SqlConnection conexao = sudoku.ObterConexao())
                    {
                        

                        string consulta = "SELECT * FROM Historico WHERE Nivel = @Nivel AND Email = @Email ORDER BY id ASC;";
                        SqlCommand command = new SqlCommand(consulta, conexao);
                        command.Parameters.AddWithValue("@Nivel", Nivel);
                        command.Parameters.AddWithValue("@Email", Email);



                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                              
                                dtgridv_pessoas.Rows.Add(reader["Tempo"], reader["Nivel"]);

                            }
                        }
                        conexao.Close();
                    }
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }


            lbl_tempo.Text = " ";
            try
            {

                {


                    using (SqlConnection conexao = sudoku.ObterConexao())
                    {


                        string consulta = "SELECT TOP 1 Tempo FROM Historico WHERE Nivel = @Nivel AND Email = @Email ORDER BY Tempo ASC;";
                        SqlCommand command = new SqlCommand(consulta, conexao);
                        command.Parameters.AddWithValue("@Nivel", Nivel);
                        command.Parameters.AddWithValue("@Email", Email);



                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {

                                lbl_tempo.Text = reader["Tempo"].ToString();

                            }
                        }
                        conexao.Close();
                    }
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void dtgridv_pessoas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rdbtn_normal_CheckedChanged(object sender, EventArgs e)
        {
            dtgridv_pessoas.Rows.Clear();

            string Nivel = "Normal";
            string Email = Usuario.Gmail;
          

            try
            {

                {

                   
                    using (SqlConnection conexao = sudoku.ObterConexao())
                    {
                       

                        string consulta = "SELECT * FROM Historico WHERE Nivel = @Nivel AND Email = @Email ORDER BY id ASC;";
                        SqlCommand command = new SqlCommand(consulta, conexao);
                        command.Parameters.AddWithValue("@Nivel", Nivel);
                        command.Parameters.AddWithValue("@Email", Email);



                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                              
                                dtgridv_pessoas.Rows.Add(reader["Tempo"], reader["Nivel"]);

                            }
                        }
                        conexao.Close();
                    }
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }



            try
            {

                {


                    using (SqlConnection conexao = sudoku.ObterConexao())
                    {


                        string consulta = "SELECT TOP 1 Tempo FROM Historico WHERE Nivel = @Nivel AND Email = @Email ORDER BY Tempo ASC;";
                        SqlCommand command = new SqlCommand(consulta, conexao);
                        command.Parameters.AddWithValue("@Nivel", Nivel);
                        command.Parameters.AddWithValue("@Email", Email);



                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {

                                lbl_tempo.Text = reader["Tempo"].ToString();

                            }
                        }
                        conexao.Close();
                    }
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void rdbtn_dificil_CheckedChanged(object sender, EventArgs e)
        {
            dtgridv_pessoas.Rows.Clear();

            string Nivel = "Dificil";
            string Email = Usuario.Gmail;
          

            try
            {

                {

                
                    using (SqlConnection conexao = sudoku.ObterConexao())
                    {
                      

                        string consulta = "SELECT * FROM Historico WHERE Nivel = @Nivel AND Email = @Email ORDER BY id DESC;";
                        SqlCommand command = new SqlCommand(consulta, conexao);
                        command.Parameters.AddWithValue("@Nivel", Nivel);
                        command.Parameters.AddWithValue("@Email", Email);



                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                              
                                dtgridv_pessoas.Rows.Add(reader["Tempo"], reader["Nivel"]);

                            }
                        }
                        conexao.Close();
                    }
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }



            try
            {

                {


                    using (SqlConnection conexao = sudoku.ObterConexao())
                    {


                        string consulta = "SELECT TOP 1 Tempo FROM Historico WHERE Nivel = @Nivel AND Email = @Email ORDER BY Tempo ASC;";
                        SqlCommand command = new SqlCommand(consulta, conexao);
                        command.Parameters.AddWithValue("@Nivel", Nivel);
                        command.Parameters.AddWithValue("@Email", Email);



                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {

                                lbl_tempo.Text = reader["Tempo"].ToString();

                            }
                        }
                        conexao.Close();
                    }
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void lbl_tempo_Click(object sender, EventArgs e)
        {

        }
    }
}

// order by desc id
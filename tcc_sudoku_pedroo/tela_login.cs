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
    public partial class tela_login : Form
    {
        public tela_login()
        {
            InitializeComponent();
        }

        private void tela_login_Load(object sender, EventArgs e)
        {
         
        }


             private void btn_Entrar_Click(object sender, EventArgs e)
        {
            string email = "adm";

            if (txtbox_nome.Text.Length < 3)
            {
                MessageBox.Show("O nome deve ter no mínimo 3 caracteres.");
                txtbox_nome.Clear();
                return; // Impedir que o restante do código seja executado
            }
            else if (txtbox_senha.Text.Length <= 0)
            {
                MessageBox.Show("Escreva sua senha!!");

                return; 
            }
            else if (txtbox_gmail.Text.Length <= 0)
            {
                MessageBox.Show("Escreva seu Email!!");

                return; 
            }


            try
            {
                
                SqlConnection conexao = sudoku.ObterConexao();
                string loginUser = txtbox_gmail.Text;
                string senha = txtbox_senha.Text;
                string nome = txtbox_nome.Text;

                string consulta = "SELECT * FROM Login WHERE Email = @loginUser";
                SqlCommand command = new SqlCommand(consulta, conexao);

                command.Parameters.AddWithValue("@loginUser", loginUser);
            using (SqlDataReader ler = command.ExecuteReader())
            {
                    
                while (ler.Read())
                {

                        if (ler["Email"].ToString() == email && ler["senha"].ToString() == senha)
                        {
                            // tela do admm
                            tela_adm tela_adm = new tela_adm();
                            tela_adm.Show();
                            this.Hide();
                        }

                        else if (ler["Email"].ToString() == loginUser && ler["Senha"].ToString() == senha)
                        {
                            Usuario.Ranking = ler["Ranking"].ToString();
                            Usuario.Gmail = ler["Email"].ToString();

                            MessageBox.Show("bem vindo de volta " + ler["nome"].ToString());
                            tela_inicio tela_inicio = new tela_inicio();
                            tela_inicio.Show();
                            this.Hide();
                        }

                        else if (ler["Email"].ToString() == loginUser && ler["Senha"].ToString() != senha)
                        {
                            MessageBox.Show("o Gmail ou a Senha estão erradas,tente de novo!");
                        }

                        else 
                        {
                            MessageBox.Show("Houve algum problema na hora de logar,tente de novo!");
                        }

                    }
                }
                conexao.Close();


            }
          catch (Exception ex) { MessageBox.Show(ex.Message); }
            

        }

        private void btn_candastrar_Click(object sender, EventArgs e)
        {
            if (txtbox_nome.Text.Length < 3)
            {
                MessageBox.Show("O nome deve ter no mínimo 3 caracteres.");
                txtbox_nome.Clear();
                return; // Impede que o restante do código seja executado
            }
            else if (txtbox_senha.Text.Length <= 0)
            {
                MessageBox.Show("Escreva sua senha!!");

                return; // Impede que o restante do código seja executado
            }
            else if (txtbox_gmail.Text.Length <= 0)
            {
                MessageBox.Show("Escreva seu Email!!");

                return; // Impede que o restante do código seja executado
            }

            try
            {

                using (SqlConnection conexao = sudoku.ObterConexao())
                {

                    string email = txtbox_gmail.Text;
                    string senha = txtbox_senha.Text;
                    string nome = txtbox_nome.Text;

                    // Verifica se o email já existe na tabela de login
                    string consultaEmail = "SELECT COUNT(*) FROM Login WHERE Email = @email";
                    using (SqlCommand commandEmail = new SqlCommand(consultaEmail, conexao))
                    {
                        commandEmail.Parameters.AddWithValue("@email", email);
                        int countEmail = (int)commandEmail.ExecuteScalar();

                        if (countEmail > 0)
                        {
                            MessageBox.Show("O email já está em uso. Escolha outro email.");
                        }
                        else
                        {
                            // Verifica se o nome já existe na tabela de login
                            string consultaNome = "SELECT COUNT(*) FROM Login WHERE Nome = @nome";
                            using (SqlCommand commandNome = new SqlCommand(consultaNome, conexao))
                            {
                                commandNome.Parameters.AddWithValue("@nome", nome);
                                int countNome = (int)commandNome.ExecuteScalar();

                                if (countNome > 0)
                                {
                                    MessageBox.Show("O nome já está em uso. Escolha outro nome.");
                                }
                                else
                                {
                                    // Insere o novo usuário na tabela de login
                                    string inserirQuery = "INSERT INTO Login (Email, Senha, Nome, Ranking, Pontos,Partidas) VALUES (@email, @senha, @nome, 'Bronze',0,0)";
                                    using (SqlCommand insertCommand = new SqlCommand(inserirQuery, conexao))
                                    {
                                        insertCommand.Parameters.AddWithValue("@email", email);
                                        insertCommand.Parameters.AddWithValue("@senha", senha);
                                        insertCommand.Parameters.AddWithValue("@nome", nome);

                                        int linhasAfetadas = insertCommand.ExecuteNonQuery();

                                        if (linhasAfetadas > 0)
                                        {
                                            Usuario.Ranking = "Bronze";
                                            Usuario.Gmail = txtbox_gmail.Text;
                                            MessageBox.Show("Conta criada com sucesso!");

                                            tela_inicio tela_inicio = new tela_inicio();
                                            tela_inicio.Show();
                                            this.Hide();
                                        }
                                        conexao.Close();
                                    }
                                }
                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

        }

        private void txtbox_nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            // limite para 3 no nome
            int limite = 3;
            if (txtbox_nome.Text.Length == limite)
            {
                MessageBox.Show("O nome deve ter no máximo 3 letras!!");
                e.Handled = true;
                txtbox_nome.Clear();
            }

        }

        private void txtbox_nome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
// ajeitar o  bd para logar certinho

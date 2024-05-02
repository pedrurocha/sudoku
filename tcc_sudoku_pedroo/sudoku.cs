using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tcc_sudoku_pedroo
{
    internal class sudoku
    {
        public static int Nivel;
        public static int Tempo;
        public static int Variavel;
        public static string Nivell;
        public static string visual = "";
        public static int ponto;


        public static SqlConnection ObterConexao()
        {
            // Obtenha o diretório base do aplicativo
            string diretorioBase = AppDomain.CurrentDomain.BaseDirectory;

            // Construa o caminho completo do arquivo de banco de dados
            string caminhoBancoDeDados = Path.Combine(diretorioBase, "bd_login.mdf");

            // Construa a string de conexão
            string conexaoSql = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={caminhoBancoDeDados};Integrated Security=True";

            // Crie e abra a conexão
            SqlConnection conexao = new SqlConnection(conexaoSql);
            conexao.Open();

            return conexao;
        }

    }
}
                                                
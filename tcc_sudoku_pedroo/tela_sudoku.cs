using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Threading;




namespace tcc_sudoku_pedroo
{
    public partial class tela_sudoku : Form
    {
        private int errorCount = 0;

        private TextBox textBoxSelecionada; // Variável para armazenar a TextBox selecionada
        private List<TextBox> textBoxes; // Lista de TextBoxes
        private int[,] sudokuGrid; // Matriz para manter os números do Sudoku

        private TextBox lastClickedTextBox; // Armazena o último TextBox clicado.

        private bool[,] usedCells; // Matriz para rastrear as células usadas
        private Random random = new Random(); // Objeto Random para gerar números aleatórios

        private System.Windows.Forms.Timer countdownTimer; // timer pro cronometro

        private Stopwatch Timer; // Segundo cronômetro 
        private DateTime tempoInicial; // Variável para armazenar o tempo inicial


        public double TempoFinal { get; private set; }


   
        public tela_sudoku()
        {
            InitializeComponent(); // Inicializa o formulário (interface gráfica).
            InitializeSudokuBoard(); // Inicializa o tabuleiro de Sudoku.
            usedCells = new bool[9, 9]; // Inicializa a matriz de células usadas.
            GenerateNewSudokuBoard(); // Gera um novo tabuleiro de Sudoku.
            BindTextBoxEvents(); // Vincula os eventos às caixas de texto (TextBoxes).

            // Inicializa o timer com intervalo de 1 segundo.
            countdownTimer = new System.Windows.Forms.Timer();
            countdownTimer.Interval = 1000; // 1 segundo
            countdownTimer.Tick += CountdownTimer_Tick; // Adiciona o evento de tick.

            // Inicia o timer com 10 minutos (20 minutos * 60 segundos).
            countdownTimer.Tag = sudoku.Tempo * 60;
            countdownTimer.Start();

            Timer = new Stopwatch(); // Segundo cronômetro
            Timer.Start();
            tempoInicial = DateTime.Now; // Armazena o tempo inicial.
             //double TempoFinall = 0;
        }


        private void InitializeSudokuBoard()
        {
            textBoxes = new List<TextBox>(); // Inicializa a lista de TextBoxes.



            // Inicialize a matriz com os números iniciais do Sudoku
            sudokuGrid = new int[9, 9]

          {
               {0, 0, 0, 0, 0, 0, 0, 0, 0},
               {0, 0, 0, 0, 0, 0, 0, 0, 0},
               {0, 0, 0, 0, 0, 0, 0, 0, 0},
               {0, 0, 0, 0, 0, 0, 0, 0, 0},
               {0, 0, 0, 0, 0, 0, 0, 0, 0},
               {0, 0, 0, 0, 0, 0, 0, 0, 0},
               {0, 0, 0, 0, 0, 0, 0, 0, 0},
               {0, 0, 0, 0, 0, 0, 0, 0, 0},
               {0, 0, 0, 0, 0, 0, 0, 0, 0}
           };

            // Itera sobre os TextBoxes no formulário e vincula o evento de clique a cada um.
            for (int i = 1; i <= 81; i++)
            {
                TextBox textBox = (TextBox)this.Controls.Find("txtbox_" + i, true)[0];
                textBox.Click += txtbox_Click;  // Vincula o evento de clique ao método txtbox_Click.
                textBoxes.Add(textBox);  // Adiciona a caixa de texto à lista.
            }

            // Itera sobre os botões no formulário e vincula o evento de clique a cada um.
            for (int i = 1; i <= 9; i++)
            {
                Button button = (Button)this.Controls.Find("btn_" + i, true)[0];
                button.Click += btn_Click; // Vincula o evento de clique ao método btn_Click.

            }


        }


        private void tela_sudoku_facil_Load(object sender, EventArgs e)
        {

        }
        //timer
        private string Tempo()
        {

           
            // Obtém o tempo decorrido em segundos
            double tempoTotalSegundos = (DateTime.Now - tempoInicial).TotalSeconds;

            // Converte para formato de minutos e segundos (mm:ss)
            TimeSpan tempoFormatado = TimeSpan.FromSeconds(tempoTotalSegundos);

            // Atualiza o texto na label, se necessário
          //  lbl_erros.Text = tempoFormatado.ToString(@"mm\:ss");

            return tempoFormatado.ToString(@"mm\:ss");
        }

        private void TempoF()
        {
           
            string Nivel = sudoku.Nivell;
            string Email = Usuario.Gmail;

            // Obtém o tempo formatado como string
            string TempoFormatado = Tempo();

            try
            {
                using (SqlConnection conexao = sudoku.ObterConexao())
                {
                   

                    string inserir = "INSERT INTO Historico (Email, Tempo, Nivel) VALUES (@Email, @TempoFormatado,@Nivel)";
                    SqlCommand adicionar = new SqlCommand(inserir, conexao);
                    adicionar.Parameters.AddWithValue("@Email", Email);
                    adicionar.Parameters.AddWithValue("@TempoFormatado", TempoFormatado);
                    adicionar.Parameters.AddWithValue("@Nivel", Nivel);

                    adicionar.ExecuteNonQuery();

                    conexao.Close();
                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            // Obtém o tempo restante do tag do timer.
            int remainingTime = (int)countdownTimer.Tag;

            // Atualiza o tempo restante na Label.
            lbl_tempo.Text = $"{remainingTime / 60:00}:{remainingTime % 60:00}";

            // Verifica se o tempo chegou a zero.
            if (remainingTime <= 0)
            {
                // Exibe uma mensagem ou executa alguma ação quando o tempo acabar.
                countdownTimer.Stop(); // Para o timer quando o tempo acabar.
                MessageBox.Show("Tempo esgotado! Jogo encerrado.", "Fim do Jogo");
                tela_inicio tela_Entrar = new tela_inicio();
                tela_Entrar.Show();
                this.Hide();
                
            }
            else
            {
                // Decrementa o tempo restante a cada tick do timer.
                remainingTime--;
                countdownTimer.Tag = remainingTime;
            }
        }

        //cores
        private void BindTextBoxEvents()
        {
            // Este método vincula o evento de clique (Click) a cada TextBox na lista textBoxes.
            foreach (var textBox in textBoxes)
            {
                textBox.Click += txtbox_Click; // Vincula o evento Click a cada TextBox.
            }
        }

        private void HighlightRelatedCells(int row, int col)
        {   // Este método é responsável por realçar as células relacionadas à célula clicada.


            // Restaura a cor padrão das células realçadas anteriormente.
            RestoreCellColors();

            // Realça a linha atual (muda a cor de fundo para azul claro).
            for (int i = 0; i < 9; i++)
            {
                textBoxes[row * 9 + i].BackColor = Color.LightBlue;
            }

            // Realça a coluna atual (muda a cor de fundo para azul claro).
            for (int i = 0; i < 9; i++)
            {
                textBoxes[i * 9 + col].BackColor = Color.LightBlue;
            }

            // Calcula os índices do quadrante.
            int quadrantRow = (row / 3) * 3;
            int quadrantCol = (col / 3) * 3;

            // Realça o quadrante atual (muda a cor de fundo para azul claro).
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    textBoxes[(quadrantRow + i) * 9 + quadrantCol + j].BackColor = Color.LightBlue;
                }
            }

            // Atualiza o TextBox atualmente clicado.
            lastClickedTextBox = textBoxes[row * 9 + col];
        }

        private void RestoreCellColors()
        {
            // Este método restaura a cor de fundo de todas as TextBoxes para a cor padrão do sistema (normalmente branco).
            foreach (var textBox in textBoxes)
            {
                textBox.BackColor = SystemColors.Window;
            }
        }

        // mudar cor button
        private void CheckNumbersOccurrences()
        {
            // Crie uma matriz para contar as ocorrências de cada número de 1 a 9.
            int[] numberOccurrences = new int[10]; // Índices 1 a 9 para números, 0 não será usado.

            // Inicialize a matriz com contagens zero.
            for (int i = 1; i <= 9; i++)
            {
                numberOccurrences[i] = 0;
            }

            // Itere sobre a grade de Sudoku e conte as ocorrências de cada número.
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    int number;
                    if (int.TryParse(textBoxes[row * 9 + col].Text, out number))
                    {
                        if (sudokuGrid[row, col] == number)
                        {
                            // Aumenta a contagem apenas se o número na TextBox for igual ao número correto no Sudoku.
                            numberOccurrences[number]++;
                        }
                        else
                        {

                            // Redefine a cor do botão se o número for incorreto.
                            Button button = (Button)this.Controls.Find("btn_" + number, true)[0];
                            button.BackColor = SystemColors.Control;
                        }
                    }
                }
            }

            // Verifique se algum número ocorre 9 vezes.
            for (int i = 1; i <= 9; i++)
            {
                if (numberOccurrences[i] == 9)
                {
                    // Altere o botão correspondente para a cor cinza.
                    Button button = (Button)this.Controls.Find("btn_" + i, true)[0];
                    button.BackColor = Color.Gray;
                    button.Enabled = false;
                }
            }
        }


       

        //buttons

        private void btn_Click(object sender, EventArgs e)
        { 
            // Converte o objeto sender em um botão (cast).
            Button clickedButton = (Button)sender;
            // Obtém o número do botão clicado (representado pelo texto no botão).
            int number = int.Parse(clickedButton.Text);
  


            if (textBoxSelecionada != null)
            {
                // Obtém o índice da TextBox selecionada na lista de TextBoxes.
                int index = textBoxes.IndexOf(textBoxSelecionada);
                // Calcula a linha e a coluna da TextBox selecionada com base no índice.
                int row = index / 9;
                int col = index % 9;
                // Verifica se o número clicado é igual ao número correto na célula do Sudoku.
                if (sudokuGrid[row, col] == number)
                {
                    // Define o texto da TextBox selecionada como o número clicado.
                    textBoxSelecionada.Text = number.ToString();
                     textBoxSelecionada.Enabled = false;
                }
                else
                {
                    HandleError();
                }
            }
        }

        
        //  regras e novo jogo

        private void GenerateNewSudokuBoard()
        {
            // Limpe o tabuleiro anterior definindo todas as caixas de texto para vazio.
            foreach (TextBox textBox in textBoxes)
            {
                textBox.Text = "";
                textBox.ReadOnly = false; // Defina todas as caixas como editáveis
            }

            // Crie um tabuleiro de Sudoku válido e diferente.
            FillSudoku(0, 0);

            // Mantenha o controle do número de números visíveis definidos.
            int visibleNumbersCount = 0;


            // Preencha aleatoriamente algumas caixas de texto com os novos valores gerados.
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    if (usedCells[row, col] && random.Next(sudoku.Variavel) < 5 && visibleNumbersCount < sudoku.Nivel) // o X é tanto de numeros que vão aparecer e os (10) < 5 e adistribuição pelo tabuleiro, no momento esta de 50% de distribuição quanto mais perto do 5 mais juntos os numeros no tabuleiro esta
                    {
                        // Define o texto da caixa de texto com um número do tabuleiro gerado.
                        textBoxes[row * 9 + col].Text = sudokuGrid[row, col].ToString();
                        textBoxes[row * 9 + col].Enabled = false; // bloqueia os numeros ja saidos para não serem editaveis
                        textBoxes[row * 9 + col].ReadOnly = true; // Torna a caixa de texto somente leitura.
                        visibleNumbersCount++;
                    }
                    else
                    {
                       
                    }
                }
            }
        }

        // preenche o tabuleiro do sudoku
        private bool FillSudoku(int row, int col)
        {
            // Verifica se atingimos a nona linha, o que significa que o tabuleiro está preenchido com sucesso.
            if (row == 9) // Se chegarmos à nona linha, o tabuleiro está preenchido com sucesso.
            {
                return true;
            }
            // Verifica se chegamos ao final da coluna atual e, nesse caso, passa para a próxima linha.
            if (col == 9) // Se chegarmos ao final da coluna, passe para a próxima linha.
            {
                return FillSudoku(row + 1, 0);
            }
            // Cria uma lista de números de 1 a 9.
            List<int> numbers = new List<int>();
            for (int i = 1; i <= 9; i++)
            {
                numbers.Add(i);
            }

            // Embaralhe os números para garantir que a solução seja diferente a cada vez.
            Shuffle(numbers);

            // Itera sobre os números embaralhados e tenta preencher a célula atual.
            foreach (int number in numbers)
            {
                if (IsSafe(row, col, number))
                {
                    // Define o número na célula atual.
                    sudokuGrid[row, col] = number;
                    usedCells[row, col] = true;

                    if (FillSudoku(row, col + 1)) // Tenta preencher a próxima célula usando recursão.
                    {
                        return true;
                    }

                    // Se a próxima célula não puder ser preenchida, volte e tente outro número.
                    sudokuGrid[row, col] = 0;
                    usedCells[row, col] = false;
                }
            }

            return false;
        }

        // Verifica se um número pode ser colocado em uma célula específica do tabuleiro de Sudoku.
        private bool IsSafe(int row, int col, int number)
        {
            // Verifica a linha e a coluna para garantir que o número seja único.
            for (int i = 0; i < 9; i++)
            {
                if (sudokuGrid[row, i] == number || sudokuGrid[i, col] == number)
                {
                    return false; // Retorna falso se o número já estiver presente na linha ou coluna.
                }
            }

            // Verifica o quadrante 3x3 para garantir que o número seja único.
            int startRow = (row / 3) * 3; // Obtém o índice da primeira linha do quadrante.
            int startCol = (col / 3) * 3; // Obtém o índice da primeira coluna do quadrante.
            for (int i = startRow; i < startRow + 3; i++)
            {
                for (int j = startCol; j < startCol + 3; j++)
                {
                    if (sudokuGrid[i, j] == number)
                    {
                        return false; // Retorna falso se o número já estiver presente no quadrante.
                    }
                }
            }

            return true; // Retorna verdadeiro se o número puder ser colocado com segurança na célula.
        }


        // Embaralha uma lista de números.
        private void Shuffle(List<int> list)
        {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--; // Decrementa o contador de elementos na lista.
                int k = rng.Next(n + 1);  // Gera um índice aleatório entre 0 e n (inclusive).
                int value = list[k]; // Obtém o valor na posição k.
                list[k] = list[n]; // Substitui o valor em k pelo último valor não embaralhado.
                list[n] = value; // Define o último valor não embaralhado na posição n (shuffle).
            }
        }
        // sudoku completo
        private void CheckSudokuCompleteness()
        {
            foreach (var textBox in textBoxes)
            {
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    // Se encontrar um TextBox vazio, o Sudoku ainda não está completo.
                    return;
                }
            }

             countdownTimer.Stop(); // Parar o timer quando o Sudoku estiver completo.
            int remainingTime = (int)countdownTimer.Tag;
            int pontosGanhos = CalcularPontosComBaseNoTempo(remainingTime);
            // Incrementa o número de partidas jogadas.
            int partidasJogadasAtual = ObterPartidasJogadasDoBancoDeDados();
            AtualizarPartidasJogadasNoBancoDeDados(partidasJogadasAtual + 1);
            Tempo();
            TempoF();
            MessageBox.Show($"Parabéns! Sudoku Completo! Você recebeu {pontosGanhos} pontos.", "Sudoku Completo");
            AtualizarPontosNoBancoDeDados(pontosGanhos);
            tela_inicio tela_Entrar = new tela_inicio();
            tela_Entrar.Show();
            this.Hide();
        }

        //partidas  
        private int ObterPartidasJogadasDoBancoDeDados()
        {
            string Gmail = Usuario.Gmail;
            try
            {
             
                using (SqlConnection conexao = sudoku.ObterConexao())
                {
                 

                    string consultaPartidasJogadas = "SELECT Partidas FROM Login WHERE Email = @Gmail";
                    SqlCommand commandPartidasJogadas = new SqlCommand(consultaPartidasJogadas, conexao);
                    commandPartidasJogadas.Parameters.AddWithValue("@Gmail", Gmail);

                    object resultado = commandPartidasJogadas.ExecuteScalar();

                    // Verifica se o resultado não é nulo e é convertível para int.
                    if (resultado != null && int.TryParse(resultado.ToString(), out int partidasJogadas))
                    {
                        return partidasJogadas;
                    }
                    else
                    {
                        MessageBox.Show("Falha ao obter o número de partidas jogadas do banco de dados.");
                        return 0; // Ou outro valor padrão, dependendo da sua lógica.
                    }

                    conexao.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter o número de partidas jogadas do banco de dados: " + ex.Message);
                return 0; // Ou outro valor padrão, dependendo da sua lógica.
            }
        }

        // número de partidas jogadas.
        private void AtualizarPartidasJogadasNoBancoDeDados(int partidasJogadas)
        {
            string Gmail = Usuario.Gmail;
            try
            {
              
                using (SqlConnection conexao = sudoku.ObterConexao())
                {
                   

                    string consultaAtualizacaoPartidas = "UPDATE Login SET Partidas = @partidas WHERE Email = @Gmail";
                    SqlCommand commandAtualizacaoPartidas = new SqlCommand(consultaAtualizacaoPartidas, conexao);
                    commandAtualizacaoPartidas.Parameters.AddWithValue("@partidas", partidasJogadas);
                    commandAtualizacaoPartidas.Parameters.AddWithValue("@Gmail", Gmail);

                    int linhasAfetadas = commandAtualizacaoPartidas.ExecuteNonQuery();

                    conexao.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar o número de partidas jogadas no banco de dados: " + ex.Message);
            }
        }       
        private void AtualizarPontosNoBancoDeDados(int pontosGanhos)
        {
            string Gmail = Usuario.Gmail;
            try
            {
              
                using (SqlConnection conexao = sudoku.ObterConexao())
                {
                

                    string consultaAtualizacaoPontos = "UPDATE Login SET Pontos = Pontos + @pontosGanhos WHERE Email = @Gmail";
                    SqlCommand commandAtualizacaoPontos = new SqlCommand(consultaAtualizacaoPontos, conexao);
                    commandAtualizacaoPontos.Parameters.AddWithValue("@pontosGanhos", pontosGanhos);
                    commandAtualizacaoPontos.Parameters.AddWithValue("@Gmail", Gmail);

                    int linhasAfetadas = commandAtualizacaoPontos.ExecuteNonQuery();



                    conexao.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar pontos no banco de dados: " + ex.Message);
            }
        }

        private int CalcularPontosComBaseNoTempo(int remainingTime)
        {
            int fatorDeConversao = 1; 
            int pontos = remainingTime / 60 * fatorDeConversao + sudoku.ponto;

            return pontos;
        }

        //erros
        private void HandleError()
        {
            errorCount++;

            // Atualiza a label com o contador de erros.
            lbl_erros.Text = $"Erros {errorCount}/3";
            lbl_erros.ForeColor = Color.Red;
            this.Update();
            Thread.Sleep(500);
            lbl_erros.ForeColor = Color.Black;
            this.Update();


            // Verifica se atingiu o limite de erros (3).
            if (errorCount == 3)
            {
                int partidasJogadasAtual = ObterPartidasJogadasDoBancoDeDados();
                AtualizarPartidasJogadasNoBancoDeDados(partidasJogadasAtual + 1);

                // Exibe a mensagem de perda.
                MessageBox.Show("Você perdeu! Tente novamente.", "Fim do Jogo");
                tela_inicio tela_Entrar = new tela_inicio();
                tela_Entrar.Show();
                this.Hide();

            }
            

        }


        // txtbox click


        private void txtbox_Click(object sender, EventArgs e)
        {

            foreach (var textBox in textBoxes)
            {
                textBox.TextAlign = HorizontalAlignment.Center;
            }

            textBoxSelecionada = (TextBox)sender; // Armazena a TextBox selecionada

            TextBox clickedTextBox = (TextBox)sender; // Obtém a TextBox que foi clicada.
            int index = textBoxes.IndexOf(clickedTextBox); // Encontra o índice dessa TextBox na lista.
            int row = index / 9; // Calcula a linha com base no índice da TextBox.
            int col = index % 9;  // Calcula a coluna com base no índice da TextBox.

            if (sudoku.visual == "1")
            {
                // Realce as células relacionadas ao TextBox clicado.
                HighlightRelatedCells(row, col);
            }

           else
            {
               
            }
        }
        private void txtbox_20_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (!char.IsLetterOrDigit(e.KeyChar)) //Este trecho de código verifica se o caractere pressionado
            {
                e.Handled = true; // Impede que o caractere seja inserido na TextBox.
            }

            if (char.IsLetterOrDigit(e.KeyChar)) //Este trecho de código verifica se o caractere pressionado
            {
                e.Handled = true; // Impede que o caractere seja inserido na TextBox.
            }
        }
        private void btn_voltar_Click(object sender, EventArgs e)
        {
            tela_inicio tela_Entrar = new tela_inicio();
            tela_Entrar.Show();
            this.Hide();
        }

        private void txtbox_20_TextChanged(object sender, EventArgs e)
        {
            CheckSudokuCompleteness();
            CheckNumbersOccurrences(); // Chama a função para verificar as ocorrências dos números.
        }

        private void txtbox_81_BackColorChanged(object sender, EventArgs e)
        {
           
        }

    }
}

// Ranking por nível de dificuldade   ss
// pontuação será os segundos restantes desde o início de uma partida  ss
// colocar mais tempo   ss
// mudar a fomra de por a cor cinza no button   SS
// o messagebox de ganhou ta dando pau  SS
// mudar para o random  deixar cair casos de paridade, ss
// MUDAR PARA UMA VARIAVEL GLOBAL E MUDAR O NIVEL DO SUDOKU  ss


// qmd o notas for ligado coloca a cor dele verde e a dos buttons roxo, e coloca as anotações !!!



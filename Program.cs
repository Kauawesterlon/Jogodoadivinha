namespace Nova_pasta;

class Program
{
    static void Main(string[] args)
    {
        // Variável que controla se o jogador quer jogar novamente
        bool jogarNovamente;

        // Laço do...while para permitir múltiplas partidas
        do
        {
            int numeroSecreto;     // Armazena o número secreto a ser adivinhado
            int tentativa;         // Armazena a tentativa atual do jogador
            int tentativas = 0;    // Contador de tentativas
            string resposta;       // Armazena a resposta do jogador (para jogar novamente ou não)

            // Gera um número aleatório entre 1 e 20
            Random aleatorio = new Random();
            numeroSecreto = aleatorio.Next(1, 21);

            // Mensagens iniciais para o jogador
            Console.WriteLine("Tente adivinhar o número entre 1 e 20.");
            Console.WriteLine("Digite 0 a qualquer momento para desistir.");

            // Loop principal do jogo — continua até o jogador acertar ou desistir
            while (true)
            {
                Console.Write("Informe o número: ");

                // Tenta converter a entrada do jogador para um número inteiro
                if (!int.TryParse(Console.ReadLine(), out tentativa))
                {
                    Console.WriteLine("Entrada inválida. Tente novamente.");
                    continue; // Reinicia o loop se a entrada for inválida
                }

                // Se o jogador digitar 0, ele desiste do jogo
                if (tentativa == 0)
                {
                    Console.WriteLine("Você desistiu do jogo.");
                    break;
                }

                // Verifica se o número está dentro do intervalo permitido
                if (tentativa < 1 || tentativa > 20)
                {
                    Console.WriteLine("Número fora do intervalo. Tente entre 1 e 20.");
                    continue;
                }

                // Incrementa o número de tentativas válidas
                tentativas++;

                // Verifica se o jogador acertou o número
                if (tentativa == numeroSecreto)
                {
                    Console.WriteLine($"Parabéns! Você acertou o número em {tentativas} tentativa(s).");
                    break;
                }
                else if (tentativa < numeroSecreto)
                {
                    Console.WriteLine("O número secreto é MAIOR.");
                }
                else
                {
                    Console.WriteLine("O número secreto é MENOR.");
                }
            }

            // Pergunta se o jogador deseja jogar novamente
            Console.Write("Deseja jogar novamente? (s/n): ");
            resposta = Console.ReadLine().ToLower(); // Converte para minúsculo
            jogarNovamente = (resposta == "s");      // Joga novamente se digitar 's'

        } while (jogarNovamente); // Continua enquanto a pessoa quiser jogar novamente

        Console.WriteLine("Obrigado por jogar!");
    }
}


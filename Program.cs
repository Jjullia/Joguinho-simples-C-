using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int numeroSecreto = random.Next(1, 101); // número entre 1 e 100
        int tentativas = 0;
        int chute = 0;

        Console.WriteLine("Bem-vindo ao jogo de Adivinhação!");
        Console.WriteLine("Tente adivinhar o número secreto entre 1 e 100.");

        while (chute != numeroSecreto)
        {
            Console.Write("\nDigite seu palpite: ");
            string entrada = Console.ReadLine();

            // Valida se o input é número
            if (!int.TryParse(entrada, out chute))
            {
                Console.WriteLine(" Opa, digite apenas números!");
                continue;
            }

            tentativas++;

            if (chute < numeroSecreto)
            {
                Console.WriteLine(" Muito baixo! Tente um número maior.");
            }
            else if (chute > numeroSecreto)
            {
                Console.WriteLine(" Muito alto! Tente um número menor.");
            }
            else
            {
                Console.WriteLine($"\n Parabéns! Você acertou o número {numeroSecreto} em {tentativas} tentativas!");
            }
        }

        Console.WriteLine("\nObrigado por jogar! Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}

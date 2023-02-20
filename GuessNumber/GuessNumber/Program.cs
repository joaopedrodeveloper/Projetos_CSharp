using GuessNumber;
using System;

public class Guess
{
    public static void Main(string[] args)
    {
        bool playAgain = true;
        int num;
        int numMax = 100;
        int numMin = 1;
        int contador = 0;
        string playAgainResponse;

        Random random = new Random();
        GuessTests guess = new GuessTests();

        int rand = random.Next(numMin, numMax);
        while (playAgain) 
        {
            Console.Write("Digite um número entre 1 e 100: ");
            try
            {
                num = guess.Testes();
                Console.Write(num);
                while (num != rand)
                {
                    while (num > 100 || num < 1)
                    {
                        Console.WriteLine("Número inválido!");
                        Console.Write("Digite um número entre 1 e 100: ");
                        num = guess.Testes();
                    }
                    if (num > rand)
                    {
                        Console.WriteLine($"\nO número {num} é muito alto!");
                        Console.Write($"\nDigite um número entre {numMin} e {num}: ");
                        numMax = num;
                        num = guess.Testes(numMin, num);
                        Console.Write(num);
                        contador++;
                    }
                    else if (num < rand)
                    {
                        Console.WriteLine($"\nO número {num} é muito baixo!");
                        Console.Write($"\nDigite um número entre {num} e {numMax}: ");
                        numMin = num;
                        num = guess.Testes(num, numMax);
                        Console.Write(num);
                        contador++;
                    }
                }
                Console.WriteLine("\nParabéns! Você ganhou!");
                Console.WriteLine($"Você precisou de {++contador} chances para acertar o número.");
                Console.Write("Deseja jogar novamente? (y/n): ");
                playAgainResponse = Console.ReadLine().ToUpper();

                while (playAgainResponse != "Y" && playAgainResponse != "N")
                {
                    Console.WriteLine("Digite (y/n)");
                    Console.Write("Deseja jogar novamente? (y/n): ");
                    playAgainResponse = Console.ReadLine().ToUpper();
                }

                switch (playAgainResponse)
                {
                    case "Y":
                        Console.WriteLine("\nRefazendo o jogo!\n");
                        numMin = 1;
                        numMax = 100;
                        rand = random.Next(1, 100);
                        contador = 0;
                        break;
                    case "N":
                        Console.WriteLine("\nFechando o jogo!");
                        playAgain = false;
                        break;
                }
            } 
            catch
            {
                Console.WriteLine("Digite um número!");
            }
        }
    }
}
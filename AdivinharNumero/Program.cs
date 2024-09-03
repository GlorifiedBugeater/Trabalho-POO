using System;

namespace AdivinharNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;

            do
            {
               
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("0) Sair");
                Console.WriteLine("1) Adivinhar número");

                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Por favor, insira um número válido.");
                    continue;
                }

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;

                    case 1:
                        JogoAdivinharNumero();
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

            } while (opcao != 0);
        }

        static void JogoAdivinharNumero()
        {
            var jogo = new AdivinhaNumero();
            bool acertou = false;

            while (!acertou)
            {
                Console.WriteLine("Tente adivinhar o número entre 1 e 100:");

                if (!int.TryParse(Console.ReadLine(), out int tentativa))
                {
                    Console.WriteLine("Por favor, insira um número válido.");
                    continue;
                }

                acertou = jogo.Adivinhar(tentativa);
            }
        }
    }
}

    
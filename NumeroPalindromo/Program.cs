using System;

namespace VerificadorPalindromo
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
                Console.WriteLine("1) Verificar se um número é palíndromo");

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
                        VerificarPalindromo();
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

            } while (opcao != 0);
        }

        static void VerificarPalindromo()
        {
            Console.WriteLine("Digite um número para verificar se é palíndromo:");

            if (!int.TryParse(Console.ReadLine(), out int numero))
            {
                Console.WriteLine("Por favor, insira um número válido.");
                return;
            }

            bool resultado = Palindromo.EPalindromo(numero);
            if (resultado)
            {
                Console.WriteLine("O número é um palíndromo.");
            }
            else
            {
                Console.WriteLine("O número não é um palíndromo.");
            }
        }
    }
}

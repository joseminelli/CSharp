using System;

namespace ConsoleApp1
{
    
    internal class Program
    {
        public static void ColorText(string texto, string cor)
        {
            // tenta converter a string 'cor' pra um valor do enum ConsoleColor
            // o parâmetro 'true' indica que a conversão é insensível a maiúsculas/minúsculas
            // a variável 'consoleColor' vai ser usada para armazenar o resultado da conversão com o 'out' definindo a saída do resultado.
            if (!Enum.TryParse<ConsoleColor>(cor, true, out ConsoleColor consoleColor))
            {
                // lança uma exceção indicando que a cor é inválida se a conversão falhar
                throw new ArgumentException("Cor inválida", nameof(cor));
            }

            Console.ForegroundColor = consoleColor;

            Console.WriteLine(texto);

            // volta a cor original do console
            Console.ResetColor();
        }

        static void Encerrar(string texto = null)
        {
            try
            {
                if (texto != null)
                {
                    Console.WriteLine(texto);
                }
                else
                {
                    Console.WriteLine("Aperte ENTER para sair");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }

            Console.ReadKey();
        }

        static void Main()
        {
            ColorText("Hello, World!", "Magenta");

            char opcao;

            do
            {
                Console.Write("\n Digite a opção desejada: ");
                opcao = Console.ReadKey().KeyChar;
                Console.WriteLine("\n");
                switch (opcao)
                {
                    case '1':
                        Console.WriteLine("Cadastrar");
                        break;
                    case '2':
                        Console.WriteLine("Listar");
                        break;
                    case '3':
                        Console.WriteLine("Sair");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            } while (opcao != '3');

            Encerrar();
        }
    }
}

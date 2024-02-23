using System;
using System.Reflection;
using System.Security.Cryptography;
using System.Threading;

namespace PrimeiroProjeto
{

    internal class Program1
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
                    Console.WriteLine("\nAperte ENTER para sair");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }

            Console.ReadKey();
        }

        static void Delay(int tempo)
        {
            Thread.Sleep(tempo);
        }

        static void BoasVindas()
        {
            ColorText("Bem vindo ao sistema", "green");
            Console.WriteLine("Pressione ENTER para continuar");
            Console.ReadKey();
            Console.Clear();
        }
       
        static void Main()
        {
            BoasVindas();

            Console.Write("Digite seu nome: ");
            String nome = Console.ReadLine();

            int idade;
            try
            {
                do
                {
                    Console.Clear();

                    Console.Write("Digite sua idade: ");
                    idade = Convert.ToInt32(Console.ReadLine());
                } while (idade <= 0 || idade > 99);
            }
            catch (Exception ex)
            {
                ColorText("Erro: " + ex.Message, "red");
                Encerrar();
                return;
            }
            

            Console.Clear();

            Console.Write("Digite o nome da sua Rua: ");
            String rua = Console.ReadLine();

            int numeroDaCasa;
            Console.Clear();
            try
            {
                Console.Write("Digite o número da sua casa: ");
                numeroDaCasa = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                ColorText("Erro: " + ex.Message, "red");
                Encerrar();
                return;
            }

            Console.Clear();

            string genero = "";
            do
            {
                Console.Write("Informe seu gênero");
                ColorText("\n [M] - Masculino", "blue");
                ColorText("\n [F] - Feminino", "Magenta");
                genero = Console.ReadKey().KeyChar.ToString();
                Console.Clear();
            } while (genero != "m" && genero != "f" && genero != "M" && genero != "F" );

            ColorText("Aguarde um momento...", "yellow");
            Delay(2000);
            Console.Clear();

            switch (genero)
            {
                case "m":
                    genero = "Masculino";
                    break;
                case "f":
                    genero = "Feminino";
                    break;
                case "M":
                    genero = "Masculino";
                    break;
                case "F":
                    genero = "Feminino";
                    break;
            }

            Console.WriteLine($"Seu nome é {nome}, você tem {idade} anos, mora na rua {rua}, número {numeroDaCasa} e é do gênero {genero}");

            Encerrar();
        }
    }
}

using System;
using System.Reflection;
using System.Security.Cryptography;
using System.Threading;

namespace PrimeiroProjeto
{
    
    internal class Program1
    {
        

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

        static void Main()
        {
            Console.Write("Digite seu nome: ");
            String nome = Console.ReadLine();

            Console.Clear();

            Console.Write("Digite sua idade: ");    
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.Write("Digite o nome da sua Rua: ");
            String rua = Console.ReadLine();

            Console.Clear();

            Console.Write("Digite o número da sua casa: ");
            int numeroDaCasa = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            string genero = "";
            do
            {
                Console.Write("Informe seu gênero \n [M] - Masculino \n [F] - Feminino\n");
                genero = Console.ReadKey().KeyChar.ToString();
                Console.Clear();
            } while (genero != "m" && genero != "f" && genero != "M" && genero != "F" );

            Console.WriteLine("Aguarde um momento...");
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

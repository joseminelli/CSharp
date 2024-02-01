using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
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
                    Console.WriteLine("Aperte ENTER para sair");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }

            Console.ReadKey(); 
        }


        static void Main(string[] args)
        {
            Console.WriteLine("=== Menu === \n 1 - Cadastrar \n 2 - Listar \n 3 - Sair");
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

using System;
using System.Globalization;

namespace CineCidade
{
    class Program
    {
        static void Main()
        {
            var cultura = new CultureInfo("pt-BR");

            Console.WriteLine("=== CineCidade - Venda de Ingressos ===\n");

            Console.Write("Nome do cliente: ");
            string nome = Console.ReadLine();

            Console.Write("Quantidade de ingressos: ");
            int quantidade = int.Parse(Console.ReadLine());

            Console.Write("Cupom de desconto: ");
            string cupom = Console.ReadLine();

            Console.Write("Idade do cliente: ");
            int idade = int.Parse(Console.ReadLine());
        }
    }
}
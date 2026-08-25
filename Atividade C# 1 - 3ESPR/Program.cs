using System;
using System.Globalization;

namespace CineCidade
{
    class Program
    {
        // Valores fixos do sistema (constantes reutilizáveis)
        const decimal TaxaConveniencia = 5.00m;
        const decimal PrecoIngresso = 25.00m;
        const string CupomValido = "CINEMA10";
        const decimal PercentualDesconto = 0.10m;

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

            decimal custoBruto = TaxaConveniencia + (PrecoIngresso * quantidade);
        }
    }
}
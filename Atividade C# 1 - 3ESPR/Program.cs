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

            decimal desconto = cupom.Trim().Equals(CupomValido, StringComparison.OrdinalIgnoreCase)
                ? custoBruto * PercentualDesconto
                : 0.00m;

            decimal valorFinal = custoBruto - desconto;

            bool elegivelSessaoNoturna = quantidade > 1 && idade >= 18;

            Console.WriteLine("\n=== Resumo da Compra ===");
            Console.WriteLine($"Cliente: {nome.ToUpper()}");
            Console.WriteLine($"Valor bruto: {custoBruto.ToString("C", cultura)}");
            Console.WriteLine($"Desconto: {desconto.ToString("C", cultura)}");
            Console.WriteLine($"Valor final: {valorFinal.ToString("C", cultura)}");
            Console.WriteLine($"Elegível para Sessão Noturna: {elegivelSessaoNoturna}");
        }
    }
}
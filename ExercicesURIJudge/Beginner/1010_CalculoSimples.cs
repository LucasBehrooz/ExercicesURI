using System;
using System.Globalization;

namespace ExercicesURIJudge.Beginner
{
    class _1010_CalculoSimples
    {
        public static void Execute()
        {
            String[] produto1 = Console.ReadLine().Split(' ');
            var codigo1 = int.Parse(produto1[0]);
            var quantidade1 = int.Parse(produto1[1]);
            var preco1 = double.Parse(produto1[2], CultureInfo.InvariantCulture);

            String[] produto2 = Console.ReadLine().Split(' ');
            var codigo2 = int.Parse(produto2[0]);
            var quantidade2 = int.Parse(produto2[1]);
            var preco2 = double.Parse(produto2[2], CultureInfo.InvariantCulture);

            var totalGeral = (quantidade1 * preco1) + (quantidade2 * preco2);

            Console.WriteLine("VALOR A PAGAR: R$ " + totalGeral.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

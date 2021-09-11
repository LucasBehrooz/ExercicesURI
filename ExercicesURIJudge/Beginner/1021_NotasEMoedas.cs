using System;
using System.Globalization;

namespace ExercicesURIJudge.Beginner
{
    class _1021_NotasEMoedas
    {
        public static void Execute()
        {
            double N;
            int quoficiente, resto, notas, moedas;

            N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            resto = (int)(N * 100.0 + 0.5);
            Console.WriteLine("NOTAS:");

            notas = 100;
            quoficiente = resto / (notas * 100);
            Console.WriteLine(quoficiente + " nota(s) de R$ " + notas + ".00");
            resto = resto % (notas * 100);

            notas = 50;
            quoficiente = resto / (notas * 100);
            Console.WriteLine(quoficiente + " nota(s) de R$ " + notas + ".00");
            resto = resto % (notas * 100);

            notas = 20;
            quoficiente = resto / (notas * 100);
            Console.WriteLine(quoficiente + " nota(s) de R$ " + notas + ".00");
            resto = resto % (notas * 100);

            notas = 10;
            quoficiente = resto / (notas * 100);
            Console.WriteLine(quoficiente + " nota(s) de R$ " + notas + ".00");
            resto = resto % (notas * 100);

            notas = 5;
            quoficiente = resto / (notas * 100);
            Console.WriteLine(quoficiente + " nota(s) de R$ " + notas + ".00");
            resto = resto % (notas * 100);

            notas = 2;
            quoficiente = resto / (notas * 100);
            Console.WriteLine(quoficiente + " nota(s) de R$ " + notas + ".00");
            resto = resto % (notas * 100);

            Console.WriteLine("MOEDAS:");
            moedas = 100;
            quoficiente = resto / moedas;
            Console.WriteLine(quoficiente + " moeda(s) de R$ 1.00");
            resto = resto % moedas;

            moedas = 50;
            quoficiente = resto / moedas;
            Console.WriteLine(quoficiente + " moeda(s) de R$ 0.50");
            resto = resto % moedas;

            moedas = 25;
            quoficiente = resto / moedas;
            Console.WriteLine(quoficiente + " moeda(s) de R$ 0.25");
            resto = resto % moedas;

            moedas = 10;
            quoficiente = resto / moedas;
            Console.WriteLine(quoficiente + " moeda(s) de R$ 0.10");
            resto = resto % moedas;

            moedas = 5;
            quoficiente = resto / moedas;
            Console.WriteLine(quoficiente + " moeda(s) de R$ 0.05");
            resto = resto % moedas;

            Console.WriteLine(resto + " moeda(s) de R$ 0.01");
        }
    }
}

//Leia um valor de ponto flutuante com duas casas decimais. Este valor representa um valor monetário. A
//seguir, calcule o menor número de notas e moedas possíveis no qual o valor pode ser decomposto. As
//notas consideradas são de 100, 50, 20, 10, 5, 2. As moedas possíveis são de 1, 0.50, 0.25, 0.10, 0.05 e 0.01.
//A seguir mostre a relação de notas necessárias.

//Entrada
//O arquivo de entrada contém um valor de ponto flutuante N (0 ≤ N ≤ 1000000.00).

//Saída
//Imprima a quantidade mínima de notas e moedas necessárias para trocar o valor inicial, conforme exemplo
//fornecido.

//Obs: Utilize ponto(.) para separar a parte decimal.
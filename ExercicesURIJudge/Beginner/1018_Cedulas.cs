using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicesURIJudge.Beginner
{
    class _1018_Cedulas
    {
        public static void Execute()
        {
            var notas = int.Parse(Console.ReadLine());
            Console.WriteLine(notas);
            Console.WriteLine(notas / 100 + " nota(s) de R$ 100,00");
            var resto = (notas % 100);

            Console.WriteLine(resto / 50 + " nota(s) de R$ 50,00");
            resto = (resto % 50);

            Console.WriteLine(resto / 20 + " nota(s) de R$ 20,00");
            resto = (resto % 20);

            Console.WriteLine(resto / 10 + " nota(s) de R$ 10,00");
            resto = (resto % 10);

            Console.WriteLine(resto / 5 + " nota(s) de R$ 5,00");
            resto = (resto % 5);

            Console.WriteLine(resto / 2 + " nota(s) de R$ 2,00");
            resto = (resto % 2);

            Console.WriteLine(resto / 1 + " nota(s) de R$ 1,00");
        }
    }
}

//Leia um valor inteiro. A seguir, calcule o menor número de notas possíveis (cédulas) no qual o valor
//pode ser decomposto. As notas consideradas são de 100, 50, 20, 10, 5, 2 e 1. A seguir mostre o
//valor lido e a relação de notas necessárias.

//Entrada
//O arquivo de entrada contém um valor inteiro N (0 < N < 1000000).

//Saída
//Imprima o valor lido e, em seguida, a quantidade mínima de notas de cada tipo necessárias, conforme o exemplo
//fornecido. Não esqueça de imprimir o fim de linha após cada linha, caso contrário seu programa apresentará a
//mensagem: “Presentation Error”.
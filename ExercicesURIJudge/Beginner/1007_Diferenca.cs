using System;
using System.Globalization;

namespace ExercicesURIJudge.Beginner
{
    class _1007_Diferenca
    {
        public static void Execute()
        {
            var A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            var B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            var C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            var D = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            var DIFERENCA = (A * B - C * D);

            Console.WriteLine("DIFERENCA = " + DIFERENCA);
        }
    }
}


//Leia quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto de A e B pelo 
//produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).

//Entrada
//O arquivo de entrada contém 4 valores inteiros.

//Saída
//Imprima a mensagem DIFERENCA com todas as letras maiúsculas, conforme exemplo abaixo, com um espaço em 
//branco antes e depois da igualdade.
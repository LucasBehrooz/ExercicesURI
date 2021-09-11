using System;
using System.Globalization;

namespace ExercicesURIJudge.Beginner
{
    class _1036_FormulaDeBhaskara
    {
        public static void Execute()
        {
            String[] valores = Console.ReadLine().Split(' ');
            var A = double.Parse(valores[0]);
            var B = double.Parse(valores[1]);
            var C = double.Parse(valores[2]);

            var delta = Math.Pow(B, 2) - (4 * A * C);

            if (delta < 0 || A == 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                var x1 = (-B + Math.Sqrt(delta)) / (2 * A);
                var x2 = (-B - Math.Sqrt(delta)) / (2 * A);

                Console.WriteLine("R1 = " + x1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + x2.ToString("F5", CultureInfo.InvariantCulture));
            }
        }
    }
}

//Leia 3 valores de ponto flutuante e efetue o cálculo das raízes da equação de Bhaskara. Se não for 
//possível calcular as raízes, mostre a mensagem correspondente “Impossivel calcular”, caso haja uma 
//divisão por 0 ou raiz de numero negativo.

//Entrada
//Leia três valores de ponto flutuante (double) A, B e C.

//Saída
//Se não houver possibilidade de calcular as raízes, apresente a mensagem "Impossivel calcular". Caso 
//contrário, imprima o resultado das raízes com 5 dígitos após o ponto, com uma mensagem correspondente 
//conforme exemplo abaixo. Imprima sempre o final de linha após cada mensagem.

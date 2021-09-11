using System;
using System.Globalization;

namespace ExercicesURIJudge.Beginner
{
    class _1044_Multiplos
    {
        public static void Execute()
        {
            String[] valores = Console.ReadLine().Split(' ');
            var A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            var B = double.Parse(valores[1], CultureInfo.InvariantCulture);

            if (A % B == 0 || B % A == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}

//Leia 2 valores inteiros(A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou 
//"Nao sao Multiplos", indicando se os valores lidos são múltiplos entre si.

//Entrada
//A entrada contém valores inteiros.

//Saída
//A saída deve conter uma das mensagens conforme descrito acima.
